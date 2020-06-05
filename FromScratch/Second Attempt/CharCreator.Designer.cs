namespace Second_Attempt
{
    partial class CharCreator
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblDexterity = new System.Windows.Forms.Label();
            this.lblConstitution = new System.Windows.Forms.Label();
            this.lblIntelligence = new System.Windows.Forms.Label();
            this.lblCharisma = new System.Windows.Forms.Label();
            this.txtBoxStrength = new System.Windows.Forms.TextBox();
            this.txtBoxDexterity = new System.Windows.Forms.TextBox();
            this.txtBoxCharisma = new System.Windows.Forms.TextBox();
            this.txtBoxWisdom = new System.Windows.Forms.TextBox();
            this.txtBoxIntelligence = new System.Windows.Forms.TextBox();
            this.txtBoxConstitution = new System.Windows.Forms.TextBox();
            this.lblWisdom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxHPSkill = new System.Windows.Forms.TextBox();
            this.txtBoxReflexSkill = new System.Windows.Forms.TextBox();
            this.txtBoxArmorSkill = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxEnduranceSkill = new System.Windows.Forms.TextBox();
            this.chkBoxTracked = new System.Windows.Forms.CheckBox();
            this.rtbCharStuff = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPerceptionSkill = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(46, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(146, 43);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(119, 20);
            this.txtBoxName.TabIndex = 1;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Location = new System.Drawing.Point(46, 72);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(47, 13);
            this.lblStrength.TabIndex = 3;
            this.lblStrength.Text = "Strength";
            this.lblStrength.Click += new System.EventHandler(this.lblStrength_Click);
            // 
            // lblDexterity
            // 
            this.lblDexterity.AutoSize = true;
            this.lblDexterity.Location = new System.Drawing.Point(46, 98);
            this.lblDexterity.Name = "lblDexterity";
            this.lblDexterity.Size = new System.Drawing.Size(48, 13);
            this.lblDexterity.TabIndex = 4;
            this.lblDexterity.Text = "Dexterity";
            this.lblDexterity.Click += new System.EventHandler(this.lblDexterity_Click);
            // 
            // lblConstitution
            // 
            this.lblConstitution.AutoSize = true;
            this.lblConstitution.Location = new System.Drawing.Point(46, 124);
            this.lblConstitution.Name = "lblConstitution";
            this.lblConstitution.Size = new System.Drawing.Size(62, 13);
            this.lblConstitution.TabIndex = 5;
            this.lblConstitution.Text = "Constitution";
            this.lblConstitution.Click += new System.EventHandler(this.lblConstitution_Click);
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.AutoSize = true;
            this.lblIntelligence.Location = new System.Drawing.Point(46, 150);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(61, 13);
            this.lblIntelligence.TabIndex = 6;
            this.lblIntelligence.Text = "Intelligence";
            this.lblIntelligence.Click += new System.EventHandler(this.lblIntelligence_Click);
            // 
            // lblCharisma
            // 
            this.lblCharisma.AutoSize = true;
            this.lblCharisma.Location = new System.Drawing.Point(46, 202);
            this.lblCharisma.Name = "lblCharisma";
            this.lblCharisma.Size = new System.Drawing.Size(50, 13);
            this.lblCharisma.TabIndex = 7;
            this.lblCharisma.Text = "Charisma";
            this.lblCharisma.Click += new System.EventHandler(this.lblCharisma_Click);
            // 
            // txtBoxStrength
            // 
            this.txtBoxStrength.Location = new System.Drawing.Point(146, 69);
            this.txtBoxStrength.Name = "txtBoxStrength";
            this.txtBoxStrength.Size = new System.Drawing.Size(119, 20);
            this.txtBoxStrength.TabIndex = 2;
            this.txtBoxStrength.TextChanged += new System.EventHandler(this.txtBoxStrength_TextChanged);
            // 
            // txtBoxDexterity
            // 
            this.txtBoxDexterity.Location = new System.Drawing.Point(146, 95);
            this.txtBoxDexterity.Name = "txtBoxDexterity";
            this.txtBoxDexterity.Size = new System.Drawing.Size(119, 20);
            this.txtBoxDexterity.TabIndex = 3;
            this.txtBoxDexterity.TextChanged += new System.EventHandler(this.txtBoxDexterity_TextChanged);
            // 
            // txtBoxCharisma
            // 
            this.txtBoxCharisma.Location = new System.Drawing.Point(146, 199);
            this.txtBoxCharisma.Name = "txtBoxCharisma";
            this.txtBoxCharisma.Size = new System.Drawing.Size(119, 20);
            this.txtBoxCharisma.TabIndex = 7;
            this.txtBoxCharisma.TextChanged += new System.EventHandler(this.txtBoxCharisma_TextChanged);
            // 
            // txtBoxWisdom
            // 
            this.txtBoxWisdom.Location = new System.Drawing.Point(146, 173);
            this.txtBoxWisdom.Name = "txtBoxWisdom";
            this.txtBoxWisdom.Size = new System.Drawing.Size(119, 20);
            this.txtBoxWisdom.TabIndex = 6;
            this.txtBoxWisdom.TextChanged += new System.EventHandler(this.txtBoxWisdom_TextChanged);
            // 
            // txtBoxIntelligence
            // 
            this.txtBoxIntelligence.Location = new System.Drawing.Point(146, 147);
            this.txtBoxIntelligence.Name = "txtBoxIntelligence";
            this.txtBoxIntelligence.Size = new System.Drawing.Size(119, 20);
            this.txtBoxIntelligence.TabIndex = 5;
            this.txtBoxIntelligence.TextChanged += new System.EventHandler(this.txtBoxIntelligence_TextChanged);
            // 
            // txtBoxConstitution
            // 
            this.txtBoxConstitution.Location = new System.Drawing.Point(146, 121);
            this.txtBoxConstitution.Name = "txtBoxConstitution";
            this.txtBoxConstitution.Size = new System.Drawing.Size(119, 20);
            this.txtBoxConstitution.TabIndex = 4;
            this.txtBoxConstitution.TextChanged += new System.EventHandler(this.txtBoxConstitution_TextChanged);
            // 
            // lblWisdom
            // 
            this.lblWisdom.AutoSize = true;
            this.lblWisdom.Location = new System.Drawing.Point(46, 176);
            this.lblWisdom.Name = "lblWisdom";
            this.lblWisdom.Size = new System.Drawing.Size(45, 13);
            this.lblWisdom.TabIndex = 14;
            this.lblWisdom.Text = "Wisdom";
            this.lblWisdom.Click += new System.EventHandler(this.lblWisdom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "HPSkill";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "ReflexSkill";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "ArmorSkill";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtBoxHPSkill
            // 
            this.txtBoxHPSkill.Location = new System.Drawing.Point(146, 251);
            this.txtBoxHPSkill.Name = "txtBoxHPSkill";
            this.txtBoxHPSkill.Size = new System.Drawing.Size(119, 20);
            this.txtBoxHPSkill.TabIndex = 9;
            this.txtBoxHPSkill.TextChanged += new System.EventHandler(this.txtBoxHPSkill_TextChanged);
            // 
            // txtBoxReflexSkill
            // 
            this.txtBoxReflexSkill.Location = new System.Drawing.Point(146, 277);
            this.txtBoxReflexSkill.Name = "txtBoxReflexSkill";
            this.txtBoxReflexSkill.Size = new System.Drawing.Size(119, 20);
            this.txtBoxReflexSkill.TabIndex = 10;
            this.txtBoxReflexSkill.TextChanged += new System.EventHandler(this.txtBoxReflexSkill_TextChanged);
            // 
            // txtBoxArmorSkill
            // 
            this.txtBoxArmorSkill.Location = new System.Drawing.Point(146, 303);
            this.txtBoxArmorSkill.Name = "txtBoxArmorSkill";
            this.txtBoxArmorSkill.Size = new System.Drawing.Size(119, 20);
            this.txtBoxArmorSkill.TabIndex = 11;
            this.txtBoxArmorSkill.TextChanged += new System.EventHandler(this.txtBoxArmorSkill_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(309, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "EnduranceSkill";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtBoxEnduranceSkill
            // 
            this.txtBoxEnduranceSkill.Location = new System.Drawing.Point(146, 225);
            this.txtBoxEnduranceSkill.Name = "txtBoxEnduranceSkill";
            this.txtBoxEnduranceSkill.Size = new System.Drawing.Size(119, 20);
            this.txtBoxEnduranceSkill.TabIndex = 8;
            this.txtBoxEnduranceSkill.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chkBoxTracked
            // 
            this.chkBoxTracked.AutoSize = true;
            this.chkBoxTracked.Location = new System.Drawing.Point(309, 72);
            this.chkBoxTracked.Name = "chkBoxTracked";
            this.chkBoxTracked.Size = new System.Drawing.Size(110, 17);
            this.chkBoxTracked.TabIndex = 29;
            this.chkBoxTracked.Text = "Is Tracked Online";
            this.chkBoxTracked.UseVisualStyleBackColor = true;
            // 
            // rtbCharStuff
            // 
            this.rtbCharStuff.Location = new System.Drawing.Point(309, 183);
            this.rtbCharStuff.Name = "rtbCharStuff";
            this.rtbCharStuff.Size = new System.Drawing.Size(350, 186);
            this.rtbCharStuff.TabIndex = 30;
            this.rtbCharStuff.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "PerceptionSkill";
            // 
            // txtBoxPerceptionSkill
            // 
            this.txtBoxPerceptionSkill.Location = new System.Drawing.Point(146, 329);
            this.txtBoxPerceptionSkill.Name = "txtBoxPerceptionSkill";
            this.txtBoxPerceptionSkill.Size = new System.Drawing.Size(119, 20);
            this.txtBoxPerceptionSkill.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(146, 355);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(119, 21);
            this.comboBox2.TabIndex = 32;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "CreatureTypes";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(309, 95);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(350, 82);
            this.richTextBoxDescription.TabIndex = 34;
            this.richTextBoxDescription.Text = "";
            // 
            // CharCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 442);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.txtBoxPerceptionSkill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbCharStuff);
            this.Controls.Add(this.chkBoxTracked);
            this.Controls.Add(this.txtBoxEnduranceSkill);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtBoxArmorSkill);
            this.Controls.Add(this.txtBoxReflexSkill);
            this.Controls.Add(this.txtBoxHPSkill);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWisdom);
            this.Controls.Add(this.txtBoxConstitution);
            this.Controls.Add(this.txtBoxIntelligence);
            this.Controls.Add(this.txtBoxWisdom);
            this.Controls.Add(this.txtBoxCharisma);
            this.Controls.Add(this.txtBoxDexterity);
            this.Controls.Add(this.txtBoxStrength);
            this.Controls.Add(this.lblCharisma);
            this.Controls.Add(this.lblIntelligence);
            this.Controls.Add(this.lblConstitution);
            this.Controls.Add(this.lblDexterity);
            this.Controls.Add(this.lblStrength);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CharCreator";
            this.Text = "CharCreator";
            this.Load += new System.EventHandler(this.CharCreator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblDexterity;
        private System.Windows.Forms.Label lblConstitution;
        private System.Windows.Forms.Label lblIntelligence;
        private System.Windows.Forms.Label lblCharisma;
        private System.Windows.Forms.TextBox txtBoxStrength;
        private System.Windows.Forms.TextBox txtBoxDexterity;
        private System.Windows.Forms.TextBox txtBoxCharisma;
        private System.Windows.Forms.TextBox txtBoxWisdom;
        private System.Windows.Forms.TextBox txtBoxIntelligence;
        private System.Windows.Forms.TextBox txtBoxConstitution;
        private System.Windows.Forms.Label lblWisdom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxHPSkill;
        private System.Windows.Forms.TextBox txtBoxReflexSkill;
        private System.Windows.Forms.TextBox txtBoxArmorSkill;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxEnduranceSkill;
        private System.Windows.Forms.CheckBox chkBoxTracked;
        private System.Windows.Forms.RichTextBox rtbCharStuff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxPerceptionSkill;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
    }
}