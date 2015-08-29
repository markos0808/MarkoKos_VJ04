namespace Rok
{
    partial class frmIspitniRok
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
            this.groupBoxPodaci = new System.Windows.Forms.GroupBox();
            this.btnKreirajRok = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtNazivIspita = new System.Windows.Forms.TextBox();
            this.txtNazivPredmeta = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblNazivIspita = new System.Windows.Forms.Label();
            this.lblNazivPredmeta = new System.Windows.Forms.Label();
            this.groupBoxPitanja = new System.Windows.Forms.GroupBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvPitanja = new System.Windows.Forms.DataGridView();
            this.groupBoxPodaci.SuspendLayout();
            this.groupBoxPitanja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPitanja)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPodaci
            // 
            this.groupBoxPodaci.Controls.Add(this.btnKreirajRok);
            this.groupBoxPodaci.Controls.Add(this.dtpDatum);
            this.groupBoxPodaci.Controls.Add(this.txtNazivIspita);
            this.groupBoxPodaci.Controls.Add(this.txtNazivPredmeta);
            this.groupBoxPodaci.Controls.Add(this.lblDatum);
            this.groupBoxPodaci.Controls.Add(this.lblNazivIspita);
            this.groupBoxPodaci.Controls.Add(this.lblNazivPredmeta);
            this.groupBoxPodaci.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPodaci.Name = "groupBoxPodaci";
            this.groupBoxPodaci.Size = new System.Drawing.Size(365, 159);
            this.groupBoxPodaci.TabIndex = 0;
            this.groupBoxPodaci.TabStop = false;
            this.groupBoxPodaci.Text = "Podaci o ispitnom roku:";
            // 
            // btnKreirajRok
            // 
            this.btnKreirajRok.Location = new System.Drawing.Point(252, 120);
            this.btnKreirajRok.Name = "btnKreirajRok";
            this.btnKreirajRok.Size = new System.Drawing.Size(75, 23);
            this.btnKreirajRok.TabIndex = 6;
            this.btnKreirajRok.Text = "Kreiraj rok";
            this.btnKreirajRok.UseVisualStyleBackColor = true;
            this.btnKreirajRok.Click += new System.EventHandler(this.btnKreirajRok_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(172, 83);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(155, 20);
            this.dtpDatum.TabIndex = 5;
            // 
            // txtNazivIspita
            // 
            this.txtNazivIspita.Location = new System.Drawing.Point(172, 50);
            this.txtNazivIspita.Name = "txtNazivIspita";
            this.txtNazivIspita.Size = new System.Drawing.Size(155, 20);
            this.txtNazivIspita.TabIndex = 4;
            // 
            // txtNazivPredmeta
            // 
            this.txtNazivPredmeta.Location = new System.Drawing.Point(172, 19);
            this.txtNazivPredmeta.Name = "txtNazivPredmeta";
            this.txtNazivPredmeta.Size = new System.Drawing.Size(155, 20);
            this.txtNazivPredmeta.TabIndex = 3;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(28, 90);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(41, 13);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "Datum:";
            // 
            // lblNazivIspita
            // 
            this.lblNazivIspita.AutoSize = true;
            this.lblNazivIspita.Location = new System.Drawing.Point(28, 57);
            this.lblNazivIspita.Name = "lblNazivIspita";
            this.lblNazivIspita.Size = new System.Drawing.Size(64, 13);
            this.lblNazivIspita.TabIndex = 1;
            this.lblNazivIspita.Text = "Naziv ispita:";
            // 
            // lblNazivPredmeta
            // 
            this.lblNazivPredmeta.AutoSize = true;
            this.lblNazivPredmeta.Location = new System.Drawing.Point(28, 26);
            this.lblNazivPredmeta.Name = "lblNazivPredmeta";
            this.lblNazivPredmeta.Size = new System.Drawing.Size(84, 13);
            this.lblNazivPredmeta.TabIndex = 0;
            this.lblNazivPredmeta.Text = "Naziv predmeta:";
            // 
            // groupBoxPitanja
            // 
            this.groupBoxPitanja.Controls.Add(this.btnDodaj);
            this.groupBoxPitanja.Controls.Add(this.dgvPitanja);
            this.groupBoxPitanja.Location = new System.Drawing.Point(12, 177);
            this.groupBoxPitanja.Name = "groupBoxPitanja";
            this.groupBoxPitanja.Size = new System.Drawing.Size(365, 240);
            this.groupBoxPitanja.TabIndex = 1;
            this.groupBoxPitanja.TabStop = false;
            this.groupBoxPitanja.Text = "Ispitna pitanja:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(284, 202);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvPitanja
            // 
            this.dgvPitanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPitanja.Location = new System.Drawing.Point(3, 16);
            this.dgvPitanja.Name = "dgvPitanja";
            this.dgvPitanja.Size = new System.Drawing.Size(356, 167);
            this.dgvPitanja.TabIndex = 0;
            // 
            // frmIspitniRok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 429);
            this.Controls.Add(this.groupBoxPitanja);
            this.Controls.Add(this.groupBoxPodaci);
            this.Name = "frmIspitniRok";
            this.Text = "Ispitni rok";
            this.groupBoxPodaci.ResumeLayout(false);
            this.groupBoxPodaci.PerformLayout();
            this.groupBoxPitanja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPitanja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBoxPodaci;
        public System.Windows.Forms.Button btnKreirajRok;
        public System.Windows.Forms.DateTimePicker dtpDatum;
        public System.Windows.Forms.TextBox txtNazivIspita;
        public System.Windows.Forms.TextBox txtNazivPredmeta;
        public System.Windows.Forms.Label lblDatum;
        public System.Windows.Forms.Label lblNazivIspita;
        public System.Windows.Forms.Label lblNazivPredmeta;
        public System.Windows.Forms.GroupBox groupBoxPitanja;
        public System.Windows.Forms.Button btnDodaj;
        public System.Windows.Forms.DataGridView dgvPitanja;
    }
}

