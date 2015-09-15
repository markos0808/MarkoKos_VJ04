namespace SEMAFOR
{
    partial class Forma
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
            this.gboxSemafor = new System.Windows.Forms.GroupBox();
            this.picCrvena = new System.Windows.Forms.PictureBox();
            this.picZuta = new System.Windows.Forms.PictureBox();
            this.picZelena = new System.Windows.Forms.PictureBox();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gboxSemafor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCrvena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZelena)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxSemafor
            // 
            this.gboxSemafor.Controls.Add(this.picZelena);
            this.gboxSemafor.Controls.Add(this.picZuta);
            this.gboxSemafor.Controls.Add(this.picCrvena);
            this.gboxSemafor.Location = new System.Drawing.Point(79, 24);
            this.gboxSemafor.Name = "gboxSemafor";
            this.gboxSemafor.Size = new System.Drawing.Size(116, 218);
            this.gboxSemafor.TabIndex = 0;
            this.gboxSemafor.TabStop = false;
            this.gboxSemafor.Text = "Semafor";
            // 
            // picCrvena
            // 
            this.picCrvena.Location = new System.Drawing.Point(10, 19);
            this.picCrvena.Name = "picCrvena";
            this.picCrvena.Size = new System.Drawing.Size(100, 50);
            this.picCrvena.TabIndex = 0;
            this.picCrvena.TabStop = false;
            // 
            // picZuta
            // 
            this.picZuta.Location = new System.Drawing.Point(10, 86);
            this.picZuta.Name = "picZuta";
            this.picZuta.Size = new System.Drawing.Size(100, 50);
            this.picZuta.TabIndex = 1;
            this.picZuta.TabStop = false;
            // 
            // picZelena
            // 
            this.picZelena.Location = new System.Drawing.Point(10, 157);
            this.picZelena.Name = "picZelena";
            this.picZelena.Size = new System.Drawing.Size(100, 50);
            this.picZelena.TabIndex = 2;
            this.picZelena.TabStop = false;
            // 
            // btnPokreni
            // 
            this.btnPokreni.Location = new System.Drawing.Point(79, 266);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(116, 23);
            this.btnPokreni.TabIndex = 3;
            this.btnPokreni.Text = "Pokreni";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 313);
            this.Controls.Add(this.btnPokreni);
            this.Controls.Add(this.gboxSemafor);
            this.Name = "Forma";
            this.Text = "Semafor";
            this.Load += new System.EventHandler(this.Forma_Load);
            this.gboxSemafor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCrvena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZelena)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gboxSemafor;
        public System.Windows.Forms.PictureBox picZuta;
        public System.Windows.Forms.PictureBox picCrvena;
        public System.Windows.Forms.PictureBox picZelena;
        public System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.Timer timer;
    }
}

