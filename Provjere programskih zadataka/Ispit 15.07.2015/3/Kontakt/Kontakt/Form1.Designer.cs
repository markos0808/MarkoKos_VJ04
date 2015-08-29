namespace Kontakt
{
    partial class FrmGlavna
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
            this.btnDodajNovi = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblKontakti = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblGrupa = new System.Windows.Forms.Label();
            this.lblTrazi = new System.Windows.Forms.Label();
            this.listBoxPopisKontakata = new System.Windows.Forms.ListBox();
            this.cmbGrupa = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDodajNovi
            // 
            this.btnDodajNovi.Location = new System.Drawing.Point(280, 301);
            this.btnDodajNovi.Name = "btnDodajNovi";
            this.btnDodajNovi.Size = new System.Drawing.Size(84, 23);
            this.btnDodajNovi.TabIndex = 0;
            this.btnDodajNovi.Text = "Dodaj novi";
            this.btnDodajNovi.UseVisualStyleBackColor = true;
            this.btnDodajNovi.Click += new System.EventHandler(this.btnDodajNovi_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(409, 301);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(84, 23);
            this.btnSpremi.TabIndex = 1;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(345, 9);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(148, 20);
            this.txtIme.TabIndex = 2;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(345, 54);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(148, 20);
            this.txtPrezime.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(345, 108);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(345, 162);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(148, 20);
            this.txtTelefon.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(61, 377);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(158, 20);
            this.textBox5.TabIndex = 6;
            // 
            // lblKontakti
            // 
            this.lblKontakti.AutoSize = true;
            this.lblKontakti.Location = new System.Drawing.Point(9, 9);
            this.lblKontakti.Name = "lblKontakti";
            this.lblKontakti.Size = new System.Drawing.Size(49, 13);
            this.lblKontakti.TabIndex = 7;
            this.lblKontakti.Text = "Kontakti:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(277, 9);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 8;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(277, 61);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 9;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(277, 115);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "e-Mail:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(277, 169);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(46, 13);
            this.lblTelefon.TabIndex = 11;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblGrupa
            // 
            this.lblGrupa.AutoSize = true;
            this.lblGrupa.Location = new System.Drawing.Point(277, 249);
            this.lblGrupa.Name = "lblGrupa";
            this.lblGrupa.Size = new System.Drawing.Size(39, 13);
            this.lblGrupa.TabIndex = 12;
            this.lblGrupa.Text = "Grupa:";
            // 
            // lblTrazi
            // 
            this.lblTrazi.AutoSize = true;
            this.lblTrazi.Location = new System.Drawing.Point(9, 384);
            this.lblTrazi.Name = "lblTrazi";
            this.lblTrazi.Size = new System.Drawing.Size(33, 13);
            this.lblTrazi.TabIndex = 13;
            this.lblTrazi.Text = "Traži:";
            // 
            // listBoxPopisKontakata
            // 
            this.listBoxPopisKontakata.FormattingEnabled = true;
            this.listBoxPopisKontakata.Location = new System.Drawing.Point(12, 28);
            this.listBoxPopisKontakata.Name = "listBoxPopisKontakata";
            this.listBoxPopisKontakata.Size = new System.Drawing.Size(207, 329);
            this.listBoxPopisKontakata.TabIndex = 14;
            this.listBoxPopisKontakata.SelectedIndexChanged += new System.EventHandler(this.listBoxPopisKontakata_SelectedIndexChanged);
            // 
            // cmbGrupa
            // 
            this.cmbGrupa.FormattingEnabled = true;
            this.cmbGrupa.Location = new System.Drawing.Point(345, 241);
            this.cmbGrupa.Name = "cmbGrupa";
            this.cmbGrupa.Size = new System.Drawing.Size(148, 21);
            this.cmbGrupa.TabIndex = 15;
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 414);
            this.Controls.Add(this.cmbGrupa);
            this.Controls.Add(this.listBoxPopisKontakata);
            this.Controls.Add(this.lblTrazi);
            this.Controls.Add(this.lblGrupa);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblKontakti);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnDodajNovi);
            this.Name = "FrmGlavna";
            this.Text = "Kontakti";
            this.Load += new System.EventHandler(this.FrmGlavna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.Label lblKontakti;
        public System.Windows.Forms.Label lblTrazi;
        public System.Windows.Forms.ListBox listBoxPopisKontakata;
        public System.Windows.Forms.TextBox txtIme;
        public System.Windows.Forms.Label lblIme;
        public System.Windows.Forms.TextBox txtPrezime;
        public System.Windows.Forms.Label lblPrezime;
        public System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtTelefon;
        public System.Windows.Forms.Label lblTelefon;
        public System.Windows.Forms.Label lblGrupa;
        public System.Windows.Forms.ComboBox cmbGrupa;
        public System.Windows.Forms.Button btnDodajNovi;
        public System.Windows.Forms.Button btnSpremi;
    }
}

