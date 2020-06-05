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
    public partial class SourceCheckForm : Form, FormWithLogicSetup
    {
        SourceCheck _data;
        public Logic Data()
        {
            return _data;
        }
        public SourceCheckForm(Logic l)
        {
            InitializeComponent();
            Setup(l);
        }

        public void Setup(Logic l)
        {
            _data = (SourceCheck)l;
            if (_data.display != null && _data.display != this)
            {
                _data.display.Close();
            }
            _data.display = this;
            EnchantmentUtilities.SourceTypes dam = _data.SourceType;
            comboBoxSources.DataSource = Enum.GetNames(typeof(EnchantmentUtilities.SourceTypes));
            comboBoxSources.SelectedItem = dam.ToString();
            _data.SourceType = dam;
        }
        private void comboBoxSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnchantmentUtilities.SourceTypes source;
            Enum.TryParse(comboBoxSources.Text, out source);
            _data.SourceType = source;
        }
    }
}
