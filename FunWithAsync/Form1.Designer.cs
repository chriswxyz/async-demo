namespace FunWithAsync
{
    partial class Form1
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
            this.CounterButton = new System.Windows.Forms.Button();
            this.ClickTracker = new System.Windows.Forms.Label();
            this.DownloadBlocking = new System.Windows.Forms.Button();
            this.DownloadAsync = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ComputeBlocking = new System.Windows.Forms.Button();
            this.ComputeAsync = new System.Windows.Forms.Button();
            this.ResultArea = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CounterButton
            // 
            this.CounterButton.Location = new System.Drawing.Point(12, 12);
            this.CounterButton.Name = "CounterButton";
            this.CounterButton.Size = new System.Drawing.Size(146, 33);
            this.CounterButton.TabIndex = 0;
            this.CounterButton.Text = "Click me!!";
            this.CounterButton.UseVisualStyleBackColor = true;
            this.CounterButton.Click += new System.EventHandler(this.CounterButton_Click);
            // 
            // ClickTracker
            // 
            this.ClickTracker.AutoSize = true;
            this.ClickTracker.Location = new System.Drawing.Point(12, 48);
            this.ClickTracker.Name = "ClickTracker";
            this.ClickTracker.Size = new System.Drawing.Size(47, 13);
            this.ClickTracker.TabIndex = 1;
            this.ClickTracker.Text = "Clicks: 0";
            // 
            // DownloadBlocking
            // 
            this.DownloadBlocking.Location = new System.Drawing.Point(349, 13);
            this.DownloadBlocking.Name = "DownloadBlocking";
            this.DownloadBlocking.Size = new System.Drawing.Size(155, 32);
            this.DownloadBlocking.TabIndex = 2;
            this.DownloadBlocking.Text = "Download a file (blocking)";
            this.DownloadBlocking.UseVisualStyleBackColor = true;
            this.DownloadBlocking.Click += new System.EventHandler(this.DownloadBlocking_Click);
            // 
            // DownloadAsync
            // 
            this.DownloadAsync.Location = new System.Drawing.Point(349, 51);
            this.DownloadAsync.Name = "DownloadAsync";
            this.DownloadAsync.Size = new System.Drawing.Size(155, 32);
            this.DownloadAsync.TabIndex = 3;
            this.DownloadAsync.Text = "Download a file (async)";
            this.DownloadAsync.UseVisualStyleBackColor = true;
            this.DownloadAsync.Click += new System.EventHandler(this.DownloadAsync_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 246);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(489, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 4;
            // 
            // ComputeBlocking
            // 
            this.ComputeBlocking.Location = new System.Drawing.Point(349, 125);
            this.ComputeBlocking.Name = "ComputeBlocking";
            this.ComputeBlocking.Size = new System.Drawing.Size(155, 32);
            this.ComputeBlocking.TabIndex = 5;
            this.ComputeBlocking.Text = "Do some math (blocking)";
            this.ComputeBlocking.UseVisualStyleBackColor = true;
            this.ComputeBlocking.Click += new System.EventHandler(this.ComputeBlocking_Click);
            // 
            // ComputeAsync
            // 
            this.ComputeAsync.Location = new System.Drawing.Point(349, 163);
            this.ComputeAsync.Name = "ComputeAsync";
            this.ComputeAsync.Size = new System.Drawing.Size(155, 32);
            this.ComputeAsync.TabIndex = 6;
            this.ComputeAsync.Text = "Do some math (async)";
            this.ComputeAsync.UseVisualStyleBackColor = true;
            this.ComputeAsync.Click += new System.EventHandler(this.ComputeAsync_Click);
            // 
            // ResultArea
            // 
            this.ResultArea.Location = new System.Drawing.Point(12, 76);
            this.ResultArea.Multiline = true;
            this.ResultArea.Name = "ResultArea";
            this.ResultArea.Size = new System.Drawing.Size(311, 119);
            this.ResultArea.TabIndex = 7;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 201);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(86, 27);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 281);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ResultArea);
            this.Controls.Add(this.ComputeAsync);
            this.Controls.Add(this.ComputeBlocking);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.DownloadAsync);
            this.Controls.Add(this.DownloadBlocking);
            this.Controls.Add(this.ClickTracker);
            this.Controls.Add(this.CounterButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CounterButton;
        private System.Windows.Forms.Label ClickTracker;
        private System.Windows.Forms.Button DownloadBlocking;
        private System.Windows.Forms.Button DownloadAsync;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button ComputeBlocking;
        private System.Windows.Forms.Button ComputeAsync;
        private System.Windows.Forms.TextBox ResultArea;
        private System.Windows.Forms.Button ClearButton;
    }
}

