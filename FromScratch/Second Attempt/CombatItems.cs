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
    public class CombatItems
    {
        public CombatItems(Character c)
        {
            parent = c;
            AttackNotes = new CombatNotes();
            DefendNotes = new CombatNotes();
        }
        public Character parent { get; set; }
        
        public string CombatName { get; set; }
        
        public Weapon CombatWeapon { get; set; }
        
        public Shield CombatShield { get; set; }
        [DataMember]
        public double CombatOB { get; set; }
        [DataMember]
        public double CombatDB { get; set; }

        public bool readyForCombat = false;

        public bool rollSet = false;

        public double CombatRoll;

        public List<Character> targets = new List<Character>();

        public SpellToCast[] SpellsToCast = new SpellToCast[3];

        public List<List<String>> attackResultsForDisplay = new List<List<string>>();
        public List<List<String>> defendResultsForDisplay = new List<List<string>>();

        public List<SpellToCast> spellResultsForDisplay = new List<SpellToCast>();

        public AttackOutcome aoForEnchantments;
        public SpellToCast stcForEnchantments;



        public CombatNotes AttackNotes { get; set; }
        public CombatNotes DefendNotes { get; set; }
    }
}
