using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Second_Attempt.EnchantmentLogic;

namespace Second_Attempt
{
    public partial class Combat : Form
    {
        AttackOutcome _outcome = new AttackOutcome();
        public Combat()
        {
            InitializeComponent();
            List<String> charNames = Utilities.GetCharacterNames();
            List<String> charNames2 = Utilities.GetCharacterNames();
            foreach (Character c in CombatHolder._inCombatChars) {
                charNames.Add(c.CombatStuff.CombatName);
                charNames2.Add(c.CombatStuff.CombatName);
            }
            cboBoxChar1.DataSource = charNames;
            cboBoxChar2.DataSource = charNames2;
        }

       

        private void cboBoxChar1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Character WeaponSelection = Utilities.getCharacterFromXmlOrCombatHolderByString(cboBoxChar1.Text);
            List<Weapon> WeaponList = WeaponSelection.Weapons;
            List<Shield> ShieldList = WeaponSelection.Shields;
            cboBoxWeapon1.SelectedIndex = -1;
            cboBoxWeapon1.Items.Clear();
            cboBoxShield1.SelectedIndex = -1;
            cboBoxShield1.Items.Clear();
            foreach (Weapon NowWep in WeaponList)
            {
                cboBoxWeapon1.Items.Add(NowWep.ItemName);
            }
            if (cboBoxWeapon1.Items.Count != 0) {
                cboBoxWeapon1.SelectedIndex = 0;
            }
            foreach (Shield NowShield in ShieldList)
            {
                cboBoxShield1.Items.Add(NowShield.ItemName);
            }
            if (cboBoxShield1.Items.Count != 0)
            {
                cboBoxShield1.SelectedIndex = 0;
            }
            ChangeStatLabels();


        }

