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
    public partial class SetVariableForm : Form, FormWithLogicSetup
    {
        SetVariable _data;
        public Logic Data()
        {
            return _data;
        }
        public SetVariableForm(Logic l)
        {
            InitializeComponent();
            Setup(l);
        }

        public void Setup(Logic l)
        {
            _data = (SetVariable)l;
            if (_data.display != null && _data.display != this)
            {
                _data.display.Close();
            }
            _data.display = this;

            comboBoxCalculables.DataSource = EnchantmentUtilities.getCalculableTypes();
            if (_data.setTo != null)
            {
                comboBoxCalculables.SelectedItem = ((Logic)_data.setTo).LogicType;
                label1.Text = ((Logic)_data.setTo).LogicType;
            }

            if (_data.parent != null)
            {
                comboBoxVariables.SelectedIndexChanged -= comboBoxVariables_SelectedIndexChanged;
                EnchantmentUtilities.FillComboboxWithVariableNames(comboBoxVariables, _data);
                comboBoxVariables.SelectedIndexChanged += comboBoxVariables_SelectedIndexChanged;
                if (_data.varName != null)
                {
                    comboBoxVariables.SelectedItem = _data.varName;
                }
            }

            
            
        }        

        private void buttonChangeOrEdit_Click(object sender, EventArgs e)
        {
            if (_data.setTo == null)
            {
                FormWithLogicSetup temp = EnchantmentUtilities.getCorrectFormType(comboBoxCalculables.Text);
                temp.Data().Parent = _data;
                temp.Setup(temp.Data());
                _data.setTo = ((Calculable)temp.Data());
                Setup(_data);
                temp.Show();
            }
            else if (((Logic)_data.setTo).LogicType == comboBoxCalculables.Text)
            {
                EnchantmentUtilities.EditLogicWithRightForm((Logic)_data.setTo);
            }
            else if (checkBoxChangeable.Checked)
            {
                ((Logic)_data.setTo).Delete();
                _data.setTo = null;
                buttonChangeOrEdit_Click(sender, e);
            }
        }

        private void comboBoxVariables_SelectedIndexChanged(object sender, EventArgs e)
        {
            _data.varName = _data.GetVariables().ElementAt(comboBoxVariables.SelectedIndex).Key;
        }
    }
}



