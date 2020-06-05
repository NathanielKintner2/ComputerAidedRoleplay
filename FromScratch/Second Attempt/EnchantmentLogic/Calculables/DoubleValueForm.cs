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
    public partial class DoubleValueForm : Form, FormWithLogicSetup
    {
        DoubleValue _data;
        public Logic Data()
        {
            return _data;
        }
        public DoubleValueForm(Logic l)
        {
            InitializeComponent();
            Setup(l);
        }

        public void Setup(Logic l)
        {
            _data = (DoubleValue)l;
            if (_data.display != null && _data.display != this)
            {
                _data.display.Close();
            }
            _data.display = this;
            textBoxValue.TextChanged -= textBoxValue_TextChanged;
            textBoxValue.Text = _data.val.ToString();
            textBoxValue.TextChanged += textBoxValue_TextChanged;
        }

        private void textBoxValue_TextChanged(object sender, EventArgs e)
        {
            _data.name = textBoxValue.Text;
            double d = 0.0;
            Double.TryParse(textBoxValue.Text, out d);
            _data.val = d;
            ((FormWithLogicSetup)_data.parent.Display).Setup(_data.parent);
        }
    }
}
