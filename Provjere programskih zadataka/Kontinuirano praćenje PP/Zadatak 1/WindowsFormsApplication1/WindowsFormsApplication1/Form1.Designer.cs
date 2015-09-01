namespace WindowsFormsApplication1
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
            this.lblNazivDrzave = new System.Windows.Forms.Label();
            this.lblBrojStanovnika = new System.Windows.Forms.Label();
            this.lblStopaRasta = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.textBoxNazivDrzave = new System.Windows.Forms.TextBox();
            this.textBoxBrojStanovnika = new System.Windows.Forms.TextBox();
            this.textBoxStopaRasta = new System.Windows.Forms.TextBox();
            this.trackBarGodina = new System.Windows.Forms.TrackBar();
            this.lblGodina = new System.Windows.Forms.Label();
            this.labelRast = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGodina)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNazivDrzave
            // 
            this.lblNazivDrzave.AutoSize = true;
            this.lblNazivDrzave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivDrzave.Location = new System.Drawing.Point(12, 19);
            this.lblNazivDrzave.Name = "lblNazivDrzave";
            this.lblNazivDrzave.Size = new System.Drawing.Size(85, 13);
            this.lblNazivDrzave.TabIndex = 0;
            this.lblNazivDrzave.Text = "Naziv države:";
            // 
            // lblBrojStanovnika
            // 
            this.lblBrojStanovnika.AutoSize = true;
            this.lblBrojStanovnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojStanovnika.Location = new System.Drawing.Point(12, 55);
            this.lblBrojStanovnika.Name = "lblBrojStanovnika";
            this.lblBrojStanovnika.Size = new System.Drawing.Size(99, 13);
            this.lblBrojStanovnika.TabIndex = 1;
            this.lblBrojStanovnika.Text = "Broj stanovnika:";
            // 
            // lblStopaRasta
            // 
            this.lblStopaRasta.AutoSize = true;
            this.lblStopaRasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStopaRasta.Location = new System.Drawing.Point(12, 99);
            this.lblStopaRasta.Name = "lblStopaRasta";
            this.lblStopaRasta.Size = new System.Drawing.Size(76, 13);
            this.lblStopaRasta.TabIndex = 2;
            this.lblStopaRasta.Text = "Stopa rasta:";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(376, 50);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 23);
            this.btnUnesi.TabIndex = 3;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // textBoxNazivDrzave
            // 
            this.textBoxNazivDrzave.Location = new System.Drawing.Point(132, 12);
            this.textBoxNazivDrzave.Name = "textBoxNazivDrzave";
            this.textBoxNazivDrzave.Size = new System.Drawing.Size(199, 20);
            this.textBoxNazivDrzave.TabIndex = 4;
            // 
            // textBoxBrojStanovnika
            // 
            this.textBoxBrojStanovnika.Location = new System.Drawing.Point(132, 52);
            this.textBoxBrojStanovnika.Name = "textBoxBrojStanovnika";
            this.textBoxBrojStanovnika.Size = new System.Drawing.Size(199, 20);
            this.textBoxBrojStanovnika.TabIndex = 5;
            // 
            // textBoxStopaRasta
            // 
            this.textBoxStopaRasta.Location = new System.Drawing.Point(132, 99);
            this.textBoxStopaRasta.Name = "textBoxStopaRasta";
            this.textBoxStopaRasta.Size = new System.Drawing.Size(199, 20);
            this.textBoxStopaRasta.TabIndex = 6;
            // 
            // trackBarGodina
            // 
            this.trackBarGodina.Location = new System.Drawing.Point(132, 157);
            this.trackBarGodina.Maximum = 2050;
            this.trackBarGodina.Minimum = 2015;
            this.trackBarGodina.Name = "trackBarGodina";
            this.trackBarGodina.Size = new System.Drawing.Size(199, 45);
            this.trackBarGodina.TabIndex = 7;
            this.trackBarGodina.Value = 2015;
            this.trackBarGodina.ValueChanged += new System.EventHandler(this.trackBarGodina_ValueChanged);
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGodina.Location = new System.Drawing.Point(29, 157);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(51, 13);
            this.lblGodina.TabIndex = 8;
            this.lblGodina.Text = "Godina:";
            // 
            // labelRast
            // 
            this.labelRast.AutoSize = true;
            this.labelRast.Location = new System.Drawing.Point(392, 157);
            this.labelRast.Name = "labelRast";
            this.labelRast.Size = new System.Drawing.Size(31, 13);
            this.labelRast.TabIndex = 9;
            this.labelRast.Text = "2015";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(132, 208);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(199, 108);
            this.textBoxLog.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 328);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.labelRast);
            this.Controls.Add(this.lblGodina);
            this.Controls.Add(this.trackBarGodina);
            this.Controls.Add(this.textBoxStopaRasta);
            this.Controls.Add(this.textBoxBrojStanovnika);
            this.Controls.Add(this.textBoxNazivDrzave);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.lblStopaRasta);
            this.Controls.Add(this.lblBrojStanovnika);
            this.Controls.Add(this.lblNazivDrzave);
            this.Name = "Form1";
            this.Text = "Proračun stanovnika";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGodina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazivDrzave;
        private System.Windows.Forms.Label lblBrojStanovnika;
        private System.Windows.Forms.Label lblStopaRasta;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.Label labelRast;
        public System.Windows.Forms.TextBox textBoxLog;
        public System.Windows.Forms.TextBox textBoxNazivDrzave;
        public System.Windows.Forms.TextBox textBoxBrojStanovnika;
        public System.Windows.Forms.TextBox textBoxStopaRasta;
        public System.Windows.Forms.TrackBar trackBarGodina;
    }
}

