namespace Second_Attempt
{
    partial class AttackChart
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxDoLocationCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxKO = new System.Windows.Forms.CheckBox();
            this.checkBoxTrauma = new System.Windows.Forms.CheckBox();
            this.checkBoxImpairment = new System.Windows.Forms.CheckBox();
            this.checkBoxDisorientation = new System.Windows.Forms.CheckBox();
            this.checkBoxBleed = new System.Windows.Forms.CheckBox();
            this.checkBoxHarm = new System.Windows.Forms.CheckBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.labelAttacker = new System.Windows.Forms.Label();
            this.labelDefender = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.labelDefender);
            this.panel1.Controls.Add(this.labelAttacker);
            this.panel1.Controls.Add(this.checkBoxDoLocationCheck);
            this.panel1.Controls.Add(this.checkBoxKO);
            this.panel1.Controls.Add(this.checkBoxTrauma);
            this.panel1.Controls.Add(this.checkBoxImpairment);
            this.panel1.Controls.Add(this.checkBoxDisorientation);
            this.panel1.Controls.Add(this.checkBoxBleed);
            this.panel1.Controls.Add(this.checkBoxHarm);
            this.panel1.Controls.Add(this.lblAverage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 333);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // checkBoxDoLocationCheck
            // 
            this.checkBoxDoLocationCheck.AutoSize = true;
            this.checkBoxDoLocationCheck.Location = new System.Drawing.Point(12, 59);
            this.checkBoxDoLocationCheck.Name = "checkBoxDoLocationCheck";
            this.checkBoxDoLocationCheck.Size = new System.Drawing.Size(84, 17);
            this.checkBoxDoLocationCheck.TabIndex = 7;
            this.checkBoxDoLocationCheck.Text = "TargetNoise";
            this.checkBoxDoLocationCheck.UseVisualStyleBackColor = true;
            this.checkBoxDoLocationCheck.CheckedChanged += new System.EventHandler(this.checkBoxDoLocationCheck_CheckedChanged);
            // 
            // checkBoxKO
            // 
            this.checkBoxKO.AutoSize = true;
            this.checkBoxKO.Location = new System.Drawing.Point(178, 36);
            this.checkBoxKO.Name = "checkBoxKO";
            this.checkBoxKO.Size = new System.Drawing.Size(41, 17);
            this.checkBoxKO.TabIndex = 6;
            this.checkBoxKO.Text = "KO";
            this.checkBoxKO.UseVisualStyleBackColor = true;
            this.checkBoxKO.CheckedChanged += new System.EventHandler(this.checkBoxKO_CheckedChanged);
            // 
            // checkBoxTrauma
            // 
            this.checkBoxTrauma.AutoSize = true;
            this.checkBoxTrauma.Location = new System.Drawing.Point(98, 36);
            this.checkBoxTrauma.Name = "checkBoxTrauma";
            this.checkBoxTrauma.Size = new System.Drawing.Size(62, 17);
            this.checkBoxTrauma.TabIndex = 5;
            this.checkBoxTrauma.Text = "Trauma";
            this.checkBoxTrauma.UseVisualStyleBackColor = true;
            this.checkBoxTrauma.CheckedChanged += new System.EventHandler(this.checkBoxTrauma_CheckedChanged);
            // 
            // checkBoxImpairment
            // 
            this.checkBoxImpairment.AutoSize = true;
            this.checkBoxImpairment.Location = new System.Drawing.Point(12, 36);
            this.checkBoxImpairment.Name = "checkBoxImpairment";
            this.checkBoxImpairment.Size = new System.Drawing.Size(77, 17);
            this.checkBoxImpairment.TabIndex = 4;
            this.checkBoxImpairment.Text = "Impairment";
            this.checkBoxImpairment.UseVisualStyleBackColor = true;
            this.checkBoxImpairment.CheckedChanged += new System.EventHandler(this.checkBoxImpairment_CheckedChanged);
            // 
            // checkBoxDisorientation
            // 
            this.checkBoxDisorientation.AutoSize = true;
            this.checkBoxDisorientation.Location = new System.Drawing.Point(178, 12);
            this.checkBoxDisorientation.Name = "checkBoxDisorientation";
            this.checkBoxDisorientation.Size = new System.Drawing.Size(90, 17);
            this.checkBoxDisorientation.TabIndex = 3;
            this.checkBoxDisorientation.Text = "Disorientation";
            this.checkBoxDisorientation.UseVisualStyleBackColor = true;
            this.checkBoxDisorientation.CheckedChanged += new System.EventHandler(this.checkBoxDisorientation_CheckedChanged);
            // 
            // checkBoxBleed
            // 
            this.checkBoxBleed.AutoSize = true;
            this.checkBoxBleed.Location = new System.Drawing.Point(99, 13);
            this.checkBoxBleed.Name = "checkBoxBleed";
            this.checkBoxBleed.Size = new System.Drawing.Size(53, 17);
            this.checkBoxBleed.TabIndex = 2;
            this.checkBoxBleed.Text = "Bleed";
            this.checkBoxBleed.UseVisualStyleBackColor = true;
            this.checkBoxBleed.CheckedChanged += new System.EventHandler(this.checkBoxBleed_CheckedChanged);
            // 
            // checkBoxHarm
            // 
            this.checkBoxHarm.AutoSize = true;
            this.checkBoxHarm.Location = new System.Drawing.Point(13, 13);
            this.checkBoxHarm.Name = "checkBoxHarm";
            this.checkBoxHarm.Size = new System.Drawing.Size(51, 17);
            this.checkBoxHarm.TabIndex = 1;
            this.checkBoxHarm.Text = "Harm";
            this.checkBoxHarm.UseVisualStyleBackColor = true;
            this.checkBoxHarm.CheckedChanged += new System.EventHandler(this.checkBoxHarm_CheckedChanged);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(12, 311);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(35, 13);
            this.lblAverage.TabIndex = 0;
            this.lblAverage.Text = "label1";
            // 
            // labelAttacker
            // 
            this.labelAttacker.AutoSize = true;
            this.labelAttacker.Location = new System.Drawing.Point(102, 59);
            this.labelAttacker.Name = "labelAttacker";
            this.labelAttacker.Size = new System.Drawing.Size(35, 13);
            this.labelAttacker.TabIndex = 1;
            this.labelAttacker.Text = "label1";
            // 
            // labelDefender
            // 
            this.labelDefender.AutoSize = true;
            this.labelDefender.Location = new System.Drawing.Point(175, 59);
            this.labelDefender.Name = "labelDefender";
            this.labelDefender.Size = new System.Drawing.Size(35, 13);
            this.labelDefender.TabIndex = 8;
            this.labelDefender.Text = "label1";
            // 
            // AttackChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 333);
            this.Controls.Add(this.panel1);
            this.Name = "AttackChart";
            this.Text = "AttackChart";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.CheckBox checkBoxKO;
        private System.Windows.Forms.CheckBox checkBoxTrauma;
        private System.Windows.Forms.CheckBox checkBoxImpairment;
        private System.Windows.Forms.CheckBox checkBoxDisorientation;
        private System.Windows.Forms.CheckBox checkBoxBleed;
        private System.Windows.Forms.CheckBox checkBoxHarm;
        private System.Windows.Forms.CheckBox checkBoxDoLocationCheck;
        private System.Windows.Forms.Label labelDefender;
        private System.Windows.Forms.Label labelAttacker;
    }
}