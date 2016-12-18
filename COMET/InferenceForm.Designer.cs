namespace COMET
{
    partial class InferenceForm
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
            this.checkButton = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.plotsGroupBox = new System.Windows.Forms.GroupBox();
            this.plotsPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.plotsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(852, 387);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(100, 23);
            this.checkButton.TabIndex = 0;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Location = new System.Drawing.Point(12, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(468, 13);
            this.header.TabIndex = 1;
            this.header.Text = "To evaluate a single object, enter the value of each of the criteria, and then cl" +
    "ick \"Check\" button.";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(900, 416);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(52, 20);
            this.resultTextBox.TabIndex = 2;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(849, 419);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 13);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Result";
            // 
            // plotsGroupBox
            // 
            this.plotsGroupBox.Controls.Add(this.plotsPanel);
            this.plotsGroupBox.Location = new System.Drawing.Point(12, 35);
            this.plotsGroupBox.Name = "plotsGroupBox";
            this.plotsGroupBox.Size = new System.Drawing.Size(940, 346);
            this.plotsGroupBox.TabIndex = 4;
            this.plotsGroupBox.TabStop = false;
            // 
            // plotsPanel
            // 
            this.plotsPanel.AutoScroll = true;
            this.plotsPanel.Location = new System.Drawing.Point(6, 9);
            this.plotsPanel.Name = "plotsPanel";
            this.plotsPanel.Size = new System.Drawing.Size(928, 331);
            this.plotsPanel.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(18, 387);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "<- Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // InferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 638);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.plotsGroupBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.header);
            this.Controls.Add(this.checkButton);
            this.MaximumSize = new System.Drawing.Size(983, 677);
            this.MinimumSize = new System.Drawing.Size(983, 677);
            this.Name = "InferenceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InferenceForm";
            this.plotsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.GroupBox plotsGroupBox;
        private System.Windows.Forms.Panel plotsPanel;
        private System.Windows.Forms.Button backButton;
    }
}