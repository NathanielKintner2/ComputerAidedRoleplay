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
    [KnownType(typeof(Weapon))]
    [KnownType(typeof(Armor))]
    [KnownType(typeof(Shield))]
    public class Item
    {
        public Item()
        {
            ItemName = "";
            Enchantments = new Dictionary<EnchantmentLogic.IfElseLogic, Dictionary<string, object>>();
            ItemEffects = new List<Effect>();
        }
        
        public enum ItemUse
        {
            Equipable,
            Consumable,
            Inert
        }

        [DataMember]
        public bool IsEquipped;

        [DataMember]
        public bool IsIdentified;

        [DataMember]
        public int Count;

        [DataMember]
        public ItemUse Use;

        [DataMember]
        public string ItemName { get; set; }


        [DataMember]
        public double Weight { get; set; }


        [DataMember]
        public string Description { get; set; }


        [DataMember]
        public string UnidentifiedDescription { get; set; }


        [DataMember]
        public Utilities.ItemType Type { get; set; }


        [DataMember]
        public List<Effect> ItemEffects { get; set; }


        [DataMember]
        public Dictionary<EnchantmentLogic.IfElseLogic, Dictionary<String, Object>> Enchantments { get; set; }


        public override string ToString()
        {
            if (ItemName == null)
                return "";
            if (Count != 1)
            {
                return ItemName + " (" + Count + ")";
            }
            return ItemName;
        }

        public string TechnicalDescription()
        {
            string ret = "";
            ret += "Enchantments:\n";
            ret += Utilities.translateEnchantmentsToDisplayString(Enchantments);
            ret += "\nEffects:\n";
            foreach (Effect eff in ItemEffects)
            {
                ret += eff.getDisplayString() + "\n";
            }
            return ret;
        }

        public string Serialize()
        {
            DataContractSerializer serializer = new DataContractSerializer(GetType());
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
        public static Item Deserialize(string strCharacterXml, Type typeOfItem)
        {
            using (XmlReader reader = XmlReader.Create(new StringReader(strCharacterXml)))
            {
                DataContractSerializer formatter0 =
                    new DataContractSerializer(typeOfItem);
                return (Item)formatter0.ReadObject(reader);
            }
        }
    }
}

