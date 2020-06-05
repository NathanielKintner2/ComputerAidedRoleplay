using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Second_Attempt
{
    public class SpellToCast
    {
        public Character caster;
        public List<Character> targets;
        public Spell spell;
        public double spellPower;
        public bool castAtBeginningOfNextRound;
        public bool hasBeenCast;

        //These lists contain the results of casting the spell. Usually empty.
        public List<AttackOutcome> weaponResult = new List<AttackOutcome>();
        public Dictionary<Effect, Character> effectResult = new Dictionary<Effect, Character>();

        public bool IsCorrectlyFormattedAndReadyToCast() {
            if (caster != null && CombatHolder._inCombatChars.Contains(caster)
                && targets != null && targets.Find(A => !CombatHolder._inCombatChars.Contains(A)) == null
                && targets.Find(A => CombatHolder._inCombatChars.Contains(A)) != null
                && spell != null && !hasBeenCast)
            {
                return true;
            }
            return false;
        }

    }
}
