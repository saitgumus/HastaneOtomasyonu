namespace HastaneOtomasyon.UIForms
{
    partial class listForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTcKimlikNumarasi = new System.Windows.Forms.MaskedTextBox();
            this.lblKimlikno = new System.Windows.Forms.Label();
            this.txtDosyaNo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_yazdir = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.rb_hepsi = new System.Windows.Forms.RadioButton();
            this.rb_taburcuolmamıs = new System.Windows.Forms.RadioButton();
            this.rb_taburcuolmus = new System.Windows.Forms.RadioButton();
            this.dtp_bitistarihi = new System.Windows.Forms.DateTimePicker();
            this.dtp_baslangictarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_baslangic = new System.Windows.Forms.Label();
            this.dtgridDataList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.txtTcKimlikNumarasi);
            this.panel1.Controls.Add(this.lblKimlikno);
            this.panel1.Controls.Add(this.txtDosyaNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_cikis);
            this.panel1.Controls.Add(this.btn_yazdir);
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.rb_hepsi);
            this.panel1.Controls.Add(this.rb_taburcuolmamıs);
            this.panel1.Controls.Add(this.rb_taburcuolmus);
            this.panel1.Controls.Add(this.dtp_bitistarihi);
            this.panel1.Controls.Add(this.dtp_baslangictarihi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_baslangic);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 146);
            this.panel1.TabIndex = 0;
            // 
            // txtTcKimlikNumarasi
            // 
            this.txtTcKimlikNumarasi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTcKimlikNumarasi.Location = new System.Drawing.Point(128, 105);
            this.txtTcKimlikNumarasi.Mask = "00000000000";
            this.txtTcKimlikNumarasi.Name = "txtTcKimlikNumarasi";
            this.txtTcKimlikNumarasi.PromptChar = ' ';
            this.txtTcKimlikNumarasi.Size = new System.Drawing.Size(137, 23);
            this.txtTcKimlikNumarasi.TabIndex = 62;
            // 
            // lblKimlikno
            // 
            this.lblKimlikno.AutoSize = true;
            this.lblKimlikno.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKimlikno.Location = new System.Drawing.Point(30, 108);
            this.lblKimlikno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKimlikno.Name = "lblKimlikno";
            this.lblKimlikno.Size = new System.Drawing.Size(86, 18);
            this.lblKimlikno.TabIndex = 61;
            this.lblKimlikno.Text = "TC Kimlik No";
            // 
            // txtDosyaNo
            // 
            this.txtDosyaNo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDosyaNo.Location = new System.Drawing.Point(128, 12);
            this.txtDosyaNo.Mask = "00000";
            this.txtDosyaNo.Name = "txtDosyaNo";
            this.txtDosyaNo.PromptChar = ' ';
            this.txtDosyaNo.Size = new System.Drawing.Size(137, 26);
            this.txtDosyaNo.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 59;
            this.label2.Text = "Dosya No";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cikis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_cikis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btn_cikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikis.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cikis.ForeColor = System.Drawing.Color.Red;
            this.btn_cikis.Image = global::HastaneOtomasyon.Properties.Resources.Erase;
            this.btn_cikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cikis.Location = new System.Drawing.Point(717, 72);
            this.btn_cikis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(112, 54);
            this.btn_cikis.TabIndex = 11;
            this.btn_cikis.Text = "Çık";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_yazdir
            // 
            this.btn_yazdir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_yazdir.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_yazdir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btn_yazdir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_yazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yazdir.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yazdir.Image = global::HastaneOtomasyon.Properties.Resources.Print;
            this.btn_yazdir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_yazdir.Location = new System.Drawing.Point(717, 12);
            this.btn_yazdir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.Size = new System.Drawing.Size(112, 51);
            this.btn_yazdir.TabIndex = 10;
            this.btn_yazdir.Text = "Yazdır";
            this.btn_yazdir.UseVisualStyleBackColor = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTemizle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTemizle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btnTemizle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Image = global::HastaneOtomasyon.Properties.Resources.New_document;
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.Location = new System.Drawing.Point(573, 71);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(123, 56);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Image = global::HastaneOtomasyon.Properties.Resources.Search;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(573, 12);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(123, 51);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Ara";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // rb_hepsi
            // 
            this.rb_hepsi.AutoSize = true;
            this.rb_hepsi.Checked = true;
            this.rb_hepsi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_hepsi.Location = new System.Drawing.Point(302, 72);
            this.rb_hepsi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_hepsi.Name = "rb_hepsi";
            this.rb_hepsi.Size = new System.Drawing.Size(55, 21);
            this.rb_hepsi.TabIndex = 7;
            this.rb_hepsi.TabStop = true;
            this.rb_hepsi.Text = "hepsi";
            this.rb_hepsi.UseVisualStyleBackColor = true;
            // 
            // rb_taburcuolmamıs
            // 
            this.rb_taburcuolmamıs.AutoSize = true;
            this.rb_taburcuolmamıs.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_taburcuolmamıs.Location = new System.Drawing.Point(302, 47);
            this.rb_taburcuolmamıs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_taburcuolmamıs.Name = "rb_taburcuolmamıs";
            this.rb_taburcuolmamıs.Size = new System.Drawing.Size(120, 21);
            this.rb_taburcuolmamıs.TabIndex = 6;
            this.rb_taburcuolmamıs.Text = "taburcu olmamış";
            this.rb_taburcuolmamıs.UseVisualStyleBackColor = true;
            // 
            // rb_taburcuolmus
            // 
            this.rb_taburcuolmus.AutoSize = true;
            this.rb_taburcuolmus.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_taburcuolmus.Location = new System.Drawing.Point(302, 22);
            this.rb_taburcuolmus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_taburcuolmus.Name = "rb_taburcuolmus";
            this.rb_taburcuolmus.Size = new System.Drawing.Size(106, 21);
            this.rb_taburcuolmus.TabIndex = 5;
            this.rb_taburcuolmus.Text = "taburcu olmuş";
            this.rb_taburcuolmus.UseVisualStyleBackColor = true;
            // 
            // dtp_bitistarihi
            // 
            this.dtp_bitistarihi.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtp_bitistarihi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_bitistarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_bitistarihi.Location = new System.Drawing.Point(128, 76);
            this.dtp_bitistarihi.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtp_bitistarihi.Name = "dtp_bitistarihi";
            this.dtp_bitistarihi.Size = new System.Drawing.Size(137, 24);
            this.dtp_bitistarihi.TabIndex = 4;
            // 
            // dtp_baslangictarihi
            // 
            this.dtp_baslangictarihi.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtp_baslangictarihi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_baslangictarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_baslangictarihi.Location = new System.Drawing.Point(128, 44);
            this.dtp_baslangictarihi.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_baslangictarihi.Name = "dtp_baslangictarihi";
            this.dtp_baslangictarihi.Size = new System.Drawing.Size(137, 24);
            this.dtp_baslangictarihi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bitiş Tarihi";
            // 
            // lbl_baslangic
            // 
            this.lbl_baslangic.AutoSize = true;
            this.lbl_baslangic.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_baslangic.Location = new System.Drawing.Point(8, 44);
            this.lbl_baslangic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_baslangic.Name = "lbl_baslangic";
            this.lbl_baslangic.Size = new System.Drawing.Size(111, 19);
            this.lbl_baslangic.TabIndex = 1;
            this.lbl_baslangic.Text = "Başlangıç Tarihi";
            // 
            // dtgridDataList
            // 
            this.dtgridDataList.AllowUserToAddRows = false;
            this.dtgridDataList.AllowUserToDeleteRows = false;
            this.dtgridDataList.AllowUserToOrderColumns = true;
            this.dtgridDataList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(252)))));
            this.dtgridDataList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgridDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridDataList.Location = new System.Drawing.Point(9, 161);
            this.dtgridDataList.Name = "dtgridDataList";
            this.dtgridDataList.ReadOnly = true;
            this.dtgridDataList.RowHeadersWidth = 51;
            this.dtgridDataList.Size = new System.Drawing.Size(865, 351);
            this.dtgridDataList.TabIndex = 5;
            // 
            // listForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(884, 522);
            this.Controls.Add(this.dtgridDataList);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "listForm";
            this.Text = "Hasta Listeleme";
            this.Load += new System.EventHandler(this.listForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridDataList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_hepsi;
        private System.Windows.Forms.RadioButton rb_taburcuolmamıs;
        private System.Windows.Forms.RadioButton rb_taburcuolmus;
        private System.Windows.Forms.DateTimePicker dtp_bitistarihi;
        private System.Windows.Forms.DateTimePicker dtp_baslangictarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_baslangic;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_yazdir;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dtgridDataList;
        private System.Windows.Forms.MaskedTextBox txtDosyaNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtTcKimlikNumarasi;
        private System.Windows.Forms.Label lblKimlikno;
    }
}