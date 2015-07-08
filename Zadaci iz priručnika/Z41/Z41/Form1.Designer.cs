namespace Z41
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
            this.btnIspis = new System.Windows.Forms.Button();
            this.lblBrojevi = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIspis
            // 
            this.btnIspis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIspis.Location = new System.Drawing.Point(107, 162);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(82, 23);
            this.btnIspis.TabIndex = 0;
            this.btnIspis.Text = "Ispis niza";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // lblBrojevi
            // 
            this.lblBrojevi.AutoSize = true;
            this.lblBrojevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojevi.Location = new System.Drawing.Point(104, 59);
            this.lblBrojevi.Name = "lblBrojevi";
            this.lblBrojevi.Size = new System.Drawing.Size(58, 17);
            this.lblBrojevi.TabIndex = 1;
            this.lblBrojevi.Text = "Brojevi";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(91, 106);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 261);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblBrojevi);
            this.Controls.Add(this.btnIspis);
            this.Name = "Form1";
            this.Text = "Fibbonacijev niz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIspis;
        public System.Windows.Forms.Label lblBrojevi;
        public System.Windows.Forms.TextBox txtA;
    }
}

