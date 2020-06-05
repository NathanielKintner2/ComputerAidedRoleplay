namespace Second_Attempt.EnchantmentLogic
{
    partial class MakeAttackForm
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
            this.comboBoxDefender = new System.Windows.Forms.ComboBox();
            this.comboBoxAttacker = new System.Windows.Forms.ComboBox();
            this.comboBoxAttackerCalc = new System.Windows.Forms.ComboBox();
            this.comboBoxDefenderCalc = new System.Windows.Forms.ComboBox();
            this.comboBoxWeapon = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // checkBoxChangeable
            // 
            this.checkBoxChangeable.AutoSize = true;
            this.checkBoxChangeable.Location = new System.Drawing.Point(12, 137);
            this.checkBoxChangeable.Name = "checkBoxChangeable";
            this.checkBoxChangeable.Size = new System.Drawing.Size(110, 17);
            this.checkBoxChangeable.TabIndex = 23;
            this.checkBoxChangeable.Text = "Type Changeable";
            this.checkBoxChangeable.UseVisualStyleBackColor = true;
            // 
            // buttonChangeRight
            // 
            this.buttonChangeRight.Location = new System.Drawing.Point(151, 66);
            this.buttonChangeRight.Name = "buttonChangeRight";
            this.buttonChangeRight.Size = new System.Drawing.Size(121, 23);
            this.buttonChangeRight.TabIndex = 22;
            this.buttonChangeRight.Text = "Change Def Val";
            this.buttonChangeRight.UseVisualStyleBackColor = true;
            this.buttonChangeRight.Click += new System.EventHandler(this.buttonChangeRight_Click);
            // 
            // buttonChangeLeft
            // 
            this.buttonChangeLeft.Location = new System.Drawing.Point(12, 67);
            this.buttonChangeLeft.Name = "buttonChangeLeft";
            this.buttonChangeLeft.Size = new System.Drawing.Size(121, 23);
            this.buttonChangeLeft.TabIndex = 21;
            this.buttonChangeLeft.Text = "Change Attack Val";
            this.buttonChangeLeft.UseVisualStyleBackColor = true;
            this.buttonChangeLeft.Click += new System.EventHandler(this.buttonChangeLeft_Click);
            // 
            // labelRight
            // 
            this.labelRight.AutoSize = true;
            this.labelRight.Location = new System.Drawing.Point(151, 93);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(35, 13);
            this.labelRight.TabIndex = 20;
            this.labelRight.Text = "label3";
            // 
            // labelLeft
            // 
            this.labelLeft.AutoSize = true;
            this.labelLeft.Location = new System.Drawing.Point(12, 93);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(35, 13);
            this.labelLeft.TabIndex = 19;
            this.labelLeft.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "=";
            // 
            // comboBoxDefender
            // 
            this.comboBoxDefender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDefender.FormattingEnabled = true;
            this.comboBoxDefender.Location = new System.Drawing.Point(151, 12);
            this.comboBoxDefender.Name = "comboBoxDefender";
            this.comboBoxDefender.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDefender.TabIndex = 17;
            this.comboBoxDefender.SelectedIndexChanged += new System.EventHandler(this.comboBoxDefender_SelectedIndexChanged);
            // 
            // comboBoxAttacker
            // 
            this.comboBoxAttacker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAttacker.FormattingEnabled = true;
            this.comboBoxAttacker.Location = new System.Drawing.Point(12, 12);
            this.comboBoxAttacker.Name = "comboBoxAttacker";
            this.comboBoxAttacker.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAttacker.TabIndex = 16;
            this.comboBoxAttacker.SelectedIndexChanged += new System.EventHandler(this.comboBoxAttacker_SelectedIndexChanged);
            // 
            // comboBoxAttackerCalc
            // 
            this.comboBoxAttackerCalc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAttackerCalc.FormattingEnabled = true;
            this.comboBoxAttackerCalc.Location = new System.Drawing.Point(12, 39);
            this.comboBoxAttackerCalc.Name = "comboBoxAttackerCalc";
            this.comboBoxAttackerCalc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAttackerCalc.TabIndex = 24;
            // 
            // comboBoxDefenderCalc
            // 
            this.comboBoxDefenderCalc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDefenderCalc.FormattingEnabled = true;
            this.comboBoxDefenderCalc.Location = new System.Drawing.Point(151, 39);
            this.comboBoxDefenderCalc.Name = "comboBoxDefenderCalc";
            this.comboBoxDefenderCalc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDefenderCalc.TabIndex = 25;
            // 
            // comboBoxWeapon
            // 
            this.comboBoxWeapon.FormattingEnabled = true;
            this.comboBoxWeapon.Location = new System.Drawing.Point(12, 110);
            this.comboBoxWeapon.Name = "comboBoxWeapon";
            this.comboBoxWeapon.Size = new System.Drawing.Size(121, 21);
            this.comboBoxWeapon.TabIndex = 26;
            this.comboBoxWeapon.SelectedIndexChanged += new System.EventHandler(this.comboBoxWeapon_SelectedIndexChanged);
            this.comboBoxWeapon.TextUpdate += new System.EventHandler(this.comboBoxWeapon_TextUpdate);
            // 
            // MakeAttackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 161);
            this.Controls.Add(this.comboBoxWeapon);
            this.Controls.Add(this.comboBoxDefenderCalc);
            this.Controls.Add(this.comboBoxAttackerCalc);
            this.Controls.Add(this.checkBoxChangeable);
            this.Controls.Add(this.buttonChangeRight);
            this.Controls.Add(this.buttonChangeLeft);
            this.Controls.Add(this.labelRight);
            this.Controls.Add(this.labelLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDefender);
            this.Controls.Add(this.comboBoxAttacker);
            this.Name = "MakeAttackForm";
            this.Text = "MakeAttackForm";
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
        private System.Windows.Forms.ComboBox comboBoxDefender;
        private System.Windows.Forms.ComboBox comboBoxAttacker;
        private System.Windows.Forms.ComboBox comboBoxAttackerCalc;
        private System.Windows.Forms.ComboBox comboBoxDefenderCalc;
        private System.Windows.Forms.ComboBox comboBoxWeapon;
    }
}