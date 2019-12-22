namespace HastaneOtomasyon.UIForms
{
    partial class UserDefinition
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
            this.cmbMedeniHal = new System.Windows.Forms.ComboBox();
            this.cmbKanGrubu = new System.Windows.Forms.ComboBox();
            this.cmbCinsiyeti = new System.Windows.Forms.ComboBox();
            this.dateDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.dateIseBaslama = new System.Windows.Forms.DateTimePicker();
            this.cmbUnvani = new System.Windows.Forms.ComboBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtAnneAdi = new System.Windows.Forms.TextBox();
            this.txtBabaAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.chcYetkiliKullanici = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlUserDef = new System.Windows.Forms.Panel();
            this.txtMaas = new System.Windows.Forms.MaskedTextBox();
            this.txtGSM = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefonNo = new System.Windows.Forms.MaskedTextBox();
            this.txtKullaniciKodu = new System.Windows.Forms.MaskedTextBox();
            this.txtTcKimlikNumarasi = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelleKaydet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_userNamePass = new System.Windows.Forms.Panel();
            this.pnlUserDef.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_userNamePass.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMedeniHal
            // 
            this.cmbMedeniHal.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedeniHal.FormattingEnabled = true;
            this.cmbMedeniHal.Items.AddRange(new object[] {
            "Seçiniz",
            "Evli",
            "Bekar",
            "Dul"});
            this.cmbMedeniHal.Location = new System.Drawing.Point(602, 222);
            this.cmbMedeniHal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMedeniHal.Name = "cmbMedeniHal";
            this.cmbMedeniHal.Size = new System.Drawing.Size(68, 25);
            this.cmbMedeniHal.TabIndex = 15;
            // 
            // cmbKanGrubu
            // 
            this.cmbKanGrubu.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKanGrubu.FormattingEnabled = true;
            this.cmbKanGrubu.Items.AddRange(new object[] {
            "Seçiniz",
            "ARh+",
            "ARh-",
            "BRh+",
            "BRh-",
            "0Rh+",
            "0Rh-",
            "ABRh+",
            "ABRh-"});
            this.cmbKanGrubu.Location = new System.Drawing.Point(469, 259);
            this.cmbKanGrubu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbKanGrubu.Name = "cmbKanGrubu";
            this.cmbKanGrubu.Size = new System.Drawing.Size(52, 25);
            this.cmbKanGrubu.TabIndex = 17;
            // 
            // cmbCinsiyeti
            // 
            this.cmbCinsiyeti.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCinsiyeti.FormattingEnabled = true;
            this.cmbCinsiyeti.Items.AddRange(new object[] {
            "Seçiniz",
            "Erkek",
            "Kadın"});
            this.cmbCinsiyeti.Location = new System.Drawing.Point(470, 222);
            this.cmbCinsiyeti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCinsiyeti.Name = "cmbCinsiyeti";
            this.cmbCinsiyeti.Size = new System.Drawing.Size(50, 25);
            this.cmbCinsiyeti.TabIndex = 14;
            // 
            // dateDogumTarihi
            // 
            this.dateDogumTarihi.CustomFormat = "dd-MM-yyyy";
            this.dateDogumTarihi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDogumTarihi.Location = new System.Drawing.Point(470, 180);
            this.dateDogumTarihi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateDogumTarihi.Name = "dateDogumTarihi";
            this.dateDogumTarihi.Size = new System.Drawing.Size(199, 24);
            this.dateDogumTarihi.TabIndex = 13;
            // 
            // dateIseBaslama
            // 
            this.dateIseBaslama.CustomFormat = "dd-MM-yyyy";
            this.dateIseBaslama.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateIseBaslama.Location = new System.Drawing.Point(470, 145);
            this.dateIseBaslama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateIseBaslama.Name = "dateIseBaslama";
            this.dateIseBaslama.Size = new System.Drawing.Size(199, 24);
            this.dateIseBaslama.TabIndex = 12;
            // 
            // cmbUnvani
            // 
            this.cmbUnvani.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnvani.FormattingEnabled = true;
            this.cmbUnvani.Items.AddRange(new object[] {
            "Yönetici",
            "Çalışan",
            "Öğrenci",
            "Müdür",
            "Öğretmen",
            "Diğer"});
            this.cmbUnvani.Location = new System.Drawing.Point(470, 8);
            this.cmbUnvani.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUnvani.Name = "cmbUnvani";
            this.cmbUnvani.Size = new System.Drawing.Size(199, 25);
            this.cmbUnvani.TabIndex = 8;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(149, 318);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAdres.Size = new System.Drawing.Size(520, 59);
            this.txtAdres.TabIndex = 18;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifre.Location = new System.Drawing.Point(320, 13);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(196, 24);
            this.txtSifre.TabIndex = 20;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(95, 13);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(155, 24);
            this.txtKullaniciAdi.TabIndex = 19;
            // 
            // txtAnneAdi
            // 
            this.txtAnneAdi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnneAdi.Location = new System.Drawing.Point(149, 145);
            this.txtAnneAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAnneAdi.Name = "txtAnneAdi";
            this.txtAnneAdi.Size = new System.Drawing.Size(156, 24);
            this.txtAnneAdi.TabIndex = 5;
            this.txtAnneAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckAlphabetic);
            // 
            // txtBabaAdi
            // 
            this.txtBabaAdi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBabaAdi.Location = new System.Drawing.Point(149, 112);
            this.txtBabaAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBabaAdi.Name = "txtBabaAdi";
            this.txtBabaAdi.Size = new System.Drawing.Size(156, 24);
            this.txtBabaAdi.TabIndex = 4;
            this.txtBabaAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckAlphabetic);
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyadi.Location = new System.Drawing.Point(470, 73);
            this.txtSoyadi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(199, 24);
            this.txtSoyadi.TabIndex = 10;
            this.txtSoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckAlphabetic);
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDogumYeri.Location = new System.Drawing.Point(149, 76);
            this.txtDogumYeri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(156, 24);
            this.txtDogumYeri.TabIndex = 3;
            // 
            // txtAdi
            // 
            this.txtAdi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdi.Location = new System.Drawing.Point(470, 41);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(199, 24);
            this.txtAdi.TabIndex = 9;
            this.txtAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckAlphabetic);
            // 
            // chcYetkiliKullanici
            // 
            this.chcYetkiliKullanici.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chcYetkiliKullanici.FlatAppearance.BorderSize = 2;
            this.chcYetkiliKullanici.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.chcYetkiliKullanici.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chcYetkiliKullanici.Location = new System.Drawing.Point(149, 255);
            this.chcYetkiliKullanici.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chcYetkiliKullanici.Name = "chcYetkiliKullanici";
            this.chcYetkiliKullanici.Size = new System.Drawing.Size(154, 27);
            this.chcYetkiliKullanici.TabIndex = 16;
            this.chcYetkiliKullanici.Text = "Yetkili Kullanıcı?";
            this.chcYetkiliKullanici.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(382, 261);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 18);
            this.label15.TabIndex = 8;
            this.label15.Text = "Kan Grubu";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(524, 223);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 18);
            this.label16.TabIndex = 9;
            this.label16.Text = "Medeni Hal";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(395, 221);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 18);
            this.label14.TabIndex = 10;
            this.label14.Text = "Cinsiyeti";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(368, 184);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 18);
            this.label13.TabIndex = 11;
            this.label13.Text = "Doğum Tarihi";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(268, 15);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 18);
            this.label19.TabIndex = 12;
            this.label19.Text = "Şifre";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(2, 15);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 18);
            this.label18.TabIndex = 13;
            this.label18.Text = "Kullanıcı Adı";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(88, 317);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 18);
            this.label17.TabIndex = 14;
            this.label17.Text = "Adres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(94, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "GSM";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(377, 150);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 18);
            this.label12.TabIndex = 15;
            this.label12.Text = "İşe Başlama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(62, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Telefon No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(406, 75);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 18);
            this.label11.TabIndex = 17;
            this.label11.Text = "Soyadı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(70, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Anne Adı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(413, 111);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Maaş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(56, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Doğum Yeri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(425, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(72, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Baba Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(404, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "Unvanı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "T.C. Kimlik Numarası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kullanıcı Kodu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlUserDef
            // 
            this.pnlUserDef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(252)))));
            this.pnlUserDef.Controls.Add(this.txtMaas);
            this.pnlUserDef.Controls.Add(this.txtGSM);
            this.pnlUserDef.Controls.Add(this.txtTelefonNo);
            this.pnlUserDef.Controls.Add(this.txtKullaniciKodu);
            this.pnlUserDef.Controls.Add(this.txtTcKimlikNumarasi);
            this.pnlUserDef.Controls.Add(this.panel3);
            this.pnlUserDef.Controls.Add(this.pnl_userNamePass);
            this.pnlUserDef.Controls.Add(this.chcYetkiliKullanici);
            this.pnlUserDef.Controls.Add(this.txtAdres);
            this.pnlUserDef.Controls.Add(this.cmbKanGrubu);
            this.pnlUserDef.Controls.Add(this.label4);
            this.pnlUserDef.Controls.Add(this.cmbMedeniHal);
            this.pnlUserDef.Controls.Add(this.label1);
            this.pnlUserDef.Controls.Add(this.label2);
            this.pnlUserDef.Controls.Add(this.cmbCinsiyeti);
            this.pnlUserDef.Controls.Add(this.label3);
            this.pnlUserDef.Controls.Add(this.label17);
            this.pnlUserDef.Controls.Add(this.dateDogumTarihi);
            this.pnlUserDef.Controls.Add(this.label15);
            this.pnlUserDef.Controls.Add(this.label5);
            this.pnlUserDef.Controls.Add(this.dateIseBaslama);
            this.pnlUserDef.Controls.Add(this.label6);
            this.pnlUserDef.Controls.Add(this.cmbUnvani);
            this.pnlUserDef.Controls.Add(this.label7);
            this.pnlUserDef.Controls.Add(this.label16);
            this.pnlUserDef.Controls.Add(this.label14);
            this.pnlUserDef.Controls.Add(this.txtDogumYeri);
            this.pnlUserDef.Controls.Add(this.txtSoyadi);
            this.pnlUserDef.Controls.Add(this.txtAdi);
            this.pnlUserDef.Controls.Add(this.txtBabaAdi);
            this.pnlUserDef.Controls.Add(this.txtAnneAdi);
            this.pnlUserDef.Controls.Add(this.label8);
            this.pnlUserDef.Controls.Add(this.label9);
            this.pnlUserDef.Controls.Add(this.label10);
            this.pnlUserDef.Controls.Add(this.label11);
            this.pnlUserDef.Controls.Add(this.label12);
            this.pnlUserDef.Controls.Add(this.label13);
            this.pnlUserDef.Location = new System.Drawing.Point(9, 10);
            this.pnlUserDef.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlUserDef.Name = "pnlUserDef";
            this.pnlUserDef.Size = new System.Drawing.Size(680, 552);
            this.pnlUserDef.TabIndex = 50;
            // 
            // txtMaas
            // 
            this.txtMaas.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaas.Location = new System.Drawing.Point(470, 106);
            this.txtMaas.Mask = "00000";
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.PromptChar = ' ';
            this.txtMaas.Size = new System.Drawing.Size(199, 26);
            this.txtMaas.TabIndex = 11;
            // 
            // txtGSM
            // 
            this.txtGSM.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGSM.Location = new System.Drawing.Point(149, 214);
            this.txtGSM.Mask = "0000000000";
            this.txtGSM.Name = "txtGSM";
            this.txtGSM.PromptChar = ' ';
            this.txtGSM.Size = new System.Drawing.Size(156, 23);
            this.txtGSM.TabIndex = 7;
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonNo.Location = new System.Drawing.Point(149, 179);
            this.txtTelefonNo.Mask = "0000000000";
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.PromptChar = ' ';
            this.txtTelefonNo.Size = new System.Drawing.Size(156, 23);
            this.txtTelefonNo.TabIndex = 6;
            // 
            // txtKullaniciKodu
            // 
            this.txtKullaniciKodu.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullaniciKodu.Location = new System.Drawing.Point(149, 11);
            this.txtKullaniciKodu.Mask = "00000000000";
            this.txtKullaniciKodu.Name = "txtKullaniciKodu";
            this.txtKullaniciKodu.PromptChar = ' ';
            this.txtKullaniciKodu.Size = new System.Drawing.Size(156, 23);
            this.txtKullaniciKodu.TabIndex = 53;
            // 
            // txtTcKimlikNumarasi
            // 
            this.txtTcKimlikNumarasi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTcKimlikNumarasi.Location = new System.Drawing.Point(149, 45);
            this.txtTcKimlikNumarasi.Mask = "00000000000";
            this.txtTcKimlikNumarasi.Name = "txtTcKimlikNumarasi";
            this.txtTcKimlikNumarasi.PromptChar = ' ';
            this.txtTcKimlikNumarasi.Size = new System.Drawing.Size(156, 23);
            this.txtTcKimlikNumarasi.TabIndex = 52;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(247)))));
            this.panel3.Controls.Add(this.btn_exit);
            this.panel3.Controls.Add(this.btnSil);
            this.panel3.Controls.Add(this.btnGuncelleKaydet);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(4, 466);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 81);
            this.panel3.TabIndex = 51;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Red;
            this.btn_exit.Image = global::HastaneOtomasyon.Properties.Resources.Erase;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(538, 18);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(124, 45);
            this.btn_exit.TabIndex = 25;
            this.btn_exit.Text = "Çık";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Image = global::HastaneOtomasyon.Properties.Resources.delete;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(314, 18);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(120, 45);
            this.btnSil.TabIndex = 24;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelleKaydet
            // 
            this.btnGuncelleKaydet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuncelleKaydet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuncelleKaydet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btnGuncelleKaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuncelleKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelleKaydet.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelleKaydet.Image = global::HastaneOtomasyon.Properties.Resources.Save1;
            this.btnGuncelleKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelleKaydet.Location = new System.Drawing.Point(164, 18);
            this.btnGuncelleKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuncelleKaydet.Name = "btnGuncelleKaydet";
            this.btnGuncelleKaydet.Size = new System.Drawing.Size(124, 45);
            this.btnGuncelleKaydet.TabIndex = 23;
            this.btnGuncelleKaydet.Text = "Kaydet";
            this.btnGuncelleKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelleKaydet.UseVisualStyleBackColor = false;
            this.btnGuncelleKaydet.Click += new System.EventHandler(this.btnGuncelleKaydet_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::HastaneOtomasyon.Properties.Resources.New_document;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(11, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 45);
            this.button1.TabIndex = 22;
            this.button1.Text = "Temizle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_userNamePass
            // 
            this.pnl_userNamePass.Controls.Add(this.txtKullaniciAdi);
            this.pnl_userNamePass.Controls.Add(this.txtSifre);
            this.pnl_userNamePass.Controls.Add(this.label18);
            this.pnl_userNamePass.Controls.Add(this.label19);
            this.pnl_userNamePass.Location = new System.Drawing.Point(149, 392);
            this.pnl_userNamePass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_userNamePass.Name = "pnl_userNamePass";
            this.pnl_userNamePass.Size = new System.Drawing.Size(519, 56);
            this.pnl_userNamePass.TabIndex = 50;
            // 
            // UserDefinition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(693, 561);
            this.Controls.Add(this.pnlUserDef);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserDefinition";
            this.Text = "Kullanıcı Tanımlama";
            this.Load += new System.EventHandler(this.UserDefinition_Load);
            this.pnlUserDef.ResumeLayout(false);
            this.pnlUserDef.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnl_userNamePass.ResumeLayout(false);
            this.pnl_userNamePass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMedeniHal;
        private System.Windows.Forms.ComboBox cmbKanGrubu;
        private System.Windows.Forms.ComboBox cmbCinsiyeti;
        private System.Windows.Forms.DateTimePicker dateDogumTarihi;
        private System.Windows.Forms.DateTimePicker dateIseBaslama;
        private System.Windows.Forms.ComboBox cmbUnvani;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtAnneAdi;
        private System.Windows.Forms.TextBox txtBabaAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.CheckBox chcYetkiliKullanici;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlUserDef;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl_userNamePass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btn_exit;
        public System.Windows.Forms.Button btnGuncelleKaydet;
        private System.Windows.Forms.MaskedTextBox txtKullaniciKodu;
        private System.Windows.Forms.MaskedTextBox txtTcKimlikNumarasi;
        private System.Windows.Forms.MaskedTextBox txtMaas;
        private System.Windows.Forms.MaskedTextBox txtGSM;
        private System.Windows.Forms.MaskedTextBox txtTelefonNo;
    }
}