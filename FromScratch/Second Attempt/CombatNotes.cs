using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Second_Attempt
{
    public class CombatNotes
    {
        public string attackerWeaponName;
        public string defenderWeaponName;
        public double attackroll;
        public double attackValue;
        public double defendRoll;
        public double defendValue;
        public double blockingDifficulty;
        public double stun;
        public double reflex;
        public double defendValueAfterBlockingDifficulty;
        public double block;
        public double parryBreak;
        public double parryStrength;
        public double parry;
        public double attackAfterReflex;
        public double attackAfterBlock;
        public double attackAfterParry;
        public double damageBeforeArmor;
        public double damageAfterArmor;

        public string DisplayResults()
        {
            string ret = "";
            ret += "----INITIAL NUMBERS----\n";
            ret += "Attack Value:\t\t" + (int)attackValue + "\n";
            ret += "Defence Value:\t\t" + (int)defendValue + "\n";
            ret += "\n--FACTORS HELPING OFFENSE--\n";
            ret += "Blocking Difficulty:\t" + (int)blockingDifficulty + "\n";
            ret += "Defender Stun:\t" + (int)stun + "\n";
            ret += "\n--FACTORS HELPING DEFENCE--\n";
            int parrypercent = parryBreak != 0 ? (int)((parryStrength * 100.0) / parryBreak) : 100001;
            ret += "Parry Effectiveness:\t\t" + (Math.Abs(parrypercent) < 10000 ? parrypercent.ToString()+"%" : "undefined") + "\n";
            ret += "Total Parry:\t\t" + (int)parry + "\n";
            ret += "Reflex:\t\t" + (int)reflex + "\n";
            ret += "Shield:\t\t" + (int)block + "\n";
            ret += "Total Defence:\t" + (int)(parry + block + reflex) + "\n";
            ret += "\n-------RESULTS-------\n";
            ret += "Attack after Defence:\t" + attackAfterParry + "\n";
            ret += "Strike Power before Armor:\t" + damageBeforeArmor + "\n";
            ret += "Strike Power after Armor:\t" + damageAfterArmor + "\n\n";
            return ret;
        }
        /* An old version of the display.
        public string DisplayResults()
        {
            string ret = "";
            ret += "Attack Roll:\t\t" + attackroll + "\n";
            ret += "Defence Roll:\t\t" + defendRoll + "\n";
            ret += "Attack Value:\t\t" + attackValue + "\n";
            ret += "Defence Value:\t\t" + defendValue + "\n";
            ret += "Blocking Difficulty:\t" + blockingDifficulty + "\n";
            ret += "Def Val minus Block Diff:\t" + defendValueAfterBlockingDifficulty + "\n";
            ret += "Reflex:\t\t" + reflex + "\n";
            ret += "Shield:\t\t" + block + "\n";
            ret += "Parry Break:\t\t" + parryBreak + "\n";
            ret += "Parry Strength:\t\t" + parryStrength + "\n";
            ret += "Total Parry:\t\t" + parry + "\n";
            ret += "Attack after Reflex:\t" + attackAfterReflex + "\n";
            ret += "Attack after Shield:\t" + attackAfterBlock + "\n";
            ret += "Attack after Parry:\t" + attackAfterParry + "\n";
            ret += "Value before Armor:\t" + damageBeforeArmor + "\n";
            ret += "Value after Armor:\t" + damageAfterArmor + "\n";
            return ret;
        }*/
    }
}
