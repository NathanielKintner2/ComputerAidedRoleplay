namespace Second_Attempt.EnchantmentLogic
{
    partial class GetVariableForm
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
            this.comboBoxVariables = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Variable Name";
            // 
            // comboBoxVariables
            // 
            this.comboBoxVariables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVariables.FormattingEnabled = true;
            this.comboBoxVariables.Location = new System.Drawing.Point(94, 26);
            this.comboBoxVariables.Name = "comboBoxVariables";
            this.comboBoxVariables.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVariables.TabIndex = 1;
            this.comboBoxVariables.SelectedIndexChanged += new System.EventHandler(this.comboBoxVariables_SelectedIndexChanged);
            // 
            // GetVariableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 72);
            this.Controls.Add(this.comboBoxVariables);
            this.Controls.Add(this.label1);
            this.Name = "GetVariableForm";
            this.Text = "GetVariableForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxVariables;
    }
}