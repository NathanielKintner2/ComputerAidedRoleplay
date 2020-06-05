using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;

namespace Second_Attempt
{
    [DataContract]
    public class Weapon : Item
    {
        public Weapon()
        {            
            DamageTypes = new Dictionary<Utilities.DamageType, double>();
            WeaponTypes = new List<Utilities.WeaponType>();
        }      
        


        [DataMember]
        public double OffensiveBonus { get; set; }


        [DataMember]
        public double DefensiveBonus { get; set; }


        [DataMember]
        public double BlockingDifficulty { get; set; }


        [DataMember]
        public double ParryStrength { get; set; }


        [DataMember]
        public double ParryBreak { get; set; }


        [DataMember]
        public double ExcessStrengthMultiplier { get; set; }


        [DataMember]
        public int StaminaRequirement { get; set; }


        [DataMember]
        public Dictionary<Utilities.DamageType, double> DamageTypes { get; set; }

        

        [DataMember]
        public List<Utilities.WeaponType> WeaponTypes { get; set; }


        /// <summary>
        /// very lacking, but should work. Danger of making it too strict
        /// </summary>
        /// <returns></returns>
        /// 
        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            Weapon p = (Weapon)obj;
            return (ItemName== p.ItemName /*&&
                    isPermanent == p.isPermanent &&
                    effectLength == p.effectLength &&
                    effectStrength == p.effectStrength &&
                    effectTarget == p.effectTarget &&
                    effectType == p.effectType*/);
        }
        /// <summary>
        /// very lacking, but should work. Danger of making it too strict
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            int hashcode = 17;
            hashcode = hashcode * 23 + ItemName.GetHashCode();/*
            hashcode = hashcode * 23 + isPermanent.GetHashCode();
            hashcode = hashcode * 23 + effectLength.GetHashCode();
            hashcode = hashcode * 23 + effectStrength.GetHashCode();
            hashcode = hashcode * 23 + effectTarget.GetHashCode();
            hashcode = hashcode * 23 + effectType.GetHashCode();*/
            return hashcode;
        }
    }
}
