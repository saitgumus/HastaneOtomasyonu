namespace HastaneOtomasyon.UIForms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.HomeMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuReferanslar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPoliklinik = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKullanici = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHastaKabul = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHastaIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRapor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRaporlama = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeMenuStrip
            // 
            this.HomeMenuStrip.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HomeMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.HomeMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReferanslar,
            this.menuHastaKabul,
            this.menuRapor});
            this.HomeMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.HomeMenuStrip.Name = "HomeMenuStrip";
            this.HomeMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.HomeMenuStrip.Size = new System.Drawing.Size(799, 40);
            this.HomeMenuStrip.TabIndex = 2;
            this.HomeMenuStrip.Text = "menuStrip1";
            this.HomeMenuStrip.Visible = false;
            // 
            // menuReferanslar
            // 
            this.menuReferanslar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogout,
            this.menuPoliklinik,
            this.menuKullanici,
            this.menuCikis});
            this.menuReferanslar.Image = global::HastaneOtomasyon.Properties.Resources.shape_align_middle;
            this.menuReferanslar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuReferanslar.Name = "menuReferanslar";
            this.menuReferanslar.Size = new System.Drawing.Size(107, 36);
            this.menuReferanslar.Text = "Referanslar";
            // 
            // menuLogout
            // 
            this.menuLogout.Image = global::HastaneOtomasyon.Properties.Resources.ico_logout;
            this.menuLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.menuLogout.ShowShortcutKeys = false;
            this.menuLogout.Size = new System.Drawing.Size(197, 42);
            this.menuLogout.Text = "Logout";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // menuPoliklinik
            // 
            this.menuPoliklinik.Image = global::HastaneOtomasyon.Properties.Resources.ico_poliklinik;
            this.menuPoliklinik.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuPoliklinik.Name = "menuPoliklinik";
            this.menuPoliklinik.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.menuPoliklinik.ShowShortcutKeys = false;
            this.menuPoliklinik.Size = new System.Drawing.Size(197, 42);
            this.menuPoliklinik.Text = "Poliklinik Tanıtma";
            this.menuPoliklinik.Click += new System.EventHandler(this.menuPoliklinik_Click);
            // 
            // menuKullanici
            // 
            this.menuKullanici.Image = global::HastaneOtomasyon.Properties.Resources.user_32x32;
            this.menuKullanici.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuKullanici.Name = "menuKullanici";
            this.menuKullanici.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.menuKullanici.ShowShortcutKeys = false;
            this.menuKullanici.Size = new System.Drawing.Size(197, 42);
            this.menuKullanici.Text = "Kullanıcı Tanıtma";
            this.menuKullanici.Click += new System.EventHandler(this.menuKullanici_Click);
            // 
            // menuCikis
            // 
            this.menuCikis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCikis.Name = "menuCikis";
            this.menuCikis.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.menuCikis.ShowShortcutKeys = false;
            this.menuCikis.Size = new System.Drawing.Size(197, 42);
            this.menuCikis.Text = "Çıkış";
            // 
            // menuHastaKabul
            // 
            this.menuHastaKabul.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHastaIslemleri});
            this.menuHastaKabul.Image = global::HastaneOtomasyon.Properties.Resources.btnico_hastabul;
            this.menuHastaKabul.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuHastaKabul.Name = "menuHastaKabul";
            this.menuHastaKabul.Size = new System.Drawing.Size(112, 36);
            this.menuHastaKabul.Text = "Hasta Kabul";
            // 
            // menuHastaIslemleri
            // 
            this.menuHastaIslemleri.Image = global::HastaneOtomasyon.Properties.Resources.btnico_hastabilgisi;
            this.menuHastaIslemleri.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuHastaIslemleri.Name = "menuHastaIslemleri";
            this.menuHastaIslemleri.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2)));
            this.menuHastaIslemleri.ShowShortcutKeys = false;
            this.menuHastaIslemleri.Size = new System.Drawing.Size(199, 42);
            this.menuHastaIslemleri.Text = "Hasta İşlemleri";
            this.menuHastaIslemleri.Click += new System.EventHandler(this.menuHastaIslemleri_Click);
            // 
            // menuRapor
            // 
            this.menuRapor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRaporlama});
            this.menuRapor.Image = global::HastaneOtomasyon.Properties.Resources.report;
            this.menuRapor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuRapor.Name = "menuRapor";
            this.menuRapor.Size = new System.Drawing.Size(104, 36);
            this.menuRapor.Text = "Raporlar";
            // 
            // menuRaporlama
            // 
            this.menuRaporlama.Image = global::HastaneOtomasyon.Properties.Resources.report;
            this.menuRaporlama.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuRaporlama.Name = "menuRaporlama";
            this.menuRaporlama.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.menuRaporlama.ShowShortcutKeys = false;
            this.menuRaporlama.Size = new System.Drawing.Size(120, 38);
            this.menuRaporlama.Text = "Rapor";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(799, 579);
            this.Controls.Add(this.HomeMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Sağlık Ocağı Hasta Takip Sistemi";
            this.Load += new System.EventHandler(this.Main_Load);
            this.HomeMenuStrip.ResumeLayout(false);
            this.HomeMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip HomeMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuReferanslar;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem menuPoliklinik;
        private System.Windows.Forms.ToolStripMenuItem menuKullanici;
        private System.Windows.Forms.ToolStripMenuItem menuCikis;
        private System.Windows.Forms.ToolStripMenuItem menuHastaKabul;
        private System.Windows.Forms.ToolStripMenuItem menuHastaIslemleri;
        private System.Windows.Forms.ToolStripMenuItem menuRapor;
        private System.Windows.Forms.ToolStripMenuItem menuRaporlama;
    }
}