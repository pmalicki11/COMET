namespace COMET
{
    partial class SensitivityResultSingle
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
            this.title = new System.Windows.Forms.Label();
            this.inputValues = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.resultChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(2, 11);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(23, 13);
            this.title.TabIndex = 0;
            this.title.Text = "title";
            // 
            // inputValues
            // 
            this.inputValues.AutoSize = true;
            this.inputValues.Location = new System.Drawing.Point(2, 36);
            this.inputValues.Name = "inputValues";
            this.inputValues.Size = new System.Drawing.Size(30, 13);
            this.inputValues.TabIndex = 1;
            this.inputValues.Text = "input";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(128, 36);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(32, 13);
            this.result.TabIndex = 1;
            this.result.Text = "result";
            // 
            // resultChange
            // 
            this.resultChange.AutoSize = true;
            this.resultChange.Location = new System.Drawing.Point(128, 56);
            this.resultChange.Name = "resultChange";
            this.resultChange.Size = new System.Drawing.Size(71, 13);
            this.resultChange.TabIndex = 2;
            this.resultChange.Text = "result change";
            // 
            // SensitivityResultSingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.resultChange);
            this.Controls.Add(this.result);
            this.Controls.Add(this.inputValues);
            this.Controls.Add(this.title);
            this.Name = "SensitivityResultSingle";
            this.Size = new System.Drawing.Size(298, 148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label inputValues;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label resultChange;
    }
}
