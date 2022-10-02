namespace TimetableManager
{
    partial class FormMain
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
            this.groupBoxModuleInfo = new System.Windows.Forms.GroupBox();
            this.comboBoxModuleSelector = new System.Windows.Forms.ComboBox();
            this.labelModuleSelector = new System.Windows.Forms.Label();
            this.textBoxModuleDescription = new System.Windows.Forms.TextBox();
            this.labelModuleDescription = new System.Windows.Forms.Label();
            this.groupBoxModuleInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxModuleInfo
            // 
            this.groupBoxModuleInfo.Controls.Add(this.labelModuleDescription);
            this.groupBoxModuleInfo.Controls.Add(this.textBoxModuleDescription);
            this.groupBoxModuleInfo.Controls.Add(this.labelModuleSelector);
            this.groupBoxModuleInfo.Controls.Add(this.comboBoxModuleSelector);
            this.groupBoxModuleInfo.Location = new System.Drawing.Point(12, 34);
            this.groupBoxModuleInfo.Name = "groupBoxModuleInfo";
            this.groupBoxModuleInfo.Size = new System.Drawing.Size(511, 323);
            this.groupBoxModuleInfo.TabIndex = 0;
            this.groupBoxModuleInfo.TabStop = false;
            this.groupBoxModuleInfo.Text = "Module Information";
            // 
            // comboBoxModuleSelector
            // 
            this.comboBoxModuleSelector.FormattingEnabled = true;
            this.comboBoxModuleSelector.Location = new System.Drawing.Point(77, 29);
            this.comboBoxModuleSelector.Name = "comboBoxModuleSelector";
            this.comboBoxModuleSelector.Size = new System.Drawing.Size(428, 28);
            this.comboBoxModuleSelector.TabIndex = 0;
            this.comboBoxModuleSelector.SelectedIndexChanged += new System.EventHandler(this.comboBoxModuleSelector_SelectedIndexChanged);
            // 
            // labelModuleSelector
            // 
            this.labelModuleSelector.AutoSize = true;
            this.labelModuleSelector.Location = new System.Drawing.Point(6, 32);
            this.labelModuleSelector.Name = "labelModuleSelector";
            this.labelModuleSelector.Size = new System.Drawing.Size(65, 20);
            this.labelModuleSelector.TabIndex = 1;
            this.labelModuleSelector.Text = "Module:";
            // 
            // textBoxModuleDescription
            // 
            this.textBoxModuleDescription.Location = new System.Drawing.Point(6, 98);
            this.textBoxModuleDescription.Multiline = true;
            this.textBoxModuleDescription.Name = "textBoxModuleDescription";
            this.textBoxModuleDescription.ReadOnly = true;
            this.textBoxModuleDescription.Size = new System.Drawing.Size(499, 205);
            this.textBoxModuleDescription.TabIndex = 2;
            // 
            // labelModuleDescription
            // 
            this.labelModuleDescription.AutoSize = true;
            this.labelModuleDescription.Location = new System.Drawing.Point(6, 75);
            this.labelModuleDescription.Name = "labelModuleDescription";
            this.labelModuleDescription.Size = new System.Drawing.Size(145, 20);
            this.labelModuleDescription.TabIndex = 3;
            this.labelModuleDescription.Text = "Module Description";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 369);
            this.Controls.Add(this.groupBoxModuleInfo);
            this.Name = "FormMain";
            this.Text = "Timetable System Manager";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxModuleInfo.ResumeLayout(false);
            this.groupBoxModuleInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxModuleInfo;
        private System.Windows.Forms.Label labelModuleDescription;
        private System.Windows.Forms.TextBox textBoxModuleDescription;
        private System.Windows.Forms.Label labelModuleSelector;
        private System.Windows.Forms.ComboBox comboBoxModuleSelector;
    }
}

