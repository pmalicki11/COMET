namespace COMET
{
    partial class FuzzyVariableControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.criterionName = new System.Windows.Forms.Label();
            this.varValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // criterionName
            // 
            this.criterionName.AutoSize = true;
            this.criterionName.Location = new System.Drawing.Point(3, 7);
            this.criterionName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.criterionName.Name = "criterionName";
            this.criterionName.Size = new System.Drawing.Size(35, 13);
            this.criterionName.TabIndex = 0;
            this.criterionName.Text = "label1";
            // 
            // varValue
            // 
            this.varValue.Location = new System.Drawing.Point(65, 4);
            this.varValue.Name = "varValue";
            this.varValue.Size = new System.Drawing.Size(100, 20);
            this.varValue.TabIndex = 1;
            // 
            // FuzzyVariableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.varValue);
            this.Controls.Add(this.criterionName);
            this.Name = "FuzzyVariableControl";
            this.Size = new System.Drawing.Size(180, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label criterionName;
        private System.Windows.Forms.TextBox varValue;
    }
}
