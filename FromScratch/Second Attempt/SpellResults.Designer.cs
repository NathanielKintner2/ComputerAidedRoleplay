namespace Second_Attempt
{
    partial class SpellResults
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
            this.btnResolveSpells = new System.Windows.Forms.Button();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnResolveSpells
            // 
            this.btnResolveSpells.Location = new System.Drawing.Point(12, 226);
            this.btnResolveSpells.Name = "btnResolveSpells";
            this.btnResolveSpells.Size = new System.Drawing.Size(75, 23);
            this.btnResolveSpells.TabIndex = 0;
            this.btnResolveSpells.Text = "Resolve Spells";
            this.btnResolveSpells.UseVisualStyleBackColor = true;
            this.btnResolveSpells.Click += new System.EventHandler(this.btnResolveSpells_Click);
            // 
            // rtbResults
            // 
            this.rtbResults.Location = new System.Drawing.Point(13, 13);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(259, 207);
            this.rtbResults.TabIndex = 1;
            this.rtbResults.Text = "";
            // 
            // SpellResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rtbResults);
            this.Controls.Add(this.btnResolveSpells);
            this.Name = "SpellResults";
            this.Text = "SpellResults";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResolveSpells;
        private System.Windows.Forms.RichTextBox rtbResults;
    }
}