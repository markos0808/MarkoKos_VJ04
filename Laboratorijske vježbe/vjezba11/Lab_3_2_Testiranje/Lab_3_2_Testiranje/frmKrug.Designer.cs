namespace Lab_3_2_Testiranje
{
    partial class frmKrug
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
            this.gbRezultati = new System.Windows.Forms.GroupBox();
            this.lblDijagonala = new System.Windows.Forms.Label();
            this.lblPovrsina = new System.Windows.Forms.Label();
            this.txtOpseg = new System.Windows.Forms.TextBox();
            this.txtPovrsina = new System.Windows.Forms.TextBox();
            this.gbUnos = new System.Windows.Forms.GroupBox();
            this.lblStranicaA = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.gbRezultati.SuspendLayout();
            this.gbUnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRezultati
            // 
            this.gbRezultati.Controls.Add(this.lblDijagonala);
            this.gbRezultati.Controls.Add(this.lblPovrsina);
            this.gbRezultati.Controls.Add(this.txtOpseg);
            this.gbRezultati.Controls.Add(this.txtPovrsina);
            this.gbRezultati.Location = new System.Drawing.Point(30, 129);
            this.gbRezultati.Name = "gbRezultati";
            this.gbRezultati.Size = new System.Drawing.Size(225, 100);
            this.gbRezultati.TabIndex = 13;
            this.gbRezultati.TabStop = false;
            this.gbRezultati.Text = "Rezultati";
            // 
            // lblDijagonala
            // 
            this.lblDijagonala.AutoSize = true;
            this.lblDijagonala.Location = new System.Drawing.Point(5, 22);
            this.lblDijagonala.Name = "lblDijagonala";
            this.lblDijagonala.Size = new System.Drawing.Size(38, 13);
            this.lblDijagonala.TabIndex = 2;
            this.lblDijagonala.Text = "Opseg";
            // 
            // lblPovrsina
            // 
            this.lblPovrsina.AutoSize = true;
            this.lblPovrsina.Location = new System.Drawing.Point(5, 48);
            this.lblPovrsina.Name = "lblPovrsina";
            this.lblPovrsina.Size = new System.Drawing.Size(51, 13);
            this.lblPovrsina.TabIndex = 3;
            this.lblPovrsina.Text = "Površina:";
            // 
            // txtOpseg
            // 
            this.txtOpseg.Location = new System.Drawing.Point(100, 19);
            this.txtOpseg.Name = "txtOpseg";
            this.txtOpseg.Size = new System.Drawing.Size(100, 20);
            this.txtOpseg.TabIndex = 6;
            this.txtOpseg.Text = "0,00";
            this.txtOpseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPovrsina
            // 
            this.txtPovrsina.Location = new System.Drawing.Point(100, 45);
            this.txtPovrsina.Name = "txtPovrsina";
            this.txtPovrsina.Size = new System.Drawing.Size(100, 20);
            this.txtPovrsina.TabIndex = 7;
            this.txtPovrsina.Text = "0,00";
            this.txtPovrsina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbUnos
            // 
            this.gbUnos.Controls.Add(this.lblStranicaA);
            this.gbUnos.Controls.Add(this.txtRadius);
            this.gbUnos.Location = new System.Drawing.Point(29, 32);
            this.gbUnos.Name = "gbUnos";
            this.gbUnos.Size = new System.Drawing.Size(226, 91);
            this.gbUnos.TabIndex = 12;
            this.gbUnos.TabStop = false;
            this.gbUnos.Text = "Unos podataka";
            // 
            // lblStranicaA
            // 
            this.lblStranicaA.AutoSize = true;
            this.lblStranicaA.Location = new System.Drawing.Point(6, 25);
            this.lblStranicaA.Name = "lblStranicaA";
            this.lblStranicaA.Size = new System.Drawing.Size(40, 13);
            this.lblStranicaA.TabIndex = 0;
            this.lblStranicaA.Text = "Radius";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(101, 22);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 20);
            this.txtRadius.TabIndex = 4;
            this.txtRadius.Text = "0,00";
            this.txtRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(99, 235);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 15;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(180, 235);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzracunaj.TabIndex = 14;
            this.btnIzracunaj.Text = "Izračunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // frmKrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.gbRezultati);
            this.Controls.Add(this.gbUnos);
            this.Name = "frmKrug";
            this.Text = "frmKrug";
            this.Load += new System.EventHandler(this.frmKrug_Load);
            this.gbRezultati.ResumeLayout(false);
            this.gbRezultati.PerformLayout();
            this.gbUnos.ResumeLayout(false);
            this.gbUnos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRezultati;
        private System.Windows.Forms.Label lblDijagonala;
        private System.Windows.Forms.Label lblPovrsina;
        private System.Windows.Forms.TextBox txtOpseg;
        private System.Windows.Forms.TextBox txtPovrsina;
        private System.Windows.Forms.GroupBox gbUnos;
        private System.Windows.Forms.Label lblStranicaA;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnIzracunaj;
    }
}