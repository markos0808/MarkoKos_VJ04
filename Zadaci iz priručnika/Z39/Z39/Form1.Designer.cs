namespace Z39
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
            this.btnPovecaj = new System.Windows.Forms.Button();
            this.btnSmanji = new System.Windows.Forms.Button();
            this.lblTekst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPovecaj
            // 
            this.btnPovecaj.Location = new System.Drawing.Point(12, 16);
            this.btnPovecaj.Name = "btnPovecaj";
            this.btnPovecaj.Size = new System.Drawing.Size(75, 23);
            this.btnPovecaj.TabIndex = 0;
            this.btnPovecaj.Text = "Povećaj";
            this.btnPovecaj.UseVisualStyleBackColor = true;
            this.btnPovecaj.Click += new System.EventHandler(this.btnPovecaj_Click);
            // 
            // btnSmanji
            // 
            this.btnSmanji.Location = new System.Drawing.Point(197, 12);
            this.btnSmanji.Name = "btnSmanji";
            this.btnSmanji.Size = new System.Drawing.Size(75, 23);
            this.btnSmanji.TabIndex = 1;
            this.btnSmanji.Text = "Smanji";
            this.btnSmanji.UseVisualStyleBackColor = true;
            this.btnSmanji.Click += new System.EventHandler(this.btnSmanji_Click);
            // 
            // lblTekst
            // 
            this.lblTekst.AutoSize = true;
            this.lblTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTekst.Location = new System.Drawing.Point(109, 127);
            this.lblTekst.Name = "lblTekst";
            this.lblTekst.Size = new System.Drawing.Size(64, 17);
            this.lblTekst.TabIndex = 2;
            this.lblTekst.Text = "Provjeri";
            this.lblTekst.Click += new System.EventHandler(this.lblTekst_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblTekst);
            this.Controls.Add(this.btnSmanji);
            this.Controls.Add(this.btnPovecaj);
            this.Name = "Form1";
            this.Text = "Provjera vida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnPovecaj;
        public System.Windows.Forms.Button btnSmanji;
        public System.Windows.Forms.Label lblTekst;
    }
}

