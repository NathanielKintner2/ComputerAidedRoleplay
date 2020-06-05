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
    public partial class EquipStatusChanger : Form
    {
        Character SaveCharacter = new Character();
        public EquipStatusChanger()
        {
            InitializeComponent();
            comboBoxCharacters.DataSource = Utilities.GetCharacterNames();
        }
        public void RefreshComboBoxes()
        {
            comboBoxEquipped.Items.Clear();
            comboBoxNonEquipped.Items.Clear();
            comboBoxEquipped.Text = "";
            comboBoxNonEquipped.Text = "";
            if (comboBoxCharacters.Text == "")
            {
                return;
            }
            foreach (Item i in SaveCharacter.Inventory)
            {
                if (i.IsEquipped)
                {
                    comboBoxEquipped.Items.Add(i);
                }
                else
                {
                    comboBoxNonEquipped.Items.Add(i);
                }
            }
            richTextBoxEquipped.Text = "EQUIPPED:\n";
            foreach(Item i in comboBoxEquipped.Items)
            {
                richTextBoxEquipped.Text += i.ItemName + (i.IsIdentified ? "" : " (Unidentified)") + "\n";
            }
            richTextBoxBag.Text = "BAG:\n";
            foreach (Item i in comboBoxNonEquipped.Items)
            {
                richTextBoxBag.Text += i.ItemName + (i.IsIdentified ? "" : " (Unidentified)") + "\n";
            }
        }

        private void comboBoxCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveCharacter = Utilities.GetCharByName(comboBoxCharacters.Text);
            RefreshComboBoxes();
        }

        private void buttonEquip_Click(object sender, EventArgs e)
        {
            if (comboBoxNonEquipped.SelectedItem == null)
            {
                return;
            }
            ((Item)(comboBoxNonEquipped.SelectedItem)).IsEquipped = true;            
            Utilities.SaveCharacter(SaveCharacter);
            RefreshComboBoxes();
        }

        private void buttonUnequip_Click(object sender, EventArgs e)
        {
            if (comboBoxEquipped.SelectedItem == null)
            {
                return;
            }
            ((Item)(comboBoxEquipped.SelectedItem)).IsEquipped = false;
            Utilities.SaveCharacter(SaveCharacter);
            RefreshComboBoxes();
        }
        //identify item
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBoxNonEquipped.SelectedItem == null)
            {
                return;
            }
            ((Item)(comboBoxNonEquipped.SelectedItem)).IsIdentified = true;
            Utilities.SaveCharacter(SaveCharacter);
            RefreshComboBoxes();
        }
    }
}
