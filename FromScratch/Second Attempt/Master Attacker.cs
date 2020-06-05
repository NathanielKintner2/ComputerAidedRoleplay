using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_Attempt
{
    public partial class Master_Attacker : Form
    {
        List<AttackOutcome> allAttacks = new List<AttackOutcome>();
        public Master_Attacker()
        {
            InitializeComponent();
            foreach (Character attacker in CombatHolder._makingAttackChars)
            {
                cboBoxAttackers.Items.Add(attacker.CombatStuff.CombatName);
                if (attacker.CombatStuff.targets == null || attacker.CombatStuff.targets.Count == 0) {
                    attacker.CombatStuff.targets.Add(CombatHolder._inCombatChars.First());
                }
                foreach (Character target in attacker.CombatStuff.targets) {
                    SingleAttack frmCreator = new SingleAttack(attacker, CombatHolder._inCombatChars, this, target);
                    frmCreator.Show();
                }
                

                /*if (TacoFollower.CombatStuff.CurrentlyInCombat == true)
                {//currently depreciated
                    
                }*/
                    
                
            }
            
        }
        public void AddToAttacks(AttackOutcome toAdd)
        {
            allAttacks.Add(toAdd);
        }

        private void FOLLOWTHETACO_Click(object sender, EventArgs e)
        {
            List<AttackOutcome> followedTacos = new List<AttackOutcome>();
            foreach(AttackOutcome tacoToFollow in allAttacks)
            {
                AttackOutcome followedTaco  = CombatScripts.RunCombat(tacoToFollow.Attacker, tacoToFollow.Defender, tacoToFollow.attackRoll, tacoToFollow.defendRoll, null);


                followedTaco.Attacker.CombatStuff.AttackNotes = followedTaco.Notes;
                followedTaco.Defender.CombatStuff.DefendNotes = followedTaco.Notes;

                followedTacos.Add(followedTaco);
            }

            CombatScripts.fatigueCharactersAndRecordCombat(followedTacos);

            foreach (AttackOutcome Whack in followedTacos)
            {
                CombatScripts.applyAttackOutcome(Whack);
            }

            EffectHolder.ClearUselessEffects();
            CombatHolder.MoveAttackingCharsToHasAttackedChars();
            if (CombatHolder._masterOfDeclarations != null)
            {
                CombatHolder._masterOfDeclarations.UpdateRTB();
            }
            CombatHolder.updateCombatDeclarations();
            AfterCrits frmCreator = new AfterCrits();
            frmCreator.Show();

            Master_Attacker frmCloser = this;
            frmCloser.Hide();
        }

        private void btnAddTarget_Click(object sender, EventArgs e)
        {
            if (CombatHolder._makingAttackChars.Any(A => A.CombatStuff.CombatName == cboBoxAttackers.SelectedItem.ToString())) {
                SingleAttack frmCreator = new SingleAttack(CombatHolder._makingAttackChars.Find(TChar => TChar.CombatStuff.CombatName == cboBoxAttackers.SelectedItem.ToString()), CombatHolder._inCombatChars, this, CombatHolder._inCombatChars.First());
                frmCreator.Show();
            }
        }
    }
}
