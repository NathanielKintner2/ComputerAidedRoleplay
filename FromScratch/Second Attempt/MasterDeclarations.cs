using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Second_Attempt.EnchantmentLogic;

namespace Second_Attempt
{
    public partial class MasterDeclarations : Form
    {
        public MasterDeclarations()
        {
            InitializeComponent();
            cboBoxName.DataSource = CombatHolder.getInCombatCharNames();
            UpdateRTB();
            CombatHolder.updateCombatDeclarations();
            CombatHolder._masterOfDeclarations = this;
        }

        
        //create combat declaration for single char
        private void button1_Click(object sender, EventArgs e)
        {
            if (cboBoxName.Text == null)
                return;
            if (cboBoxName.Text == "")
                return;
            Character CharToCreateAttackFor = CombatHolder._inCombatChars.Find(TChar => TChar.CombatStuff.CombatName == cboBoxName.Text);
            if (CharToCreateAttackFor != null)
            {
                CombatDeclarations frmCreator = new CombatDeclarations(CharToCreateAttackFor);
                CombatHolder._currentDeclarationsToUpdate.Add(frmCreator);
                frmCreator.Show();
            }
        }

        public void UpdateRTB()
        {
            rtbAttackingChars.Text = "";
            rtbSpellcastingChars.Text = "";
            rtbCharsWithNotes.Text = "";
            foreach (Character example in CombatHolder._makingAttackChars)
            {
                rtbAttackingChars.Text += example.CombatStuff.CombatName + "\n";
                rtbAttackingChars.Text += " Weapon =" + Convert.ToString(example.CombatStuff.CombatWeapon.ItemName) + "\n";
                rtbAttackingChars.Text += " Shield =" + Convert.ToString(example.CombatStuff.CombatShield.ItemName) + "\n";
                rtbAttackingChars.Text += " OB =" + Convert.ToString(example.CombatStuff.CombatOB) + "\n";
                rtbAttackingChars.Text += " DB =" + Convert.ToString(example.CombatStuff.CombatDB) + "\n";
                rtbAttackingChars.Text += " Roll =" + Convert.ToString(example.CombatStuff.CombatRoll) + "\n";
                double staminaReqirement = example.CombatStuff.CombatWeapon.StaminaRequirement;
                foreach(Armor arm in example.Armor)
                {
                    staminaReqirement += arm.StaminaRequirement;
                }
                rtbAttackingChars.Text += " Energy Used = " + staminaReqirement + "\n";                
                if (EffectHolder.GetValidEffectsByEffect(example, EffectHolder.EffectType.Focus) < 0)
                    rtbAttackingChars.Text += "STUNNED STUNNED STUNNED STUNNED" + "\n";
                if (!(EffectHolder.GetValidEffectsByEffect(example, EffectHolder.EffectType.KO) < 1))
                    rtbAttackingChars.Text += "KO KO KO KO KO KO KO KO KO KO KO" + "\n";
                rtbAttackingChars.Text += "\n";

                
            }
            foreach (Character example in CombatHolder._inCombatChars)
            {
                if (example.GoogleNinjaNotesInbound != null && example.GoogleNinjaNotesInbound != "")
                {
                    rtbCharsWithNotes.Text += example.Name + "\n";
                    if (example.GoogleNinjaNotesInbound.Length < 20) {
                        rtbCharsWithNotes.Text += "\"" + example.GoogleNinjaNotesInbound + "\"\n";
                    }
                    else
                    {
                        rtbCharsWithNotes.Text += "\"" + example.GoogleNinjaNotesInbound.Substring(0,18) + "...\"\n";
                    }
                }
                foreach (SpellToCast stc in example.CombatStuff.SpellsToCast)
                {
                    if (stc != null && stc.IsCorrectlyFormattedAndReadyToCast())
                    {
                        rtbSpellcastingChars.Text += "Caster: " + stc.caster.CombatStuff.CombatName + "\n";
                        rtbSpellcastingChars.Text += "Instigator: " + example.CombatStuff.CombatName + "\n";
                        rtbSpellcastingChars.Text += "Spell: " + stc.spell.SpellName + "\n";
                        rtbSpellcastingChars.Text += "Power: " + stc.spellPower + "\n";
                        foreach (Character tar in stc.targets)
                        {
                            rtbSpellcastingChars.Text += "Target: " + tar.CombatStuff.CombatName + "\n";
                        }
                        rtbSpellcastingChars.Text += "\n";
                    }
                }
            }
        }
        //run attacks
        private void button2_Click(object sender, EventArgs e)
        {
            CombatHolder.updateCombatDeclarations();
            CombatHolder.attemptToBeginCombat();
        }
        //next round
        private void button3_Click(object sender, EventArgs e)
        {
            CombatHolder._alreadyAttackedThisRound.Clear();

            int rounds = 1;
            Int32.TryParse(textBoxRoundsToJump.Text, out rounds);
            if (rounds < 1)
                rounds = 1;
            textBoxRoundsToJump.Text = "";
            for(int i = 0; i < rounds; i++)
            {
                EffectHolder.ProcAndDecayEffects();
                foreach (Character c in CombatHolder._inCombatChars)
                {
                    EnchantmentUtilities.triggerAllEnchantmentsForChar(c, new EnchantmentParameters() { triggerSource = EnchantmentUtilities.SourceTypes.Round });
                    foreach (SpellToCast stc in c.CombatStuff.SpellsToCast)
                    {
                        if (stc != null)
                        {
                            stc.hasBeenCast = false;
                            if (!stc.castAtBeginningOfNextRound)
                            {
                                stc.spellPower = -1;
                            }
                        }
                    }
                }
                if(rounds < 10)
                {
                    SpellResults frmCreator = new SpellResults(false);
                }
                CombatScripts.slowlyRegenerateCharacters();
                CombatScripts.removeOverhealFromCharacters();
            }
            

            
            UpdateRTB();
            CombatHolder.updateCombatDeclarations();
        }
        //get data from google sheets
        private void btnInternet_Click(object sender, EventArgs e)
        {
            //CombatHolder.readCharsFromGoogle(true);
            UpdateRTB();
            CombatHolder.updateCombatDeclarations();
        }
        //write data out to google sheets
        private void btnInternetWrite_Click(object sender, EventArgs e)
        {
            foreach(Character c in CombatHolder._inCombatChars)
            {
                Utilities.updateCharacterInMemoryFromDB(c);
            }
        }
        //run spells
        private void btnRunSpells_Click(object sender, EventArgs e)
        {
            SpellResults frmCreator = new SpellResults(true);
            frmCreator.Show();
        }
    }
}
