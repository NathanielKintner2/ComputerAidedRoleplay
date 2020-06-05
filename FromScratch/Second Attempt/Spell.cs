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
    public class Spell
    {
        public Spell()
        {            
            SpellWeapons = new Dictionary<Weapon, double>();            
            SpellEffects = new Dictionary<Effect, Tuple<double, double, double>>();
        }

        [DataMember]
        public string SpellName { get; set; }


        [DataMember]
        public string GoogleSheetID { get; set; }


        [DataMember]
        public string Description { get; set; }


        [DataMember]
        public int SpellCost { get; set; }


        [DataMember]
        public Dictionary<Weapon, double> SpellWeapons { get; set; }
        
        //potency, length, deterioration
        [DataMember]
        public Dictionary<Effect, Tuple<double, double, double>> SpellEffects { get; set; }

        
        public string Serialize()
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(Spell));
            string xmlString;
            using (StringWriter sw = new StringWriter())
            {
                using (XmlTextWriter writer = new XmlTextWriter(sw))
                {
                    writer.Formatting = Formatting.Indented; // indent the Xml so it's human readable
                    serializer.WriteObject(writer, this);
                    writer.Flush();
                    xmlString = sw.ToString();
                }
            }
            return xmlString;
        }
        public static Spell Deserialize(string strSpellXml)
        {
            using (XmlReader reader = XmlReader.Create(new StringReader(strSpellXml)))
            {
                DataContractSerializer formatter0 =
                    new DataContractSerializer(typeof(Spell));
                return (Spell)formatter0.ReadObject(reader);
            }
        }
    }
}
