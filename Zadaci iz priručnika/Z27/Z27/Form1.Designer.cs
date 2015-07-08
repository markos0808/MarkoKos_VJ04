namespace Z27
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
            this.btnKlik = new System.Windows.Forms.Button();
            this.lblbrojacKlikova = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKlik
            // 
            this.btnKlik.Location = new System.Drawing.Point(105, 106);
            this.btnKlik.Name = "btnKlik";
            this.btnKlik.Size = new System.Drawing.Size(75, 23);
            this.btnKlik.TabIndex = 0;
            this.btnKlik.Text = "Klik";
            this.btnKlik.UseVisualStyleBackColor = true;
            // 
            // lblbrojacKlikova
            // 
            this.lblbrojacKlikova.AutoSize = true;
            this.lblbrojacKlikova.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblbrojacKlikova.Location = new System.Drawing.Point(70, 53);
            this.lblbrojacKlikova.Name = "lblbrojacKlikova";
            this.lblbrojacKlikova.Size = new System.Drawing.Size(143, 26);
            this.lblbrojacKlikova.TabIndex = 1;
            this.lblbrojacKlikova.Text = "Broj klikova:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblbrojacKlikova);
            this.Controls.Add(this.btnKlik);
            this.Name = "Form1";
            this.Text = "Brojac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKlik;
        public System.Windows.Forms.Label lblbrojacKlikova;
    }
}

