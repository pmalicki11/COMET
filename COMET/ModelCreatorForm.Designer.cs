namespace COMET
{
    partial class ModelCreatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelCreatorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.creatorPanel = new System.Windows.Forms.Panel();
            this.creatorNextButton = new System.Windows.Forms.Button();
            this.valLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.judgmentPanel = new System.Windows.Forms.Panel();
            this.judgmentNextButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.judgmentResultsPanel = new System.Windows.Forms.Panel();
            this.inferenceButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.judgmentResultsContent = new System.Windows.Forms.Label();
            this.resultsHeaderLabel = new System.Windows.Forms.Label();
            this.backToMenuButton = new System.Windows.Forms.Button();
            this.firstCriterionControl = new COMET.CriterionControl();
            this.creatorPanel.SuspendLayout();
            this.judgmentPanel.SuspendLayout();
            this.judgmentResultsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Define criteria";
            // 
            // creatorPanel
            // 
            this.creatorPanel.AutoScroll = true;
            this.creatorPanel.Controls.Add(this.firstCriterionControl);
            this.creatorPanel.Controls.Add(this.creatorNextButton);
            this.creatorPanel.Controls.Add(this.valLabel);
            this.creatorPanel.Controls.Add(this.nameLabel);
            this.creatorPanel.Controls.Add(this.label2);
            this.creatorPanel.Controls.Add(this.label1);
            this.creatorPanel.Location = new System.Drawing.Point(12, 12);
            this.creatorPanel.Name = "creatorPanel";
            this.creatorPanel.Size = new System.Drawing.Size(760, 537);
            this.creatorPanel.TabIndex = 0;
            // 
            // creatorNextButton
            // 
            this.creatorNextButton.Location = new System.Drawing.Point(682, 511);
            this.creatorNextButton.Name = "creatorNextButton";
            this.creatorNextButton.Size = new System.Drawing.Size(75, 23);
            this.creatorNextButton.TabIndex = 7;
            this.creatorNextButton.Text = "Next >";
            this.creatorNextButton.UseVisualStyleBackColor = true;
            this.creatorNextButton.Click += new System.EventHandler(this.creatorNextButton_Click);
            // 
            // valLabel
            // 
            this.valLabel.AutoSize = true;
            this.valLabel.Location = new System.Drawing.Point(213, 83);
            this.valLabel.Name = "valLabel";
            this.valLabel.Size = new System.Drawing.Size(105, 13);
            this.valLabel.TabIndex = 6;
            this.valLabel.Text = "Characteristic values";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(48, 83);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(74, 13);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Criterion name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter at least 2 criteria and their characteristic values separated by commas(,)." +
    " Then press Next >.\r\nIf you want to set a real number then use dot (.) to separa" +
    "te rational numbers and the fraction.";
            // 
            // judgmentPanel
            // 
            this.judgmentPanel.Controls.Add(this.judgmentNextButton);
            this.judgmentPanel.Controls.Add(this.label3);
            this.judgmentPanel.Controls.Add(this.label4);
            this.judgmentPanel.Location = new System.Drawing.Point(12, 12);
            this.judgmentPanel.Name = "judgmentPanel";
            this.judgmentPanel.Size = new System.Drawing.Size(760, 537);
            this.judgmentPanel.TabIndex = 1;
            this.judgmentPanel.Visible = false;
            // 
            // judgmentNextButton
            // 
            this.judgmentNextButton.Location = new System.Drawing.Point(682, 511);
            this.judgmentNextButton.Name = "judgmentNextButton";
            this.judgmentNextButton.Size = new System.Drawing.Size(75, 23);
            this.judgmentNextButton.TabIndex = 10;
            this.judgmentNextButton.Text = "Next >";
            this.judgmentNextButton.UseVisualStyleBackColor = true;
            this.judgmentNextButton.Click += new System.EventHandler(this.judgmentNextButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(18, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(719, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Judgment";
            // 
            // judgmentResultsPanel
            // 
            this.judgmentResultsPanel.AutoScroll = true;
            this.judgmentResultsPanel.Controls.Add(this.inferenceButton);
            this.judgmentResultsPanel.Controls.Add(this.saveButton);
            this.judgmentResultsPanel.Controls.Add(this.judgmentResultsContent);
            this.judgmentResultsPanel.Controls.Add(this.resultsHeaderLabel);
            this.judgmentResultsPanel.Location = new System.Drawing.Point(12, 12);
            this.judgmentResultsPanel.Name = "judgmentResultsPanel";
            this.judgmentResultsPanel.Size = new System.Drawing.Size(760, 537);
            this.judgmentResultsPanel.TabIndex = 2;
            // 
            // inferenceButton
            // 
            this.inferenceButton.Location = new System.Drawing.Point(635, 83);
            this.inferenceButton.Name = "inferenceButton";
            this.inferenceButton.Size = new System.Drawing.Size(120, 50);
            this.inferenceButton.TabIndex = 10;
            this.inferenceButton.Text = "Inference at this model";
            this.inferenceButton.UseVisualStyleBackColor = true;
            this.inferenceButton.Click += new System.EventHandler(this.inferenceButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(635, 30);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 50);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save base to file";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // judgmentResultsContent
            // 
            this.judgmentResultsContent.AutoSize = true;
            this.judgmentResultsContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.judgmentResultsContent.Location = new System.Drawing.Point(3, 30);
            this.judgmentResultsContent.Name = "judgmentResultsContent";
            this.judgmentResultsContent.Size = new System.Drawing.Size(47, 16);
            this.judgmentResultsContent.TabIndex = 8;
            this.judgmentResultsContent.Text = "results";
            // 
            // resultsHeaderLabel
            // 
            this.resultsHeaderLabel.AutoSize = true;
            this.resultsHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultsHeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.resultsHeaderLabel.Name = "resultsHeaderLabel";
            this.resultsHeaderLabel.Size = new System.Drawing.Size(247, 20);
            this.resultsHeaderLabel.TabIndex = 7;
            this.resultsHeaderLabel.Text = "Judement results (rules base)";
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.Location = new System.Drawing.Point(14, 523);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(101, 23);
            this.backToMenuButton.TabIndex = 3;
            this.backToMenuButton.Text = "< Back to menu";
            this.backToMenuButton.UseVisualStyleBackColor = true;
            this.backToMenuButton.Click += new System.EventHandler(this.backToMenuButton_Click);
            // 
            // firstCriterionControl
            // 
            this.firstCriterionControl.Location = new System.Drawing.Point(25, 99);
            this.firstCriterionControl.Name = "firstCriterionControl";
            this.firstCriterionControl.Size = new System.Drawing.Size(421, 26);
            this.firstCriterionControl.TabIndex = 8;
            // 
            // ModelCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.backToMenuButton);
            this.Controls.Add(this.creatorPanel);
            this.Controls.Add(this.judgmentResultsPanel);
            this.Controls.Add(this.judgmentPanel);
            this.Name = "ModelCreatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Model creator";
            this.creatorPanel.ResumeLayout(false);
            this.creatorPanel.PerformLayout();
            this.judgmentPanel.ResumeLayout(false);
            this.judgmentPanel.PerformLayout();
            this.judgmentResultsPanel.ResumeLayout(false);
            this.judgmentResultsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel creatorPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label valLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button creatorNextButton;
        private CriterionControl firstCriterionControl;
        private System.Windows.Forms.Panel judgmentPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button judgmentNextButton;
        private System.Windows.Forms.Panel judgmentResultsPanel;
        private System.Windows.Forms.Label resultsHeaderLabel;
        private System.Windows.Forms.Label judgmentResultsContent;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button backToMenuButton;
        private System.Windows.Forms.Button inferenceButton;



    }
}

