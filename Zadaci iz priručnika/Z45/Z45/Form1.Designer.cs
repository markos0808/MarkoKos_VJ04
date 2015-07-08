namespace Z45
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
            this.listBoxMjesec = new System.Windows.Forms.ListBox();
            this.listBoxDani = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxMjesec
            // 
            this.listBoxMjesec.FormattingEnabled = true;
            this.listBoxMjesec.Location = new System.Drawing.Point(12, 12);
            this.listBoxMjesec.Name = "listBoxMjesec";
            this.listBoxMjesec.Size = new System.Drawing.Size(260, 95);
            this.listBoxMjesec.TabIndex = 0;
            this.listBoxMjesec.SelectedIndexChanged += new System.EventHandler(this.listBoxMjesec_SelectedIndexChanged);
            // 
            // listBoxDani
            // 
            this.listBoxDani.FormattingEnabled = true;
            this.listBoxDani.Location = new System.Drawing.Point(12, 124);
            this.listBoxDani.Name = "listBoxDani";
            this.listBoxDani.Size = new System.Drawing.Size(260, 95);
            this.listBoxDani.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listBoxDani);
            this.Controls.Add(this.listBoxMjesec);
            this.Name = "Form1";
            this.Text = "Mjeseci i dani";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listBoxMjesec;
        public System.Windows.Forms.ListBox listBoxDani;
    }
}

