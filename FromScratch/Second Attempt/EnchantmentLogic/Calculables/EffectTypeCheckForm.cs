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
    public partial class EffectTypeCheckForm : Form, FormWithLogicSetup
    {
        EffectTypeCheck _data;
        public Logic Data()
        {
            return _data;
        }
        public EffectTypeCheckForm(Logic l)
        {
            InitializeComponent();
            Setup(l);
        }

        public void Setup(Logic l)
        {
            _data = (EffectTypeCheck)l;
            if (_data.display != null && _data.display != this)
            {
                _data.display.Close();
            }
            _data.display = this;
            string dam = _data.damType;
            string type = _data.effType;
            string tag = _data.effTag;
            comboBoxEffectTypes.DataSource = Enum.GetNames(typeof(EffectHolder.EffectType));
            comboBoxEffectTypes.Text = type;
            _data.effType = type;
            comboBoxEffectTags.DataSource = Enum.GetNames(typeof(EffectHolder.EffectTag));
            comboBoxEffectTags.Text = tag;
            _data.effTag = tag;
            comboBoxDamageType.DataSource = Enum.GetNames(typeof(Utilities.DamageType));
            comboBoxDamageType.Text = dam;
            _data.damType = dam;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBoxDamageType.SelectedIndex = -1;
            comboBoxEffectTags.SelectedIndex = -1;
            comboBoxEffectTypes.SelectedIndex = -1;
            _data.damType = null;
            _data.effTag = null;
            _data.effType = null;
        }

        private void comboBoxEffectTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _data.effType = comboBoxEffectTypes.Text;
        }

        private void comboBoxEffectTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            _data.effTag = comboBoxEffectTags.Text;
        }

        private void comboBoxDamageType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _data.damType = comboBoxDamageType.Text;
        }

        private void comboBoxEffectTypes_TextUpdate(object sender, EventArgs e)
        {
            _data.effType = comboBoxEffectTypes.Text;
        }

        private void comboBoxDamageType_TextUpdate(object sender, EventArgs e)
        {
            _data.damType = comboBoxDamageType.Text;
        }

        private void comboBoxEffectTags_TextUpdate(object sender, EventArgs e)
        {
            _data.effTag = comboBoxEffectTags.Text;
        }
    }
}

