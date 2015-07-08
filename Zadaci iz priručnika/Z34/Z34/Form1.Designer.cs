namespace Z34
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
            this.lblKvadrant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKvadrant
            // 
            this.lblKvadrant.AutoSize = true;
            this.lblKvadrant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKvadrant.Location = new System.Drawing.Point(99, 116);
            this.lblKvadrant.Name = "lblKvadrant";
            this.lblKvadrant.Size = new System.Drawing.Size(73, 17);
            this.lblKvadrant.TabIndex = 0;
            this.lblKvadrant.Text = "Kvadrant";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblKvadrant);
            this.Name = "Form1";
            this.Text = "Kvadrant";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblKvadrant;

    }
}

