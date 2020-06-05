using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Second_Attempt.EnchantmentLogic.Calculables;

namespace Second_Attempt.EnchantmentLogic
{
    public static class EnchantmentUtilities
    {

        public static int layersDeep = 0;

        public static void startup()
        {
            
        }

        public static FormWithLogicSetup getCorrectFormType(String str)
        {
            switch (str)
            {
                case "MathLogic":
                    return new MathLogicForm(new MathLogic());
                case "DoubleValue":
                    return new DoubleValueForm(new DoubleValue());
                case "IfElseLogic":
                    return new IfElseLogicForm(new IfElseLogic());
                case "ReturnValue":
                    return new ReturnValueForm(new ReturnValue());
                case "PrintMessage":
                    return new PrintMessageForm(new PrintMessage());
                case "GetVariable":
                    return new GetVariableForm(new GetVariable());
                case "SetVariable":
                    return new SetVariableForm(new SetVariable());
                case "SourceCheck":
                    return new SourceCheckForm(new SourceCheck());
                case "ParamReader":
                    return new ParamReaderForm(new ParamReader());
                case "MakeAttack":
                    return new MakeAttackForm(new MakeAttack());
                case "EffectTypeCheck":
                    return new EffectTypeCheckForm(new EffectTypeCheck());
                case "CreateEffect":
                    return new CreateEffectForm(new CreateEffect());
                default:
                    return null;
            }
        }

        public static void EditLogicWithRightForm(Logic l)
        {
            FormWithLogicSetup f = getCorrectFormType(l.LogicType);
            f.Show();
            f.Setup(l);
        }

        public static void FillComboboxWithVariableNames(ComboBox cb, Logic l)
        {
            cb.Items.Clear();
            Dictionary<String, Object[]> vars = l.GetVariables();
            foreach (String s in vars.Keys)
            {
                cb.Items.Add(vars[s][0]);
            }
        }
        public static void FillComboboxWithNames(ComboBox cb, List<Calculable> names)
        {
            cb.Items.Clear();
            foreach(Logic l in names)
            {
                if (l.Name != null)
                {
                    cb.Items.Add(l.LogicType + ": " + l.Name);
                }
                else
                {
                    cb.Items.Add("Unnamed " + l.LogicType);
                }
            }
        }
        public static void FillComboboxWithNames(ComboBox cb, List<Triggerable> names)
        {
            cb.Items.Clear();
            foreach (Logic l in names)
            {
                if (l.Name != null)
                {
                    cb.Items.Add(l.LogicType + ": " + l.Name);
                }
                else
                {
                    cb.Items.Add("Unnamed " + l.LogicType);
                }
            }
        }

        public enum CalculableTypes
        {
            DoubleValue,
            MathLogic,
            GetVariable,
            SourceCheck,
            ParamReader,
            EffectTypeCheck
        }

        public enum MathTypes
        {
            Add,
            Subtract,
            Multiply,
            Divide,
            GreaterThan,
            EqualTo
        }

        public enum TriggerableTypes
        {
            PrintMessage,
            ReturnValue,
            IfElseLogic,
            SetVariable,
            MakeAttack,
            CreateEffect
        }

        public enum SourceTypes
        {
            Attack,
            PostAttack,
            Round,
            EffectCheck,
            WasAttacked,
            PostWasAttacked,
            SpellCast,
            SpellResolution,
            TargetedBySpell,
            TargetedBySpellResolves,
            CombatEntry
        }
        public enum DataSources
        {
            AttackStats,
            Character,
            Spell
                //spell target
        }
        public enum AttackParamsSubmenu
        {
            AttackResult,
            AttackRoll,
            DefendRoll,
            AttackValue,
            DefendValue,
            AttackAfterParry,
            Damage,
            Harm,
            Bleed,
            Disorientation,
            Impairment,
            Trauma,
            Ko
        }
        public enum SpellSubmenu
        {
            SpellPower,
            SpellEffects
        }
        public enum CharacterSelectionSubmenu
        {
            Attacker,
            Defender,
            Caster,
            Parent
        }
        public enum CharacterStatsSubmenu
        {
            Strength,
            Dexterity,
            Constitution,
            Intelligence,
            Wisdom,
            Charisma,
            Health,
            Stamina,
            SelectedWeaponName,
            SelectedWeaponType,
            Effects,
            IsParentChar,
            CreatureType
        }

        public static double triggerAllEnchantmentsForChar(Character c, EnchantmentParameters ep)
        {
            if(ep.ao == null)
            {
                ep.ao = c.CombatStuff.aoForEnchantments;
            }
            if(ep.stc == null)
            {
                ep.stc = c.CombatStuff.stcForEnchantments;
            }
            double ret = 0.0;
            foreach(IfElseLogic iel in c.Enchantments.Keys)
            {
                ret += iel.Trigger(ep);
            }
            foreach (Item i in c.Items)
            {
                foreach (IfElseLogic iel in i.Enchantments.Keys)
                {
                    ret += iel.Trigger(ep);
                }
            }
            if (c.CombatStuff != null)
            {
                if (c.CombatStuff.CombatWeapon != null)
                {
                    if (c.CombatStuff.CombatWeapon.ItemEffects != null)
                    {
                        foreach (IfElseLogic iel in c.CombatStuff.CombatWeapon.Enchantments.Keys)
                        {
                            ret += iel.Trigger(ep);
                        }
                    }
                }
            }
            return ret;
        }

        public static List<String> getTriggerableTypes(bool getEnchantments)
        {
            List<String> ret = new List<string>();
            foreach (TriggerableTypes tt in Enum.GetValues(typeof(TriggerableTypes)))
            {
                ret.Add(tt.ToString());
            }
            if (getEnchantments)
            {
                foreach (string str in Utilities.GetEnchantmentNames())
                {
                    ret.Add(str);
                }
            }
            
            return ret;
        }
        public static List<String> getCalculableTypes()
        {
            List<String> ret = new List<string>();
            foreach (CalculableTypes ct in Enum.GetValues(typeof(CalculableTypes)))
            {
                ret.Add(ct.ToString());
            }
            return ret;
        }

        public static string checkForVariable(string data, Logic dataHolder)
        {
            Dictionary<string, object[]> vars = dataHolder.GetVariables();
            foreach (string str in vars.Keys)
            {
                if(data == str)
                {
                    data = vars[str][1].ToString();
                    break;
                }
            }
            return data;
        }

    }
}
