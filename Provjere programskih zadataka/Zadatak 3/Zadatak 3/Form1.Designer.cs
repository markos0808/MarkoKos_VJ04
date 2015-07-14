namespace Zadatak_3
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.rbtnAuto = new System.Windows.Forms.RadioButton();
            this.rbtnMoto = new System.Windows.Forms.RadioButton();
            this.txtNazivVozila = new System.Windows.Forms.TextBox();
            this.lblNazivVozila = new System.Windows.Forms.Label();
            this.lblVozilaUGarazi = new System.Windows.Forms.Label();
            this.lblBrojAutomobila = new System.Windows.Forms.Label();
            this.lblUkupnoA = new System.Windows.Forms.Label();
            this.lblBrojMotocikla = new System.Windows.Forms.Label();
            this.lblUkupnoM = new System.Windows.Forms.Label();
            this.listBoxVozilaUGarazi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(58, 158);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // rbtnAuto
            // 
            this.rbtnAuto.AutoSize = true;
            this.rbtnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnAuto.Location = new System.Drawing.Point(33, 12);
            this.rbtnAuto.Name = "rbtnAuto";
            this.rbtnAuto.Size = new System.Drawing.Size(80, 17);
            this.rbtnAuto.TabIndex = 1;
            this.rbtnAuto.TabStop = true;
            this.rbtnAuto.Text = "Automobil";
            this.rbtnAuto.UseVisualStyleBackColor = true;
            // 
            // rbtnMoto
            // 
            this.rbtnMoto.AutoSize = true;
            this.rbtnMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnMoto.Location = new System.Drawing.Point(33, 48);
            this.rbtnMoto.Name = "rbtnMoto";
            this.rbtnMoto.Size = new System.Drawing.Size(73, 17);
            this.rbtnMoto.TabIndex = 2;
            this.rbtnMoto.TabStop = true;
            this.rbtnMoto.Text = "Motocikl";
            this.rbtnMoto.UseVisualStyleBackColor = true;
            // 
            // txtNazivVozila
            // 
            this.txtNazivVozila.Location = new System.Drawing.Point(33, 122);
            this.txtNazivVozila.Name = "txtNazivVozila";
            this.txtNazivVozila.Size = new System.Drawing.Size(100, 20);
            this.txtNazivVozila.TabIndex = 3;
            // 
            // lblNazivVozila
            // 
            this.lblNazivVozila.AutoSize = true;
            this.lblNazivVozila.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivVozila.Location = new System.Drawing.Point(30, 97);
            this.lblNazivVozila.Name = "lblNazivVozila";
            this.lblNazivVozila.Size = new System.Drawing.Size(77, 13);
            this.lblNazivVozila.TabIndex = 4;
            this.lblNazivVozila.Text = "Naziv Vozila";
            // 
            // lblVozilaUGarazi
            // 
            this.lblVozilaUGarazi.AutoSize = true;
            this.lblVozilaUGarazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVozilaUGarazi.Location = new System.Drawing.Point(206, 12);
            this.lblVozilaUGarazi.Name = "lblVozilaUGarazi";
            this.lblVozilaUGarazi.Size = new System.Drawing.Size(90, 13);
            this.lblVozilaUGarazi.TabIndex = 5;
            this.lblVozilaUGarazi.Text = "Vozila u garaži";
            // 
            // lblBrojAutomobila
            // 
            this.lblBrojAutomobila.AutoSize = true;
            this.lblBrojAutomobila.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojAutomobila.Location = new System.Drawing.Point(30, 218);
            this.lblBrojAutomobila.Name = "lblBrojAutomobila";
            this.lblBrojAutomobila.Size = new System.Drawing.Size(98, 13);
            this.lblBrojAutomobila.TabIndex = 7;
            this.lblBrojAutomobila.Text = "Broj automobila:";
            // 
            // lblUkupnoA
            // 
            this.lblUkupnoA.AutoSize = true;
            this.lblUkupnoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupnoA.Location = new System.Drawing.Point(134, 218);
            this.lblUkupnoA.Name = "lblUkupnoA";
            this.lblUkupnoA.Size = new System.Drawing.Size(51, 13);
            this.lblUkupnoA.TabIndex = 8;
            this.lblUkupnoA.Text = "Ukupno";
            // 
            // lblBrojMotocikla
            // 
            this.lblBrojMotocikla.AutoSize = true;
            this.lblBrojMotocikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojMotocikla.Location = new System.Drawing.Point(30, 255);
            this.lblBrojMotocikla.Name = "lblBrojMotocikla";
            this.lblBrojMotocikla.Size = new System.Drawing.Size(91, 13);
            this.lblBrojMotocikla.TabIndex = 9;
            this.lblBrojMotocikla.Text = "Broj motocikla:";
            // 
            // lblUkupnoM
            // 
            this.lblUkupnoM.AutoSize = true;
            this.lblUkupnoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupnoM.Location = new System.Drawing.Point(134, 255);
            this.lblUkupnoM.Name = "lblUkupnoM";
            this.lblUkupnoM.Size = new System.Drawing.Size(51, 13);
            this.lblUkupnoM.TabIndex = 10;
            this.lblUkupnoM.Text = "Ukupno";
            // 
            // listBoxVozilaUGarazi
            // 
            this.listBoxVozilaUGarazi.FormattingEnabled = true;
            this.listBoxVozilaUGarazi.Location = new System.Drawing.Point(209, 37);
            this.listBoxVozilaUGarazi.Name = "listBoxVozilaUGarazi";
            this.listBoxVozilaUGarazi.Size = new System.Drawing.Size(291, 225);
            this.listBoxVozilaUGarazi.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 286);
            this.Controls.Add(this.listBoxVozilaUGarazi);
            this.Controls.Add(this.lblUkupnoM);
            this.Controls.Add(this.lblBrojMotocikla);
            this.Controls.Add(this.lblUkupnoA);
            this.Controls.Add(this.lblBrojAutomobila);
            this.Controls.Add(this.lblVozilaUGarazi);
            this.Controls.Add(this.lblNazivVozila);
            this.Controls.Add(this.txtNazivVozila);
            this.Controls.Add(this.rbtnMoto);
            this.Controls.Add(this.rbtnAuto);
            this.Controls.Add(this.btnDodaj);
            this.Name = "Form1";
            this.Text = "Vozila u garaži";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnDodaj;
        public System.Windows.Forms.RadioButton rbtnAuto;
        public System.Windows.Forms.RadioButton rbtnMoto;
        public System.Windows.Forms.TextBox txtNazivVozila;
        public System.Windows.Forms.Label lblNazivVozila;
        public System.Windows.Forms.Label lblVozilaUGarazi;
        public System.Windows.Forms.Label lblBrojAutomobila;
        public System.Windows.Forms.Label lblUkupnoA;
        public System.Windows.Forms.Label lblBrojMotocikla;
        public System.Windows.Forms.Label lblUkupnoM;
        public System.Windows.Forms.ListBox listBoxVozilaUGarazi;
    }
}

