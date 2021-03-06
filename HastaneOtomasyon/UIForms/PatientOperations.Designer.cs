﻿namespace HastaneOtomasyon.UIForms
{
    partial class PatientOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientOperations));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.cmbMiktar = new System.Windows.Forms.NumericUpDown();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.cmbSiraNo = new System.Windows.Forms.TextBox();
            this.cmbDrKodu = new System.Windows.Forms.ComboBox();
            this.cmbYapilanIslem = new System.Windows.Forms.ComboBox();
            this.cmbPoliklinik = new System.Windows.Forms.ComboBox();
            this.birimfiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yapilanislem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDosyaNo = new System.Windows.Forms.MaskedTextBox();
            this.cmbSevkTarihi = new System.Windows.Forms.ComboBox();
            this.btnHastaBilgileri = new System.Windows.Forms.Button();
            this.btnGit = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.pnlYeniEkle = new System.Windows.Forms.Panel();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbOncekiIslemleri = new System.Windows.Forms.ComboBox();
            this.txtKurumAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poliklinik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgTahliller = new System.Windows.Forms.DataGridView();
            this.grpDatagrid = new System.Windows.Forms.GroupBox();
            this.lblToplamTutarValue = new System.Windows.Forms.Label();
            this.lblTopTutar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnYazdır = new System.Windows.Forms.Button();
            this.btnTaburcu = new System.Windows.Forms.Button();
            this.btnSecSil = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.pnlHastaIslemleri = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMiktar)).BeginInit();
            this.pnlYeniEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTahliller)).BeginInit();
            this.grpDatagrid.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlHastaIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // cmbMiktar
            // 
            this.cmbMiktar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMiktar.Location = new System.Drawing.Point(490, 37);
            this.cmbMiktar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cmbMiktar.Name = "cmbMiktar";
            this.cmbMiktar.Size = new System.Drawing.Size(70, 24);
            this.cmbMiktar.TabIndex = 14;
            this.cmbMiktar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cmbMiktar.ValueChanged += new System.EventHandler(this.cmbMiktar_ValueChanged);
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirimFiyat.Location = new System.Drawing.Point(579, 37);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.ReadOnly = true;
            this.txtBirimFiyat.Size = new System.Drawing.Size(104, 24);
            this.txtBirimFiyat.TabIndex = 15;
            // 
            // cmbSiraNo
            // 
            this.cmbSiraNo.Enabled = false;
            this.cmbSiraNo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSiraNo.Location = new System.Drawing.Point(146, 37);
            this.cmbSiraNo.Name = "cmbSiraNo";
            this.cmbSiraNo.Size = new System.Drawing.Size(83, 24);
            this.cmbSiraNo.TabIndex = 11;
            // 
            // cmbDrKodu
            // 
            this.cmbDrKodu.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDrKodu.FormattingEnabled = true;
            this.cmbDrKodu.Location = new System.Drawing.Point(379, 37);
            this.cmbDrKodu.Name = "cmbDrKodu";
            this.cmbDrKodu.Size = new System.Drawing.Size(100, 25);
            this.cmbDrKodu.TabIndex = 13;
            // 
            // cmbYapilanIslem
            // 
            this.cmbYapilanIslem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYapilanIslem.FormattingEnabled = true;
            this.cmbYapilanIslem.Location = new System.Drawing.Point(234, 36);
            this.cmbYapilanIslem.Name = "cmbYapilanIslem";
            this.cmbYapilanIslem.Size = new System.Drawing.Size(140, 25);
            this.cmbYapilanIslem.TabIndex = 12;
            this.cmbYapilanIslem.SelectedIndexChanged += new System.EventHandler(this.cmbYapilanIslem_SelectedIndexChanged);
            // 
            // cmbPoliklinik
            // 
            this.cmbPoliklinik.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPoliklinik.FormattingEnabled = true;
            this.cmbPoliklinik.Location = new System.Drawing.Point(7, 37);
            this.cmbPoliklinik.Name = "cmbPoliklinik";
            this.cmbPoliklinik.Size = new System.Drawing.Size(135, 25);
            this.cmbPoliklinik.TabIndex = 10;
            this.cmbPoliklinik.SelectedIndexChanged += new System.EventHandler(this.cmbPoliklinik_SelectedIndexChanged);
            // 
            // birimfiyat
            // 
            this.birimfiyat.DataPropertyName = "birimfiyat";
            this.birimfiyat.HeaderText = "BİRİM FİYATI";
            this.birimfiyat.MinimumWidth = 6;
            this.birimfiyat.Name = "birimfiyat";
            this.birimfiyat.ReadOnly = true;
            this.birimfiyat.Width = 125;
            // 
            // miktar
            // 
            this.miktar.DataPropertyName = "miktar";
            this.miktar.HeaderText = "MİKTAR";
            this.miktar.MinimumWidth = 6;
            this.miktar.Name = "miktar";
            this.miktar.ReadOnly = true;
            this.miktar.Width = 125;
            // 
            // drkod
            // 
            this.drkod.DataPropertyName = "drkod";
            this.drkod.HeaderText = "DR. KODU";
            this.drkod.MinimumWidth = 6;
            this.drkod.Name = "drkod";
            this.drkod.ReadOnly = true;
            this.drkod.Width = 125;
            // 
            // yapilanislem
            // 
            this.yapilanislem.DataPropertyName = "yapilanislem";
            this.yapilanislem.HeaderText = "YAPILAN İŞLEM";
            this.yapilanislem.MinimumWidth = 6;
            this.yapilanislem.Name = "yapilanislem";
            this.yapilanislem.ReadOnly = true;
            this.yapilanislem.Width = 125;
            // 
            // saat
            // 
            this.saat.DataPropertyName = "saat";
            this.saat.HeaderText = "SAAT";
            this.saat.MinimumWidth = 6;
            this.saat.Name = "saat";
            this.saat.ReadOnly = true;
            this.saat.Width = 125;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(594, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 21);
            this.label13.TabIndex = 5;
            this.label13.Text = "Birim Fiyat";
            // 
            // txtDosyaNo
            // 
            this.txtDosyaNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDosyaNo.Location = new System.Drawing.Point(109, 19);
            this.txtDosyaNo.Mask = "00000";
            this.txtDosyaNo.Name = "txtDosyaNo";
            this.txtDosyaNo.PromptChar = ' ';
            this.txtDosyaNo.Size = new System.Drawing.Size(149, 23);
            this.txtDosyaNo.TabIndex = 59;
            this.txtDosyaNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDosyaNo_KeyPress_1);
            // 
            // cmbSevkTarihi
            // 
            this.cmbSevkTarihi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSevkTarihi.FormattingEnabled = true;
            this.cmbSevkTarihi.Location = new System.Drawing.Point(110, 47);
            this.cmbSevkTarihi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSevkTarihi.Name = "cmbSevkTarihi";
            this.cmbSevkTarihi.Size = new System.Drawing.Size(215, 23);
            this.cmbSevkTarihi.TabIndex = 11;
            // 
            // btnHastaBilgileri
            // 
            this.btnHastaBilgileri.BackColor = System.Drawing.Color.AliceBlue;
            this.btnHastaBilgileri.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnHastaBilgileri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btnHastaBilgileri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnHastaBilgileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaBilgileri.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHastaBilgileri.Image = global::HastaneOtomasyon.Properties.Resources.table_go;
            this.btnHastaBilgileri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHastaBilgileri.Location = new System.Drawing.Point(702, 57);
            this.btnHastaBilgileri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHastaBilgileri.Name = "btnHastaBilgileri";
            this.btnHastaBilgileri.Size = new System.Drawing.Size(176, 44);
            this.btnHastaBilgileri.TabIndex = 10;
            this.btnHastaBilgileri.Text = "Hasta Bilgileri";
            this.btnHastaBilgileri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHastaBilgileri.UseVisualStyleBackColor = false;
            this.btnHastaBilgileri.Click += new System.EventHandler(this.btnHastaBilgileri_Click);
            // 
            // btnGit
            // 
            this.btnGit.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGit.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnGit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btnGit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGit.Image = global::HastaneOtomasyon.Properties.Resources.Forward;
            this.btnGit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGit.Location = new System.Drawing.Point(262, 78);
            this.btnGit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGit.Name = "btnGit";
            this.btnGit.Size = new System.Drawing.Size(63, 22);
            this.btnGit.TabIndex = 5;
            this.btnGit.Text = "Git";
            this.btnGit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGit.UseVisualStyleBackColor = false;
            this.btnGit.Click += new System.EventHandler(this.btnGit_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_ekle.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_ekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btn_ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ekle.Image = global::HastaneOtomasyon.Properties.Resources.Search;
            this.btn_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ekle.Location = new System.Drawing.Point(262, 19);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(63, 22);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Bul";
            this.btn_ekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // pnlYeniEkle
            // 
            this.pnlYeniEkle.Controls.Add(this.btnEkle);
            this.pnlYeniEkle.Controls.Add(this.label8);
            this.pnlYeniEkle.Controls.Add(this.cmbPoliklinik);
            this.pnlYeniEkle.Controls.Add(this.label13);
            this.pnlYeniEkle.Controls.Add(this.cmbMiktar);
            this.pnlYeniEkle.Controls.Add(this.txtBirimFiyat);
            this.pnlYeniEkle.Controls.Add(this.cmbSiraNo);
            this.pnlYeniEkle.Controls.Add(this.label9);
            this.pnlYeniEkle.Controls.Add(this.cmbDrKodu);
            this.pnlYeniEkle.Controls.Add(this.label10);
            this.pnlYeniEkle.Controls.Add(this.cmbYapilanIslem);
            this.pnlYeniEkle.Controls.Add(this.label11);
            this.pnlYeniEkle.Controls.Add(this.label12);
            this.pnlYeniEkle.Location = new System.Drawing.Point(6, 147);
            this.pnlYeniEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlYeniEkle.Name = "pnlYeniEkle";
            this.pnlYeniEkle.Size = new System.Drawing.Size(878, 81);
            this.pnlYeniEkle.TabIndex = 9;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.AliceBlue;
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Image = global::HastaneOtomasyon.Properties.Resources.Add;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(701, 19);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(174, 44);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(34, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Poliklinik";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(158, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 21);
            this.label9.TabIndex = 5;
            this.label9.Text = "Sıra No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(258, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "Yapılan İşlem";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(396, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 21);
            this.label11.TabIndex = 5;
            this.label11.Text = "Dr. Kodu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(496, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 21);
            this.label12.TabIndex = 5;
            this.label12.Text = "Miktar";
            // 
            // cmbOncekiIslemleri
            // 
            this.cmbOncekiIslemleri.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOncekiIslemleri.FormattingEnabled = true;
            this.cmbOncekiIslemleri.Location = new System.Drawing.Point(112, 75);
            this.cmbOncekiIslemleri.Name = "cmbOncekiIslemleri";
            this.cmbOncekiIslemleri.Size = new System.Drawing.Size(146, 25);
            this.cmbOncekiIslemleri.TabIndex = 4;
            this.cmbOncekiIslemleri.SelectedIndexChanged += new System.EventHandler(this.cmbOncekiIslemleri_SelectedIndexChanged);
            // 
            // txtKurumAdi
            // 
            this.txtKurumAdi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKurumAdi.Location = new System.Drawing.Point(448, 79);
            this.txtKurumAdi.Name = "txtKurumAdi";
            this.txtKurumAdi.Size = new System.Drawing.Size(230, 24);
            this.txtKurumAdi.TabIndex = 8;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyadi.Location = new System.Drawing.Point(448, 50);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(230, 24);
            this.txtSoyadi.TabIndex = 7;
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHastaAdi.Location = new System.Drawing.Point(448, 21);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(230, 24);
            this.txtHastaAdi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(4, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Önceki İşlemler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sevk Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(369, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kurum  Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(395, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Soyadı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(682, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sağlık Ocağı Hasta Takip Sistemi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(379, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hasta Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya No";
            // 
            // sira
            // 
            this.sira.DataPropertyName = "sira";
            this.sira.HeaderText = "SIRA NO";
            this.sira.MinimumWidth = 6;
            this.sira.Name = "sira";
            this.sira.ReadOnly = true;
            this.sira.Width = 125;
            // 
            // poliklinik
            // 
            this.poliklinik.DataPropertyName = "poliklinik";
            this.poliklinik.HeaderText = "POLİKLİNİK";
            this.poliklinik.MinimumWidth = 6;
            this.poliklinik.Name = "poliklinik";
            this.poliklinik.ReadOnly = true;
            this.poliklinik.Width = 125;
            // 
            // dtgTahliller
            // 
            this.dtgTahliller.AllowUserToAddRows = false;
            this.dtgTahliller.AllowUserToOrderColumns = true;
            this.dtgTahliller.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(252)))));
            this.dtgTahliller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTahliller.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.poliklinik,
            this.sira,
            this.saat,
            this.yapilanislem,
            this.drkod,
            this.miktar,
            this.birimfiyat});
            this.dtgTahliller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgTahliller.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgTahliller.Location = new System.Drawing.Point(3, 16);
            this.dtgTahliller.MultiSelect = false;
            this.dtgTahliller.Name = "dtgTahliller";
            this.dtgTahliller.ReadOnly = true;
            this.dtgTahliller.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgTahliller.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgTahliller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTahliller.Size = new System.Drawing.Size(889, 228);
            this.dtgTahliller.TabIndex = 0;
            // 
            // grpDatagrid
            // 
            this.grpDatagrid.BackColor = System.Drawing.Color.Transparent;
            this.grpDatagrid.Controls.Add(this.dtgTahliller);
            this.grpDatagrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpDatagrid.Location = new System.Drawing.Point(4, 239);
            this.grpDatagrid.Name = "grpDatagrid";
            this.grpDatagrid.Size = new System.Drawing.Size(895, 247);
            this.grpDatagrid.TabIndex = 15;
            this.grpDatagrid.TabStop = false;
            this.grpDatagrid.Text = "Yapılan Tahlil ve İşlemler";
            // 
            // lblToplamTutarValue
            // 
            this.lblToplamTutarValue.AutoSize = true;
            this.lblToplamTutarValue.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamTutarValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplamTutarValue.Location = new System.Drawing.Point(852, 506);
            this.lblToplamTutarValue.Name = "lblToplamTutarValue";
            this.lblToplamTutarValue.Size = new System.Drawing.Size(36, 19);
            this.lblToplamTutarValue.TabIndex = 16;
            this.lblToplamTutarValue.Text = "0 TL";
            // 
            // lblTopTutar
            // 
            this.lblTopTutar.AutoSize = true;
            this.lblTopTutar.BackColor = System.Drawing.Color.Transparent;
            this.lblTopTutar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopTutar.Location = new System.Drawing.Point(707, 506);
            this.lblTopTutar.Name = "lblTopTutar";
            this.lblTopTutar.Size = new System.Drawing.Size(114, 21);
            this.lblTopTutar.TabIndex = 17;
            this.lblTopTutar.Text = "Toplam Tutar : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btnYazdır);
            this.panel2.Controls.Add(this.btnTaburcu);
            this.panel2.Controls.Add(this.btnSecSil);
            this.panel2.Controls.Add(this.btnYeni);
            this.panel2.Location = new System.Drawing.Point(11, 559);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(888, 92);
            this.panel2.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.AliceBlue;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::HastaneOtomasyon.Properties.Resources.btnico_kapat;
            this.button5.Location = new System.Drawing.Point(796, 10);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 70);
            this.button5.TabIndex = 23;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AliceBlue;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::HastaneOtomasyon.Properties.Resources.btnico_hastaonizleme;
            this.button4.Location = new System.Drawing.Point(360, 10);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 70);
            this.button4.TabIndex = 22;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnYazdır
            // 
            this.btnYazdır.BackColor = System.Drawing.Color.AliceBlue;
            this.btnYazdır.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnYazdır.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btnYazdır.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnYazdır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazdır.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYazdır.Image = global::HastaneOtomasyon.Properties.Resources.btnico_hastayazdir;
            this.btnYazdır.Location = new System.Drawing.Point(274, 10);
            this.btnYazdır.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(66, 70);
            this.btnYazdır.TabIndex = 21;
            this.btnYazdır.UseVisualStyleBackColor = false;
            // 
            // btnTaburcu
            // 
            this.btnTaburcu.BackColor = System.Drawing.Color.AliceBlue;
            this.btnTaburcu.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnTaburcu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btnTaburcu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTaburcu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaburcu.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaburcu.Image = global::HastaneOtomasyon.Properties.Resources.btnico_hastataburcu;
            this.btnTaburcu.Location = new System.Drawing.Point(184, 10);
            this.btnTaburcu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTaburcu.Name = "btnTaburcu";
            this.btnTaburcu.Size = new System.Drawing.Size(66, 70);
            this.btnTaburcu.TabIndex = 20;
            this.btnTaburcu.UseVisualStyleBackColor = false;
            this.btnTaburcu.Click += new System.EventHandler(this.btnTaburcu_Click);
            // 
            // btnSecSil
            // 
            this.btnSecSil.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSecSil.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSecSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btnSecSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSecSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecSil.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecSil.Image = global::HastaneOtomasyon.Properties.Resources.btnico_hastasec;
            this.btnSecSil.Location = new System.Drawing.Point(96, 10);
            this.btnSecSil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSecSil.Name = "btnSecSil";
            this.btnSecSil.Size = new System.Drawing.Size(66, 70);
            this.btnSecSil.TabIndex = 19;
            this.btnSecSil.UseVisualStyleBackColor = false;
            this.btnSecSil.Click += new System.EventHandler(this.btnSecSil_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.AliceBlue;
            this.btnYeni.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnYeni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btnYeni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeni.Image = global::HastaneOtomasyon.Properties.Resources.btnico_hastaekle;
            this.btnYeni.Location = new System.Drawing.Point(8, 10);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(66, 70);
            this.btnYeni.TabIndex = 18;
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // pnlHastaIslemleri
            // 
            this.pnlHastaIslemleri.Controls.Add(this.txtDosyaNo);
            this.pnlHastaIslemleri.Controls.Add(this.cmbSevkTarihi);
            this.pnlHastaIslemleri.Controls.Add(this.pnlYeniEkle);
            this.pnlHastaIslemleri.Controls.Add(this.btnHastaBilgileri);
            this.pnlHastaIslemleri.Controls.Add(this.label1);
            this.pnlHastaIslemleri.Controls.Add(this.btnGit);
            this.pnlHastaIslemleri.Controls.Add(this.label4);
            this.pnlHastaIslemleri.Controls.Add(this.btn_ekle);
            this.pnlHastaIslemleri.Controls.Add(this.label7);
            this.pnlHastaIslemleri.Controls.Add(this.cmbOncekiIslemleri);
            this.pnlHastaIslemleri.Controls.Add(this.label5);
            this.pnlHastaIslemleri.Controls.Add(this.txtKurumAdi);
            this.pnlHastaIslemleri.Controls.Add(this.label6);
            this.pnlHastaIslemleri.Controls.Add(this.txtSoyadi);
            this.pnlHastaIslemleri.Controls.Add(this.label2);
            this.pnlHastaIslemleri.Controls.Add(this.txtHastaAdi);
            this.pnlHastaIslemleri.Controls.Add(this.label3);
            this.pnlHastaIslemleri.Location = new System.Drawing.Point(4, 3);
            this.pnlHastaIslemleri.Name = "pnlHastaIslemleri";
            this.pnlHastaIslemleri.Size = new System.Drawing.Size(889, 230);
            this.pnlHastaIslemleri.TabIndex = 60;
            // 
            // PatientOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(899, 652);
            this.Controls.Add(this.pnlHastaIslemleri);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grpDatagrid);
            this.Controls.Add(this.lblToplamTutarValue);
            this.Controls.Add(this.lblTopTutar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PatientOperations";
            this.Text = "Hasta İşlemleri";
            this.Load += new System.EventHandler(this.PatientOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbMiktar)).EndInit();
            this.pnlYeniEkle.ResumeLayout(false);
            this.pnlYeniEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTahliller)).EndInit();
            this.grpDatagrid.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlHastaIslemleri.ResumeLayout(false);
            this.pnlHastaIslemleri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.NumericUpDown cmbMiktar;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.TextBox cmbSiraNo;
        private System.Windows.Forms.ComboBox cmbDrKodu;
        private System.Windows.Forms.ComboBox cmbYapilanIslem;
        private System.Windows.Forms.ComboBox cmbPoliklinik;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimfiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn drkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn yapilanislem;
        private System.Windows.Forms.DataGridViewTextBoxColumn saat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlYeniEkle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbOncekiIslemleri;
        private System.Windows.Forms.TextBox txtKurumAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtHastaAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn poliklinik;
        private System.Windows.Forms.DataGridView dtgTahliller;
        private System.Windows.Forms.GroupBox grpDatagrid;
        private System.Windows.Forms.Label lblToplamTutarValue;
        private System.Windows.Forms.Label lblTopTutar;
        private System.Windows.Forms.Button btnGit;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btnHastaBilgileri;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSecSil;
        private System.Windows.Forms.Button btnTaburcu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnYazdır;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cmbSevkTarihi;
        private System.Windows.Forms.MaskedTextBox txtDosyaNo;
        private System.Windows.Forms.Panel pnlHastaIslemleri;
    }
}