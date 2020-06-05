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
    public partial class ReturnValueForm : Form, FormWithLogicSetup
    {
        ReturnValue _data;
        public Logic Data()
        {
            return _data;
        }
        public ReturnValueForm(Logic l)
        {
            InitializeComponent();
            Setup(l);
        }
        public void Setup(Logic l)
        {            
            _data = (ReturnValue)l;
            if(_data.display != null && _data.display != this)
            {
                _data.display.Close();
            }
            _data.display = this;

            comboBoxValue.DataSource = EnchantmentUtilities.getCalculableTypes();
            if (_data.valueToReturn != null)
            {
                comboBoxValue.SelectedItem = ((Logic)_data.valueToReturn).LogicType;
                labelValue.Text = ((Logic)_data.valueToReturn).LogicType;
            }
        }

        private void buttonChangeValue_Click(object sender, EventArgs e)
        {
            if (_data.valueToReturn == null)
            {
                FormWithLogicSetup temp = EnchantmentUtilities.getCorrectFormType(comboBoxValue.Text);
                temp.Data().Parent = _data;
                temp.Setup(temp.Data());
                _data.valueToReturn = ((Calculable)temp.Data());
                Setup(_data);
                temp.Show();
            }
            else if (((Logic)_data.valueToReturn).LogicType == comboBoxValue.Text)
            {
                EnchantmentUtilities.EditLogicWithRightForm((Logic)_data.valueToReturn);
            }
            else if (checkBoxChangeable.Checked)
            {
                ((Logic)_data.valueToReturn).Delete();
                _data.valueToReturn = null;
                buttonChangeValue_Click(sender, e);
            }
        }
    }
}
