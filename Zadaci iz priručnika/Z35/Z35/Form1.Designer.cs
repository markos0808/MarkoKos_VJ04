namespace Z35
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
            this.progressBarX = new System.Windows.Forms.ProgressBar();
            this.progressBarY = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // progressBarX
            // 
            this.progressBarX.Location = new System.Drawing.Point(12, 12);
            this.progressBarX.Name = "progressBarX";
            this.progressBarX.Size = new System.Drawing.Size(100, 23);
            this.progressBarX.TabIndex = 0;
            // 
            // progressBarY
            // 
            this.progressBarY.Location = new System.Drawing.Point(172, 12);
            this.progressBarY.Name = "progressBarY";
            this.progressBarY.Size = new System.Drawing.Size(100, 23);
            this.progressBarY.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.progressBarY);
            this.Controls.Add(this.progressBarX);
            this.Name = "Form1";
            this.Text = "Koordinate miša";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ProgressBar progressBarX;
        public System.Windows.Forms.ProgressBar progressBarY;

    }
}

