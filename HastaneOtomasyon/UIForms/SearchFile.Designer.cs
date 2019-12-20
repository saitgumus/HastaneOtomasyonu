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
            this.cmbKriterBaslık = new System.Windows.Forms.ComboBox();
            this.txt_bilgi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgridHasta = new System.Windows.Forms.DataGridView();
            this.btnBul = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(15, 20);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(100, 20);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "kullanıcı kodu";
            // 
            // cmbKriterBaslık
            // 
            this.cmbKriterBaslık.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKriterBaslık.FormattingEnabled = true;
            this.cmbKriterBaslık.Location = new System.Drawing.Point(123, 18);
            this.cmbKriterBaslık.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbKriterBaslık.Name = "cmbKriterBaslık";
            this.cmbKriterBaslık.Size = new System.Drawing.Size(150, 25);
            this.cmbKriterBaslık.TabIndex = 3;
            this.cmbKriterBaslık.SelectedIndexChanged += new System.EventHandler(this.cmbKriterBaslık_SelectedIndexChanged);
            // 
            // txt_bilgi
            // 
            this.txt_bilgi.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bilgi.Location = new System.Drawing.Point(294, 19);
            this.txt_bilgi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_bilgi.Name = "txt_bilgi";
            this.txt_bilgi.Size = new System.Drawing.Size(268, 25);
            this.txt_bilgi.TabIndex = 4;
            this.txt_bilgi.TextChanged += new System.EventHandler(this.txt_bilgi_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(187)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.btnBul);
            this.panel1.Controls.Add(this.txt_bilgi);
            this.panel1.Controls.Add(this.lbl_username);
            this.panel1.Controls.Add(this.cmbKriterBaslık);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 63);
            this.panel1.TabIndex = 5;
            // 
            // dtgridHasta
            // 
            this.dtgridHasta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(252)))));
            this.dtgridHasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridHasta.Location = new System.Drawing.Point(9, 78);
            this.dtgridHasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgridHasta.Name = "dtgridHasta";
            this.dtgridHasta.RowHeadersWidth = 51;
            this.dtgridHasta.RowTemplate.Height = 24;
            this.dtgridHasta.Size = new System.Drawing.Size(681, 323);
            this.dtgridHasta.TabIndex = 6;
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.Color.White;
            this.btnBul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBul.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBul.Image = global::HastaneOtomasyon.Properties.Resources.Search;
            this.btnBul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBul.Location = new System.Drawing.Point(577, 18);
            this.btnBul.Margin = new System.Windows.Forms.Padding(4);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(100, 28);
            this.btnBul.TabIndex = 5;
            this.btnBul.Text = "    BUL";
            this.btnBul.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // SearchFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(775, 401);
            this.Controls.Add(this.dtgridHasta);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchFile";
            this.Text = "Dosya Arama Yardımı";
            this.Load += new System.EventHandler(this.SearchFile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridHasta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.ComboBox cmbKriterBaslık;
        private System.Windows.Forms.TextBox txt_bilgi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgridHasta;
        private System.Windows.Forms.Button btnBul;
    }
}