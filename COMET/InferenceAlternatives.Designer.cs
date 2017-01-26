namespace COMET
{
    partial class InferenceAlternatives
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
            this.label1 = new System.Windows.Forms.Label();
            this.numOfAlternatives = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.loadFromFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numOfAlternatives)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of alternatives (2 - 25)";
            // 
            // numOfAlternatives
            // 
            this.numOfAlternatives.Location = new System.Drawing.Point(180, 27);
            this.numOfAlternatives.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numOfAlternatives.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numOfAlternatives.Name = "numOfAlternatives";
            this.numOfAlternatives.Size = new System.Drawing.Size(47, 20);
            this.numOfAlternatives.TabIndex = 1;
            this.numOfAlternatives.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(233, 24);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // loadFromFile
            // 
            this.loadFromFile.Location = new System.Drawing.Point(120, 84);
            this.loadFromFile.Name = "loadFromFile";
            this.loadFromFile.Size = new System.Drawing.Size(83, 23);
            this.loadFromFile.TabIndex = 2;
            this.loadFromFile.Text = "Load from file";
            this.loadFromFile.UseVisualStyleBackColor = true;
            this.loadFromFile.Click += new System.EventHandler(this.loadFromFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Or";
            // 
            // InferenceAlternatives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 119);
            this.Controls.Add(this.loadFromFile);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.numOfAlternatives);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InferenceAlternatives";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inference alternatives";
            ((System.ComponentModel.ISupportInitialize)(this.numOfAlternatives)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numOfAlternatives;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button loadFromFile;
        private System.Windows.Forms.Label label2;
    }
}