namespace Z12
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
            this.btnDirektorij = new System.Windows.Forms.Button();
            this.txtPutanja = new System.Windows.Forms.TextBox();
            this.txtSadrzaj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDirektorij
            // 
            this.btnDirektorij.Location = new System.Drawing.Point(99, 80);
            this.btnDirektorij.Name = "btnDirektorij";
            this.btnDirektorij.Size = new System.Drawing.Size(75, 23);
            this.btnDirektorij.TabIndex = 0;
            this.btnDirektorij.Text = "Klikni";
            this.btnDirektorij.UseVisualStyleBackColor = true;
            this.btnDirektorij.Click += new System.EventHandler(this.btnDirektorij_Click);
            // 
            // txtPutanja
            // 
            this.txtPutanja.Location = new System.Drawing.Point(12, 39);
            this.txtPutanja.Name = "txtPutanja";
            this.txtPutanja.Size = new System.Drawing.Size(260, 20);
            this.txtPutanja.TabIndex = 1;
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(12, 123);
            this.txtSadrzaj.Multiline = true;
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.Size = new System.Drawing.Size(260, 126);
            this.txtSadrzaj.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtSadrzaj);
            this.Controls.Add(this.txtPutanja);
            this.Controls.Add(this.btnDirektorij);
            this.Name = "Form1";
            this.Text = "Sadržaj direktorija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDirektorij;
        private System.Windows.Forms.TextBox txtPutanja;
        private System.Windows.Forms.TextBox txtSadrzaj;
    }
}

