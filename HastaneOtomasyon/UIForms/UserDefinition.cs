﻿using HastaneOtomasyon.Models;
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
        private List<string> unvans;
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
            else
            {
                SetDefaultValues();
            }
        }

        /// <summary>
        /// form alanlarını doldurur
        /// </summary>
        private void SetUpdateUser()
        {
            txtKullaniciKodu.Text = updateUser.Kodu.ToString();
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
            txtMaas.Text = updateUser.Maas.ToString();
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
        /// default değerler girilir
        /// </summary>
        private void SetDefaultValues()
        {
            dateDogumTarihi.Value = DateTime.Today;
            dateDogumTarihi.Value = DateTime.Today;
            GetUnvan();
            cmbUnvani.DataSource = unvans;
        }

        /// <summary>
        /// ünvan kayıtlarınık getirir
        /// </summary>
        private void GetUnvan()
        {
            var request = new Request<bool,List<string>>();
            request.MethodName = "SelectUnvan";

            var response = request.Execute();
            if (!response.Success)
            {
                Messaging.DialogErrorMessage("unvan listesi alınamadı");
                return;
            }

            unvans = new List<string>();
            unvans = response.Value;
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
                    Messaging.DialogWarningMessage(Messaging.msg_zorunluAlanWarning);
                    return;
                }
            }
        }

        /// <summary>
        /// set user values
        /// </summary>
        private void SetUserValues()
        {
            data.Kodu = Convert.ToInt32(txtKullaniciKodu.Text);
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
            data.Maas = Convert.ToInt32(txtMaas.Text);
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
                Messaging.DialogErrorMessage(response.ErrorMessage);
                return;
            }

            Messaging.DialogInfoMessage(Messaging.msg_kayıtOk);
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
                Messaging.DialogErrorMessage(response.ErrorMessage);
                return;
            }

            Messaging.DialogInfoMessage(Messaging.msg_güncellemeOk);
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
        /// eğer sadece alfabetik veya silme tuşu ise true döner.
        /// event fonksiyonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckAlphabetic(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Common.ControlAlphabetic(e);
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
                if(Messaging.DialogExamMessage(Messaging.msg_silmeIslemiSoru ))
                {
                    var request = new Request<User, bool>();
                    request.MethodName = "DeleteUser";
                    User user = new User{ Kodu= Convert.ToInt32(txtKullaniciKodu.Text)};
                    var response = request.Execute( user );
                    if (!response.Success)
                    {
                        Messaging.DialogErrorMessage(Messaging.msg_silmeHata + response.ErrorMessage);
                        return;
                    }

                    Messaging.DialogInfoMessage(Messaging.msg_silmeOk);
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
