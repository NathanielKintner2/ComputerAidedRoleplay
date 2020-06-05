using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Second_Attempt
{
    public partial class CombatDeclarations : Form
    {
        Character ThisChar = new Character();
        public CombatDeclarations(Character DeclaringChar)
        {
            InitializeComponent();
            ThisChar = DeclaringChar;
            RefreshThisCharacter();
        }

        public void RefreshThisCharacter() {
            this.Text = ThisChar.CombatStuff.CombatName;
            lblOB.Text = "+( " + Convert.ToString(EffectHolder.GetValidEffectsByEffect(ThisChar, EffectHolder.EffectType.OB)) + " )";
            lblDB.Text = "+( " + Convert.ToString(EffectHolder.GetValidEffectsByEffect(ThisChar, EffectHolder.EffectType.DB)) + " )";
            lblFB.Text = "+( " + Convert.ToString(Convert.ToDouble(EffectHolder.GetValidEffectsByEffect(ThisChar, EffectHolder.EffectType.Dexterity)) / 2) + " )";
            txtBoxHP.Text = Convert.ToString(ThisChar.HitPoints + EffectHolder.GetValidEffectsByEffect(ThisChar, EffectHolder.EffectType.Health));
            txtBoxStamina.Text = Convert.ToString(ThisChar.Stamina);
            richTextBox1.Text = Utilities.translateCharacterStatusToDisplayString(ThisChar) + "\n\n";
            rtbLastDefenses.Text = "";
            foreach (Effect ef in ThisChar.TemporaryEffects)
            {
                richTextBox1.Text += ef.getDisplayString();
            }
            if (ThisChar.CombatStuff.defendResultsForDisplay != null &&
                ThisChar.CombatStuff.defendResultsForDisplay.Any())
            {
                foreach (List<String> lststr in ThisChar.CombatStuff.defendResultsForDisplay) {
                    rtbLastDefenses.Text += lststr[1] + "\n";
                    rtbLastDefenses.Text += lststr[2] + "\n";
                    if (lststr.Count > 10) {
                        rtbLastDefenses.Text += lststr[10] + "\n";
                    }
                    rtbLastDefenses.Text += "\n";
                }
                
            }
            rtbInbound.Text = "This Character's Message: \n";
            rtbInbound.Text += ThisChar.GoogleNinjaNotesInbound;
            rtbInbound.Text += "\n\nOther Messages To This Character:\n" + ThisChar.GoogleNinjaNotesRebound;
            rtbOutbound.Text = ThisChar.GoogleNinjaNotesOutbound;
            
            List<Weapon> WeaponList = ThisChar.Weapons;
            List<Shield> ShieldList = ThisChar.Shields;
            cboBoxWeapon.SelectedIndex = -1;
            cboBoxShield.SelectedIndex = -1;
            cboBoxWeapon.Items.Clear();
            cboBoxShield.Items.Clear();
            foreach (Weapon NowWep in WeaponList)
            {
                cboBoxWeapon.Items.Add(NowWep.ItemName);
            }
            foreach (Shield NowShield in ShieldList)
            {
                cboBoxShield.Items.Add(NowShield.ItemName);
            }
            if (cboBoxWeapon.Items.Count != 0)
            {
                cboBoxWeapon.SelectedIndex = 0;
            }
            if (cboBoxShield.Items.Count != 0)
            {
                cboBoxShield.SelectedIndex = 0;
            }
            if (!(ThisChar.CombatStuff.CombatWeapon == null))
            {
                cboBoxShield.Text = ThisChar.CombatStuff.CombatShield.ItemName;
                cboBoxWeapon.Text = ThisChar.CombatStuff.CombatWeapon.ItemName;
                txtBoxDB.Text = Convert.ToString(ThisChar.CombatStuff.CombatDB);
                txtBoxOB.Text = Convert.ToString(ThisChar.CombatStuff.CombatOB);
            }

            
            SetColorCorrectly();
        }
        private bool ValidateDoubleOrNegativeTextBox(string strText)
        {
            Regex reDigitsOnly = new Regex(@"^[\d\.\-]+$");
            if (reDigitsOnly.IsMatch(strText))
            {
                return true;
            }
            else
            {
                MessageBox.Show("All entries must be in correct form.  Please fix.", "YOU DONE GOOFED");
                return false;
            }
        }
        private bool ValidateIntTextBox(string strText)
        {
            Regex reDigitsOnly = new Regex(@"^[\d]+$");
            if (reDigitsOnly.IsMatch(strText))
            {
                return true;
            }
            else
            {
                MessageBox.Show("All entries must be in correct form.  Please fix.", "YOU DONE GOOFED");
                return false;
            }
        }
        private bool ValidateBoolTextBox(string strText)
        {
            
            if (strText == "True")
            {
                return true;
            }
            if (strText == "False")
            {
                return true; 
            }
            else
            {
                MessageBox.Show("All entries must be in correct form.  Please fix.", "YOU DONE GOOFED");
                return false;
            }
        }
       
             
           //save button
        private void button1_Click(object sender, EventArgs e)
        {
            ThisChar.CombatStuff.readyForCombat = true;
            SaveChar();
            //frmRemover.Hide();

        }
        //add attack button
        private void btnIndividualAttack_Click(object sender, EventArgs e)
        {            
            if (SaveChar()) {
                if (CombatHolder._alreadyAttackedThisRound.Contains(ThisChar))
                {
                    CombatHolder._alreadyAttackedThisRound.Remove(ThisChar);
                }
                else
                {
                    ThisChar.CombatStuff.readyForCombat = true;
                    CombatHolder.toggleCharAttack(ThisChar);
                }
                SetColorCorrectly();
                CombatHolder._masterOfDeclarations.UpdateRTB();
            }
        }

        private Boolean SaveChar() {
            if (!Utilities.ValidateComboBox(cboBoxWeapon.Text))
                return false;
            if (!Utilities.ValidateDoubleOrNegativeTextBox(txtBoxOB.Text))
                return false;
            if (!Utilities.ValidateDoubleOrNegativeTextBox(txtBoxDB.Text))
                return false;
            if (!Utilities.ValidateDoubleOrNegativeTextBox(txtBoxHP.Text))
                return false;
            if (!Utilities.ValidateDoubleOrNegativeTextBox(txtBoxStamina.Text))
                return false;

            ThisChar.CombatStuff.CombatDB = Convert.ToDouble(txtBoxDB.Text);
            ThisChar.CombatStuff.CombatOB = Convert.ToDouble(txtBoxOB.Text);
            ThisChar.CombatStuff.CombatWeapon = ThisChar.Weapons.Find(A => A.ItemName == cboBoxWeapon.Text);
            ThisChar.CombatStuff.CombatShield = ThisChar.Shields.Find(A => A.ItemName == cboBoxShield.Text);
            //ThisChar.Armor = Utilities.GetArmorByName(ThisChar.Armor.ArmorName);
            ThisChar.HitPoints = Convert.ToDouble(txtBoxHP.Text) - EffectHolder.GetValidEffectsByEffect(ThisChar, EffectHolder.EffectType.Health);
            ThisChar.Stamina = Convert.ToDouble(txtBoxStamina.Text);
            ThisChar.GoogleNinjaNotesOutbound = rtbOutbound.Text;

            CombatHolder._masterOfDeclarations.UpdateRTB();
            return true;
        }

        private void SetColorCorrectly()
        {
            if (CombatHolder._makingAttackChars.Contains(ThisChar))
            {
                this.BackColor = Color.Red;
                btnIndividualAttack.Text = "Remove Attack";
            }
            else if (CombatHolder._alreadyAttackedThisRound.Contains(ThisChar))
            {
                this.BackColor = Color.Gray;
                btnIndividualAttack.Text = "Allow Attack";
            }
            else
            {
                this.BackColor = Color.Green;
                btnIndividualAttack.Text = "Add Attack";
            }
        }


    }
}
