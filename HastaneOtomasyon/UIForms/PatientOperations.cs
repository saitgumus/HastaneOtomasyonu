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
// ReSharper disable All

namespace HastaneOtomasyon.UIForms
{
    public partial class PatientOperations : Form
    {
        #region properties
        Patient patient;
        List<User> users;
        List<Operation> operations;
        List<Polyclinic> polyclinics;
        List<Transfer> transfers;
        private int DosyaNo;

        #endregion
        public PatientOperations()
        {
            InitializeComponent();
        }

        /// <summary>
        /// load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PatientOperations_Load(object sender, EventArgs e)
        {
            GetUsers();
            GetPolyclinics();
            GetOperations();
            SetComboboxes();
        }


        /// <summary>
        /// kullanıcıları al
        /// </summary>
        private void GetUsers()
        {
            users = new List<User>();

            Request<User, List<User>> request = new Request<User, List<User>>();
            request.MethodName = "SelectUser";

            GenericResponse<List<User>> responseUser = request.Execute();

            if (!responseUser.Success)
            {
                Messaging.DialogErrorMessage(responseUser.ErrorMessage);
                return;
            }

            users = responseUser.Value;
            var list = users.Where(x => x.Unvan == Unvan.Doktor).ToList();
            cmbDrKodu.DataSource = list;
            cmbDrKodu.DisplayMember = "Kodu";
        }

        /// <summary>
        /// poliklinikleri al
        /// </summary>
        private void GetPolyclinics()
        {
            polyclinics = new List<Polyclinic>();

            Request<Polyclinic, List<Polyclinic>> request = new Request<Polyclinic, List<Polyclinic>>();
            request.MethodName = "SelectPolyclinic";

            GenericResponse<List<Polyclinic>> responseUser = request.Execute();

            if (!responseUser.Success)
            {
                Messaging.DialogErrorMessage(responseUser.ErrorMessage);
                return;
            }

            polyclinics = responseUser.Value;
        }

        /// <summary>
        /// işlemleri al
        /// </summary>
        private void GetOperations()
        {
            operations = new List<Operation>();

            Request<Operation, List<Operation>> request = new Request<Operation, List<Operation>>();
            request.MethodName = "SelectOperation";

            GenericResponse<List<Operation>> responseUser = request.Execute();

            if (!responseUser.Success)
            {
                Messaging.DialogErrorMessage(responseUser.ErrorMessage);
                return;
            }

            operations = responseUser.Value;
        }

        /// <summary>
        /// sevk getir
        /// git butonu click eventi
        /// TODO: güncellenecek (filtre kalkacak)
        /// </summary>
        private void GetTransfersAll()
        {
            transfers = new List<Transfer>();

            Request<Transfer, List<Transfer>> request = new Request<Transfer, List<Transfer>>();
            request.MethodName = "SelectTransfer";

            GenericResponse<List<Transfer>> responseUser = request.Execute(new object[] {null, "dosyano = '" + txtDosyaNo.Text + "' OR yapilanislem = '"+cmbOncekiIslemleri.Text+"'" });

            if (!responseUser.Success)
            {
                Messaging.DialogErrorMessage(responseUser.ErrorMessage);
                return;
            }

            transfers = responseUser.Value;
        }

        /// <summary>
        /// dosya numarasına göre sevk getirir
        /// </summary>
        private void GetTransferByDosyaNo()
        {
            transfers = new List<Transfer>();

            Request<Transfer, List<Transfer>> request = new Request<Transfer, List<Transfer>>();
            request.MethodName = "SelectTransferByDosyaNo";

            GenericResponse<List<Transfer>> responseUser = request.Execute(new object[] { DosyaNo});

            if (!responseUser.Success)
            {
                Messaging.DialogErrorMessage(responseUser.ErrorMessage);
                return;
            }

            transfers = responseUser.Value;
        }

        /// <summary>
        /// dosya numarasından hasta getirir.
        /// </summary>
        private void GetPatient()
        {
            var request = new Request<Patient, Patient>();
            request.MethodName = "SelectPatientByKey";

            var response = request.Execute(new object[] {DosyaNo});
            if (response.Success)
            {
                patient = response.Value;
            }
            else
            {
                Messaging.DialogErrorMessage(response.ErrorMessage);
            }

        }

