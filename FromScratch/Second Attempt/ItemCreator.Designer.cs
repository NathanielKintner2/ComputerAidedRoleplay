namespace Second_Attempt
{
    partial class ItemCreator
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.richTextBoxTechnicalDescription = new System.Windows.Forms.RichTextBox();
            this.comboBoxItemUse = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 147);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(12, 12);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxName.TabIndex = 1;
            this.comboBoxName.SelectedIndexChanged += new System.EventHandler(this.comboBoxName_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(12, 91);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 3;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(139, 12);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(133, 158);
            this.richTextBoxDescription.TabIndex = 4;
            this.richTextBoxDescription.Text = "";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(12, 65);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(121, 20);
            this.textBoxWeight.TabIndex = 5;
            // 
            // richTextBoxTechnicalDescription
            // 
            this.richTextBoxTechnicalDescription.Location = new System.Drawing.Point(12, 176);
            this.richTextBoxTechnicalDescription.Name = "richTextBoxTechnicalDescription";
            this.richTextBoxTechnicalDescription.Size = new System.Drawing.Size(260, 124);
            this.richTextBoxTechnicalDescription.TabIndex = 6;
            this.richTextBoxTechnicalDescription.Text = "";
            // 
            // comboBoxItemUse
            // 
            this.comboBoxItemUse.FormattingEnabled = true;
            this.comboBoxItemUse.Location = new System.Drawing.Point(12, 118);
            this.comboBoxItemUse.Name = "comboBoxItemUse";
            this.comboBoxItemUse.Size = new System.Drawing.Size(121, 21);
            this.comboBoxItemUse.TabIndex = 7;
            // 
            // ItemCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 312);
            this.Controls.Add(this.comboBoxItemUse);
            this.Controls.Add(this.richTextBoxTechnicalDescription);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.buttonSave);
            this.Name = "ItemCreator";
            this.Text = "ItemCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.RichTextBox richTextBoxTechnicalDescription;
        private System.Windows.Forms.ComboBox comboBoxItemUse;
    }
}