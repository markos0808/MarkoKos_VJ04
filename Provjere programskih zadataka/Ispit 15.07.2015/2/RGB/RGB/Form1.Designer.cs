namespace RGB
{
    partial class frmMain
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
            this.nudRed = new System.Windows.Forms.NumericUpDown();
            this.nudGreen = new System.Windows.Forms.NumericUpDown();
            this.nudBlue = new System.Windows.Forms.NumericUpDown();
            this.panelPrikazBoje = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvBoje = new System.Windows.Forms.DataGridView();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoje)).BeginInit();
            this.SuspendLayout();
            // 
            // nudRed
            // 
            this.nudRed.Location = new System.Drawing.Point(98, 21);
            this.nudRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRed.Name = "nudRed";
            this.nudRed.Size = new System.Drawing.Size(120, 20);
            this.nudRed.TabIndex = 0;
            this.nudRed.ValueChanged += new System.EventHandler(this.nudRed_ValueChanged);
            // 
            // nudGreen
            // 
            this.nudGreen.Location = new System.Drawing.Point(98, 56);
            this.nudGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreen.Name = "nudGreen";
            this.nudGreen.Size = new System.Drawing.Size(120, 20);
            this.nudGreen.TabIndex = 1;
            this.nudGreen.ValueChanged += new System.EventHandler(this.nudRed_ValueChanged);
            // 
            // nudBlue
            // 
            this.nudBlue.Location = new System.Drawing.Point(98, 92);
            this.nudBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlue.Name = "nudBlue";
            this.nudBlue.Size = new System.Drawing.Size(120, 20);
            this.nudBlue.TabIndex = 2;
            this.nudBlue.ValueChanged += new System.EventHandler(this.nudRed_ValueChanged);
            // 
            // panelPrikazBoje
            // 
            this.panelPrikazBoje.BackColor = System.Drawing.Color.Red;
            this.panelPrikazBoje.Location = new System.Drawing.Point(247, 21);
            this.panelPrikazBoje.Name = "panelPrikazBoje";
            this.panelPrikazBoje.Size = new System.Drawing.Size(200, 128);
            this.panelPrikazBoje.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 129);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 20);
            this.txtName.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(372, 164);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvBoje
            // 
            this.dgvBoje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoje.Location = new System.Drawing.Point(12, 202);
            this.dgvBoje.Name = "dgvBoje";
            this.dgvBoje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBoje.Size = new System.Drawing.Size(435, 202);
            this.dgvBoje.TabIndex = 5;
            this.dgvBoje.SelectionChanged += new System.EventHandler(this.dgvBoje_SelectionChanged);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(28, 28);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(57, 13);
            this.lblRed.TabIndex = 6;
            this.lblRed.Text = "Red . . . . .";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(28, 63);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(66, 13);
            this.lblGreen.TabIndex = 7;
            this.lblGreen.Text = "Green . . . . .";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(28, 99);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(58, 13);
            this.lblBlue.TabIndex = 8;
            this.lblBlue.Text = "Blue . . . . .";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 136);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name . . . . .";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 416);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.dgvBoje);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panelPrikazBoje);
            this.Controls.Add(this.nudBlue);
            this.Controls.Add(this.nudGreen);
            this.Controls.Add(this.nudRed);
            this.Name = "frmMain";
            this.Text = "Software Engineering - FOI 2015";
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudGreen;
        public System.Windows.Forms.Label lblRed;
        public System.Windows.Forms.NumericUpDown nudRed;
        public System.Windows.Forms.Label lblGreen;
        public System.Windows.Forms.NumericUpDown nudBlue;
        public System.Windows.Forms.Label lblBlue;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Panel panelPrikazBoje;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.DataGridView dgvBoje;
    }
}

