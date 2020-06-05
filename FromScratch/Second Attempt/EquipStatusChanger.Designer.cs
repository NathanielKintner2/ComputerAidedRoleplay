namespace Second_Attempt
{
    partial class EquipStatusChanger
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
            this.buttonEquip = new System.Windows.Forms.Button();
            this.comboBoxCharacters = new System.Windows.Forms.ComboBox();
            this.comboBoxNonEquipped = new System.Windows.Forms.ComboBox();
            this.buttonUnequip = new System.Windows.Forms.Button();
            this.comboBoxEquipped = new System.Windows.Forms.ComboBox();
            this.richTextBoxBag = new System.Windows.Forms.RichTextBox();
            this.richTextBoxEquipped = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEquip
            // 
            this.buttonEquip.Location = new System.Drawing.Point(139, 39);
            this.buttonEquip.Name = "buttonEquip";
            this.buttonEquip.Size = new System.Drawing.Size(75, 23);
            this.buttonEquip.TabIndex = 0;
            this.buttonEquip.Text = "Equip";
            this.buttonEquip.UseVisualStyleBackColor = true;
            this.buttonEquip.Click += new System.EventHandler(this.buttonEquip_Click);
            // 
            // comboBoxCharacters
            // 
            this.comboBoxCharacters.FormattingEnabled = true;
            this.comboBoxCharacters.Location = new System.Drawing.Point(12, 12);
            this.comboBoxCharacters.Name = "comboBoxCharacters";
            this.comboBoxCharacters.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCharacters.TabIndex = 1;
            this.comboBoxCharacters.SelectedIndexChanged += new System.EventHandler(this.comboBoxCharacters_SelectedIndexChanged);
            // 
            // comboBoxNonEquipped
            // 
            this.comboBoxNonEquipped.FormattingEnabled = true;
            this.comboBoxNonEquipped.Location = new System.Drawing.Point(139, 12);
            this.comboBoxNonEquipped.Name = "comboBoxNonEquipped";
            this.comboBoxNonEquipped.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNonEquipped.TabIndex = 2;
            // 
            // buttonUnequip
            // 
            this.buttonUnequip.Location = new System.Drawing.Point(266, 39);
            this.buttonUnequip.Name = "buttonUnequip";
            this.buttonUnequip.Size = new System.Drawing.Size(75, 23);
            this.buttonUnequip.TabIndex = 3;
            this.buttonUnequip.Text = "Unequip";
            this.buttonUnequip.UseVisualStyleBackColor = true;
            this.buttonUnequip.Click += new System.EventHandler(this.buttonUnequip_Click);
            // 
            // comboBoxEquipped
            // 
            this.comboBoxEquipped.FormattingEnabled = true;
            this.comboBoxEquipped.Location = new System.Drawing.Point(266, 12);
            this.comboBoxEquipped.Name = "comboBoxEquipped";
            this.comboBoxEquipped.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEquipped.TabIndex = 4;
            // 
            // richTextBoxBag
            // 
            this.richTextBoxBag.Location = new System.Drawing.Point(139, 69);
            this.richTextBoxBag.Name = "richTextBoxBag";
            this.richTextBoxBag.Size = new System.Drawing.Size(121, 141);
            this.richTextBoxBag.TabIndex = 5;
            this.richTextBoxBag.Text = "";
            // 
            // richTextBoxEquipped
            // 
            this.richTextBoxEquipped.Location = new System.Drawing.Point(266, 69);
            this.richTextBoxEquipped.Name = "richTextBoxEquipped";
            this.richTextBoxEquipped.Size = new System.Drawing.Size(121, 141);
            this.richTextBoxEquipped.TabIndex = 6;
            this.richTextBoxEquipped.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Identify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EquipStatusChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxEquipped);
            this.Controls.Add(this.richTextBoxBag);
            this.Controls.Add(this.comboBoxEquipped);
            this.Controls.Add(this.buttonUnequip);
            this.Controls.Add(this.comboBoxNonEquipped);
            this.Controls.Add(this.comboBoxCharacters);
            this.Controls.Add(this.buttonEquip);
            this.Name = "EquipStatusChanger";
            this.Text = "EquipStatusChanger";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEquip;
        private System.Windows.Forms.ComboBox comboBoxCharacters;
        private System.Windows.Forms.ComboBox comboBoxNonEquipped;
        private System.Windows.Forms.Button buttonUnequip;
        private System.Windows.Forms.ComboBox comboBoxEquipped;
        private System.Windows.Forms.RichTextBox richTextBoxBag;
        private System.Windows.Forms.RichTextBox richTextBoxEquipped;
        private System.Windows.Forms.Button button1;
    }
}