namespace HastaneOtomasyon.UIForms
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.lbl_username = new System.Windows.Forms.Label();
            this.cmb_kullanicilar = new System.Windows.Forms.ComboBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(38, 41);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(114, 23);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "kullanıcı kodu";
            // 
            // cmb_kullanicilar
            // 
            this.cmb_kullanicilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_kullanicilar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_kullanicilar.FormattingEnabled = true;
            this.cmb_kullanicilar.Location = new System.Drawing.Point(168, 41);
            this.cmb_kullanicilar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_kullanicilar.Name = "cmb_kullanicilar";
            this.cmb_kullanicilar.Size = new System.Drawing.Size(206, 25);
            this.cmb_kullanicilar.TabIndex = 1;
            this.cmb_kullanicilar.SelectedIndexChanged += new System.EventHandler(this.cmb_kullanicilar_SelectedIndexChanged);
            this.cmb_kullanicilar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_kullanicilar_KeyPress);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ekle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btn_ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ekle.Image = global::HastaneOtomasyon.Properties.Resources.user_add;
            this.btn_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ekle.Location = new System.Drawing.Point(168, 93);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(206, 39);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Kullanıcı Ekle";
            this.btn_ekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(385, 151);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.cmb_kullanicilar);
            this.Controls.Add(this.lbl_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddUser";
            this.Text = "Kullanıcı Tanıtma";
            this.Load += new System.EventHandler(this.lbl_userCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.ComboBox cmb_kullanicilar;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button btn_ekle;
    }
}