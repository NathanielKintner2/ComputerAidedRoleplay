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
    public partial class SpellCreator : Form
    {
        private Boolean updateForm = true;
        private Spell CurrentSpell = new Spell();
        public SpellCreator()
        {
            InitializeComponent();
            foreach (String ef in Enum.GetNames(typeof(EffectHolder.EffectType)))
            {
                cboBoxEffectType.Items.Add(ef);
            }
            foreach (String ef in Enum.GetNames(typeof(EffectHolder.EffectTag)))
            {
                cboBoxEffectTag.Items.Add(ef);
            }
            foreach (string str in Utilities.GetSpellNames())
            {
                cboBoxSpellName.Items.Add(str);
            }
            foreach (string str in Utilities.GetWeaponNames())
            {
                cboBoxWeapons.Items.Add(str);
            }
            comboBoxDamageType.Items.Add("");
            foreach (string str in Enum.GetNames(typeof(Utilities.DamageType)))
            {
                comboBoxDamageType.Items.Add(str);
            }
        }

        private bool ValidateAllForEffect()
        {
            if (!Utilities.ValidateDoubleOrNegativeTextBox(txtBoxPotency.Text))
                return false;
            if (!Utilities.ValidatePositiveOrNegativeTextBox(txtBoxLength.Text))
                return false;
            if (!Utilities.ValidateDoubleOrNegativeTextBox(txtBoxDeterioration.Text))
                return false;
            if (!Utilities.ValidateDoubleOrNegativeTextBox(txtBoxPotencyMul.Text))
                return false;
            if (!Utilities.ValidateDoubleOrNegativeTextBox(txtBoxLengthMul.Text))
                return false;
            if (!Utilities.ValidateDoubleOrNegativeTextBox(txtBoxDeteriorationMul.Text))
                return false;
            if (!Utilities.ValidateComboBox(cboBoxEffectType.Text + cboBoxEffectTag.Text))
                return false;
            if (!Utilities.ValidateComboBox(txtBoxSpellName.Text.ToString()))
                return false;

            //All valid!
            return true;
        }

        private bool ValidateAllForWeapon()
        {
            if (!Utilities.ValidateDoubleOrNegativeTextBox(txtBoxWeaponBonus.Text))
                return false;
            if (!Utilities.ValidateComboBox(cboBoxWeapons.SelectedItem.ToString()))
                return false;
            if (!Utilities.ValidateComboBox(txtBoxSpellName.Text.ToString()))
                return false;

            return true;
        }

        private void btnSaveEff_Click(object sender, EventArgs e)
        {
            if (!ValidateAllForEffect())
                return;


            EffectHolder.EffectType myStatus;
            Enum.TryParse(cboBoxEffectType.Text, out myStatus);

            EffectHolder.EffectTag tag;
            Enum.TryParse(cboBoxEffectTag.Text, out tag);

            Utilities.DamageType? dt;
            Utilities.DamageType dtTemp;
            Enum.TryParse(comboBoxDamageType.Text, out dtTemp);
            dt = dtTemp;
            if (comboBoxDamageType.Text == "")
                dt = null;

            Effect NewEffect = new Effect(myStatus, Convert.ToDouble(txtBoxPotency.Text), Convert.ToInt32(txtBoxLength.Text), Convert.ToDouble(txtBoxDeterioration.Text));
            NewEffect.effectTag = tag;
            NewEffect.damageType = dt;
            Utilities.forceTypesToConformToTag(NewEffect);
            
            if (!CurrentSpell.SpellEffects.ContainsKey(NewEffect)) {
                CurrentSpell.SpellEffects.Add(NewEffect, new Tuple<double, double, double>(Double.Parse(txtBoxPotencyMul.Text), Double.Parse(txtBoxLengthMul.Text), Double.Parse(txtBoxDeteriorationMul.Text)));
            }
            UpdateRTBs();
            UpdateEffectIndexCombobox();

        }

        private void cboBoxSpellName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentSpell = Utilities.GetSpellByName(cboBoxSpellName.Text);
            rtbDescription.Text = CurrentSpell.Description;
            txtBoxCost.Text = CurrentSpell.SpellCost.ToString();
            UpdateRTBs();
            UpdateEffectIndexCombobox();
            txtBoxSpellName.Text = CurrentSpell.SpellName;
        }

        private void UpdateRTBs() {
            rtbEffects.Text = "";
            rtbWeapons.Text = "";
            foreach (Effect e in CurrentSpell.SpellEffects.Keys) {
                rtbEffects.Text +=  e.getDisplayString()
                    + "Potency Scaling = \t\t" + CurrentSpell.SpellEffects[e].Item1.ToString() + "\n"
                    + "Length Scaling = \t\t" + CurrentSpell.SpellEffects[e].Item2.ToString() + "\n"
                    + "Deterioration Scaling = \t" + CurrentSpell.SpellEffects[e].Item3.ToString() + "\n"
                    + "\n";
            }
            foreach (Weapon w in CurrentSpell.SpellWeapons.Keys) {
                rtbWeapons.Text += w.ItemName.ToString() + "\n"
                    + "Weapon Bonus = \t\t" + CurrentSpell.SpellWeapons[w].ToString() + "\n"
                    + "\n";
            }

        }

        private void UpdateEffectIndexCombobox(){
            updateForm = false;
            cboBoxEffectIndex.Items.Clear();
            for (int i = 0; i < CurrentSpell.SpellEffects.Keys.Count; i++)
            {
                string effectTypes = "";
                foreach (EffectHolder.EffectType et in CurrentSpell.SpellEffects.Keys.ElementAt(i).effectTypes)
                {
                    effectTypes += et.ToString() + " ";
                }
                cboBoxEffectIndex.Items.Add(i.ToString() + " " + effectTypes);
            }
            cboBoxEffectIndex.SelectedIndex = -1;
            updateForm = true;
        }

        private void cboBoxEffectIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!updateForm) {
                return;
            }

            if (!(CurrentSpell.SpellEffects.Keys.Count > cboBoxEffectIndex.SelectedIndex && cboBoxEffectIndex.SelectedIndex > -1)) {
                return;
            }

            Effect eff = CurrentSpell.SpellEffects.Keys.ElementAt(cboBoxEffectIndex.SelectedIndex);
            cboBoxEffectTag.SelectedItem = eff.effectTag.ToString();
            if (eff.effectTag == EffectHolder.EffectTag.NoTag)
            {
                cboBoxEffectType.SelectedItem = eff.effectTypes.First().ToString();
            }
            else
            {
                cboBoxEffectType.SelectedIndex = -1;
            }
            if(eff.damageType == null)
            {
                comboBoxDamageType.SelectedItem = "";
            }
            else
            {
                comboBoxDamageType.SelectedItem = eff.damageType.ToString();
            }
            
            txtBoxPotency.Text = eff.effectStrength.ToString();
            txtBoxPotencyMul.Text = CurrentSpell.SpellEffects[eff].Item1.ToString();
            txtBoxLength.Text = eff.effectLength.ToString();
            txtBoxLengthMul.Text = CurrentSpell.SpellEffects[eff].Item2.ToString();
            txtBoxDeterioration.Text = eff.deterioration.ToString();
            txtBoxDeteriorationMul.Text = CurrentSpell.SpellEffects[eff].Item3.ToString();
        }

        private void btnDeleteEffect_Click(object sender, EventArgs e)
        {
            if (cboBoxEffectIndex.SelectedIndex == -1)
            {
                return;
            }
            if (CurrentSpell.SpellEffects.Keys.Count > cboBoxEffectIndex.SelectedIndex) {
                CurrentSpell.SpellEffects.Remove(CurrentSpell.SpellEffects.Keys.ElementAt(cboBoxEffectIndex.SelectedIndex));
            }
            UpdateRTBs();
            UpdateEffectIndexCombobox();
        }

        private void btnSaveWeapon_Click(object sender, EventArgs e)
        {
            if (!ValidateAllForWeapon()) {
                return;
            }

            Weapon newWeapon = Utilities.GetWeaponByName(cboBoxWeapons.Text);
            if (newWeapon.ItemName != "") {
                if (CurrentSpell.SpellWeapons.ContainsKey(newWeapon))
                {
                    CurrentSpell.SpellWeapons[newWeapon] = Int32.Parse(txtBoxWeaponBonus.Text);
                }
                else
                {
                    CurrentSpell.SpellWeapons.Add(newWeapon, Int32.Parse(txtBoxWeaponBonus.Text));
                }
            }

            UpdateRTBs();
            UpdateEffectIndexCombobox();
        }

        private void btnDelWeapon_Click(object sender, EventArgs e)
        {
            

            Weapon newWeapon = Utilities.GetWeaponByName(cboBoxWeapons.Text);

            if (newWeapon.ItemName != "")
            {
                if (CurrentSpell.SpellWeapons.ContainsKey(newWeapon))
                {
                    CurrentSpell.SpellWeapons.Remove(newWeapon);
                }
            }

            UpdateRTBs();
            UpdateEffectIndexCombobox();
        }
        //save spell
        private void button1_Click(object sender, EventArgs e)
        {
            CurrentSpell.SpellName = txtBoxSpellName.Text;
            CurrentSpell.Description = rtbDescription.Text;
            int temp = 0;
            Int32.TryParse(txtBoxCost.Text, out temp);
            CurrentSpell.SpellCost = temp;
            Utilities.SaveSpell(CurrentSpell);
            //necessary because setting the datasource sets the index and that resets the selected spell
            string nameSaver = CurrentSpell.SpellName;
            cboBoxSpellName.DataSource = Utilities.GetSpellNames();
            cboBoxSpellName.SelectedItem = nameSaver;
        }
    }
}
