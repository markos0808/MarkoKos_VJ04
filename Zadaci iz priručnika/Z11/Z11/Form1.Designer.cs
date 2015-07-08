namespace Z11
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
            this.txtUL = new System.Windows.Forms.TextBox();
            this.txtPL = new System.Windows.Forms.TextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUL
            // 
            this.txtUL.Location = new System.Drawing.Point(93, 51);
            this.txtUL.Name = "txtUL";
            this.txtUL.PasswordChar = '@';
            this.txtUL.Size = new System.Drawing.Size(100, 20);
            this.txtUL.TabIndex = 0;
            // 
            // txtPL
            // 
            this.txtPL.Location = new System.Drawing.Point(93, 121);
            this.txtPL.Name = "txtPL";
            this.txtPL.PasswordChar = '@';
            this.txtPL.Size = new System.Drawing.Size(100, 20);
            this.txtPL.TabIndex = 1;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(107, 179);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 23);
            this.btnUnesi.TabIndex = 2;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.txtPL);
            this.Controls.Add(this.txtUL);
            this.Name = "Form1";
            this.Text = "Unesi lozinku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUL;
        private System.Windows.Forms.TextBox txtPL;
        private System.Windows.Forms.Button btnUnesi;
    }
}

