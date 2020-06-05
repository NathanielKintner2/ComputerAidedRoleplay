namespace Second_Attempt
{
    partial class StartupScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonCombatTesting = new System.Windows.Forms.Button();
            this.buttonArmor = new System.Windows.Forms.Button();
            this.btnSpells = new System.Windows.Forms.Button();
            this.btnCastSpells = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonEnchantments = new System.Windows.Forms.Button();
            this.btnLoot = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.buttonEquip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRecentAttacks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Characters";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CharCreator_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Weapons";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.WeaponCreator);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 43);
            this.button4.TabIndex = 3;
            this.button4.Text = "Combat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(174, 27);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 38);
            this.button5.TabIndex = 4;
            this.button5.Text = "Shields";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(408, 193);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 27);
            this.button7.TabIndex = 6;
            this.button7.Text = "Effects";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(93, 226);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 43);
            this.button8.TabIndex = 7;
            this.button8.Text = "Combat Entry";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // buttonCombatTesting
            // 
            this.buttonCombatTesting.Location = new System.Drawing.Point(255, 226);
            this.buttonCombatTesting.Name = "buttonCombatTesting";
            this.buttonCombatTesting.Size = new System.Drawing.Size(75, 43);
            this.buttonCombatTesting.TabIndex = 8;
            this.buttonCombatTesting.Text = "Combat Testing";
            this.buttonCombatTesting.UseVisualStyleBackColor = true;
            this.buttonCombatTesting.Click += new System.EventHandler(this.buttonCombatTesting_Click);
            // 
            // buttonArmor
            // 
            this.buttonArmor.Location = new System.Drawing.Point(255, 27);
            this.buttonArmor.Name = "buttonArmor";
            this.buttonArmor.Size = new System.Drawing.Size(75, 38);
            this.buttonArmor.TabIndex = 9;
            this.buttonArmor.Text = "Armor";
            this.buttonArmor.UseVisualStyleBackColor = true;
            this.buttonArmor.Click += new System.EventHandler(this.buttonArmor_Click);
            // 
            // btnSpells
            // 
            this.btnSpells.Location = new System.Drawing.Point(12, 120);
            this.btnSpells.Name = "btnSpells";
            this.btnSpells.Size = new System.Drawing.Size(75, 38);
            this.btnSpells.TabIndex = 11;
            this.btnSpells.Text = "Spells";
            this.btnSpells.UseVisualStyleBackColor = true;
            this.btnSpells.Click += new System.EventHandler(this.btnSpells_Click);
            // 
            // btnCastSpells
            // 
            this.btnCastSpells.Location = new System.Drawing.Point(93, 120);
            this.btnCastSpells.Name = "btnCastSpells";
            this.btnCastSpells.Size = new System.Drawing.Size(75, 38);
            this.btnCastSpells.TabIndex = 12;
            this.btnCastSpells.Text = "Cast Spell";
            this.btnCastSpells.UseVisualStyleBackColor = true;
            this.btnCastSpells.Click += new System.EventHandler(this.btnCastSpells_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(174, 120);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 38);
            this.button9.TabIndex = 13;
            this.button9.Text = "Spell Assigner";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonEnchantments
            // 
            this.buttonEnchantments.Location = new System.Drawing.Point(408, 226);
            this.buttonEnchantments.Name = "buttonEnchantments";
            this.buttonEnchantments.Size = new System.Drawing.Size(84, 43);
            this.buttonEnchantments.TabIndex = 14;
            this.buttonEnchantments.Text = "Enchantments";
            this.buttonEnchantments.UseVisualStyleBackColor = true;
            this.buttonEnchantments.Click += new System.EventHandler(this.buttonEnchantments_Click);
            // 
            // btnLoot
            // 
            this.btnLoot.Location = new System.Drawing.Point(417, 120);
            this.btnLoot.Name = "btnLoot";
            this.btnLoot.Size = new System.Drawing.Size(75, 38);
            this.btnLoot.TabIndex = 15;
            this.btnLoot.Text = "Generate Loot";
            this.btnLoot.UseVisualStyleBackColor = true;
            this.btnLoot.Click += new System.EventHandler(this.btnLoot_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(336, 27);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 38);
            this.button10.TabIndex = 16;
            this.button10.Text = "Other Items";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(417, 27);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 38);
            this.button11.TabIndex = 17;
            this.button11.Text = "Item Assigner";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(1, 1);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(300, 20);
            this.textBoxAddress.TabIndex = 18;
            // 
            // buttonEquip
            // 
            this.buttonEquip.Location = new System.Drawing.Point(417, 71);
            this.buttonEquip.Name = "buttonEquip";
            this.buttonEquip.Size = new System.Drawing.Size(75, 43);
            this.buttonEquip.TabIndex = 19;
            this.buttonEquip.Text = "Equip";
            this.buttonEquip.UseVisualStyleBackColor = true;
            this.buttonEquip.Click += new System.EventHandler(this.buttonEquip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "GenerateDataBlob";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonRecentAttacks
            // 
            this.buttonRecentAttacks.Location = new System.Drawing.Point(174, 226);
            this.buttonRecentAttacks.Name = "buttonRecentAttacks";
            this.buttonRecentAttacks.Size = new System.Drawing.Size(75, 43);
            this.buttonRecentAttacks.TabIndex = 21;
            this.buttonRecentAttacks.Text = "Recent Attacks";
            this.buttonRecentAttacks.UseVisualStyleBackColor = true;
            this.buttonRecentAttacks.Click += new System.EventHandler(this.buttonRecentAttacks_Click);
            // 
            // StartupScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 281);
            this.Controls.Add(this.buttonRecentAttacks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEquip);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btnLoot);
            this.Controls.Add(this.buttonEnchantments);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnCastSpells);
            this.Controls.Add(this.btnSpells);
            this.Controls.Add(this.buttonArmor);
            this.Controls.Add(this.buttonCombatTesting);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "StartupScreen";
            this.Text = "StartupScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartupScreen_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button buttonCombatTesting;
        private System.Windows.Forms.Button buttonArmor;
        private System.Windows.Forms.Button btnSpells;
        private System.Windows.Forms.Button btnCastSpells;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonEnchantments;
        private System.Windows.Forms.Button btnLoot;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button buttonEquip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRecentAttacks;
    }
}