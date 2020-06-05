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
    public partial class ArmorCreator : Form
    {
        Armor currentArmor = new Armor();
        public ArmorCreator()
        {
            InitializeComponent();
            cboBoxArmors.SelectedIndexChanged -= cboBoxArmor_SelectedIndexChanged;
            cboBoxArmors.DataSource = Utilities.GetArmorNames();
            cboBoxArmors.SelectedIndexChanged += cboBoxArmor_SelectedIndexChanged;
            foreach (Utilities.DamageType dt in Enum.GetValues(typeof(Utilities.DamageType)))
            {
                cboBoxResistanceType.Items.Add(dt);
                cboBoxReductionType.Items.Add(dt);
            }
            comboBoxBodyParts.DataSource = Enum.GetValues(typeof(Utilities.BodyParts));
            updateRTB();
        }

        #region Validation

        private bool ValidateAll()
        {
            if (!Utilities.ValidateDoubleTextBox(txtBoxWeight.Text))
                return false;
            if (!Utilities.ValidateDoubleOrNegativeTextBox(txtBoxOffensiveBonus.Text))
                return false;
            if (!Utilities.ValidateDoubleOrNegativeTextBox(txtBoxDefensiveBonus.Text))
                return false;
            if (!Utilities.ValidateDoubleTextBox(txtBoxStaminaReq.Text))
                return false;

            //All valid!
            return true;
        }

        #endregion

        private void buttonSaveArmor_Click(object sender, EventArgs e)
        {
            if (!ValidateAll())
                return;

            if (!Utilities.GetArmorNames().Contains(txtBoxArmorName.Text)) {
                currentArmor = new Armor { DamageResistanceTypes = currentArmor.DamageResistanceTypes, DamageReductionTypes = currentArmor.DamageReductionTypes, CoveredAreas = currentArmor.CoveredAreas };
            }
            currentArmor.Description = rtbWeaponDescription.Text;
            currentArmor.ItemName = txtBoxArmorName.Text;
            currentArmor.Weight = Convert.ToDouble(txtBoxWeight.Text);
            currentArmor.OffensiveBonus = Convert.ToDouble(txtBoxOffensiveBonus.Text);
            currentArmor.DefensiveBonus = Convert.ToDouble(txtBoxDefensiveBonus.Text);
            currentArmor.StaminaRequirement = Convert.ToDouble(txtBoxStaminaReq.Text);
            Utilities.SaveArmor(currentArmor);
            //necessary because setting the datasource sets the index and that resets the selected armor
            string nameSaver = currentArmor.ItemName;
            cboBoxArmors.DataSource = Utilities.GetArmorNames();
            cboBoxArmors.SelectedItem = nameSaver;

        }

        private void cboBoxArmor_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentArmor = Utilities.GetArmorByName(cboBoxArmors.Text);
            txtBoxArmorName.Text = currentArmor.ItemName;
            rtbWeaponDescription.Text = currentArmor.Description;
            txtBoxWeight.Text = Convert.ToString(currentArmor.Weight);
            txtBoxOffensiveBonus.Text = Convert.ToString(currentArmor.OffensiveBonus);
            txtBoxDefensiveBonus.Text = Convert.ToString(currentArmor.DefensiveBonus);
            txtBoxStaminaReq.Text = currentArmor.StaminaRequirement.ToString();
            txtBoxResistanceEfficacy.Text = "";
            txtBoxReductionEfficacy.Text = "";
            cboBoxResistanceType.SelectedIndex = -1;
            cboBoxReductionType.SelectedIndex = -1;
            writeResistanceTypes();
            writeReductionTypes();
            writeCoverAreas();
            updateRTB();
        }

        private void updateRTB()
        {
            richTextBoxTechnical.Text = currentArmor.TechnicalDescription();
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBoxArmorName.Text = "";
            txtBoxWeight.Text = "";
            txtBoxOffensiveBonus.Text = "";
            txtBoxDefensiveBonus.Text = "";
            txtBoxResistanceEfficacy.Text = "";
            cboBoxResistanceType.Text = "";
            cboBoxReductionType.Text = "";
            txtBoxStaminaReq.Text = "";
            cboBoxResistanceType.SelectedIndex = -1;
            cboBoxReductionType.SelectedIndex = -1;
            rtbResistanceTypes.Text = "";
            rtbReductionTypes.Text = "";
            rtbWeaponDescription.Text = "";
        }

        private void buttonChangeResistance_Click(object sender, EventArgs e)
        {
            if (!Utilities.ValidateComboBox(cboBoxResistanceType.Text))
                return;
            if (!Utilities.ValidateDoubleTextBox(txtBoxResistanceEfficacy.Text))
                return;
            //get the appropriate enum version of the damage type
            Utilities.DamageType myStatus;
            Enum.TryParse(cboBoxResistanceType.Text, out myStatus);
            //if the efficacy is zero, remove it from the dictionary of damage types
            if (Convert.ToDouble(txtBoxResistanceEfficacy.Text) == 0.0)
            {
                currentArmor.DamageResistanceTypes.Remove(myStatus);
            }
            //otherwise, add or update it
            else if (currentArmor.DamageResistanceTypes.ContainsKey(myStatus))
            {
                currentArmor.DamageResistanceTypes[myStatus] = Convert.ToDouble(txtBoxResistanceEfficacy.Text);
            }
            else
            {
                currentArmor.DamageResistanceTypes.Add(myStatus, Convert.ToDouble(txtBoxResistanceEfficacy.Text));
            }
            writeResistanceTypes();
        }

        private void buttonChangeReduction_Click(object sender, EventArgs e)
        {
            if (!Utilities.ValidateComboBox(cboBoxReductionType.Text))
                return;
            if (!Utilities.ValidateDoubleTextBox(txtBoxReductionEfficacy.Text))
                return;
            //get the appropriate enum version of the damage type
            Utilities.DamageType myStatus;
            Enum.TryParse(cboBoxReductionType.Text, out myStatus);
            //if the efficacy is zero, remove it from the dictionary of damage types
            if (Convert.ToDouble(txtBoxReductionEfficacy.Text) == 0.0)
            {
                currentArmor.DamageReductionTypes.Remove(myStatus);
            }
            //otherwise, add or update it
            else if (currentArmor.DamageReductionTypes.ContainsKey(myStatus))
            {
                currentArmor.DamageReductionTypes[myStatus] = Convert.ToDouble(txtBoxReductionEfficacy.Text);
            }
            else
            {
                currentArmor.DamageReductionTypes.Add(myStatus, Convert.ToDouble(txtBoxReductionEfficacy.Text));
            }
            writeReductionTypes();
        }

        private void writeResistanceTypes()
        {
            rtbResistanceTypes.Text = "";
            foreach (Utilities.DamageType dt in currentArmor.DamageResistanceTypes.Keys)
            {
                rtbResistanceTypes.Text += dt.ToString() + "\t" + currentArmor.DamageResistanceTypes[dt].ToString() + "\n";
            }
        }

        private void writeReductionTypes()
        {
            rtbReductionTypes.Text = "";
            foreach (Utilities.DamageType dt in currentArmor.DamageReductionTypes.Keys)
            {
                rtbReductionTypes.Text += dt.ToString() + "\t" + currentArmor.DamageReductionTypes[dt].ToString() + "\n";
            }
        }

        private void writeCoverAreas()
        {
            richTextBoxCoverAreas.Text = "";
            foreach (Utilities.BodyParts bp in currentArmor.CoveredAreas)
            {
                richTextBoxCoverAreas.Text += bp.ToString() + "\n";
            }
        }
        

        private void buttonToggleCover_Click(object sender, EventArgs e)
        {
            Utilities.BodyParts part = (Utilities.BodyParts)comboBoxBodyParts.SelectedItem;
            if (currentArmor.CoveredAreas.Contains(part))
            {
                currentArmor.CoveredAreas.Remove(part);
            }
            else
            {
                currentArmor.CoveredAreas.Add(part);
            }
            writeCoverAreas();
        }
        //toggle all parts
        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Utilities.BodyParts part in Enum.GetValues(typeof(Utilities.BodyParts)))
            {
                if (currentArmor.CoveredAreas.Contains(part))
                {
                    currentArmor.CoveredAreas.Remove(part);
                }
                else
                {
                    currentArmor.CoveredAreas.Add(part);
                }
            }
            writeCoverAreas();
        }

        private void buttonSuite_Click(object sender, EventArgs e)
        {
            if (currentArmor.CoveredAreas.Any() || currentArmor.ItemName == "")
            {
                return;
            }/* Verbose version
            Utilities.SaveArmor(createFromMaterial(currentArmor, new List<Utilities.BodyParts>() { Utilities.BodyParts.Head }, "Helm"));
            Utilities.SaveArmor(createFromMaterial(currentArmor, new List<Utilities.BodyParts>() { Utilities.BodyParts.Head, Utilities.BodyParts.Neck }, "Coif"));
            Utilities.SaveArmor(createFromMaterial(currentArmor, new List<Utilities.BodyParts>() { Utilities.BodyParts.Neck }, "Gorget"));
            Utilities.SaveArmor(createFromMaterial(currentArmor, new List<Utilities.BodyParts>() { Utilities.BodyParts.Chest }, "Breastplate"));
            Utilities.SaveArmor(createFromMaterial(currentArmor, new List<Utilities.BodyParts>() { Utilities.BodyParts.Chest, Utilities.BodyParts.Gut }, "Cuirass"));
            Utilities.SaveArmor(createFromMaterial(currentArmor, new List<Utilities.BodyParts>() { Utilities.BodyParts.Gut }, "Plackart"));
            Utilities.SaveArmor(createFromMaterial(currentArmor, new List<Utilities.BodyParts>() { Utilities.BodyParts.Chest, Utilities.BodyParts.Gut, Utilities.BodyParts.RightArm, Utilities.BodyParts.LeftArm, Utilities.BodyParts.LeftShoulder, Utilities.BodyParts.RightShoulder }, "Coat"));
            Utilities.SaveArmor(createFromMaterial(currentArmor, new List<Utilities.BodyParts>() { Utilities.BodyParts.LeftShoulder, Utilities.BodyParts.RightShoulder }, "Pauldrons"));
            Utilities.SaveArmor(createFromMaterial(currentArmor, new List<Utilities.BodyParts>() { Utilities.BodyParts.LeftArm, Utilities.BodyParts.RightArm }, "Vambraces"));
            Utilities.SaveArmor(createFromMaterial(currentArmor, new List<Utilities.BodyParts>() { Utilities.BodyParts.LeftHand, Utilities.BodyParts.RightHand, Utilities.BodyParts.LeftArm, Utilities.BodyParts.RightArm }, "Gauntlets"));
            Utilities.SaveArmor(createFromMaterial(currentArmor, new List<Utilities.BodyParts>() { Utilities.BodyParts.LeftHand, Utilities.BodyParts.RightHand }, "Gloves"));
            Utilities.SaveArmor(createFromMaterial(currentArmor, new List<Utilities.BodyParts>() { Utilities.BodyParts.Groin }, "Faulds"));
            Utilities.SaveArmor(createFromMaterial(currentArmor, new List<Utilities.BodyParts>() { Utilities.BodyParts.LeftCalf, Utilities.BodyParts.RightCalf, Utilities.BodyParts.LeftThigh, Utilities.BodyParts.RightThigh, Utilities.BodyParts.Groin }, "Leggings"));
            Utilities.SaveArmor(createFromMaterial(currentArmor, new List<Utilities.BodyParts>() { Utilities.BodyParts.LeftThigh, Utilities.BodyParts.RightThigh }, "Cuisse"));
            Utilities.SaveArmor(createFromMaterial(currentArmor, new List<Utilities.BodyParts>() { Utilities.BodyParts.LeftCalf, Utilities.BodyParts.RightCalf }, "Greaves"));
            Utilities.SaveArmor(createFromMaterial(currentArmor, new List<Utilities.BodyParts>() { Utilities.BodyParts.LeftCalf, Utilities.BodyParts.RightCalf, Utilities.BodyParts.LeftFoot, Utilities.BodyParts.RightFoot }, "Boots"));
            Utilities.SaveArmor(createFromMaterial(currentArmor, new List<Utilities.BodyParts>() { Utilities.BodyParts.LeftFoot, Utilities.BodyParts.RightFoot }, "Sabatons"));
            */
            
            Utilities.SaveArmor(createFromMaterial(currentArmor, new List<Utilities.BodyParts>() { Utilities.BodyParts.Head, Utilities.BodyParts.Neck }, "Helm"));
            Utilities.SaveArmor(createFromMaterial(currentArmor, new List<Utilities.BodyParts>() { Utilities.BodyParts.Chest, Utilities.BodyParts.Gut, Utilities.BodyParts.RightArm, Utilities.BodyParts.LeftArm, Utilities.BodyParts.LeftShoulder, Utilities.BodyParts.RightShoulder }, "Coat"));
            Utilities.SaveArmor(createFromMaterial(currentArmor, new List<Utilities.BodyParts>() { Utilities.BodyParts.LeftHand, Utilities.BodyParts.RightHand }, "Gloves"));
            Utilities.SaveArmor(createFromMaterial(currentArmor, new List<Utilities.BodyParts>() { Utilities.BodyParts.LeftCalf, Utilities.BodyParts.RightCalf, Utilities.BodyParts.LeftThigh, Utilities.BodyParts.RightThigh, Utilities.BodyParts.Groin }, "Leggings"));
            Utilities.SaveArmor(createFromMaterial(currentArmor, new List<Utilities.BodyParts>() { Utilities.BodyParts.LeftFoot, Utilities.BodyParts.RightFoot }, "Boots"));
            //necessary because setting the datasource sets the index and that resets the selected armor
            string nameSaver = currentArmor.ItemName;
            cboBoxArmors.DataSource = Utilities.GetArmorNames();
            cboBoxArmors.SelectedItem = nameSaver;
        }

        private Armor createFromMaterial(Armor material, List<Utilities.BodyParts> areas, string armorname)
        {
            Armor ret = (Armor)Item.Deserialize(material.Serialize(), typeof(Armor));
            ret.CoveredAreas = areas;
            double weightmultiplier = areas.Count();
            foreach (Utilities.BodyParts bp in areas)
            {
                if (bp.ToString().ToLower().Contains("left") || bp.ToString().ToLower().Contains("right"))
                {
                    weightmultiplier -= 0.5;
                }
            }

            ret.Weight = ret.Weight * weightmultiplier;
            ret.StaminaRequirement = ret.StaminaRequirement * weightmultiplier;
            ret.ItemName = material.ItemName + " " + armorname;
            return ret;
        }
    }
}