        /// <summary>
        /// komboboxları doldur
        /// </summary>
        private void SetComboboxes()
        {
            cmbOncekiIslemleri.DataSource = operations;
            cmbOncekiIslemleri.DisplayMember = "IslemAdi";

            cmbPoliklinik.DataSource = polyclinics;
            cmbPoliklinik.DisplayMember = "PoliklinikAdi";

            cmbDrKodu.DataSource = users;
            cmbDrKodu.DisplayMember = "Kodu";

            cmbSevkTarihi.DataSource = transfers;
            cmbSevkTarihi.DisplayMember = "SevkTarihi";
        }

        /// <summary>
        /// bul
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SearchFile searchFile = new SearchFile();
            searchFile.MdiParent = Main.ActiveForm;
            searchFile.Show();
        }

        /// <summary>
        /// git >
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGit_Click(object sender, EventArgs e)
        {
            if(cmbOncekiIslemleri.SelectedIndex != -1)
            {
                dtgTahliller.DataSource = transfers;
            }
        }


        /// <summary>
        /// hasta bilgileri ekranı açılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // ReSharper disable once IdentifierTypo
        private void btnHastaBilgileri_Click(object sender, EventArgs e)
        {
            if (Common.SpaceControl(txtDosyaNo.Text))
            {
                PatientInformation pinfo = new PatientInformation(Convert.ToInt32(txtDosyaNo.Text));
                pinfo.MdiParent = Main.ActiveForm;
                pinfo.Show();
            }
            else
            {
                Messaging.DialogWarningMessage("Dosya numarası giriniz.");
            }
        }



        /// <summary>
        /// datagrid'e yeni veri ekler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEkle_Click(object sender, EventArgs e)
        {
            var transfer = new Transfer
            {
                DosyaNo = int.Parse(txtDosyaNo.Text),
                BirimFiyat = int.Parse(txtBirimFiyat.Text),
                DrKod = int.Parse(cmbDrKodu.SelectedText),
                Miktar = Convert.ToInt32(cmbMiktar.Value),
                Poliklinik = cmbPoliklinik.SelectedText,
                Saat = DateTime.Now,
                SevkTarihi = Convert.ToDateTime(cmbSevkTarihi.SelectedText),
                Sira = 0
            };
        }

       
        /// <summary>
        /// dosya no enter basıldığında
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDosyaNo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!Common.SpaceControl(txtDosyaNo.Text))
                {
                    return;
                }

                DosyaNo = int.Parse(txtDosyaNo.Text);

                if (DosyaNo > 0)
                {
                    GetPatient();
                    SetComboboxItemsForPatient();
                }

            }
        }

        /// <summary>
        /// hasta bilgileri komboboxlarda seçilir
        /// dosya numarası girilip enter a basıldığında çalışır
        /// </summary>
        private void SetComboboxItemsForPatient()
        {
            if (transfers == null || transfers.Count < 1)
            {
                GetTransferByDosyaNo();
            }

            var sevk = transfers.Find(r => r.DosyaNo == DosyaNo);

            if (patient != null)
            {
                txtDosyaNo.Text = patient.DosyaNo.ToString();
                txtHastaAdi.Text = patient.Ad;
                txtSoyadi.Text = patient.Soyad;
                txtKurumAdi.Text = patient.KurumAdi;
            }

            if (sevk != null)
            {
                var transfersSpec = transfers.Where(x => x.DosyaNo == DosyaNo).ToList();
                cmbOncekiIslemleri.DataSource = transfersSpec;
                cmbOncekiIslemleri.DisplayMember = "YapilanIslem";

                cmbSevkTarihi.DataSource = transfersSpec;
                cmbSevkTarihi.DisplayMember = "SevkTarihi";
            }
        }

        /// <summary>
        /// yeni hasta ekler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYeni_Click(object sender, EventArgs e)
        {
            PatientInformation ptInfo = new PatientInformation();
            ptInfo.MdiParent = Main.ActiveForm;
            ptInfo.Show();
        }
    }
}
