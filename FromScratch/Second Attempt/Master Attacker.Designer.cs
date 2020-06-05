namespace Second_Attempt
{
    partial class Master_Attacker
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
            this.FOLLOWTHETACO = new System.Windows.Forms.Button();
            this.cboBoxAttackers = new System.Windows.Forms.ComboBox();
            this.btnAddTarget = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FOLLOWTHETACO
            // 
            this.FOLLOWTHETACO.Location = new System.Drawing.Point(198, 51);
            this.FOLLOWTHETACO.Name = "FOLLOWTHETACO";
            this.FOLLOWTHETACO.Size = new System.Drawing.Size(75, 23);
            this.FOLLOWTHETACO.TabIndex = 0;
            this.FOLLOWTHETACO.Text = "GO";
            this.FOLLOWTHETACO.UseVisualStyleBackColor = true;
            this.FOLLOWTHETACO.Click += new System.EventHandler(this.FOLLOWTHETACO_Click);
            // 
            // cboBoxAttackers
            // 
            this.cboBoxAttackers.FormattingEnabled = true;
            this.cboBoxAttackers.Location = new System.Drawing.Point(13, 13);
            this.cboBoxAttackers.Name = "cboBoxAttackers";
            this.cboBoxAttackers.Size = new System.Drawing.Size(121, 21);
            this.cboBoxAttackers.TabIndex = 1;
            // 
            // btnAddTarget
            // 
            this.btnAddTarget.Location = new System.Drawing.Point(13, 41);
            this.btnAddTarget.Name = "btnAddTarget";
            this.btnAddTarget.Size = new System.Drawing.Size(75, 23);
            this.btnAddTarget.TabIndex = 2;
            this.btnAddTarget.Text = "Add Target";
            this.btnAddTarget.UseVisualStyleBackColor = true;
            this.btnAddTarget.Click += new System.EventHandler(this.btnAddTarget_Click);
            // 
            // Master_Attacker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 135);
            this.Controls.Add(this.btnAddTarget);
            this.Controls.Add(this.cboBoxAttackers);
            this.Controls.Add(this.FOLLOWTHETACO);
            this.Name = "Master_Attacker";
            this.Text = "Master_Attacker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FOLLOWTHETACO;
        private System.Windows.Forms.ComboBox cboBoxAttackers;
        private System.Windows.Forms.Button btnAddTarget;
    }
}