using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Second_Attempt.EnchantmentLogic;

namespace Second_Attempt
{
    public static class CombatScripts
    {        

        public static AttackOutcome RunCombat(Character _attacker, Character _defender, double AttackRoll, double DefendRoll, Utilities.BodyParts? location)
        {
            AttackOutcome outcome = new AttackOutcome();
            _attacker.CombatStuff.aoForEnchantments = outcome;
            _defender.CombatStuff.aoForEnchantments = outcome;
            outcome.attackRoll = AttackRoll;
            outcome.defendRoll = DefendRoll;
            //this is to give the option of one-roll combat on the specific input of DefensiveRoll == -999.0
            /*
            if (DefendRoll == -999.0)
            {
                DefendRoll = 20 - AttackRoll;
            }*/

            outcome.Attacker = _attacker;
            outcome.Defender = _defender;

            Weapon _attackerSelectedWeapon = _attacker.CombatStuff.CombatWeapon;
            Weapon _defenderSelectedWeapon = _defender.CombatStuff.CombatWeapon;
            Shield _attackerSelectedShield = _attacker.CombatStuff.CombatShield;
            Shield _defenderSelectedShield = _defender.CombatStuff.CombatShield;

            outcome.Notes.attackerWeaponName = _attackerSelectedWeapon.ItemName;
            outcome.Notes.defenderWeaponName = _defenderSelectedWeapon.ItemName;
            outcome.Notes.stun = -1 * EffectHolder.GetValidEffectsByEffect(_defender, EffectHolder.EffectType.Focus);

            double _attackerWeightFactor = GetWeightFactor(_attacker);
            double _defenderWeightFactor = GetWeightFactor(_defender);

            double _attackerStaminaFactor = GetStaminaFactor(_attacker);
            double _defenderStaminaFactor = GetStaminaFactor(_defender);
            //primary calculators
            double offensiveCalculator = (AttackRoll + _attacker.CombatStuff.CombatOB + _attackerSelectedWeapon.OffensiveBonus + _attackerSelectedShield.OffensiveBonus + EffectHolder.GetValidEffectsByEffect(_attacker, EffectHolder.EffectType.OB) + _attackerWeightFactor) * _attackerStaminaFactor;
            double defensiveCalculator = (DefendRoll + _defender.CombatStuff.CombatDB + _defenderSelectedWeapon.DefensiveBonus + _defenderSelectedShield.DefensiveBonus + EffectHolder.GetValidEffectsByEffect(_defender, EffectHolder.EffectType.DB) + _defenderWeightFactor) * _defenderStaminaFactor;
            foreach(Armor a in _attacker.Armor)
            {
                offensiveCalculator += a.OffensiveBonus;
            }
            foreach (Armor a in _defender.Armor)
            {
                defensiveCalculator += a.DefensiveBonus;
            }

            outcome.Notes.attackroll = AttackRoll;
            outcome.Notes.attackValue = offensiveCalculator;
            outcome.Notes.defendRoll = DefendRoll;
            outcome.Notes.defendValue = defensiveCalculator;
            
            EnchantmentUtilities.triggerAllEnchantmentsForChar(_attacker, new EnchantmentParameters() { triggerSource = EnchantmentUtilities.SourceTypes.Attack });
            EnchantmentUtilities.triggerAllEnchantmentsForChar(_defender, new EnchantmentParameters() { triggerSource = EnchantmentUtilities.SourceTypes.WasAttacked });
            
            //generate reflex
            double defenderReflex = CalculateReflex(_defender, defensiveCalculator);
            //adjust by a percentage if stamina is low
            defenderReflex = defenderReflex * _defenderStaminaFactor;

            outcome.Notes.reflex = defenderReflex;

            //generate blocking difficulty
            double attackerBlockingDifficulty = _attackerSelectedWeapon.BlockingDifficulty + EffectHolder.GetValidEffectsByEffect(_attacker, EffectHolder.EffectType.BlockingDifficulty) + 0.2 * offensiveCalculator;

            outcome.Notes.blockingDifficulty = attackerBlockingDifficulty;

            //apply 25% of blocking difficulty
            defensiveCalculator -= attackerBlockingDifficulty * 0.25;

            //generate block
            double defenderBlock = defensiveCalculator * (_defenderSelectedShield.Coverage + EffectHolder.GetValidEffectsByEffect(_defender, EffectHolder.EffectType.ShieldCoverage));

            outcome.Notes.block = defenderBlock;

            //apply rest of blocking difficulty
            defensiveCalculator -= attackerBlockingDifficulty * 0.75;

            //generate parry
            double defenderParry = defensiveCalculator * _defenderSelectedWeapon.ParryStrength / System.Math.Max(_attackerSelectedWeapon.ParryBreak, 0.01);

            outcome.Notes.parryBreak = _attackerSelectedWeapon.ParryBreak;
            outcome.Notes.parryStrength = _defenderSelectedWeapon.ParryStrength;
            outcome.Notes.parry = defenderParry;
            outcome.Notes.defendValueAfterBlockingDifficulty = defensiveCalculator;


            //perform dodge
            if(defenderReflex > 0)
                offensiveCalculator -= defenderReflex;

            //if the attack has been reduced to 0, it was dodged
            if (offensiveCalculator <= 0)
            {
                outcome.Othertext = Utilities.AttackResultType.Miss;
                outcome.HitCaliber = offensiveCalculator;
                return outcome;
            }

            outcome.Notes.attackAfterReflex = offensiveCalculator;

            //perform block
            if(defenderBlock > 0)
                offensiveCalculator -= defenderBlock;

            //if the attack has been reduced to 0, it was blocked
            if (offensiveCalculator <= 0)
            {
                outcome.Othertext = Utilities.AttackResultType.Block;
                outcome.HitCaliber = offensiveCalculator;
                return outcome;
            }

            outcome.Notes.attackAfterBlock = offensiveCalculator;

            //perform parry
            if (defenderParry > 0)
                offensiveCalculator -= defenderParry;

            //if the attack has been reduced to 0, it was parried
            if (offensiveCalculator <= 0)
            {
                outcome.Othertext = Utilities.AttackResultType.Parry;
                outcome.HitCaliber = offensiveCalculator;
                return outcome;
            }

            outcome.Notes.attackAfterParry = offensiveCalculator;
            if(location == null)
            {
                Utilities.FindCritLocation(outcome);
            }
            else
            {
                outcome.HitLocation = (Utilities.BodyParts)location;
            }

            //otherwise, attacker hit! do damage/armor calculation
            Dictionary<Utilities.DamageType, Double> tempDamageValues = new Dictionary<Utilities.DamageType, double>();
            foreach (Utilities.DamageType dt in _attackerSelectedWeapon.DamageTypes.Keys)
            {
                tempDamageValues.Add(dt, _attackerSelectedWeapon.DamageTypes[dt]);
            }
            foreach (Utilities.DamageType dt in Enum.GetValues(typeof(Utilities.DamageType)))
            {
                double addedDamage = EffectHolder.GetValidEffectsByEffectAndDamageType(_attacker, EffectHolder.EffectType.WeaponDamage, dt);
                if (addedDamage != 0)
                {
                    if (tempDamageValues.ContainsKey(dt))
                    {
                        tempDamageValues[dt] += addedDamage;
                    }
                    else
                    {
                        tempDamageValues.Add(dt, addedDamage);
                    }
                }
            }
            foreach (Utilities.DamageType dt in tempDamageValues.Keys)
            {

                Double strikeAmountForDamageType = offensiveCalculator * tempDamageValues[dt];
                outcome.HitStrength = outcome.HitStrength + strikeAmountForDamageType;
                outcome.Notes.damageBeforeArmor = outcome.HitStrength;
                //actually percentage of damage that will go through
                double damageResistance = 1.0 - EffectHolder.GetValidEffectsByEffectAndDamageType(_defender, EffectHolder.EffectType.DamageResistance, null);
                damageResistance -= EffectHolder.GetValidEffectsByEffectAndDamageType(_defender, EffectHolder.EffectType.DamageResistance, dt);
                foreach(Armor arm in _defender.Armor)
                {
                    if (arm.CoveredAreas.Contains(outcome.HitLocation) && arm.DamageResistanceTypes.ContainsKey(dt))
                    {
                        //subtraction because a lower percentage of the damage will get through
                        damageResistance -= (arm.DamageResistanceTypes[dt]);
                    }
                }
                outcome.DamageTypes.Add(dt, Math.Max(0, (strikeAmountForDamageType * damageResistance)));
            }

            double generalDamageReduction = EffectHolder.GetValidEffectsByEffectAndDamageType(_defender, EffectHolder.EffectType.DamageReduction, null);
            double totalDamageBeforeReduction = outcome.TotalStrikeAmountFromAllTypes();

            //weird things happen if this is less than or equal to zero
            if (totalDamageBeforeReduction > 0)
            {
                foreach (Utilities.DamageType dt in tempDamageValues.Keys)
                {
                    //the amount of damage that will be prevented
                    outcome.DamageTypes[dt] -= generalDamageReduction * (outcome.DamageTypes[dt] / totalDamageBeforeReduction);
                    outcome.DamageTypes[dt] -= EffectHolder.GetValidEffectsByEffectAndDamageType(_defender, EffectHolder.EffectType.DamageReduction, dt);
                    foreach (Armor arm in _defender.Armor)
                    {
                        if (arm.CoveredAreas.Contains(outcome.HitLocation) && arm.DamageReductionTypes.ContainsKey(dt))
                        {
                            outcome.DamageTypes[dt] -= (arm.DamageReductionTypes[dt]);
                        }
                    }
                    if (outcome.DamageTypes[dt] < 0)
                    {
                        outcome.DamageTypes[dt] = 0;
                    }
                }
            }
            
             

            outcome.Notes.damageAfterArmor = outcome.TotalStrikeAmountFromAllTypes();

            outcome.Othertext = Utilities.AttackResultType.Hit;
            outcome.HitCaliber = offensiveCalculator;


            CritCalculator.CalculateCrit(outcome);

            EnchantmentUtilities.triggerAllEnchantmentsForChar(_attacker, new EnchantmentParameters() { triggerSource = EnchantmentUtilities.SourceTypes.PostAttack });
            EnchantmentUtilities.triggerAllEnchantmentsForChar(_defender, new EnchantmentParameters() { triggerSource = EnchantmentUtilities.SourceTypes.PostWasAttacked });

            return outcome;
        }


