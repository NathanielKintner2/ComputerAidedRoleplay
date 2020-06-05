using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Text;

namespace Second_Attempt
{
    public static class CombatHolder
    {
        public static MasterDeclarations _masterOfDeclarations;
        public static List<Character> _inCombatChars = new List<Character>();
        public static List<Character> _makingAttackChars = new List<Character>();
        public static List<Character> _alreadyAttackedThisRound = new List<Character>();
        public static List<CombatDeclarations> _currentDeclarationsToUpdate = new List<CombatDeclarations>();
        public static List<Item> _theGround = new List<Item>();

        public static Boolean toggleCharAttack(Character c)
        {
            if (_makingAttackChars.Contains(c))
            {
                _makingAttackChars.Remove(c);
                return false;
            }
            else
            {
                _makingAttackChars.Add(c);
                return true;
            }

        }

        public static void UpdateCharInventorySpellsSkillsEffectsAndStats(Character c) {
            if (_inCombatChars.Any(TChar => TChar.Name.Equals(c.Name))) {
                List<Character> toUpdate = _inCombatChars.FindAll(TChar => TChar.Name.Equals(c.Name));
                foreach (Character updateNow in toUpdate) {
                    updateNow.Inventory = c.Inventory;
                    Utilities.FillEquipListsFromInventory(updateNow);
                    updateNow.Statistics = c.Statistics;
                    updateNow.Skills = c.Skills;
                    updateNow.Spells = c.Spells;
                    updateNow.Effects = c.Effects;
                }                
            }
        }
        public static void MoveAttackingCharsToHasAttackedChars()
        {
            foreach(Character attackingChar in _makingAttackChars) {
                if (!_alreadyAttackedThisRound.Contains(attackingChar)) {
                    _alreadyAttackedThisRound.Add(attackingChar);
                }
                
            }
            _makingAttackChars.Clear();
        }

        public static void updateCombatDeclarations() {
            foreach (CombatDeclarations cd in CombatHolder._currentDeclarationsToUpdate)
            {
                if (cd != null)
                {
                    cd.RefreshThisCharacter();
                }
            }
        }

        public static void attemptToBeginCombat()
        {
            if (!_inCombatChars.Any(c => !c.CombatStuff.readyForCombat && c.CharTypeTag != ""))
            {
                Master_Attacker frmCreator = new Master_Attacker();
                frmCreator.Show();
            }
        }

        public static List<string> getInCombatCharNames() {
            List<string> ret = new List<string>();
            foreach (Character c in _inCombatChars) {
                ret.Add(c.CombatStuff.CombatName);
            }
            return ret;
        }        
    }
}
