using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
namespace Second_Attempt
{
    public partial class WeaponCreator : Form
    {
        Weapon SaveWeapon = new Weapon();
        public WeaponCreator()
        {
            InitializeComponent();
            cboBoxWeapons.SelectedIndexChanged -= cboBoxWeapons_SelectedIndexChanged;
            cboBoxWeapons.DataSource = Utilities.GetWeaponNames();
            cboBoxWeapons.SelectedIndexChanged += cboBoxWeapons_SelectedIndexChanged;
            cboBoxDamageType.DataSource = Enum.GetValues(typeof(Utilities.DamageType));
            comboBoxWeaponType.SelectedIndexChanged -= comboBoxWeaponType_SelectedIndexChanged;
            comboBoxWeaponType.DataSource = Enum.GetValues(typeof(Utilities.WeaponType));
            comboBoxWeaponType.SelectedIndexChanged += comboBoxWeaponType_SelectedIndexChanged;
        }

        #region Validation
        
        private bool ValidateAll()
        {
            if (!Utilities.ValidateDoubleTextBox(txtBoxWeight.Text))
                return false;
            if (!Utilities.ValidateDoubleOrNegativeTextBox(txtBoxOffensiveBonus.Text))
                return false;
            if (!Utilities.ValidateDoubleOrNegativeTextBox(txtBoxDefensiveBonus.Text))
                return false;
            if (!Utilities.ValidateDoubleTextBox(txtBoxBlockingDifficulty.Text))
                return false;
            if (!Utilities.ValidateDoubleTextBox(txtBoxParryStrength.Text))
                return false;
            if (!Utilities.ValidateDoubleTextBox(txtBoxParryBreak.Text))
                return false;
            if (!Utilities.ValidateDoubleTextBox(txtBoxExcessStrengthMultiplier.Text))
                return false;
            if (!Utilities.ValidateDoubleTextBox(txtBoxStaminaReq.Text))
                return false;
                
            //All valid!
            return true;
        }

        #endregion

        private void buttonSaveWeapon_Click(object sender, EventArgs e)
        {
            if (!ValidateAll())
                return;

            Weapon newWeapon = new Weapon() { DamageTypes = SaveWeapon.DamageTypes, WeaponTypes = SaveWeapon.WeaponTypes };
            if (Utilities.GetWeaponNames().Contains(txtBoxWepName.Text))
            {
                newWeapon = SaveWeapon;
            }
            newWeapon.Description = rtbWeaponDescription.Text;
            newWeapon.ItemName = txtBoxWepName.Text;
            newWeapon.Weight = Convert.ToDouble(txtBoxWeight.Text);
            newWeapon.OffensiveBonus = Convert.ToDouble(txtBoxOffensiveBonus.Text);
            newWeapon.DefensiveBonus = Convert.ToDouble(txtBoxDefensiveBonus.Text);
            newWeapon.BlockingDifficulty = Convert.ToDouble(txtBoxBlockingDifficulty.Text);
            newWeapon.ParryStrength = Convert.ToDouble(txtBoxParryStrength.Text);
            newWeapon.ParryBreak = Convert.ToDouble(txtBoxParryBreak.Text);
            newWeapon.ExcessStrengthMultiplier = Convert.ToDouble(txtBoxExcessStrengthMultiplier.Text);
            newWeapon.StaminaRequirement = Convert.ToInt32(txtBoxStaminaReq.Text);



            Utilities.SaveWeapon(newWeapon);            
            cboBoxWeapons.DataSource = Utilities.GetWeaponNames();
            cboBoxWeapons.SelectedItem = newWeapon.ItemName;

        }

        


