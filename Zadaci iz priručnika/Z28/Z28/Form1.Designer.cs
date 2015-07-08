namespace Z28
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
            this.btnRnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRnd
            // 
            this.btnRnd.Location = new System.Drawing.Point(185, 188);
            this.btnRnd.Name = "btnRnd";
            this.btnRnd.Size = new System.Drawing.Size(75, 23);
            this.btnRnd.TabIndex = 0;
            this.btnRnd.Text = "Random";
            this.btnRnd.UseVisualStyleBackColor = true;
            this.btnRnd.MouseHover += new System.EventHandler(this.btnRnd_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnRnd);
            this.Name = "Form1";
            this.Text = "Nasumicno";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnRnd;

    }
}

