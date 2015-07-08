namespace Z50
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
            this.txtBrojGumbeka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGeneriraj
            // 
            this.btnGeneriraj.Location = new System.Drawing.Point(175, 242);
            this.btnGeneriraj.Name = "btnGeneriraj";
            this.btnGeneriraj.Size = new System.Drawing.Size(97, 23);
            this.btnGeneriraj.TabIndex = 0;
            this.btnGeneriraj.Text = "Generiraj ";
            this.btnGeneriraj.UseVisualStyleBackColor = true;
            this.btnGeneriraj.Click += new System.EventHandler(this.btnGeneriraj_Click);
            // 
            // txtBrojGumbeka
            // 
            this.txtBrojGumbeka.Location = new System.Drawing.Point(175, 205);
            this.txtBrojGumbeka.Name = "txtBrojGumbeka";
            this.txtBrojGumbeka.Size = new System.Drawing.Size(97, 20);
            this.txtBrojGumbeka.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.txtBrojGumbeka);
            this.Controls.Add(this.btnGeneriraj);
            this.Name = "Form1";
            this.Text = "Gumbeki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGeneriraj;
        public System.Windows.Forms.TextBox txtBrojGumbeka;

    }
}

