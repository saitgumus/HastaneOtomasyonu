using HastaneOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon.UIForms
{
    public partial class UserDefinition : Form
    {
        #region properties
        bool isUpdate;
        User updateUser;
        User data;
        #endregion

        #region constructors
         public UserDefinition()
         {
             InitializeComponent();
             updateUser = new User();
            data = new User();
         }
        
         public UserDefinition(User user) : this()
         {
             updateUser = user;
             isUpdate = true;
           
        }




        #endregion

        /// <summary>
        /// load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserDefinition_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                btnGuncelleKaydet.Image = global::HastaneOtomasyon.Properties.Resources.Update;
                btnGuncelleKaydet.Text = "Güncelle";
                txtKullaniciKodu.Enabled = false;
                SetUpdateUser();
            }
        }

        /// <summary>
        /// form alanlarını doldurur
        /// </summary>
        private void SetUpdateUser()
        {
            txtKullaniciKodu.Text = updateUser.Kodu;
            txtAdi.Text = updateUser.Ad;
            txtSoyadi.Text = updateUser.Soyad;
            txtSifre.Text = updateUser.Sifre;
            if (updateUser.Yetki == Common.AdminText)
                chcYetkiliKullanici.Checked = true;
            else
                chcYetkiliKullanici.Checked = false;

            txtTelefonNo.Text = updateUser.Evtel;
            txtGSM.Text = updateUser.CepTel;
            txtAdres.Text = updateUser.Adres;
            cmbUnvani.Text = updateUser.Unvan;
            dateIseBaslama.Value = (updateUser.IseBaslama < dateIseBaslama.MinDate)? dateIseBaslama.MinDate: updateUser.IseBaslama ;
            txtMaas.Text = updateUser.Maas;
            txtDogumYeri.Text = updateUser.DogumYeri;
            txtAnneAdi.Text = updateUser.AnneAd;
            txtBabaAdi.Text = updateUser.BabaAd;
            cmbCinsiyeti.Text = updateUser.Cinsiyet;
            cmbKanGrubu.Text = updateUser.KanGrubu;
            cmbMedeniHal.Text = updateUser.MedeniHal;
            dateDogumTarihi.Value = (updateUser.DogumTarihi < dateIseBaslama.MinDate) ? dateIseBaslama.MinDate : updateUser.DogumTarihi;
            txtTcKimlikNumarasi.Text = updateUser.TcKimlikNo;
            txtKullaniciAdi.Text = updateUser.UserName;
        }

        /// <summary>
        /// buton save or update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuncelleKaydet_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                UdateUser();
            }
            else
            {
                if(Common.SpaceControlAll(ref pnlUserDef))
                {
                    SetUserValues();
                    SaveUser();
                }
                else
                {
                    Common.DialogWarningMessage(Common.msg_zorunluAlanWarning);
                    return;
                }
            }
        }

        /// <summary>
        /// set user values
        /// </summary>
        private void SetUserValues()
        {
            data.Kodu = txtKullaniciKodu.Text;
            data.Ad = txtAdi.Text;
            data.Soyad = txtSoyadi.Text;
            data.Sifre = txtSifre.Text;
            if (chcYetkiliKullanici.Checked == true)
                data.Yetki = Common.AdminText;
            else
                data.Yetki = null;
            data.Evtel = txtTelefonNo.Text;
            data.CepTel = txtGSM.Text;
            data.Adres = txtAdres.Text;
            data.Unvan = cmbUnvani.Text;
            data.IseBaslama = Convert.ToDateTime(dateIseBaslama.Value);
            data.Maas = txtMaas.Text;
            data.DogumYeri = txtDogumYeri.Text;
            data.AnneAd = txtAnneAdi.Text;
            data.BabaAd = txtBabaAdi.Text;
            data.Cinsiyet = cmbCinsiyeti.Text;
            data.KanGrubu = cmbKanGrubu.Text;
            data.MedeniHal = cmbMedeniHal.Text;
            data.DogumTarihi = Convert.ToDateTime(dateDogumTarihi.Value);
            data.TcKimlikNo = txtTcKimlikNumarasi.Text;
            data.UserName = txtKullaniciAdi.Text;
        }

        /// <summary>
        /// kullanıcıyı kaydet
        /// </summary>
        private void SaveUser()
        {

            var request = new Request<User, bool>();
            request.MethodName = "InsertUser";
            object[] o = new object[1];
            o[0] = data;

            var response = request.Execute(o);
            if (!response.Success)
            {
                Common.DialogErrorMessage(response.ErrorMessage);
                return;
            }

            Common.DialogInfoMessage(Common.msg_kayıtOk);
        }

        /// <summary>
        /// kullanıcı güncelle
        /// </summary>
        private void UdateUser()
        {
            var request = new Request<User, bool>();
            request.MethodName = "UpdateUser";
            object[] o = new object[1];
            o[0] = updateUser;

            var response = request.Execute(o);
            if (!response.Success)
            {
                Common.DialogErrorMessage(response.ErrorMessage);
                return;
            }

            Common.DialogInfoMessage(Common.msg_güncellemeOk);
        }

        /// <summary>
        /// kullanıcı kodu girildikten sonra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtKullaniciKodu_Leave(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// temizleme
        /// </summary>
        private void Clean()
        {
            Common.CleanTextControls(ref pnlUserDef);
            Common.CleanTextControls(ref pnl_userNamePass);
        }

        /// <summary>
        /// temizle butonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Clean();
        }

        /// <summary>
        /// sil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSil_Click(object sender, EventArgs e)
        {
            if(Common.SpaceControl(txtKullaniciKodu.Text))
            {
                if(Common.DialogExamMessage(Common.msg_silmeIslemiSoru ))
                {
                    var request = new Request<User, bool>();
                    request.MethodName = "DeleteUser";
                    User user = new User{ Kodu= txtKullaniciKodu.Text};
                    var response = request.Execute(new object[] { user });
                    if (!response.Success)
                    {
                        Common.DialogErrorMessage(Common.msg_silmeHata + response.ErrorMessage);
                        return;
                    }

                    Common.DialogInfoMessage(Common.msg_silmeOk);
                }
            }
        }

        /// <summary>
        /// formu kapat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
