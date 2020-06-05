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
    public partial class CreateEffectForm : Form, FormWithLogicSetup
    {
        CreateEffect _data;
        public Logic Data()
        {
            return _data;
        }
        public CreateEffectForm(Logic l)
        {
            InitializeComponent();
            Setup(l);
        }

        public void Setup(Logic l)
        {
            _data = (CreateEffect)l;
            if (_data.display != null && _data.display != this)
            {
                _data.display.Close();
            }
            _data.display = this;

            comboBoxTarget.SelectedIndexChanged -= comboBoxTarget_SelectedIndexChanged;
            comboBoxTarget.DataSource = Enum.GetValues(typeof(EnchantmentUtilities.CharacterSelectionSubmenu));
            comboBoxTarget.SelectedIndexChanged += comboBoxTarget_SelectedIndexChanged;

            comboBoxEffectType.SelectedIndexChanged -= comboBoxEffectType_SelectedIndexChanged;
            comboBoxEffectType.DataSource = Enum.GetValues(typeof(EffectHolder.EffectType));
            comboBoxEffectType.SelectedIndexChanged += comboBoxEffectType_SelectedIndexChanged;

            comboBoxEffectTag.SelectedIndexChanged -= comboBoxEffectTag_SelectedIndexChanged;
            comboBoxEffectTag.DataSource = Enum.GetValues(typeof(EffectHolder.EffectTag));
            comboBoxEffectTag.SelectedIndex = -1;
            comboBoxEffectTag.SelectedIndexChanged += comboBoxEffectTag_SelectedIndexChanged;

            comboBoxDamageType.SelectedIndexChanged -= comboBoxDamageType_SelectedIndexChanged;
            comboBoxDamageType.DataSource = Enum.GetValues(typeof(Utilities.DamageType));
            comboBoxDamageType.SelectedIndex = -1;
            comboBoxDamageType.SelectedIndexChanged += comboBoxDamageType_SelectedIndexChanged;

            comboBoxLength.SelectedIndexChanged -= comboBoxLength_SelectedIndexChanged;
            comboBoxLength.DataSource = EnchantmentUtilities.getCalculableTypes();
            if (_data.length != null)
            {
                comboBoxLength.SelectedItem = ((Logic)_data.length).LogicType;
            }
            comboBoxLength.SelectedIndexChanged += comboBoxLength_SelectedIndexChanged;

            comboBoxPotency.SelectedIndexChanged -= comboBoxPotency_SelectedIndexChanged;
            comboBoxPotency.DataSource = EnchantmentUtilities.getCalculableTypes();
            if (_data.potency != null)
            {
                comboBoxPotency.SelectedItem = ((Logic)_data.potency).LogicType;
            }
            comboBoxPotency.SelectedIndexChanged += comboBoxPotency_SelectedIndexChanged;

            comboBoxDeterioration.SelectedIndexChanged -= comboBoxDeterioration_SelectedIndexChanged;
            comboBoxDeterioration.DataSource = EnchantmentUtilities.getCalculableTypes();
            if (_data.deterioration != null)
            {
                comboBoxDeterioration.SelectedItem = ((Logic)_data.deterioration).LogicType;
            }
            comboBoxDeterioration.SelectedIndexChanged += comboBoxDeterioration_SelectedIndexChanged;

            comboBoxTarget.SelectedItem = _data.target;
            comboBoxEffectType.Text = _data.effectType;
            comboBoxEffectTag.Text = _data.effectTag;
            comboBoxDamageType.Text = _data.damageType;
        }

        private void comboBoxTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            _data.target = (EnchantmentUtilities.CharacterSelectionSubmenu)comboBoxTarget.SelectedItem;
        }

        private void comboBoxEffectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _data.effectType = comboBoxEffectType.Text;
        }

        private void comboBoxPotency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_data.potency == null)
            {
                FormWithLogicSetup temp = EnchantmentUtilities.getCorrectFormType(comboBoxPotency.Text);
                temp.Data().Parent = _data;
                temp.Setup(temp.Data());
                _data.potency = ((Calculable)temp.Data());
                temp.Show();
                Setup(_data);
            }
            else if (((Logic)_data.potency).LogicType == comboBoxPotency.Text)
            {
                EnchantmentUtilities.EditLogicWithRightForm((Logic)_data.potency);
            }
            else if (checkBoxChangeable.Checked)
            {
                ((Logic)_data.potency).Delete();
                _data.potency = null;
                comboBoxPotency_SelectedIndexChanged(sender, e);
            }
        }

        private void comboBoxLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_data.length == null)
            {
                FormWithLogicSetup temp = EnchantmentUtilities.getCorrectFormType(comboBoxLength.Text);
                temp.Data().Parent = _data;
                temp.Setup(temp.Data());
                _data.length = ((Calculable)temp.Data());
                temp.Show();
                Setup(_data);
            }
            else if (((Logic)_data.length).LogicType == comboBoxLength.Text)
            {
                EnchantmentUtilities.EditLogicWithRightForm((Logic)_data.length);
            }
            else if (checkBoxChangeable.Checked)
            {
                ((Logic)_data.length).Delete();
                _data.length = null;
                comboBoxLength_SelectedIndexChanged(sender, e);
            }
        }

        private void comboBoxDeterioration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_data.deterioration == null)
            {
                FormWithLogicSetup temp = EnchantmentUtilities.getCorrectFormType(comboBoxDeterioration.Text);
                temp.Data().Parent = _data;
                temp.Setup(temp.Data());
                _data.deterioration = ((Calculable)temp.Data());
                temp.Show();
                Setup(_data);
            }
            else if (((Logic)_data.deterioration).LogicType == comboBoxDeterioration.Text)
            {
                EnchantmentUtilities.EditLogicWithRightForm((Logic)_data.deterioration);
            }
            else if (checkBoxChangeable.Checked)
            {
                ((Logic)_data.deterioration).Delete();
                _data.deterioration = null;
                comboBoxDeterioration_SelectedIndexChanged(sender, e);
            }
        }

        private void comboBoxEffectTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            _data.effectTag = comboBoxEffectTag.Text;
        }

        private void comboBoxDamageType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _data.damageType = comboBoxDamageType.Text;
        }

        private void comboBoxDamageType_TextUpdate(object sender, EventArgs e)
        {
            _data.damageType = comboBoxDamageType.Text;
        }

        private void comboBoxEffectTag_TextUpdate(object sender, EventArgs e)
        {
            _data.effectTag = comboBoxEffectTag.Text;
        }

        private void comboBoxEffectType_TextUpdate(object sender, EventArgs e)
        {
            _data.effectType = comboBoxEffectType.Text;
        }
    }
}


