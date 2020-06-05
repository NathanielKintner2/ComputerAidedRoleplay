namespace Second_Attempt
{
    partial class ShieldCreator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxOffensiveMod = new System.Windows.Forms.TextBox();
            this.txtBoxDefensiveMod = new System.Windows.Forms.TextBox();
            this.txtBoxShieldWeight = new System.Windows.Forms.TextBox();
            this.txtBoxCoverage = new System.Windows.Forms.TextBox();
            this.cboBoxShields = new System.Windows.Forms.ComboBox();
            this.rtbShieldDescription = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGoogle = new System.Windows.Forms.Button();
            this.richTextBoxTechnical = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Offensive Mod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Defensive Mod";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Coverage";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(179, 44);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxName.TabIndex = 1;
            // 
            // txtBoxOffensiveMod
            // 
            this.txtBoxOffensiveMod.Location = new System.Drawing.Point(179, 75);
            this.txtBoxOffensiveMod.Name = "txtBoxOffensiveMod";
            this.txtBoxOffensiveMod.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOffensiveMod.TabIndex = 2;
            // 
            // txtBoxDefensiveMod
            // 
            this.txtBoxDefensiveMod.Location = new System.Drawing.Point(179, 104);
            this.txtBoxDefensiveMod.Name = "txtBoxDefensiveMod";
            this.txtBoxDefensiveMod.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDefensiveMod.TabIndex = 3;
            // 
            // txtBoxShieldWeight
            // 
            this.txtBoxShieldWeight.Location = new System.Drawing.Point(179, 134);
            this.txtBoxShieldWeight.Name = "txtBoxShieldWeight";
            this.txtBoxShieldWeight.Size = new System.Drawing.Size(100, 20);
            this.txtBoxShieldWeight.TabIndex = 4;
            // 
            // txtBoxCoverage
            // 
            this.txtBoxCoverage.Location = new System.Drawing.Point(179, 159);
            this.txtBoxCoverage.Name = "txtBoxCoverage";
            this.txtBoxCoverage.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCoverage.TabIndex = 5;
            // 
            // cboBoxShields
            // 
            this.cboBoxShields.FormattingEnabled = true;
            this.cboBoxShields.Location = new System.Drawing.Point(303, 44);
            this.cboBoxShields.Name = "cboBoxShields";
            this.cboBoxShields.Size = new System.Drawing.Size(121, 21);
            this.cboBoxShields.TabIndex = 7;
            this.cboBoxShields.SelectedIndexChanged += new System.EventHandler(this.cboBoxShields_SelectedIndexChanged);
            // 
            // rtbShieldDescription
            // 
            this.rtbShieldDescription.Location = new System.Drawing.Point(303, 75);
            this.rtbShieldDescription.Name = "rtbShieldDescription";
            this.rtbShieldDescription.Size = new System.Drawing.Size(121, 96);
            this.rtbShieldDescription.TabIndex = 6;
            this.rtbShieldDescription.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(548, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // btnGoogle
            // 
            this.btnGoogle.Location = new System.Drawing.Point(461, 12);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(75, 36);
            this.btnGoogle.TabIndex = 14;
            this.btnGoogle.Text = "Write All To Google";
            this.btnGoogle.UseVisualStyleBackColor = true;
            // 
            // richTextBoxTechnical
            // 
            this.richTextBoxTechnical.Location = new System.Drawing.Point(303, 177);
            this.richTextBoxTechnical.Name = "richTextBoxTechnical";
            this.richTextBoxTechnical.Size = new System.Drawing.Size(121, 109);
            this.richTextBoxTechnical.TabIndex = 15;
            this.richTextBoxTechnical.Text = "";
            // 
            // ShieldCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 363);
            this.Controls.Add(this.richTextBoxTechnical);
            this.Controls.Add(this.btnGoogle);
            this.Controls.Add(this.rtbShieldDescription);
            this.Controls.Add(this.cboBoxShields);
            this.Controls.Add(this.txtBoxCoverage);
            this.Controls.Add(this.txtBoxShieldWeight);
            this.Controls.Add(this.txtBoxDefensiveMod);
            this.Controls.Add(this.txtBoxOffensiveMod);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ShieldCreator";
            this.Text = "ShieldCreator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxOffensiveMod;
        private System.Windows.Forms.TextBox txtBoxDefensiveMod;
        private System.Windows.Forms.TextBox txtBoxShieldWeight;
        private System.Windows.Forms.TextBox txtBoxCoverage;
        private System.Windows.Forms.ComboBox cboBoxShields;
        private System.Windows.Forms.RichTextBox rtbShieldDescription;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Button btnGoogle;
        private System.Windows.Forms.RichTextBox richTextBoxTechnical;
    }
}