namespace EvidencijaStudenata_Vjezbe2._4
{
    partial class FrmNoviTim
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblOznakaTima = new System.Windows.Forms.Label();
            this.lblNazivProjekta = new System.Windows.Forms.Label();
            this.lblOpisProjekta = new System.Windows.Forms.Label();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtOznakaTima = new System.Windows.Forms.TextBox();
            this.txtNazivProjekta = new System.Windows.Forms.TextBox();
            this.txtOpisProjekta = new System.Windows.Forms.TextBox();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 24);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // lblOznakaTima
            // 
            this.lblOznakaTima.AutoSize = true;
            this.lblOznakaTima.Location = new System.Drawing.Point(12, 50);
            this.lblOznakaTima.Name = "lblOznakaTima";
            this.lblOznakaTima.Size = new System.Drawing.Size(69, 13);
            this.lblOznakaTima.TabIndex = 1;
            this.lblOznakaTima.Text = "Oznaka tima:";
            // 
            // lblNazivProjekta
            // 
            this.lblNazivProjekta.AutoSize = true;
            this.lblNazivProjekta.Location = new System.Drawing.Point(12, 76);
            this.lblNazivProjekta.Name = "lblNazivProjekta";
            this.lblNazivProjekta.Size = new System.Drawing.Size(78, 13);
            this.lblNazivProjekta.TabIndex = 2;
            this.lblNazivProjekta.Text = "Naziv projekta:";
            // 
            // lblOpisProjekta
            // 
            this.lblOpisProjekta.AutoSize = true;
            this.lblOpisProjekta.Location = new System.Drawing.Point(12, 102);
            this.lblOpisProjekta.Name = "lblOpisProjekta";
            this.lblOpisProjekta.Size = new System.Drawing.Size(72, 13);
            this.lblOpisProjekta.TabIndex = 3;
            this.lblOpisProjekta.Text = "Opis projekta:";
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(12, 203);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(62, 13);
            this.lblNapomena.TabIndex = 4;
            this.lblNapomena.Text = "Napomena:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(108, 21);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(93, 20);
            this.txtId.TabIndex = 5;
            this.txtId.TabStop = false;
            // 
            // txtOznakaTima
            // 
            this.txtOznakaTima.Location = new System.Drawing.Point(108, 47);
            this.txtOznakaTima.Name = "txtOznakaTima";
            this.txtOznakaTima.Size = new System.Drawing.Size(304, 20);
            this.txtOznakaTima.TabIndex = 6;
            // 
            // txtNazivProjekta
            // 
            this.txtNazivProjekta.Location = new System.Drawing.Point(108, 73);
            this.txtNazivProjekta.Name = "txtNazivProjekta";
            this.txtNazivProjekta.Size = new System.Drawing.Size(304, 20);
            this.txtNazivProjekta.TabIndex = 7;
            // 
            // txtOpisProjekta
            // 
            this.txtOpisProjekta.Location = new System.Drawing.Point(108, 99);
            this.txtOpisProjekta.Multiline = true;
            this.txtOpisProjekta.Name = "txtOpisProjekta";
            this.txtOpisProjekta.Size = new System.Drawing.Size(304, 95);
            this.txtOpisProjekta.TabIndex = 8;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(108, 200);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(304, 117);
            this.txtNapomena.TabIndex = 9;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(337, 323);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 28);
            this.btnOdustani.TabIndex = 10;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(256, 323);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 28);
            this.btnSpremi.TabIndex = 11;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // FrmNoviTim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 363);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.txtOpisProjekta);
            this.Controls.Add(this.txtNazivProjekta);
            this.Controls.Add(this.txtOznakaTima);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.lblOpisProjekta);
            this.Controls.Add(this.lblNazivProjekta);
            this.Controls.Add(this.lblOznakaTima);
            this.Controls.Add(this.lblId);
            this.Name = "FrmNoviTim";
            this.Text = "Dodavanje novog tima";
            this.Load += new System.EventHandler(this.FrmNoviTim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblOznakaTima;
        private System.Windows.Forms.Label lblNazivProjekta;
        private System.Windows.Forms.Label lblOpisProjekta;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtOznakaTima;
        private System.Windows.Forms.TextBox txtNazivProjekta;
        private System.Windows.Forms.TextBox txtOpisProjekta;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
    }
}