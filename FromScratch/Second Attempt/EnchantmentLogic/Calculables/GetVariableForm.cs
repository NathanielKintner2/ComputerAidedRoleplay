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
    public partial class GetVariableForm : Form, FormWithLogicSetup
    {
        GetVariable _data;
        public Logic Data()
        {
            return _data;
        }
        public GetVariableForm(Logic l)
        {
            InitializeComponent();
            Setup(l);
        }

        public void Setup(Logic l)
        {
            _data = (GetVariable)l;
            if (_data.display != null && _data.display != this)
            {
                _data.display.Close();
            }
            _data.display = this;
            if(_data.parent != null)
            {

                comboBoxVariables.SelectedIndexChanged -= comboBoxVariables_SelectedIndexChanged;
                EnchantmentUtilities.FillComboboxWithVariableNames(comboBoxVariables, _data);
                comboBoxVariables.SelectedIndexChanged += comboBoxVariables_SelectedIndexChanged;
                if (_data.varName != null)
                {
                    if(_data.GetVariables().ContainsKey(_data.varName))
                    {
                        comboBoxVariables.SelectedItem = _data.varName;
                    }
                }
            }            
        }

        private void comboBoxVariables_SelectedIndexChanged(object sender, EventArgs e)
        {
            _data.varName = _data.GetVariables().ElementAt(comboBoxVariables.SelectedIndex).Key;
        }
    }
}
