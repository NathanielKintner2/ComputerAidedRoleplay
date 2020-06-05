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
using Second_Attempt.EnchantmentLogic;
namespace Second_Attempt
{
    public partial class CharCreator : Form
    {
        Character SaveCharacter = new Character();
        string saveSheetID = "";

        public CharCreator()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
            comboBox1.DataSource = Utilities.GetCharacterNames();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged -= comboBox2_SelectedIndexChanged;
            comboBox2.DataSource = Enum.GetValues(typeof(Utilities.CreatureType));
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            //setting the data source fires the getChar stuff, makes blechk
            txtBoxName.Text = "";
            txtBoxStrength.Text = "";
            txtBoxDexterity.Text = "";
            txtBoxConstitution.Text = "";
            txtBoxIntelligence.Text = "";
            txtBoxWisdom.Text = "";
            txtBoxCharisma.Text = "";
            txtBoxEnduranceSkill.Text = "";
            txtBoxHPSkill.Text = "";
            txtBoxReflexSkill.Text = "";
            txtBoxArmorSkill.Text = "";
            txtBoxPerceptionSkill.Text = "";
            rtbCharStuff.Text = "";
            richTextBoxDescription.Text = "";
        }
        //save the character
        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateAll())
                return;
            //Validation routines do all null checks so we don't need to do them below.

            Character newChar = new Character();
            //used to save old weapons and shields. will not apply to new chars.
            if (File.Exists("Data\\Characters\\" + txtBoxName.Text + ".xml"))
            {
                newChar = SaveCharacter;
            }
            else
            {
                newChar.CreatureTypes = SaveCharacter.CreatureTypes;
            }
            newChar.Name = txtBoxName.Text;
            newChar.Description = richTextBoxDescription.Text;
            newChar.Statistics.Strength =  Convert.ToInt32(txtBoxStrength.Text);
            newChar.Statistics.Dexterity = Convert.ToInt32(txtBoxDexterity.Text);
            newChar.Statistics.Constitution = Convert.ToInt32(txtBoxConstitution.Text);
            newChar.Statistics.Intelligence = Convert.ToInt32(txtBoxIntelligence.Text);
            newChar.Statistics.Wisdom = Convert.ToInt32(txtBoxWisdom.Text);
            newChar.Statistics.Charisma = Convert.ToInt32(txtBoxCharisma.Text);
            newChar.Skills.HPSkill = Convert.ToInt32(txtBoxHPSkill.Text);
            newChar.Skills.ReflexSkill = Convert.ToInt32(txtBoxReflexSkill.Text);
            newChar.Skills.ArmorSkill = Convert.ToInt32(txtBoxArmorSkill.Text);
            newChar.Skills.EnduranceSkill = Convert.ToInt32(txtBoxEnduranceSkill.Text);
            newChar.Skills.PerceptionSkill = Convert.ToInt32(txtBoxPerceptionSkill.Text);
            

            Utilities.SaveCharacter(newChar);
            comboBox1.DataSource = Utilities.GetCharacterNames();
            comboBox1.SelectedItem = newChar.Name;
        }    

       

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBoxName.Text = "";
            txtBoxStrength.Text = "";
            txtBoxDexterity.Text = "";
            txtBoxConstitution.Text = "";
            txtBoxIntelligence.Text = "";
            txtBoxWisdom.Text = "";
            txtBoxCharisma.Text = "";
            txtBoxHPSkill.Text = "";
            txtBoxReflexSkill.Text = "";
            txtBoxEnduranceSkill.Text = "";
            txtBoxArmorSkill.Text = "";
            txtBoxPerceptionSkill.Text = "";
        }     
        

        #region Validation
       

        private bool ValidateAll()
        {
            if (!Utilities.ValidateIntTextBox(txtBoxArmorSkill.Text))
                return false;
            if (!Utilities.ValidateIntTextBox(txtBoxStrength.Text))
                return false;
            if (!Utilities.ValidateIntTextBox(txtBoxDexterity.Text))
                return false;
            if (!Utilities.ValidateIntTextBox(txtBoxConstitution.Text))
                return false;
            if (!Utilities.ValidateIntTextBox(txtBoxWisdom.Text))
                return false;
            if (!Utilities.ValidateIntTextBox(txtBoxIntelligence.Text))
                return false;
            if (!Utilities.ValidateIntTextBox(txtBoxCharisma.Text))
                return false;
            if (!Utilities.ValidateIntTextBox(txtBoxHPSkill.Text))
                return false;
            if (!Utilities.ValidateIntTextBox(txtBoxReflexSkill.Text))
                return false;
            if (!Utilities.ValidateIntTextBox(txtBoxEnduranceSkill.Text))
                return false;
            //All valid!
            return true;
        }
        
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Character currentChar = Utilities.GetCharByName(comboBox1.Text);
            SaveCharacter = currentChar;
            saveSheetID = currentChar.CharTypeTag;
            txtBoxName.Text = currentChar.Name;
            txtBoxStrength.Text = Convert.ToString(currentChar.Statistics.Strength);
            txtBoxDexterity.Text = Convert.ToString(currentChar.Statistics.Dexterity);
            txtBoxConstitution.Text = Convert.ToString(currentChar.Statistics.Constitution);
            txtBoxIntelligence.Text = Convert.ToString(currentChar.Statistics.Intelligence);
            txtBoxWisdom.Text = Convert.ToString(currentChar.Statistics.Wisdom);
            txtBoxCharisma.Text = Convert.ToString(currentChar.Statistics.Charisma);
            txtBoxHPSkill.Text = Convert.ToString(currentChar.Skills.HPSkill);
            txtBoxReflexSkill.Text = Convert.ToString(currentChar.Skills.ReflexSkill);
            txtBoxArmorSkill.Text = Convert.ToString(currentChar.Skills.ArmorSkill);
            txtBoxEnduranceSkill.Text = Convert.ToString(currentChar.Skills.EnduranceSkill);
            txtBoxPerceptionSkill.Text = Convert.ToString(currentChar.Skills.PerceptionSkill);
            richTextBoxDescription.Text = currentChar.Description;
            chkBoxTracked.Checked = currentChar.CharTypeTag != "";
            UpdateRichTextBox(SaveCharacter);

        }

        private void UpdateRichTextBox(Character currentChar)
        {
            rtbCharStuff.Text = "";

            rtbCharStuff.Text += "Creature Types:\n";
            foreach (Utilities.CreatureType ct in currentChar.CreatureTypes)
            {
                rtbCharStuff.Text += ct.ToString() + "\n";
            }
            rtbCharStuff.Text += "\nArmor:\n";
            foreach(Armor arm in currentChar.Armor)
            {
                rtbCharStuff.Text += arm.ToString() + "\n";
            }
            rtbCharStuff.Text += "\nWeapons:\n";
            foreach (Weapon w in currentChar.Weapons)
            {
                rtbCharStuff.Text += w.ToString() + "\n";
            }
            rtbCharStuff.Text += "\nShields:\n";
            foreach (Shield s in currentChar.Shields)
            {
                rtbCharStuff.Text += s.ToString() + "\n";
            }
            rtbCharStuff.Text += "\nOther Items:\n";
            foreach (Item i in currentChar.Items)
            {
                rtbCharStuff.Text += i.ToString() + "\n";
            }
            rtbCharStuff.Text += "\nBag:\n";
            foreach (Item i in currentChar.Inventory)
            {
                if(!i.IsEquipped)
                    rtbCharStuff.Text += i.ToString() + "\n";
            }
            rtbCharStuff.Text += "\nSpells:\n";
            foreach (Spell s in currentChar.Spells)
            {
                rtbCharStuff.Text += s.SpellName + "\n";
            }
            rtbCharStuff.Text += "\nEnchantments:\n";
            foreach (EnchantmentLogic.IfElseLogic iel in currentChar.Enchantments.Keys)
            {
                rtbCharStuff.Text += iel.Name + "\n";
            }
        }

        private void txtBoxDexterity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxConstitution_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxIntelligence_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxWisdom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxCharisma_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxHPSkill_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxReflexSkill_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxArmorSkill_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxArmorWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxArmorQuality_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxArmorType_TextChanged(object sender, EventArgs e)
        {

        }

        private void CharCreator_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxStrength_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblDexterity_Click(object sender, EventArgs e)
        {

        }

        private void lblConstitution_Click(object sender, EventArgs e)
        {

        }

        private void lblIntelligence_Click(object sender, EventArgs e)
        {

        }

        private void lblWisdom_Click(object sender, EventArgs e)
        {

        }

        private void lblCharisma_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblStrength_Click(object sender, EventArgs e)
        {

        }
        //creature types
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utilities.CreatureType ty;
            Enum.TryParse(comboBox2.Text, out ty);
            if (SaveCharacter.CreatureTypes.Contains(ty))
            {
                SaveCharacter.CreatureTypes.Remove(ty);
            } else
            {
                SaveCharacter.CreatureTypes.Add(ty);
            }
            
            UpdateRichTextBox(SaveCharacter);
        }
    }
}
