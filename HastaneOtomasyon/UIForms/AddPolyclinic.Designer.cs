namespace HastaneOtomasyon.UIForms
{
    partial class AddPolyclinic
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
            this.cmb_policlinic = new System.Windows.Forms.ComboBox();
            this.lbl_policlinic = new System.Windows.Forms.Label();
            this.cbx_gecerli = new System.Windows.Forms.CheckBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_policlinic
            // 
            this.cmb_policlinic.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_policlinic.FormattingEnabled = true;
            this.cmb_policlinic.Location = new System.Drawing.Point(210, 42);
            this.cmb_policlinic.Name = "cmb_policlinic";
            this.cmb_policlinic.Size = new System.Drawing.Size(199, 30);
            this.cmb_policlinic.TabIndex = 1;
            // 
            // lbl_policlinic
            // 
            this.lbl_policlinic.AutoSize = true;
            this.lbl_policlinic.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_policlinic.Location = new System.Drawing.Point(37, 42);
            this.lbl_policlinic.Name = "lbl_policlinic";
            this.lbl_policlinic.Size = new System.Drawing.Size(176, 36);
            this.lbl_policlinic.TabIndex = 3;
            this.lbl_policlinic.Text = "Poliklinik Adı";
            // 
            // cbx_gecerli
            // 
            this.cbx_gecerli.AllowDrop = true;
            this.cbx_gecerli.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_gecerli.Location = new System.Drawing.Point(210, 81);
            this.cbx_gecerli.Name = "cbx_gecerli";
            this.cbx_gecerli.Size = new System.Drawing.Size(199, 30);
            this.cbx_gecerli.TabIndex = 2;
            this.cbx_gecerli.Text = "Geçerli/Geçersiz";
            this.cbx_gecerli.UseVisualStyleBackColor = true;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(8, 52);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(385, 184);
            this.txtAciklama.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Açıklama";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Red;
            this.btn_exit.Image = global::HastaneOtomasyon.Properties.Resources.Erase;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(284, 253);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(109, 43);
            this.btn_exit.TabIndex = 37;
            this.btn_exit.Text = "Çık";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btnSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Image = global::HastaneOtomasyon.Properties.Resources.delete;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(151, 253);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(104, 43);
            this.btnSil.TabIndex = 36;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btnGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Image = global::HastaneOtomasyon.Properties.Resources.Update;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.Location = new System.Drawing.Point(8, 253);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(121, 43);
            this.btnGuncelle.TabIndex = 35;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAciklama);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Location = new System.Drawing.Point(12, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 326);
            this.panel1.TabIndex = 38;
            // 
            // AddPolyclinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(427, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbx_gecerli);
            this.Controls.Add(this.cmb_policlinic);
            this.Controls.Add(this.lbl_policlinic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddPolyclinic";
            this.Text = "AddPolyclinic";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_policlinic;
        private System.Windows.Forms.Label lbl_policlinic;
        private System.Windows.Forms.CheckBox cbx_gecerli;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Panel panel1;
    }
}