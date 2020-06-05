namespace Second_Attempt.EnchantmentLogic
{
    partial class ReturnValueForm
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
            this.checkBoxChangeable = new System.Windows.Forms.CheckBox();
            this.buttonChangeLeft = new System.Windows.Forms.Button();
            this.labelValue = new System.Windows.Forms.Label();
            this.comboBoxValue = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // checkBoxChangeable
            // 
            this.checkBoxChangeable.AutoSize = true;
            this.checkBoxChangeable.Location = new System.Drawing.Point(12, 85);
            this.checkBoxChangeable.Name = "checkBoxChangeable";
            this.checkBoxChangeable.Size = new System.Drawing.Size(110, 17);
            this.checkBoxChangeable.TabIndex = 19;
            this.checkBoxChangeable.Text = "Type Changeable";
            this.checkBoxChangeable.UseVisualStyleBackColor = true;
            // 
            // buttonChangeLeft
            // 
            this.buttonChangeLeft.Location = new System.Drawing.Point(12, 40);
            this.buttonChangeLeft.Name = "buttonChangeLeft";
            this.buttonChangeLeft.Size = new System.Drawing.Size(121, 23);
            this.buttonChangeLeft.TabIndex = 18;
            this.buttonChangeLeft.Text = "Change/Edit";
            this.buttonChangeLeft.UseVisualStyleBackColor = true;
            this.buttonChangeLeft.Click += new System.EventHandler(this.buttonChangeValue_Click);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(13, 69);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(35, 13);
            this.labelValue.TabIndex = 17;
            this.labelValue.Text = "label2";
            // 
            // comboBoxValue
            // 
            this.comboBoxValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxValue.FormattingEnabled = true;
            this.comboBoxValue.Location = new System.Drawing.Point(12, 12);
            this.comboBoxValue.Name = "comboBoxValue";
            this.comboBoxValue.Size = new System.Drawing.Size(121, 21);
            this.comboBoxValue.TabIndex = 16;
            // 
            // ReturnValueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(145, 112);
            this.Controls.Add(this.checkBoxChangeable);
            this.Controls.Add(this.buttonChangeLeft);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.comboBoxValue);
            this.Name = "ReturnValueForm";
            this.Text = "ReturnValueForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxChangeable;
        private System.Windows.Forms.Button buttonChangeLeft;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.ComboBox comboBoxValue;
    }
}