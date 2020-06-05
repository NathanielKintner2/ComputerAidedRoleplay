using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Attempt
{
    public class AttackOutcome
    {
        public AttackOutcome() {
            DamageTypes = new Dictionary<Utilities.DamageType, double>();
            Notes = new CombatNotes();
        }

        public string attackUUID = "";
        public string defenceUUID = "";
        public int perception = 0;

        public double attackRoll { get; set; }
        public double defendRoll { get; set; }

        //HitCaliber is the strength and accuracy of the strike before armor or damage types are considered
        public double HitCaliber { get; set; }

        //HitStrength is the amount of strike that would go through if the target were not wearing armor
        public double HitStrength { get; set; }
        public Dictionary<Utilities.DamageType, double> DamageTypes { get; set; }
        public Utilities.AttackResultType Othertext { get; set; }
        public Character Attacker { get; set; }
        public Character Defender { get; set; }
        public Utilities.BodyParts HitLocation { get; set; }

        public CombatNotes Notes { get; set; }


        public int harm { get; set; }
        public int bleed { get; set; }
        public int disorientation { get; set; }
        public int trauma { get; set; }
        public int impairment { get; set; }
        public int ko { get; set; }

        public double TotalStrikeAmountFromAllTypes() {
            double ret = 0.0;
            foreach (Utilities.DamageType dt in DamageTypes.Keys) {
                ret += DamageTypes[dt];
            }
            return ret;
        }
    }
}
