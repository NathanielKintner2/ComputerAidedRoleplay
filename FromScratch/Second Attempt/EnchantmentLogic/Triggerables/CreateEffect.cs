using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.Serialization;

namespace Second_Attempt.EnchantmentLogic
{
    [DataContract]
    public class CreateEffect : Logic, Triggerable
    {
        public Logic parent;
        [DataMember]
        public Calculable potency;
        [DataMember]
        public Calculable length;
        [DataMember]
        public Calculable deterioration;
        [DataMember]
        public EnchantmentUtilities.CharacterSelectionSubmenu target;
        [DataMember]
        public string effectType;
        [DataMember]
        public string effectTag;
        [DataMember]
        public string damageType;
        [DataMember]
        public String name;
        public Form display;
        [DataMember]
        public String logicType = "CreateEffect";
        public String LogicType
        {
            get { return logicType; }
            set { logicType = value; }
        }
        public Form Display
        {
            get { return display; }
            set { display = value; }
        }
        public Logic Parent
        {
            get { return parent; }
            set { parent = value; }
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public Character GetParentChar()
        {
            return parent.GetParentChar();
        }

        public void UpdateAfterSave()
        {
            if (potency != null)
            {
                ((Logic)potency).Parent = this;
                ((Logic)potency).UpdateAfterSave();
            }
            if (length != null)
            {
                ((Logic)length).Parent = this;
                ((Logic)length).UpdateAfterSave();
            }
            if (deterioration != null)
            {
                ((Logic)deterioration).Parent = this;
                ((Logic)deterioration).UpdateAfterSave();
            }
        }

        public Dictionary<String, Object[]> GetVariables()
        {
            return parent.GetVariables();
        }

        public void Delete()
        {
            if (display != null)
                this.display.Close();
            if (potency != null)
                ((Logic)potency).Delete();
            this.potency = null;
            if (length != null)
                ((Logic)length).Delete();
            this.length = null;
            if (deterioration != null)
                ((Logic)deterioration).Delete();
            this.deterioration = null;
            this.parent = null;
        }
        public Character getCharByAccessString(EnchantmentParameters ep, string str)
        {
            switch (str)
            {
                case "Attacker":
                    return ep.ao.Attacker;
                case "Defender":
                    return ep.ao.Defender;
                case "Caster":
                    return ep.stc.caster;
                default:
                    return new Character();
            }
        }
        public double Trigger(EnchantmentParameters ep)
        {
            double? pot = potency.Calculate(ep);
            double? len = length.Calculate(ep);
            double? det = deterioration.Calculate(ep);
            if (pot != null && len != null && det != null)
            {
                double p = (double)pot;
                double l = (double)len;
                double d = (double)det;

                Character charToEffect = getCharByAccessString(ep, target.ToString());
                if(charToEffect.CombatStuff == null ||
                   charToEffect.CombatStuff.CombatName == ""||
                   !CombatHolder._inCombatChars.Any(A => A.CombatStuff.CombatName == charToEffect.CombatStuff.CombatName))
                {
                    return 0.0;
                }
                EffectHolder.EffectType efftype;
                bool parsedType = Enum.TryParse(EnchantmentUtilities.checkForVariable(effectType, this), out efftype);
                if (effectType!= null && effectType != "" && !parsedType)
                {
                    MessageBox.Show("Invalid effect Type");
                    return 0.0;
                }
                EffectHolder.EffectTag efftag;
                bool parsedTag = Enum.TryParse(EnchantmentUtilities.checkForVariable(effectTag, this), out efftag);
                if (effectTag != null && effectTag != "" && !parsedTag)
                {
                    MessageBox.Show("Invalid effect tag");
                    return 0.0;
                }
                Utilities.DamageType? damtype;
                Utilities.DamageType tempdamtype;
                bool parsedDam = Enum.TryParse(EnchantmentUtilities.checkForVariable(damageType, this), out tempdamtype);
                damtype = tempdamtype;
                if (EnchantmentUtilities.checkForVariable(damageType, this) == "")
                    damtype = null;
                if (damageType != null && damageType != "" && !parsedDam)
                {
                    MessageBox.Show("Invalid damage Type");
                    return 0.0;
                }
                Effect e = new Effect(efftype, p, (int)l, d);
                e.effectTag = efftag;

                Utilities.forceTypesToConformToTag(e);

                e.damageType = damtype;

                EffectHolder.CreateEffect(e, charToEffect, false);
            }
            return 0.0;
        }
    }
}

