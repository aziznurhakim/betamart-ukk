namespace Betamart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel = new System.Windows.Forms.Panel();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.daftarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new Betamart.AppData();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.daftarTableAdapter = new Betamart.AppDataTableAdapters.DaftarTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.betamartDataSet = new Betamart.betamartDataSet();
            this.daftarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.daftarTableAdapter1 = new Betamart.betamartDataSetTableAdapters.DaftarTableAdapter();
            this.betamartDataSet1 = new Betamart.betamartDataSet1();
            this.daftarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.daftarTableAdapter2 = new Betamart.betamartDataSet1TableAdapters.DaftarTableAdapter();
            this.daftarBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.betamartDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.betamartDataSet3 = new Betamart.betamartDataSet3();
            this.betamartDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.betamartDataSet2 = new Betamart.betamartDataSet2();
            this.betamartDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.betamartDataSet4 = new Betamart.betamartDataSet4();
            this.daftarBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.daftarTableAdapter3 = new Betamart.betamartDataSet4TableAdapters.DaftarTableAdapter();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daftarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.dateTimePicker1);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.txtHarga);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.txtStok);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.txtNama);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txtKode);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.btnBrowse);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(32, 137);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(748, 186);
            this.panel.TabIndex = 0;
            // 
            // txtHarga
            // 
            this.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHarga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource4, "Harga", true));
            this.txtHarga.Location = new System.Drawing.Point(310, 114);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(4);
            this.txtHarga.Multiline = true;
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(416, 22);
            this.txtHarga.TabIndex = 3;
            // 
            // daftarBindingSource
            // 
            this.daftarBindingSource.DataMember = "Daftar";
            this.daftarBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(169, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Harga";
            // 
            // txtStok
            // 
            this.txtStok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStok.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource4, "Stok", true));
            this.txtStok.Location = new System.Drawing.Point(310, 82);
            this.txtStok.Margin = new System.Windows.Forms.Padding(4);
            this.txtStok.Multiline = true;
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(416, 22);
            this.txtStok.TabIndex = 2;
            this.txtStok.TextChanged += new System.EventHandler(this.txtStok_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(169, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stok";
            // 
            // txtNama
            // 
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource4, "NamaBarang", true));
            this.txtNama.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNama.Location = new System.Drawing.Point(310, 18);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4);
            this.txtNama.Multiline = true;
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(416, 22);
            this.txtNama.TabIndex = 0;
            this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(169, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama Barang";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtKode
            // 
            this.txtKode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource4, "KodeBarang", true));
            this.txtKode.Location = new System.Drawing.Point(310, 50);
            this.txtKode.Margin = new System.Windows.Forms.Padding(4);
            this.txtKode.Multiline = true;
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(416, 22);
            this.txtKode.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.daftarBindingSource4, "Image", true));
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.Color.Transparent;
            this.btnBrowse.Location = new System.Drawing.Point(30, 144);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(169, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kode Barang";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnNew.Location = new System.Drawing.Point(356, 547);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 28);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnEdit.Location = new System.Drawing.Point(464, 547);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 28);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.daftarBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(32, 340);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(748, 199);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnCancel.Location = new System.Drawing.Point(572, 547);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnSave.Location = new System.Drawing.Point(680, 547);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // daftarTableAdapter
            // 
            this.daftarTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(308, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(221, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Futura Md BT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(171, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Expaired Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.daftarBindingSource4, "Expaired Daye", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(310, 145);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // betamartDataSet
            // 
            this.betamartDataSet.DataSetName = "betamartDataSet";
            this.betamartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // daftarBindingSource1
            // 
            this.daftarBindingSource1.DataMember = "Daftar";
            this.daftarBindingSource1.DataSource = this.betamartDataSet;
            // 
            // daftarTableAdapter1
            // 
            this.daftarTableAdapter1.ClearBeforeFill = true;
            // 
            // betamartDataSet1
            // 
            this.betamartDataSet1.DataSetName = "betamartDataSet1";
            this.betamartDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // daftarBindingSource2
            // 
            this.daftarBindingSource2.DataMember = "Daftar";
            this.daftarBindingSource2.DataSource = this.betamartDataSet1;
            // 
            // daftarTableAdapter2
            // 
            this.daftarTableAdapter2.ClearBeforeFill = true;
            // 
            // daftarBindingSource3
            // 
            this.daftarBindingSource3.DataMember = "Daftar";
            this.daftarBindingSource3.DataSource = this.betamartDataSet1;
            // 
            // betamartDataSet1BindingSource
            // 
            this.betamartDataSet1BindingSource.DataSource = this.betamartDataSet1;
            this.betamartDataSet1BindingSource.Position = 0;
            // 
            // betamartDataSet3
            // 
            this.betamartDataSet3.DataSetName = "betamartDataSet3";
            this.betamartDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // betamartDataSet3BindingSource
            // 
            this.betamartDataSet3BindingSource.DataSource = this.betamartDataSet3;
            this.betamartDataSet3BindingSource.Position = 0;
            // 
            // betamartDataSet2
            // 
            this.betamartDataSet2.DataSetName = "betamartDataSet2";
            this.betamartDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // betamartDataSet2BindingSource
            // 
            this.betamartDataSet2BindingSource.DataSource = this.betamartDataSet2;
            this.betamartDataSet2BindingSource.Position = 0;
            // 
            // betamartDataSet4
            // 
            this.betamartDataSet4.DataSetName = "betamartDataSet4";
            this.betamartDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // daftarBindingSource4
            // 
            this.daftarBindingSource4.DataMember = "Daftar";
            this.daftarBindingSource4.DataSource = this.betamartDataSet4;
            // 
            // daftarTableAdapter3
            // 
            this.daftarTableAdapter3.ClearBeforeFill = true;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.Width = 125;
            // 
            // kodeBarangDataGridViewTextBoxColumn
            // 
            this.kodeBarangDataGridViewTextBoxColumn.DataPropertyName = "KodeBarang";
            this.kodeBarangDataGridViewTextBoxColumn.HeaderText = "KodeBarang";
            this.kodeBarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodeBarangDataGridViewTextBoxColumn.Name = "kodeBarangDataGridViewTextBoxColumn";
            this.kodeBarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaBarangDataGridViewTextBoxColumn
            // 
            this.namaBarangDataGridViewTextBoxColumn.DataPropertyName = "NamaBarang";
            this.namaBarangDataGridViewTextBoxColumn.HeaderText = "NamaBarang";
            this.namaBarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaBarangDataGridViewTextBoxColumn.Name = "namaBarangDataGridViewTextBoxColumn";
            this.namaBarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            this.stokDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.Width = 125;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.MinimumWidth = 6;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "No";
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KodeBarang";
            this.dataGridViewTextBoxColumn2.HeaderText = "KodeBarang";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NamaBarang";
            this.dataGridViewTextBoxColumn3.HeaderText = "NamaBarang";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Stok";
            this.dataGridViewTextBoxColumn4.HeaderText = "Stok";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Harga";
            this.dataGridViewTextBoxColumn5.HeaderText = "Harga";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Image";
            this.dataGridViewImageColumn1.HeaderText = "Image";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Expaired Daye";
            this.dataGridViewTextBoxColumn6.HeaderText = "Expaired Daye";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(822, 597);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daftarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betamartDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private AppData appData;
        private System.Windows.Forms.BindingSource daftarBindingSource;
        private AppDataTableAdapters.DaftarTableAdapter daftarTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private betamartDataSet betamartDataSet;
        private System.Windows.Forms.BindingSource daftarBindingSource1;
        private betamartDataSetTableAdapters.DaftarTableAdapter daftarTableAdapter1;
        private betamartDataSet1 betamartDataSet1;
        private System.Windows.Forms.BindingSource daftarBindingSource2;
        private betamartDataSet1TableAdapters.DaftarTableAdapter daftarTableAdapter2;
        private System.Windows.Forms.BindingSource daftarBindingSource3;
        private System.Windows.Forms.BindingSource betamartDataSet1BindingSource;
        private betamartDataSet3 betamartDataSet3;
        private System.Windows.Forms.BindingSource betamartDataSet3BindingSource;
        private betamartDataSet2 betamartDataSet2;
        private System.Windows.Forms.BindingSource betamartDataSet2BindingSource;
        private betamartDataSet4 betamartDataSet4;
        private System.Windows.Forms.BindingSource daftarBindingSource4;
        private betamartDataSet4TableAdapters.DaftarTableAdapter daftarTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
    }
}

