namespace Z13
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
            this.txtBrojevi = new System.Windows.Forms.TextBox();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBrojevi
            // 
            this.txtBrojevi.Location = new System.Drawing.Point(12, 12);
            this.txtBrojevi.Name = "txtBrojevi";
            this.txtBrojevi.Size = new System.Drawing.Size(260, 20);
            this.txtBrojevi.TabIndex = 0;
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(95, 61);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(75, 23);
            this.btnSortiraj.TabIndex = 1;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 114);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.txtBrojevi);
            this.Name = "Form1";
            this.Text = "Sortiranje brojeva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSortiraj;
        public System.Windows.Forms.TextBox txtBrojevi;
    }
}

