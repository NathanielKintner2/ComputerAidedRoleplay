namespace Second_Attempt
{
    partial class SpellCasting
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
            this.cboBoxChars = new System.Windows.Forms.ComboBox();
            this.cboBoxSpells = new System.Windows.Forms.ComboBox();
            this.txtBoxSpellPower = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCastSpell = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chkBoxSecurity = new System.Windows.Forms.CheckBox();
            this.cboBoxCaster = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxDefenseRoll = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboBoxChars
            // 
            this.cboBoxChars.FormattingEnabled = true;
            this.cboBoxChars.Location = new System.Drawing.Point(335, 36);
            this.cboBoxChars.Name = "cboBoxChars";
            this.cboBoxChars.Size = new System.Drawing.Size(121, 21);
            this.cboBoxChars.TabIndex = 0;
            // 
            // cboBoxSpells
            // 
            this.cboBoxSpells.FormattingEnabled = true;
            this.cboBoxSpells.Location = new System.Drawing.Point(12, 54);
            this.cboBoxSpells.Name = "cboBoxSpells";
            this.cboBoxSpells.Size = new System.Drawing.Size(121, 21);
            this.cboBoxSpells.TabIndex = 1;
            // 
            // txtBoxSpellPower
            // 
            this.txtBoxSpellPower.Location = new System.Drawing.Point(208, 63);
            this.txtBoxSpellPower.Name = "txtBoxSpellPower";
            this.txtBoxSpellPower.Size = new System.Drawing.Size(121, 20);
            this.txtBoxSpellPower.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Spell";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Spell Power";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Target";
            // 
            // btnCastSpell
            // 
            this.btnCastSpell.Location = new System.Drawing.Point(279, 96);
            this.btnCastSpell.Name = "btnCastSpell";
            this.btnCastSpell.Size = new System.Drawing.Size(75, 23);
            this.btnCastSpell.TabIndex = 6;
            this.btnCastSpell.Text = "Cast Spell";
            this.btnCastSpell.UseVisualStyleBackColor = true;
            this.btnCastSpell.Click += new System.EventHandler(this.btnCastSpell_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(33, 150);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(519, 215);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // chkBoxSecurity
            // 
            this.chkBoxSecurity.AutoSize = true;
            this.chkBoxSecurity.Location = new System.Drawing.Point(360, 100);
            this.chkBoxSecurity.Name = "chkBoxSecurity";
            this.chkBoxSecurity.Size = new System.Drawing.Size(57, 17);
            this.chkBoxSecurity.TabIndex = 8;
            this.chkBoxSecurity.Text = "Ready";
            this.chkBoxSecurity.UseVisualStyleBackColor = true;
            this.chkBoxSecurity.CheckedChanged += new System.EventHandler(this.chkBoxSecurity_CheckedChanged);
            // 
            // cboBoxCaster
            // 
            this.cboBoxCaster.FormattingEnabled = true;
            this.cboBoxCaster.Location = new System.Drawing.Point(208, 36);
            this.cboBoxCaster.Name = "cboBoxCaster";
            this.cboBoxCaster.Size = new System.Drawing.Size(121, 21);
            this.cboBoxCaster.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Caster";
            // 
            // txtBoxDefenseRoll
            // 
            this.txtBoxDefenseRoll.Location = new System.Drawing.Point(335, 63);
            this.txtBoxDefenseRoll.Name = "txtBoxDefenseRoll";
            this.txtBoxDefenseRoll.Size = new System.Drawing.Size(121, 20);
            this.txtBoxDefenseRoll.TabIndex = 11;
            // 
            // SpellCasting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 397);
            this.Controls.Add(this.txtBoxDefenseRoll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboBoxCaster);
            this.Controls.Add(this.chkBoxSecurity);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCastSpell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxSpellPower);
            this.Controls.Add(this.cboBoxSpells);
            this.Controls.Add(this.cboBoxChars);
            this.Name = "SpellCasting";
            this.Text = "SpellCasting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBoxChars;
        private System.Windows.Forms.ComboBox cboBoxSpells;
        private System.Windows.Forms.TextBox txtBoxSpellPower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCastSpell;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox chkBoxSecurity;
        private System.Windows.Forms.ComboBox cboBoxCaster;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxDefenseRoll;
    }
}