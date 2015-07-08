namespace DIjagram_aktivnosti
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrvi = new System.Windows.Forms.TextBox();
            this.txtDrugi = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.gboxLog = new System.Windows.Forms.GroupBox();
            this.btnUnesiVrijednost = new System.Windows.Forms.Button();
            this.btnPokreniIzracun = new System.Windows.Forms.Button();
            this.gboxLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prvi broj:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drugi broj:";
            // 
            // txtPrvi
            // 
            this.txtPrvi.Location = new System.Drawing.Point(107, 35);
            this.txtPrvi.Name = "txtPrvi";
            this.txtPrvi.Size = new System.Drawing.Size(100, 20);
            this.txtPrvi.TabIndex = 2;
            // 
            // txtDrugi
            // 
            this.txtDrugi.Location = new System.Drawing.Point(107, 102);
            this.txtDrugi.Name = "txtDrugi";
            this.txtDrugi.Size = new System.Drawing.Size(100, 20);
            this.txtDrugi.TabIndex = 3;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(6, 19);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(335, 170);
            this.txtLog.TabIndex = 4;
            // 
            // gboxLog
            // 
            this.gboxLog.Controls.Add(this.txtLog);
            this.gboxLog.Location = new System.Drawing.Point(253, 16);
            this.gboxLog.Name = "gboxLog";
            this.gboxLog.Size = new System.Drawing.Size(347, 241);
            this.gboxLog.TabIndex = 5;
            this.gboxLog.TabStop = false;
            this.gboxLog.Text = "Log";
            // 
            // btnUnesiVrijednost
            // 
            this.btnUnesiVrijednost.Location = new System.Drawing.Point(24, 161);
            this.btnUnesiVrijednost.Name = "btnUnesiVrijednost";
            this.btnUnesiVrijednost.Size = new System.Drawing.Size(75, 44);
            this.btnUnesiVrijednost.TabIndex = 0;
            this.btnUnesiVrijednost.Text = "Unesi vrijednosti";
            this.btnUnesiVrijednost.UseVisualStyleBackColor = true;
            this.btnUnesiVrijednost.Click += new System.EventHandler(this.btnUnesiVrijednost_Click);
            // 
            // btnPokreniIzracun
            // 
            this.btnPokreniIzracun.Location = new System.Drawing.Point(132, 161);
            this.btnPokreniIzracun.Name = "btnPokreniIzracun";
            this.btnPokreniIzracun.Size = new System.Drawing.Size(75, 44);
            this.btnPokreniIzracun.TabIndex = 1;
            this.btnPokreniIzracun.Text = "Pokreni izračun";
            this.btnPokreniIzracun.UseVisualStyleBackColor = true;
            this.btnPokreniIzracun.Click += new System.EventHandler(this.btnPokreniIzracun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 217);
            this.Controls.Add(this.btnUnesiVrijednost);
            this.Controls.Add(this.btnPokreniIzracun);
            this.Controls.Add(this.gboxLog);
            this.Controls.Add(this.txtDrugi);
            this.Controls.Add(this.txtPrvi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Programsko inženjerstvo - Dijagram aktivnosti";
            this.gboxLog.ResumeLayout(false);
            this.gboxLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrvi;
        private System.Windows.Forms.TextBox txtDrugi;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.GroupBox gboxLog;
        private System.Windows.Forms.Button btnUnesiVrijednost;
        private System.Windows.Forms.Button btnPokreniIzracun;
    }
}

