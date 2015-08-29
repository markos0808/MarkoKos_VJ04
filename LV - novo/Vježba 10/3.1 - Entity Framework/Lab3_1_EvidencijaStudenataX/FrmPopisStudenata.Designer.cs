namespace Lab3_1_EvidencijaStudenataX
{
    partial class FrmPopisStudenata
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btnObrisiTim = new System.Windows.Forms.Button();
            this.btnIzmijeniTim = new System.Windows.Forms.Button();
            this.btnNoviTim = new System.Windows.Forms.Button();
            this.lblTimovi = new System.Windows.Forms.Label();
            this.dgvTimovi = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oznakaTimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivProjektaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisProjektaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnObrisiStudenta = new System.Windows.Forms.Button();
            this.btnIzmijeniStudenta = new System.Windows.Forms.Button();
            this.btnNoviStudent = new System.Windows.Forms.Button();
            this.lblStudenti = new System.Windows.Forms.Label();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odabraniModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivnostiStudentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.btnObrisiTim);
            this.splitContainer.Panel1.Controls.Add(this.btnIzmijeniTim);
            this.splitContainer.Panel1.Controls.Add(this.btnNoviTim);
            this.splitContainer.Panel1.Controls.Add(this.lblTimovi);
            this.splitContainer.Panel1.Controls.Add(this.dgvTimovi);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.btnObrisiStudenta);
            this.splitContainer.Panel2.Controls.Add(this.btnIzmijeniStudenta);
            this.splitContainer.Panel2.Controls.Add(this.btnNoviStudent);
            this.splitContainer.Panel2.Controls.Add(this.lblStudenti);
            this.splitContainer.Panel2.Controls.Add(this.dgvStudenti);
            this.splitContainer.Size = new System.Drawing.Size(873, 519);
            this.splitContainer.SplitterDistance = 246;
            this.splitContainer.TabIndex = 0;
            // 
            // btnObrisiTim
            // 
            this.btnObrisiTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisiTim.Location = new System.Drawing.Point(788, 211);
            this.btnObrisiTim.Name = "btnObrisiTim";
            this.btnObrisiTim.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiTim.TabIndex = 4;
            this.btnObrisiTim.Text = "Obriši";
            this.btnObrisiTim.UseVisualStyleBackColor = true;
            this.btnObrisiTim.Click += new System.EventHandler(this.btnObrisiTim_Click);
            // 
            // btnIzmijeniTim
            // 
            this.btnIzmijeniTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzmijeniTim.Location = new System.Drawing.Point(707, 211);
            this.btnIzmijeniTim.Name = "btnIzmijeniTim";
            this.btnIzmijeniTim.Size = new System.Drawing.Size(75, 23);
            this.btnIzmijeniTim.TabIndex = 3;
            this.btnIzmijeniTim.Text = "Izmijeni";
            this.btnIzmijeniTim.UseVisualStyleBackColor = true;
            this.btnIzmijeniTim.Click += new System.EventHandler(this.btnIzmijeniTim_Click);
            // 
            // btnNoviTim
            // 
            this.btnNoviTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoviTim.Location = new System.Drawing.Point(626, 211);
            this.btnNoviTim.Name = "btnNoviTim";
            this.btnNoviTim.Size = new System.Drawing.Size(75, 23);
            this.btnNoviTim.TabIndex = 2;
            this.btnNoviTim.Text = "Novi";
            this.btnNoviTim.UseVisualStyleBackColor = true;
            this.btnNoviTim.Click += new System.EventHandler(this.btnNoviTim_Click);
            // 
            // lblTimovi
            // 
            this.lblTimovi.AutoSize = true;
            this.lblTimovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimovi.Location = new System.Drawing.Point(12, 9);
            this.lblTimovi.Name = "lblTimovi";
            this.lblTimovi.Size = new System.Drawing.Size(48, 13);
            this.lblTimovi.TabIndex = 1;
            this.lblTimovi.Text = "Timovi:";
            // 
            // dgvTimovi
            // 
            this.dgvTimovi.AllowUserToAddRows = false;
            this.dgvTimovi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTimovi.AutoGenerateColumns = false;
            this.dgvTimovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.oznakaTimaDataGridViewTextBoxColumn,
            this.nazivProjektaDataGridViewTextBoxColumn,
            this.opisProjektaDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn,
            this.studentiDataGridViewTextBoxColumn});
            this.dgvTimovi.DataSource = this.timBindingSource;
            this.dgvTimovi.Location = new System.Drawing.Point(15, 25);
            this.dgvTimovi.MultiSelect = false;
            this.dgvTimovi.Name = "dgvTimovi";
            this.dgvTimovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimovi.Size = new System.Drawing.Size(846, 180);
            this.dgvTimovi.TabIndex = 0;
            this.dgvTimovi.SelectionChanged += new System.EventHandler(this.dgvTimovi_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // oznakaTimaDataGridViewTextBoxColumn
            // 
            this.oznakaTimaDataGridViewTextBoxColumn.DataPropertyName = "OznakaTima";
            this.oznakaTimaDataGridViewTextBoxColumn.HeaderText = "OznakaTima";
            this.oznakaTimaDataGridViewTextBoxColumn.Name = "oznakaTimaDataGridViewTextBoxColumn";
            // 
            // nazivProjektaDataGridViewTextBoxColumn
            // 
            this.nazivProjektaDataGridViewTextBoxColumn.DataPropertyName = "NazivProjekta";
            this.nazivProjektaDataGridViewTextBoxColumn.HeaderText = "NazivProjekta";
            this.nazivProjektaDataGridViewTextBoxColumn.Name = "nazivProjektaDataGridViewTextBoxColumn";
            // 
            // opisProjektaDataGridViewTextBoxColumn
            // 
            this.opisProjektaDataGridViewTextBoxColumn.DataPropertyName = "OpisProjekta";
            this.opisProjektaDataGridViewTextBoxColumn.HeaderText = "OpisProjekta";
            this.opisProjektaDataGridViewTextBoxColumn.Name = "opisProjektaDataGridViewTextBoxColumn";
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            // 
            // studentiDataGridViewTextBoxColumn
            // 
            this.studentiDataGridViewTextBoxColumn.DataPropertyName = "Studenti";
            this.studentiDataGridViewTextBoxColumn.HeaderText = "Studenti";
            this.studentiDataGridViewTextBoxColumn.Name = "studentiDataGridViewTextBoxColumn";
            this.studentiDataGridViewTextBoxColumn.Visible = false;
            // 
            // timBindingSource1
            // 
            this.timBindingSource1.DataSource = typeof(Lab3_1_EvidencijaStudenataX.Tim);
            // 
            // btnObrisiStudenta
            // 
            this.btnObrisiStudenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisiStudenta.Location = new System.Drawing.Point(788, 234);
            this.btnObrisiStudenta.Name = "btnObrisiStudenta";
            this.btnObrisiStudenta.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiStudenta.TabIndex = 9;
            this.btnObrisiStudenta.Text = "Obriši";
            this.btnObrisiStudenta.UseVisualStyleBackColor = true;
            // 
            // btnIzmijeniStudenta
            // 
            this.btnIzmijeniStudenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzmijeniStudenta.Location = new System.Drawing.Point(707, 234);
            this.btnIzmijeniStudenta.Name = "btnIzmijeniStudenta";
            this.btnIzmijeniStudenta.Size = new System.Drawing.Size(75, 23);
            this.btnIzmijeniStudenta.TabIndex = 8;
            this.btnIzmijeniStudenta.Text = "Izmijeni";
            this.btnIzmijeniStudenta.UseVisualStyleBackColor = true;
            // 
            // btnNoviStudent
            // 
            this.btnNoviStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoviStudent.Location = new System.Drawing.Point(626, 234);
            this.btnNoviStudent.Name = "btnNoviStudent";
            this.btnNoviStudent.Size = new System.Drawing.Size(75, 23);
            this.btnNoviStudent.TabIndex = 7;
            this.btnNoviStudent.Text = "Novi";
            this.btnNoviStudent.UseVisualStyleBackColor = true;
            this.btnNoviStudent.Click += new System.EventHandler(this.btnNoviStudent_Click);
            // 
            // lblStudenti
            // 
            this.lblStudenti.AutoSize = true;
            this.lblStudenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStudenti.Location = new System.Drawing.Point(12, 10);
            this.lblStudenti.Name = "lblStudenti";
            this.lblStudenti.Size = new System.Drawing.Size(58, 13);
            this.lblStudenti.TabIndex = 6;
            this.lblStudenti.Text = "Studenti:";
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.AllowUserToAddRows = false;
            this.dgvStudenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudenti.AutoGenerateColumns = false;
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.odabraniModelDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn1,
            this.timIdDataGridViewTextBoxColumn,
            this.aktivnostiStudentaDataGridViewTextBoxColumn,
            this.timDataGridViewTextBoxColumn});
            this.dgvStudenti.DataSource = this.studentBindingSource;
            this.dgvStudenti.Location = new System.Drawing.Point(15, 26);
            this.dgvStudenti.MultiSelect = false;
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudenti.Size = new System.Drawing.Size(846, 202);
            this.dgvStudenti.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // odabraniModelDataGridViewTextBoxColumn
            // 
            this.odabraniModelDataGridViewTextBoxColumn.DataPropertyName = "OdabraniModel";
            this.odabraniModelDataGridViewTextBoxColumn.HeaderText = "OdabraniModel";
            this.odabraniModelDataGridViewTextBoxColumn.Name = "odabraniModelDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // napomenaDataGridViewTextBoxColumn1
            // 
            this.napomenaDataGridViewTextBoxColumn1.DataPropertyName = "Napomena";
            this.napomenaDataGridViewTextBoxColumn1.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn1.Name = "napomenaDataGridViewTextBoxColumn1";
            // 
            // timIdDataGridViewTextBoxColumn
            // 
            this.timIdDataGridViewTextBoxColumn.DataPropertyName = "TimId";
            this.timIdDataGridViewTextBoxColumn.HeaderText = "TimId";
            this.timIdDataGridViewTextBoxColumn.Name = "timIdDataGridViewTextBoxColumn";
            this.timIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // aktivnostiStudentaDataGridViewTextBoxColumn
            // 
            this.aktivnostiStudentaDataGridViewTextBoxColumn.DataPropertyName = "AktivnostiStudenta";
            this.aktivnostiStudentaDataGridViewTextBoxColumn.HeaderText = "AktivnostiStudenta";
            this.aktivnostiStudentaDataGridViewTextBoxColumn.Name = "aktivnostiStudentaDataGridViewTextBoxColumn";
            this.aktivnostiStudentaDataGridViewTextBoxColumn.Visible = false;
            // 
            // timDataGridViewTextBoxColumn
            // 
            this.timDataGridViewTextBoxColumn.DataPropertyName = "Tim";
            this.timDataGridViewTextBoxColumn.HeaderText = "Tim";
            this.timDataGridViewTextBoxColumn.Name = "timDataGridViewTextBoxColumn";
            this.timDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Lab3_1_EvidencijaStudenataX.Student);
            // 
            // timBindingSource
            // 
            this.timBindingSource.DataSource = typeof(Lab3_1_EvidencijaStudenataX.Tim);
            // 
            // FrmPopisStudenata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 519);
            this.Controls.Add(this.splitContainer);
            this.Name = "FrmPopisStudenata";
            this.Text = "Popis studenata";
            this.Load += new System.EventHandler(this.FrmPopisStudenata_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label lblTimovi;
        private System.Windows.Forms.DataGridView dgvTimovi;
        private System.Windows.Forms.Button btnObrisiTim;
        private System.Windows.Forms.Button btnIzmijeniTim;
        private System.Windows.Forms.Button btnNoviTim;
        private System.Windows.Forms.Button btnObrisiStudenta;
        private System.Windows.Forms.Button btnIzmijeniStudenta;
        private System.Windows.Forms.Button btnNoviStudent;
        private System.Windows.Forms.Label lblStudenti;
        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.BindingSource timBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odabraniModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktivnostiStudentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oznakaTimaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivProjektaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisProjektaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource timBindingSource1;
    }
}