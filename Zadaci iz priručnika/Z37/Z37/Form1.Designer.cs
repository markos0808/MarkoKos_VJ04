namespace Z37
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
            this.txtBjezi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBjezi
            // 
            this.txtBjezi.Location = new System.Drawing.Point(85, 65);
            this.txtBjezi.Name = "txtBjezi";
            this.txtBjezi.Size = new System.Drawing.Size(100, 20);
            this.txtBjezi.TabIndex = 1;
            this.txtBjezi.TextChanged += new System.EventHandler(this.txtBjezi_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtBjezi);
            this.Name = "Form1";
            this.Text = "Textbox bježi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtBjezi;

    }
}

