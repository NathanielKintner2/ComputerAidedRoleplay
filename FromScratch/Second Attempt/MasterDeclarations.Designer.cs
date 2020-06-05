namespace Second_Attempt
{
    partial class MasterDeclarations
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
            this.btnRunAttacks = new System.Windows.Forms.Button();
            this.rtbAttackingChars = new System.Windows.Forms.RichTextBox();
            this.cboBoxName = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnInternet = new System.Windows.Forms.Button();
            this.btnInternetWrite = new System.Windows.Forms.Button();
            this.rtbSpellcastingChars = new System.Windows.Forms.RichTextBox();
            this.btnRunSpells = new System.Windows.Forms.Button();
            this.rtbCharsWithNotes = new System.Windows.Forms.RichTextBox();
            this.textBoxRoundsToJump = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Declaration";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRunAttacks
            // 
            this.btnRunAttacks.Location = new System.Drawing.Point(12, 80);
            this.btnRunAttacks.Name = "btnRunAttacks";
            this.btnRunAttacks.Size = new System.Drawing.Size(75, 23);
            this.btnRunAttacks.TabIndex = 1;
            this.btnRunAttacks.Text = "Run Attacks";
            this.btnRunAttacks.UseVisualStyleBackColor = true;
            this.btnRunAttacks.Click += new System.EventHandler(this.button2_Click);
            // 
            // rtbAttackingChars
            // 
            this.rtbAttackingChars.Location = new System.Drawing.Point(182, 12);
            this.rtbAttackingChars.Name = "rtbAttackingChars";
            this.rtbAttackingChars.Size = new System.Drawing.Size(272, 248);
            this.rtbAttackingChars.TabIndex = 2;
            this.rtbAttackingChars.Text = "";
            // 
            // cboBoxName
            // 
            this.cboBoxName.FormattingEnabled = true;
            this.cboBoxName.Location = new System.Drawing.Point(15, 12);
            this.cboBoxName.Name = "cboBoxName";
            this.cboBoxName.Size = new System.Drawing.Size(121, 21);
            this.cboBoxName.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 42);
            this.button3.TabIndex = 4;
            this.button3.Text = "Next Round";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnInternet
            // 
            this.btnInternet.Location = new System.Drawing.Point(11, 141);
            this.btnInternet.Name = "btnInternet";
            this.btnInternet.Size = new System.Drawing.Size(75, 37);
            this.btnInternet.TabIndex = 5;
            this.btnInternet.Text = "GetInternetData";
            this.btnInternet.UseVisualStyleBackColor = true;
            this.btnInternet.Click += new System.EventHandler(this.btnInternet_Click);
            // 
            // btnInternetWrite
            // 
            this.btnInternetWrite.Location = new System.Drawing.Point(12, 185);
            this.btnInternetWrite.Name = "btnInternetWrite";
            this.btnInternetWrite.Size = new System.Drawing.Size(75, 38);
            this.btnInternetWrite.TabIndex = 6;
            this.btnInternetWrite.Text = "Write To Internet";
            this.btnInternetWrite.UseVisualStyleBackColor = true;
            this.btnInternetWrite.Click += new System.EventHandler(this.btnInternetWrite_Click);
            // 
            // rtbSpellcastingChars
            // 
            this.rtbSpellcastingChars.Location = new System.Drawing.Point(460, 12);
            this.rtbSpellcastingChars.Name = "rtbSpellcastingChars";
            this.rtbSpellcastingChars.Size = new System.Drawing.Size(270, 248);
            this.rtbSpellcastingChars.TabIndex = 7;
            this.rtbSpellcastingChars.Text = "";
            // 
            // btnRunSpells
            // 
            this.btnRunSpells.Location = new System.Drawing.Point(12, 109);
            this.btnRunSpells.Name = "btnRunSpells";
            this.btnRunSpells.Size = new System.Drawing.Size(75, 23);
            this.btnRunSpells.TabIndex = 8;
            this.btnRunSpells.Text = "Run Spells";
            this.btnRunSpells.UseVisualStyleBackColor = true;
            this.btnRunSpells.Click += new System.EventHandler(this.btnRunSpells_Click);
            // 
            // rtbCharsWithNotes
            // 
            this.rtbCharsWithNotes.Location = new System.Drawing.Point(736, 12);
            this.rtbCharsWithNotes.Name = "rtbCharsWithNotes";
            this.rtbCharsWithNotes.Size = new System.Drawing.Size(129, 248);
            this.rtbCharsWithNotes.TabIndex = 9;
            this.rtbCharsWithNotes.Text = "";
            // 
            // textBoxRoundsToJump
            // 
            this.textBoxRoundsToJump.Location = new System.Drawing.Point(93, 240);
            this.textBoxRoundsToJump.Name = "textBoxRoundsToJump";
            this.textBoxRoundsToJump.Size = new System.Drawing.Size(82, 20);
            this.textBoxRoundsToJump.TabIndex = 10;
            // 
            // MasterDeclarations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 277);
            this.Controls.Add(this.textBoxRoundsToJump);
            this.Controls.Add(this.rtbCharsWithNotes);
            this.Controls.Add(this.btnRunSpells);
            this.Controls.Add(this.rtbSpellcastingChars);
            this.Controls.Add(this.btnInternetWrite);
            this.Controls.Add(this.btnInternet);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cboBoxName);
            this.Controls.Add(this.rtbAttackingChars);
            this.Controls.Add(this.btnRunAttacks);
            this.Controls.Add(this.button1);
            this.Name = "MasterDeclarations";
            this.Text = "MasterDeclarations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRunAttacks;
        private System.Windows.Forms.RichTextBox rtbAttackingChars;
        private System.Windows.Forms.ComboBox cboBoxName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnInternet;
        private System.Windows.Forms.Button btnInternetWrite;
        private System.Windows.Forms.RichTextBox rtbSpellcastingChars;
        private System.Windows.Forms.Button btnRunSpells;
        private System.Windows.Forms.RichTextBox rtbCharsWithNotes;
        private System.Windows.Forms.TextBox textBoxRoundsToJump;
    }
}