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
            this.checkSingleButton = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.plotsGroupBox = new System.Windows.Forms.GroupBox();
            this.plotsPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.standartInference = new System.Windows.Forms.TabPage();
            this.standardInferencePanel = new System.Windows.Forms.Panel();
            this.multipleInference = new System.Windows.Forms.TabPage();
            this.multipleInferencePanel = new System.Windows.Forms.Panel();
            this.checkMultipleButton = new System.Windows.Forms.Button();
            this.plotsGroupBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.standartInference.SuspendLayout();
            this.standardInferencePanel.SuspendLayout();
            this.multipleInference.SuspendLayout();
            this.multipleInferencePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkSingleButton
            // 
            this.checkSingleButton.Location = new System.Drawing.Point(829, 6);
            this.checkSingleButton.Name = "checkSingleButton";
            this.checkSingleButton.Size = new System.Drawing.Size(100, 23);
            this.checkSingleButton.TabIndex = 0;
            this.checkSingleButton.Text = "Check";
            this.checkSingleButton.UseVisualStyleBackColor = true;
            this.checkSingleButton.Click += new System.EventHandler(this.checkSingleButton_Click);
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
            this.resultTextBox.Location = new System.Drawing.Point(877, 35);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(52, 20);
            this.resultTextBox.TabIndex = 2;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(826, 38);
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
            this.backButton.Location = new System.Drawing.Point(12, 603);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "<- Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.standartInference);
            this.tabControl.Controls.Add(this.multipleInference);
            this.tabControl.Location = new System.Drawing.Point(12, 387);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(943, 210);
            this.tabControl.TabIndex = 5;
            // 
            // standartInference
            // 
            this.standartInference.Controls.Add(this.standardInferencePanel);
            this.standartInference.Location = new System.Drawing.Point(4, 22);
            this.standartInference.Name = "standartInference";
            this.standartInference.Padding = new System.Windows.Forms.Padding(3);
            this.standartInference.Size = new System.Drawing.Size(935, 184);
            this.standartInference.TabIndex = 0;
            this.standartInference.Text = "Standard inference";
            this.standartInference.UseVisualStyleBackColor = true;
            // 
            // standardInferencePanel
            // 
            this.standardInferencePanel.AutoScroll = true;
            this.standardInferencePanel.Controls.Add(this.checkSingleButton);
            this.standardInferencePanel.Controls.Add(this.resultLabel);
            this.standardInferencePanel.Controls.Add(this.resultTextBox);
            this.standardInferencePanel.Location = new System.Drawing.Point(0, 0);
            this.standardInferencePanel.Name = "standardInferencePanel";
            this.standardInferencePanel.Size = new System.Drawing.Size(935, 184);
            this.standardInferencePanel.TabIndex = 4;
            // 
            // multipleInference
            // 
            this.multipleInference.Controls.Add(this.multipleInferencePanel);
            this.multipleInference.Location = new System.Drawing.Point(4, 22);
            this.multipleInference.Name = "multipleInference";
            this.multipleInference.Padding = new System.Windows.Forms.Padding(3);
            this.multipleInference.Size = new System.Drawing.Size(935, 184);
            this.multipleInference.TabIndex = 1;
            this.multipleInference.Text = "Multiple inference";
            this.multipleInference.UseVisualStyleBackColor = true;
            this.multipleInference.Enter += new System.EventHandler(this.multipleInference_Enter);
            // 
            // multipleInferencePanel
            // 
            this.multipleInferencePanel.AutoScroll = true;
            this.multipleInferencePanel.Controls.Add(this.checkMultipleButton);
            this.multipleInferencePanel.Location = new System.Drawing.Point(0, 0);
            this.multipleInferencePanel.Name = "multipleInferencePanel";
            this.multipleInferencePanel.Size = new System.Drawing.Size(936, 184);
            this.multipleInferencePanel.TabIndex = 0;
            // 
            // checkMultipleButton
            // 
            this.checkMultipleButton.Location = new System.Drawing.Point(829, 6);
            this.checkMultipleButton.Name = "checkMultipleButton";
            this.checkMultipleButton.Size = new System.Drawing.Size(100, 23);
            this.checkMultipleButton.TabIndex = 1;
            this.checkMultipleButton.Text = "Check";
            this.checkMultipleButton.UseVisualStyleBackColor = true;
            this.checkMultipleButton.Click += new System.EventHandler(this.checkMultipleButton_Click);
            // 
            // InferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 638);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.plotsGroupBox);
            this.Controls.Add(this.header);
            this.MaximumSize = new System.Drawing.Size(983, 677);
            this.MinimumSize = new System.Drawing.Size(983, 677);
            this.Name = "InferenceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InferenceForm";
            this.plotsGroupBox.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.standartInference.ResumeLayout(false);
            this.standardInferencePanel.ResumeLayout(false);
            this.standardInferencePanel.PerformLayout();
            this.multipleInference.ResumeLayout(false);
            this.multipleInferencePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkSingleButton;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.GroupBox plotsGroupBox;
        private System.Windows.Forms.Panel plotsPanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage standartInference;
        private System.Windows.Forms.TabPage multipleInference;
        private System.Windows.Forms.Panel standardInferencePanel;
        private System.Windows.Forms.Panel multipleInferencePanel;
        private System.Windows.Forms.Button checkMultipleButton;
    }
}