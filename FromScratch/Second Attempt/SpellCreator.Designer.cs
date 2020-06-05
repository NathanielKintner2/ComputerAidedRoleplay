namespace Second_Attempt
{
    partial class SpellCreator
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
            this.btnSaveWeapon = new System.Windows.Forms.Button();
            this.btnSaveEff = new System.Windows.Forms.Button();
            this.cboBoxEffectType = new System.Windows.Forms.ComboBox();
            this.cboBoxWeapons = new System.Windows.Forms.ComboBox();
            this.txtBoxWeaponBonus = new System.Windows.Forms.TextBox();
            this.chkBoxPermanent = new System.Windows.Forms.CheckBox();
            this.txtBoxSpellName = new System.Windows.Forms.TextBox();
            this.cboBoxSpellName = new System.Windows.Forms.ComboBox();
            this.txtBoxPotency = new System.Windows.Forms.TextBox();
            this.txtBoxLength = new System.Windows.Forms.TextBox();
            this.txtBoxDeterioration = new System.Windows.Forms.TextBox();
            this.txtBoxPotencyMul = new System.Windows.Forms.TextBox();
            this.txtBoxLengthMul = new System.Windows.Forms.TextBox();
            this.txtBoxDeteriorationMul = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbEffects = new System.Windows.Forms.RichTextBox();
            this.rtbWeapons = new System.Windows.Forms.RichTextBox();
            this.btnDeleteEffect = new System.Windows.Forms.Button();
            this.btnDelWeapon = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboBoxEffectIndex = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxCost = new System.Windows.Forms.TextBox();
            this.cboBoxEffectTag = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxDamageType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save Spell";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSaveWeapon
            // 
            this.btnSaveWeapon.Location = new System.Drawing.Point(35, 294);
            this.btnSaveWeapon.Name = "btnSaveWeapon";
            this.btnSaveWeapon.Size = new System.Drawing.Size(75, 41);
            this.btnSaveWeapon.TabIndex = 1;
            this.btnSaveWeapon.Text = "Save Weapon";
            this.btnSaveWeapon.UseVisualStyleBackColor = true;
            this.btnSaveWeapon.Click += new System.EventHandler(this.btnSaveWeapon_Click);
            // 
            // btnSaveEff
            // 
            this.btnSaveEff.Location = new System.Drawing.Point(214, 206);
            this.btnSaveEff.Name = "btnSaveEff";
            this.btnSaveEff.Size = new System.Drawing.Size(75, 39);
            this.btnSaveEff.TabIndex = 2;
            this.btnSaveEff.Text = "Save Effect";
            this.btnSaveEff.UseVisualStyleBackColor = true;
            this.btnSaveEff.Click += new System.EventHandler(this.btnSaveEff_Click);
            // 
            // cboBoxEffectType
            // 
            this.cboBoxEffectType.FormattingEnabled = true;
            this.cboBoxEffectType.Location = new System.Drawing.Point(119, 12);
            this.cboBoxEffectType.Name = "cboBoxEffectType";
            this.cboBoxEffectType.Size = new System.Drawing.Size(121, 21);
            this.cboBoxEffectType.TabIndex = 3;
            // 
            // cboBoxWeapons
            // 
            this.cboBoxWeapons.FormattingEnabled = true;
            this.cboBoxWeapons.Location = new System.Drawing.Point(35, 267);
            this.cboBoxWeapons.Name = "cboBoxWeapons";
            this.cboBoxWeapons.Size = new System.Drawing.Size(121, 21);
            this.cboBoxWeapons.TabIndex = 4;
            // 
            // txtBoxWeaponBonus
            // 
            this.txtBoxWeaponBonus.Location = new System.Drawing.Point(206, 305);
            this.txtBoxWeaponBonus.Name = "txtBoxWeaponBonus";
            this.txtBoxWeaponBonus.Size = new System.Drawing.Size(100, 20);
            this.txtBoxWeaponBonus.TabIndex = 5;
            // 
            // chkBoxPermanent
            // 
            this.chkBoxPermanent.AutoSize = true;
            this.chkBoxPermanent.Location = new System.Drawing.Point(114, 187);
            this.chkBoxPermanent.Name = "chkBoxPermanent";
            this.chkBoxPermanent.Size = new System.Drawing.Size(94, 17);
            this.chkBoxPermanent.TabIndex = 7;
            this.chkBoxPermanent.Text = "Is Permanent?";
            this.chkBoxPermanent.UseVisualStyleBackColor = true;
            // 
            // txtBoxSpellName
            // 
            this.txtBoxSpellName.Location = new System.Drawing.Point(464, 13);
            this.txtBoxSpellName.Name = "txtBoxSpellName";
            this.txtBoxSpellName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSpellName.TabIndex = 8;
            // 
            // cboBoxSpellName
            // 
            this.cboBoxSpellName.FormattingEnabled = true;
            this.cboBoxSpellName.Location = new System.Drawing.Point(464, 39);
            this.cboBoxSpellName.Name = "cboBoxSpellName";
            this.cboBoxSpellName.Size = new System.Drawing.Size(121, 21);
            this.cboBoxSpellName.TabIndex = 9;
            this.cboBoxSpellName.SelectedIndexChanged += new System.EventHandler(this.cboBoxSpellName_SelectedIndexChanged);
            // 
            // txtBoxPotency
            // 
            this.txtBoxPotency.Location = new System.Drawing.Point(113, 109);
            this.txtBoxPotency.Name = "txtBoxPotency";
            this.txtBoxPotency.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPotency.TabIndex = 10;
            // 
            // txtBoxLength
            // 
            this.txtBoxLength.Location = new System.Drawing.Point(114, 135);
            this.txtBoxLength.Name = "txtBoxLength";
            this.txtBoxLength.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLength.TabIndex = 11;
            // 
            // txtBoxDeterioration
            // 
            this.txtBoxDeterioration.Location = new System.Drawing.Point(114, 161);
            this.txtBoxDeterioration.Name = "txtBoxDeterioration";
            this.txtBoxDeterioration.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDeterioration.TabIndex = 12;
            // 
            // txtBoxPotencyMul
            // 
            this.txtBoxPotencyMul.Location = new System.Drawing.Point(220, 109);
            this.txtBoxPotencyMul.Name = "txtBoxPotencyMul";
            this.txtBoxPotencyMul.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPotencyMul.TabIndex = 13;
            // 
            // txtBoxLengthMul
            // 
            this.txtBoxLengthMul.Location = new System.Drawing.Point(220, 135);
            this.txtBoxLengthMul.Name = "txtBoxLengthMul";
            this.txtBoxLengthMul.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLengthMul.TabIndex = 14;
            // 
            // txtBoxDeteriorationMul
            // 
            this.txtBoxDeteriorationMul.Location = new System.Drawing.Point(220, 161);
            this.txtBoxDeteriorationMul.Name = "txtBoxDeteriorationMul";
            this.txtBoxDeteriorationMul.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDeteriorationMul.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Potency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Length in Rounds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Deterioration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Base";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Bonus Mul.";
            // 
            // rtbEffects
            // 
            this.rtbEffects.Location = new System.Drawing.Point(376, 76);
            this.rtbEffects.Name = "rtbEffects";
            this.rtbEffects.Size = new System.Drawing.Size(305, 169);
            this.rtbEffects.TabIndex = 21;
            this.rtbEffects.Text = "";
            // 
            // rtbWeapons
            // 
            this.rtbWeapons.Location = new System.Drawing.Point(376, 251);
            this.rtbWeapons.Name = "rtbWeapons";
            this.rtbWeapons.Size = new System.Drawing.Size(305, 98);
            this.rtbWeapons.TabIndex = 22;
            this.rtbWeapons.Text = "";
            // 
            // btnDeleteEffect
            // 
            this.btnDeleteEffect.Location = new System.Drawing.Point(295, 206);
            this.btnDeleteEffect.Name = "btnDeleteEffect";
            this.btnDeleteEffect.Size = new System.Drawing.Size(75, 39);
            this.btnDeleteEffect.TabIndex = 23;
            this.btnDeleteEffect.Text = "Delete Effect";
            this.btnDeleteEffect.UseVisualStyleBackColor = true;
            this.btnDeleteEffect.Click += new System.EventHandler(this.btnDeleteEffect_Click);
            // 
            // btnDelWeapon
            // 
            this.btnDelWeapon.Location = new System.Drawing.Point(116, 294);
            this.btnDelWeapon.Name = "btnDelWeapon";
            this.btnDelWeapon.Size = new System.Drawing.Size(75, 41);
            this.btnDelWeapon.TabIndex = 24;
            this.btnDelWeapon.Text = "Delete Weapon";
            this.btnDelWeapon.UseVisualStyleBackColor = true;
            this.btnDelWeapon.Click += new System.EventHandler(this.btnDelWeapon_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Effect Type";
            // 
            // cboBoxEffectIndex
            // 
            this.cboBoxEffectIndex.FormattingEnabled = true;
            this.cboBoxEffectIndex.Location = new System.Drawing.Point(87, 216);
            this.cboBoxEffectIndex.Name = "cboBoxEffectIndex";
            this.cboBoxEffectIndex.Size = new System.Drawing.Size(121, 21);
            this.cboBoxEffectIndex.TabIndex = 26;
            this.cboBoxEffectIndex.SelectedIndexChanged += new System.EventHandler(this.cboBoxEffectIndex_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Selected Effect";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Stamina Cost";
            // 
            // txtBoxCost
            // 
            this.txtBoxCost.Location = new System.Drawing.Point(328, 12);
            this.txtBoxCost.Name = "txtBoxCost";
            this.txtBoxCost.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCost.TabIndex = 0;
            // 
            // cboBoxEffectTag
            // 
            this.cboBoxEffectTag.FormattingEnabled = true;
            this.cboBoxEffectTag.Location = new System.Drawing.Point(119, 39);
            this.cboBoxEffectTag.Name = "cboBoxEffectTag";
            this.cboBoxEffectTag.Size = new System.Drawing.Size(121, 21);
            this.cboBoxEffectTag.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Effect Tag";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 47);
            this.button2.TabIndex = 31;
            this.button2.Text = "Write All To Google";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(376, 355);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(305, 75);
            this.rtbDescription.TabIndex = 32;
            this.rtbDescription.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Damage Type";
            // 
            // comboBoxDamageType
            // 
            this.comboBoxDamageType.FormattingEnabled = true;
            this.comboBoxDamageType.Location = new System.Drawing.Point(119, 66);
            this.comboBoxDamageType.Name = "comboBoxDamageType";
            this.comboBoxDamageType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDamageType.TabIndex = 33;
            // 
            // SpellCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 442);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxDamageType);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboBoxEffectTag);
            this.Controls.Add(this.txtBoxCost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboBoxEffectIndex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDelWeapon);
            this.Controls.Add(this.btnDeleteEffect);
            this.Controls.Add(this.rtbWeapons);
            this.Controls.Add(this.rtbEffects);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxDeteriorationMul);
            this.Controls.Add(this.txtBoxLengthMul);
            this.Controls.Add(this.txtBoxPotencyMul);
            this.Controls.Add(this.txtBoxDeterioration);
            this.Controls.Add(this.txtBoxLength);
            this.Controls.Add(this.txtBoxPotency);
            this.Controls.Add(this.cboBoxSpellName);
            this.Controls.Add(this.txtBoxSpellName);
            this.Controls.Add(this.chkBoxPermanent);
            this.Controls.Add(this.txtBoxWeaponBonus);
            this.Controls.Add(this.cboBoxWeapons);
            this.Controls.Add(this.cboBoxEffectType);
            this.Controls.Add(this.btnSaveEff);
            this.Controls.Add(this.btnSaveWeapon);
            this.Controls.Add(this.button1);
            this.Name = "SpellCreator";
            this.Text = "SpellCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSaveWeapon;
        private System.Windows.Forms.Button btnSaveEff;
        private System.Windows.Forms.ComboBox cboBoxEffectType;
        private System.Windows.Forms.ComboBox cboBoxWeapons;
        private System.Windows.Forms.TextBox txtBoxWeaponBonus;
        private System.Windows.Forms.CheckBox chkBoxPermanent;
        private System.Windows.Forms.TextBox txtBoxSpellName;
        private System.Windows.Forms.ComboBox cboBoxSpellName;
        private System.Windows.Forms.TextBox txtBoxPotency;
        private System.Windows.Forms.TextBox txtBoxLength;
        private System.Windows.Forms.TextBox txtBoxDeterioration;
        private System.Windows.Forms.TextBox txtBoxPotencyMul;
        private System.Windows.Forms.TextBox txtBoxLengthMul;
        private System.Windows.Forms.TextBox txtBoxDeteriorationMul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbEffects;
        private System.Windows.Forms.RichTextBox rtbWeapons;
        private System.Windows.Forms.Button btnDeleteEffect;
        private System.Windows.Forms.Button btnDelWeapon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboBoxEffectIndex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxCost;
        private System.Windows.Forms.ComboBox cboBoxEffectTag;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxDamageType;
    }
}