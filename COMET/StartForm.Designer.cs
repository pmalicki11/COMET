namespace COMET
{
    partial class StartForm
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
            this.createModelButton = new System.Windows.Forms.Button();
            this.loadModelButton = new System.Windows.Forms.Button();
            this.inferenceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // createModelButton
            // 
            this.createModelButton.Location = new System.Drawing.Point(16, 79);
            this.createModelButton.Name = "createModelButton";
            this.createModelButton.Size = new System.Drawing.Size(130, 50);
            this.createModelButton.TabIndex = 1;
            this.createModelButton.Text = "Create new model";
            this.createModelButton.UseVisualStyleBackColor = true;
            this.createModelButton.Click += new System.EventHandler(this.createModelButton_Click);
            // 
            // loadModelButton
            // 
            this.loadModelButton.Location = new System.Drawing.Point(152, 79);
            this.loadModelButton.Name = "loadModelButton";
            this.loadModelButton.Size = new System.Drawing.Size(130, 50);
            this.loadModelButton.TabIndex = 2;
            this.loadModelButton.Text = "Load incompleted model";
            this.loadModelButton.UseVisualStyleBackColor = true;
            this.loadModelButton.Click += new System.EventHandler(this.loadModelButton_Click);
            // 
            // inferenceButton
            // 
            this.inferenceButton.Location = new System.Drawing.Point(288, 79);
            this.inferenceButton.Name = "inferenceButton";
            this.inferenceButton.Size = new System.Drawing.Size(130, 50);
            this.inferenceButton.TabIndex = 3;
            this.inferenceButton.Text = "Inference at pre-defined model";
            this.inferenceButton.UseVisualStyleBackColor = true;
            this.inferenceButton.Click += new System.EventHandler(this.inferenceButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 169);
            this.Controls.Add(this.inferenceButton);
            this.Controls.Add(this.loadModelButton);
            this.Controls.Add(this.createModelButton);
            this.Controls.Add(this.label1);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createModelButton;
        private System.Windows.Forms.Button loadModelButton;
        private System.Windows.Forms.Button inferenceButton;
    }
}