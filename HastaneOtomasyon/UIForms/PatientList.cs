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
    /// <summary>
    /// filtreli listeleme ekranı
    /// bütün filtreler defalt bırakıldığında tüm kayıtlar getirir.
    /// </summary>
    public partial class listForm : Form
    {
        #region properties

        private TransferListContract datacontract;
        private List<TransferListContract> dataList;
        #endregion
        public listForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// ara
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_Click(object sender, EventArgs e)
        {
            SetFilterContract();
            GetData();
        }

        /// <summary>
        /// filtre set
        /// </summary>
        private void SetFilterContract()
        {
            datacontract = new TransferListContract();

            if (txtDosyaNo.Text.Trim().Length > 0)
            {
                datacontract.DosyaNo = Convert.ToInt32(txtDosyaNo.Text);
            }

            if (txtTcKimlikNumarasi.Text.Trim().Length == 11)
            {
                datacontract.Tckimlikno = txtTcKimlikNumarasi.Text;
            }

            if (rb_taburcuolmus.Checked)
            {
                datacontract.Taburcu = Common.TaburcuTxt;
            }

            if (rb_taburcuolmamıs.Checked)
            {
                datacontract.Taburcu = Common.TaburcuDegilTxt;
            }

            datacontract.SevkTarihi = dtp_baslangictarihi.Value;
            datacontract.CikisTarihi = dtp_bitistarihi.Value;
        }

        /// <summary>
        /// verileri getirir
        /// </summary>
        private void GetData()
        {
            var request = new Request<TransferListContract, List<TransferListContract>>();
            request.MethodName = "SelectGeneralList";

            var response = request.Execute(datacontract);
            if (!response.Success)
            {
                Messaging.DialogErrorMessage("Bilgiler alınamadı");
                return;
            }

            dataList = response.Value;
            dtgridDataList.DataSource = dataList;
        }

        /// <summary>
        /// form yüklendiğinde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listForm_Load(object sender, EventArgs e)
        {
            datacontract = new TransferListContract();
            dataList = new List<TransferListContract>();
        }

        /// <summary>
        /// filtre sıfırla
        /// </summary>
        private void SetDefaultForm()
        {
            txtDosyaNo.Text = "";
            txtTcKimlikNumarasi.Text = "";
            rb_hepsi.Checked = true;
        }

        /// <summary>
        /// temizle butonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            SetDefaultForm();
            dtgridDataList.DataSource = null;
        }

        /// <summary>
        /// çıkış
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
