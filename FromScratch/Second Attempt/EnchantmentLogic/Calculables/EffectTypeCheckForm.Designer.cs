namespace Second_Attempt.EnchantmentLogic
{
    partial class EffectTypeCheckForm
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
            this.comboBoxEffectTypes = new System.Windows.Forms.ComboBox();
            this.comboBoxEffectTags = new System.Windows.Forms.ComboBox();
            this.comboBoxDamageType = new System.Windows.Forms.ComboBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxEffectTypes
            // 
            this.comboBoxEffectTypes.FormattingEnabled = true;
            this.comboBoxEffectTypes.Location = new System.Drawing.Point(12, 12);
            this.comboBoxEffectTypes.Name = "comboBoxEffectTypes";
            this.comboBoxEffectTypes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEffectTypes.TabIndex = 1;
            this.comboBoxEffectTypes.SelectedIndexChanged += new System.EventHandler(this.comboBoxEffectTypes_SelectedIndexChanged);
            this.comboBoxEffectTypes.TextUpdate += new System.EventHandler(this.comboBoxEffectTypes_TextUpdate);
            // 
            // comboBoxEffectTags
            // 
            this.comboBoxEffectTags.FormattingEnabled = true;
            this.comboBoxEffectTags.Location = new System.Drawing.Point(139, 12);
            this.comboBoxEffectTags.Name = "comboBoxEffectTags";
            this.comboBoxEffectTags.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEffectTags.TabIndex = 2;
            this.comboBoxEffectTags.SelectedIndexChanged += new System.EventHandler(this.comboBoxEffectTags_SelectedIndexChanged);
            this.comboBoxEffectTags.TextUpdate += new System.EventHandler(this.comboBoxEffectTags_TextUpdate);
            // 
            // comboBoxDamageType
            // 
            this.comboBoxDamageType.FormattingEnabled = true;
            this.comboBoxDamageType.Location = new System.Drawing.Point(12, 39);
            this.comboBoxDamageType.Name = "comboBoxDamageType";
            this.comboBoxDamageType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDamageType.TabIndex = 3;
            this.comboBoxDamageType.SelectedIndexChanged += new System.EventHandler(this.comboBoxDamageType_SelectedIndexChanged);
            this.comboBoxDamageType.TextUpdate += new System.EventHandler(this.comboBoxDamageType_TextUpdate);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(139, 40);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(121, 23);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // EffectTypeCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 261);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.comboBoxDamageType);
            this.Controls.Add(this.comboBoxEffectTags);
            this.Controls.Add(this.comboBoxEffectTypes);
            this.Name = "EffectTypeCheckForm";
            this.Text = "EffectTypeCheckForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEffectTypes;
        private System.Windows.Forms.ComboBox comboBoxEffectTags;
        private System.Windows.Forms.ComboBox comboBoxDamageType;
        private System.Windows.Forms.Button buttonReset;
    }
}