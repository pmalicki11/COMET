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
            this.plotsGroupBox = new System.Windows.Forms.GroupBox();
            this.plotsPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.standartInference = new System.Windows.Forms.TabPage();
            this.standardInferencePanel = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.sensitivityGraph = new System.Windows.Forms.Button();
            this.checkSensitivity = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.changeNumeric = new System.Windows.Forms.NumericUpDown();
            this.multipleInference = new System.Windows.Forms.TabPage();
            this.multipleInferencePanel = new System.Windows.Forms.Panel();
            this.saveMultipleResultsButton = new System.Windows.Forms.Button();
            this.checkMultipleButton = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.plotsGroupBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.standartInference.SuspendLayout();
            this.standardInferencePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeNumeric)).BeginInit();
            this.multipleInference.SuspendLayout();
            this.multipleInferencePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkSingleButton
            // 
            this.checkSingleButton.Location = new System.Drawing.Point(347, 9);
            this.checkSingleButton.Name = "checkSingleButton";
            this.checkSingleButton.Size = new System.Drawing.Size(100, 23);
            this.checkSingleButton.TabIndex = 0;
            this.checkSingleButton.Text = "Check result";
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
            this.resultTextBox.Location = new System.Drawing.Point(347, 36);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(100, 20);
            this.resultTextBox.TabIndex = 2;
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
            this.standardInferencePanel.Controls.Add(this.progressLabel);
            this.standardInferencePanel.Controls.Add(this.progressBar);
            this.standardInferencePanel.Controls.Add(this.checkedListBox);
            this.standardInferencePanel.Controls.Add(this.sensitivityGraph);
            this.standardInferencePanel.Controls.Add(this.checkSensitivity);
            this.standardInferencePanel.Controls.Add(this.label2);
            this.standardInferencePanel.Controls.Add(this.label1);
            this.standardInferencePanel.Controls.Add(this.changeNumeric);
            this.standardInferencePanel.Controls.Add(this.checkSingleButton);
            this.standardInferencePanel.Controls.Add(this.resultTextBox);
            this.standardInferencePanel.Location = new System.Drawing.Point(0, 0);
            this.standardInferencePanel.Name = "standardInferencePanel";
            this.standardInferencePanel.Size = new System.Drawing.Size(935, 184);
            this.standardInferencePanel.TabIndex = 4;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(660, 123);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(132, 23);
            this.progressBar.TabIndex = 10;
            // 
            // checkedListBox
            // 
            this.checkedListBox.CheckOnClick = true;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(660, 38);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(132, 79);
            this.checkedListBox.TabIndex = 9;
            // 
            // sensitivityGraph
            // 
            this.sensitivityGraph.Location = new System.Drawing.Point(660, 9);
            this.sensitivityGraph.Name = "sensitivityGraph";
            this.sensitivityGraph.Size = new System.Drawing.Size(132, 23);
            this.sensitivityGraph.TabIndex = 8;
            this.sensitivityGraph.Text = "Sensitivity graph";
            this.sensitivityGraph.UseVisualStyleBackColor = true;
            this.sensitivityGraph.Click += new System.EventHandler(this.sensitivityGraph_Click);
            // 
            // checkSensitivity
            // 
            this.checkSensitivity.Location = new System.Drawing.Point(502, 9);
            this.checkSensitivity.Name = "checkSensitivity";
            this.checkSensitivity.Size = new System.Drawing.Size(100, 23);
            this.checkSensitivity.TabIndex = 8;
            this.checkSensitivity.Text = "Check sensitivity";
            this.checkSensitivity.UseVisualStyleBackColor = true;
            this.checkSensitivity.Click += new System.EventHandler(this.checkSensitivity_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Change";
            // 
            // changeNumeric
            // 
            this.changeNumeric.Location = new System.Drawing.Point(543, 36);
            this.changeNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.changeNumeric.Name = "changeNumeric";
            this.changeNumeric.Size = new System.Drawing.Size(43, 20);
            this.changeNumeric.TabIndex = 5;
            this.changeNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.multipleInferencePanel.Controls.Add(this.saveMultipleResultsButton);
            this.multipleInferencePanel.Controls.Add(this.checkMultipleButton);
            this.multipleInferencePanel.Location = new System.Drawing.Point(0, 0);
            this.multipleInferencePanel.Name = "multipleInferencePanel";
            this.multipleInferencePanel.Size = new System.Drawing.Size(936, 184);
            this.multipleInferencePanel.TabIndex = 0;
            // 
            // saveMultipleResultsButton
            // 
            this.saveMultipleResultsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveMultipleResultsButton.Location = new System.Drawing.Point(815, 35);
            this.saveMultipleResultsButton.Name = "saveMultipleResultsButton";
            this.saveMultipleResultsButton.Size = new System.Drawing.Size(100, 23);
            this.saveMultipleResultsButton.TabIndex = 2;
            this.saveMultipleResultsButton.Text = "Save to file";
            this.saveMultipleResultsButton.UseVisualStyleBackColor = true;
            this.saveMultipleResultsButton.Click += new System.EventHandler(this.saveMultipleResultsButton_Click);
            // 
            // checkMultipleButton
            // 
            this.checkMultipleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkMultipleButton.Location = new System.Drawing.Point(815, 6);
            this.checkMultipleButton.Name = "checkMultipleButton";
            this.checkMultipleButton.Size = new System.Drawing.Size(100, 23);
            this.checkMultipleButton.TabIndex = 1;
            this.checkMultipleButton.Text = "Check";
            this.checkMultipleButton.UseVisualStyleBackColor = true;
            this.checkMultipleButton.Click += new System.EventHandler(this.checkMultipleButton_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(662, 149);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(35, 13);
            this.progressLabel.TabIndex = 11;
            this.progressLabel.Text = "label3";
            this.progressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            ((System.ComponentModel.ISupportInitialize)(this.changeNumeric)).EndInit();
            this.multipleInference.ResumeLayout(false);
            this.multipleInferencePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkSingleButton;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.GroupBox plotsGroupBox;
        private System.Windows.Forms.Panel plotsPanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage standartInference;
        private System.Windows.Forms.TabPage multipleInference;
        private System.Windows.Forms.Panel standardInferencePanel;
        private System.Windows.Forms.Panel multipleInferencePanel;
        private System.Windows.Forms.Button checkMultipleButton;
        private System.Windows.Forms.Button saveMultipleResultsButton;
        private System.Windows.Forms.Button checkSensitivity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown changeNumeric;
        private System.Windows.Forms.Button sensitivityGraph;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progressLabel;
    }
}