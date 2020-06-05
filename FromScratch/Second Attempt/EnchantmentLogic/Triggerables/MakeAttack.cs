using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.Serialization;

namespace Second_Attempt.EnchantmentLogic
{
    [DataContract]
    public class MakeAttack : Logic, Triggerable
    {
        public Logic parent;
        [DataMember]
        public Calculable attackValue;
        [DataMember]
        public Calculable defenceValue;
        [DataMember]
        public EnchantmentUtilities.CharacterSelectionSubmenu attacker;
        [DataMember]
        public EnchantmentUtilities.CharacterSelectionSubmenu defender;
        [DataMember]
        public string selectedWeap;
        [DataMember]
        public String varName;
        [DataMember]
        public String name;
        public Form display;
        [DataMember]
        public String logicType = "MakeAttack";
        public String LogicType
        {
            get { return logicType; }
            set { logicType = value; }
        }
        public Form Display
        {
            get { return display; }
            set { display = value; }
        }
        public Logic Parent
        {
            get { return parent; }
            set { parent = value; }
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public Character GetParentChar()
        {
            return parent.GetParentChar();
        }

        public void UpdateAfterSave()
        {
            if (attackValue != null)
            {
                ((Logic)attackValue).Parent = this;
                ((Logic)attackValue).UpdateAfterSave();
            }
            if (defenceValue != null)
            {
                ((Logic)defenceValue).Parent = this;
                ((Logic)defenceValue).UpdateAfterSave();
            }
        }

        public Dictionary<String, Object[]> GetVariables()
        {
            return parent.GetVariables();
        }

        public void Delete()
        {
            if (display != null)
                this.display.Close();
            if (attackValue != null)
                ((Logic)attackValue).Delete();
            this.attackValue = null;
            if (defenceValue != null)
                ((Logic)defenceValue).Delete();
            this.defenceValue = null;
            this.parent = null;
        }
        public Character getCharByAccessString(EnchantmentParameters ep, string str)
        {
            switch (str)
            {
                case "Attacker":
                    return ep.ao.Attacker;
                case "Defender":
                    return ep.ao.Defender;
                case "Caster":
                    return ep.stc.caster;
                default:
                    return new Character();
            }
        }
        public double Trigger(EnchantmentParameters ep)
        {
            Character charAttacker = getCharByAccessString(ep, attacker.ToString());
            Character charDefender = getCharByAccessString(ep, defender.ToString());
            if (charAttacker.enchantmentLayersDeep > 0)
            {
                return 0;
            }
            charAttacker.enchantmentLayersDeep++;
            double? an = attackValue.Calculate(ep);
            double? dn = defenceValue.Calculate(ep);
            if(an != null && dn !=  null)
            {
                double a = (double)an;
                double d = (double)dn;

                Weapon save = charAttacker.CombatStuff.CombatWeapon;

                string selectedWepforcalc = EnchantmentUtilities.checkForVariable(selectedWeap, this);
                charAttacker.CombatStuff.CombatWeapon = Utilities.GetWeaponByName(selectedWepforcalc);

                AttackOutcome outcome = CombatScripts.RunCombat(charAttacker, charDefender, a, d, null);
                CombatScripts.applyAttackOutcome(outcome);

                charAttacker.CombatStuff.CombatWeapon = save;
            }
            charAttacker.enchantmentLayersDeep--;
            return 0.0;
        }
    }
}
