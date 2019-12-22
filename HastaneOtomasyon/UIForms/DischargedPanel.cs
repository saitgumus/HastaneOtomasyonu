using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneOtomasyon.Models;

namespace HastaneOtomasyon.UIForms
{
    public partial class DischargedPanel : Form
    {
        #region properties

        private List<Transfer> transferlist;
        private Discharged dataContract;
        private List<string> odemeTurleri;
        #endregion

        public DischargedPanel()
        {
            InitializeComponent();
            this.transferlist = new List<Transfer>();
        }
      
        public DischargedPanel(List<Transfer> transfers) : this()
        {
            this.transferlist = transfers;
            txtTutar.ReadOnly = true;
        }

        /// <summary>
        /// form yüklendiğinde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DischargedPanel_Load(object sender, EventArgs e)
        {
            GetOdeme();
            SetFields();
        }

        /// <summary>
        /// alanları doldurur
        /// </summary>
        private void SetFields()
        {
            if (transferlist != null && transferlist.Count > 0)
            {
                cmbOdemeSekli.DataSource = odemeTurleri;
                txtDosyaNo.Text = transferlist[0].DosyaNo.ToString();
                txtDosyaNo.ReadOnly = true;
                dateSevkTarihi.Value = transferlist[0].SevkTarihi;
                dateCikisTarihi.Value = DateTime.Today;
                double top = 0;
                transferlist.ForEach(x => top += x.ToplamTutar);
                txtTutar.Text = top.ToString();
            }
           
        }

        /// <summary>
        /// dataContract doldur
        /// </summary>
        private void SetDataContract()
        {
            dataContract.DosyaNo = Convert.ToInt32(txtDosyaNo.Text);
            dataContract.SevkTarihi = Convert.ToDateTime(dateSevkTarihi.Value);
            dataContract.CikisTarihi = DateTime.Today;
            dataContract.Odeme = (string) cmbOdemeSekli.SelectedItem;
            dataContract.ToplamTutar = Convert.ToInt32(txtTutar.Text);
        }

        /// <summary>
        /// odeme türlerini alır
        /// </summary>
        private void GetOdeme()
        {
            var request = new Request<bool, List<string>>();
            request.MethodName = "SelectOdeme";

            var response = request.Execute();
            if (!response.Success)
            {
                Messaging.DialogErrorMessage("Odeme türü bilgileri alınamadı.");
                return;
            }

            odemeTurleri = response.Value;
        }

        /// <summary>
        /// çıkış kayıt işlemi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SetDataContract();
            SaveCommand();
        }

        /// <summary>
        /// kaydetme işlemi
        /// </summary>
        private void SaveCommand()
        {
            var request =new Request<Discharged, bool>();
            request.MethodName = "InsertDischarged";

            var response = request.Execute(dataContract);
            if (!response.Success)
            {
                Messaging.DialogErrorMessage(Messaging.msg_kayıtHata);
                return;
            }

            Messaging.DialogInfoMessage("Çıkış işlemi kaydedildi.");
            this.Close();
        }

        /// <summary>
        /// kapat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
