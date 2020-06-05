using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Second_Attempt
{
    public partial class DataExport : Form
    {
        public DataExport()
        {
            InitializeComponent();
            richTextBox1.Text = Utilities.GenerateDataBlob();
        }
    }
}
