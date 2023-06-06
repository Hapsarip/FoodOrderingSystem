namespace Chapter_5
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
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblPesanan = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblMeja = new System.Windows.Forms.Label();
            this.lblRef = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblWaktu = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblMenu1 = new System.Windows.Forms.Label();
            this.lblMenu2 = new System.Windows.Forms.Label();
            this.lblMenu3 = new System.Windows.Forms.Label();
            this.lblMenu4 = new System.Windows.Forms.Label();
            this.lblMenu5 = new System.Windows.Forms.Label();
            this.lblMenu6 = new System.Windows.Forms.Label();
            this.lblMenu7 = new System.Windows.Forms.Label();
            this.lblMenu8 = new System.Windows.Forms.Label();
            this.lblMenu9 = new System.Windows.Forms.Label();
            this.lblHarga1 = new System.Windows.Forms.Label();
            this.lblHarga2 = new System.Windows.Forms.Label();
            this.lblHarga3 = new System.Windows.Forms.Label();
            this.lblHarga4 = new System.Windows.Forms.Label();
            this.lblHarga5 = new System.Windows.Forms.Label();
            this.lblHarga6 = new System.Windows.Forms.Label();
            this.lblHarga7 = new System.Windows.Forms.Label();
            this.lblHarga8 = new System.Windows.Forms.Label();
            this.lblHarga9 = new System.Windows.Forms.Label();
            this.GB = new System.Windows.Forms.GroupBox();
            this.btPesan = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.pbQR = new System.Windows.Forms.PictureBox();
            this.foodOrderDataSet = new FoodOrderingSystem.FoodOrderDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new FoodOrderingSystem.FoodOrderDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new FoodOrderingSystem.FoodOrderDataSetTableAdapters.TableAdapterManager();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbMeja = new System.Windows.Forms.TextBox();
            this.tbRef = new System.Windows.Forms.TextBox();
            this.tbTanggal = new System.Windows.Forms.TextBox();
            this.tbWaktu = new System.Windows.Forms.TextBox();
            this.tbJumlah1 = new System.Windows.Forms.TextBox();
            this.tbJumlah2 = new System.Windows.Forms.TextBox();
            this.tbJumlah3 = new System.Windows.Forms.TextBox();
            this.tbJumlah4 = new System.Windows.Forms.TextBox();
            this.tbJumlah5 = new System.Windows.Forms.TextBox();
            this.tbJumlah6 = new System.Windows.Forms.TextBox();
            this.tbJumlah7 = new System.Windows.Forms.TextBox();
            this.tbJumlah8 = new System.Windows.Forms.TextBox();
            this.tbNote1 = new System.Windows.Forms.TextBox();
            this.tbNote2 = new System.Windows.Forms.TextBox();
            this.tbNote3 = new System.Windows.Forms.TextBox();
            this.tbNote4 = new System.Windows.Forms.TextBox();
            this.tbNote5 = new System.Windows.Forms.TextBox();
            this.tbNote6 = new System.Windows.Forms.TextBox();
            this.tbNote7 = new System.Windows.Forms.TextBox();
            this.tbNote8 = new System.Windows.Forms.TextBox();
            this.tbNote9 = new System.Windows.Forms.TextBox();
            this.tbJumlah9 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbQR = new System.Windows.Forms.TextBox();
            this.GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodOrderDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(420, 39);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(1084, 50);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "SISTEM PEMESANAN MAKANAN DI RUMAH MAKAN GUDEG";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(55, 132);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(208, 35);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "INFO PEMESAN";
            // 
            // lblPesanan
            // 
            this.lblPesanan.AutoSize = true;
            this.lblPesanan.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesanan.Location = new System.Drawing.Point(55, 381);
            this.lblPesanan.Name = "lblPesanan";
            this.lblPesanan.Size = new System.Drawing.Size(250, 35);
            this.lblPesanan.TabIndex = 2;
            this.lblPesanan.Text = "DAFTAR PESANAN";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(56, 192);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(164, 30);
            this.lblNama.TabIndex = 3;
            this.lblNama.Text = "Nama                :";
            // 
            // lblMeja
            // 
            this.lblMeja.AutoSize = true;
            this.lblMeja.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeja.Location = new System.Drawing.Point(56, 249);
            this.lblMeja.Name = "lblMeja";
            this.lblMeja.Size = new System.Drawing.Size(165, 30);
            this.lblMeja.TabIndex = 4;
            this.lblMeja.Text = "No. Meja          :";
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRef.Location = new System.Drawing.Point(56, 305);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(166, 30);
            this.lblRef.TabIndex = 5;
            this.lblRef.Text = "No. Referensi :";
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.Location = new System.Drawing.Point(617, 192);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(180, 30);
            this.lblTanggal.TabIndex = 6;
            this.lblTanggal.Text = "Tanggal Pesan :";
            // 
            // lblWaktu
            // 
            this.lblWaktu.AutoSize = true;
            this.lblWaktu.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaktu.Location = new System.Drawing.Point(617, 249);
            this.lblWaktu.Name = "lblWaktu";
            this.lblWaktu.Size = new System.Drawing.Size(179, 30);
            this.lblWaktu.TabIndex = 7;
            this.lblWaktu.Text = "Waktu Pesan    :";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(56, 440);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(81, 30);
            this.lblMenu.TabIndex = 8;
            this.lblMenu.Text = "MENU";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.Location = new System.Drawing.Point(512, 440);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(93, 30);
            this.lblHarga.TabIndex = 9;
            this.lblHarga.Text = "HARGA";
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJumlah.Location = new System.Drawing.Point(738, 440);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(106, 30);
            this.lblJumlah.TabIndex = 10;
            this.lblJumlah.Text = "JUMLAH";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(992, 440);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(119, 30);
            this.lblNote.TabIndex = 11;
            this.lblNote.Text = "CATATAN";
            // 
            // lblMenu1
            // 
            this.lblMenu1.AutoSize = true;
            this.lblMenu1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMenu1.Location = new System.Drawing.Point(56, 481);
            this.lblMenu1.Name = "lblMenu1";
            this.lblMenu1.Size = new System.Drawing.Size(127, 28);
            this.lblMenu1.TabIndex = 12;
            this.lblMenu1.Text = "Nasi Gudeg";
            // 
            // lblMenu2
            // 
            this.lblMenu2.AutoSize = true;
            this.lblMenu2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMenu2.Location = new System.Drawing.Point(56, 521);
            this.lblMenu2.Name = "lblMenu2";
            this.lblMenu2.Size = new System.Drawing.Size(329, 28);
            this.lblMenu2.TabIndex = 13;
            this.lblMenu2.Text = "Nasi Gudeg dan Sambal Goreng";
            // 
            // lblMenu3
            // 
            this.lblMenu3.AutoSize = true;
            this.lblMenu3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMenu3.Location = new System.Drawing.Point(56, 562);
            this.lblMenu3.Name = "lblMenu3";
            this.lblMenu3.Size = new System.Drawing.Size(183, 28);
            this.lblMenu3.TabIndex = 14;
            this.lblMenu3.Text = "Nasi Gudeg Telur";
            // 
            // lblMenu4
            // 
            this.lblMenu4.AutoSize = true;
            this.lblMenu4.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMenu4.Location = new System.Drawing.Point(56, 604);
            this.lblMenu4.Name = "lblMenu4";
            this.lblMenu4.Size = new System.Drawing.Size(385, 28);
            this.lblMenu4.TabIndex = 15;
            this.lblMenu4.Text = "Nasi Gudeg Telur dan Sambal Goreng";
            // 
            // lblMenu5
            // 
            this.lblMenu5.AutoSize = true;
            this.lblMenu5.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMenu5.Location = new System.Drawing.Point(56, 644);
            this.lblMenu5.Name = "lblMenu5";
            this.lblMenu5.Size = new System.Drawing.Size(190, 28);
            this.lblMenu5.TabIndex = 16;
            this.lblMenu5.Text = "Nasi Gudeg Ayam";
            // 
            // lblMenu6
            // 
            this.lblMenu6.AutoSize = true;
            this.lblMenu6.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMenu6.Location = new System.Drawing.Point(56, 684);
            this.lblMenu6.Name = "lblMenu6";
            this.lblMenu6.Size = new System.Drawing.Size(392, 28);
            this.lblMenu6.TabIndex = 17;
            this.lblMenu6.Text = "Nasi Gudeg Ayam dan Sambal Goreng";
            // 
            // lblMenu7
            // 
            this.lblMenu7.AutoSize = true;
            this.lblMenu7.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMenu7.Location = new System.Drawing.Point(56, 728);
            this.lblMenu7.Name = "lblMenu7";
            this.lblMenu7.Size = new System.Drawing.Size(144, 28);
            this.lblMenu7.TabIndex = 18;
            this.lblMenu7.Text = "Panas/Es Teh";
            // 
            // lblMenu8
            // 
            this.lblMenu8.AutoSize = true;
            this.lblMenu8.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMenu8.Location = new System.Drawing.Point(56, 771);
            this.lblMenu8.Name = "lblMenu8";
            this.lblMenu8.Size = new System.Drawing.Size(161, 28);
            this.lblMenu8.TabIndex = 19;
            this.lblMenu8.Text = "Panas/Es Jeruk";
            // 
            // lblMenu9
            // 
            this.lblMenu9.AutoSize = true;
            this.lblMenu9.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMenu9.Location = new System.Drawing.Point(56, 815);
            this.lblMenu9.Name = "lblMenu9";
            this.lblMenu9.Size = new System.Drawing.Size(122, 28);
            this.lblMenu9.TabIndex = 20;
            this.lblMenu9.Text = "Air Mineral";
            // 
            // lblHarga1
            // 
            this.lblHarga1.AutoSize = true;
            this.lblHarga1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHarga1.Location = new System.Drawing.Point(512, 481);
            this.lblHarga1.Name = "lblHarga1";
            this.lblHarga1.Size = new System.Drawing.Size(125, 28);
            this.lblHarga1.TabIndex = 21;
            this.lblHarga1.Text = "Rp 8.000,00";
            // 
            // lblHarga2
            // 
            this.lblHarga2.AutoSize = true;
            this.lblHarga2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHarga2.Location = new System.Drawing.Point(512, 521);
            this.lblHarga2.Name = "lblHarga2";
            this.lblHarga2.Size = new System.Drawing.Size(137, 28);
            this.lblHarga2.TabIndex = 22;
            this.lblHarga2.Text = "Rp 10.000,00";
            // 
            // lblHarga3
            // 
            this.lblHarga3.AutoSize = true;
            this.lblHarga3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHarga3.Location = new System.Drawing.Point(512, 562);
            this.lblHarga3.Name = "lblHarga3";
            this.lblHarga3.Size = new System.Drawing.Size(137, 28);
            this.lblHarga3.TabIndex = 23;
            this.lblHarga3.Text = "Rp 10.000,00";
            // 
            // lblHarga4
            // 
            this.lblHarga4.AutoSize = true;
            this.lblHarga4.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHarga4.Location = new System.Drawing.Point(512, 604);
            this.lblHarga4.Name = "lblHarga4";
            this.lblHarga4.Size = new System.Drawing.Size(137, 28);
            this.lblHarga4.TabIndex = 24;
            this.lblHarga4.Text = "Rp 12.000,00";
            // 
            // lblHarga5
            // 
            this.lblHarga5.AutoSize = true;
            this.lblHarga5.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHarga5.Location = new System.Drawing.Point(512, 644);
            this.lblHarga5.Name = "lblHarga5";
            this.lblHarga5.Size = new System.Drawing.Size(137, 28);
            this.lblHarga5.TabIndex = 25;
            this.lblHarga5.Text = "Rp 12.000,00";
            // 
            // lblHarga6
            // 
            this.lblHarga6.AutoSize = true;
            this.lblHarga6.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHarga6.Location = new System.Drawing.Point(512, 684);
            this.lblHarga6.Name = "lblHarga6";
            this.lblHarga6.Size = new System.Drawing.Size(137, 28);
            this.lblHarga6.TabIndex = 26;
            this.lblHarga6.Text = "Rp 14.000,00";
            // 
            // lblHarga7
            // 
            this.lblHarga7.AutoSize = true;
            this.lblHarga7.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHarga7.Location = new System.Drawing.Point(512, 728);
            this.lblHarga7.Name = "lblHarga7";
            this.lblHarga7.Size = new System.Drawing.Size(125, 28);
            this.lblHarga7.TabIndex = 27;
            this.lblHarga7.Text = "Rp 3.000,00";
            // 
            // lblHarga8
            // 
            this.lblHarga8.AutoSize = true;
            this.lblHarga8.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHarga8.Location = new System.Drawing.Point(512, 771);
            this.lblHarga8.Name = "lblHarga8";
            this.lblHarga8.Size = new System.Drawing.Size(125, 28);
            this.lblHarga8.TabIndex = 28;
            this.lblHarga8.Text = "Rp 3.000,00";
            // 
            // lblHarga9
            // 
            this.lblHarga9.AutoSize = true;
            this.lblHarga9.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHarga9.Location = new System.Drawing.Point(512, 815);
            this.lblHarga9.Name = "lblHarga9";
            this.lblHarga9.Size = new System.Drawing.Size(125, 28);
            this.lblHarga9.TabIndex = 29;
            this.lblHarga9.Text = "Rp 3.000,00";
            // 
            // GB
            // 
            this.GB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GB.Controls.Add(this.tbQR);
            this.GB.Controls.Add(this.pbQR);
            this.GB.Controls.Add(this.label31);
            this.GB.Location = new System.Drawing.Point(1206, 132);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(646, 794);
            this.GB.TabIndex = 30;
            this.GB.TabStop = false;
            // 
            // btPesan
            // 
            this.btPesan.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesan.Location = new System.Drawing.Point(942, 882);
            this.btPesan.Name = "btPesan";
            this.btPesan.Size = new System.Drawing.Size(215, 44);
            this.btPesan.TabIndex = 31;
            this.btPesan.Text = "Pesan Sekarang";
            this.btPesan.UseVisualStyleBackColor = true;
            this.btPesan.Click += new System.EventHandler(this.btPesan_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label31.Location = new System.Drawing.Point(19, 538);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(225, 112);
            this.label31.TabIndex = 32;
            this.label31.Text = "Scan kode QR berikut\r\ndi kasir untuk\r\nmemproses pesanan\r\nanda.";
            // 
            // pbQR
            // 
            this.pbQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbQR.Location = new System.Drawing.Point(268, 432);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(370, 355);
            this.pbQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQR.TabIndex = 33;
            this.pbQR.TabStop = false;
            // 
            // foodOrderDataSet
            // 
            this.foodOrderDataSet.DataSetName = "FoodOrderDataSet";
            this.foodOrderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.foodOrderDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = FoodOrderingSystem.FoodOrderDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbNama
            // 
            this.tbNama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Nama", true));
            this.tbNama.Location = new System.Drawing.Point(239, 196);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(327, 26);
            this.tbNama.TabIndex = 34;
            // 
            // tbMeja
            // 
            this.tbMeja.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "No_Meja", true));
            this.tbMeja.Location = new System.Drawing.Point(239, 253);
            this.tbMeja.Name = "tbMeja";
            this.tbMeja.Size = new System.Drawing.Size(327, 26);
            this.tbMeja.TabIndex = 35;
            // 
            // tbRef
            // 
            this.tbRef.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "No_Referensi", true));
            this.tbRef.Location = new System.Drawing.Point(239, 309);
            this.tbRef.Name = "tbRef";
            this.tbRef.Size = new System.Drawing.Size(327, 26);
            this.tbRef.TabIndex = 36;
            // 
            // tbTanggal
            // 
            this.tbTanggal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Tanggal", true));
            this.tbTanggal.Location = new System.Drawing.Point(818, 196);
            this.tbTanggal.Name = "tbTanggal";
            this.tbTanggal.Size = new System.Drawing.Size(327, 26);
            this.tbTanggal.TabIndex = 37;
            // 
            // tbWaktu
            // 
            this.tbWaktu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Waktu", true));
            this.tbWaktu.Location = new System.Drawing.Point(818, 253);
            this.tbWaktu.Name = "tbWaktu";
            this.tbWaktu.Size = new System.Drawing.Size(327, 26);
            this.tbWaktu.TabIndex = 38;
            // 
            // tbJumlah1
            // 
            this.tbJumlah1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Jumlah1", true));
            this.tbJumlah1.Location = new System.Drawing.Point(740, 484);
            this.tbJumlah1.Name = "tbJumlah1";
            this.tbJumlah1.Size = new System.Drawing.Size(101, 26);
            this.tbJumlah1.TabIndex = 39;
            // 
            // tbJumlah2
            // 
            this.tbJumlah2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Jumlah2", true));
            this.tbJumlah2.Location = new System.Drawing.Point(740, 524);
            this.tbJumlah2.Name = "tbJumlah2";
            this.tbJumlah2.Size = new System.Drawing.Size(101, 26);
            this.tbJumlah2.TabIndex = 40;
            // 
            // tbJumlah3
            // 
            this.tbJumlah3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Jumlah3", true));
            this.tbJumlah3.Location = new System.Drawing.Point(740, 565);
            this.tbJumlah3.Name = "tbJumlah3";
            this.tbJumlah3.Size = new System.Drawing.Size(101, 26);
            this.tbJumlah3.TabIndex = 41;
            // 
            // tbJumlah4
            // 
            this.tbJumlah4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Jumlah4", true));
            this.tbJumlah4.Location = new System.Drawing.Point(740, 607);
            this.tbJumlah4.Name = "tbJumlah4";
            this.tbJumlah4.Size = new System.Drawing.Size(101, 26);
            this.tbJumlah4.TabIndex = 42;
            // 
            // tbJumlah5
            // 
            this.tbJumlah5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Jumlah5", true));
            this.tbJumlah5.Location = new System.Drawing.Point(740, 647);
            this.tbJumlah5.Name = "tbJumlah5";
            this.tbJumlah5.Size = new System.Drawing.Size(101, 26);
            this.tbJumlah5.TabIndex = 43;
            // 
            // tbJumlah6
            // 
            this.tbJumlah6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Jumlah6", true));
            this.tbJumlah6.Location = new System.Drawing.Point(740, 687);
            this.tbJumlah6.Name = "tbJumlah6";
            this.tbJumlah6.Size = new System.Drawing.Size(101, 26);
            this.tbJumlah6.TabIndex = 44;
            // 
            // tbJumlah7
            // 
            this.tbJumlah7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Jumlah7", true));
            this.tbJumlah7.Location = new System.Drawing.Point(740, 731);
            this.tbJumlah7.Name = "tbJumlah7";
            this.tbJumlah7.Size = new System.Drawing.Size(101, 26);
            this.tbJumlah7.TabIndex = 45;
            // 
            // tbJumlah8
            // 
            this.tbJumlah8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Jumlah8", true));
            this.tbJumlah8.Location = new System.Drawing.Point(740, 774);
            this.tbJumlah8.Name = "tbJumlah8";
            this.tbJumlah8.Size = new System.Drawing.Size(101, 26);
            this.tbJumlah8.TabIndex = 46;
            // 
            // tbNote1
            // 
            this.tbNote1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Catatan1", true));
            this.tbNote1.Location = new System.Drawing.Point(942, 484);
            this.tbNote1.Name = "tbNote1";
            this.tbNote1.Size = new System.Drawing.Size(215, 26);
            this.tbNote1.TabIndex = 48;
            // 
            // tbNote2
            // 
            this.tbNote2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Catatan2", true));
            this.tbNote2.Location = new System.Drawing.Point(942, 524);
            this.tbNote2.Name = "tbNote2";
            this.tbNote2.Size = new System.Drawing.Size(215, 26);
            this.tbNote2.TabIndex = 49;
            // 
            // tbNote3
            // 
            this.tbNote3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Catatan3", true));
            this.tbNote3.Location = new System.Drawing.Point(942, 565);
            this.tbNote3.Name = "tbNote3";
            this.tbNote3.Size = new System.Drawing.Size(215, 26);
            this.tbNote3.TabIndex = 50;
            // 
            // tbNote4
            // 
            this.tbNote4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Catatan4", true));
            this.tbNote4.Location = new System.Drawing.Point(942, 607);
            this.tbNote4.Name = "tbNote4";
            this.tbNote4.Size = new System.Drawing.Size(215, 26);
            this.tbNote4.TabIndex = 51;
            // 
            // tbNote5
            // 
            this.tbNote5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Catatan5", true));
            this.tbNote5.Location = new System.Drawing.Point(942, 647);
            this.tbNote5.Name = "tbNote5";
            this.tbNote5.Size = new System.Drawing.Size(215, 26);
            this.tbNote5.TabIndex = 52;
            // 
            // tbNote6
            // 
            this.tbNote6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Catatan6", true));
            this.tbNote6.Location = new System.Drawing.Point(942, 687);
            this.tbNote6.Name = "tbNote6";
            this.tbNote6.Size = new System.Drawing.Size(215, 26);
            this.tbNote6.TabIndex = 53;
            // 
            // tbNote7
            // 
            this.tbNote7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Catatan7", true));
            this.tbNote7.Location = new System.Drawing.Point(942, 731);
            this.tbNote7.Name = "tbNote7";
            this.tbNote7.Size = new System.Drawing.Size(215, 26);
            this.tbNote7.TabIndex = 54;
            // 
            // tbNote8
            // 
            this.tbNote8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Catatan8", true));
            this.tbNote8.Location = new System.Drawing.Point(942, 774);
            this.tbNote8.Name = "tbNote8";
            this.tbNote8.Size = new System.Drawing.Size(215, 26);
            this.tbNote8.TabIndex = 55;
            // 
            // tbNote9
            // 
            this.tbNote9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Catatan9", true));
            this.tbNote9.Location = new System.Drawing.Point(942, 818);
            this.tbNote9.Name = "tbNote9";
            this.tbNote9.Size = new System.Drawing.Size(215, 26);
            this.tbNote9.TabIndex = 56;
            // 
            // tbJumlah9
            // 
            this.tbJumlah9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Jumlah9", true));
            this.tbJumlah9.Location = new System.Drawing.Point(740, 818);
            this.tbJumlah9.Name = "tbJumlah9";
            this.tbJumlah9.Size = new System.Drawing.Size(101, 26);
            this.tbJumlah9.TabIndex = 57;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(712, 882);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 44);
            this.button1.TabIndex = 58;
            this.button1.Text = "Reset Pesanan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbQR
            // 
            this.tbQR.Location = new System.Drawing.Point(6, 6);
            this.tbQR.Multiline = true;
            this.tbQR.Name = "tbQR";
            this.tbQR.Size = new System.Drawing.Size(634, 420);
            this.tbQR.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 974);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbJumlah9);
            this.Controls.Add(this.tbNote9);
            this.Controls.Add(this.tbNote8);
            this.Controls.Add(this.tbNote7);
            this.Controls.Add(this.tbNote6);
            this.Controls.Add(this.tbNote5);
            this.Controls.Add(this.tbNote4);
            this.Controls.Add(this.tbNote3);
            this.Controls.Add(this.tbNote2);
            this.Controls.Add(this.tbNote1);
            this.Controls.Add(this.tbJumlah8);
            this.Controls.Add(this.tbJumlah7);
            this.Controls.Add(this.tbJumlah6);
            this.Controls.Add(this.tbJumlah5);
            this.Controls.Add(this.tbJumlah4);
            this.Controls.Add(this.tbJumlah3);
            this.Controls.Add(this.tbJumlah2);
            this.Controls.Add(this.tbJumlah1);
            this.Controls.Add(this.tbWaktu);
            this.Controls.Add(this.tbTanggal);
            this.Controls.Add(this.tbRef);
            this.Controls.Add(this.tbMeja);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.btPesan);
            this.Controls.Add(this.GB);
            this.Controls.Add(this.lblHarga9);
            this.Controls.Add(this.lblHarga8);
            this.Controls.Add(this.lblHarga7);
            this.Controls.Add(this.lblHarga6);
            this.Controls.Add(this.lblHarga5);
            this.Controls.Add(this.lblHarga4);
            this.Controls.Add(this.lblHarga3);
            this.Controls.Add(this.lblHarga2);
            this.Controls.Add(this.lblHarga1);
            this.Controls.Add(this.lblMenu9);
            this.Controls.Add(this.lblMenu8);
            this.Controls.Add(this.lblMenu7);
            this.Controls.Add(this.lblMenu6);
            this.Controls.Add(this.lblMenu5);
            this.Controls.Add(this.lblMenu4);
            this.Controls.Add(this.lblMenu3);
            this.Controls.Add(this.lblMenu2);
            this.Controls.Add(this.lblMenu1);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblWaktu);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.lblRef);
            this.Controls.Add(this.lblMeja);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblPesanan);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblJudul);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Food Ordering System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GB.ResumeLayout(false);
            this.GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodOrderDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblPesanan;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblMeja;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblWaktu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblMenu1;
        private System.Windows.Forms.Label lblMenu2;
        private System.Windows.Forms.Label lblMenu3;
        private System.Windows.Forms.Label lblMenu4;
        private System.Windows.Forms.Label lblMenu5;
        private System.Windows.Forms.Label lblMenu6;
        private System.Windows.Forms.Label lblMenu7;
        private System.Windows.Forms.Label lblMenu8;
        private System.Windows.Forms.Label lblMenu9;
        private System.Windows.Forms.Label lblHarga1;
        private System.Windows.Forms.Label lblHarga2;
        private System.Windows.Forms.Label lblHarga3;
        private System.Windows.Forms.Label lblHarga4;
        private System.Windows.Forms.Label lblHarga5;
        private System.Windows.Forms.Label lblHarga6;
        private System.Windows.Forms.Label lblHarga7;
        private System.Windows.Forms.Label lblHarga8;
        private System.Windows.Forms.Label lblHarga9;
        private System.Windows.Forms.GroupBox GB;
        private System.Windows.Forms.PictureBox pbQR;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btPesan;
        private FoodOrderingSystem.FoodOrderDataSet foodOrderDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private FoodOrderingSystem.FoodOrderDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private FoodOrderingSystem.FoodOrderDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbMeja;
        private System.Windows.Forms.TextBox tbRef;
        private System.Windows.Forms.TextBox tbTanggal;
        private System.Windows.Forms.TextBox tbWaktu;
        private System.Windows.Forms.TextBox tbJumlah1;
        private System.Windows.Forms.TextBox tbJumlah2;
        private System.Windows.Forms.TextBox tbJumlah3;
        private System.Windows.Forms.TextBox tbJumlah4;
        private System.Windows.Forms.TextBox tbJumlah5;
        private System.Windows.Forms.TextBox tbJumlah6;
        private System.Windows.Forms.TextBox tbJumlah7;
        private System.Windows.Forms.TextBox tbJumlah8;
        private System.Windows.Forms.TextBox tbNote1;
        private System.Windows.Forms.TextBox tbNote2;
        private System.Windows.Forms.TextBox tbNote3;
        private System.Windows.Forms.TextBox tbNote4;
        private System.Windows.Forms.TextBox tbNote5;
        private System.Windows.Forms.TextBox tbNote6;
        private System.Windows.Forms.TextBox tbNote7;
        private System.Windows.Forms.TextBox tbNote8;
        private System.Windows.Forms.TextBox tbNote9;
        private System.Windows.Forms.TextBox tbJumlah9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbQR;
    }
}