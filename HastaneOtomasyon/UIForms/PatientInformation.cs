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
        public int DosyaNo { get; private set; }

        #endregion
        public PatientInformation()
        {
            InitializeComponent();
        } 
        public PatientInformation(int dosyaNo):this()
        {
            DosyaNo = dosyaNo;
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
                Common.DialogErrorMessage(response.ErrorMessage);
                return;
            }

            if (response.Value.Count > 0)
            {
                patient = response.Value[0];
            }
            else
            {
                Common.DialogWarningMessage(Common.msg_hastaBulunamadı);
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
            if (DosyaNo > 0)
            {  GetPatient();
                SetFields();
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
    }
}
