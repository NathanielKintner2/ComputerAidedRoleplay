namespace Second_Attempt
{
    partial class ItemAssigner
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
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxItemNames = new System.Windows.Forms.ComboBox();
            this.comboBoxCharacterNames = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxItemType = new System.Windows.Forms.ComboBox();
            this.comboBoxGround = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBoxGround = new System.Windows.Forms.RichTextBox();
            this.textBoxItemCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxInventory = new System.Windows.Forms.RichTextBox();
            this.comboBoxInventory = new System.Windows.Forms.ComboBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(502, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Unassign";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxItemNames
            // 
            this.comboBoxItemNames.FormattingEnabled = true;
            this.comboBoxItemNames.Location = new System.Drawing.Point(12, 64);
            this.comboBoxItemNames.Name = "comboBoxItemNames";
            this.comboBoxItemNames.Size = new System.Drawing.Size(121, 21);
            this.comboBoxItemNames.TabIndex = 6;
            // 
            // comboBoxCharacterNames
            // 
            this.comboBoxCharacterNames.FormattingEnabled = true;
            this.comboBoxCharacterNames.Location = new System.Drawing.Point(242, 73);
            this.comboBoxCharacterNames.Name = "comboBoxCharacterNames";
            this.comboBoxCharacterNames.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCharacterNames.TabIndex = 5;
            this.comboBoxCharacterNames.SelectedIndexChanged += new System.EventHandler(this.comboBoxCharacterNames_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Assign To";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(139, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Ground";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBoxItemType
            // 
            this.comboBoxItemType.FormattingEnabled = true;
            this.comboBoxItemType.Location = new System.Drawing.Point(12, 37);
            this.comboBoxItemType.Name = "comboBoxItemType";
            this.comboBoxItemType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxItemType.TabIndex = 9;
            this.comboBoxItemType.SelectedIndexChanged += new System.EventHandler(this.comboBoxItemType_SelectedIndexChanged);
            // 
            // comboBoxGround
            // 
            this.comboBoxGround.FormattingEnabled = true;
            this.comboBoxGround.Location = new System.Drawing.Point(375, 46);
            this.comboBoxGround.Name = "comboBoxGround";
            this.comboBoxGround.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGround.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(375, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Pick Up";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // richTextBoxGround
            // 
            this.richTextBoxGround.Location = new System.Drawing.Point(375, 73);
            this.richTextBoxGround.Name = "richTextBoxGround";
            this.richTextBoxGround.Size = new System.Drawing.Size(97, 154);
            this.richTextBoxGround.TabIndex = 12;
            this.richTextBoxGround.Text = "";
            // 
            // textBoxItemCount
            // 
            this.textBoxItemCount.Location = new System.Drawing.Point(12, 107);
            this.textBoxItemCount.Name = "textBoxItemCount";
            this.textBoxItemCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxItemCount.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Count (Default 1)";
            // 
            // richTextBoxInventory
            // 
            this.richTextBoxInventory.Location = new System.Drawing.Point(502, 73);
            this.richTextBoxInventory.Name = "richTextBoxInventory";
            this.richTextBoxInventory.Size = new System.Drawing.Size(97, 154);
            this.richTextBoxInventory.TabIndex = 15;
            this.richTextBoxInventory.Text = "";
            // 
            // comboBoxInventory
            // 
            this.comboBoxInventory.FormattingEnabled = true;
            this.comboBoxInventory.Location = new System.Drawing.Point(502, 46);
            this.comboBoxInventory.Name = "comboBoxInventory";
            this.comboBoxInventory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxInventory.TabIndex = 16;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(12, 151);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(190, 83);
            this.richTextBoxDescription.TabIndex = 17;
            this.richTextBoxDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Description";
            // 
            // ItemAssigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 246);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.comboBoxInventory);
            this.Controls.Add(this.richTextBoxInventory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxItemCount);
            this.Controls.Add(this.richTextBoxGround);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBoxGround);
            this.Controls.Add(this.comboBoxItemType);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxItemNames);
            this.Controls.Add(this.comboBoxCharacterNames);
            this.Controls.Add(this.button1);
            this.Name = "ItemAssigner";
            this.Text = "ItemAssigner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxItemNames;
        private System.Windows.Forms.ComboBox comboBoxCharacterNames;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBoxItemType;
        private System.Windows.Forms.ComboBox comboBoxGround;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox richTextBoxGround;
        private System.Windows.Forms.TextBox textBoxItemCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxInventory;
        private System.Windows.Forms.ComboBox comboBoxInventory;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label label2;
    }
}