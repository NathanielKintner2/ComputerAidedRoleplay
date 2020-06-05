using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Second_Attempt
{
    public partial class LootTable : Form
    {
        public LootTable()
        {
            InitializeComponent();
            comboBoxTables.SelectedIndexChanged -= comboBoxTables_SelectedIndexChanged;
            comboBoxTables.DataSource = Utilities.GetLootNames();
            comboBoxTables.SelectedIndexChanged += comboBoxTables_SelectedIndexChanged;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = getLoot(richTextBox1.Text);
            if (!checkBoxFindStats.Checked)
            {
                return;
            }
            Dictionary<String, int> allTokens = new Dictionary<string, int>();
            int REPS = 200;
            int totalLines = 0;
            for(int i = 0; i < REPS; i++)
            {
                String loot = getLoot(richTextBox1.Text);
                totalLines += loot.Split('\n').Count();
                foreach(string str in loot.Split())
                {
                    if (allTokens.ContainsKey(str))
                    {
                        allTokens[str] += 1;
                    }
                    else
                    {
                        allTokens[str] = 1;
                    }
                }
            }

            richTextBox3.Text = "Average lines: " + (totalLines * 1.0) / REPS + "\n";
            Dictionary<int, List<string>> reverse = new Dictionary<int, List<string>>();
            foreach(string str in allTokens.Keys)
            {
                if (reverse.ContainsKey(allTokens[str]))
                {
                    reverse[allTokens[str]].Add(str);
                }
                else
                {
                    reverse[allTokens[str]] = new List<string>() { str };
                }
            }
            List<int> vals = new List<int>();
            foreach (int i in reverse.Keys)
            {
                vals.Add(i);
            }
            vals.Sort();
            vals.Reverse();
            foreach (int i in vals)
            {
                foreach(string str in reverse[i])
                {
                    richTextBox3.Text += str + " " + (i * 100.0) / REPS + "%\n";
                }
            }
        }

        private string getLoot(string startingString)
        {
            string ret = "";
            if(startingString == "")
            {
                return "";
            }
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < startingString.Length; i++)
            {
                char toAppend = startingString[i];
                if (Char.IsLetterOrDigit(toAppend))
                {
                    sb.Append(toAppend);
                }
                if(!Char.IsLetterOrDigit(toAppend) || i + 1 == startingString.Length)
                {
                    if(sb.ToString() != "")
                    {
                        if (sb.ToString().ToCharArray()[0] == '@')
                        {
                            try
                            {
                                StreamReader sr = new StreamReader("Data\\Loot\\" + sb.ToString().Substring(1) + ".txt");
                                string strToPickRandomlyFrom = sr.ReadToEnd();
                                sr.Close();
                                string[] pickFromHere = strToPickRandomlyFrom.Split('\n');
                                string randomPick = pickFromHere[Utilities.addedRandomness.Next(pickFromHere.Length)];
                                ret += getLoot(randomPick);
                            }
                            catch
                            {
                                MessageBox.Show("Failed to read from loot table " + sb.ToString());
                            }
                        }
                        else
                        {
                            ret += sb.ToString();
                        }
                    }
                    sb.Clear();          
                    if (toAppend == ' ')
                    {
                        ret += ' ';
                    }
                    if (toAppend == '%')
                    {
                        ret += '\n';
                    }
                    if (toAppend == '@')
                    {
                        sb.Append("@");
                    }
                }                
            }
            return ret;
        }

        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "@" + (string)comboBoxTables.SelectedItem;
        }
    }
}
