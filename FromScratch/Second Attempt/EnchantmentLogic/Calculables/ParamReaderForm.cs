using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Second_Attempt.EnchantmentLogic.Calculables
{
    public partial class ParamReaderForm : Form, FormWithLogicSetup
    {
        ParamReader _data;
        public Logic Data()
        {
            return _data;
        }
        public ParamReaderForm(Logic l)
        {
            InitializeComponent();
            Setup(l);
        }
        public void Setup(Logic l)
        {
            _data = (ParamReader)l;
            if (_data.display != null && _data.display != this)
            {
                _data.display.Close();
            }
            _data.display = this;
            comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
            comboBox1.DataSource = Enum.GetValues(typeof(EnchantmentUtilities.DataSources));
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            if (_data.Branch1 != "")
            {
                comboBox2.SelectedIndexChanged -= comboBox2_SelectedIndexChanged;
                comboBox3.SelectedIndexChanged -= comboBox3_SelectedIndexChanged;
                comboBox4.SelectedIndexChanged -= comboBox4_SelectedIndexChanged;
                comboBox1.Text = _data.Branch1;
                comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
                comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
                comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            }
            if (_data.Branch2 != "")
            {
                comboBox3.SelectedIndexChanged -= comboBox3_SelectedIndexChanged;
                comboBox2.Text = _data.Branch2;
                comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            }
            if (_data.Branch3 != "")
            {
                comboBox4.SelectedIndexChanged -= comboBox4_SelectedIndexChanged;
                comboBox3.Text = _data.Branch3;
                comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            }
            if (_data.Branch4 != "")
            {
                comboBox4.Text = _data.Branch4;
            }
        }
        public ParamReaderForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.DataSource = new string[1] { "" };
            comboBox4.DataSource = new string[1] { "" };
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            _data.Branch1 = comboBox1.Text;
            switch (comboBox1.Text)
            {
                case "AttackStats":
                    comboBox2.DataSource = Enum.GetValues(typeof(EnchantmentUtilities.AttackParamsSubmenu));
                    comboBox2.SelectedIndex = 0;
                    break;
                case "Character":
                    comboBox2.DataSource = Enum.GetValues(typeof(EnchantmentUtilities.CharacterSelectionSubmenu));
                    comboBox2.SelectedIndex = 0;
                    comboBox3.DataSource = Enum.GetValues(typeof(EnchantmentUtilities.CharacterStatsSubmenu));
                    comboBox3.SelectedIndex = 0;
                    break;
                case "Spell":
                    comboBox2.DataSource = Enum.GetValues(typeof(EnchantmentUtilities.SpellSubmenu));
                    comboBox2.SelectedIndex = 0;
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text != "Character")
            {
                comboBox3.DataSource = new string[1] { "" };
                comboBox3.SelectedIndex = 0;
                comboBox4.DataSource = new string[1] { "" };
                comboBox4.SelectedIndex = 0;
            }
            _data.Branch2 = comboBox2.Text;
            switch (comboBox2.Text)
            {
                case "SpellEffects":
                    comboBox3.DataSource = EffectHolder.allEffectTagsAndTypes();
                    comboBox3.SelectedIndex = 0;
                    break;
                case "AttackResult":
                    comboBox3.DataSource = Enum.GetValues(typeof(Utilities.AttackResultType));
                    comboBox3.SelectedIndex = 0;
                    break;
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.DataSource = new string[1] { "" };
            comboBox4.SelectedIndex = 0;
            _data.Branch3 = comboBox3.Text;
            switch (comboBox3.Text)
            {
                case "Effects":
                    comboBox4.DataSource = EffectHolder.allEffectTagsAndTypes();
                    comboBox4.SelectedIndex = 0;
                    break;
                case "SelectedWeaponName":
                    comboBox4.DataSource = Utilities.GetWeaponNames();
                    comboBox4.SelectedIndex = 0;
                    break;
                case "SelectedWeaponType":
                    comboBox4.DataSource = Enum.GetValues(typeof(Utilities.WeaponType));
                    comboBox4.SelectedIndex = 0;
                    break;
                case "CreatureType":
                    comboBox4.DataSource = Enum.GetValues(typeof(Utilities.CreatureType));
                    comboBox4.SelectedIndex = 0;
                    break;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            _data.Branch4 = comboBox4.Text;
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            _data.Branch1 = comboBox1.Text;
        }

        private void comboBox2_TextUpdate(object sender, EventArgs e)
        {
            _data.Branch2 = comboBox2.Text;
        }

        private void comboBox3_TextUpdate(object sender, EventArgs e)
        {
            _data.Branch3 = comboBox3.Text;
        }

        private void comboBox4_TextUpdate(object sender, EventArgs e)
        {
            _data.Branch4 = comboBox4.Text;
        }
    }
}