using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Second_Attempt
{
    public partial class BattleTesting : Form
    {
        Random r = new Random();

        Dictionary<Character, bool> leftSide = new Dictionary<Character, bool>();
        Dictionary<Character, bool> rightSide = new Dictionary<Character, bool>();     
        Boolean ifThisThenLeftAttacksNext = true;
        bool doPrinting = false;

        public BattleTesting()
        {
            InitializeComponent();
            foreach(Character c in CombatHolder._inCombatChars)
            {
                comboBoxNames.Items.Add(c.CombatStuff.CombatName);
            }
        }

        private void buttonAddLeftChar_Click(object sender, EventArgs e)
        {
            if (CombatHolder._inCombatChars.Any(A => A.CombatStuff.CombatName.Equals(comboBoxNames.SelectedItem))) {
                Character fromInCombatChars = CombatHolder._inCombatChars.Find(A => A.CombatStuff.CombatName.Equals(comboBoxNames.SelectedItem));
                leftSide.Add(fromInCombatChars.MakeDeepCopy(), false);
            }
            UpdateRTBs();
        }

        private void buttonAddRightChar_Click(object sender, EventArgs e)
        {
            if (CombatHolder._inCombatChars.Any(A => A.CombatStuff.CombatName.Equals(comboBoxNames.SelectedItem)))
            {
                Character fromInCombatChars = CombatHolder._inCombatChars.Find(A => A.CombatStuff.CombatName.Equals(comboBoxNames.SelectedItem));
                rightSide.Add(fromInCombatChars.MakeDeepCopy(), false);
            }
            UpdateRTBs();
        }

        private void UpdateRTBs() {
            richTextBoxLeft.Text = "";
            richTextBoxRight.Text = "";
            foreach (Character c in leftSide.Keys)
            {
                richTextBoxLeft.Text += c.CombatStuff.CombatName + " " + (c.HitPoints + EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.Health)) + "\n";
            }
            foreach (Character c in rightSide.Keys)
            {
                richTextBoxRight.Text += c.CombatStuff.CombatName + " " + (c.HitPoints + EffectHolder.GetValidEffectsByEffect(c, EffectHolder.EffectType.Health)) + "\n";
            }
        }

        private void buttonDoOneAttack_Click(object sender, EventArgs e)
        {
            doPrinting = true;
            runSingleAttack();
            doPrinting = false;
            UpdateRTBs();
        }

        private void runSingleAttack() {

            clearDedPeople();
            if (leftSide.Count == 0 || rightSide.Count == 0)
            {
                return;
            }
            Character attackingChar = new Character();
            Character toAttackChar = new Character();
            bool thereIsACharThatHasNotAttacked = false;
            bool thereIsAnAttackingChar = false;
            ifThisThenLeftAttacksNext = !ifThisThenLeftAttacksNext;
            foreach (Character c in leftSide.Keys) {
                if (!leftSide[c]) {
                    thereIsACharThatHasNotAttacked = true;
                    break;
                }
            }
            foreach (Character c in rightSide.Keys)
            {
                if (!rightSide[c])
                {
                    thereIsACharThatHasNotAttacked = true;
                    break;
                }
            }
            if (!thereIsACharThatHasNotAttacked) {
                EffectHolder.ProcAndDecayEffectsForSingleChar(rightSide.Keys.Last());
                EffectHolder.ProcAndDecayEffectsForSingleChar(leftSide.Keys.Last());
                clearDedPeople();
                //c# really does make you do it this way. Iteration through a dictionary is hard for some reason
                List<Character> temp = new List<Character>();
                foreach (Character c in leftSide.Keys)
                {
                    temp.Add(c);
                }
                foreach (Character c in temp)
                {
                    leftSide[c] = false;
                }
                temp.Clear();
                foreach (Character c in rightSide.Keys)
                {
                    temp.Add(c);
                }
                foreach (Character c in temp)
                {
                    rightSide[c] = false;
                }
                if (leftSide.Count == 0 || rightSide.Count == 0)
                {
                    return;
                }
            }
            if (ifThisThenLeftAttacksNext)
            {
                foreach (Character c in leftSide.Keys)
                {
                    if (!leftSide[c])
                    {
                        attackingChar = c;
                        thereIsAnAttackingChar = true;
                        leftSide[c] = true;
                        break;
                    }
                }
                toAttackChar = rightSide.Keys.Last();
            }
            else
            {
                foreach (Character c in rightSide.Keys)
                {
                    if (!rightSide[c])
                    {
                        attackingChar = c;
                        thereIsAnAttackingChar = true;
                        rightSide[c] = true;
                        break;
                    }
                }
                toAttackChar = leftSide.Keys.Last();
            }
            if (!thereIsAnAttackingChar) {
                return;
            }
            AttackOutcome ao = CombatScripts.RunCombat(attackingChar, toAttackChar, Math.Round(r.NextDouble() * 20), Math.Round(r.NextDouble() * 20), null);
            

            if (ao.Othertext.ToString() == "Hit") {
                toAttackChar.HitPoints = toAttackChar.HitPoints - ao.harm;
                Effect bleed = new Effect(EffectHolder.EffectType.Regeneration, ao.bleed * -1, -1, 0);
                Effect focus = new Effect(EffectHolder.EffectType.Focus, ao.trauma * -1, -1, 0);
                Effect impairmentOB = new Effect(EffectHolder.EffectType.OB, ao.impairment * -1, -1, 0);
                Effect impairmentDB = new Effect(EffectHolder.EffectType.DB, ao.impairment * -1, -1, 0);
                Effect OB = new Effect(EffectHolder.EffectType.OB, ao.disorientation * -1, ao.disorientation, 1);
                Effect DB = new Effect(EffectHolder.EffectType.DB, ao.disorientation * -1, ao.disorientation, 1);
                EffectHolder.CreateEffect(OB, toAttackChar, false);
                EffectHolder.CreateEffect(DB, toAttackChar, false);
                EffectHolder.CreateEffect(bleed, toAttackChar, false);
                EffectHolder.CreateEffect(focus, toAttackChar, false);
                EffectHolder.CreateEffect(impairmentOB, toAttackChar, false);
                EffectHolder.CreateEffect(impairmentDB, toAttackChar, false);
                EffectHolder.ClearUselessEffects();
            }

            if(doPrinting)
                richTextBoxBig.Text += attackingChar.CombatStuff.CombatName + " -> " + toAttackChar.CombatStuff.CombatName + " " + " " + ao.Othertext.ToString() + "\n";

            clearDedPeople();

        }


        public void clearDedPeople() {
            
            if (leftSide.Count == 0 || rightSide.Count == 0) {
                return;
            }
            if (leftSide.Keys.Last().HitPoints + EffectHolder.GetValidEffectsByEffect(leftSide.Keys.Last(), EffectHolder.EffectType.Health) <= 0) {
                
                leftSide.Remove(leftSide.Keys.Last());
            }

            if (rightSide.Keys.Last().HitPoints + EffectHolder.GetValidEffectsByEffect(rightSide.Keys.Last(), EffectHolder.EffectType.Health) <= 0) {
                
                rightSide.Remove(rightSide.Keys.Last());
            }
            
        }

        private void buttonFinishCombat_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 500; i++)
            {
                runSingleAttack();
            }

            UpdateRTBs();
        }

        private void buttonFindAverageWinRate_Click(object sender, EventArgs e)
        {
            double left = 1.0;
            double right = 1.0;
            for (int i = 0; i < 2000; i++) {
                Dictionary<Character, bool> leftCopy = new Dictionary<Character, bool>();
                foreach (Character c in leftSide.Keys)
                {
                    leftCopy.Add(c.MakeDeepCopy(), leftSide[c]);
                }
                Dictionary<Character, bool> rightCopy = new Dictionary<Character, bool>();
                foreach (Character c in rightSide.Keys)
                {
                    rightCopy.Add(c.MakeDeepCopy(), rightSide[c]);
                }
                while (leftSide.Any() && rightSide.Any()) {
                    runSingleAttack();
                }
                if (leftSide.Any()) {
                    left++;
                }
                if (rightSide.Any()) {
                    right++;
                }
                leftSide = leftCopy;
                rightSide = rightCopy;
            }
            lblAverage.Text = "Average: " + (Math.Round((left / (left + right)) * 1000)/1000).ToString();

            UpdateRTBs();
        }
    }
}
