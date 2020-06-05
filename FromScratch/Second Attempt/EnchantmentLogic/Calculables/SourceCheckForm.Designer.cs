namespace Second_Attempt.EnchantmentLogic
{
    partial class SourceCheckForm
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
            this.comboBoxSources = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxSources
            // 
            this.comboBoxSources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSources.FormattingEnabled = true;
            this.comboBoxSources.Location = new System.Drawing.Point(13, 13);
            this.comboBoxSources.Name = "comboBoxSources";
            this.comboBoxSources.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSources.TabIndex = 0;
            this.comboBoxSources.SelectedIndexChanged += new System.EventHandler(this.comboBoxSources_SelectedIndexChanged);
            // 
            // SourceCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 51);
            this.Controls.Add(this.comboBoxSources);
            this.Name = "SourceCheckForm";
            this.Text = "SourceCheckForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSources;
    }
}