        private void cboBoxWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveWeapon = Utilities.GetWeaponByName(cboBoxWeapons.Text);
            txtBoxWepName.Text = SaveWeapon.ItemName;
            rtbWeaponDescription.Text = SaveWeapon.Description;
            txtBoxWeight.Text = Convert.ToString(SaveWeapon.Weight);
            txtBoxOffensiveBonus.Text = Convert.ToString(SaveWeapon.OffensiveBonus);
            txtBoxDefensiveBonus.Text = Convert.ToString(SaveWeapon.DefensiveBonus);            
            txtBoxBlockingDifficulty.Text = Convert.ToString(SaveWeapon.BlockingDifficulty);
            txtBoxParryStrength.Text = Convert.ToString(SaveWeapon.ParryStrength);
            txtBoxParryBreak.Text = Convert.ToString(SaveWeapon.ParryBreak);
            txtBoxExcessStrengthMultiplier.Text = Convert.ToString(SaveWeapon.ExcessStrengthMultiplier);
            txtBoxStaminaReq.Text = SaveWeapon.StaminaRequirement.ToString();
            txtBoxEfficacy.Text = "";
            cboBoxDamageType.SelectedIndex = -1;
            writeDamageTypes();
            updateRTB();
            
        }

        private void updateRTB()
        {
            richTextBoxTechnicalDescription.Text = SaveWeapon.TechnicalDescription();
            richTextBoxTechnicalDescription.Text += "\nWeapon Types:\n";
            foreach (Utilities.WeaponType wt in SaveWeapon.WeaponTypes)
            {
                richTextBoxTechnicalDescription.Text += wt.ToString() + "\n";
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBoxWepName.Text = "";
            txtBoxWeight.Text = "";
            txtBoxOffensiveBonus.Text = "";
            txtBoxDefensiveBonus.Text = "";
            txtBoxEfficacy.Text = "";
            cboBoxDamageType.Text = "";
            txtBoxBlockingDifficulty.Text = "";
            txtBoxParryStrength.Text = "";
            txtBoxParryBreak.Text = "";
            txtBoxExcessStrengthMultiplier.Text = "";
            txtBoxStaminaReq.Text = "";
            cboBoxDamageType.SelectedIndex = -1;
            rtbDamageTypes.Text = "";
            rtbWeaponDescription.Text = "";
        }

        private void WeaponCreator_Load(object sender, EventArgs e)
        {

        }

        private void buttonChangeDamage_Click(object sender, EventArgs e)
        {
            if (!Utilities.ValidateComboBox(cboBoxDamageType.Text))
                return;
            if (!Utilities.ValidateDoubleTextBox(txtBoxEfficacy.Text))
                return;
            //get the appropriate enum version of the damage type
            Utilities.DamageType myStatus;
            Enum.TryParse(cboBoxDamageType.Text, out myStatus);
            //if the efficacy is zero, remove it from the dictionary of damage types
            if (Convert.ToDouble(txtBoxEfficacy.Text) == 0.0) {
                SaveWeapon.DamageTypes.Remove(myStatus);
            }
            //otherwise, add or update it
            else if (SaveWeapon.DamageTypes.ContainsKey(myStatus))
            {
                SaveWeapon.DamageTypes[myStatus] = Convert.ToDouble(txtBoxEfficacy.Text);
            }
            else {
                SaveWeapon.DamageTypes.Add(myStatus, Convert.ToDouble(txtBoxEfficacy.Text));
            }
            writeDamageTypes();
        }

        private void writeDamageTypes() {
            rtbDamageTypes.Text = "";
            foreach (Utilities.DamageType dt in SaveWeapon.DamageTypes.Keys) {
                rtbDamageTypes.Text += dt.ToString() + "\t" + SaveWeapon.DamageTypes[dt].ToString() + "\n";
            }
        }
        
        private void comboBoxWeaponType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utilities.WeaponType wt = (Utilities.WeaponType)comboBoxWeaponType.SelectedItem;
            if (SaveWeapon.WeaponTypes.Contains(wt))
            {
                SaveWeapon.WeaponTypes.Remove(wt);
            }
            else
            {
                SaveWeapon.WeaponTypes.Add(wt);
            }
            updateRTB();
        }
    }
}
