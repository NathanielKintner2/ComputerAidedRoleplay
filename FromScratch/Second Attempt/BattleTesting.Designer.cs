namespace Second_Attempt
{
    partial class BattleTesting
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
            this.richTextBoxRight = new System.Windows.Forms.RichTextBox();
            this.richTextBoxLeft = new System.Windows.Forms.RichTextBox();
            this.comboBoxNames = new System.Windows.Forms.ComboBox();
            this.buttonAddLeftChar = new System.Windows.Forms.Button();
            this.buttonAddRightChar = new System.Windows.Forms.Button();
            this.buttonDoOneAttack = new System.Windows.Forms.Button();
            this.buttonFindAverageWinRate = new System.Windows.Forms.Button();
            this.buttonFinishCombat = new System.Windows.Forms.Button();
            this.richTextBoxBig = new System.Windows.Forms.RichTextBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxRight
            // 
            this.richTextBoxRight.Location = new System.Drawing.Point(139, 68);
            this.richTextBoxRight.Name = "richTextBoxRight";
            this.richTextBoxRight.Size = new System.Drawing.Size(121, 137);
            this.richTextBoxRight.TabIndex = 0;
            this.richTextBoxRight.Text = "";
            // 
            // richTextBoxLeft
            // 
            this.richTextBoxLeft.Location = new System.Drawing.Point(12, 68);
            this.richTextBoxLeft.Name = "richTextBoxLeft";
            this.richTextBoxLeft.Size = new System.Drawing.Size(121, 137);
            this.richTextBoxLeft.TabIndex = 1;
            this.richTextBoxLeft.Text = "";
            // 
            // comboBoxNames
            // 
            this.comboBoxNames.FormattingEnabled = true;
            this.comboBoxNames.Location = new System.Drawing.Point(12, 12);
            this.comboBoxNames.Name = "comboBoxNames";
            this.comboBoxNames.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNames.TabIndex = 2;
            // 
            // buttonAddLeftChar
            // 
            this.buttonAddLeftChar.Location = new System.Drawing.Point(12, 39);
            this.buttonAddLeftChar.Name = "buttonAddLeftChar";
            this.buttonAddLeftChar.Size = new System.Drawing.Size(121, 23);
            this.buttonAddLeftChar.TabIndex = 4;
            this.buttonAddLeftChar.Text = "AddLeftChar";
            this.buttonAddLeftChar.UseVisualStyleBackColor = true;
            this.buttonAddLeftChar.Click += new System.EventHandler(this.buttonAddLeftChar_Click);
            // 
            // buttonAddRightChar
            // 
            this.buttonAddRightChar.Location = new System.Drawing.Point(139, 39);
            this.buttonAddRightChar.Name = "buttonAddRightChar";
            this.buttonAddRightChar.Size = new System.Drawing.Size(121, 23);
            this.buttonAddRightChar.TabIndex = 5;
            this.buttonAddRightChar.Text = "AddRightChar";
            this.buttonAddRightChar.UseVisualStyleBackColor = true;
            this.buttonAddRightChar.Click += new System.EventHandler(this.buttonAddRightChar_Click);
            // 
            // buttonDoOneAttack
            // 
            this.buttonDoOneAttack.Location = new System.Drawing.Point(12, 222);
            this.buttonDoOneAttack.Name = "buttonDoOneAttack";
            this.buttonDoOneAttack.Size = new System.Drawing.Size(75, 23);
            this.buttonDoOneAttack.TabIndex = 6;
            this.buttonDoOneAttack.Text = "OneAttack";
            this.buttonDoOneAttack.UseVisualStyleBackColor = true;
            this.buttonDoOneAttack.Click += new System.EventHandler(this.buttonDoOneAttack_Click);
            // 
            // buttonFindAverageWinRate
            // 
            this.buttonFindAverageWinRate.Location = new System.Drawing.Point(13, 252);
            this.buttonFindAverageWinRate.Name = "buttonFindAverageWinRate";
            this.buttonFindAverageWinRate.Size = new System.Drawing.Size(75, 23);
            this.buttonFindAverageWinRate.TabIndex = 7;
            this.buttonFindAverageWinRate.Text = "FindAverage";
            this.buttonFindAverageWinRate.UseVisualStyleBackColor = true;
            this.buttonFindAverageWinRate.Click += new System.EventHandler(this.buttonFindAverageWinRate_Click);
            // 
            // buttonFinishCombat
            // 
            this.buttonFinishCombat.Location = new System.Drawing.Point(12, 282);
            this.buttonFinishCombat.Name = "buttonFinishCombat";
            this.buttonFinishCombat.Size = new System.Drawing.Size(75, 23);
            this.buttonFinishCombat.TabIndex = 8;
            this.buttonFinishCombat.Text = "FinishCombat";
            this.buttonFinishCombat.UseVisualStyleBackColor = true;
            this.buttonFinishCombat.Click += new System.EventHandler(this.buttonFinishCombat_Click);
            // 
            // richTextBoxBig
            // 
            this.richTextBoxBig.Location = new System.Drawing.Point(267, 13);
            this.richTextBoxBig.Name = "richTextBoxBig";
            this.richTextBoxBig.Size = new System.Drawing.Size(438, 326);
            this.richTextBoxBig.TabIndex = 9;
            this.richTextBoxBig.Text = "";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(129, 252);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(50, 13);
            this.lblAverage.TabIndex = 10;
            this.lblAverage.Text = "Average:";
            // 
            // BattleTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 351);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.richTextBoxBig);
            this.Controls.Add(this.buttonFinishCombat);
            this.Controls.Add(this.buttonFindAverageWinRate);
            this.Controls.Add(this.buttonDoOneAttack);
            this.Controls.Add(this.buttonAddRightChar);
            this.Controls.Add(this.buttonAddLeftChar);
            this.Controls.Add(this.comboBoxNames);
            this.Controls.Add(this.richTextBoxLeft);
            this.Controls.Add(this.richTextBoxRight);
            this.Name = "BattleTesting";
            this.Text = "BattleTesting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxRight;
        private System.Windows.Forms.RichTextBox richTextBoxLeft;
        private System.Windows.Forms.ComboBox comboBoxNames;
        private System.Windows.Forms.Button buttonAddLeftChar;
        private System.Windows.Forms.Button buttonAddRightChar;
        private System.Windows.Forms.Button buttonDoOneAttack;
        private System.Windows.Forms.Button buttonFindAverageWinRate;
        private System.Windows.Forms.Button buttonFinishCombat;
        private System.Windows.Forms.RichTextBox richTextBoxBig;
        private System.Windows.Forms.Label lblAverage;
    }
}