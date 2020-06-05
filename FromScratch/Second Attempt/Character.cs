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
    public class Character
    {
        public Character()
        {
            CombatStuff = new CombatItems(this);
            Statistics = new CharacterStatistics();
            Skills = new CharacterSkills();
            Armor = new List<Armor>();
            Weapons = new List<Weapon>();
            Shields = new List<Shield>();
            Effects = new List<Effect>();
            TemporaryEffects = new List<Effect>();
            Items = new List<Item>();
            Inventory = new List<Item>();
            Spells = new List<Spell>();
            Enchantments = new Dictionary<EnchantmentLogic.IfElseLogic, Dictionary<string, object>>();
            CreatureTypes = new List<Utilities.CreatureType>();
            CharTypeTag = "";
            Name = "";
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string CharTypeTag { get; set; }

        [DataMember]
        public string GoogleNinjaNotesOutbound { get; set; }

        [DataMember]
        public string GoogleNinjaNotesInbound { get; set; }


        [DataMember]
        public string GoogleNinjaNotesRebound { get; set; }

        public Dictionary<double, String> EnchantmentMessagesForGoogle { get; set; }

        [DataMember]
        public double Stamina { get; set; }


        [DataMember]
        public double HitPoints { get; set; }


        [DataMember]
        public CombatItems CombatStuff { get; set; }

        public string LastAttackTargetSelected = "";
        public string LastSpellTargetSelected = "";


        [DataMember]
        public CharacterStatistics Statistics { get; set; }


        
        public List<Weapon> Weapons { get; set; }

        
        public List<Shield> Shields { get; set; }

        [DataMember]
        public List<Spell> Spells { get; set; }


        [DataMember]
        public List<Effect> Effects { get; set; }

        public List<Effect> TemporaryEffects { get; set; }

        [DataMember]
        public Dictionary<EnchantmentLogic.IfElseLogic, Dictionary<String, Object>> Enchantments { get; set; }
        
        public List<Item> Items { get; set; }


        [DataMember]
        public CharacterSkills Skills { get; set; }
        
        public List<Armor> Armor { get; set; }

        [DataMember]
        public List<Item> Inventory { get; set; }


        [DataMember]
        public List<Utilities.CreatureType> CreatureTypes { get; set; }

        // int used by enchantment logic to determine whether to fire
        // certain enchantments or not, in order to avoid infinite loops
        public int enchantmentLayersDeep = 0;
        /*
        //VERY weak equals and get hash code methods. Only used for dictionary cooperation
        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            Character p = (Character)obj;
            return (Name == p.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        */
        public string Serialize()
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(Character));
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
        public static Character Deserialize(string strCharacterXml)
        {
            using (XmlReader reader = XmlReader.Create(new StringReader(strCharacterXml)))
            {
                DataContractSerializer formatter0 =
                    new DataContractSerializer(typeof(Character));
                return (Character)formatter0.ReadObject(reader);
            }
        }

        public Character MakeDeepCopy()
        {
            String copyString = this.Serialize();
            Character ret = Deserialize(copyString);
            return ret;
        }
    }
}
