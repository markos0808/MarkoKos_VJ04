namespace Z52
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
            this.btnKreni = new System.Windows.Forms.Button();
            this.txtVrijednost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKreni
            // 
            this.btnKreni.Location = new System.Drawing.Point(99, 183);
            this.btnKreni.Name = "btnKreni";
            this.btnKreni.Size = new System.Drawing.Size(75, 23);
            this.btnKreni.TabIndex = 0;
            this.btnKreni.Text = "Klik";
            this.btnKreni.UseVisualStyleBackColor = true;
            this.btnKreni.Click += new System.EventHandler(this.btnKreni_Click);
            // 
            // txtVrijednost
            // 
            this.txtVrijednost.Location = new System.Drawing.Point(86, 108);
            this.txtVrijednost.Name = "txtVrijednost";
            this.txtVrijednost.Size = new System.Drawing.Size(100, 20);
            this.txtVrijednost.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtVrijednost);
            this.Controls.Add(this.btnKreni);
            this.Name = "Form1";
            this.Text = "Brojač klikova";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnKreni;
        public System.Windows.Forms.TextBox txtVrijednost;

    }
}

