using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
namespace Second_Attempt
{
    public partial class ShieldCreator : Form
    {
        private Shield SaveShield = new Shield();
        public ShieldCreator()
        {
            InitializeComponent();
            cboBoxShields.DataSource = Utilities.GetShieldNames();
            updateRTB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateAll())
                return;

            Shield newShield = new Shield();

            newShield.Description = rtbShieldDescription.Text;
            newShield.ItemName = txtBoxName.Text;
            newShield.OffensiveBonus = Convert.ToDouble(txtBoxOffensiveMod.Text);
            newShield.DefensiveBonus = Convert.ToDouble(txtBoxDefensiveMod.Text);
            newShield.Coverage = Convert.ToDouble(txtBoxCoverage.Text);
            newShield.Weight = Convert.ToDouble(txtBoxShieldWeight.Text);            
            string newSerialize = newShield.Serialize();
            StreamWriter sw = new StreamWriter("Data\\Shields\\" + newShield.ItemName + ".xml");
            sw.Write(newSerialize);
            sw.Close();
            cboBoxShields.DataSource = Utilities.GetShieldNames();
            cboBoxShields.SelectedItem = newShield.ItemName;
        }

        #region Validation
        private bool ValidateDoubleTextBox(string strText)
        {
            Regex reDigitsOnly = new Regex(@"^[\d\.]+$");
            if (reDigitsOnly.IsMatch(strText))
            {
                return true;
            }
            else
            {
                MessageBox.Show("All entries must be in correct form.  Please fix.", "YOU DONE GOOFED");
                return false;
            }
        }
        
        private bool ValidateDoubleOrNegativeTextBox(string strText)
        {
            Regex reDigitsOnly = new Regex(@"^[\d\.\-]+$");
            if (reDigitsOnly.IsMatch(strText))
            {
                return true;
            }
            else
            {
                MessageBox.Show("All entries must be in correct form.  Please fix.", "YOU DONE GOOFED");
                return false;
            }
        }
        private bool ValidateAll()
        {
            if (!ValidateDoubleOrNegativeTextBox(txtBoxOffensiveMod.Text))
                return false;
            if (!ValidateDoubleOrNegativeTextBox(txtBoxDefensiveMod.Text))
                return false;
            if (!ValidateDoubleTextBox(txtBoxShieldWeight.Text))
                return false;
            if (!ValidateDoubleTextBox(txtBoxCoverage.Text))
                return false;
            
           
            //All valid!
            return true;
        }

        #endregion


        private void updateRTB()
        {
            richTextBoxTechnical.Text = SaveShield.TechnicalDescription();
        }
        private void cboBoxShields_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveShield = Utilities.GetShieldByName(cboBoxShields.Text);
            txtBoxName.Text = SaveShield.ItemName;            
            rtbShieldDescription.Text = SaveShield.Description;
            txtBoxOffensiveMod.Text = Convert.ToString(SaveShield.OffensiveBonus);
            txtBoxDefensiveMod.Text = Convert.ToString(SaveShield.DefensiveBonus);
            txtBoxShieldWeight.Text = Convert.ToString(SaveShield.Weight);
            txtBoxCoverage.Text = Convert.ToString(SaveShield.Coverage);
            updateRTB();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBoxName.Text = "";
            txtBoxOffensiveMod.Text = "";
            txtBoxDefensiveMod.Text = "";
            txtBoxShieldWeight.Text = "";
            txtBoxCoverage.Text = "";
            rtbShieldDescription.Text = "";
        }
    }
}
