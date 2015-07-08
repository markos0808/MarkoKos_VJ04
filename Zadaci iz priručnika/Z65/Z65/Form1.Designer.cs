namespace Z65
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
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.txtRok = new System.Windows.Forms.TextBox();
            this.btnIzracun = new System.Windows.Forms.Button();
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblRok = new System.Windows.Forms.Label();
            this.lblKamate = new System.Windows.Forms.Label();
            this.numKamata = new System.Windows.Forms.NumericUpDown();
            this.lvOtplata = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.numKamata)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(115, 9);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(100, 20);
            this.txtIznos.TabIndex = 1;
            // 
            // txtRok
            // 
            this.txtRok.Location = new System.Drawing.Point(115, 35);
            this.txtRok.Name = "txtRok";
            this.txtRok.Size = new System.Drawing.Size(100, 20);
            this.txtRok.TabIndex = 2;
            // 
            // btnIzracun
            // 
            this.btnIzracun.Location = new System.Drawing.Point(262, 32);
            this.btnIzracun.Name = "btnIzracun";
            this.btnIzracun.Size = new System.Drawing.Size(75, 23);
            this.btnIzracun.TabIndex = 4;
            this.btnIzracun.Text = "Izračun";
            this.btnIzracun.UseVisualStyleBackColor = true;
            this.btnIzracun.Click += new System.EventHandler(this.btnIzracun_Click);
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(12, 12);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(70, 13);
            this.lblIznos.TabIndex = 5;
            this.lblIznos.Text = "Iznos kredita:";
            // 
            // lblRok
            // 
            this.lblRok.AutoSize = true;
            this.lblRok.Location = new System.Drawing.Point(12, 38);
            this.lblRok.Name = "lblRok";
            this.lblRok.Size = new System.Drawing.Size(101, 13);
            this.lblRok.TabIndex = 6;
            this.lblRok.Text = "Broj mjeseci otplate:";
            // 
            // lblKamate
            // 
            this.lblKamate.AutoSize = true;
            this.lblKamate.Location = new System.Drawing.Point(12, 64);
            this.lblKamate.Name = "lblKamate";
            this.lblKamate.Size = new System.Drawing.Size(46, 13);
            this.lblKamate.TabIndex = 7;
            this.lblKamate.Text = "Kamata:";
            // 
            // numKamata
            // 
            this.numKamata.Location = new System.Drawing.Point(115, 64);
            this.numKamata.Name = "numKamata";
            this.numKamata.Size = new System.Drawing.Size(100, 20);
            this.numKamata.TabIndex = 8;
            // 
            // lvOtplata
            // 
            this.lvOtplata.Location = new System.Drawing.Point(15, 102);
            this.lvOtplata.Name = "lvOtplata";
            this.lvOtplata.Size = new System.Drawing.Size(373, 147);
            this.lvOtplata.TabIndex = 9;
            this.lvOtplata.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 261);
            this.Controls.Add(this.lvOtplata);
            this.Controls.Add(this.numKamata);
            this.Controls.Add(this.lblKamate);
            this.Controls.Add(this.lblRok);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.btnIzracun);
            this.Controls.Add(this.txtRok);
            this.Controls.Add(this.txtIznos);
            this.Name = "Form1";
            this.Text = "Kredit";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKamata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnIzracun;
        public System.Windows.Forms.Label lblIznos;
        public System.Windows.Forms.Label lblRok;
        public System.Windows.Forms.Label lblKamate;
        public System.Windows.Forms.TextBox txtIznos;
        public System.Windows.Forms.TextBox txtRok;
        public System.Windows.Forms.NumericUpDown numKamata;
        public System.Windows.Forms.ListView lvOtplata;

    }
}

