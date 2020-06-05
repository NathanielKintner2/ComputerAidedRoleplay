namespace Second_Attempt
{
    partial class EnchantmentCreator
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
            this.comboBoxEnchantments = new System.Windows.Forms.ComboBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.comboBoxTargets = new System.Windows.Forms.ComboBox();
            this.buttonAssignment = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.richTextBoxParams = new System.Windows.Forms.RichTextBox();
            this.comboBoxAlreadyAssigned = new System.Windows.Forms.ComboBox();
            this.buttonUnassignment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxEnchantments
            // 
            this.comboBoxEnchantments.FormattingEnabled = true;
            this.comboBoxEnchantments.Location = new System.Drawing.Point(12, 12);
            this.comboBoxEnchantments.Name = "comboBoxEnchantments";
            this.comboBoxEnchantments.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEnchantments.TabIndex = 0;
            this.comboBoxEnchantments.SelectedIndexChanged += new System.EventHandler(this.comboBoxEnchantments_SelectedIndexChanged);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(12, 39);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(121, 23);
            this.buttonNew.TabIndex = 1;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(12, 68);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(121, 23);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // comboBoxTargets
            // 
            this.comboBoxTargets.FormattingEnabled = true;
            this.comboBoxTargets.Location = new System.Drawing.Point(12, 124);
            this.comboBoxTargets.Name = "comboBoxTargets";
            this.comboBoxTargets.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTargets.TabIndex = 3;
            this.comboBoxTargets.SelectedIndexChanged += new System.EventHandler(this.comboBoxTargets_SelectedIndexChanged);
            // 
            // buttonAssignment
            // 
            this.buttonAssignment.Location = new System.Drawing.Point(12, 151);
            this.buttonAssignment.Name = "buttonAssignment";
            this.buttonAssignment.Size = new System.Drawing.Size(121, 23);
            this.buttonAssignment.TabIndex = 4;
            this.buttonAssignment.Text = "Assign";
            this.buttonAssignment.UseVisualStyleBackColor = true;
            this.buttonAssignment.Click += new System.EventHandler(this.buttonAssignment_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(12, 97);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 5;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // richTextBoxParams
            // 
            this.richTextBoxParams.Location = new System.Drawing.Point(140, 39);
            this.richTextBoxParams.Name = "richTextBoxParams";
            this.richTextBoxParams.Size = new System.Drawing.Size(243, 134);
            this.richTextBoxParams.TabIndex = 6;
            this.richTextBoxParams.Text = "";
            // 
            // comboBoxAlreadyAssigned
            // 
            this.comboBoxAlreadyAssigned.FormattingEnabled = true;
            this.comboBoxAlreadyAssigned.Location = new System.Drawing.Point(140, 12);
            this.comboBoxAlreadyAssigned.Name = "comboBoxAlreadyAssigned";
            this.comboBoxAlreadyAssigned.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAlreadyAssigned.TabIndex = 7;
            this.comboBoxAlreadyAssigned.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlreadyAssigned_SelectedIndexChanged);
            // 
            // buttonUnassignment
            // 
            this.buttonUnassignment.Location = new System.Drawing.Point(267, 12);
            this.buttonUnassignment.Name = "buttonUnassignment";
            this.buttonUnassignment.Size = new System.Drawing.Size(116, 21);
            this.buttonUnassignment.TabIndex = 8;
            this.buttonUnassignment.Text = "Unassign";
            this.buttonUnassignment.UseVisualStyleBackColor = true;
            this.buttonUnassignment.Click += new System.EventHandler(this.buttonUnassignment_Click);
            // 
            // EnchantmentCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 185);
            this.Controls.Add(this.buttonUnassignment);
            this.Controls.Add(this.comboBoxAlreadyAssigned);
            this.Controls.Add(this.richTextBoxParams);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.buttonAssignment);
            this.Controls.Add(this.comboBoxTargets);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.comboBoxEnchantments);
            this.Name = "EnchantmentCreator";
            this.Text = "EnchantmentCreator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEnchantments;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ComboBox comboBoxTargets;
        private System.Windows.Forms.Button buttonAssignment;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.RichTextBox richTextBoxParams;
        private System.Windows.Forms.ComboBox comboBoxAlreadyAssigned;
        private System.Windows.Forms.Button buttonUnassignment;
    }
}