namespace Z19
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtRez = new System.Windows.Forms.TextBox();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.lblDijeljenik = new System.Windows.Forms.Label();
            this.lblDjelitelj = new System.Windows.Forms.Label();
            this.lblKolicnik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(87, 27);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(87, 73);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 1;
            // 
            // txtRez
            // 
            this.txtRez.Location = new System.Drawing.Point(87, 122);
            this.txtRez.Name = "txtRez";
            this.txtRez.Size = new System.Drawing.Size(100, 20);
            this.txtRez.TabIndex = 2;
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(99, 186);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzracunaj.TabIndex = 3;
            this.btnIzracunaj.Text = "Izracunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // lblDijeljenik
            // 
            this.lblDijeljenik.AutoSize = true;
            this.lblDijeljenik.Location = new System.Drawing.Point(28, 30);
            this.lblDijeljenik.Name = "lblDijeljenik";
            this.lblDijeljenik.Size = new System.Drawing.Size(52, 13);
            this.lblDijeljenik.TabIndex = 4;
            this.lblDijeljenik.Text = "Dijeljenik:";
            // 
            // lblDjelitelj
            // 
            this.lblDjelitelj.AutoSize = true;
            this.lblDjelitelj.Location = new System.Drawing.Point(28, 76);
            this.lblDjelitelj.Name = "lblDjelitelj";
            this.lblDjelitelj.Size = new System.Drawing.Size(43, 13);
            this.lblDjelitelj.TabIndex = 5;
            this.lblDjelitelj.Text = "Djelitelj:";
            // 
            // lblKolicnik
            // 
            this.lblKolicnik.AutoSize = true;
            this.lblKolicnik.Location = new System.Drawing.Point(28, 125);
            this.lblKolicnik.Name = "lblKolicnik";
            this.lblKolicnik.Size = new System.Drawing.Size(47, 13);
            this.lblKolicnik.TabIndex = 6;
            this.lblKolicnik.Text = "Količnik:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblKolicnik);
            this.Controls.Add(this.lblDjelitelj);
            this.Controls.Add(this.lblDijeljenik);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.txtRez);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Dijeljenje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Label lblDijeljenik;
        private System.Windows.Forms.Label lblDjelitelj;
        private System.Windows.Forms.Label lblKolicnik;
        public System.Windows.Forms.TextBox txtA;
        public System.Windows.Forms.TextBox txtB;
        public System.Windows.Forms.TextBox txtRez;
    }
}

