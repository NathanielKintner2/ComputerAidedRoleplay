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
    public static class CritCalculator
    {
        public static Random _generator = new Random();

        public static void CalculateCrit(AttackOutcome CritSource)
        {
            double harm;
            double bleed;
            double heavybleed;
            double disorientation;
            double impairment;
            double trauma;
            double ko;

            double harmCumulative = CritSource.TotalStrikeAmountFromAllTypes() * EffectHolder.GetValidEffectsByEffect(CritSource.Attacker, EffectHolder.EffectType.InflictHarm);
            double bleedCumulative = CritSource.TotalStrikeAmountFromAllTypes() * EffectHolder.GetValidEffectsByEffect(CritSource.Attacker, EffectHolder.EffectType.InflictBleed);
            double heavybleedCumulative = CritSource.TotalStrikeAmountFromAllTypes() * EffectHolder.GetValidEffectsByEffect(CritSource.Attacker, EffectHolder.EffectType.InflictBleed);
            double disorientationCumulative = CritSource.TotalStrikeAmountFromAllTypes() * EffectHolder.GetValidEffectsByEffect(CritSource.Attacker, EffectHolder.EffectType.InflictDisorientation);
            double impairmentCumulative = CritSource.TotalStrikeAmountFromAllTypes() * EffectHolder.GetValidEffectsByEffect(CritSource.Attacker, EffectHolder.EffectType.InflictImpairment);
            double traumaCumulative = CritSource.TotalStrikeAmountFromAllTypes() * EffectHolder.GetValidEffectsByEffect(CritSource.Attacker, EffectHolder.EffectType.InflictTrauma);
            double koCumulative = CritSource.TotalStrikeAmountFromAllTypes() * EffectHolder.GetValidEffectsByEffect(CritSource.Attacker, EffectHolder.EffectType.InflictKO);
            bool locationMatters;
            foreach (Utilities.DamageType critType in CritSource.DamageTypes.Keys)
            {
                switch (critType)
                {
                    case Utilities.DamageType.Slash:
                        harm = 0.3;
                        bleed = 0.6;
                        heavybleed = 0.3;
                        disorientation = 0.3;
                        impairment = 0.3;
                        trauma = 0.2;
                        ko = 0.2;
                        locationMatters = true;
                        break;
                    case Utilities.DamageType.Pierce:
                        harm = 0.3;
                        bleed = 0.3;
                        heavybleed = 0.6;
                        disorientation = 0.1;
                        impairment = 0.2;
                        trauma = 0.2;
                        ko = 0.1;
                        locationMatters = true;
                        break;
                    case Utilities.DamageType.Crush:
                        harm = 0.2;
                        bleed = 0.0;
                        heavybleed = 0.1;
                        disorientation = 0.4;
                        impairment = 0.4;
                        trauma = 0.4;
                        ko = 0.4;
                        locationMatters = true;
                        break;
                    case Utilities.DamageType.Heat:
                        harm = 0.7;
                        bleed = -0.1;
                        heavybleed = 0.0;
                        disorientation = 0.5;
                        impairment = 0.3;
                        trauma = 0.3;
                        ko = 0.0;
                        locationMatters = true;
                        break;
                    case Utilities.DamageType.Cold:
                        harm = 0.2;
                        bleed = -0.3;
                        heavybleed = -0.3;
                        disorientation = 0.5;
                        impairment = 0.8;
                        trauma = 0.3;
                        ko = 0.3;
                        locationMatters = true;
                        break;
                    case Utilities.DamageType.Shock:
                        harm = 0.6;
                        bleed = 0.0;
                        heavybleed = 0.0;
                        disorientation = 0.4;
                        impairment = 0.5;
                        trauma = 0.6;
                        ko = 0.4;
                        locationMatters = false;
                        break;
                    case Utilities.DamageType.Mental:
                        harm = 0;
                        bleed = 0;
                        heavybleed = 0.1;
                        disorientation = 1.0;
                        impairment = 0.0;
                        trauma = 1.0;
                        ko = 0.3;
                        locationMatters = false;
                        break;
                    case Utilities.DamageType.Impact:
                        harm = 0.8;
                        bleed = 0;
                        heavybleed = 0.1;
                        disorientation = 0.5;
                        impairment = 0.3;
                        trauma = 0.6;
                        ko = 0.6;
                        locationMatters = false;
                        break;
                    case Utilities.DamageType.Soul:
                        harm = 1.0;
                        bleed = 0;
                        heavybleed = 0.0;
                        disorientation = 0.0;
                        impairment = 0.7;
                        trauma = 0.2;
                        ko = 0.4;
                        locationMatters = false;
                        break;
                    default:
                        throw new Exception("No valid Critical Type found.");
                }
                if (locationMatters)
                {
                    switch (CritSource.HitLocation)
                    {
                        case Utilities.BodyParts.Head:
                            harm += 0.2;
                            bleed += 0.0;
                            heavybleed += 0.0;
                            disorientation += 0.2;
                            impairment += 0.1;
                            trauma += 0.2;
                            ko += 0.2;
                            break;
                        case Utilities.BodyParts.Gut:
                            harm += 0.4;
                            bleed += 0.1;
                            heavybleed += 0.2;
                            disorientation += 0.0;
                            impairment += 0.0;
                            trauma += 0.1;
                            ko += 0.1;
                            break;
                        case Utilities.BodyParts.Groin:
                            harm += 0.0;
                            bleed += 0.0;
                            heavybleed += 0.0;
                            disorientation += 0.5;
                            impairment += 0.1;
                            trauma += 0.5;
                            ko += 0.0;
                            break;
                        case Utilities.BodyParts.Chest:
                            harm += 0.3;
                            bleed += 0.1;
                            heavybleed += 0.2;
                            disorientation += 0.0;
                            impairment += 0.0;
                            trauma += 0.0;
                            ko += 0.2;
                            break;
                        case Utilities.BodyParts.Neck:
                            harm += 0.2;
                            bleed += 0.2;
                            heavybleed += 0.4;
                            disorientation += 0.0;
                            impairment += 0.0;
                            trauma += 0.0;
                            ko += 0.3;
                            break;
                        default:
                            harm += 0.0;
                            bleed += 0.1;
                            heavybleed += 0.1;
                            disorientation += 0.0;
                            impairment += 0.2;
                            trauma += 0.0;
                            ko += 0.0;
                            break;
                    }
                }
                harmCumulative += harm * CritSource.DamageTypes[critType];
                bleedCumulative += bleed * CritSource.DamageTypes[critType];
                heavybleedCumulative += heavybleed * CritSource.DamageTypes[critType];
                disorientationCumulative += disorientation * CritSource.DamageTypes[critType];
                impairmentCumulative += impairment * CritSource.DamageTypes[critType];
                traumaCumulative += trauma * CritSource.DamageTypes[critType];
                koCumulative += ko * CritSource.DamageTypes[critType];
            }
            //ADD THIS FOR SOME  RANDOMNESS
            /*
            harmCumulative = harmCumulative * (_generator.NextDouble() + 0.5);
            bleedCumulative = bleedCumulative * (_generator.NextDouble() + 0.5);
            heavybleedCumulative = heavybleedCumulative * (_generator.NextDouble() + 0.5);
            disorientationCumulative = disorientationCumulative * (_generator.NextDouble() + 0.5);
            impairmentCumulative = impairmentCumulative * (_generator.NextDouble() + 0.5);
            traumaCumulative = traumaCumulative * (_generator.NextDouble() + 0.5);
            koCumulative = koCumulative * (_generator.NextDouble() + 0.5);*/

            //adjust the values. changing these lines vastly changes the harm dealt by all attacks, futz with caution

            //harm is easy to come by, as it has the smallest impact on its own and needs to accumulate to perform its function
            harmCumulative = harmCumulative * 2;
            //bleed is easy to get in smallish doses, and scales at a moderate rate
            bleedCumulative = bleedCumulative / 2;
            //....until a certain point, when you start hitting arteries and stuff, and it scales rapidly
            heavybleedCumulative = heavybleedCumulative - 7;
            //the plus on the right is necessary, because 1 point of disorientation matters very little, since it dissapates at the end of the round
            disorientationCumulative = (disorientationCumulative / 2) + 0.4;
            //impairment has to scale slowly and be difficult to achieve, since it will accumulate over combat and seriously hamstrings a fighter
            impairmentCumulative = (impairmentCumulative / 4) - 0.5;
            //like disorientation, 1 point of trauma matters very little, unless you held off on your attack for the round
            traumaCumulative = (traumaCumulative / 4);
            //even one point of ko is usually fatal, since you are likely to be bleeding, so this needs to be difficult to achieve
            koCumulative = (koCumulative / 2) - 7.5;

            Character Whackee = CritSource.Defender;
            double resistHarm = EffectHolder.GetValidEffectsByEffect(Whackee, EffectHolder.EffectType.ResistHarm);
            double resistBleed = EffectHolder.GetValidEffectsByEffect(Whackee, EffectHolder.EffectType.ResistBleed);
            double resistDisorientation = EffectHolder.GetValidEffectsByEffect(Whackee, EffectHolder.EffectType.ResistDisorientation);
            double resistImpairment = EffectHolder.GetValidEffectsByEffect(Whackee, EffectHolder.EffectType.ResistImpairment);
            double resistTrauma = EffectHolder.GetValidEffectsByEffect(Whackee, EffectHolder.EffectType.ResistTrauma);
            double resistKo = EffectHolder.GetValidEffectsByEffect(Whackee, EffectHolder.EffectType.ResistKO);
            harmCumulative = (harmCumulative - resistHarm) * 5 / (5 + resistHarm);
            // NOTE bleed and heavybleed both accounted for here
            bleedCumulative = (Math.Max(0, bleedCumulative) + Math.Max(0, heavybleedCumulative) - resistBleed) * 5 / (5 + resistBleed);
            disorientationCumulative = (disorientationCumulative - resistDisorientation) * 5 / (5 + resistDisorientation);
            impairmentCumulative = (impairmentCumulative - resistImpairment) * 5 / (5 + resistImpairment);
            traumaCumulative = (traumaCumulative - resistTrauma) * 5 / (5 + resistTrauma);
            koCumulative = (koCumulative - resistKo) * 5 / (5 + resistKo);

            //round the values properly and send them back, no negative values accepted
            CritSource.harm = (int)Math.Round(Math.Max(0, harmCumulative));
            CritSource.bleed = (int)Math.Round(Math.Max(0, bleedCumulative));
            CritSource.disorientation = (int)Math.Round(Math.Max(0, disorientationCumulative));
            CritSource.impairment = (int)Math.Round(Math.Max(0, impairmentCumulative));
            CritSource.trauma = (int)Math.Round(Math.Max(0, traumaCumulative));
            CritSource.ko = (int)Math.Round(Math.Max(0, koCumulative));
        }
    }
}
