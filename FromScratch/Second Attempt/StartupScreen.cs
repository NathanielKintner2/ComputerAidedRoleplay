using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Second_Attempt
{
    public partial class StartupScreen : Form
    {
        public StartupScreen()
        {
            InitializeComponent();
            textBoxAddress.Text = HTMLWriter.BaseURL();
            textBoxAddress.ReadOnly = true;
        }

        private void CharCreator_Click(object sender, EventArgs e)
        {
            CharCreator frmCreator = new CharCreator();
            frmCreator.Show();            
        }

        private void WeaponCreator(object sender, EventArgs e)
        {
            WeaponCreator frmCreator = new WeaponCreator();
            frmCreator.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Combat frmCreator = new Combat();
            frmCreator.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShieldCreator frmCreator = new ShieldCreator();
            frmCreator.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EffectAdder frmCreator = new EffectAdder();
            frmCreator.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CombatEntry frmCreator = new CombatEntry();
            frmCreator.Show();
        }

        private void buttonCombatTesting_Click(object sender, EventArgs e)
        {
            BattleTesting frmCreator = new BattleTesting();
            frmCreator.Show();
        }

        private void buttonArmor_Click(object sender, EventArgs e)
        {
            ArmorCreator frmCreator = new ArmorCreator();
            frmCreator.Show();
        }

        private void btnSpells_Click(object sender, EventArgs e)
        {
            SpellCreator frmCreator = new SpellCreator();
            frmCreator.Show();
        }

        private void btnCastSpells_Click(object sender, EventArgs e)
        {
            SpellCasting frmCreator = new SpellCasting();
            frmCreator.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SpellAssigner frmCreator = new SpellAssigner();
            frmCreator.Show();
        }

        private void buttonEnchantments_Click(object sender, EventArgs e)
        {
            EnchantmentCreator frmCreator = new EnchantmentCreator();
            frmCreator.Show();
        }

        private void btnLoot_Click(object sender, EventArgs e)
        {
            LootTable frmCreator = new LootTable();
            frmCreator.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            ItemCreator frmCreator = new ItemCreator();
            frmCreator.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ItemAssigner frmCreator = new ItemAssigner();
            frmCreator.Show();
        }

        private void StartupScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utilities.myServer.Stop();
        }

        private void buttonEquip_Click(object sender, EventArgs e)
        {
            EquipStatusChanger frmCreator = new EquipStatusChanger();
            frmCreator.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DataExport frmCreator = new DataExport();
            frmCreator.Show();
        }

        private void buttonRecentAttacks_Click(object sender, EventArgs e)
        {
            AfterCrits frmCreator = new AfterCrits();
            frmCreator.Show();
        }
    }
}
