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
    public partial class PrintMessageForm : Form, FormWithLogicSetup
    {
        PrintMessage _data;
        public Logic Data()
        {
            return _data;
        }
        public PrintMessageForm(Logic l)
        {
            InitializeComponent();
            Setup(l);
        }
        public void Setup(Logic l)
        {
            _data = (PrintMessage)l;
            if (_data.display != null && _data.display != this)
            {
                _data.display.Close();
            }
            _data.display = this;

            textBoxMessage.TextChanged -= textBoxMessage_TextChanged;
            textBoxMessage.Text = _data.message;
            textBoxMessage.TextChanged += textBoxMessage_TextChanged;
        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {
            _data.name = textBoxMessage.Text;
            _data.message = textBoxMessage.Text;
            ((FormWithLogicSetup)_data.parent.Display).Setup(_data.parent);
        }
    }
}
