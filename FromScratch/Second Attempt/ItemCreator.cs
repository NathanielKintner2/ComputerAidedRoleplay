using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Second_Attempt
{
    public partial class ItemCreator : Form
    {
        Item SaveItem = null;
        public ItemCreator()
        {
            InitializeComponent();
            comboBoxName.DataSource = Utilities.GetItemNames();
            comboBoxType.DataSource = Enum.GetValues(typeof(Utilities.ItemType));
            comboBoxItemUse.DataSource = Enum.GetValues(typeof(Item.ItemUse));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateAll())
                return;

            Item newItem = new Item();
            if (SaveItem != null && textBoxName.Text == SaveItem.ItemName)
            {
                newItem = SaveItem;
            }

            newItem.Description = richTextBoxDescription.Text;
            newItem.ItemName = textBoxName.Text;
            newItem.Weight = Convert.ToDouble(textBoxWeight.Text);
            newItem.Type = (Utilities.ItemType)comboBoxType.SelectedItem;
            newItem.Use = (Item.ItemUse)comboBoxItemUse.SelectedItem;
            Utilities.SaveItem(newItem);
            comboBoxName.DataSource = Utilities.GetItemNames();
            comboBoxName.SelectedItem = newItem.ItemName;
        }


        private bool ValidateAll()
        {
            if (!Utilities.ValidateDoubleOrNegativeTextBox(textBoxWeight.Text))
                return false;
            if (!Utilities.ValidateComboBox(comboBoxType.Text))
                return false;
            if (!Utilities.ValidateComboBox(textBoxName.Text))
                return false;


            //All valid!
            return true;
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveItem = Utilities.GetItemByName(comboBoxName.Text);
            textBoxName.Text = SaveItem.ItemName;
            richTextBoxDescription.Text = SaveItem.Description;
            textBoxWeight.Text = Convert.ToString(SaveItem.Weight);
            comboBoxType.SelectedItem = SaveItem.Type;
            comboBoxItemUse.SelectedItem = SaveItem.Use;
            richTextBoxTechnicalDescription.Text = "";
            richTextBoxTechnicalDescription.Text += "Enchantments:\n";
            richTextBoxTechnicalDescription.Text += Utilities.translateEnchantmentsToDisplayString(SaveItem.Enchantments);
            richTextBoxTechnicalDescription.Text += "\nEffects:\n";
            foreach (Effect eff in SaveItem.ItemEffects)
            {
                richTextBoxTechnicalDescription.Text += eff.getDisplayString() + "\n";
            }
        }
    }
}
