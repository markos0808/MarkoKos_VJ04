namespace Z44
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
            this.btnGeneriraj = new System.Windows.Forms.Button();
            this.txtBrojLabela = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGeneriraj
            // 
            this.btnGeneriraj.Location = new System.Drawing.Point(145, 74);
            this.btnGeneriraj.Name = "btnGeneriraj";
            this.btnGeneriraj.Size = new System.Drawing.Size(75, 23);
            this.btnGeneriraj.TabIndex = 0;
            this.btnGeneriraj.Text = "Generiraj";
            this.btnGeneriraj.UseVisualStyleBackColor = true;
            this.btnGeneriraj.Click += new System.EventHandler(this.btnGeneriraj_Click);
            // 
            // txtBrojLabela
            // 
            this.txtBrojLabela.Location = new System.Drawing.Point(132, 28);
            this.txtBrojLabela.Name = "txtBrojLabela";
            this.txtBrojLabela.Size = new System.Drawing.Size(100, 20);
            this.txtBrojLabela.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.txtBrojLabela);
            this.Controls.Add(this.btnGeneriraj);
            this.Name = "Form1";
            this.Text = "Generiranje labela";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeneriraj;
        public System.Windows.Forms.TextBox txtBrojLabela;
    }
}

