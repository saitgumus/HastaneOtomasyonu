namespace HastaneOtomasyon.UIForms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnl_login = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_clean = new System.Windows.Forms.Button();
            this.btn_giriş = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pnl_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_login
            // 
            this.pnl_login.Controls.Add(this.btn_exit);
            this.pnl_login.Controls.Add(this.btn_clean);
            this.pnl_login.Controls.Add(this.btn_giriş);
            this.pnl_login.Controls.Add(this.txt_password);
            this.pnl_login.Controls.Add(this.txt_username);
            this.pnl_login.Controls.Add(this.lbl_password);
            this.pnl_login.Controls.Add(this.lbl_username);
            this.pnl_login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_login.Location = new System.Drawing.Point(0, 12);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(520, 595);
            this.pnl_login.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Image = global::HastaneOtomasyon.Properties.Resources.Erase;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(245, 445);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(187, 54);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Çık";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_clean
            // 
            this.btn_clean.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clean.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_clean.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_clean.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clean.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clean.Image = global::HastaneOtomasyon.Properties.Resources.New_document;
            this.btn_clean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clean.Location = new System.Drawing.Point(245, 375);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(187, 54);
            this.btn_clean.TabIndex = 5;
            this.btn_clean.Text = "Temizle";
            this.btn_clean.UseVisualStyleBackColor = false;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // btn_giriş
            // 
            this.btn_giriş.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_giriş.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_giriş.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btn_giriş.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_giriş.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giriş.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_giriş.Image = global::HastaneOtomasyon.Properties.Resources.Apply;
            this.btn_giriş.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_giriş.Location = new System.Drawing.Point(245, 304);
            this.btn_giriş.Name = "btn_giriş";
            this.btn_giriş.Size = new System.Drawing.Size(187, 54);
            this.btn_giriş.TabIndex = 4;
            this.btn_giriş.Text = "Giriş";
            this.btn_giriş.UseVisualStyleBackColor = false;
            this.btn_giriş.Click += new System.EventHandler(this.btn_giriş_Click);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(187, 238);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(245, 32);
            this.txt_password.TabIndex = 3;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(187, 180);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(245, 32);
            this.txt_username.TabIndex = 2;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(113, 238);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(57, 29);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Şifre";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(38, 183);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(132, 29);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "kullanıcı adı";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(520, 607);
            this.Controls.Add(this.pnl_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button btn_giriş;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_exit;
    }
}