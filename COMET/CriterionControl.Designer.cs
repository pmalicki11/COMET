namespace COMET
{
    partial class CriterionControl
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
            this.criterionTextBox = new System.Windows.Forms.TextBox();
            this.operationLabel = new System.Windows.Forms.LinkLabel();
            this.valuesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // criterionTextBox
            // 
            this.criterionTextBox.Location = new System.Drawing.Point(3, 3);
            this.criterionTextBox.Name = "criterionTextBox";
            this.criterionTextBox.Size = new System.Drawing.Size(120, 20);
            this.criterionTextBox.TabIndex = 0;
            // 
            // operationLabel
            // 
            this.operationLabel.AutoSize = true;
            this.operationLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.operationLabel.Location = new System.Drawing.Point(350, 6);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(66, 13);
            this.operationLabel.TabIndex = 2;
            this.operationLabel.TabStop = true;
            this.operationLabel.Text = "Add criterion";
            this.operationLabel.Click += new System.EventHandler(this.operationLabel_Click);
            // 
            // valuesTextBox
            // 
            this.valuesTextBox.Location = new System.Drawing.Point(129, 3);
            this.valuesTextBox.Name = "valuesTextBox";
            this.valuesTextBox.Size = new System.Drawing.Size(215, 20);
            this.valuesTextBox.TabIndex = 1;
            this.valuesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterPressed);
            // 
            // CriterionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.valuesTextBox);
            this.Controls.Add(this.operationLabel);
            this.Controls.Add(this.criterionTextBox);
            this.Name = "CriterionControl";
            this.Size = new System.Drawing.Size(421, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox criterionTextBox;
        private System.Windows.Forms.LinkLabel operationLabel;
        private System.Windows.Forms.TextBox valuesTextBox;
    }
}
