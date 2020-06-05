using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Second_Attempt.EnchantmentLogic
{
    public partial class MakeAttackForm : Form, FormWithLogicSetup
    {
        MakeAttack _data;
        public Logic Data()
        {
            return _data;
        }
        public MakeAttackForm(Logic l)
        {
            InitializeComponent();
            Setup(l);
        }

        public void Setup(Logic l)
        {
            _data = (MakeAttack)l;
            if (_data.display != null && _data.display != this)
            {
                _data.display.Close();
            }
            _data.display = this;

            comboBoxAttackerCalc.DataSource = EnchantmentUtilities.getCalculableTypes();
            comboBoxDefenderCalc.DataSource = EnchantmentUtilities.getCalculableTypes();
            comboBoxAttacker.SelectedIndexChanged -= comboBoxAttacker_SelectedIndexChanged;
            comboBoxAttacker.DataSource = Enum.GetValues(typeof(EnchantmentUtilities.CharacterSelectionSubmenu));
            comboBoxAttacker.SelectedIndexChanged += comboBoxAttacker_SelectedIndexChanged;
            comboBoxDefender.SelectedIndexChanged -= comboBoxDefender_SelectedIndexChanged;
            comboBoxDefender.DataSource = Enum.GetValues(typeof(EnchantmentUtilities.CharacterSelectionSubmenu));
            comboBoxDefender.SelectedIndexChanged += comboBoxDefender_SelectedIndexChanged;
            comboBoxWeapon.SelectedIndexChanged -= comboBoxWeapon_SelectedIndexChanged;
            comboBoxWeapon.DataSource = Utilities.GetWeaponNames();
            comboBoxWeapon.SelectedIndexChanged += comboBoxWeapon_SelectedIndexChanged;

            if (_data.attackValue != null)
            {
                comboBoxAttackerCalc.SelectedItem = ((Logic)_data.attackValue).LogicType;
                labelLeft.Text = ((Logic)_data.attackValue).LogicType;
            }
            if (_data.defenceValue != null)
            {
                comboBoxDefenderCalc.SelectedItem = ((Logic)_data.defenceValue).LogicType;
                labelRight.Text = ((Logic)_data.defenceValue).LogicType;
            }
            comboBoxAttacker.SelectedItem = _data.attacker;
            comboBoxDefender.SelectedItem = _data.defender;
            if (_data.selectedWeap != null)
            {
                comboBoxWeapon.Text = _data.selectedWeap;
            }
        }

        //change attack val
        private void buttonChangeLeft_Click(object sender, EventArgs e)
        {
            if (_data.attackValue == null)
            {
                FormWithLogicSetup temp = EnchantmentUtilities.getCorrectFormType(comboBoxAttackerCalc.Text);
                temp.Data().Parent = _data;
                temp.Setup(temp.Data());
                _data.attackValue = ((Calculable)temp.Data());
                Setup(_data);
                temp.Show();
            }
            else if (((Logic)_data.attackValue).LogicType == comboBoxAttackerCalc.Text)
            {
                EnchantmentUtilities.EditLogicWithRightForm((Logic)_data.attackValue);
            }
            else if (checkBoxChangeable.Checked)
            {
                ((Logic)_data.attackValue).Delete();
                _data.attackValue = null;
                buttonChangeLeft_Click(sender, e);
            }
        }
        // change defence val
        private void buttonChangeRight_Click(object sender, EventArgs e)
        {
            if (_data.defenceValue == null)
            {
                FormWithLogicSetup temp = EnchantmentUtilities.getCorrectFormType(comboBoxDefenderCalc.Text);
                temp.Data().Parent = _data;
                temp.Setup(temp.Data());
                _data.defenceValue = ((Calculable)temp.Data());
                Setup(_data);
                temp.Show();
            }
            else if (((Logic)_data.defenceValue).LogicType == comboBoxDefenderCalc.Text)
            {
                EnchantmentUtilities.EditLogicWithRightForm((Logic)_data.defenceValue);
            }
            else if (checkBoxChangeable.Checked)
            {
                ((Logic)_data.defenceValue).Delete();
                _data.defenceValue = null;
                buttonChangeRight_Click(sender, e);
            }
        }

        private void comboBoxAttacker_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantmentUtilities.CharacterSelectionSubmenu val;
            Enum.TryParse(comboBoxAttacker.Text, out val);
            _data.attacker = val;
        }

        private void comboBoxDefender_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantmentUtilities.CharacterSelectionSubmenu val;
            Enum.TryParse(comboBoxDefender.Text, out val);
            _data.defender = val;
        }

        private void comboBoxWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            _data.selectedWeap = comboBoxWeapon.Text;
        }

        private void comboBoxWeapon_TextUpdate(object sender, EventArgs e)
        {
            _data.selectedWeap = comboBoxWeapon.Text;
        }
    }
}

