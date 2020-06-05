namespace Second_Attempt.EnchantmentLogic
{
    partial class IfElseLogicForm
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
            this.comboBoxConditions = new System.Windows.Forms.ComboBox();
            this.comboBoxCurrentConditions = new System.Windows.Forms.ComboBox();
            this.comboBoxResults = new System.Windows.Forms.ComboBox();
            this.comboBoxIfResults = new System.Windows.Forms.ComboBox();
            this.comboBoxElseResults = new System.Windows.Forms.ComboBox();
            this.buttonAddCondition = new System.Windows.Forms.Button();
            this.buttonAddIfResult = new System.Windows.Forms.Button();
            this.buttonAddElseResult = new System.Windows.Forms.Button();
            this.buttonEditCondition = new System.Windows.Forms.Button();
            this.buttonEditIfResult = new System.Windows.Forms.Button();
            this.buttonEditElseResult = new System.Windows.Forms.Button();
            this.buttonDeleteCondition = new System.Windows.Forms.Button();
            this.buttonDeleteIfResult = new System.Windows.Forms.Button();
            this.buttonDeleteElseResult = new System.Windows.Forms.Button();
            this.textBoxLogicName = new System.Windows.Forms.TextBox();
            this.textBoxVariableName = new System.Windows.Forms.TextBox();
            this.comboBoxVariables = new System.Windows.Forms.ComboBox();
            this.checkBoxEnableDeletes = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxVariables = new System.Windows.Forms.RichTextBox();
            this.buttonAddVariable = new System.Windows.Forms.Button();
            this.buttonDeleteVariable = new System.Windows.Forms.Button();
            this.buttonFire = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxPremades = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBoxConditions
            // 
            this.comboBoxConditions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConditions.FormattingEnabled = true;
            this.comboBoxConditions.Location = new System.Drawing.Point(12, 114);
            this.comboBoxConditions.Name = "comboBoxConditions";
            this.comboBoxConditions.Size = new System.Drawing.Size(121, 21);
            this.comboBoxConditions.TabIndex = 0;
            // 
            // comboBoxCurrentConditions
            // 
            this.comboBoxCurrentConditions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurrentConditions.FormattingEnabled = true;
            this.comboBoxCurrentConditions.Location = new System.Drawing.Point(12, 170);
            this.comboBoxCurrentConditions.Name = "comboBoxCurrentConditions";
            this.comboBoxCurrentConditions.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCurrentConditions.TabIndex = 1;
            // 
            // comboBoxResults
            // 
            this.comboBoxResults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResults.FormattingEnabled = true;
            this.comboBoxResults.Location = new System.Drawing.Point(139, 114);
            this.comboBoxResults.Name = "comboBoxResults";
            this.comboBoxResults.Size = new System.Drawing.Size(121, 21);
            this.comboBoxResults.TabIndex = 2;
            // 
            // comboBoxIfResults
            // 
            this.comboBoxIfResults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIfResults.FormattingEnabled = true;
            this.comboBoxIfResults.Location = new System.Drawing.Point(139, 170);
            this.comboBoxIfResults.Name = "comboBoxIfResults";
            this.comboBoxIfResults.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIfResults.TabIndex = 3;
            // 
            // comboBoxElseResults
            // 
            this.comboBoxElseResults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxElseResults.FormattingEnabled = true;
            this.comboBoxElseResults.Location = new System.Drawing.Point(266, 170);
            this.comboBoxElseResults.Name = "comboBoxElseResults";
            this.comboBoxElseResults.Size = new System.Drawing.Size(121, 21);
            this.comboBoxElseResults.TabIndex = 4;
            // 
            // buttonAddCondition
            // 
            this.buttonAddCondition.Location = new System.Drawing.Point(12, 141);
            this.buttonAddCondition.Name = "buttonAddCondition";
            this.buttonAddCondition.Size = new System.Drawing.Size(119, 23);
            this.buttonAddCondition.TabIndex = 6;
            this.buttonAddCondition.Text = "Add Condition";
            this.buttonAddCondition.UseVisualStyleBackColor = true;
            this.buttonAddCondition.Click += new System.EventHandler(this.buttonAddCondition_Click);
            // 
            // buttonAddIfResult
            // 
            this.buttonAddIfResult.Location = new System.Drawing.Point(139, 141);
            this.buttonAddIfResult.Name = "buttonAddIfResult";
            this.buttonAddIfResult.Size = new System.Drawing.Size(121, 23);
            this.buttonAddIfResult.TabIndex = 7;
            this.buttonAddIfResult.Text = "Add If Result";
            this.buttonAddIfResult.UseVisualStyleBackColor = true;
            this.buttonAddIfResult.Click += new System.EventHandler(this.buttonAddIfResult_Click);
            // 
            // buttonAddElseResult
            // 
            this.buttonAddElseResult.Location = new System.Drawing.Point(266, 141);
            this.buttonAddElseResult.Name = "buttonAddElseResult";
            this.buttonAddElseResult.Size = new System.Drawing.Size(119, 23);
            this.buttonAddElseResult.TabIndex = 8;
            this.buttonAddElseResult.Text = "Add Else Result";
            this.buttonAddElseResult.UseVisualStyleBackColor = true;
            this.buttonAddElseResult.Click += new System.EventHandler(this.buttonAddElseResult_Click);
            // 
            // buttonEditCondition
            // 
            this.buttonEditCondition.Location = new System.Drawing.Point(12, 197);
            this.buttonEditCondition.Name = "buttonEditCondition";
            this.buttonEditCondition.Size = new System.Drawing.Size(121, 23);
            this.buttonEditCondition.TabIndex = 9;
            this.buttonEditCondition.Text = "Edit Condition";
            this.buttonEditCondition.UseVisualStyleBackColor = true;
            this.buttonEditCondition.Click += new System.EventHandler(this.buttonEditCondition_Click);
            // 
            // buttonEditIfResult
            // 
            this.buttonEditIfResult.Location = new System.Drawing.Point(139, 197);
            this.buttonEditIfResult.Name = "buttonEditIfResult";
            this.buttonEditIfResult.Size = new System.Drawing.Size(121, 23);
            this.buttonEditIfResult.TabIndex = 10;
            this.buttonEditIfResult.Text = "Edit If Result";
            this.buttonEditIfResult.UseVisualStyleBackColor = true;
            this.buttonEditIfResult.Click += new System.EventHandler(this.buttonEditIfResult_Click);
            // 
            // buttonEditElseResult
            // 
            this.buttonEditElseResult.Location = new System.Drawing.Point(266, 197);
            this.buttonEditElseResult.Name = "buttonEditElseResult";
            this.buttonEditElseResult.Size = new System.Drawing.Size(121, 23);
            this.buttonEditElseResult.TabIndex = 11;
            this.buttonEditElseResult.Text = "Edit Else Result";
            this.buttonEditElseResult.UseVisualStyleBackColor = true;
            this.buttonEditElseResult.Click += new System.EventHandler(this.buttonEditElseResult_Click);
            // 
            // buttonDeleteCondition
            // 
            this.buttonDeleteCondition.Location = new System.Drawing.Point(12, 226);
            this.buttonDeleteCondition.Name = "buttonDeleteCondition";
            this.buttonDeleteCondition.Size = new System.Drawing.Size(121, 23);
            this.buttonDeleteCondition.TabIndex = 12;
            this.buttonDeleteCondition.Text = "Delete Condition";
            this.buttonDeleteCondition.UseVisualStyleBackColor = true;
            this.buttonDeleteCondition.Click += new System.EventHandler(this.buttonDeleteCondition_Click);
            // 
            // buttonDeleteIfResult
            // 
            this.buttonDeleteIfResult.Location = new System.Drawing.Point(139, 226);
            this.buttonDeleteIfResult.Name = "buttonDeleteIfResult";
            this.buttonDeleteIfResult.Size = new System.Drawing.Size(121, 23);
            this.buttonDeleteIfResult.TabIndex = 13;
            this.buttonDeleteIfResult.Text = "Delete If Result";
            this.buttonDeleteIfResult.UseVisualStyleBackColor = true;
            this.buttonDeleteIfResult.Click += new System.EventHandler(this.buttonDeleteIfResult_Click);
            // 
            // buttonDeleteElseResult
            // 
            this.buttonDeleteElseResult.Location = new System.Drawing.Point(266, 226);
            this.buttonDeleteElseResult.Name = "buttonDeleteElseResult";
            this.buttonDeleteElseResult.Size = new System.Drawing.Size(121, 23);
            this.buttonDeleteElseResult.TabIndex = 14;
            this.buttonDeleteElseResult.Text = "Delete Else Result";
            this.buttonDeleteElseResult.UseVisualStyleBackColor = true;
            this.buttonDeleteElseResult.Click += new System.EventHandler(this.buttonDeleteElseResult_Click);
            // 
            // textBoxLogicName
            // 
            this.textBoxLogicName.Location = new System.Drawing.Point(12, 20);
            this.textBoxLogicName.Name = "textBoxLogicName";
            this.textBoxLogicName.Size = new System.Drawing.Size(121, 20);
            this.textBoxLogicName.TabIndex = 15;
            this.textBoxLogicName.TextChanged += new System.EventHandler(this.textBoxLogicName_TextChanged);
            // 
            // textBoxVariableName
            // 
            this.textBoxVariableName.Location = new System.Drawing.Point(158, 59);
            this.textBoxVariableName.Name = "textBoxVariableName";
            this.textBoxVariableName.Size = new System.Drawing.Size(100, 20);
            this.textBoxVariableName.TabIndex = 16;
            // 
            // comboBoxVariables
            // 
            this.comboBoxVariables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVariables.FormattingEnabled = true;
            this.comboBoxVariables.Location = new System.Drawing.Point(264, 59);
            this.comboBoxVariables.Name = "comboBoxVariables";
            this.comboBoxVariables.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVariables.TabIndex = 17;
            this.comboBoxVariables.SelectedIndexChanged += new System.EventHandler(this.comboBoxVariables_SelectedIndexChanged);
            // 
            // checkBoxEnableDeletes
            // 
            this.checkBoxEnableDeletes.AutoSize = true;
            this.checkBoxEnableDeletes.Location = new System.Drawing.Point(264, 42);
            this.checkBoxEnableDeletes.Name = "checkBoxEnableDeletes";
            this.checkBoxEnableDeletes.Size = new System.Drawing.Size(98, 17);
            this.checkBoxEnableDeletes.TabIndex = 18;
            this.checkBoxEnableDeletes.Text = "Enable Deletes";
            this.checkBoxEnableDeletes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name Of Logic Piece";
            // 
            // richTextBoxVariables
            // 
            this.richTextBoxVariables.Location = new System.Drawing.Point(12, 46);
            this.richTextBoxVariables.Name = "richTextBoxVariables";
            this.richTextBoxVariables.Size = new System.Drawing.Size(140, 62);
            this.richTextBoxVariables.TabIndex = 20;
            this.richTextBoxVariables.Text = "";
            // 
            // buttonAddVariable
            // 
            this.buttonAddVariable.Location = new System.Drawing.Point(158, 86);
            this.buttonAddVariable.Name = "buttonAddVariable";
            this.buttonAddVariable.Size = new System.Drawing.Size(100, 23);
            this.buttonAddVariable.TabIndex = 21;
            this.buttonAddVariable.Text = "Add Variable";
            this.buttonAddVariable.UseVisualStyleBackColor = true;
            this.buttonAddVariable.Click += new System.EventHandler(this.buttonAddVariable_Click);
            // 
            // buttonDeleteVariable
            // 
            this.buttonDeleteVariable.Location = new System.Drawing.Point(264, 86);
            this.buttonDeleteVariable.Name = "buttonDeleteVariable";
            this.buttonDeleteVariable.Size = new System.Drawing.Size(121, 23);
            this.buttonDeleteVariable.TabIndex = 22;
            this.buttonDeleteVariable.Text = "Delete Variable";
            this.buttonDeleteVariable.UseVisualStyleBackColor = true;
            this.buttonDeleteVariable.Click += new System.EventHandler(this.buttonDeleteVariable_Click);
            // 
            // buttonFire
            // 
            this.buttonFire.Location = new System.Drawing.Point(311, 13);
            this.buttonFire.Name = "buttonFire";
            this.buttonFire.Size = new System.Drawing.Size(75, 23);
            this.buttonFire.TabIndex = 23;
            this.buttonFire.Text = "Fire";
            this.buttonFire.UseVisualStyleBackColor = true;
            this.buttonFire.Click += new System.EventHandler(this.buttonFire_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(230, 13);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 24;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxPremades
            // 
            this.checkBoxPremades.AutoSize = true;
            this.checkBoxPremades.Location = new System.Drawing.Point(158, 42);
            this.checkBoxPremades.Name = "checkBoxPremades";
            this.checkBoxPremades.Size = new System.Drawing.Size(103, 17);
            this.checkBoxPremades.TabIndex = 25;
            this.checkBoxPremades.Text = "Show Premades";
            this.checkBoxPremades.UseVisualStyleBackColor = true;
            this.checkBoxPremades.CheckedChanged += new System.EventHandler(this.checkBoxPremades_CheckedChanged);
            // 
            // IfElseLogicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 261);
            this.Controls.Add(this.checkBoxPremades);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonFire);
            this.Controls.Add(this.buttonDeleteVariable);
            this.Controls.Add(this.buttonAddVariable);
            this.Controls.Add(this.richTextBoxVariables);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxEnableDeletes);
            this.Controls.Add(this.comboBoxVariables);
            this.Controls.Add(this.textBoxVariableName);
            this.Controls.Add(this.textBoxLogicName);
            this.Controls.Add(this.buttonDeleteElseResult);
            this.Controls.Add(this.buttonDeleteIfResult);
            this.Controls.Add(this.buttonDeleteCondition);
            this.Controls.Add(this.buttonEditElseResult);
            this.Controls.Add(this.buttonEditIfResult);
            this.Controls.Add(this.buttonEditCondition);
            this.Controls.Add(this.buttonAddElseResult);
            this.Controls.Add(this.buttonAddIfResult);
            this.Controls.Add(this.buttonAddCondition);
            this.Controls.Add(this.comboBoxElseResults);
            this.Controls.Add(this.comboBoxIfResults);
            this.Controls.Add(this.comboBoxResults);
            this.Controls.Add(this.comboBoxCurrentConditions);
            this.Controls.Add(this.comboBoxConditions);
            this.Name = "IfElseLogicForm";
            this.Text = "IfElseLogicForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxConditions;
        private System.Windows.Forms.ComboBox comboBoxCurrentConditions;
        private System.Windows.Forms.ComboBox comboBoxResults;
        private System.Windows.Forms.ComboBox comboBoxIfResults;
        private System.Windows.Forms.ComboBox comboBoxElseResults;
        private System.Windows.Forms.Button buttonAddCondition;
        private System.Windows.Forms.Button buttonAddIfResult;
        private System.Windows.Forms.Button buttonAddElseResult;
        private System.Windows.Forms.Button buttonEditCondition;
        private System.Windows.Forms.Button buttonEditIfResult;
        private System.Windows.Forms.Button buttonEditElseResult;
        private System.Windows.Forms.Button buttonDeleteCondition;
        private System.Windows.Forms.Button buttonDeleteIfResult;
        private System.Windows.Forms.Button buttonDeleteElseResult;
        private System.Windows.Forms.TextBox textBoxLogicName;
        private System.Windows.Forms.TextBox textBoxVariableName;
        private System.Windows.Forms.ComboBox comboBoxVariables;
        private System.Windows.Forms.CheckBox checkBoxEnableDeletes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxVariables;
        private System.Windows.Forms.Button buttonAddVariable;
        private System.Windows.Forms.Button buttonDeleteVariable;
        private System.Windows.Forms.Button buttonFire;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBoxPremades;
    }
}