        public static double GetWeightFactor(Character c) {
            double weightFactor = 0.0;
            foreach(Armor arm in c.Armor)
            {
                weightFactor += arm.Weight;
            }
            foreach (Weapon w in c.Weapons)
            {
                weightFactor += w.Weight;
            }
            foreach (Shield s in c.Shields)
            {
                weightFactor += s.Weight;
            }
            weightFactor += EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.Weight);
            weightFactor = weightFactor * -1;
            weightFactor += Convert.ToDouble(c.Statistics.Strength + EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.Strength));
            weightFactor += c.Skills.ArmorSkill * 0.5;
            if (weightFactor > 0) {
                weightFactor = weightFactor * c.CombatStuff.CombatWeapon.ExcessStrengthMultiplier;
            }
            return weightFactor;
        }

        public static double GetStaminaFactor(Character c)
        {
            double staminaFactor = 1.0;
            //300 is standard stamina. Base stamina is equal to ((con-10) * 25) + 300, meaning that a con of 10 give 300 stamina, and a point
            //of con in either direction changes this value by 25 in the same direction.
            //if you get below half of your starting value, you begin to be less effective
            if (c.Stamina<(((c.Statistics.Constitution - 10) * 25) + 300.0) / 2)
            {
                //SF = (some decimal < 1, lower as stamina decreases)
                //at exactly 1/2 stamina, no effect. at 1/4 stamina, 71% effective (SF = 0.707). at 1/8 stamina, 50% effective (SF = 0.5)
                staminaFactor = System.Math.Sqrt((c.Stamina / ((((c.Statistics.Constitution - 10) * 25) + 300.0)) / 2));
            }
            if (double.IsNaN(staminaFactor))
            {
                staminaFactor = 0;
            }
            return staminaFactor;
        }

        
        public static double CalculateReflex(Character c, Double defensiveCalculator)
        {
            double d_defenderReflex = GetBaseReflex(c) + 0.2 * defensiveCalculator;
            //divide reflex if stunned (negative focus)
            double focus = EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.Focus);
            if (focus < 0)
            {
                d_defenderReflex = d_defenderReflex / (1 - focus);
            }
            d_defenderReflex = d_defenderReflex * GetStaminaFactor(c);
            //no reflex if KO
            if (!(EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.KO) < 1))
                d_defenderReflex = 0.0;
            return d_defenderReflex;
        }

        public static double GetBaseReflex(Character c)// + 0.2 * defensiveCalculator for actual Reflex
        {
            double dxMod2 = (Convert.ToDouble(c.Statistics.Dexterity + EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.Dexterity)) - 10) / 2;
            //BASE REFLEX
            //reflex = (dex/2)-3 + reflexskill OR dexmod + 2 (they're the same. the algebra here is correct I promise) plus a little extra based on your general fighting skill
            double d_defenderReflex = dxMod2 + 2 + c.Skills.ReflexSkill + EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.Reflex);
            //reduce reflex if overburdened
            if (GetWeightFactor(c) < 0)
            {
                //+ because weight factor is a negative number
                d_defenderReflex += GetWeightFactor(c);
            }
            return d_defenderReflex;
        }

        public static double GetBaseHealth(Character c) {
            return Convert.ToDouble(Convert.ToDouble((c.Statistics.Constitution) + EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.Constitution)) * (2 + c.Skills.HPSkill * 0.25));
        }

        public static double GetBaseStamina(Character c)
        {
            return Convert.ToDouble((c.Statistics.Constitution + EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.Constitution) + c.Skills.EnduranceSkill - 10) * 25 + 300);

        }


        public static void applyAttackOutcome(AttackOutcome Whack)
        {
            Whack.Attacker.CombatStuff.attackResultsForDisplay.Insert(0, Utilities.translateAttackOutcomeToDisplayStrings(Whack, Whack.attackUUID));
            Whack.Defender.CombatStuff.defendResultsForDisplay.Insert(0, Utilities.translateAttackOutcomeToDisplayStrings(Whack, Whack.defenceUUID));
            Character Whackee = CombatHolder._inCombatChars.Find(Ch => Ch.CombatStuff.CombatName == Whack.Defender.CombatStuff.CombatName);
            //this can happen in some enchantment cases
            if (Whackee == null)
            {
                return;
            }          

            Whackee.HitPoints = Whackee.HitPoints - Whack.harm;
            Effect bleed = new Effect(EffectHolder.EffectType.Regeneration, Whack.bleed * -1, Whack.bleed, -1);
            bleed.effectTag = EffectHolder.EffectTag.Bleed;
            Effect trauma = new Effect(EffectHolder.EffectType.Focus, Whack.trauma * -1, Whack.trauma, -1);
            trauma.effectTag = EffectHolder.EffectTag.Trauma;
            bool doPermanantImpairment = Whackee.CharTypeTag != "" && Whackee.CharTypeTag != null;
            Effect impairment = new Effect(EffectHolder.EffectType.OB, Whack.impairment * -1, -1, 0);
            impairment.effectTypes.Add(EffectHolder.EffectType.DB);
            impairment.effectTag = EffectHolder.EffectTag.NerveImpairment;
            Effect disorientation = new Effect(EffectHolder.EffectType.OB, Whack.disorientation * -1, Whack.disorientation, 1);
            disorientation.effectTypes.Add(EffectHolder.EffectType.DB);
            disorientation.effectTag = EffectHolder.EffectTag.Disorientation;
            Effect KO = new Effect(EffectHolder.EffectType.KO, Whack.ko, Whack.ko, 0.02);
            EffectHolder.CreateEffect(disorientation, Whackee, false);
            EffectHolder.CreateEffect(bleed, Whackee, false);
            EffectHolder.CreateEffect(trauma, Whackee, false);
            EffectHolder.CreateEffect(impairment, Whackee, false);
            EffectHolder.CreateEffect(KO, Whackee, false);
        }
        public static void fatigueCharacters(List<Character> chars)
        {
            foreach(Character c in chars)
            {
                c.Stamina = c.Stamina - c.CombatStuff.CombatWeapon.StaminaRequirement;
                foreach (Armor arm in c.Armor)
                {
                    c.Stamina -= arm.StaminaRequirement;
                }
                c.CombatStuff.targets.Clear();
                c.CombatStuff.rollSet = false;
                c.CombatStuff.CombatRoll = 0;
            }
        }
        public static void fatigueCharactersAndRecordCombat (List<AttackOutcome> outcomes)
        {
            foreach(AttackOutcome ao in outcomes)
            {
                while (ao.Attacker.CombatStuff.defendResultsForDisplay.Count() > 5)
                {
                    ao.Attacker.CombatStuff.defendResultsForDisplay.RemoveAt(ao.Attacker.CombatStuff.defendResultsForDisplay.Count() - 1);
                }
                while (ao.Attacker.CombatStuff.attackResultsForDisplay.Count() > 5)
                {
                    ao.Attacker.CombatStuff.attackResultsForDisplay.RemoveAt(ao.Attacker.CombatStuff.attackResultsForDisplay.Count() - 1);
                }
            }
            AfterCrits.MostRecentAttacks = outcomes;
            AfterCrits.IndexAttacks();
            fatigueCharacters(CombatHolder._makingAttackChars);
        }

        public static void removeOverhealFromCharacters()
        {
            foreach (Character c in CombatHolder._inCombatChars) {
                c.HitPoints = System.Math.Min(c.HitPoints, GetBaseHealth(c) + (int)EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.Health));
                c.Stamina = System.Math.Min(c.Stamina, GetBaseStamina(c));
            }
        }
        //regenerates character health and stamina as though resting
        public static void slowlyRegenerateCharacters()
        {
            foreach (Character c in CombatHolder._inCombatChars)
            {
                c.HitPoints = System.Math.Round(c.HitPoints + GetBaseHealth(c) / 4800, 5);
                c.Stamina = System.Math.Round(c.Stamina + GetBaseStamina(c) / 4800, 5);
            }
        }
    }
}
