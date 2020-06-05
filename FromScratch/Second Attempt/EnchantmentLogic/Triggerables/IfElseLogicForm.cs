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
    public partial class IfElseLogicForm : Form, FormWithLogicSetup
    {
        IfElseLogic _data;
        public Logic Data()
        {
            return _data;
        }

        public IfElseLogicForm(Logic l)
        {
            InitializeComponent();
            Setup(l);
        }

        public void Setup(Logic l)
        {
            _data = (IfElseLogic)l;
            if (_data.display != null && _data.display != this)
            {
                _data.display.Close();
            }
            _data.display = this;
            richTextBoxVariables.Text = "Variables:\n";
            foreach (object[] oarr in _data.variables)
            {
                richTextBoxVariables.Text += oarr[0] + "   " + oarr[1].ToString() + "\n";
            }
            
            richTextBoxVariables.Text += "\nVariables From Parent:\n";
            if(_data.parent != null)
            {
                Dictionary<String, Object[]> forDisplay = _data.parent.GetVariables();
                foreach(String s in forDisplay.Keys)
                {
                    richTextBoxVariables.Text += forDisplay[s][0] + "\t\t" + forDisplay[s][1].ToString() + "\n";
                }
            }

            EnchantmentUtilities.FillComboboxWithVariableNames(comboBoxVariables, _data);

            comboBoxConditions.DataSource = EnchantmentUtilities.getCalculableTypes();
            comboBoxResults.DataSource = EnchantmentUtilities.getTriggerableTypes(checkBoxPremades.Checked);
            EnchantmentUtilities.FillComboboxWithNames(comboBoxCurrentConditions, _data.conditions);
            EnchantmentUtilities.FillComboboxWithNames(comboBoxIfResults, _data.ifResults);
            EnchantmentUtilities.FillComboboxWithNames(comboBoxElseResults, _data.elseResults);
            comboBoxCurrentConditions.Text = "";
            comboBoxElseResults.Text = "";
            comboBoxIfResults.Text = "";            
            comboBoxCurrentConditions.SelectedIndex = comboBoxCurrentConditions.Items.Count - 1;
            comboBoxElseResults.SelectedIndex = comboBoxElseResults.Items.Count - 1;
            comboBoxIfResults.SelectedIndex = comboBoxIfResults.Items.Count - 1;
            textBoxLogicName.TextChanged -= textBoxLogicName_TextChanged;
            textBoxLogicName.Text = _data.name;
            textBoxLogicName.TextChanged += textBoxLogicName_TextChanged;
        }

        private void buttonEditCondition_Click(object sender, EventArgs e)
        {
            if (_data.conditions.Any() && comboBoxCurrentConditions.Text != "")
            {
                EnchantmentUtilities.EditLogicWithRightForm((Logic)_data.conditions[comboBoxCurrentConditions.SelectedIndex]);
            }
        }

        private void buttonEditIfResult_Click(object sender, EventArgs e)
        {
            if(_data.ifResults.Any() && comboBoxIfResults.Text != "")
            {
                EnchantmentUtilities.EditLogicWithRightForm((Logic)_data.ifResults[comboBoxIfResults.SelectedIndex]);
            }
        }

        private void buttonEditElseResult_Click(object sender, EventArgs e)
        {
            if (_data.elseResults.Any() && comboBoxElseResults.Text != "")
            {
                EnchantmentUtilities.EditLogicWithRightForm((Logic)_data.elseResults[comboBoxElseResults.SelectedIndex]);
            }
        }

        private void textBoxLogicName_TextChanged(object sender, EventArgs e)
        {
            _data.name = textBoxLogicName.Text;
            if(_data.parent != null)
            {
                ((FormWithLogicSetup)_data.parent.Display).Setup(_data.parent);
            }
            
        }

        private void buttonAddCondition_Click(object sender, EventArgs e)
        {
            FormWithLogicSetup temp = EnchantmentUtilities.getCorrectFormType(comboBoxConditions.Text);
            temp.Data().Parent = _data;
            temp.Setup(temp.Data());
            _data.conditions.Add((Calculable)temp.Data());
            Setup(_data);
            temp.Show();
        }

        private void buttonAddIfResult_Click(object sender, EventArgs e)
        {
            FormWithLogicSetup temp;
            if (Enum.GetNames(typeof(EnchantmentUtilities.TriggerableTypes)).Contains(comboBoxResults.Text))
            {
                temp = EnchantmentUtilities.getCorrectFormType(comboBoxResults.Text);
            }
            else
            {
                temp = new IfElseLogicForm(Utilities.GetEnchantmentByName(comboBoxResults.Text));
            }
            
            temp.Data().Parent = _data;
            temp.Setup(temp.Data());
            _data.ifResults.Add((Triggerable)temp.Data());
            Setup(_data);
            temp.Show();
        }

        private void buttonAddElseResult_Click(object sender, EventArgs e)
        {
            FormWithLogicSetup temp;
            if (Enum.GetNames(typeof(EnchantmentUtilities.TriggerableTypes)).Contains(comboBoxResults.Text))
            {
                temp = EnchantmentUtilities.getCorrectFormType(comboBoxResults.Text);
            }
            else
            {
                temp = new IfElseLogicForm(Utilities.GetEnchantmentByName(comboBoxResults.Text));
            }
            temp.Data().Parent = _data;
            temp.Setup(temp.Data());
            _data.elseResults.Add((Triggerable)temp.Data());
            Setup(_data);
            temp.Show();            
        }

        private void buttonFire_Click(object sender, EventArgs e)
        {
            _data.Trigger(new EnchantmentParameters());
        }

        private void buttonAddVariable_Click(object sender, EventArgs e)
        {
            string varName = textBoxVariableName.Text;
            if(!_data.variables.Any(A => (String)A[0] == varName))
            {
                _data.variables.Add(new Object[]{ varName, 0.0});
                Setup(_data);
            }
        }

        private void buttonDeleteVariable_Click(object sender, EventArgs e)
        {
            if (checkBoxEnableDeletes.Checked)
            {
                _data.variables.RemoveAll(A => (String)A[0] == textBoxVariableName.Text);
                Setup(_data);
            }
        }

        private void buttonDeleteCondition_Click(object sender, EventArgs e)
        {
            if (checkBoxEnableDeletes.Checked)
            {
                if (_data.conditions.Any() && comboBoxCurrentConditions.Text != "")
                {
                    Logic toDelete = (Logic)_data.conditions[comboBoxCurrentConditions.SelectedIndex];
                    toDelete.Delete();
                    _data.conditions.Remove((Calculable)toDelete);
                    Setup(_data);
                }
            }
        }

        private void buttonDeleteIfResult_Click(object sender, EventArgs e)
        {
            if (checkBoxEnableDeletes.Checked)
            {
                if (_data.ifResults.Any() && comboBoxIfResults.Text != "")
                {
                    Logic toDelete = (Logic)_data.ifResults[comboBoxIfResults.SelectedIndex];
                    toDelete.Delete();
                    _data.ifResults.Remove((Triggerable)toDelete);
                    Setup(_data);
                }
            }
        }

        private void buttonDeleteElseResult_Click(object sender, EventArgs e)
        {
            if (checkBoxEnableDeletes.Checked)
            {
                if (_data.elseResults.Any() && comboBoxElseResults.Text != "")
                {
                    Logic toDelete = (Logic)_data.elseResults[comboBoxElseResults.SelectedIndex];
                    toDelete.Delete();
                    _data.elseResults.Remove((Triggerable)toDelete);
                    Setup(_data);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Utilities.SaveEnchantment(_data);
        }

        private void checkBoxPremades_CheckedChanged(object sender, EventArgs e)
        {
            Setup(_data);
        }

        private void comboBoxVariables_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxVariableName.Text = comboBoxVariables.Text;
        }
    }
}
