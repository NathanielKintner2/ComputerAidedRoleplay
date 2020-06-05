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

namespace Second_Attempt
{
    //This form us ised during combat to specify the roll being input into the calculation, as well
    //as any additional adjustments the GM wishes to impose. It gives useful but unused information
    //about combat. (all non-roll non-other numbers are recalculated later)
    public partial class SingleAttack : Form
    {
        Character _attacker;
        List<Character> _canAttack;
        Master_Attacker _parentForm;
        AttackOutcome _outcome = new AttackOutcome();

        public SingleAttack(Character Attacker, List<Character> CanAttack, Master_Attacker ParentForm, Character preSelected)
        {
            InitializeComponent();
            _attacker = Attacker;
            _canAttack = CanAttack;
            _parentForm = ParentForm;
            foreach (Character attackableChar in _canAttack)
            {
                comboBox1.Items.Add(attackableChar.CombatStuff.CombatName);
            }
            comboBox1.SelectedIndex = 0;
            if (preSelected != null)
            {
                comboBox1.SelectedItem = preSelected.CombatStuff.CombatName;
            }
            comboBoxAttackerWeapon.DataSource = Utilities.GetWeaponNames();
            comboBoxAttackerWeapon.SelectedItem = _attacker.CombatStuff.CombatWeapon.ItemName;
            label1.Text = _attacker.CombatStuff.CombatName;
            comboBoxAttackerWeapon.SelectedText = _attacker.CombatStuff.CombatWeapon.ItemName;

            txtBoxDefensiveRoll.Text = Math.Round(Utilities.addedRandomness.NextDouble() * 20 + 0.5).ToString();
            if (_attacker.CombatStuff.rollSet)
            {
                txtBoxOffensiveRoll.Text = _attacker.CombatStuff.CombatRoll.ToString();
            }
            else
            {
                txtBoxOffensiveRoll.Text = Math.Round(Utilities.addedRandomness.NextDouble() * 20 + 0.5).ToString();
            }
        }
        //this is what happens when you click the 'Attack' button. The method name is an inside joke.
        private void followTheTaco_Click(object sender, EventArgs e)
        {
            double offenseRoll = 0.0;
            double defendRoll = 0.0;
            Double.TryParse(txtBoxOffensiveRoll.Text, out offenseRoll);
            Double.TryParse(txtBoxDefensiveRoll.Text, out defendRoll);

            Character _defender = _canAttack.Find(Ch => Ch.CombatStuff.CombatName == comboBox1.Text);
            if (_attacker.Weapons.Any(A => A.ItemName == comboBoxAttackerWeapon.Text))
            {
                _attacker.CombatStuff.CombatWeapon = _attacker.Weapons.Find(A => A.ItemName == comboBoxAttackerWeapon.Text);
            }
            else
            {
                _attacker.CombatStuff.CombatWeapon = Utilities.GetWeaponByName(comboBoxAttackerWeapon.Text);
            }
            if (_defender.Weapons.Any(A => A.ItemName == comboBoxDefenderWeapon.Text))
            {
                _defender.CombatStuff.CombatWeapon = _defender.Weapons.Find(A => A.ItemName == comboBoxDefenderWeapon.Text);
            }
            else
            {
                _defender.CombatStuff.CombatWeapon = Utilities.GetWeaponByName(comboBoxDefenderWeapon.Text);
            }

            _outcome = new AttackOutcome();
            _outcome.Attacker = _attacker;
            _outcome.Defender = _defender;
            _outcome.attackRoll = offenseRoll;
            _outcome.defendRoll = defendRoll;

            _parentForm.AddToAttacks(_outcome);
            SingleAttack frmRemover = this;
            frmRemover.Hide();
        }
        private void txtBoxOffensiveRoll_TextChanged(object sender, EventArgs e)
        {
            double d1;
            Double.TryParse(txtBoxOffensiveRoll.Text, out d1);
            d1 += _attacker.CombatStuff.CombatOB;
            d1 += Utilities.GetWeaponByName(comboBoxAttackerWeapon.Text).OffensiveBonus;
            d1 += _attacker.CombatStuff.CombatShield.OffensiveBonus;
            d1 += Utilities.GetTotalOffensiveBonusOfAllArmor(_attacker);
            d1 += CombatScripts.GetWeightFactor(_attacker);
            d1 = d1 * CombatScripts.GetStaminaFactor(_attacker);

            labelAfterOffensiveMods.Text = d1.ToString();
        }

        private void txtBoxDefensiveRoll_TextChanged(object sender, EventArgs e)
        {
            double d1;
            Double.TryParse(txtBoxDefensiveRoll.Text, out d1);
            Character _defender = Utilities.getCharacterFromXmlOrCombatHolderByString(comboBox1.Text);
            d1 += _defender.CombatStuff.CombatDB;
            d1 += Utilities.GetWeaponByName(comboBoxDefenderWeapon.Text).DefensiveBonus;
            d1 += _defender.CombatStuff.CombatShield.DefensiveBonus;
            d1 += Utilities.GetTotalDefensiveBonusOfAllArmor(_defender);
            d1 += CombatScripts.GetWeightFactor(_defender);
            d1 = d1 * CombatScripts.GetStaminaFactor(_defender);

            labelAfterDefensiveMods.Text = d1.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Character _defender = Utilities.getCharacterFromXmlOrCombatHolderByString(comboBox1.Text);
            comboBoxDefenderWeapon.DataSource = Utilities.GetWeaponNames();
            comboBoxDefenderWeapon.SelectedItem = _defender.CombatStuff.CombatWeapon.ItemName;
            txtBoxDefensiveRoll_TextChanged(null, null);
        }

        private void comboBoxAttackerWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxOffensiveRoll_TextChanged(null, null);
        }

        private void comboBoxDefenderWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxDefensiveRoll_TextChanged(null, null);
        }
    }
}
