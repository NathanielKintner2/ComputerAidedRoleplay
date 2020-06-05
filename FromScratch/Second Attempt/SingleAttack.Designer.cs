namespace Second_Attempt
{
    partial class SingleAttack
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxOffensiveRoll = new System.Windows.Forms.TextBox();
            this.followTheTaco = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtBoxDefensiveRoll = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOffensiveBonus = new System.Windows.Forms.Label();
            this.lblAttackerWeapon = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDefensiveBonus = new System.Windows.Forms.Label();
            this.lblDefenderWeapon = new System.Windows.Forms.Label();
            this.comboBoxAttackerWeapon = new System.Windows.Forms.ComboBox();
            this.comboBoxDefenderWeapon = new System.Windows.Forms.ComboBox();
            this.labelAfterOffensiveMods = new System.Windows.Forms.Label();
            this.labelAfterDefensiveMods = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // txtBoxOffensiveRoll
            // 
            this.txtBoxOffensiveRoll.Location = new System.Drawing.Point(167, 74);
            this.txtBoxOffensiveRoll.Name = "txtBoxOffensiveRoll";
            this.txtBoxOffensiveRoll.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOffensiveRoll.TabIndex = 1;
            this.txtBoxOffensiveRoll.TextChanged += new System.EventHandler(this.txtBoxOffensiveRoll_TextChanged);
            // 
            // followTheTaco
            // 
            this.followTheTaco.Location = new System.Drawing.Point(645, 47);
            this.followTheTaco.Name = "followTheTaco";
            this.followTheTaco.Size = new System.Drawing.Size(75, 35);
            this.followTheTaco.TabIndex = 4;
            this.followTheTaco.Text = "Attack";
            this.followTheTaco.UseVisualStyleBackColor = true;
            this.followTheTaco.Click += new System.EventHandler(this.followTheTaco_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(467, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtBoxDefensiveRoll
            // 
            this.txtBoxDefensiveRoll.Location = new System.Drawing.Point(467, 74);
            this.txtBoxDefensiveRoll.Name = "txtBoxDefensiveRoll";
            this.txtBoxDefensiveRoll.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDefensiveRoll.TabIndex = 6;
            this.txtBoxDefensiveRoll.TextChanged += new System.EventHandler(this.txtBoxDefensiveRoll_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Attacker";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Raw Attack Roll";
            // 
            // lblOffensiveBonus
            // 
            this.lblOffensiveBonus.AutoSize = true;
            this.lblOffensiveBonus.Location = new System.Drawing.Point(9, 103);
            this.lblOffensiveBonus.Name = "lblOffensiveBonus";
            this.lblOffensiveBonus.Size = new System.Drawing.Size(130, 13);
            this.lblOffensiveBonus.TabIndex = 9;
            this.lblOffensiveBonus.Text = "Post OB, Weight, Stamina";
            // 
            // lblAttackerWeapon
            // 
            this.lblAttackerWeapon.AutoSize = true;
            this.lblAttackerWeapon.Location = new System.Drawing.Point(11, 47);
            this.lblAttackerWeapon.Name = "lblAttackerWeapon";
            this.lblAttackerWeapon.Size = new System.Drawing.Size(48, 13);
            this.lblAttackerWeapon.TabIndex = 10;
            this.lblAttackerWeapon.Text = "Weapon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(306, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Defender";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Raw Defense Roll";
            // 
            // lblDefensiveBonus
            // 
            this.lblDefensiveBonus.AutoSize = true;
            this.lblDefensiveBonus.Location = new System.Drawing.Point(306, 103);
            this.lblDefensiveBonus.Name = "lblDefensiveBonus";
            this.lblDefensiveBonus.Size = new System.Drawing.Size(130, 13);
            this.lblDefensiveBonus.TabIndex = 17;
            this.lblDefensiveBonus.Text = "Post DB, Weight, Stamina";
            // 
            // lblDefenderWeapon
            // 
            this.lblDefenderWeapon.AutoSize = true;
            this.lblDefenderWeapon.Location = new System.Drawing.Point(306, 50);
            this.lblDefenderWeapon.Name = "lblDefenderWeapon";
            this.lblDefenderWeapon.Size = new System.Drawing.Size(48, 13);
            this.lblDefenderWeapon.TabIndex = 18;
            this.lblDefenderWeapon.Text = "Weapon";
            // 
            // comboBoxAttackerWeapon
            // 
            this.comboBoxAttackerWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAttackerWeapon.FormattingEnabled = true;
            this.comboBoxAttackerWeapon.Location = new System.Drawing.Point(167, 47);
            this.comboBoxAttackerWeapon.Name = "comboBoxAttackerWeapon";
            this.comboBoxAttackerWeapon.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAttackerWeapon.TabIndex = 38;
            this.comboBoxAttackerWeapon.SelectedIndexChanged += new System.EventHandler(this.comboBoxAttackerWeapon_SelectedIndexChanged);
            // 
            // comboBoxDefenderWeapon
            // 
            this.comboBoxDefenderWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDefenderWeapon.FormattingEnabled = true;
            this.comboBoxDefenderWeapon.Location = new System.Drawing.Point(467, 47);
            this.comboBoxDefenderWeapon.Name = "comboBoxDefenderWeapon";
            this.comboBoxDefenderWeapon.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDefenderWeapon.TabIndex = 39;
            this.comboBoxDefenderWeapon.SelectedIndexChanged += new System.EventHandler(this.comboBoxDefenderWeapon_SelectedIndexChanged);
            // 
            // labelAfterOffensiveMods
            // 
            this.labelAfterOffensiveMods.AutoSize = true;
            this.labelAfterOffensiveMods.Location = new System.Drawing.Point(164, 103);
            this.labelAfterOffensiveMods.Name = "labelAfterOffensiveMods";
            this.labelAfterOffensiveMods.Size = new System.Drawing.Size(130, 13);
            this.labelAfterOffensiveMods.TabIndex = 40;
            this.labelAfterOffensiveMods.Text = "Post OB, Weight, Stamina";
            // 
            // labelAfterDefensiveMods
            // 
            this.labelAfterDefensiveMods.AutoSize = true;
            this.labelAfterDefensiveMods.Location = new System.Drawing.Point(464, 103);
            this.labelAfterDefensiveMods.Name = "labelAfterDefensiveMods";
            this.labelAfterDefensiveMods.Size = new System.Drawing.Size(130, 13);
            this.labelAfterDefensiveMods.TabIndex = 41;
            this.labelAfterDefensiveMods.Text = "Post OB, Weight, Stamina";
            // 
            // SingleAttack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 136);
            this.Controls.Add(this.labelAfterDefensiveMods);
            this.Controls.Add(this.labelAfterOffensiveMods);
            this.Controls.Add(this.comboBoxDefenderWeapon);
            this.Controls.Add(this.comboBoxAttackerWeapon);
            this.Controls.Add(this.lblDefenderWeapon);
            this.Controls.Add(this.lblDefensiveBonus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblAttackerWeapon);
            this.Controls.Add(this.lblOffensiveBonus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxDefensiveRoll);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.followTheTaco);
            this.Controls.Add(this.txtBoxOffensiveRoll);
            this.Controls.Add(this.label1);
            this.Name = "SingleAttack";
            this.Text = "SingleAttack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxOffensiveRoll;
        private System.Windows.Forms.Button followTheTaco;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtBoxDefensiveRoll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOffensiveBonus;
        private System.Windows.Forms.Label lblAttackerWeapon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDefensiveBonus;
        private System.Windows.Forms.Label lblDefenderWeapon;
        private System.Windows.Forms.ComboBox comboBoxAttackerWeapon;
        private System.Windows.Forms.ComboBox comboBoxDefenderWeapon;
        private System.Windows.Forms.Label labelAfterOffensiveMods;
        private System.Windows.Forms.Label labelAfterDefensiveMods;
    }
}