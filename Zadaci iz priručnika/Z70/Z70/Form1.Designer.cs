namespace Z70
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
            this.lblTrVrijeme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTrVrijeme
            // 
            this.lblTrVrijeme.AutoSize = true;
            this.lblTrVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrVrijeme.Location = new System.Drawing.Point(92, 119);
            this.lblTrVrijeme.Name = "lblTrVrijeme";
            this.lblTrVrijeme.Size = new System.Drawing.Size(94, 26);
            this.lblTrVrijeme.TabIndex = 0;
            this.lblTrVrijeme.Text = "Vrijeme";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 261);
            this.Controls.Add(this.lblTrVrijeme);
            this.Name = "Form1";
            this.Text = "Prikaz trenutnog vremena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTrVrijeme;
    }
}

