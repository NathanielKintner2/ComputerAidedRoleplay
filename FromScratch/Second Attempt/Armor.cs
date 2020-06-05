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
    public class Armor : Item
    {
        public Armor()
        {
            DamageReductionTypes = new Dictionary<Utilities.DamageType, double>();
            DamageResistanceTypes = new Dictionary<Utilities.DamageType, double>();
            CoveredAreas = new List<Utilities.BodyParts>();
        }
        

        

        [DataMember]
        public List<Utilities.BodyParts> CoveredAreas;

        [DataMember]
        public Dictionary<Utilities.DamageType, double> DamageReductionTypes { get; set; }


        [DataMember]
        public Dictionary<Utilities.DamageType, double> DamageResistanceTypes { get; set; }


        [DataMember]
        public double OffensiveBonus { get; set; }


        [DataMember]
        public double DefensiveBonus { get; set; }


        [DataMember]
        public double StaminaRequirement { get; set; }

    }
}
