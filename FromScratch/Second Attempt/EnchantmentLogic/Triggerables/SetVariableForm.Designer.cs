namespace Second_Attempt.EnchantmentLogic
{
    partial class SetVariableForm
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
            this.comboBoxVariables = new System.Windows.Forms.ComboBox();
            this.comboBoxCalculables = new System.Windows.Forms.ComboBox();
            this.buttonChangeOrEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxChangeable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBoxVariables
            // 
            this.comboBoxVariables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVariables.FormattingEnabled = true;
            this.comboBoxVariables.Location = new System.Drawing.Point(12, 12);
            this.comboBoxVariables.Name = "comboBoxVariables";
            this.comboBoxVariables.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVariables.TabIndex = 0;
            this.comboBoxVariables.SelectedIndexChanged += new System.EventHandler(this.comboBoxVariables_SelectedIndexChanged);
            // 
            // comboBoxCalculables
            // 
            this.comboBoxCalculables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCalculables.FormattingEnabled = true;
            this.comboBoxCalculables.Location = new System.Drawing.Point(151, 12);
            this.comboBoxCalculables.Name = "comboBoxCalculables";
            this.comboBoxCalculables.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCalculables.TabIndex = 1;
            // 
            // buttonChangeOrEdit
            // 
            this.buttonChangeOrEdit.Location = new System.Drawing.Point(151, 39);
            this.buttonChangeOrEdit.Name = "buttonChangeOrEdit";
            this.buttonChangeOrEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeOrEdit.TabIndex = 2;
            this.buttonChangeOrEdit.Text = "Change/Edit";
            this.buttonChangeOrEdit.UseVisualStyleBackColor = true;
            this.buttonChangeOrEdit.Click += new System.EventHandler(this.buttonChangeOrEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // checkBoxChangeable
            // 
            this.checkBoxChangeable.AutoSize = true;
            this.checkBoxChangeable.Location = new System.Drawing.Point(12, 39);
            this.checkBoxChangeable.Name = "checkBoxChangeable";
            this.checkBoxChangeable.Size = new System.Drawing.Size(91, 17);
            this.checkBoxChangeable.TabIndex = 4;
            this.checkBoxChangeable.Text = "Allow Change";
            this.checkBoxChangeable.UseVisualStyleBackColor = true;
            // 
            // SetVariableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 96);
            this.Controls.Add(this.checkBoxChangeable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChangeOrEdit);
            this.Controls.Add(this.comboBoxCalculables);
            this.Controls.Add(this.comboBoxVariables);
            this.Name = "SetVariableForm";
            this.Text = "SetVariableForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxVariables;
        private System.Windows.Forms.ComboBox comboBoxCalculables;
        private System.Windows.Forms.Button buttonChangeOrEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxChangeable;
    }
}