namespace Z57
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
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtO = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblO = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(82, 12);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(82, 46);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 1;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(82, 88);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 2;
            // 
            // txtO
            // 
            this.txtO.Location = new System.Drawing.Point(82, 128);
            this.txtO.Name = "txtO";
            this.txtO.Size = new System.Drawing.Size(100, 20);
            this.txtO.TabIndex = 3;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(82, 165);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(100, 20);
            this.txtP.TabIndex = 4;
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(94, 208);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzracunaj.TabIndex = 5;
            this.btnIzracunaj.Text = "Izračunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(16, 15);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(58, 13);
            this.lblA.TabIndex = 6;
            this.lblA.Text = "Stranica a:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(16, 49);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(58, 13);
            this.lblB.TabIndex = 7;
            this.lblB.Text = "Stranica b:";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(16, 91);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(58, 13);
            this.lblC.TabIndex = 8;
            this.lblC.Text = "Stranica c:";
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.Location = new System.Drawing.Point(16, 131);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(41, 13);
            this.lblO.TabIndex = 9;
            this.lblO.Text = "Opseg:";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(16, 168);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(51, 13);
            this.lblP.TabIndex = 10;
            this.lblP.Text = "Površina:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblO);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtO);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Proračun trokuta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtA;
        public System.Windows.Forms.TextBox txtB;
        public System.Windows.Forms.TextBox txtC;
        public System.Windows.Forms.TextBox txtO;
        public System.Windows.Forms.TextBox txtP;
        public System.Windows.Forms.Button btnIzracunaj;
        public System.Windows.Forms.Label lblA;
        public System.Windows.Forms.Label lblB;
        public System.Windows.Forms.Label lblC;
        public System.Windows.Forms.Label lblO;
        public System.Windows.Forms.Label lblP;
    }
}

