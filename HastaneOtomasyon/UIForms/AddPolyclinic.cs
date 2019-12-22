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
        private bool isUpdate;
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
                Messaging.DialogErrorMessage("poliklinik listesi alınamadı.");
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
            if (e.KeyChar == (Char)Keys.Enter)
            {
                pnl_polyclinic.Visible = true;
                this.Height = 500;
                if (isUpdate)
                {
                    if (selectedData.Durum == Common.PolyclinicStatusAktif)
                    {
                        cbx_gecerli.Checked = true;
                    }
                    else
                    {
                        cbx_gecerli.Checked = false;
                    }


                    txtAciklama.Text = selectedData.Aciklama;
                }
                else
                {
                    txtAciklama.Text = "";
                }

            }
        }

        /// <summary>
        /// butonu kaydetme durumuna getirir
        /// </summary>
        private void SetButtonToSave()
        {
            btnGuncelle.Text = "Kaydet";
            btnGuncelle.Image = global::HastaneOtomasyon.Properties.Resources.Save1;
            isUpdate = false;
        }

        /// <summary>
        /// butonu güncelle durumuna getirir.
        /// </summary>
        private void SetButtonToUpdate()
        {
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.Image = global::HastaneOtomasyon.Properties.Resources.Update;
            isUpdate = true;
        }

        /// <summary>
        /// seçili poliklinik değiştiğinde çalışır.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_policlinic_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if (polyList.Contains((cmb.SelectedItem as Polyclinic)))
            {
                selectedData = (Polyclinic)cmb.SelectedItem;
                SetButtonToUpdate();
            } 
        }

        /// <summary>
        /// poliklinik güncelleme/kaydetme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                Request<Polyclinic, bool> request = new Request<Polyclinic, bool>();
                request.MethodName = "UpdatePolyclinic";

                var response = request.Execute(selectedData);
                if (!response.Success)
                {
                    Common.WriteLog("database", "poliklinik kaydı yapılamadı.");
                    Messaging.DialogErrorMessage(Messaging.msg_güncellemeHata);
                    return;
                }

                Messaging.DialogInfoMessage(Messaging.msg_güncellemeOk);
            }
            else
            {
                var request = new Request<Polyclinic, bool>();
                request.MethodName = "InsertPolyclinic";

                var response = request.Execute(new Polyclinic
                                                        {
                                                            PoliklinikAdi = cmb_policlinic.Text,
                                                            Aciklama = txtAciklama.Text,
                                                            Durum = (cbx_gecerli.CheckState == CheckState.Checked) ? Common.PolyclinicStatusAktif : Common.PolyclinicStatusPasif
                                                        });

                if (!response.Success)
                {
                    Messaging.DialogErrorMessage(Messaging.msg_kayıtHata);
                    return;
                }

                Messaging.DialogInfoMessage(Messaging.msg_kayıtOk);
            }

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
                if (Messaging.DialogExamMessage(Messaging.msg_silmeIslemiSoru))
                {
                    Request<Polyclinic, bool> request = new Request<Polyclinic, bool>();
                    request.MethodName = "DeletePolyclinic";
                    object[] vs = new object[1];
                    vs[0] = selectedData;
                    var response = request.Execute(vs);
                    if (!response.Success)
                    {
                        Common.WriteLog("database", "poliklinik kaydı silinemedi.");
                        Messaging.DialogErrorMessage(Messaging.msg_silmeHata + response.ErrorMessage);
                        return;
                    }

                    Messaging.DialogInfoMessage(Messaging.msg_silmeOk);
                }

            }
            else
            {
                Messaging.DialogWarningMessage(Messaging.msg_selectRecordWarning);
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

        /// <summary>
        /// manuel isim girildiğinde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_policlinic_TextChanged(object sender, EventArgs e)
        {
            if (selectedData != null)
            {
                selectedData = new Polyclinic();
            }

            SetButtonToSave();
        }
    }
}
