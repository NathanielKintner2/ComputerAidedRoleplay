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

namespace Second_Attempt
{
    public partial class EffectAdder : Form
    {

        #region Validation
        private bool updateTxtBoxes = true;

        private List<Effect> selectableEffects = new List<Effect>();
  
        private bool ValidateAll()
        {
            if (!Utilities.ValidateDoubleOrNegativeTextBox(txtBoxStrength.Text))
                return false;
            if (!Utilities.ValidatePositiveOrNegativeTextBox(txtBoxLength.Text))
                return false;
            if (!Utilities.ValidateDoubleOrNegativeTextBox(txtBoxDeterioration.Text))
                return false;
            if (!Utilities.ValidateComboBox(cboBoxEffect.Text + cboBoxTag.Text))
                return false;
            //All valid!
            return true;
        }

        #endregion

        public EffectAdder()
        {
            InitializeComponent();
            comboBoxEffectableTypes.DataSource = Enum.GetValues(typeof(Utilities.EffectableTypes));
            foreach (String ef in Enum.GetNames(typeof(EffectHolder.EffectType)))
            {
                cboBoxEffect.Items.Add(ef);
            }
            foreach (String ef in Enum.GetNames(typeof(EffectHolder.EffectTag)))
            {
                cboBoxTag.Items.Add(ef);
            }
            foreach (Utilities.DamageType dt in Enum.GetValues(typeof(Utilities.DamageType)))
            {
                cboBoxDamageType.Items.Add(dt);
            }
            cboBoxDamageType.Items.Insert(0, "");
            cboBoxName.SelectedIndex = -1;
            UpdateRtb();
        }

        private Effect readForm()
        {
            if (!ValidateAll())
                return null;

            EffectHolder.EffectType myStatus;
            Enum.TryParse(cboBoxEffect.Text, out myStatus);

            EffectHolder.EffectTag tag;
            Enum.TryParse(cboBoxTag.Text, out tag);

            Utilities.DamageType? dt;
            Utilities.DamageType dtTemp;
            Enum.TryParse(cboBoxDamageType.Text, out dtTemp);
            dt = dtTemp;
            if (cboBoxDamageType.Text == "")
                dt = null;

            Effect NewEffect = new Effect(myStatus, Convert.ToDouble(txtBoxStrength.Text), Convert.ToInt32(txtBoxLength.Text), Convert.ToDouble(txtBoxDeterioration.Text));

            NewEffect.effectTag = tag;
            Utilities.forceTypesToConformToTag(NewEffect);

            NewEffect.damageType = dt;
            return NewEffect;
        }

        // when the save effect button is pressed
        //reads the form, and adds the effect
        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateAll())
                return;
            Effect NewEffect = readForm();
            if(Utilities.EffectableTypes.Character == (Utilities.EffectableTypes)comboBoxEffectableTypes.SelectedItem)
            {                
                EffectHolder.CreateEffect(NewEffect, Utilities.getCharacterFromXmlOrCombatHolderByString(cboBoxName.Text), ckBoxPermanent.Checked);
            }
            else
            {
                Item toAffect = new Item();

                if (comboBoxEffectableTypes.Text == "Item")
                    toAffect = Utilities.GetItemByName(cboBoxName.Text);
                if (comboBoxEffectableTypes.Text == "Shield")
                    toAffect = Utilities.GetShieldByName(cboBoxName.Text);
                if (comboBoxEffectableTypes.Text == "Weapon")
                    toAffect = Utilities.GetWeaponByName(cboBoxName.Text);
                if (comboBoxEffectableTypes.Text == "Armor")
                    toAffect = Utilities.GetArmorByName(cboBoxName.Text);

                toAffect.ItemEffects.Add(NewEffect);

                if (comboBoxEffectableTypes.Text == "Item")
                    Utilities.SaveItem(toAffect);
                if (comboBoxEffectableTypes.Text == "Shield")
                    Utilities.SaveShield((Shield)toAffect);
                if (comboBoxEffectableTypes.Text == "Weapon")
                    Utilities.SaveWeapon((Weapon)toAffect);
                if (comboBoxEffectableTypes.Text == "Armor")
                    Utilities.SaveArmor((Armor)toAffect);

                Utilities.SaveItem(toAffect);
            }


