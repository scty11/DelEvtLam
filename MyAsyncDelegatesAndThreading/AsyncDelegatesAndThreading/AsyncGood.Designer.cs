namespace ThreadsAndDelegates
{
    partial class AsyncGood
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.pbStatus = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(178, 32);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(100, 23);
            this.lblOutput.TabIndex = 11;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(26, 32);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Start";
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // pbStatus
            // 
            this.pbStatus.Location = new System.Drawing.Point(26, 96);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(264, 23);
            this.pbStatus.TabIndex = 9;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(134, 32);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(196, 23);
            this.progressBar1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            // 
            // AsyncGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 150);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.pbStatus);
            this.Name = "AsyncGood";
            this.Text = "AsyncGood";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ProgressBar pbStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
    }
}