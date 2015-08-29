namespace Rok
{
    partial class frmUnosPitanja
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
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtTekstPitanja = new System.Windows.Forms.TextBox();
            this.txtBrojBodova = new System.Windows.Forms.TextBox();
            this.lblTekstPitanja = new System.Windows.Forms.Label();
            this.lblBrojBodova = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(353, 163);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(100, 23);
            this.btnSpremi.TabIndex = 0;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtTekstPitanja
            // 
            this.txtTekstPitanja.Location = new System.Drawing.Point(106, 31);
            this.txtTekstPitanja.Multiline = true;
            this.txtTekstPitanja.Name = "txtTekstPitanja";
            this.txtTekstPitanja.Size = new System.Drawing.Size(347, 69);
            this.txtTekstPitanja.TabIndex = 1;
            // 
            // txtBrojBodova
            // 
            this.txtBrojBodova.Location = new System.Drawing.Point(353, 114);
            this.txtBrojBodova.Name = "txtBrojBodova";
            this.txtBrojBodova.Size = new System.Drawing.Size(100, 20);
            this.txtBrojBodova.TabIndex = 2;
            // 
            // lblTekstPitanja
            // 
            this.lblTekstPitanja.AutoSize = true;
            this.lblTekstPitanja.Location = new System.Drawing.Point(29, 31);
            this.lblTekstPitanja.Name = "lblTekstPitanja";
            this.lblTekstPitanja.Size = new System.Drawing.Size(71, 13);
            this.lblTekstPitanja.TabIndex = 3;
            this.lblTekstPitanja.Text = "Tekst pitanja:";
            // 
            // lblBrojBodova
            // 
            this.lblBrojBodova.AutoSize = true;
            this.lblBrojBodova.Location = new System.Drawing.Point(29, 114);
            this.lblBrojBodova.Name = "lblBrojBodova";
            this.lblBrojBodova.Size = new System.Drawing.Size(67, 13);
            this.lblBrojBodova.TabIndex = 4;
            this.lblBrojBodova.Text = "Broj bodova:";
            // 
            // frmUnosPitanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 209);
            this.Controls.Add(this.lblBrojBodova);
            this.Controls.Add(this.lblTekstPitanja);
            this.Controls.Add(this.txtBrojBodova);
            this.Controls.Add(this.txtTekstPitanja);
            this.Controls.Add(this.btnSpremi);
            this.Name = "frmUnosPitanja";
            this.Text = "Unos pitanja:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnSpremi;
        public System.Windows.Forms.TextBox txtTekstPitanja;
        public System.Windows.Forms.TextBox txtBrojBodova;
        public System.Windows.Forms.Label lblTekstPitanja;
        public System.Windows.Forms.Label lblBrojBodova;
    }
}