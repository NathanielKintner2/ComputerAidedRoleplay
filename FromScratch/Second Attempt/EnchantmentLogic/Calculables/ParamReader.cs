using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.Serialization;

namespace Second_Attempt.EnchantmentLogic
{
    [DataContract]
    class ParamReader : Logic, Calculable
    {
        public Logic parent;
        [DataMember]
        public String name;
        public Form display;
        [DataMember]
        public String logicType = "ParamReader";
        [DataMember]
        public string Branch1;
        [DataMember]
        public string Branch2;
        [DataMember]
        public string Branch3;
        [DataMember]
        public string Branch4;
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
        }

        public Dictionary<String, Object[]> GetVariables()
        {
            return parent.GetVariables();
        }

        public void Delete()
        {
            if (display != null)
                this.display.Close();
            this.parent = null;
        }

        public double? Calculate(EnchantmentParameters ep)
        {
            string Branch1forcalc = EnchantmentUtilities.checkForVariable(Branch1, this);
            string Branch2forcalc = EnchantmentUtilities.checkForVariable(Branch2, this);
            string Branch3forcalc = EnchantmentUtilities.checkForVariable(Branch3, this);
            try
            {
                switch (Branch1forcalc)
                {
                    case "AttackStats":
                        if (ep.ao == null)
                            return null;
                        switch (Branch2forcalc)
                        {
                            case "AttackResult":
                                double ret = 0;
                                if (ep.ao.Othertext.ToString() == Branch3forcalc)
                                {
                                    ret = 1;
                                }
                                return ret;
                            case "AttackRoll":
                                return ep.ao.Notes.attackroll;
                            case "DefendRoll":
                                return ep.ao.Notes.defendRoll;
                            case "AttackValue":
                                return ep.ao.Notes.attackValue;
                            case "DefendValue":
                                return ep.ao.Notes.defendValue;
                            case "AttackAfterParry":
                                return ep.ao.Notes.attackAfterParry;
                            case "Damage":
                                return ep.ao.TotalStrikeAmountFromAllTypes();
                            case "Harm":
                                return ep.ao.harm;
                            case "Bleed":
                                return ep.ao.bleed;
                            case "Disorientation":
                                return ep.ao.disorientation;
                            case "Impairment":
                                return ep.ao.impairment;
                            case "Trauma":
                                return ep.ao.trauma;
                            case "Ko":
                                return ep.ao.ko;
                            default:
                                return 0;
                        }
                    case "Character":
                        switch (Branch2forcalc)
                        {
                            case "Attacker":
                                if (ep.ao == null)
                                    return null;
                                return CalculateWithCharacter(ep.ao.Attacker);
                            case "Defender":
                                if (ep.ao == null)
                                    return null;
                                return CalculateWithCharacter(ep.ao.Defender);
                            case "Caster":
                                if (ep.stc == null)
                                    return null;
                                return CalculateWithCharacter(ep.stc.caster);
                            case "Parent":
                                return CalculateWithCharacter(GetParentChar());
                            default:
                                return 0;
                        }
                    case "Spell":
                        if (ep.stc == null)
                            return null;
                        switch (Branch2forcalc)
                        {
                            case "SpellPower":
                                return ep.stc.spellPower;
                            case "SpellEffects":
                                EffectHolder.EffectType ety;
                                EffectHolder.EffectTag eta;

                                Enum.TryParse(Branch3forcalc, out ety);
                                Enum.TryParse(Branch3forcalc, out eta);

                                double ret = 0; ;
                                foreach (Effect e in ep.stc.spell.SpellEffects.Keys)
                                {
                                    if ((ety.ToString() == Branch3forcalc && e.effectTypes.Contains(ety))
                                        || (eta.ToString() == Branch3forcalc && e.effectTag == eta))
                                    {
                                        //potency, length, deterioration
                                        Tuple<Double, Double, Double> t = ep.stc.spell.SpellEffects[e];
                                        ret += t.Item1 * System.Math.Abs(t.Item2);
                                    }
                                }
                                return ret;
                            default:
                                return 0;
                        }
                    default:
                        return 0;
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                //MessageBox.Show(e.Message + "\n" + e.StackTrace);
                return null;
            }
        }

        public double? CalculateWithCharacter(Character c)
        {
            string Branch3forcalc = EnchantmentUtilities.checkForVariable(Branch3, this);
            string Branch4forcalc = EnchantmentUtilities.checkForVariable(Branch4, this);
            switch (Branch3forcalc)
            {
                case "Strength":
                    return c.Statistics.Strength + EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.Strength, true);
                case "Dexterity":
                    return c.Statistics.Dexterity + EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.Dexterity, true);
                case "Constitution":
                    return c.Statistics.Constitution + EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.Constitution, true);
                case "Intelligence":
                    return c.Statistics.Intelligence + EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.Intelligence, true);
                case "Wisdom":
                    return c.Statistics.Wisdom + EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.Wisdom, true);
                case "Charisma":
                    return c.Statistics.Charisma + EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.Charisma, true);
                case "Health":
                    return c.HitPoints;
                case "Stamina":
                    return c.Stamina;
                case "SelectedWeaponName":
                    if (c.CombatStuff == null || c.CombatStuff.CombatWeapon == null)
                        return null;
                    double ret = 0;
                    if (c.CombatStuff.CombatWeapon.ItemName == Branch4forcalc)
                    {
                        ret = 1;
                    }
                    return ret;
                case "SelectedWeaponType":
                    if (c.CombatStuff == null || c.CombatStuff.CombatWeapon == null || c.CombatStuff.CombatWeapon.WeaponTypes == null)
                        return null;
                    double ret3 = 0;
                    if (c.CombatStuff.CombatWeapon.WeaponTypes.Any(A => A.ToString() == Branch4forcalc))
                    {
                        ret3 = 1;
                    }
                    return ret3;
                case "Effects":
                    EffectHolder.EffectType ety;
                    EffectHolder.EffectTag eta;
                    
                    Enum.TryParse(Branch4forcalc, out ety);                    
                    Enum.TryParse(Branch4forcalc, out eta);
                    if (ety.ToString() == Branch4forcalc)
                    {
                        return EffectHolder.GetValidEffectsByTag(c, eta, false);
                    }
                    return EffectHolder.GetValidEffectsByEffect(c, ety, false);
                case "IsParentChar":
                    double ret1 = 0;
                    if (c == GetParentChar())
                    {
                        ret1 = 1;
                    }
                    return ret1;
                case "CreatureType":
                    if (c.CreatureTypes == null)
                        return null;
                    double ret2 = 0;
                    if (c.CreatureTypes.Any(A => A.ToString() == Branch4forcalc))
                    {
                        ret2 = 1;
                    }
                    return ret2;
                default:
                    return 0;
            }
        }        
    }
}


