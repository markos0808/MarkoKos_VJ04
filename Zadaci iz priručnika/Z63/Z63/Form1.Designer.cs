namespace Z63
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
            this.components = new System.ComponentModel.Container();
            this.txtPutanja = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnKreni = new System.Windows.Forms.Button();
            this.lblPutanja = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPutanja
            // 
            this.txtPutanja.Location = new System.Drawing.Point(38, 33);
            this.txtPutanja.Name = "txtPutanja";
            this.txtPutanja.Size = new System.Drawing.Size(192, 20);
            this.txtPutanja.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnKreni
            // 
            this.btnKreni.Location = new System.Drawing.Point(93, 70);
            this.btnKreni.Name = "btnKreni";
            this.btnKreni.Size = new System.Drawing.Size(75, 23);
            this.btnKreni.TabIndex = 1;
            this.btnKreni.Text = "Piši";
            this.btnKreni.UseVisualStyleBackColor = true;
            this.btnKreni.Click += new System.EventHandler(this.btnKreni_Click);
            // 
            // lblPutanja
            // 
            this.lblPutanja.AutoSize = true;
            this.lblPutanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPutanja.Location = new System.Drawing.Point(107, 9);
            this.lblPutanja.Name = "lblPutanja";
            this.lblPutanja.Size = new System.Drawing.Size(54, 13);
            this.lblPutanja.TabIndex = 2;
            this.lblPutanja.Text = "Putanja:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 109);
            this.Controls.Add(this.lblPutanja);
            this.Controls.Add(this.btnKreni);
            this.Controls.Add(this.txtPutanja);
            this.Name = "Form1";
            this.Text = "Piši u datoteku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TextBox txtPutanja;
        public System.Windows.Forms.Button btnKreni;
        public System.Windows.Forms.Label lblPutanja;
    }
}

