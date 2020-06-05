using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Second_Attempt.EnchantmentLogic;

namespace Second_Attempt
{
    
    public static class EffectHolder
    {
        public enum EffectType
        {
            Strength,
            Dexterity,
            Constitution,
            Wisdom,
            Intelligence,
            Charisma,
            Reflex,
            OB,
            DB,
            WeaponDamage,
            ShieldCoverage,
            Regeneration,
            StaminaGain,
            DamageResistance,
            DamageReduction,
            BlockingDifficulty,
            Focus,
            Health,
            KO,
            Weight,
            ResistHarm,
            ResistBleed,
            ResistDisorientation,
            ResistImpairment,
            ResistTrauma,
            ResistKO,
            InflictHarm,
            InflictBleed,
            InflictDisorientation,
            InflictImpairment,
            InflictTrauma,
            InflictKO,
            SpellBonus
        }
        // for effects that need 'healing', that have a special effect
        // when the value of effectStrength is positive
        public enum EffectTag
        {
            NoTag,
            Bleed,
            Trauma,
            Disorientation,
            NerveImpairment,
            BoneImpairment,
            MuscleImpairment
        }

        public delegate bool EffectCompare(Effect goal, Effect test);
        public static bool TagOnly(Effect goal, Effect test)
        {
            return goal.effectTag == test.effectTag;
        }
        public static bool TypeOnly(Effect goal, Effect test)
        {
            return test.effectTypes.Contains(goal.effectTypes[0]);
        }
        public static bool TypeAndDamage(Effect goal, Effect test)
        {
            return test.effectTypes.Contains(goal.effectTypes[0]) && test.damageType == goal.damageType;
        }
        public static List<String> allEffectTagsAndTypes()
        {
            List<String> ret = new List<string>();
            foreach (EffectType et in Enum.GetValues(typeof(EffectType)))
            {
                ret.Add(et.ToString());
            }
            foreach (EffectTag et in Enum.GetValues(typeof(EffectTag)))
            {
                ret.Add(et.ToString());
            }
            return ret;
        }

        public static void CreateEffect (Effect toAdd, Character c, bool isPermanent)
        {
            Utilities.forceTypesToConformToTag(toAdd);
            if (toAdd.effectStrength > 0)
            {
                List<Effect> toDecFrom = new List<Effect>();
                if (isPermanent)
                {
                    toDecFrom = c.Effects;
                }
                else
                {
                    toDecFrom = c.TemporaryEffects;
                }
                switch (toAdd.effectTag)
                {
                    case EffectHolder.EffectTag.Bleed:
                        DecrementTaggedEffect(toAdd, true, toDecFrom);
                        Utilities.SaveCharacter(c);
                        CombatHolder.UpdateCharInventorySpellsSkillsEffectsAndStats(c);
                        return;
                    case EffectHolder.EffectTag.Trauma:
                        DecrementTaggedEffect(toAdd, true, toDecFrom);
                        Utilities.SaveCharacter(c);
                        CombatHolder.UpdateCharInventorySpellsSkillsEffectsAndStats(c);
                        return;
                    case EffectHolder.EffectTag.BoneImpairment:
                        DecrementTaggedEffect(toAdd, false, toDecFrom);
                        Utilities.SaveCharacter(c);
                        CombatHolder.UpdateCharInventorySpellsSkillsEffectsAndStats(c);
                        return;
                    case EffectHolder.EffectTag.MuscleImpairment:
                        DecrementTaggedEffect(toAdd, false, toDecFrom);
                        Utilities.SaveCharacter(c);
                        CombatHolder.UpdateCharInventorySpellsSkillsEffectsAndStats(c);
                        return;
                    case EffectHolder.EffectTag.NerveImpairment:
                        DecrementTaggedEffect(toAdd, false, toDecFrom);
                        Utilities.SaveCharacter(c);
                        CombatHolder.UpdateCharInventorySpellsSkillsEffectsAndStats(c);
                        return;
                    case EffectHolder.EffectTag.Disorientation:
                        DecrementTaggedEffect(toAdd, true, toDecFrom);
                        Utilities.SaveCharacter(c);
                        CombatHolder.UpdateCharInventorySpellsSkillsEffectsAndStats(c);
                        return;
                    case EffectHolder.EffectTag.NoTag:
                        break;
                }
            }
            if (isPermanent)
            {
                c.Effects.Add(toAdd);
                Utilities.SaveCharacter(c);
                CombatHolder.UpdateCharInventorySpellsSkillsEffectsAndStats(c);
            }
            else
            {
                c.TemporaryEffects.Add(toAdd);
            }
        }

        public static void DecrementTaggedEffect(Effect toDecWith, bool decRounds, List<Effect> toDecFrom)
        {
            while (toDecWith.effectStrength != 0)
            {
                Effect highest = new Effect(EffectType.DamageResistance, 0, 0, 0);
                foreach (Effect e in toDecFrom)
                {
                    if (e.effectTag == toDecWith.effectTag &&
                        Math.Abs(e.effectStrength) > Math.Abs(highest.effectStrength))
                    {
                        highest = e;
                    }
                }
                double decamount = System.Math.Min(System.Math.Abs(highest.effectStrength), toDecWith.effectStrength);
                if (decamount == 0) {
                    break;
                }
                highest.effectStrength += decamount;
                toDecWith.effectStrength -= decamount;
                if (decRounds) {
                    highest.effectLength -= (int)decamount;
                    highest.effectStrength = -1 * highest.effectLength;
                }
                ClearUselessEffects();
            }
        }
        public static void RemoveEffect(Effect toRem, Character c, bool isPermanent)
        {
            Utilities.forceTypesToConformToTag(toRem);
            if (isPermanent)
            {
                Effect toRemFromChar = c.Effects.Find(A => A.Equals(toRem));
                c.Effects.Remove(toRemFromChar);
                Utilities.SaveCharacter(c);
                CombatHolder.UpdateCharInventorySpellsSkillsEffectsAndStats(c);
            }
            else
            {
                Effect toRemFromChar = c.TemporaryEffects.Find(A => A.Equals(toRem));
                c.TemporaryEffects.Remove(toRemFromChar);
            }
        }

