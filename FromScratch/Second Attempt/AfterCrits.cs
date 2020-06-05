using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Second_Attempt.EnchantmentLogic;

namespace Second_Attempt
{
    public partial class AfterCrits : Form
    {
        public static List<AttackOutcome> MostRecentAttacks = new List<AttackOutcome>();
        public static Dictionary<String, Tuple<AttackOutcome, List<List<double>>>> IndexedAttacks = new Dictionary<String, Tuple<AttackOutcome, List<List<double>>>>();
        public AfterCrits()
        {
            InitializeComponent();
            richTextBox1.Text = "";
            var comparer = Comparer<AttackOutcome>.Create((k1, k2) => k1.TotalStrikeAmountFromAllTypes().CompareTo(k2.TotalStrikeAmountFromAllTypes()));
            MostRecentAttacks.Sort(comparer);
            foreach (AttackOutcome Whack in MostRecentAttacks)
            {
                richTextBox1.Text += "---------------------------------------------------\n";
                richTextBox1.Text += Whack.Attacker.CombatStuff.CombatName + " against " + Whack.Defender.CombatStuff.CombatName + " with " + Whack.Attacker.CombatStuff.CombatWeapon.ItemName + "\n";
                richTextBox1.Text += "Attackroll: " + Whack.attackRoll.ToString() + "\n";
                richTextBox1.Text += "Defendroll: " + Whack.defendRoll.ToString() + "\n";
                richTextBox1.Text += "Result: " + Whack.Othertext + "\n";
                if (Whack.Othertext == Utilities.AttackResultType.Hit) {
                    richTextBox1.Text += "Location: " + Whack.HitLocation + "\n";
                    richTextBox1.Text += "Hit Caliber: " + Convert.ToString(Whack.HitCaliber) + "\n";
                    richTextBox1.Text += "Hit Strength: " + Convert.ToString(Whack.HitStrength) + "\n";
                    richTextBox1.Text += "Strike Power: " + Convert.ToString(Whack.TotalStrikeAmountFromAllTypes()) + "\n\n";
                    richTextBox1.Text += "Harm: " + Convert.ToString(Whack.harm) + "\n" + "Bleed: " + Convert.ToString(Whack.bleed) + "\n" + "Disorientation: " + Convert.ToString(Whack.disorientation) + "\n" + "Impairment: " + Convert.ToString(Whack.impairment) + "\n" + "Trauma: " + Convert.ToString(Whack.trauma) + "\n" + "KO: " + Convert.ToString(Whack.ko) + "\n";                
                }
                richTextBox1.Text += Whack.HitLocation.ToString() + "\n\n";
            }
        }
        
        public static void IndexAttacks()
        {
            lock (IndexedAttacks)
            {                
                foreach(AttackOutcome ao in MostRecentAttacks)
                {
                    while (ao.attackUUID == "" || IndexedAttacks.ContainsKey(ao.attackUUID))
                    {
                        ao.attackUUID = Utilities.RandomString(8);
                    }
                    AttackOutcome attackcopy = new AttackOutcome();
                    attackcopy.Attacker = Utilities.GetSameCharWithCurrentState(ao.Attacker);
                    attackcopy.Defender = Utilities.GetSameCharWithCurrentState(ao.Defender);
                    attackcopy.attackRoll = ao.attackRoll;
                    attackcopy.defendRoll = ao.defendRoll;
                    attackcopy.HitLocation = ao.HitLocation;
                    attackcopy.Othertext = ao.Othertext;
                    attackcopy.perception = attackcopy.Attacker.Skills.PerceptionSkill + (int)(attackcopy.Attacker.Statistics.Intelligence / 3.0);
                    IndexedAttacks.Add(ao.attackUUID, new Tuple<AttackOutcome, List<List<double>>>(attackcopy, null));
                    while (ao.defenceUUID == "" || IndexedAttacks.ContainsKey(ao.defenceUUID))
                    {
                        ao.defenceUUID = Utilities.RandomString(8);
                    }
                    AttackOutcome defendcopy = new AttackOutcome();
                    defendcopy.Attacker = Utilities.GetSameCharWithCurrentState(ao.Attacker);
                    defendcopy.Defender = Utilities.GetSameCharWithCurrentState(ao.Defender);
                    defendcopy.attackRoll = ao.attackRoll;
                    defendcopy.defendRoll = ao.defendRoll;
                    defendcopy.HitLocation = ao.HitLocation;
                    defendcopy.Othertext = ao.Othertext;
                    defendcopy.perception = defendcopy.Defender.Skills.PerceptionSkill + (int)(defendcopy.Defender.Statistics.Intelligence / 3.0);
                    IndexedAttacks.Add(ao.defenceUUID, new Tuple<AttackOutcome, List<List<double>>>(defendcopy, null));
                }
            }
        }

        public static void AddGridToIndexedAttacksForever()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(10);
                lock (IndexedAttacks)
                {
                    var addition = new Tuple<AttackOutcome, List<List<double>>>(null, null);
                    String uuidscoped = "";
                    foreach (String uuid in IndexedAttacks.Keys)
                    {
                        if(IndexedAttacks[uuid].Item2 == null)
                        {
                            var grid = CombatGridWriter.CreateDataPoints(IndexedAttacks[uuid].Item1,
                                true,
                                false,
                                false,
                                false,
                                false,
                                false,
                                false,
                                IndexedAttacks[uuid].Item1.HitLocation,
                                IndexedAttacks[uuid].Item1.perception);
                            addition = new Tuple<AttackOutcome, List<List<double>>>(IndexedAttacks[uuid].Item1, grid);
                            uuidscoped = uuid;
                            break;
                        }
                    }
                    if(uuidscoped == "")
                    {
                        continue;
                    }
                    IndexedAttacks[uuidscoped] = addition;
                }
            }
        }
    }
}
