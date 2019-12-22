namespace HastaneOtomasyon.UIForms
{
    partial class DischargedPanel
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
            this.dateCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dateSevkTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbOdemeSekli = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtDosyaNo = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // dateCikisTarihi
            // 
            this.dateCikisTarihi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCikisTarihi.Location = new System.Drawing.Point(125, 80);
            this.dateCikisTarihi.Name = "dateCikisTarihi";
            this.dateCikisTarihi.Size = new System.Drawing.Size(218, 24);
            this.dateCikisTarihi.TabIndex = 13;
            // 
            // dateSevkTarihi
            // 
            this.dateSevkTarihi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSevkTarihi.Location = new System.Drawing.Point(125, 50);
            this.dateSevkTarihi.Name = "dateSevkTarihi";
            this.dateSevkTarihi.Size = new System.Drawing.Size(218, 24);
            this.dateSevkTarihi.TabIndex = 14;
            // 
            // cmbOdemeSekli
            // 
            this.cmbOdemeSekli.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOdemeSekli.FormattingEnabled = true;
            this.cmbOdemeSekli.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı - Taksitli",
            "Kredi Kartı - Tek Çekim",
            "Çek",
            "Senet"});
            this.cmbOdemeSekli.Location = new System.Drawing.Point(125, 109);
            this.cmbOdemeSekli.Name = "cmbOdemeSekli";
            this.cmbOdemeSekli.Size = new System.Drawing.Size(217, 25);
            this.cmbOdemeSekli.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Toplam Tutar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ödeme Şekli :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Çıkış Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sevk Tarihi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dosya No :";
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTutar.Location = new System.Drawing.Point(124, 139);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(218, 24);
            this.txtTutar.TabIndex = 6;
            // 
            // btnVazgec
            // 
            this.btnVazgec.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVazgec.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnVazgec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btnVazgec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnVazgec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVazgec.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVazgec.Image = global::HastaneOtomasyon.Properties.Resources.round_remove_32x32;
            this.btnVazgec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVazgec.Location = new System.Drawing.Point(191, 230);
            this.btnVazgec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(149, 39);
            this.btnVazgec.TabIndex = 49;
            this.btnVazgec.Text = "Vazgec";
            this.btnVazgec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVazgec.UseVisualStyleBackColor = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnKaydet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btnKaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Image = global::HastaneOtomasyon.Properties.Resources.Save1;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(190, 182);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(150, 39);
            this.btnKaydet.TabIndex = 48;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.UseVisualStyleBackColor = false;
            // 
            // txtDosyaNo
            // 
            this.txtDosyaNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDosyaNo.Location = new System.Drawing.Point(124, 22);
            this.txtDosyaNo.Mask = "00000";
            this.txtDosyaNo.Name = "txtDosyaNo";
            this.txtDosyaNo.PromptChar = ' ';
            this.txtDosyaNo.Size = new System.Drawing.Size(216, 23);
            this.txtDosyaNo.TabIndex = 59;
            // 
            // DischargedPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(376, 299);
            this.Controls.Add(this.txtDosyaNo);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dateCikisTarihi);
            this.Controls.Add(this.dateSevkTarihi);
            this.Controls.Add(this.cmbOdemeSekli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTutar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DischargedPanel";
            this.Text = "Taburcu";
            this.Load += new System.EventHandler(this.DischargedPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateCikisTarihi;
        private System.Windows.Forms.DateTimePicker dateSevkTarihi;
        private System.Windows.Forms.ComboBox cmbOdemeSekli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.MaskedTextBox txtDosyaNo;
    }
}