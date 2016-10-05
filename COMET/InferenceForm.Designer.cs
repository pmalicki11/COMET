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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(387, 182);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(435, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 2;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(384, 214);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 13);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Result";
            // 
            // InferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 243);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.checkButton);
            this.Name = "InferenceForm";
            this.Text = "InferenceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label resultLabel;
    }
}