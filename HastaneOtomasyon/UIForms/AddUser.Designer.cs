namespace HastaneOtomasyon.UIForms
{
    partial class lbl_userCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lbl_userCode));
            this.lbl_username = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(51, 51);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(150, 29);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "kullanıcı kodu";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(224, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 30);
            this.comboBox1.TabIndex = 2;
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
            this.btn_ekle.Location = new System.Drawing.Point(224, 114);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(199, 48);
            this.btn_ekle.TabIndex = 5;
            this.btn_ekle.Text = "Kullanıcı Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            // 
            // lbl_userCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(445, 181);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "lbl_userCode";
            this.Text = "Kullanıcı Tanıtma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button btn_ekle;
    }
}