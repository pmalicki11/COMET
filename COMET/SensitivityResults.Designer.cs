namespace COMET
{
    partial class SensitivityResults
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
            this.resultsPanel = new System.Windows.Forms.Panel();
            this.baseResult = new COMET.SensitivityResultSingle();
            this.SuspendLayout();
            // 
            // resultsPanel
            // 
            this.resultsPanel.AutoScroll = true;
            this.resultsPanel.Location = new System.Drawing.Point(317, 12);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(311, 373);
            this.resultsPanel.TabIndex = 0;
            // 
            // baseResult
            // 
            this.baseResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baseResult.Input = "input";
            this.baseResult.Location = new System.Drawing.Point(12, 12);
            this.baseResult.Name = "baseResult";
            this.baseResult.Result = "Result: Result: Result: Result: Result: Result: Result: Result: Result: Result: r" +
    "esult";
            this.baseResult.ResultChange = "Result change: Result change: Result change: Result change: Result change: Result" +
    " change: Result change: Result change: Result change: Result change: result chan" +
    "ge%%%%%%%%%%";
            this.baseResult.Size = new System.Drawing.Size(300, 150);
            this.baseResult.TabIndex = 1;
            this.baseResult.Title = "title";
            // 
            // SensitivityResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 397);
            this.Controls.Add(this.baseResult);
            this.Controls.Add(this.resultsPanel);
            this.Name = "SensitivityResults";
            this.Text = "Sensitivity Results";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel resultsPanel;
        private SensitivityResultSingle baseResult;
    }
}