            UpdateRtb();
        }

        // when the clear effect button is pressed
        // reads form the form, then tries to remove the effect that matches that description
        private void button2_Click(object sender, EventArgs e)
        {
            if (!ValidateAll())
                return;
            Effect EffectToRemove = readForm();
            if (Utilities.EffectableTypes.Character == (Utilities.EffectableTypes)comboBoxEffectableTypes.SelectedItem)
            {
                EffectHolder.RemoveEffect(EffectToRemove, Utilities.getCharacterFromXmlOrCombatHolderByString(cboBoxName.Text), ckBoxPermanent.Checked);
            }
            else
            {
                Item toAffect = new Item();

                if (comboBoxEffectableTypes.Text == "Item")
                    toAffect = Utilities.GetItemByName(cboBoxName.Text);
                if (comboBoxEffectableTypes.Text == "Shield")
                    toAffect = Utilities.GetShieldByName(cboBoxName.Text);
                if (comboBoxEffectableTypes.Text == "Weapon")
                    toAffect = Utilities.GetWeaponByName(cboBoxName.Text);
                if (comboBoxEffectableTypes.Text == "Armor")
                    toAffect = Utilities.GetArmorByName(cboBoxName.Text);
                
                toAffect.ItemEffects.Remove(EffectToRemove);

                if (comboBoxEffectableTypes.Text == "Item")
                    Utilities.SaveItem(toAffect);
                if (comboBoxEffectableTypes.Text == "Shield")
                    Utilities.SaveShield((Shield)toAffect);
                if (comboBoxEffectableTypes.Text == "Weapon")
                    Utilities.SaveWeapon((Weapon)toAffect);
                if (comboBoxEffectableTypes.Text == "Armor")
                    Utilities.SaveArmor((Armor)toAffect);

                Utilities.SaveItem(toAffect);
            }

            UpdateRtb();

        }


        private void UpdateRtb()
        {
            updateTxtBoxes = false;

            var selectedName = cboBoxName.SelectedItem;
            string s = "";
            if (selectedName != null) {
                s = selectedName.ToString();
            }
            else
            {
                return;
            }
            
            rtbActiveEffects.Text = "";
            selectableEffects.Clear();


            if (Utilities.EffectableTypes.Character == (Utilities.EffectableTypes)comboBoxEffectableTypes.SelectedItem)
            {
                if (ckBoxPermanent.Checked)
                {
                    rtbActiveEffects.Text += "PERMANENT EFFECTS\n";
                    foreach (Effect ef in Utilities.getCharacterFromXmlOrCombatHolderByString(cboBoxName.Text).Effects)
                    {
                        rtbActiveEffects.Text += ef.getDisplayString() + "\n";
                        selectableEffects.Add(ef);
                    }
                }
                else
                {
                    rtbActiveEffects.Text += "TEMPORARY EFFECTS\n";
                    foreach (Effect ef in Utilities.getCharacterFromXmlOrCombatHolderByString(cboBoxName.Text).TemporaryEffects)
                    {
                        rtbActiveEffects.Text += ef.getDisplayString() + "\n";
                        selectableEffects.Add(ef);
                    }
                }
            }
            else
            {
                Item itToReadFrom = new Item();

                if (comboBoxEffectableTypes.Text == "Item")
                    itToReadFrom = Utilities.GetItemByName(cboBoxName.Text);
                if (comboBoxEffectableTypes.Text == "Shield")
                    itToReadFrom = Utilities.GetShieldByName(cboBoxName.Text);
                if (comboBoxEffectableTypes.Text == "Weapon")
                    itToReadFrom = Utilities.GetWeaponByName(cboBoxName.Text);
                if (comboBoxEffectableTypes.Text == "Armor")
                    itToReadFrom = Utilities.GetArmorByName(cboBoxName.Text);
                foreach (Effect ef in itToReadFrom.ItemEffects)
                {
                    rtbActiveEffects.Text += ef.getDisplayString() + "\n";
                    selectableEffects.Add(ef);
                }
            }


            comboBox1.Items.Clear();
            for (int i = 0; i < selectableEffects.Count; i++)
            {
                string effectTypes = "";
                foreach (EffectHolder.EffectType et in selectableEffects.ElementAt(i).effectTypes)
                {
                    effectTypes += et.ToString() + " ";
                }
                comboBox1.Items.Add(i.ToString() + " " + effectTypes);
            }
            comboBox1.SelectedIndex = -1;

            updateTxtBoxes = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateRtb();
        }

        private void cboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRtb();
        }



        //top selector cbobox changed
        // meant to get a particular effect and populate the text boxes with its values
        // makes it wayyyy easier to delete an effect
        // based off the "selectable effects" list
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!updateTxtBoxes)
            {
                return;
            }
            

            Effect eff = selectableEffects.ElementAt(comboBox1.SelectedIndex);
            cboBoxTag.SelectedItem = eff.effectTag.ToString();
            if (eff.effectTag == EffectHolder.EffectTag.NoTag)
            {
                cboBoxEffect.SelectedItem = eff.effectTypes.First().ToString();
            }
            else
            {
                cboBoxEffect.SelectedIndex = -1;
            }
            cboBoxDamageType.SelectedItem = eff.damageType;
            txtBoxStrength.Text = eff.effectStrength.ToString();
            txtBoxLength.Text = eff.effectLength.ToString();
            txtBoxDeterioration.Text = eff.deterioration.ToString();
        }

        private void comboBoxEffectableTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Utilities.EffectableTypes.Character == (Utilities.EffectableTypes)comboBoxEffectableTypes.SelectedItem)
            {
                List<String> names = Utilities.GetCharacterNames();
                foreach (string combatName in CombatHolder.getInCombatCharNames())
                {
                    names.Add(combatName);
                }
                names.Insert(0, "");
                cboBoxName.DataSource = names;
            }
            else
            {
                Item itToReadFrom = new Item();                

                if (comboBoxEffectableTypes.Text == "Item")
                    cboBoxName.DataSource = Utilities.GetItemNames();
                if (comboBoxEffectableTypes.Text == "Shield")
                    cboBoxName.DataSource = Utilities.GetShieldNames();
                if (comboBoxEffectableTypes.Text == "Weapon")
                    cboBoxName.DataSource = Utilities.GetWeaponNames();
                if (comboBoxEffectableTypes.Text == "Armor")
                    cboBoxName.DataSource = Utilities.GetArmorNames();

            }
        }

        private void ckBoxPermanent_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRtb();
        }
    }
}
