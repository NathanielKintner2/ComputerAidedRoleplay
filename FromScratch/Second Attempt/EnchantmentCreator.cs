using Second_Attempt.EnchantmentLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Second_Attempt
{
    public partial class EnchantmentCreator : Form
    {
        bool doneWithInit = false;
        Dictionary<IfElseLogic, Dictionary<String, Object>> saveEnchantmentCollection = new Dictionary<IfElseLogic, Dictionary<string, object>>();
        public EnchantmentCreator()
        {
            InitializeComponent();
            comboBoxEnchantments.DataSource = Utilities.GetEnchantmentNames();
            comboBoxType.DataSource = Enum.GetValues(typeof(Utilities.EffectableTypes));
            doneWithInit = true;
            updateAlreadyAssignedChoices();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            IfElseLogicForm frmCreator = new IfElseLogicForm(new IfElseLogic());
            frmCreator.Setup(new IfElseLogic());
            frmCreator.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            IfElseLogicForm frmCreator = new IfElseLogicForm(Utilities.GetEnchantmentByName(comboBoxEnchantments.Text));
            frmCreator.Setup(frmCreator.Data());
            frmCreator.Show();
        }

        private void saveListInCorrectPlace()
        {
            if (Utilities.EffectableTypes.Character == (Utilities.EffectableTypes)comboBoxType.SelectedItem)
            {
                Character c = Utilities.GetCharByName(comboBoxTargets.Text);
                c.Enchantments = saveEnchantmentCollection;
                Utilities.SaveCharacter(c);
            }
            else
            {
                Item currentItem = new Item();
                if (comboBoxType.Text == "Item")
                    currentItem = Utilities.GetItemByName(comboBoxTargets.Text);
                if (comboBoxType.Text == "Shield")
                    currentItem = Utilities.GetShieldByName(comboBoxTargets.Text);
                if (comboBoxType.Text == "Weapon")
                    currentItem = Utilities.GetWeaponByName(comboBoxTargets.Text);
                if (comboBoxType.Text == "Armor")
                    currentItem = Utilities.GetArmorByName(comboBoxTargets.Text);
                
                currentItem.Enchantments = saveEnchantmentCollection;

                if (comboBoxType.Text == "Item")
                    Utilities.SaveItem(currentItem);
                if (comboBoxType.Text == "Shield")
                    Utilities.SaveShield((Shield)currentItem);
                if (comboBoxType.Text == "Weapon")
                    Utilities.SaveWeapon((Weapon)currentItem);
                if (comboBoxType.Text == "Armor")
                    Utilities.SaveArmor((Armor)currentItem);
            }
        }

        private void buttonAssignment_Click(object sender, EventArgs e)
        {
            IfElseLogic ench = Utilities.GetEnchantmentByName(comboBoxEnchantments.Text);
            saveEnchantmentCollection.Add(ench, readParamRTB());
            saveListInCorrectPlace();
            updateAlreadyAssignedChoices();
        }

        private void buttonUnassignment_Click(object sender, EventArgs e)
        {
            if(comboBoxAlreadyAssigned.SelectedItem != null)
            {
                saveEnchantmentCollection.Remove((IfElseLogic)comboBoxAlreadyAssigned.SelectedItem);
                saveListInCorrectPlace();
                updateAlreadyAssignedChoices();
            }
        }

        private Dictionary<String, Object> readParamRTB()
        {
            Dictionary<String, Object> ret = new Dictionary<string, Object>();
            string[] lines = richTextBoxParams.Text.Split('\n');
            foreach (string str in lines)
            {
                string[] line = str.Split(null);
                if(line.Length < 2)
                {
                    continue;
                }
                string name = line[0].Trim();
                ret[name] = line[line.Length - 1].Replace('_', ' ');
            }
            return ret;
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Utilities.EffectableTypes.Character == (Utilities.EffectableTypes)comboBoxType.SelectedItem)
            {
                comboBoxTargets.DataSource = Utilities.GetCharacterNames();
            }
            else
            {
                if (comboBoxType.Text == "Item")
                    comboBoxTargets.DataSource = Utilities.GetItemNames();
                if (comboBoxType.Text == "Shield")
                    comboBoxTargets.DataSource = Utilities.GetShieldNames();
                if (comboBoxType.Text == "Weapon")
                    comboBoxTargets.DataSource = Utilities.GetWeaponNames();
                if (comboBoxType.Text == "Armor")
                    comboBoxTargets.DataSource = Utilities.GetArmorNames();
            }
        }

        private void comboBoxEnchantments_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateAlreadyAssignedChoices();
        }

        private void comboBoxTargets_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateAlreadyAssignedChoices();
        }

        private void updateAlreadyAssignedChoices()
        {
            if (!doneWithInit)
                return;
            IfElseLogic ench = Utilities.GetEnchantmentByName(comboBoxEnchantments.Text);

            if (Utilities.EffectableTypes.Character == (Utilities.EffectableTypes)comboBoxType.SelectedItem)
            {
                Character c = Utilities.GetCharByName(comboBoxTargets.Text);
                saveEnchantmentCollection = c.Enchantments;
            }
            else
            {
                Item currentItem = new Item();
                if (comboBoxType.Text == "Item")
                    currentItem = Utilities.GetItemByName(comboBoxTargets.Text);
                if (comboBoxType.Text == "Shield")
                    currentItem = Utilities.GetShieldByName(comboBoxTargets.Text);
                if (comboBoxType.Text == "Weapon")
                    currentItem = Utilities.GetWeaponByName(comboBoxTargets.Text);
                if (comboBoxType.Text == "Armor")
                    currentItem = Utilities.GetArmorByName(comboBoxTargets.Text);

                saveEnchantmentCollection = currentItem.Enchantments;
            }
            List<IfElseLogic> selectable = new List<IfElseLogic>();
            foreach(IfElseLogic iel in saveEnchantmentCollection.Keys)
            {
                if(iel.name == ench.name)
                {
                    selectable.Add(iel);
                }
            }
            comboBoxAlreadyAssigned.DataSource = selectable;
            comboBoxAlreadyAssigned.Text = "";
            comboBoxAlreadyAssigned.SelectedIndex = -1;
            if(selectable.Count > 0)
            {
                comboBoxAlreadyAssigned.SelectedIndex = 0;
            }
            populateRTBWithParams(saveEnchantmentCollection, (IfElseLogic)comboBoxAlreadyAssigned.SelectedItem ?? Utilities.GetEnchantmentByName(comboBoxEnchantments.Text));
        }

        private void comboBoxAlreadyAssigned_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateRTBWithParams(saveEnchantmentCollection, (IfElseLogic)comboBoxAlreadyAssigned.SelectedItem ?? Utilities.GetEnchantmentByName(comboBoxEnchantments.Text));
        }

        private void populateRTBWithParams(Dictionary<IfElseLogic, Dictionary<String, Object>> readFrom, IfElseLogic ench)
        {
            richTextBoxParams.Text = "";
            foreach (object[] vari in ench.variables)
            {
                richTextBoxParams.Text += (string)vari[0] + "\t\t";
                if (readFrom.ContainsKey(ench) && readFrom[ench].ContainsKey((string)vari[0]))
                {
                    richTextBoxParams.Text += readFrom[ench][(string)vari[0]].ToString().Replace(' ', '_');
                }
                else
                {
                    richTextBoxParams.Text += "0";
                }
                richTextBoxParams.Text += "\n";
            }
        }
    }
}
