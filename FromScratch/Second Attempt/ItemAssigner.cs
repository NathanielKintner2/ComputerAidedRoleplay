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
    public partial class ItemAssigner : Form
    {
        public ItemAssigner()
        {
            InitializeComponent();
            comboBoxCharacterNames.DataSource = Utilities.GetCharacterNames();
            comboBoxItemType.DataSource = new List<Item>() { new Item() { ItemName = "Item", Count = 1 },
                                                            new Weapon() { ItemName = "Weapon", Count = 1 },
                                                            new Armor() { ItemName = "Armor", Count = 1 },
                                                            new Shield() { ItemName = "Shield", Count = 1 } };
            updateRTB();
        }
        //add item
        private void button1_Click(object sender, EventArgs e)
        {
            Character currentChar = Utilities.GetCharByName(comboBoxCharacterNames.Text);
            Utilities.AddItemToInventory(GetCurrentItem(), currentChar.Inventory);
            Utilities.FillEquipListsFromInventory(currentChar);
            Utilities.SaveCharacter(currentChar);
            updateRTB();
        }
        //remove item
        private void button2_Click(object sender, EventArgs e)
        {            
            Character currentChar = Utilities.GetCharByName(comboBoxCharacterNames.Text);
            Utilities.RemoveItemFromInventory((Item)comboBoxInventory.SelectedItem, currentChar.Inventory);
            Utilities.FillEquipListsFromInventory(currentChar);
            Utilities.SaveCharacter(currentChar);
            updateRTB();
        }

        private void comboBoxItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxItemType.SelectedItem.GetType() == typeof(Item))
                comboBoxItemNames.DataSource = Utilities.GetItemNames();
            if (comboBoxItemType.SelectedItem.GetType() == typeof(Shield))
                comboBoxItemNames.DataSource = Utilities.GetShieldNames();
            if (comboBoxItemType.SelectedItem.GetType() == typeof(Weapon))
                comboBoxItemNames.DataSource = Utilities.GetWeaponNames();
            if (comboBoxItemType.SelectedItem.GetType() == typeof(Armor))
                comboBoxItemNames.DataSource = Utilities.GetArmorNames();
        }



        private Item GetCurrentItem()
        {
            Item currentItem = new Item();
            if (comboBoxItemType.Text == "Item")
                currentItem = Utilities.GetItemByName(comboBoxItemNames.Text);
            if (comboBoxItemType.Text == "Shield")
                currentItem = Utilities.GetShieldByName(comboBoxItemNames.Text);
            if (comboBoxItemType.Text == "Weapon")
                currentItem = Utilities.GetWeaponByName(comboBoxItemNames.Text);
            if (comboBoxItemType.Text == "Armor")
                currentItem = Utilities.GetArmorByName(comboBoxItemNames.Text);
            int count;
            Int32.TryParse(textBoxItemCount.Text, out count);
            if(count < 1 || currentItem.Use == Item.ItemUse.Equipable)
            {
                count = 1;
            }
            currentItem.Count = count;
            currentItem.UnidentifiedDescription = richTextBoxDescription.Text;
            if(currentItem.UnidentifiedDescription == "")
            {
                currentItem.IsIdentified = true;
            }
            return currentItem;
        }
        //put a new item onto the ground
        private void button3_Click(object sender, EventArgs e)
        {
            Utilities.AddItemToInventory(GetCurrentItem(), CombatHolder._theGround);
            updateRTB();
        }
        //remove an item from the ground
        private void button4_Click(object sender, EventArgs e)
        {
            Utilities.RemoveItemFromInventory((Item)comboBoxGround.SelectedItem, CombatHolder._theGround);
            updateRTB();
        }

        private void updateRTB()
        {
            richTextBoxGround.Text = "GROUND:\n";
            richTextBoxInventory.Text = "INVENTORY:\n";
            comboBoxGround.Items.Clear();
            comboBoxGround.Text = "";
            comboBoxInventory.Items.Clear();
            comboBoxInventory.Text = "";
            foreach (Item i in CombatHolder._theGround)
            {
                richTextBoxGround.Text += i.ToString() + "\n";
                comboBoxGround.Items.Add(i);
            }
            foreach (Item i in Utilities.GetCharByName(comboBoxCharacterNames.Text).Inventory)
            {
                richTextBoxInventory.Text += i.ToString() + "\n";
                comboBoxInventory.Items.Add(i);
            }
        }

        private void comboBoxCharacterNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateRTB();
        }
    }
}
