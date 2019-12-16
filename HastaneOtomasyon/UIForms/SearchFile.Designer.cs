namespace HastaneOtomasyon.UIForms
{
    partial class SearchFile
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.cmb_hastaAdSoyad = new System.Windows.Forms.ComboBox();
            this.txt_bilgi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(20, 25);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(124, 24);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "kullanıcı kodu";
            // 
            // cmb_hastaAdSoyad
            // 
            this.cmb_hastaAdSoyad.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_hastaAdSoyad.FormattingEnabled = true;
            this.cmb_hastaAdSoyad.Location = new System.Drawing.Point(164, 22);
            this.cmb_hastaAdSoyad.Name = "cmb_hastaAdSoyad";
            this.cmb_hastaAdSoyad.Size = new System.Drawing.Size(199, 30);
            this.cmb_hastaAdSoyad.TabIndex = 3;
            // 
            // txt_bilgi
            // 
            this.txt_bilgi.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bilgi.Location = new System.Drawing.Point(392, 23);
            this.txt_bilgi.Name = "txt_bilgi";
            this.txt_bilgi.Size = new System.Drawing.Size(475, 29);
            this.txt_bilgi.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.txt_bilgi);
            this.panel1.Controls.Add(this.lbl_username);
            this.panel1.Controls.Add(this.cmb_hastaAdSoyad);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 78);
            this.panel1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(252)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(873, 397);
            this.dataGridView1.TabIndex = 6;
            // 
            // SearchFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(891, 493);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SearchFile";
            this.Text = "Dosya Arama Yardımı";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.ComboBox cmb_hastaAdSoyad;
        private System.Windows.Forms.TextBox txt_bilgi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}