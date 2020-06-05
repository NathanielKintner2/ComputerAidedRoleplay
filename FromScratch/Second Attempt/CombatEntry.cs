using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Second_Attempt.EnchantmentLogic;

namespace Second_Attempt
{
    public partial class CombatEntry : Form
    {
        public CombatEntry()
        {
            InitializeComponent();
            cboBoxNames.DataSource = Utilities.GetCharacterNames();
            cboBoxInCombat.DataSource = CombatHolder.getInCombatCharNames();
            updateRTBWithCharacternames();
        }
        //update character
        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Character update in CombatHolder._inCombatChars) {
                Character c = Utilities.GetCharByName(update.Name);
                CombatHolder.UpdateCharInventorySpellsSkillsEffectsAndStats(c);
            }
            updateRTBWithCharacternames();
            cboBoxInCombat.DataSource = CombatHolder.getInCombatCharNames();
        }

        private void updateRTBWithCharacternames() {
            richTextBox1.Text = "";
            foreach (Character Fit in CombatHolder._inCombatChars)
            {
                richTextBox1.Text += Fit.CombatStuff.CombatName + " " + Fit.HitPoints + "\n";
            }
        }
        //go to next form
        private void button2_Click(object sender, EventArgs e)
        {
            
            
            MasterDeclarations frmCreator = new MasterDeclarations();
            CombatEntry frmRemover = this;           
            frmCreator.Show();
            frmRemover.Hide();            
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (cboBoxInCombat.Text == "")
            {
                MessageBox.Show("Please Enter A Character");
                return;
            }
            Character found = CombatHolder._inCombatChars.Find(FitChar => cboBoxInCombat.Text == FitChar.CombatStuff.CombatName);

            if (found != null)
            {
                
                CombatHolder._inCombatChars.Remove(found);
            }
            updateRTBWithCharacternames();
            cboBoxInCombat.DataSource = CombatHolder.getInCombatCharNames();
        }
        //add character
        private void button3_Click(object sender, EventArgs e)
        {            
            if (cboBoxNames.Text == "")
            {
                MessageBox.Show("Please Enter A Character");
                return;
            }
            Character charToAdd = Utilities.GetCharByName(cboBoxNames.Text);
            if (!charToAdd.Weapons.Any() || !charToAdd.Shields.Any())
            {
                return;
            }
            charToAdd.CombatStuff.CombatWeapon = charToAdd.Weapons[0];
            charToAdd.CombatStuff.CombatShield = charToAdd.Shields[0];
            List<Character> found = CombatHolder._inCombatChars.FindAll(FitChar => cboBoxNames.Text == FitChar.Name);
            int appendnum = found.Count + 1;
            //while there is a character that has the same combatname
            while (CombatHolder._inCombatChars.FindAll(FitChar => charToAdd.Name + appendnum == FitChar.CombatStuff.CombatName).Count != 0) {
                appendnum++;
            }
            charToAdd.CombatStuff.CombatName = charToAdd.Name + appendnum;
            charToAdd.Stamina = CombatScripts.GetBaseStamina(charToAdd);
            charToAdd.HitPoints = CombatScripts.GetBaseHealth(charToAdd);
            charToAdd.CombatStuff.targets = new List<Character>();
            CombatHolder._inCombatChars.Add(charToAdd);

            EnchantmentUtilities.triggerAllEnchantmentsForChar(charToAdd, new EnchantmentParameters() { triggerSource = EnchantmentUtilities.SourceTypes.CombatEntry });

            updateRTBWithCharacternames();
            cboBoxInCombat.DataSource = CombatHolder.getInCombatCharNames();
        }
    }
}
