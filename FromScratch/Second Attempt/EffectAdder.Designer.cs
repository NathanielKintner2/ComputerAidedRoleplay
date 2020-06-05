namespace Second_Attempt
{
    partial class EffectAdder
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
            this.cboBoxName = new System.Windows.Forms.ComboBox();
            this.cboBoxEffect = new System.Windows.Forms.ComboBox();
            this.txtBoxStrength = new System.Windows.Forms.TextBox();
            this.txtBoxLength = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbActiveEffects = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxDeterioration = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ckBoxPermanent = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboBoxTag = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboBoxDamageType = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxEffectableTypes = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboBoxName
            // 
            this.cboBoxName.FormattingEnabled = true;
            this.cboBoxName.Location = new System.Drawing.Point(118, 33);
            this.cboBoxName.Name = "cboBoxName";
            this.cboBoxName.Size = new System.Drawing.Size(121, 21);
            this.cboBoxName.TabIndex = 0;
            this.cboBoxName.SelectedIndexChanged += new System.EventHandler(this.cboBoxName_SelectedIndexChanged);
            // 
            // cboBoxEffect
            // 
            this.cboBoxEffect.FormattingEnabled = true;
            this.cboBoxEffect.Location = new System.Drawing.Point(117, 60);
            this.cboBoxEffect.Name = "cboBoxEffect";
            this.cboBoxEffect.Size = new System.Drawing.Size(121, 21);
            this.cboBoxEffect.TabIndex = 1;
            // 
            // txtBoxStrength
            // 
            this.txtBoxStrength.Location = new System.Drawing.Point(118, 144);
            this.txtBoxStrength.Name = "txtBoxStrength";
            this.txtBoxStrength.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStrength.TabIndex = 2;
            // 
            // txtBoxLength
            // 
            this.txtBoxLength.Location = new System.Drawing.Point(118, 170);
            this.txtBoxLength.Name = "txtBoxLength";
            this.txtBoxLength.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLength.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Effect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clear Effect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name of Target";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Effect";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Potency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Length in rounds";
            // 
            // rtbActiveEffects
            // 
            this.rtbActiveEffects.Location = new System.Drawing.Point(312, 43);
            this.rtbActiveEffects.Name = "rtbActiveEffects";
            this.rtbActiveEffects.Size = new System.Drawing.Size(262, 217);
            this.rtbActiveEffects.TabIndex = 10;
            this.rtbActiveEffects.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Deterioration";
            // 
            // txtBoxDeterioration
            // 
            this.txtBoxDeterioration.Location = new System.Drawing.Point(118, 197);
            this.txtBoxDeterioration.Name = "txtBoxDeterioration";
            this.txtBoxDeterioration.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDeterioration.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(499, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Update Effects";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ckBoxPermanent
            // 
            this.ckBoxPermanent.AutoSize = true;
            this.ckBoxPermanent.Location = new System.Drawing.Point(117, 223);
            this.ckBoxPermanent.Name = "ckBoxPermanent";
            this.ckBoxPermanent.Size = new System.Drawing.Size(77, 17);
            this.ckBoxPermanent.TabIndex = 14;
            this.ckBoxPermanent.Text = "Permanent";
            this.ckBoxPermanent.UseVisualStyleBackColor = true;
            this.ckBoxPermanent.CheckedChanged += new System.EventHandler(this.ckBoxPermanent_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tag";
            // 
            // cboBoxTag
            // 
            this.cboBoxTag.FormattingEnabled = true;
            this.cboBoxTag.Location = new System.Drawing.Point(117, 87);
            this.cboBoxTag.Name = "cboBoxTag";
            this.cboBoxTag.Size = new System.Drawing.Size(121, 21);
            this.cboBoxTag.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Damage Type";
            // 
            // cboBoxDamageType
            // 
            this.cboBoxDamageType.FormattingEnabled = true;
            this.cboBoxDamageType.Location = new System.Drawing.Point(118, 114);
            this.cboBoxDamageType.Name = "cboBoxDamageType";
            this.cboBoxDamageType.Size = new System.Drawing.Size(121, 21);
            this.cboBoxDamageType.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(352, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Select";
            // 
            // comboBoxEffectableTypes
            // 
            this.comboBoxEffectableTypes.FormattingEnabled = true;
            this.comboBoxEffectableTypes.Location = new System.Drawing.Point(117, 6);
            this.comboBoxEffectableTypes.Name = "comboBoxEffectableTypes";
            this.comboBoxEffectableTypes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEffectableTypes.TabIndex = 21;
            this.comboBoxEffectableTypes.SelectedIndexChanged += new System.EventHandler(this.comboBoxEffectableTypes_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Type of Target";
            // 
            // EffectAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 272);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxEffectableTypes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cboBoxDamageType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboBoxTag);
            this.Controls.Add(this.ckBoxPermanent);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtBoxDeterioration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbActiveEffects);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxLength);
            this.Controls.Add(this.txtBoxStrength);
            this.Controls.Add(this.cboBoxEffect);
            this.Controls.Add(this.cboBoxName);
            this.Name = "EffectAdder";
            this.Text = "EffectAdder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBoxName;
        private System.Windows.Forms.ComboBox cboBoxEffect;
        private System.Windows.Forms.TextBox txtBoxStrength;
        private System.Windows.Forms.TextBox txtBoxLength;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbActiveEffects;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxDeterioration;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox ckBoxPermanent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboBoxTag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboBoxDamageType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxEffectableTypes;
        private System.Windows.Forms.Label label9;
    }
}