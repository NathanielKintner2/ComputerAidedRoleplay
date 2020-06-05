namespace Second_Attempt.EnchantmentLogic
{
    partial class CreateEffectForm
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
            this.comboBoxDeterioration = new System.Windows.Forms.ComboBox();
            this.comboBoxPotency = new System.Windows.Forms.ComboBox();
            this.comboBoxLength = new System.Windows.Forms.ComboBox();
            this.checkBoxChangeable = new System.Windows.Forms.CheckBox();
            this.comboBoxEffectType = new System.Windows.Forms.ComboBox();
            this.comboBoxTarget = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxDamageType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxEffectTag = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxDeterioration
            // 
            this.comboBoxDeterioration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeterioration.FormattingEnabled = true;
            this.comboBoxDeterioration.Location = new System.Drawing.Point(114, 169);
            this.comboBoxDeterioration.Name = "comboBoxDeterioration";
            this.comboBoxDeterioration.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDeterioration.TabIndex = 37;
            this.comboBoxDeterioration.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeterioration_SelectedIndexChanged);
            // 
            // comboBoxPotency
            // 
            this.comboBoxPotency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPotency.FormattingEnabled = true;
            this.comboBoxPotency.Location = new System.Drawing.Point(114, 115);
            this.comboBoxPotency.Name = "comboBoxPotency";
            this.comboBoxPotency.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPotency.TabIndex = 36;
            this.comboBoxPotency.SelectedIndexChanged += new System.EventHandler(this.comboBoxPotency_SelectedIndexChanged);
            // 
            // comboBoxLength
            // 
            this.comboBoxLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLength.FormattingEnabled = true;
            this.comboBoxLength.Location = new System.Drawing.Point(114, 142);
            this.comboBoxLength.Name = "comboBoxLength";
            this.comboBoxLength.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLength.TabIndex = 35;
            this.comboBoxLength.SelectedIndexChanged += new System.EventHandler(this.comboBoxLength_SelectedIndexChanged);
            // 
            // checkBoxChangeable
            // 
            this.checkBoxChangeable.AutoSize = true;
            this.checkBoxChangeable.Location = new System.Drawing.Point(114, 196);
            this.checkBoxChangeable.Name = "checkBoxChangeable";
            this.checkBoxChangeable.Size = new System.Drawing.Size(110, 17);
            this.checkBoxChangeable.TabIndex = 34;
            this.checkBoxChangeable.Text = "Type Changeable";
            this.checkBoxChangeable.UseVisualStyleBackColor = true;
            // 
            // comboBoxEffectType
            // 
            this.comboBoxEffectType.FormattingEnabled = true;
            this.comboBoxEffectType.Location = new System.Drawing.Point(114, 34);
            this.comboBoxEffectType.Name = "comboBoxEffectType";
            this.comboBoxEffectType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEffectType.TabIndex = 28;
            this.comboBoxEffectType.SelectedIndexChanged += new System.EventHandler(this.comboBoxEffectType_SelectedIndexChanged);
            this.comboBoxEffectType.TextUpdate += new System.EventHandler(this.comboBoxEffectType_TextUpdate);
            // 
            // comboBoxTarget
            // 
            this.comboBoxTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTarget.FormattingEnabled = true;
            this.comboBoxTarget.Location = new System.Drawing.Point(114, 7);
            this.comboBoxTarget.Name = "comboBoxTarget";
            this.comboBoxTarget.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTarget.TabIndex = 27;
            this.comboBoxTarget.SelectedIndexChanged += new System.EventHandler(this.comboBoxTarget_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Target";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "EffectType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Potency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Deterioration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "DamageType";
            // 
            // comboBoxDamageType
            // 
            this.comboBoxDamageType.FormattingEnabled = true;
            this.comboBoxDamageType.Location = new System.Drawing.Point(114, 88);
            this.comboBoxDamageType.Name = "comboBoxDamageType";
            this.comboBoxDamageType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDamageType.TabIndex = 43;
            this.comboBoxDamageType.SelectedIndexChanged += new System.EventHandler(this.comboBoxDamageType_SelectedIndexChanged);
            this.comboBoxDamageType.TextUpdate += new System.EventHandler(this.comboBoxDamageType_TextUpdate);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "EffectTag";
            // 
            // comboBoxEffectTag
            // 
            this.comboBoxEffectTag.FormattingEnabled = true;
            this.comboBoxEffectTag.Location = new System.Drawing.Point(114, 61);
            this.comboBoxEffectTag.Name = "comboBoxEffectTag";
            this.comboBoxEffectTag.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEffectTag.TabIndex = 45;
            this.comboBoxEffectTag.SelectedIndexChanged += new System.EventHandler(this.comboBoxEffectTag_SelectedIndexChanged);
            this.comboBoxEffectTag.TextUpdate += new System.EventHandler(this.comboBoxEffectTag_TextUpdate);
            // 
            // CreateEffectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 219);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxEffectTag);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxDamageType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDeterioration);
            this.Controls.Add(this.comboBoxPotency);
            this.Controls.Add(this.comboBoxLength);
            this.Controls.Add(this.checkBoxChangeable);
            this.Controls.Add(this.comboBoxEffectType);
            this.Controls.Add(this.comboBoxTarget);
            this.Name = "CreateEffectForm";
            this.Text = "CreateEffectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDeterioration;
        private System.Windows.Forms.ComboBox comboBoxPotency;
        private System.Windows.Forms.ComboBox comboBoxLength;
        private System.Windows.Forms.CheckBox checkBoxChangeable;
        private System.Windows.Forms.ComboBox comboBoxEffectType;
        private System.Windows.Forms.ComboBox comboBoxTarget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxDamageType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxEffectTag;
    }
}