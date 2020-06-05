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
    public partial class MathLogicForm : Form, FormWithLogicSetup
    {
        MathLogic _data;
        public Logic Data()
        {
            return _data;
        }
        public MathLogicForm(Logic l)
        {
            InitializeComponent();
            Setup(l);
        }

        public void Setup(Logic l)
        {
            _data = (MathLogic)l;
            if (_data.display != null && _data.display != this)
            {
                _data.display.Close();
            }
            _data.display = this;

            comboBoxLeft.DataSource = EnchantmentUtilities.getCalculableTypes();
            comboBoxRight.DataSource = EnchantmentUtilities.getCalculableTypes();
            comboBoxMathTypes.SelectedIndexChanged -= comboBoxMathTypes_SelectedIndexChanged; 
            comboBoxMathTypes.DataSource = Enum.GetValues(typeof(EnchantmentUtilities.MathTypes));
            comboBoxMathTypes.SelectedIndexChanged += comboBoxMathTypes_SelectedIndexChanged;
            comboBoxMathTypes.SelectedItem = _data.operation;
            if (_data.left != null)
            {
                comboBoxLeft.SelectedItem = ((Logic)_data.left).LogicType;
                labelLeft.Text = ((Logic)_data.left).LogicType;
            }
            if (_data.right != null)
            {
                comboBoxRight.SelectedItem = ((Logic)_data.right).LogicType;
                labelRight.Text = ((Logic)_data.right).LogicType;
            }
        }

        private void buttonChangeLeft_Click(object sender, EventArgs e)
        {
            if (_data.left == null)
            {
                FormWithLogicSetup temp = EnchantmentUtilities.getCorrectFormType(comboBoxLeft.Text);
                temp.Data().Parent = _data;
                temp.Setup(temp.Data());
                _data.left = ((Calculable)temp.Data());
                Setup(_data);
                temp.Show();
            }
            else if (((Logic)_data.left).LogicType == comboBoxLeft.Text)
            {
                EnchantmentUtilities.EditLogicWithRightForm((Logic)_data.left);
            }
            else if (checkBoxChangeable.Checked)
            {
                ((Logic)_data.left).Delete();
                _data.left = null;
                buttonChangeLeft_Click(sender, e);
            }
        }

        private void buttonChangeRight_Click(object sender, EventArgs e)
        {
            if (_data.right == null)
            {
                FormWithLogicSetup temp = EnchantmentUtilities.getCorrectFormType(comboBoxRight.Text);
                temp.Data().Parent = _data;
                temp.Setup(temp.Data());
                _data.right = ((Calculable)temp.Data());
                Setup(_data);
                temp.Show();
            }
            else if (((Logic)_data.right).LogicType == comboBoxRight.Text)
            {
                EnchantmentUtilities.EditLogicWithRightForm((Logic)_data.right);
            }
            else if (checkBoxChangeable.Checked)
            {
                ((Logic)_data.right).Delete();
                _data.right = null;
                buttonChangeRight_Click(sender, e);
            }
        }

        private void comboBoxMathTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _data.operation = (EnchantmentUtilities.MathTypes)comboBoxMathTypes.SelectedItem;
            switch (_data.operation)
            {
                case EnchantmentUtilities.MathTypes.Add:
                    label1.Text = "+";
                    break;
                case EnchantmentUtilities.MathTypes.Divide:
                    label1.Text = "/";
                    break;
                case EnchantmentUtilities.MathTypes.Multiply:
                    label1.Text = "*";
                    break;
                case EnchantmentUtilities.MathTypes.Subtract:
                    label1.Text = "-";
                    break;
                case EnchantmentUtilities.MathTypes.EqualTo:
                    label1.Text = "=";
                    break;
                case EnchantmentUtilities.MathTypes.GreaterThan:
                    label1.Text = ">";
                    break;
            }
        }
    }
}
