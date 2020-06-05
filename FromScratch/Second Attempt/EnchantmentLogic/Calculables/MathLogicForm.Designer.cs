namespace Second_Attempt.EnchantmentLogic
{
    partial class MathLogicForm
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
            this.buttonChangeRight = new System.Windows.Forms.Button();
            this.buttonChangeLeft = new System.Windows.Forms.Button();
            this.labelRight = new System.Windows.Forms.Label();
            this.labelLeft = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRight = new System.Windows.Forms.ComboBox();
            this.comboBoxLeft = new System.Windows.Forms.ComboBox();
            this.comboBoxMathTypes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // checkBoxChangeable
            // 
            this.checkBoxChangeable.AutoSize = true;
            this.checkBoxChangeable.Location = new System.Drawing.Point(12, 85);
            this.checkBoxChangeable.Name = "checkBoxChangeable";
            this.checkBoxChangeable.Size = new System.Drawing.Size(110, 17);
            this.checkBoxChangeable.TabIndex = 15;
            this.checkBoxChangeable.Text = "Type Changeable";
            this.checkBoxChangeable.UseVisualStyleBackColor = true;
            // 
            // buttonChangeRight
            // 
            this.buttonChangeRight.Location = new System.Drawing.Point(266, 39);
            this.buttonChangeRight.Name = "buttonChangeRight";
            this.buttonChangeRight.Size = new System.Drawing.Size(121, 23);
            this.buttonChangeRight.TabIndex = 14;
            this.buttonChangeRight.Text = "Change/Edit Right";
            this.buttonChangeRight.UseVisualStyleBackColor = true;
            this.buttonChangeRight.Click += new System.EventHandler(this.buttonChangeRight_Click);
            // 
            // buttonChangeLeft
            // 
            this.buttonChangeLeft.Location = new System.Drawing.Point(12, 40);
            this.buttonChangeLeft.Name = "buttonChangeLeft";
            this.buttonChangeLeft.Size = new System.Drawing.Size(121, 23);
            this.buttonChangeLeft.TabIndex = 13;
            this.buttonChangeLeft.Text = "Change/Edit Left";
            this.buttonChangeLeft.UseVisualStyleBackColor = true;
            this.buttonChangeLeft.Click += new System.EventHandler(this.buttonChangeLeft_Click);
            // 
            // labelRight
            // 
            this.labelRight.AutoSize = true;
            this.labelRight.Location = new System.Drawing.Point(267, 69);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(35, 13);
            this.labelRight.TabIndex = 12;
            this.labelRight.Text = "label3";
            // 
            // labelLeft
            // 
            this.labelLeft.AutoSize = true;
            this.labelLeft.Location = new System.Drawing.Point(13, 69);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(35, 13);
            this.labelLeft.TabIndex = 11;
            this.labelLeft.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "+";
            // 
            // comboBoxRight
            // 
            this.comboBoxRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRight.FormattingEnabled = true;
            this.comboBoxRight.Location = new System.Drawing.Point(266, 12);
            this.comboBoxRight.Name = "comboBoxRight";
            this.comboBoxRight.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRight.TabIndex = 9;
            // 
            // comboBoxLeft
            // 
            this.comboBoxLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLeft.FormattingEnabled = true;
            this.comboBoxLeft.Location = new System.Drawing.Point(12, 12);
            this.comboBoxLeft.Name = "comboBoxLeft";
            this.comboBoxLeft.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLeft.TabIndex = 8;
            // 
            // comboBoxMathTypes
            // 
            this.comboBoxMathTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMathTypes.FormattingEnabled = true;
            this.comboBoxMathTypes.Location = new System.Drawing.Point(139, 12);
            this.comboBoxMathTypes.Name = "comboBoxMathTypes";
            this.comboBoxMathTypes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMathTypes.TabIndex = 16;
            this.comboBoxMathTypes.SelectedIndexChanged += new System.EventHandler(this.comboBoxMathTypes_SelectedIndexChanged);
            // 
            // MathLogicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 109);
            this.Controls.Add(this.comboBoxMathTypes);
            this.Controls.Add(this.checkBoxChangeable);
            this.Controls.Add(this.buttonChangeRight);
            this.Controls.Add(this.buttonChangeLeft);
            this.Controls.Add(this.labelRight);
            this.Controls.Add(this.labelLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRight);
            this.Controls.Add(this.comboBoxLeft);
            this.Name = "MathLogicForm";
            this.Text = "MathLogicForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxChangeable;
        private System.Windows.Forms.Button buttonChangeRight;
        private System.Windows.Forms.Button buttonChangeLeft;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRight;
        private System.Windows.Forms.ComboBox comboBoxLeft;
        private System.Windows.Forms.ComboBox comboBoxMathTypes;
    }
}