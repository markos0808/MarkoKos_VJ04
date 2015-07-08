namespace Z62
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
            this.txtUpisi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUpisi
            // 
            this.txtUpisi.Location = new System.Drawing.Point(12, 12);
            this.txtUpisi.Multiline = true;
            this.txtUpisi.Name = "txtUpisi";
            this.txtUpisi.Size = new System.Drawing.Size(260, 237);
            this.txtUpisi.TabIndex = 0;
            this.txtUpisi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUpisi_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtUpisi);
            this.Name = "Form1";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtUpisi;
    }
}

