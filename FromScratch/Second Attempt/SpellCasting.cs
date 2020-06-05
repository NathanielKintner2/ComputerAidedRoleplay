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
    public partial class SpellCasting : Form
    {
        public SpellCasting()
        {
            InitializeComponent();


            foreach (Character c in CombatHolder._inCombatChars) {
                cboBoxChars.Items.Add(c.CombatStuff.CombatName);
                cboBoxCaster.Items.Add(c.CombatStuff.CombatName);
            }

            foreach (string s in Utilities.GetSpellNames()) {
                cboBoxSpells.Items.Add(s);
            }

            cboBoxCaster.Items.Add("Nobody");
            cboBoxCaster.SelectedItem = "Nobody";
        }

        private void btnCastSpell_Click(object sender, EventArgs e)
        {
            if (!Utilities.ValidateComboBox(cboBoxChars.Text) || !Utilities.ValidateComboBox(cboBoxSpells.Text))
            {
                return;
            }
            if (chkBoxSecurity.Checked)
            {
                chkBoxSecurity.Checked = false;
            }
            else
            {
                return;
            }
            richTextBox1.Text = "";
            double spellPower = 0.0;
            Double.TryParse(txtBoxSpellPower.Text, out spellPower);
            double defensePower = 0.0;
            Double.TryParse(txtBoxDefenseRoll.Text, out defensePower);

            // Character c = Utilities.GetCharByName(cboBoxChars.Text); something like this needs to work eventually
            Character target = CombatHolder._inCombatChars.Find(A => A.CombatStuff.CombatName == cboBoxChars.Text);

            Character caster = new Character();
            if (cboBoxCaster.Text.Equals("Nobody"))
            {
                caster = Utilities.GetCharByName("Nobody");
                caster.CombatStuff.CombatShield = caster.Shields.First();
                caster.Stamina = CombatScripts.GetBaseStamina(caster);
                caster.CombatStuff.CombatName = "Nobody";
            }
            else
            {
                caster = CombatHolder._inCombatChars.Find(A => A.CombatStuff.CombatName == cboBoxCaster.Text);
            }
            

            if (target == null) {//fail
                Utilities.ValidateComboBox("");
            }
            Spell s = Utilities.GetSpellByName(cboBoxSpells.Text);


            caster.Stamina -= s.SpellCost;

            Tuple<List<AttackOutcome>, List<Effect>> results = SpellScripts.castSpell(caster, target, s, spellPower, defensePower);

            foreach (Effect effMultiplied in results.Item2) {


                richTextBox1.Text += effMultiplied.getDisplayString();

                EffectHolder.CreateEffect(effMultiplied, target, false);
            }

            foreach (AttackOutcome outcome in results.Item1) {
                
                richTextBox1.Text += outcome.Attacker.CombatStuff.CombatName + " against " + outcome.Defender.CombatStuff.CombatName + " with " + outcome.Attacker.CombatStuff.CombatWeapon.ItemName + "\n";
                richTextBox1.Text += "Attackroll: " + outcome.attackRoll.ToString() + "\n";
                richTextBox1.Text += "Defendroll: " + outcome.defendRoll.ToString() + "\n";
                richTextBox1.Text += "Result: " + outcome.Othertext.ToString() + "\n";
                if (outcome.Othertext == Utilities.AttackResultType.Hit)
                {
                    richTextBox1.Text += "Location: " + outcome.HitLocation + "\n";
                    richTextBox1.Text += "Hit Caliber: " + Convert.ToString(outcome.HitCaliber) + "\n";
                    richTextBox1.Text += "Hit Strength: " + Convert.ToString(outcome.HitStrength) + "\n";
                    richTextBox1.Text += "Strike Power: " + Convert.ToString(outcome.TotalStrikeAmountFromAllTypes()) + "\n\n";
                    richTextBox1.Text += "Harm: " + Convert.ToString(outcome.harm) + "\n" + "Bleed: " + Convert.ToString(outcome.bleed) + "\n" + "Disorientation: " + Convert.ToString(outcome.disorientation) + "\n" + "Impairment: " + Convert.ToString(outcome.impairment) + "\n" + "Trauma: " + Convert.ToString(outcome.trauma) + "\n" + "KO: " + Convert.ToString(outcome.ko) + "\n";
                }
                richTextBox1.Text += outcome.HitLocation.ToString() + "\n\n";
                CombatScripts.applyAttackOutcome(outcome);
                EffectHolder.ClearUselessEffects();
                
            }


        }

        private void chkBoxSecurity_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
