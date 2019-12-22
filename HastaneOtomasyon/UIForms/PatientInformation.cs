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
    public partial class PatientInformation : Form
    {
        #region properties

        private Patient patient;
        private bool isUpdate;

        public int DosyaNo { get; private set; }

        #endregion
        public PatientInformation()
        {
            InitializeComponent();
        }
        public PatientInformation(int dosyaNo) : this()
        {
            DosyaNo = dosyaNo;
            isUpdate = true;
        }
        public PatientInformation(Patient patient) : this()
        {
            this.patient = patient;
            isUpdate = true;
        }

        /// <summary>
        /// hasta bilgisi getirir
        /// </summary>
        private void GetPatient()
        {
            var filterstring = $"dosyano = '{DosyaNo}'";

            var req = new Request<Patient, List<Patient>>
            {
                DataContract = new Patient()
                {
                    DosyaNo = DosyaNo
                },
                MethodName = "SelectPatient"
            };

            var response = req.Execute(o: new object[2]
            {
                null,
                filterstring
            });

            if (!response.Success)
            {
                Messaging.DialogErrorMessage(response.ErrorMessage);
                return;
            }

            if (response.Value.Count > 0)
            {
                patient = response.Value[0];
            }
            else
            {
                Messaging.DialogWarningMessage(Messaging.msg_hastaBulunamadı);
                return;
            }
        }

        /// <summary>
        /// form load olduğunda çalışır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PatientInformation_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                if (DosyaNo > 0 && patient == null)
                {
                    GetPatient();
                }

                SetFields();

                SetSaveButtonImage();
                txtDosyaNo.ReadOnly = true;
                txtTcKimlikNo.ReadOnly = true;
            }
            else
            {
                GetLastFileNumber();
            }

            txtDosyaNo.Text = (Dosya.SonDosyaNumarası +1).ToString();
            txtDosyaNo.ReadOnly = true;

        }

        /// <summary>
        /// son dosya numarası bilgisini getirir.
        /// </summary>
        private void GetLastFileNumber()
        {
            var request = new Request<bool,int>();
            request.MethodName = "SelectDosyaNo";

            var response = request.Execute();
            if (!response.Success)
            {
                Messaging.DialogErrorMessage("son dosya numarası alınamadı.");
                return;

            }

            Dosya.SonDosyaNumarası = response.Value;

        }

        /// <summary>
        /// kaydet/güncelle buton Image değiştirir
        /// </summary>
        private void SetSaveButtonImage()
        {
            if (isUpdate)
            {
                btnKaydet.Text = "Güncelle";
                btnKaydet.Image = global::HastaneOtomasyon.Properties.Resources.Update;
            }
        }

        /// <summary>
        /// alanları doldurur.
        /// </summary>
        private void SetFields()
        {
            txtTcKimlikNo.Text = patient.TcKimlikNo;
            txtDosyaNo.Text = patient.DosyaNo.ToString();
            txtAdi.Text = patient.Ad;
            txtSoyadi.Text = patient.Soyad;
            txtDogumYeri.Text = patient.DogumYeri;
            dateDogumTarihi.Value = patient.DogumTarihi;
            txtBabaAdi.Text = patient.BabaAdi;
            txtAnneAdi.Text = patient.AnneAdi;
            cmbCinsiyet.Text = patient.Cinsiyet;
            cmbKanGrubu.Text = patient.KanGrubu;
            cmbMedeniHal.Text = patient.MedeniHal;
            txtAdres.Text = patient.Adres;
            txtTelefonNo.Text = patient.Tel;
            txtKurumSicilNo.Text = patient.KurumSicilNo;
            txtKurumAdi.Text = patient.KurumAdi;
            txtYakininTelefonu.Text = patient.YakinTel;
            txtYakininKurumSicilNo.Text = patient.YakinKurumSicilNo;
            txtYakininKurumAdi.Text = patient.YakinKurumAdi;
        }

        /// <summary>
        /// dosya numarası enter'a basıldığında
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDosyaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        /// <summary>
        /// kaydet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!Common.SpaceControlAll(ref pnlPatientInfo))
            {
                Messaging.DialogWarningMessage(Messaging.msg_zorunluAlanWarning);
                return;
            }

            if (isUpdate)
            {
                UpdatePatientData();
                UpdatePatient();
            }
            else
            {
                UpdatePatientData();
                SavePatient();
            }
        }

        /// <summary>
        /// güncelleme yapar
        /// </summary>
        private void UpdatePatient()
        {
            var request = new  Request<Patient,bool>();
            request.DataContract = patient;
            request.MethodName = "InsertPatient";

            var response = request.Execute(patient);
            if (!response.Success)
            {
                Messaging.DialogErrorMessage("Kayıt hatası" + response.ErrorMessage);
                return;
            }

            Messaging.DialogInfoMessage(Messaging.msg_kayıtOk);
        }

        /// <summary>
        /// yeni ekler
        /// </summary>
        private void SavePatient()
        {
            var request = new Request<Patient, bool>();
            request.DataContract = patient;
            request.MethodName = "UpdatePatient";

            var response = request.Execute(patient);
            if (!response.Success)
            {
                Messaging.DialogErrorMessage("Kayıt hatası" + response.ErrorMessage);
                return;
            }

            Messaging.DialogInfoMessage(Messaging.msg_kayıtOk);
        }

        /// <summary>
        /// hasta bilgilerini güneller
        /// </summary>
        private void UpdatePatientData()
        {
            patient.DogumYeri = txtDogumYeri.Text;
            patient.DogumTarihi = dateDogumTarihi.Value;
            patient.BabaAdi = txtBabaAdi.Text;
            patient.AnneAdi = txtAnneAdi.Text;
            patient.Cinsiyet = cmbCinsiyet.Text;
            patient.KanGrubu = cmbKanGrubu.Text;
            patient.MedeniHal = cmbMedeniHal.Text;
            patient.Adres = txtAdres.Text;
            patient.Tel = txtTelefonNo.Text;
            patient.KurumSicilNo = txtKurumSicilNo.Text;
            patient.KurumAdi = txtKurumAdi.Text;
            patient.YakinTel = txtYakininTelefonu.Text;
            patient.YakinKurumSicilNo = txtYakininKurumSicilNo.Text;
            patient.YakinKurumAdi = txtYakininKurumAdi.Text;
            patient.Ad = txtAdi.Text;
            patient.Soyad = txtSoyadi.Text;
        }

        /// <summary>
        /// temizler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYeni_Click(object sender, EventArgs e)
        {
            Common.CleanTextControls(ref pnlPatientInfo);
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
    }
}
