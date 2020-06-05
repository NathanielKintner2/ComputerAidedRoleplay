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
    public partial class SpellAssigner : Form
    {
        public SpellAssigner()
        {
            InitializeComponent();
            comboBox1.DataSource = Utilities.GetCharacterNames();
            comboBox2.DataSource = Utilities.GetSpellNames();
        }
        //assign one spell
        private void button1_Click(object sender, EventArgs e)
        {
            Character currentChar = Utilities.GetCharByName(comboBox1.Text);
            Spell currentSpell = Utilities.GetSpellByName(comboBox2.Text);
            Spell found = currentChar.Spells.Find(weap => weap.SpellName == currentSpell.SpellName);
            if (found != null)
            {
                currentChar.Spells.Remove(found);
                MessageBox.Show("Item Removed");
            }
            else
            {
                currentChar.Spells.Add(currentSpell);
                MessageBox.Show("Item Added");
            }
            Utilities.SaveCharacter(currentChar);
        }
        //unassign all spell
        private void button2_Click(object sender, EventArgs e)
        {
            Character currentChar = Utilities.GetCharByName(comboBox1.Text);
            currentChar.Spells.Clear();
            Utilities.SaveCharacter(currentChar);
        }
    }
}