        private void cboBoxChar2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Character WeaponSelection = Utilities.getCharacterFromXmlOrCombatHolderByString(cboBoxChar2.Text);
            List<Weapon> WeaponList = WeaponSelection.Weapons;
            List<Shield> ShieldList = WeaponSelection.Shields;
            cboBoxWeapon2.SelectedIndex = -1;
            cboBoxWeapon2.Items.Clear();
            cboBoxShield2.SelectedIndex = -1;
            cboBoxShield2.Items.Clear();
            foreach (Weapon NowWep in WeaponList)
            {
                cboBoxWeapon2.Items.Add(NowWep.ItemName);
            }
            if (cboBoxWeapon2.Items.Count != 0)
            {
                cboBoxWeapon2.SelectedIndex = 0;
            }
            foreach (Shield NowShield in ShieldList)
            {
                cboBoxShield2.Items.Add(NowShield.ItemName);
            }
            if (cboBoxShield2.Items.Count != 0)
            {
                cboBoxShield2.SelectedIndex = 0;
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (!Utilities.ValidateComboBox(cboBoxChar1.Text))
                return;
            if (!Utilities.ValidateComboBox(cboBoxChar2.Text))
                return;/*
            if (!Utilities.ValidateComboBox(cboBoxWeapon1.Text))
                return;
            if (!Utilities.ValidateComboBox(cboBoxWeapon2.Text))
                return;*/
            Character char1 = Utilities.getCharacterFromXmlOrCombatHolderByString(cboBoxChar1.Text);
            if (!CombatHolder._inCombatChars.Contains(char1))
            {
                char1.HitPoints = CombatScripts.GetBaseHealth(char1);
                char1.Stamina = CombatScripts.GetBaseStamina(char1);
            }
            Character char2 = Utilities.getCharacterFromXmlOrCombatHolderByString(cboBoxChar2.Text);
            if (!CombatHolder._inCombatChars.Contains(char1))
            {
                char2.HitPoints = CombatScripts.GetBaseHealth(char2);
                char2.Stamina = CombatScripts.GetBaseStamina(char2);
            }
            Character CharCopy1 = Utilities.GetSameCharWithCurrentState(char1);
            Character CharCopy2 = Utilities.GetSameCharWithCurrentState(char2);

            CharCopy1.CombatStuff.CombatOB = Utilities.ParseDoubleFromDangerousString(txtBoxOffensiveBonus.Text);
            CharCopy1.CombatStuff.CombatWeapon = char1.Weapons.Find(A => A.ItemName == cboBoxWeapon1.Text);
            CharCopy1.CombatStuff.CombatShield = char1.Shields.Find(A => A.ItemName == cboBoxShield1.Text);
            if(CharCopy1.CombatStuff.CombatShield == null)
            {
                CharCopy1.CombatStuff.CombatShield = new Shield();
            }


            CharCopy2.CombatStuff.CombatDB = Utilities.ParseDoubleFromDangerousString(txtBoxDefensiveBonus.Text);
            CharCopy2.CombatStuff.CombatWeapon = char2.Weapons.Find(A => A.ItemName == cboBoxWeapon2.Text);
            CharCopy2.CombatStuff.CombatShield = char2.Shields.Find(A => A.ItemName == cboBoxShield2.Text);
            if (CharCopy2.CombatStuff.CombatShield == null)
            {
                CharCopy2.CombatStuff.CombatShield = new Shield();
            }
            if (checkBoxStartup.Checked)
            {
                EnchantmentUtilities.triggerAllEnchantmentsForChar(CharCopy1, new EnchantmentParameters() { triggerSource = EnchantmentUtilities.SourceTypes.CombatEntry });
                EnchantmentUtilities.triggerAllEnchantmentsForChar(CharCopy2, new EnchantmentParameters() { triggerSource = EnchantmentUtilities.SourceTypes.CombatEntry });
            }
            _outcome = CombatScripts.RunCombat(Utilities.GetSameCharWithCurrentState(CharCopy1), Utilities.GetSameCharWithCurrentState(CharCopy2), Utilities.ParseDoubleFromDangerousString(txtBoxOffensiveRoll.Text), Utilities.ParseDoubleFromDangerousString(txtBoxDefensiveRoll.Text), null);
            txtBoxCrit.Text = _outcome.Othertext.ToString();
            txtBoxDamage.Text = Convert.ToString(0);
            lblHitCaliber.Text = Convert.ToString(0);
            lblHitStrength.Text = Convert.ToString(0);
            if (_outcome.Othertext.ToString() == "Hit")
            {
                lblHitCaliber.Text = "Hit Caliber: " + _outcome.HitCaliber.ToString();
                lblHitStrength.Text = "Hit Strength: " + _outcome.HitStrength.ToString();
                double damage = _outcome.TotalStrikeAmountFromAllTypes();
                txtBoxDamage.Text = Convert.ToString(damage);
                txtBoxCrit.Text = _outcome.HitLocation.ToString();
                AttackOutcome cumulative = new AttackOutcome();
                for (int i = 0; i < 1000; i++) {
                    //calculate the same crit every time
                    Utilities.FindCritLocation(_outcome);
                    CritCalculator.CalculateCrit(_outcome);
                    //store it in a different place so it doesnt get reset
                    cumulative.bleed += _outcome.bleed;
                    cumulative.harm += _outcome.harm;
                    cumulative.disorientation += _outcome.disorientation;
                    cumulative.impairment += _outcome.impairment;
                    cumulative.ko += _outcome.ko;
                    cumulative.trauma += _outcome.trauma;
                    
                }

                Console.WriteLine("Harm: " + Convert.ToDouble(cumulative.harm) / 1000);
                Console.WriteLine("Bleed: " + Convert.ToDouble(cumulative.bleed) / 1000);
                Console.WriteLine("Disorientation: " + Convert.ToDouble(cumulative.disorientation) / 1000);
                Console.WriteLine("Impairment: " + Convert.ToDouble(cumulative.impairment) / 1000);
                Console.WriteLine("Trauma: " + Convert.ToDouble(cumulative.trauma) / 1000);
                Console.WriteLine("KO: " + Convert.ToDouble(cumulative.ko) / 1000);

                rtbAverageResults.Text = "";
                rtbAverageResults.Text += "Harm: " + Convert.ToDouble(cumulative.harm) / 1000 + "\n";
                rtbAverageResults.Text += "Bleed: " + Convert.ToDouble(cumulative.bleed) / 1000 + "\n";
                rtbAverageResults.Text += "Disorientation: " + Convert.ToDouble(cumulative.disorientation) / 1000 + "\n";
                rtbAverageResults.Text += "Impairment: " + Convert.ToDouble(cumulative.impairment) / 1000 + "\n";
                rtbAverageResults.Text += "Trauma: " + Convert.ToDouble(cumulative.trauma) / 1000 + "\n";
                rtbAverageResults.Text += "KO: " + Convert.ToDouble(cumulative.ko) / 1000 + "\n";

            }
            if (chkBoxGraph.Checked) {
                AttackChart frmCreator = new AttackChart(Utilities.GetSameCharWithCurrentState(CharCopy1), Utilities.GetSameCharWithCurrentState(CharCopy2));
                frmCreator.Show();
            }

        }

        public void ChangeStatLabels() {
            //Now, fill out some labels about the attacker's stats

            Character statCharacter = Utilities.getCharacterFromXmlOrCombatHolderByString(cboBoxChar1.Text);
            lblHealth.Text = "Health: " + Convert.ToString(CombatScripts.GetBaseHealth(statCharacter));
            lblStamina.Text = "Stamina: " + Convert.ToString(CombatScripts.GetBaseStamina(statCharacter));

            statCharacter.CombatStuff.CombatWeapon = statCharacter.Weapons.Find(A => A.ItemName == cboBoxWeapon1.Text) ?? new Weapon();
            statCharacter.CombatStuff.CombatShield = statCharacter.Shields.Find(A => A.ItemName == cboBoxShield1.Text) ?? new Shield();
            

            double attackerWeightFactor = CombatScripts.GetWeightFactor(statCharacter);

            lblWeightFactor.Text = "WeightFactor: " + Convert.ToString(CombatScripts.GetWeightFactor(statCharacter));

            double dxMod1 = (Convert.ToDouble(statCharacter.Statistics.Dexterity + EffectHolder.GetValidEffectsByEffect(statCharacter, EffectHolder.EffectType.Dexterity)) - 10) / 2;
           
            double attackerReflex = CombatScripts.GetBaseReflex(statCharacter);
            lblReflex.Text = "Reflex: " + attackerReflex.ToString();
        }

        private void cboBoxWeapon1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeStatLabels();
        }

        private void cboBoxShield1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeStatLabels();
        }


        
    }
}
