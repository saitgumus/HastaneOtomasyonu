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
    public partial class AddPolyclinic : Form
    {
        #region properties

        List<Polyclinic> polyList;
        Polyclinic selectedData;

        #endregion
        public AddPolyclinic()
        {
            InitializeComponent();
        }

        /// <summary>
        /// load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPolyclinic_Load(object sender, EventArgs e)
        {
            polyList = new List<Polyclinic>();
            selectedData = new Polyclinic();

            GetPolyclinicList();
        }

        /// <summary>
        /// listeyi getirir
        /// </summary>
        private void GetPolyclinicList()
        {
            Request<Polyclinic, List<Polyclinic>> request = new Request<Polyclinic, List<Polyclinic>>();
            request.MethodName = "SelectPolyclinic";

            var response = request.Execute();
            if (!response.Success)
            {
                Common.WriteLog("veri tabanı", "poliklinik listesi alınamadı");
                Common.DialogErrorMessage("poliklinik listesi alınamadı.");
                return;
            }

            polyList = response.Value;
            SetListToCombo();

        }

        /// <summary>
        /// listeyi kombobox a atar.
        /// </summary>
        private void SetListToCombo()
        {
            cmb_policlinic.DataSource = polyList;
            cmb_policlinic.DisplayMember = "poliklinikAdi";
        }

        /// <summary>
        /// keypress (enter? )
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_policlinic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter)
            {
                pnl_polyclinic.Visible = true;
                this.Height = 550;

                if(selectedData.Durum == Common.PolyclinicStatus)
                {
                    cbx_gecerli.Checked = true;
                }
                else
                {
                    cbx_gecerli.Checked = false;
                }

                txtAciklama.Text = selectedData.Aciklama;
            }
        }

        private void cmb_policlinic_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            selectedData = (Polyclinic)cmb.SelectedItem;
        }

        /// <summary>
        /// poliklinik güncelleme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Request<Polyclinic, bool> request = new Request<Polyclinic, bool>();
            request.MethodName = "UpdatePolyclinic";

            var response = request.Execute();
            if (!response.Success)
            {
                Common.WriteLog("database", "poliklinik kaydı yapılamadı.");
                Common.DialogErrorMessage(Common.msg_güncellemeHata);
                return;
            }

            Common.DialogInfoMessage(Common.msg_güncellemeOk);
        }

        /// <summary>
        /// silme işlemi yapar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (selectedData != null)
            {
                if (Common.DialogExamMessage(Common.msg_silmeIslemiSoru))
                {
                    Request<Polyclinic, bool> request = new Request<Polyclinic, bool>();
                    request.MethodName = "DeletePolyclinic";
                    object[] vs = new object[1];
                    vs[0] = selectedData;
                    var response = request.Execute(vs);
                    if (!response.Success)
                    {
                        Common.WriteLog("database", "poliklinik kaydı silinemedi.");
                        Common.DialogErrorMessage(Common.msg_silmeHata);
                        return;
                    }

                    Common.DialogInfoMessage(Common.msg_silmeOk);
                }
                
            }
            else
            {
                Common.DialogWarningMessage(Common.msg_selectRecordWarning);
            }

        }

        /// <summary>
        /// exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
