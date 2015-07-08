namespace Z59
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
            this.btnRezultat = new System.Windows.Forms.Button();
            this.txtRacunaj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRezultat
            // 
            this.btnRezultat.Location = new System.Drawing.Point(106, 78);
            this.btnRezultat.Name = "btnRezultat";
            this.btnRezultat.Size = new System.Drawing.Size(75, 23);
            this.btnRezultat.TabIndex = 0;
            this.btnRezultat.Text = "Rezultat";
            this.btnRezultat.UseVisualStyleBackColor = true;
            this.btnRezultat.Click += new System.EventHandler(this.btnRezultat_Click);
            // 
            // txtRacunaj
            // 
            this.txtRacunaj.Location = new System.Drawing.Point(76, 34);
            this.txtRacunaj.Name = "txtRacunaj";
            this.txtRacunaj.Size = new System.Drawing.Size(139, 20);
            this.txtRacunaj.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 119);
            this.Controls.Add(this.txtRacunaj);
            this.Controls.Add(this.btnRezultat);
            this.Name = "Form1";
            this.Text = "Izračunaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnRezultat;
        public System.Windows.Forms.TextBox txtRacunaj;

    }
}

