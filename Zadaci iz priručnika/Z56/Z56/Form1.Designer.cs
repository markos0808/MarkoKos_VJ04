namespace Z56
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
            this.btnPomnozi = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPomnozi
            // 
            this.btnPomnozi.Location = new System.Drawing.Point(91, 175);
            this.btnPomnozi.Name = "btnPomnozi";
            this.btnPomnozi.Size = new System.Drawing.Size(75, 23);
            this.btnPomnozi.TabIndex = 0;
            this.btnPomnozi.Text = "Pomnoži";
            this.btnPomnozi.UseVisualStyleBackColor = true;
            this.btnPomnozi.Click += new System.EventHandler(this.btnPomnozi_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(76, 54);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 1;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(76, 80);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 89);
            this.txt2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnPomnozi);
            this.Name = "Form1";
            this.Text = "Množenje brojeva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt1;
        public System.Windows.Forms.TextBox txt2;
        public System.Windows.Forms.Button btnPomnozi;
    }
}