        public static Double GetValidEffectsByEffect(Character c, EffectType desiredEffect)
        {

            EffectCompare ec = new EffectCompare(TypeOnly);
            return GetValidEffectsByDelegate(c, 
                ec, 
                new Effect() { effectTypes = new List<EffectType>() { desiredEffect } }, 
                new EnchantmentParameters() { triggerSource = EnchantmentUtilities.SourceTypes.EffectCheck, ety = desiredEffect });
        }
        // an overload of the GVEBE method that does not trigger enchantments, thereby avoiding
        // infinite loops. Use this instead of the normal method within enchantments.
        public static Double GetValidEffectsByEffect(Character c, EffectType desiredEffect, bool justForOverload)
        {
            EffectCompare ec = new EffectCompare(TypeOnly);
            return GetValidEffectsByDelegate(c,
                ec,
                new Effect() { effectTypes = new List<EffectType>() { desiredEffect } },
                null);
        }

        public static Double GetValidEffectsByEffectAndDamageType(Character c, EffectType desiredEffect, Utilities.DamageType? desiredDamageType)
        {
            EffectCompare ec = new EffectCompare(TypeAndDamage);
            return GetValidEffectsByDelegate(c,
                ec,
                new Effect() { effectTypes = new List<EffectType>() { desiredEffect }, damageType = desiredDamageType },
                new EnchantmentParameters() { triggerSource = EnchantmentUtilities.SourceTypes.EffectCheck, ety = desiredEffect, dty = desiredDamageType });
        }

        public static Double GetValidEffectsByTag(Character c, EffectTag desiredTag)
        {
            EffectCompare ec = new EffectCompare(TagOnly);
            return GetValidEffectsByDelegate(c,
                ec,
                new Effect() { effectTag = desiredTag},
                new EnchantmentParameters() { triggerSource = EnchantmentUtilities.SourceTypes.EffectCheck, eta = desiredTag });
        }
        public static Double GetValidEffectsByTag(Character c, EffectTag desiredTag, bool justForOverload)
        {
            EffectCompare ec = new EffectCompare(TagOnly);
            return GetValidEffectsByDelegate(c,
                ec,
                new Effect() { effectTag = desiredTag },
                null);
        }
        public static Double GetValidEffectsByDelegate(Character c, EffectCompare comp, Effect goal, EnchantmentParameters ep)
        {
            double effectAmount = 0;
            foreach(Effect ef in c.TemporaryEffects)
            {
                //the effect has the correct effect
                if (comp(goal, ef))
                {
                    effectAmount = effectAmount + ef.effectStrength;
                }
            }
            foreach (Effect ef in c.Effects)
            {
                //the effect has the correct effect
                if (comp(goal, ef))
                {
                    effectAmount = effectAmount + ef.effectStrength;
                }
            }
            foreach (Item it in c.Items)
            {
                foreach (Effect ef in it.ItemEffects)
                {
                    //the effect has the correct effect
                    if (comp(goal, ef))
                    {
                        effectAmount = effectAmount + ef.effectStrength;
                    }
                }
            }
            if(c.CombatStuff != null)
            {
                if(c.CombatStuff.CombatWeapon != null)
                {
                    if(c.CombatStuff.CombatWeapon.ItemEffects != null)
                    {
                        foreach (Effect ef in c.CombatStuff.CombatWeapon.ItemEffects)
                        {
                            //the effect has the correct effect
                            if (comp(goal, ef))
                            {
                                effectAmount = effectAmount + ef.effectStrength;
                            }
                        }
                    }
                }
            }
            if (ep != null)
            {
                effectAmount += EnchantmentUtilities.triggerAllEnchantmentsForChar(c, ep);
            }
            return effectAmount;
        }

        public static void ClearUselessEffects()
        {
            foreach(Character c in CombatHolder._inCombatChars)
            {
                ClearUselessEffects(c.TemporaryEffects);
            }
        }
        private static void ClearUselessEffects(List<Effect> toClearFrom)
        {
            //working backwards to avoid issues when removing effects
            for (int i = toClearFrom.Count; i > 0; i--)
            {
                Effect ef = toClearFrom[i - 1];
                if ((ef.effectStrength == 0 && ef.deterioration == 0) || ef.effectLength == 0)
                {
                    toClearFrom.Remove(ef);
                }
            }
        }

        public static void ProcAndDecayEffects() {
            foreach (Character c in CombatHolder._inCombatChars)
            {
                ProcAndDecayEffectsForSingleChar(c);
            }
        }

        public static void ProcAndDecayEffectsForSingleChar(Character c)
        {
            c.Stamina += GetValidEffectsByEffect(c, EffectType.StaminaGain);
            c.HitPoints += GetValidEffectsByEffect(c, EffectType.Regeneration);
            //working backwards to avoid issues when removing effects   
            for (int i = c.TemporaryEffects.Count; i > 0; i--)
            {
                Effect ef = c.TemporaryEffects[i - 1];
                ef.effectStrength = ef.effectStrength + ef.deterioration;
                if (ef.effectLength > 0)
                {
                    ef.effectLength = ef.effectLength - 1;
                }
                if (ef.effectLength == 0)
                {
                    c.TemporaryEffects.Remove(ef);
                }
            }
        }
    }
}
