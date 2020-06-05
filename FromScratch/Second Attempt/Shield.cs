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
    public class Shield : Item
    {
        public Shield()
        {

        }
        


        [DataMember]
        public double OffensiveBonus { get; set; }


        [DataMember]
        public double DefensiveBonus { get; set; }
        
        [DataMember]
        public double Coverage { get; set; }
        
    }
}
