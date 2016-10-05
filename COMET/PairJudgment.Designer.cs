namespace COMET
{
    partial class pairJudgment
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
            this.leftGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.leftText = new System.Windows.Forms.Label();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.rightGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rightText = new System.Windows.Forms.Label();
            this.skipButton = new System.Windows.Forms.Button();
            this.pairsLeftLabel = new System.Windows.Forms.Label();
            this.totalObjectsLabel = new System.Windows.Forms.Label();
            this.judgmentCompleteLabel = new System.Windows.Forms.Label();
            this.saveToFile = new System.Windows.Forms.Button();
            this.leftGroupBox.SuspendLayout();
            this.rightGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftGroupBox
            // 
            this.leftGroupBox.Controls.Add(this.label1);
            this.leftGroupBox.Controls.Add(this.leftText);
            this.leftGroupBox.Location = new System.Drawing.Point(3, 3);
            this.leftGroupBox.Name = "leftGroupBox";
            this.leftGroupBox.Size = new System.Drawing.Size(208, 251);
            this.leftGroupBox.TabIndex = 0;
            this.leftGroupBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(40, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Characteristic object";
            // 
            // leftText
            // 
            this.leftText.AutoSize = true;
            this.leftText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftText.Location = new System.Drawing.Point(7, 48);
            this.leftText.Name = "leftText";
            this.leftText.Size = new System.Drawing.Size(130, 80);
            this.leftText.TabIndex = 0;
            this.leftText.Text = "Height: 190\r\nWeight: 90\r\nHair length: short\r\nEye color: green";
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(65, 260);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 23);
            this.leftButton.TabIndex = 1;
            this.leftButton.Text = "Choose";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(353, 260);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 23);
            this.rightButton.TabIndex = 3;
            this.rightButton.Text = "Choose";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // rightGroupBox
            // 
            this.rightGroupBox.Controls.Add(this.label2);
            this.rightGroupBox.Controls.Add(this.rightText);
            this.rightGroupBox.Location = new System.Drawing.Point(291, 3);
            this.rightGroupBox.Name = "rightGroupBox";
            this.rightGroupBox.Size = new System.Drawing.Size(208, 251);
            this.rightGroupBox.TabIndex = 2;
            this.rightGroupBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(39, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Characteristic object";
            // 
            // rightText
            // 
            this.rightText.AutoSize = true;
            this.rightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rightText.Location = new System.Drawing.Point(6, 48);
            this.rightText.Name = "rightText";
            this.rightText.Size = new System.Drawing.Size(150, 80);
            this.rightText.TabIndex = 1;
            this.rightText.Text = "Height: 180\r\nWeight: 90\r\nHair length: medium\r\nEye color: green";
            // 
            // skipButton
            // 
            this.skipButton.Location = new System.Drawing.Point(214, 260);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(75, 23);
            this.skipButton.TabIndex = 4;
            this.skipButton.Text = "Skip";
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // pairsLeftLabel
            // 
            this.pairsLeftLabel.AutoSize = true;
            this.pairsLeftLabel.Location = new System.Drawing.Point(225, 51);
            this.pairsLeftLabel.Name = "pairsLeftLabel";
            this.pairsLeftLabel.Size = new System.Drawing.Size(50, 13);
            this.pairsLeftLabel.TabIndex = 5;
            this.pairsLeftLabel.Text = "Pairs left:";
            this.pairsLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalObjectsLabel
            // 
            this.totalObjectsLabel.AutoSize = true;
            this.totalObjectsLabel.Location = new System.Drawing.Point(216, 9);
            this.totalObjectsLabel.Name = "totalObjectsLabel";
            this.totalObjectsLabel.Size = new System.Drawing.Size(71, 13);
            this.totalObjectsLabel.TabIndex = 5;
            this.totalObjectsLabel.Text = "Total objects:";
            this.totalObjectsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // judgmentCompleteLabel
            // 
            this.judgmentCompleteLabel.AutoSize = true;
            this.judgmentCompleteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.judgmentCompleteLabel.Location = new System.Drawing.Point(190, 113);
            this.judgmentCompleteLabel.Name = "judgmentCompleteLabel";
            this.judgmentCompleteLabel.Size = new System.Drawing.Size(129, 32);
            this.judgmentCompleteLabel.TabIndex = 6;
            this.judgmentCompleteLabel.Text = "Judgment complete!\r\nPress next.";
            this.judgmentCompleteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.judgmentCompleteLabel.Visible = false;
            // 
            // saveToFile
            // 
            this.saveToFile.Location = new System.Drawing.Point(214, 289);
            this.saveToFile.Name = "saveToFile";
            this.saveToFile.Size = new System.Drawing.Size(75, 43);
            this.saveToFile.TabIndex = 4;
            this.saveToFile.Text = "Save actual results";
            this.saveToFile.UseVisualStyleBackColor = true;
            this.saveToFile.Click += new System.EventHandler(this.saveToFile_Click);
            // 
            // pairJudgment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.judgmentCompleteLabel);
            this.Controls.Add(this.totalObjectsLabel);
            this.Controls.Add(this.pairsLeftLabel);
            this.Controls.Add(this.saveToFile);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.rightGroupBox);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.leftGroupBox);
            this.Name = "pairJudgment";
            this.Size = new System.Drawing.Size(502, 347);
            this.leftGroupBox.ResumeLayout(false);
            this.leftGroupBox.PerformLayout();
            this.rightGroupBox.ResumeLayout(false);
            this.rightGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox leftGroupBox;
        private System.Windows.Forms.Label leftText;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.GroupBox rightGroupBox;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.Label rightText;
        private System.Windows.Forms.Label pairsLeftLabel;
        private System.Windows.Forms.Label totalObjectsLabel;
        private System.Windows.Forms.Label judgmentCompleteLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveToFile;
    }
}
