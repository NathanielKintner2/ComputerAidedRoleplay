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
    public partial class SpellResults : Form
    {
        List<SpellToCast> spells = new List<SpellToCast>();
        public SpellResults(bool waitForConfirmation)
        {
            InitializeComponent();
            foreach (Character example in CombatHolder._inCombatChars)
            {
                foreach (SpellToCast stc in example.CombatStuff.SpellsToCast)
                {
                    if (stc != null && stc.IsCorrectlyFormattedAndReadyToCast())
                    {
                        spells.Add(stc);
                        rtbResults.Text += "--------------------------------------------------------\n";
                        rtbResults.Text += "Caster: " + stc.caster.CombatStuff.CombatName + "\n";
                        rtbResults.Text += "Instigator: " + example.CombatStuff.CombatName + "\n";
                        rtbResults.Text += "Spell: " + stc.spell.SpellName + "\n";
                        rtbResults.Text += "Power: " + stc.spellPower + "\n";
                        rtbResults.Text += "------------------\n";
                        foreach (Character c in stc.targets)
                        {
                            rtbResults.Text += c.CombatStuff.CombatName + "\n";
                            rtbResults.Text += "-----ATTACKS-----\n";
                            Tuple<List<AttackOutcome>, List<Effect>> result = SpellScripts.castSpell(stc.caster, c, stc.spell, stc.spellPower, Utilities.addedRandomness.NextDouble() * 20);
                            stc.weaponResult = result.Item1;
                            foreach(Effect ef in result.Item2)
                            {
                                stc.effectResult.Add(ef, c);
                            }
                            foreach (AttackOutcome ao in result.Item1)
                            {
                                rtbResults.Text += "Weapon: " + ao.Attacker.CombatStuff.CombatWeapon.ItemName + "\n";
                                rtbResults.Text += "Result: " + ao.Othertext + "\n";
                                if (ao.Othertext == Utilities.AttackResultType.Hit)
                                {
                                    rtbResults.Text += "Location: " + ao.HitLocation + "\n";
                                    rtbResults.Text += "Hit Caliber: " + Convert.ToString(ao.HitCaliber) + "\n";
                                    rtbResults.Text += "Hit Strength: " + Convert.ToString(ao.HitStrength) + "\n";
                                    rtbResults.Text += "Strike Power: " + Convert.ToString(ao.TotalStrikeAmountFromAllTypes()) + "\n\n";
                                    rtbResults.Text += "Harm: " + Convert.ToString(ao.harm) + "\n" + "Bleed: " + Convert.ToString(ao.bleed) + "\n" + "Disorientation: " + Convert.ToString(ao.disorientation) + "\n" + "Impairment: " + Convert.ToString(ao.impairment) + "\n" + "Trauma: " + Convert.ToString(ao.trauma) + "\n" + "KO: " + Convert.ToString(ao.ko) + "\n";
                                }
                                rtbResults.Text += ao.HitLocation.ToString() + "\n";
                                rtbResults.Text += "---------------------\n";
                            }
                            rtbResults.Text += "-----EFFECTS-----\n";
                            foreach (Effect ef in result.Item2)
                            {
                                rtbResults.Text += ef.getDisplayString()
                                    + "\n---------------------\n";
                            }
                            rtbResults.Text += "---------------------\n";
                        }
                        rtbResults.Text += "--------------------------------------------------------\n";
                    }
                }
            }
            if (!waitForConfirmation) {
                resolveSpells(false);
            }
        }

        private void btnResolveSpells_Click(object sender, EventArgs e)
        {
            resolveSpells(true);
        }

        private void attemptToAddResult(Character c,  SpellToCast stc)
        {
            if (!c.CombatStuff.spellResultsForDisplay.Contains(stc))
            {
                if (c.CombatStuff.spellResultsForDisplay.Count > 6)
                {
                    c.CombatStuff.spellResultsForDisplay.RemoveAt(6);
                }
                c.CombatStuff.spellResultsForDisplay.Insert(0, stc);
            }
        }

        private void resolveSpells(bool updateboxes) {
            foreach (SpellToCast stc in spells)
            {
                foreach (Effect eff in stc.effectResult.Keys)
                {
                    EffectHolder.CreateEffect(eff, stc.effectResult[eff], false);
                }
                foreach (AttackOutcome ao in stc.weaponResult)
                {
                    CombatScripts.applyAttackOutcome(ao);
                }
                stc.caster.Stamina -= stc.spell.SpellCost;
                attemptToAddResult(stc.caster, stc);
                foreach (Character c in stc.targets)
                {
                    attemptToAddResult(c, stc);
                }
                stc.targets.Clear();
                stc.spellPower = 0;
            }
            EffectHolder.ClearUselessEffects();

            if (updateboxes)
            {
                if (CombatHolder._masterOfDeclarations != null)
                {
                    CombatHolder._masterOfDeclarations.UpdateRTB();
                }
                CombatHolder.updateCombatDeclarations();
            }

            SpellResults frmCloser = this;
            frmCloser.Hide();
        }
    }
}
