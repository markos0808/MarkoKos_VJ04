namespace Z3
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
            this.btnPremjesti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPremjesti
            // 
            this.btnPremjesti.Location = new System.Drawing.Point(96, 112);
            this.btnPremjesti.Name = "btnPremjesti";
            this.btnPremjesti.Size = new System.Drawing.Size(75, 23);
            this.btnPremjesti.TabIndex = 0;
            this.btnPremjesti.Text = "Premjesti tipku";
            this.btnPremjesti.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPremjesti);
            this.Name = "Form1";
            this.Text = "Premjesti botun";
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnPremjesti;

    }
}

