using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Second_Attempt
{
    public static class SpellScripts
    {
        public static Tuple<List<AttackOutcome>, List<Effect>> castSpell(Character caster, Character target, Spell s, double spellPower, double defensePower) {
            
            Tuple < List<AttackOutcome>, List < Effect >> ret = new Tuple<List<AttackOutcome>, List<Effect>>(new List<AttackOutcome>(), new List<Effect>());

            spellPower += EffectHolder.GetValidEffectsByEffect(caster, EffectHolder.EffectType.SpellBonus);
            foreach (Effect eff in s.SpellEffects.Keys)
            {
                Effect effMultiplied = new Effect(eff.effectTypes,
                    eff.effectStrength + s.SpellEffects[eff].Item1 * spellPower,
                    eff.effectLength + (int)Math.Round(s.SpellEffects[eff].Item2 * spellPower),
                    eff.deterioration + s.SpellEffects[eff].Item3 * spellPower);
                effMultiplied.effectTag = eff.effectTag;
                ret.Item2.Add(effMultiplied);
            }

            foreach (Weapon weap in s.SpellWeapons.Keys)
            {
                Weapon save = caster.CombatStuff.CombatWeapon;
                caster.CombatStuff.CombatWeapon = Utilities.GetWeaponByName(weap.ItemName);

                AttackOutcome outcome = CombatScripts.RunCombat(caster.MakeDeepCopy(), target, s.SpellWeapons[weap] + spellPower, defensePower, null);
                outcome.Attacker.CombatStuff.attackResultsForDisplay = new List<List<string>>();
                outcome.Defender.CombatStuff.defendResultsForDisplay = new List<List<string>>();
                ret.Item1.Add(outcome);

                caster.CombatStuff.CombatWeapon = save;
            }


            return ret;
        }
    }
}
