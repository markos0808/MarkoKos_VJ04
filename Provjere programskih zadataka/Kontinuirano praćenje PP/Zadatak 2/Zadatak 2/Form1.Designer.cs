namespace Zadatak_2
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
            this.lblNazivMjerenja = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblVrijeme = new System.Windows.Forms.Label();
            this.txtNazivMjerenja = new System.Windows.Forms.TextBox();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.dtpVrijeme = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvStatistika = new System.Windows.Forms.DataGridView();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.lblRez = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistika)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNazivMjerenja
            // 
            this.lblNazivMjerenja.AutoSize = true;
            this.lblNazivMjerenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivMjerenja.Location = new System.Drawing.Point(18, 19);
            this.lblNazivMjerenja.Name = "lblNazivMjerenja";
            this.lblNazivMjerenja.Size = new System.Drawing.Size(94, 13);
            this.lblNazivMjerenja.TabIndex = 0;
            this.lblNazivMjerenja.Text = "Naziv mjerenja:";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTemperatura.Location = new System.Drawing.Point(18, 63);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(82, 13);
            this.lblTemperatura.TabIndex = 1;
            this.lblTemperatura.Text = "Temperatura:";
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.AutoSize = true;
            this.lblVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVrijeme.Location = new System.Drawing.Point(18, 112);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(52, 13);
            this.lblVrijeme.TabIndex = 2;
            this.lblVrijeme.Text = "Vrijeme:";
            // 
            // txtNazivMjerenja
            // 
            this.txtNazivMjerenja.Location = new System.Drawing.Point(115, 16);
            this.txtNazivMjerenja.Name = "txtNazivMjerenja";
            this.txtNazivMjerenja.Size = new System.Drawing.Size(334, 20);
            this.txtNazivMjerenja.TabIndex = 3;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(115, 60);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(334, 20);
            this.txtTemperatura.TabIndex = 4;
            // 
            // dtpVrijeme
            // 
            this.dtpVrijeme.Location = new System.Drawing.Point(115, 106);
            this.dtpVrijeme.Name = "dtpVrijeme";
            this.dtpVrijeme.Size = new System.Drawing.Size(334, 20);
            this.dtpVrijeme.TabIndex = 5;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(374, 148);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvStatistika
            // 
            this.dgvStatistika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistika.Location = new System.Drawing.Point(21, 192);
            this.dgvStatistika.Name = "dgvStatistika";
            this.dgvStatistika.Size = new System.Drawing.Size(428, 150);
            this.dgvStatistika.TabIndex = 7;
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProsjek.Location = new System.Drawing.Point(18, 375);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(138, 13);
            this.lblProsjek.TabIndex = 8;
            this.lblProsjek.Text = "Prosječna temperatura:";
            // 
            // lblRez
            // 
            this.lblRez.AutoSize = true;
            this.lblRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRez.Location = new System.Drawing.Point(162, 375);
            this.lblRez.Name = "lblRez";
            this.lblRez.Size = new System.Drawing.Size(54, 13);
            this.lblRez.TabIndex = 9;
            this.lblRez.Text = "Rezultat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 411);
            this.Controls.Add(this.lblRez);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.dgvStatistika);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dtpVrijeme);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.txtNazivMjerenja);
            this.Controls.Add(this.lblVrijeme);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.lblNazivMjerenja);
            this.Name = "Form1";
            this.Text = "Mjerenje temperature";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblNazivMjerenja;
        public System.Windows.Forms.Label lblTemperatura;
        public System.Windows.Forms.Label lblVrijeme;
        public System.Windows.Forms.TextBox txtNazivMjerenja;
        public System.Windows.Forms.TextBox txtTemperatura;
        public System.Windows.Forms.DateTimePicker dtpVrijeme;
        public System.Windows.Forms.Button btnDodaj;
        public System.Windows.Forms.DataGridView dgvStatistika;
        public System.Windows.Forms.Label lblProsjek;
        public System.Windows.Forms.Label lblRez;
    }
}

