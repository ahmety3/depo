namespace BiletYönetimSistemi
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.MskNo = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.CmbNereden = new System.Windows.Forms.ComboBox();
            this.CmbNereye = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neredenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nereyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gidisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dönüsTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yonTekYonCiftDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.koltukSecimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUcakBiletYonetimSistemiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.biletYönetimSistemiDataSet1 = new BiletYönetimSistemi.BiletYönetimSistemiDataSet1();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbKoltuk = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbl_UcakBiletYonetimSistemiTableAdapter1 = new BiletYönetimSistemi.BiletYönetimSistemiDataSet1TableAdapters.Tbl_UcakBiletYonetimSistemiTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUcakBiletYonetimSistemiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletYönetimSistemiDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(132, 27);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(216, 22);
            this.TxtAd.TabIndex = 1;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(132, 55);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(216, 22);
            this.TxtSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nereden:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nereye:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gidiş Tarihi:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(58, 233);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 20);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.Text = "Tek Yön";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(163, 233);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 20);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.Text = "Çift Yön";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Dönüş Tarihi:";
            // 
            // MskTc
            // 
            this.MskTc.Location = new System.Drawing.Point(132, 84);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(216, 22);
            this.MskTc.TabIndex = 18;
            this.MskTc.ValidatingType = typeof(int);
            // 
            // MskNo
            // 
            this.MskNo.Location = new System.Drawing.Point(132, 112);
            this.MskNo.Mask = "(999) 000-0000";
            this.MskNo.Name = "MskNo";
            this.MskNo.Size = new System.Drawing.Size(216, 22);
            this.MskNo.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 195);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 22);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(132, 263);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(216, 22);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // CmbNereden
            // 
            this.CmbNereden.FormattingEnabled = true;
            this.CmbNereden.Items.AddRange(new object[] {
            "Adana",
            "",
            "Adıyaman",
            "",
            "Afyonkarahisar",
            "",
            "Ağrı",
            "",
            "Amasya",
            "",
            "Ankara",
            "",
            "Antalya",
            "",
            "Artvin",
            "",
            "Aydın",
            "",
            "Balıkesir",
            "",
            "Bilecik",
            "",
            "Bingöl",
            "",
            "Bitlis",
            "",
            "Bolu",
            "",
            "Burdur",
            "",
            "Bursa",
            "",
            "Çanakkale",
            "",
            "Çankırı",
            "",
            "Çorum",
            "",
            "Denizli",
            "",
            "Diyarbakır",
            "",
            "Edirne",
            "",
            "Elazığ",
            "",
            "Erzincan",
            "",
            "Erzurum",
            "",
            "Eskişehir",
            "",
            "Gaziantep",
            "",
            "Giresun",
            "",
            "Gümüşhane",
            "",
            "Hakkari",
            "",
            "Hatay",
            "",
            "Iğdır",
            "",
            "Isparta",
            "",
            "İstanbul",
            "",
            "İzmir",
            "",
            "Kahramanmaraş",
            "",
            "Karabük",
            "",
            "Karaman",
            "",
            "Kars",
            "",
            "Kastamonu",
            "",
            "Kayseri",
            "",
            "Kırıkkale",
            "",
            "Kırklareli",
            "",
            "Kırşehir",
            "",
            "Kilis",
            "",
            "Kocaeli",
            "",
            "Konya",
            "",
            "Kütahya",
            "",
            "Malatya",
            "",
            "Manisa",
            "",
            "Mardin",
            "",
            "Mersin",
            "",
            "Muğla",
            "",
            "Muş",
            "",
            "Nevşehir",
            "",
            "Niğde",
            "",
            "Ordu",
            "",
            "Osmaniye",
            "",
            "Rize",
            "",
            "Sakarya",
            "",
            "Samsun",
            "",
            "Şanlıurfa",
            "",
            "Siirt",
            "",
            "Sinop",
            "",
            "Şırnak",
            "",
            "Sivas",
            "",
            "Tekirdağ",
            "",
            "Tokat",
            "",
            "Trabzon",
            "",
            "Tunceli",
            "",
            "Uşak",
            "",
            "Van",
            "",
            "Yalova",
            "",
            "Yozgat",
            "",
            "Zonguldak"});
            this.CmbNereden.Location = new System.Drawing.Point(132, 141);
            this.CmbNereden.Name = "CmbNereden";
            this.CmbNereden.Size = new System.Drawing.Size(216, 24);
            this.CmbNereden.TabIndex = 22;
            // 
            // CmbNereye
            // 
            this.CmbNereye.FormattingEnabled = true;
            this.CmbNereye.Items.AddRange(new object[] {
            "Adana",
            "",
            "Adıyaman",
            "",
            "Afyonkarahisar",
            "",
            "Ağrı",
            "",
            "Amasya",
            "",
            "Ankara",
            "",
            "Antalya",
            "",
            "Artvin",
            "",
            "Aydın",
            "",
            "Balıkesir",
            "",
            "Bilecik",
            "",
            "Bingöl",
            "",
            "Bitlis",
            "",
            "Bolu",
            "",
            "Burdur",
            "",
            "Bursa",
            "",
            "Çanakkale",
            "",
            "Çankırı",
            "",
            "Çorum",
            "",
            "Denizli",
            "",
            "Diyarbakır",
            "",
            "Edirne",
            "",
            "Elazığ",
            "",
            "Erzincan",
            "",
            "Erzurum",
            "",
            "Eskişehir",
            "",
            "Gaziantep",
            "",
            "Giresun",
            "",
            "Gümüşhane",
            "",
            "Hakkari",
            "",
            "Hatay",
            "",
            "Iğdır",
            "",
            "Isparta",
            "",
            "İstanbul",
            "",
            "İzmir",
            "",
            "Kahramanmaraş",
            "",
            "Karabük",
            "",
            "Karaman",
            "",
            "Kars",
            "",
            "Kastamonu",
            "",
            "Kayseri",
            "",
            "Kırıkkale",
            "",
            "Kırklareli",
            "",
            "Kırşehir",
            "",
            "Kilis",
            "",
            "Kocaeli",
            "",
            "Konya",
            "",
            "Kütahya",
            "",
            "Malatya",
            "",
            "Manisa",
            "",
            "Mardin",
            "",
            "Mersin",
            "",
            "Muğla",
            "",
            "Muş",
            "",
            "Nevşehir",
            "",
            "Niğde",
            "",
            "Ordu",
            "",
            "Osmaniye",
            "",
            "Rize",
            "",
            "Sakarya",
            "",
            "Samsun",
            "",
            "Şanlıurfa",
            "",
            "Siirt",
            "",
            "Sinop",
            "",
            "Şırnak",
            "",
            "Sivas",
            "",
            "Tekirdağ",
            "",
            "Tokat",
            "",
            "Trabzon",
            "",
            "Tunceli",
            "",
            "Uşak",
            "",
            "Van",
            "",
            "Yalova",
            "",
            "Yozgat",
            "",
            "Zonguldak"});
            this.CmbNereye.Location = new System.Drawing.Point(132, 167);
            this.CmbNereye.Name = "CmbNereye";
            this.CmbNereye.Size = new System.Drawing.Size(216, 24);
            this.CmbNereye.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(30, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1310, 216);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veriler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.tcNoDataGridViewTextBoxColumn,
            this.telefonNoDataGridViewTextBoxColumn,
            this.neredenDataGridViewTextBoxColumn,
            this.nereyeDataGridViewTextBoxColumn,
            this.gidisTarihiDataGridViewTextBoxColumn,
            this.dönüsTarihiDataGridViewTextBoxColumn,
            this.yonTekYonCiftDataGridViewCheckBoxColumn,
            this.koltukSecimiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblUcakBiletYonetimSistemiBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1304, 195);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // tcNoDataGridViewTextBoxColumn
            // 
            this.tcNoDataGridViewTextBoxColumn.DataPropertyName = "TcNo";
            this.tcNoDataGridViewTextBoxColumn.HeaderText = "TcNo";
            this.tcNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcNoDataGridViewTextBoxColumn.Name = "tcNoDataGridViewTextBoxColumn";
            this.tcNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonNoDataGridViewTextBoxColumn
            // 
            this.telefonNoDataGridViewTextBoxColumn.DataPropertyName = "TelefonNo";
            this.telefonNoDataGridViewTextBoxColumn.HeaderText = "TelefonNo";
            this.telefonNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonNoDataGridViewTextBoxColumn.Name = "telefonNoDataGridViewTextBoxColumn";
            this.telefonNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // neredenDataGridViewTextBoxColumn
            // 
            this.neredenDataGridViewTextBoxColumn.DataPropertyName = "Nereden";
            this.neredenDataGridViewTextBoxColumn.HeaderText = "Nereden";
            this.neredenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.neredenDataGridViewTextBoxColumn.Name = "neredenDataGridViewTextBoxColumn";
            this.neredenDataGridViewTextBoxColumn.Width = 125;
            // 
            // nereyeDataGridViewTextBoxColumn
            // 
            this.nereyeDataGridViewTextBoxColumn.DataPropertyName = "Nereye";
            this.nereyeDataGridViewTextBoxColumn.HeaderText = "Nereye";
            this.nereyeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nereyeDataGridViewTextBoxColumn.Name = "nereyeDataGridViewTextBoxColumn";
            this.nereyeDataGridViewTextBoxColumn.Width = 125;
            // 
            // gidisTarihiDataGridViewTextBoxColumn
            // 
            this.gidisTarihiDataGridViewTextBoxColumn.DataPropertyName = "GidisTarihi";
            this.gidisTarihiDataGridViewTextBoxColumn.HeaderText = "GidisTarihi";
            this.gidisTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gidisTarihiDataGridViewTextBoxColumn.Name = "gidisTarihiDataGridViewTextBoxColumn";
            this.gidisTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // dönüsTarihiDataGridViewTextBoxColumn
            // 
            this.dönüsTarihiDataGridViewTextBoxColumn.DataPropertyName = "DönüsTarihi";
            this.dönüsTarihiDataGridViewTextBoxColumn.HeaderText = "DönüsTarihi";
            this.dönüsTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dönüsTarihiDataGridViewTextBoxColumn.Name = "dönüsTarihiDataGridViewTextBoxColumn";
            this.dönüsTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // yonTekYonCiftDataGridViewCheckBoxColumn
            // 
            this.yonTekYonCiftDataGridViewCheckBoxColumn.DataPropertyName = "YonTekYonCift";
            this.yonTekYonCiftDataGridViewCheckBoxColumn.HeaderText = "YonTekYonCift";
            this.yonTekYonCiftDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.yonTekYonCiftDataGridViewCheckBoxColumn.Name = "yonTekYonCiftDataGridViewCheckBoxColumn";
            this.yonTekYonCiftDataGridViewCheckBoxColumn.Width = 125;
            // 
            // koltukSecimiDataGridViewTextBoxColumn
            // 
            this.koltukSecimiDataGridViewTextBoxColumn.DataPropertyName = "KoltukSecimi";
            this.koltukSecimiDataGridViewTextBoxColumn.HeaderText = "KoltukSecimi";
            this.koltukSecimiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.koltukSecimiDataGridViewTextBoxColumn.Name = "koltukSecimiDataGridViewTextBoxColumn";
            this.koltukSecimiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblUcakBiletYonetimSistemiBindingSource1
            // 
            this.tblUcakBiletYonetimSistemiBindingSource1.DataMember = "Tbl_UcakBiletYonetimSistemi";
            this.tblUcakBiletYonetimSistemiBindingSource1.DataSource = this.biletYönetimSistemiDataSet1;
            // 
            // biletYönetimSistemiDataSet1
            // 
            this.biletYönetimSistemiDataSet1.DataSetName = "BiletYönetimSistemiDataSet1";
            this.biletYönetimSistemiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(572, 67);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(207, 82);
            this.BtnListele.TabIndex = 25;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(785, 67);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(207, 82);
            this.BtnKaydet.TabIndex = 26;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(998, 67);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(207, 82);
            this.BtnSil.TabIndex = 28;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Location = new System.Drawing.Point(572, 155);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(207, 82);
            this.BtnGüncelle.TabIndex = 29;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Location = new System.Drawing.Point(785, 155);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(207, 82);
            this.BtnTemizle.TabIndex = 31;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Koltuk Seçimi:";
            // 
            // CmbKoltuk
            // 
            this.CmbKoltuk.FormattingEnabled = true;
            this.CmbKoltuk.Location = new System.Drawing.Point(132, 291);
            this.CmbKoltuk.Name = "CmbKoltuk";
            this.CmbKoltuk.Size = new System.Drawing.Size(216, 24);
            this.CmbKoltuk.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(998, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 82);
            this.button1.TabIndex = 35;
            this.button1.Text = "Uygulamayı Kapat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(194, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "label10 ";
            this.label10.Visible = false;
            // 
            // tbl_UcakBiletYonetimSistemiTableAdapter1
            // 
            this.tbl_UcakBiletYonetimSistemiTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1376, 604);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CmbKoltuk);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CmbNereye);
            this.Controls.Add(this.CmbNereden);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.MskNo);
            this.Controls.Add(this.MskTc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Uçak Bilet Yönetim Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUcakBiletYonetimSistemiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletYönetimSistemiDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.MaskedTextBox MskNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox CmbNereden;
        private System.Windows.Forms.ComboBox CmbNereye;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbKoltuk;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn neredenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nereyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dönüsTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn yonTekYonCiftDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koltukSecimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private BiletYönetimSistemiDataSet1 biletYönetimSistemiDataSet1;
        private System.Windows.Forms.BindingSource tblUcakBiletYonetimSistemiBindingSource1;
        private BiletYönetimSistemiDataSet1TableAdapters.Tbl_UcakBiletYonetimSistemiTableAdapter tbl_UcakBiletYonetimSistemiTableAdapter1;
    }
}

