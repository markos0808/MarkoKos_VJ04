namespace Z2
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
            this.btnKlik = new System.Windows.Forms.Button();
            this.txtReset = new System.Windows.Forms.TextBox();
            this.lblBrojKlikova = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKlik
            // 
            this.btnKlik.Location = new System.Drawing.Point(102, 131);
            this.btnKlik.Name = "btnKlik";
            this.btnKlik.Size = new System.Drawing.Size(75, 23);
            this.btnKlik.TabIndex = 0;
            this.btnKlik.Text = "Klikni";
            this.btnKlik.UseVisualStyleBackColor = true;
            this.btnKlik.Click += new System.EventHandler(this.btnKlik_Click);
            // 
            // txtReset
            // 
            this.txtReset.Location = new System.Drawing.Point(90, 84);
            this.txtReset.Name = "txtReset";
            this.txtReset.Size = new System.Drawing.Size(100, 20);
            this.txtReset.TabIndex = 1;
            // 
            // lblBrojKlikova
            // 
            this.lblBrojKlikova.AutoSize = true;
            this.lblBrojKlikova.Location = new System.Drawing.Point(120, 46);
            this.lblBrojKlikova.Name = "lblBrojKlikova";
            this.lblBrojKlikova.Size = new System.Drawing.Size(35, 13);
            this.lblBrojKlikova.TabIndex = 2;
            this.lblBrojKlikova.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblBrojKlikova);
            this.Controls.Add(this.txtReset);
            this.Controls.Add(this.btnKlik);
            this.Name = "Form1";
            this.Text = "Brojač klikova";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKlik;
        private System.Windows.Forms.TextBox txtReset;
        private System.Windows.Forms.Label lblBrojKlikova;
    }
}

