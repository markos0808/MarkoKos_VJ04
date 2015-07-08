namespace Z48
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
            this.btnProvjeri = new System.Windows.Forms.Button();
            this.txtRijec = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnProvjeri
            // 
            this.btnProvjeri.Location = new System.Drawing.Point(97, 148);
            this.btnProvjeri.Name = "btnProvjeri";
            this.btnProvjeri.Size = new System.Drawing.Size(75, 23);
            this.btnProvjeri.TabIndex = 0;
            this.btnProvjeri.Text = "Provjeri";
            this.btnProvjeri.UseVisualStyleBackColor = true;
            this.btnProvjeri.Click += new System.EventHandler(this.btnProvjeri_Click);
            // 
            // txtRijec
            // 
            this.txtRijec.Location = new System.Drawing.Point(84, 97);
            this.txtRijec.Name = "txtRijec";
            this.txtRijec.Size = new System.Drawing.Size(100, 20);
            this.txtRijec.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtRijec);
            this.Controls.Add(this.btnProvjeri);
            this.Name = "Form1";
            this.Text = "Palindrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnProvjeri;
        public System.Windows.Forms.TextBox txtRijec;
    }
}

