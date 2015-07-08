namespace Lab3_1_EvidencijaStudenataX
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
            this.btnUredu = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.txtOpisProjekta = new System.Windows.Forms.TextBox();
            this.txtNazivProjekta = new System.Windows.Forms.TextBox();
            this.txtOznakaTima = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.lblOpisProjekta = new System.Windows.Forms.Label();
            this.lblNazivProjekta = new System.Windows.Forms.Label();
            this.lblOznakaTima = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUredu
            // 
            this.btnUredu.Location = new System.Drawing.Point(149, 198);
            this.btnUredu.Name = "btnUredu";
            this.btnUredu.Size = new System.Drawing.Size(75, 23);
            this.btnUredu.TabIndex = 5;
            this.btnUredu.Text = "Uredu";
            this.btnUredu.UseVisualStyleBackColor = true;
            this.btnUredu.Click += new System.EventHandler(this.btnUredu_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(230, 198);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(109, 119);
            this.txtNapomena.MaxLength = 255;
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(196, 73);
            this.txtNapomena.TabIndex = 4;
            // 
            // txtOpisProjekta
            // 
            this.txtOpisProjekta.Location = new System.Drawing.Point(109, 93);
            this.txtOpisProjekta.Name = "txtOpisProjekta";
            this.txtOpisProjekta.Size = new System.Drawing.Size(196, 20);
            this.txtOpisProjekta.TabIndex = 3;
            // 
            // txtNazivProjekta
            // 
            this.txtNazivProjekta.Location = new System.Drawing.Point(109, 67);
            this.txtNazivProjekta.Name = "txtNazivProjekta";
            this.txtNazivProjekta.Size = new System.Drawing.Size(196, 20);
            this.txtNazivProjekta.TabIndex = 2;
            // 
            // txtOznakaTima
            // 
            this.txtOznakaTima.Location = new System.Drawing.Point(109, 41);
            this.txtOznakaTima.Name = "txtOznakaTima";
            this.txtOznakaTima.Size = new System.Drawing.Size(196, 20);
            this.txtOznakaTima.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(109, 15);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(87, 20);
            this.txtId.TabIndex = 17;
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(14, 119);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(62, 13);
            this.lblNapomena.TabIndex = 16;
            this.lblNapomena.Text = "Napomena:";
            // 
            // lblOpisProjekta
            // 
            this.lblOpisProjekta.AutoSize = true;
            this.lblOpisProjekta.Location = new System.Drawing.Point(14, 93);
            this.lblOpisProjekta.Name = "lblOpisProjekta";
            this.lblOpisProjekta.Size = new System.Drawing.Size(72, 13);
            this.lblOpisProjekta.TabIndex = 15;
            this.lblOpisProjekta.Text = "Opis projekta:";
            // 
            // lblNazivProjekta
            // 
            this.lblNazivProjekta.AutoSize = true;
            this.lblNazivProjekta.Location = new System.Drawing.Point(14, 67);
            this.lblNazivProjekta.Name = "lblNazivProjekta";
            this.lblNazivProjekta.Size = new System.Drawing.Size(78, 13);
            this.lblNazivProjekta.TabIndex = 14;
            this.lblNazivProjekta.Text = "Naziv projekta:";
            // 
            // lblOznakaTima
            // 
            this.lblOznakaTima.AutoSize = true;
            this.lblOznakaTima.Location = new System.Drawing.Point(14, 41);
            this.lblOznakaTima.Name = "lblOznakaTima";
            this.lblOznakaTima.Size = new System.Drawing.Size(69, 13);
            this.lblOznakaTima.TabIndex = 13;
            this.lblOznakaTima.Text = "Oznaka tima:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(14, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "Id:";
            // 
            // FrmNoviTim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 243);
            this.Controls.Add(this.btnUredu);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmNoviTim";
            this.Text = "Dodavanje/Izmjena tima";
            this.Load += new System.EventHandler(this.FrmNoviTim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUredu;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.TextBox txtOpisProjekta;
        private System.Windows.Forms.TextBox txtNazivProjekta;
        private System.Windows.Forms.TextBox txtOznakaTima;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.Label lblOpisProjekta;
        private System.Windows.Forms.Label lblNazivProjekta;
        private System.Windows.Forms.Label lblOznakaTima;
        private System.Windows.Forms.Label lblId;
    }
}