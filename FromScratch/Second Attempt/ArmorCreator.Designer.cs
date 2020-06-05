namespace Second_Attempt
{
    partial class ArmorCreator
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
            this.buttonSaveWeapon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxArmorName = new System.Windows.Forms.TextBox();
            this.txtBoxWeight = new System.Windows.Forms.TextBox();
            this.txtBoxOffensiveBonus = new System.Windows.Forms.TextBox();
            this.txtBoxDefensiveBonus = new System.Windows.Forms.TextBox();
            this.txtBoxResistanceEfficacy = new System.Windows.Forms.TextBox();
            this.cboBoxArmors = new System.Windows.Forms.ComboBox();
            this.rtbWeaponDescription = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxStaminaReq = new System.Windows.Forms.TextBox();
            this.cboBoxResistanceType = new System.Windows.Forms.ComboBox();
            this.rtbResistanceTypes = new System.Windows.Forms.RichTextBox();
            this.buttonChangeResistance = new System.Windows.Forms.Button();
            this.rtbReductionTypes = new System.Windows.Forms.RichTextBox();
            this.buttonChangeReduction = new System.Windows.Forms.Button();
            this.cboBoxReductionType = new System.Windows.Forms.ComboBox();
            this.txtBoxReductionEfficacy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonToggleCover = new System.Windows.Forms.Button();
            this.comboBoxBodyParts = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBoxCoverAreas = new System.Windows.Forms.RichTextBox();
            this.richTextBoxTechnical = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSuite = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSaveWeapon
            // 
            this.buttonSaveWeapon.Location = new System.Drawing.Point(171, 502);
            this.buttonSaveWeapon.Name = "buttonSaveWeapon";
            this.buttonSaveWeapon.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveWeapon.TabIndex = 0;
            this.buttonSaveWeapon.Text = "Save";
            this.buttonSaveWeapon.UseVisualStyleBackColor = true;
            this.buttonSaveWeapon.Click += new System.EventHandler(this.buttonSaveArmor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Armor Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Offensive Bonus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Defensive Bonus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Damage Resistance Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Efficacy";
            // 
            // txtBoxArmorName
            // 
            this.txtBoxArmorName.Location = new System.Drawing.Point(171, 38);
            this.txtBoxArmorName.Name = "txtBoxArmorName";
            this.txtBoxArmorName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxArmorName.TabIndex = 1;
            // 
            // txtBoxWeight
            // 
            this.txtBoxWeight.Location = new System.Drawing.Point(171, 65);
            this.txtBoxWeight.Name = "txtBoxWeight";
            this.txtBoxWeight.Size = new System.Drawing.Size(100, 20);
            this.txtBoxWeight.TabIndex = 2;
            // 
            // txtBoxOffensiveBonus
            // 
            this.txtBoxOffensiveBonus.Location = new System.Drawing.Point(171, 91);
            this.txtBoxOffensiveBonus.Name = "txtBoxOffensiveBonus";
            this.txtBoxOffensiveBonus.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOffensiveBonus.TabIndex = 4;
            // 
            // txtBoxDefensiveBonus
            // 
            this.txtBoxDefensiveBonus.Location = new System.Drawing.Point(171, 118);
            this.txtBoxDefensiveBonus.Name = "txtBoxDefensiveBonus";
            this.txtBoxDefensiveBonus.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDefensiveBonus.TabIndex = 5;
            // 
            // txtBoxResistanceEfficacy
            // 
            this.txtBoxResistanceEfficacy.Location = new System.Drawing.Point(171, 196);
            this.txtBoxResistanceEfficacy.Name = "txtBoxResistanceEfficacy";
            this.txtBoxResistanceEfficacy.Size = new System.Drawing.Size(100, 20);
            this.txtBoxResistanceEfficacy.TabIndex = 7;
            // 
            // cboBoxArmors
            // 
            this.cboBoxArmors.FormattingEnabled = true;
            this.cboBoxArmors.Location = new System.Drawing.Point(287, 38);
            this.cboBoxArmors.Name = "cboBoxArmors";
            this.cboBoxArmors.Size = new System.Drawing.Size(121, 21);
            this.cboBoxArmors.TabIndex = 13;
            this.cboBoxArmors.SelectedIndexChanged += new System.EventHandler(this.cboBoxArmor_SelectedIndexChanged);
            // 
            // rtbWeaponDescription
            // 
            this.rtbWeaponDescription.Location = new System.Drawing.Point(287, 65);
            this.rtbWeaponDescription.Name = "rtbWeaponDescription";
            this.rtbWeaponDescription.Size = new System.Drawing.Size(121, 99);
            this.rtbWeaponDescription.TabIndex = 12;
            this.rtbWeaponDescription.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Stamina Requirement";
            // 
            // txtBoxStaminaReq
            // 
            this.txtBoxStaminaReq.Location = new System.Drawing.Point(171, 144);
            this.txtBoxStaminaReq.Name = "txtBoxStaminaReq";
            this.txtBoxStaminaReq.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStaminaReq.TabIndex = 9;
            // 
            // cboBoxResistanceType
            // 
            this.cboBoxResistanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxResistanceType.FormattingEnabled = true;
            this.cboBoxResistanceType.Location = new System.Drawing.Point(171, 170);
            this.cboBoxResistanceType.Name = "cboBoxResistanceType";
            this.cboBoxResistanceType.Size = new System.Drawing.Size(100, 21);
            this.cboBoxResistanceType.TabIndex = 6;
            // 
            // rtbResistanceTypes
            // 
            this.rtbResistanceTypes.Location = new System.Drawing.Point(287, 170);
            this.rtbResistanceTypes.Name = "rtbResistanceTypes";
            this.rtbResistanceTypes.Size = new System.Drawing.Size(121, 99);
            this.rtbResistanceTypes.TabIndex = 37;
            this.rtbResistanceTypes.Text = "";
            // 
            // buttonChangeResistance
            // 
            this.buttonChangeResistance.Location = new System.Drawing.Point(171, 223);
            this.buttonChangeResistance.Name = "buttonChangeResistance";
            this.buttonChangeResistance.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeResistance.TabIndex = 38;
            this.buttonChangeResistance.Text = "Change Damage";
            this.buttonChangeResistance.UseVisualStyleBackColor = true;
            this.buttonChangeResistance.Click += new System.EventHandler(this.buttonChangeResistance_Click);
            // 
            // rtbReductionTypes
            // 
            this.rtbReductionTypes.Location = new System.Drawing.Point(287, 275);
            this.rtbReductionTypes.Name = "rtbReductionTypes";
            this.rtbReductionTypes.Size = new System.Drawing.Size(121, 99);
            this.rtbReductionTypes.TabIndex = 39;
            this.rtbReductionTypes.Text = "";
            // 
            // buttonChangeReduction
            // 
            this.buttonChangeReduction.Location = new System.Drawing.Point(171, 328);
            this.buttonChangeReduction.Name = "buttonChangeReduction";
            this.buttonChangeReduction.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeReduction.TabIndex = 44;
            this.buttonChangeReduction.Text = "Change Damage";
            this.buttonChangeReduction.UseVisualStyleBackColor = true;
            this.buttonChangeReduction.Click += new System.EventHandler(this.buttonChangeReduction_Click);
            // 
            // cboBoxReductionType
            // 
            this.cboBoxReductionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxReductionType.FormattingEnabled = true;
            this.cboBoxReductionType.Location = new System.Drawing.Point(171, 275);
            this.cboBoxReductionType.Name = "cboBoxReductionType";
            this.cboBoxReductionType.Size = new System.Drawing.Size(100, 21);
            this.cboBoxReductionType.TabIndex = 40;
            // 
            // txtBoxReductionEfficacy
            // 
            this.txtBoxReductionEfficacy.Location = new System.Drawing.Point(171, 301);
            this.txtBoxReductionEfficacy.Name = "txtBoxReductionEfficacy";
            this.txtBoxReductionEfficacy.Size = new System.Drawing.Size(100, 20);
            this.txtBoxReductionEfficacy.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Efficacy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Damage Reduction Type";
            // 
            // buttonToggleCover
            // 
            this.buttonToggleCover.Location = new System.Drawing.Point(171, 407);
            this.buttonToggleCover.Name = "buttonToggleCover";
            this.buttonToggleCover.Size = new System.Drawing.Size(75, 23);
            this.buttonToggleCover.TabIndex = 51;
            this.buttonToggleCover.Text = "Toggle";
            this.buttonToggleCover.UseVisualStyleBackColor = true;
            this.buttonToggleCover.Click += new System.EventHandler(this.buttonToggleCover_Click);
            // 
            // comboBoxBodyParts
            // 
            this.comboBoxBodyParts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBodyParts.FormattingEnabled = true;
            this.comboBoxBodyParts.Location = new System.Drawing.Point(171, 380);
            this.comboBoxBodyParts.Name = "comboBoxBodyParts";
            this.comboBoxBodyParts.Size = new System.Drawing.Size(100, 21);
            this.comboBoxBodyParts.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Cover Area";
            // 
            // richTextBoxCoverAreas
            // 
            this.richTextBoxCoverAreas.Location = new System.Drawing.Point(287, 380);
            this.richTextBoxCoverAreas.Name = "richTextBoxCoverAreas";
            this.richTextBoxCoverAreas.Size = new System.Drawing.Size(121, 99);
            this.richTextBoxCoverAreas.TabIndex = 46;
            this.richTextBoxCoverAreas.Text = "";
            // 
            // richTextBoxTechnical
            // 
            this.richTextBoxTechnical.Location = new System.Drawing.Point(414, 68);
            this.richTextBoxTechnical.Name = "richTextBoxTechnical";
            this.richTextBoxTechnical.Size = new System.Drawing.Size(134, 201);
            this.richTextBoxTechnical.TabIndex = 52;
            this.richTextBoxTechnical.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 53;
            this.button1.Text = "ToggleAll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSuite
            // 
            this.buttonSuite.Location = new System.Drawing.Point(473, 12);
            this.buttonSuite.Name = "buttonSuite";
            this.buttonSuite.Size = new System.Drawing.Size(75, 42);
            this.buttonSuite.TabIndex = 54;
            this.buttonSuite.Text = "Write Armor Suite";
            this.buttonSuite.UseVisualStyleBackColor = true;
            this.buttonSuite.Click += new System.EventHandler(this.buttonSuite_Click);
            // 
            // ArmorCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 551);
            this.Controls.Add(this.buttonSuite);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxTechnical);
            this.Controls.Add(this.buttonToggleCover);
            this.Controls.Add(this.comboBoxBodyParts);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.richTextBoxCoverAreas);
            this.Controls.Add(this.buttonChangeReduction);
            this.Controls.Add(this.cboBoxReductionType);
            this.Controls.Add(this.txtBoxReductionEfficacy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtbReductionTypes);
            this.Controls.Add(this.buttonChangeResistance);
            this.Controls.Add(this.rtbResistanceTypes);
            this.Controls.Add(this.cboBoxResistanceType);
            this.Controls.Add(this.txtBoxStaminaReq);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rtbWeaponDescription);
            this.Controls.Add(this.cboBoxArmors);
            this.Controls.Add(this.txtBoxResistanceEfficacy);
            this.Controls.Add(this.txtBoxDefensiveBonus);
            this.Controls.Add(this.txtBoxOffensiveBonus);
            this.Controls.Add(this.txtBoxWeight);
            this.Controls.Add(this.txtBoxArmorName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveWeapon);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ArmorCreator";
            this.Text = "ArmorCreator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveWeapon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxArmorName;
        private System.Windows.Forms.TextBox txtBoxWeight;
        private System.Windows.Forms.TextBox txtBoxOffensiveBonus;
        private System.Windows.Forms.TextBox txtBoxDefensiveBonus;
        private System.Windows.Forms.TextBox txtBoxResistanceEfficacy;
        private System.Windows.Forms.ComboBox cboBoxArmors;
        private System.Windows.Forms.RichTextBox rtbWeaponDescription;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxStaminaReq;
        private System.Windows.Forms.ComboBox cboBoxResistanceType;
        private System.Windows.Forms.RichTextBox rtbResistanceTypes;
        private System.Windows.Forms.Button buttonChangeResistance;
        private System.Windows.Forms.RichTextBox rtbReductionTypes;
        private System.Windows.Forms.Button buttonChangeReduction;
        private System.Windows.Forms.ComboBox cboBoxReductionType;
        private System.Windows.Forms.TextBox txtBoxReductionEfficacy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonToggleCover;
        private System.Windows.Forms.ComboBox comboBoxBodyParts;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBoxCoverAreas;
        private System.Windows.Forms.RichTextBox richTextBoxTechnical;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSuite;
    }
}