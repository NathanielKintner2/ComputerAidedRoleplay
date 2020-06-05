namespace Second_Attempt
{
    partial class Combat
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
            this.cboBoxChar1 = new System.Windows.Forms.ComboBox();
            this.cboBoxWeapon1 = new System.Windows.Forms.ComboBox();
            this.cboBoxChar2 = new System.Windows.Forms.ComboBox();
            this.cboBoxWeapon2 = new System.Windows.Forms.ComboBox();
            this.txtBoxDamage = new System.Windows.Forms.TextBox();
            this.txtBoxOffensiveRoll = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxOffensiveBonus = new System.Windows.Forms.TextBox();
            this.txtBoxDefensiveBonus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboBoxShield1 = new System.Windows.Forms.ComboBox();
            this.cboBoxShield2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxCrit = new System.Windows.Forms.TextBox();
            this.chkBoxGraph = new System.Windows.Forms.CheckBox();
            this.txtBoxDefensiveRoll = new System.Windows.Forms.TextBox();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblStamina = new System.Windows.Forms.Label();
            this.lblWeightFactor = new System.Windows.Forms.Label();
            this.lblReflex = new System.Windows.Forms.Label();
            this.lblArmor = new System.Windows.Forms.Label();
            this.lblHitCaliber = new System.Windows.Forms.Label();
            this.lblHitStrength = new System.Windows.Forms.Label();
            this.rtbAverageResults = new System.Windows.Forms.RichTextBox();
            this.checkBoxStartup = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Attack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboBoxChar1
            // 
            this.cboBoxChar1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxChar1.FormattingEnabled = true;
            this.cboBoxChar1.Location = new System.Drawing.Point(114, 36);
            this.cboBoxChar1.Name = "cboBoxChar1";
            this.cboBoxChar1.Size = new System.Drawing.Size(121, 21);
            this.cboBoxChar1.TabIndex = 1;
            this.cboBoxChar1.SelectedIndexChanged += new System.EventHandler(this.cboBoxChar1_SelectedIndexChanged);
            // 
            // cboBoxWeapon1
            // 
            this.cboBoxWeapon1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxWeapon1.FormattingEnabled = true;
            this.cboBoxWeapon1.Location = new System.Drawing.Point(114, 71);
            this.cboBoxWeapon1.Name = "cboBoxWeapon1";
            this.cboBoxWeapon1.Size = new System.Drawing.Size(121, 21);
            this.cboBoxWeapon1.TabIndex = 2;
            this.cboBoxWeapon1.SelectedIndexChanged += new System.EventHandler(this.cboBoxWeapon1_SelectedIndexChanged);
            // 
            // cboBoxChar2
            // 
            this.cboBoxChar2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxChar2.FormattingEnabled = true;
            this.cboBoxChar2.Location = new System.Drawing.Point(276, 36);
            this.cboBoxChar2.Name = "cboBoxChar2";
            this.cboBoxChar2.Size = new System.Drawing.Size(121, 21);
            this.cboBoxChar2.TabIndex = 4;
            this.cboBoxChar2.SelectedIndexChanged += new System.EventHandler(this.cboBoxChar2_SelectedIndexChanged);
            // 
            // cboBoxWeapon2
            // 
            this.cboBoxWeapon2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxWeapon2.FormattingEnabled = true;
            this.cboBoxWeapon2.Location = new System.Drawing.Point(276, 71);
            this.cboBoxWeapon2.Name = "cboBoxWeapon2";
            this.cboBoxWeapon2.Size = new System.Drawing.Size(121, 21);
            this.cboBoxWeapon2.TabIndex = 5;
            // 
            // txtBoxDamage
            // 
            this.txtBoxDamage.Location = new System.Drawing.Point(196, 289);
            this.txtBoxDamage.Name = "txtBoxDamage";
            this.txtBoxDamage.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDamage.TabIndex = 13;
            // 
            // txtBoxOffensiveRoll
            // 
            this.txtBoxOffensiveRoll.Location = new System.Drawing.Point(114, 127);
            this.txtBoxOffensiveRoll.Name = "txtBoxOffensiveRoll";
            this.txtBoxOffensiveRoll.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOffensiveRoll.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Attacker/Defender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Weapon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Roll";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bonuses";
            // 
            // txtBoxOffensiveBonus
            // 
            this.txtBoxOffensiveBonus.Location = new System.Drawing.Point(114, 160);
            this.txtBoxOffensiveBonus.Name = "txtBoxOffensiveBonus";
            this.txtBoxOffensiveBonus.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOffensiveBonus.TabIndex = 9;
            // 
            // txtBoxDefensiveBonus
            // 
            this.txtBoxDefensiveBonus.Location = new System.Drawing.Point(276, 159);
            this.txtBoxDefensiveBonus.Name = "txtBoxDefensiveBonus";
            this.txtBoxDefensiveBonus.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDefensiveBonus.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Shield";
            // 
            // cboBoxShield1
            // 
            this.cboBoxShield1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxShield1.FormattingEnabled = true;
            this.cboBoxShield1.Location = new System.Drawing.Point(114, 98);
            this.cboBoxShield1.Name = "cboBoxShield1";
            this.cboBoxShield1.Size = new System.Drawing.Size(121, 21);
            this.cboBoxShield1.TabIndex = 3;
            this.cboBoxShield1.SelectedIndexChanged += new System.EventHandler(this.cboBoxShield1_SelectedIndexChanged);
            // 
            // cboBoxShield2
            // 
            this.cboBoxShield2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxShield2.FormattingEnabled = true;
            this.cboBoxShield2.Location = new System.Drawing.Point(276, 98);
            this.cboBoxShield2.Name = "cboBoxShield2";
            this.cboBoxShield2.Size = new System.Drawing.Size(121, 21);
            this.cboBoxShield2.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Damage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Result";
            // 
            // txtBoxCrit
            // 
            this.txtBoxCrit.Location = new System.Drawing.Point(196, 222);
            this.txtBoxCrit.Name = "txtBoxCrit";
            this.txtBoxCrit.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCrit.TabIndex = 12;
            // 
            // chkBoxGraph
            // 
            this.chkBoxGraph.AutoSize = true;
            this.chkBoxGraph.Location = new System.Drawing.Point(320, 224);
            this.chkBoxGraph.Name = "chkBoxGraph";
            this.chkBoxGraph.Size = new System.Drawing.Size(95, 17);
            this.chkBoxGraph.TabIndex = 11;
            this.chkBoxGraph.Text = "Create Graph?";
            this.chkBoxGraph.UseVisualStyleBackColor = true;
            // 
            // txtBoxDefensiveRoll
            // 
            this.txtBoxDefensiveRoll.Location = new System.Drawing.Point(276, 127);
            this.txtBoxDefensiveRoll.Name = "txtBoxDefensiveRoll";
            this.txtBoxDefensiveRoll.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDefensiveRoll.TabIndex = 8;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(469, 36);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(35, 13);
            this.lblHealth.TabIndex = 26;
            this.lblHealth.Text = "label5";
            // 
            // lblStamina
            // 
            this.lblStamina.AutoSize = true;
            this.lblStamina.Location = new System.Drawing.Point(469, 60);
            this.lblStamina.Name = "lblStamina";
            this.lblStamina.Size = new System.Drawing.Size(35, 13);
            this.lblStamina.TabIndex = 27;
            this.lblStamina.Text = "label5";
            // 
            // lblWeightFactor
            // 
            this.lblWeightFactor.AutoSize = true;
            this.lblWeightFactor.Location = new System.Drawing.Point(469, 88);
            this.lblWeightFactor.Name = "lblWeightFactor";
            this.lblWeightFactor.Size = new System.Drawing.Size(35, 13);
            this.lblWeightFactor.TabIndex = 28;
            this.lblWeightFactor.Text = "label5";
            // 
            // lblReflex
            // 
            this.lblReflex.AutoSize = true;
            this.lblReflex.Location = new System.Drawing.Point(469, 116);
            this.lblReflex.Name = "lblReflex";
            this.lblReflex.Size = new System.Drawing.Size(35, 13);
            this.lblReflex.TabIndex = 29;
            this.lblReflex.Text = "label5";
            // 
            // lblArmor
            // 
            this.lblArmor.AutoSize = true;
            this.lblArmor.Location = new System.Drawing.Point(469, 147);
            this.lblArmor.Name = "lblArmor";
            this.lblArmor.Size = new System.Drawing.Size(35, 13);
            this.lblArmor.TabIndex = 30;
            this.lblArmor.Text = "label5";
            // 
            // lblHitCaliber
            // 
            this.lblHitCaliber.AutoSize = true;
            this.lblHitCaliber.Location = new System.Drawing.Point(193, 249);
            this.lblHitCaliber.Name = "lblHitCaliber";
            this.lblHitCaliber.Size = new System.Drawing.Size(38, 13);
            this.lblHitCaliber.TabIndex = 31;
            this.lblHitCaliber.Text = "caliber";
            // 
            // lblHitStrength
            // 
            this.lblHitStrength.AutoSize = true;
            this.lblHitStrength.Location = new System.Drawing.Point(193, 268);
            this.lblHitStrength.Name = "lblHitStrength";
            this.lblHitStrength.Size = new System.Drawing.Size(45, 13);
            this.lblHitStrength.TabIndex = 32;
            this.lblHitStrength.Text = "strength";
            // 
            // rtbAverageResults
            // 
            this.rtbAverageResults.Location = new System.Drawing.Point(472, 186);
            this.rtbAverageResults.Name = "rtbAverageResults";
            this.rtbAverageResults.Size = new System.Drawing.Size(260, 152);
            this.rtbAverageResults.TabIndex = 33;
            this.rtbAverageResults.Text = "";
            // 
            // checkBoxStartup
            // 
            this.checkBoxStartup.AutoSize = true;
            this.checkBoxStartup.Location = new System.Drawing.Point(320, 249);
            this.checkBoxStartup.Name = "checkBoxStartup";
            this.checkBoxStartup.Size = new System.Drawing.Size(83, 17);
            this.checkBoxStartup.TabIndex = 34;
            this.checkBoxStartup.Text = "Run Startup";
            this.checkBoxStartup.UseVisualStyleBackColor = true;
            // 
            // Combat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 350);
            this.Controls.Add(this.checkBoxStartup);
            this.Controls.Add(this.rtbAverageResults);
            this.Controls.Add(this.lblHitStrength);
            this.Controls.Add(this.lblHitCaliber);
            this.Controls.Add(this.lblArmor);
            this.Controls.Add(this.lblReflex);
            this.Controls.Add(this.lblWeightFactor);
            this.Controls.Add(this.lblStamina);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.txtBoxDefensiveRoll);
            this.Controls.Add(this.chkBoxGraph);
            this.Controls.Add(this.txtBoxCrit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboBoxShield2);
            this.Controls.Add(this.cboBoxShield1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxDefensiveBonus);
            this.Controls.Add(this.txtBoxOffensiveBonus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxOffensiveRoll);
            this.Controls.Add(this.txtBoxDamage);
            this.Controls.Add(this.cboBoxWeapon2);
            this.Controls.Add(this.cboBoxChar2);
            this.Controls.Add(this.cboBoxWeapon1);
            this.Controls.Add(this.cboBoxChar1);
            this.Controls.Add(this.button1);
            this.Name = "Combat";
            this.Text = "Combat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboBoxChar1;
        private System.Windows.Forms.ComboBox cboBoxWeapon1;
        private System.Windows.Forms.ComboBox cboBoxChar2;
        private System.Windows.Forms.ComboBox cboBoxWeapon2;
        private System.Windows.Forms.TextBox txtBoxDamage;
        private System.Windows.Forms.TextBox txtBoxOffensiveRoll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxOffensiveBonus;
        private System.Windows.Forms.TextBox txtBoxDefensiveBonus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboBoxShield1;
        private System.Windows.Forms.ComboBox cboBoxShield2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxCrit;
        private System.Windows.Forms.CheckBox chkBoxGraph;
        private System.Windows.Forms.TextBox txtBoxDefensiveRoll;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblStamina;
        private System.Windows.Forms.Label lblWeightFactor;
        private System.Windows.Forms.Label lblReflex;
        private System.Windows.Forms.Label lblArmor;
        private System.Windows.Forms.Label lblHitCaliber;
        private System.Windows.Forms.Label lblHitStrength;
        private System.Windows.Forms.RichTextBox rtbAverageResults;
        private System.Windows.Forms.CheckBox checkBoxStartup;
    }
}