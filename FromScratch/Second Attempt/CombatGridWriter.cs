using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Attempt
{
    class CombatGridWriter
    {
        public static List<List<Double>> CreateDataPoints(AttackOutcome ao, 
            bool doTotalDamage, 
            bool doHarm, 
            bool doBleed,
            bool doDisorientation,
            bool doImpairment,
            bool doTrauma,
            bool doKO,
            Utilities.BodyParts? location,
            int perception)
        {
            List<List<Double>> gridOfPoints= new List<List<double>>();
            for (double j = ao.defendRoll - perception; j <= ao.defendRoll + perception; j++)
            {
                List<double> rowOfPoints = new List<double>();
                for (double i = ao.attackRoll - perception; i <= ao.attackRoll + perception; i++)
                {
                    AttackOutcome oneOutcome = CombatScripts.RunCombat(Utilities.GetSameCharWithCurrentState(ao.Attacker), Utilities.GetSameCharWithCurrentState(ao.Defender), i, j, location);                    
                    double Damage = 0.0;                    
                    switch (oneOutcome.Othertext.ToString())
                    {
                        case "Miss":
                            Damage = -1;
                            break;
                        case "Block":
                            Damage = -2;
                            break;
                        case "Parry":
                            Damage = -3;
                            break;
                        case "Hit":
                            if (doTotalDamage)
                            {
                                Damage += oneOutcome.TotalStrikeAmountFromAllTypes();
                            }
                            if (doHarm)
                            {
                                Damage += oneOutcome.harm;
                            }
                            if (doBleed)
                            {
                                Damage += oneOutcome.bleed;
                            }
                            if (doDisorientation)
                            {
                                Damage += oneOutcome.disorientation;
                            }
                            if (doImpairment)
                            {
                                Damage += oneOutcome.impairment;
                            }
                            if (doTrauma)
                            {
                                Damage += oneOutcome.trauma;
                            }
                            if (doTrauma)
                            {
                                Damage += oneOutcome.ko;
                            }
                            if (ao.Othertext != Utilities.AttackResultType.Hit)
                            {
                                Damage = 99;
                            }
                            break;
                        default:
                            throw new Exception("WTF did you give me?");
                    }
                    rowOfPoints.Add(Damage);
                }
                gridOfPoints.Add(rowOfPoints);
            }
            return gridOfPoints;
        }
    }
}
