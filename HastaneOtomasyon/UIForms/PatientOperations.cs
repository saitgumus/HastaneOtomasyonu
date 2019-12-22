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
        private Operation selectedOperation;
        List<Polyclinic> polyclinics;
        List<Transfer> transfers;
        private int DosyaNo;

        #endregion
        public PatientOperations()
        {
            InitializeComponent();
        }

        #region Methods


        /// <summary>
        /// load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PatientOperations_Load(object sender, EventArgs e)
        {
            selectedOperation = new Operation();
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

            GenericResponse<List<Transfer>> responseUser = request.Execute( null, "dosyano = '" + txtDosyaNo.Text + "' OR yapilanislem = '" + selectedOperation.IslemAdi + "'");

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

            GenericResponse<List<Transfer>> responseUser = request.Execute( DosyaNo );

            if (!responseUser.Success)
            {
                Messaging.DialogErrorMessage(responseUser.ErrorMessage);
                return;
            }

            transfers = responseUser.Value;
            dtgTahliller.DataSource = transfers;
        }

        /// <summary>
        /// dosya numarasından hasta getirir.
        /// </summary>
        private void GetPatient()
        {
            var request = new Request<Patient, Patient>();
            request.MethodName = "SelectPatientByKey";

            var response = request.Execute( DosyaNo );
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
            operations.Insert(0,new Operation{IslemAdi = Messaging.msg_seciniz});
            cmbYapilanIslem.DataSource = operations;
            cmbYapilanIslem.DisplayMember = "IslemAdi";

            polyclinics.Insert(0,new Polyclinic{PoliklinikAdi = Messaging.msg_seciniz});
            cmbPoliklinik.DataSource = polyclinics;
            cmbPoliklinik.DisplayMember = "PoliklinikAdi";

            users.Insert(0,new User{Kodu = 0});
            cmbDrKodu.DataSource = users;
            cmbDrKodu.DisplayMember = "Kodu";

            cmbSevkTarihi.DataSource = transfers;
            cmbSevkTarihi.DisplayMember = "SevkTarihi";
        }


        /// <summary>
        /// sevk kaydeder.
        /// </summary>
        /// <param name="transfer"></param>
        private void InsertTransfer(Transfer transfer)
        {
            var request = new Request<Transfer, bool>();
            request.DataContract = transfer;
            request.MethodName = "InsertTransfer";

            var response = request.Execute(transfer);
            if (!response.Success)
            {
                Messaging.DialogErrorMessage(Messaging.msg_kayıtHata);
                return;
            }

            GetTransfersAll();
            SetDataGridValues();
        }

        private void SetDataGridValues()
        {
            dtgTahliller.DataSource = transfers;
        }


        /// <summary>
        /// hasta bilgileri komboboxlarda seçilir
        /// dosya numarası girilip enter a basıldığında çalışır
        /// </summary>
        private void SetComboboxItemsForPatient()
        {
           
            var sevk = transfers.Find(r => r.DosyaNo == DosyaNo);

            if (patient != null)
            {
                txtDosyaNo.Text = patient.DosyaNo.ToString();
                txtHastaAdi.Text = patient.Ad;
                txtSoyadi.Text = patient.Soyad;
                txtKurumAdi.Text = patient.KurumAdi;
            }
            else
            {
                Messaging.DialogWarningMessage("Hasta kaydı bulunamadı.");
            }

            if (sevk != null)
            {
                var transfersSpec = transfers.Where(x => x.DosyaNo == DosyaNo).ToList();

                cmbOncekiIslemleri.DataSource = transfersSpec;
                cmbOncekiIslemleri.DisplayMember = "YapilanIslem";

                cmbSevkTarihi.DataSource = transfersSpec;
                cmbSevkTarihi.DisplayMember = "SevkTarihi";
            }
            else
            {
                Common.CleanTextControls(ref pnlHastaIslemleri);
            }

        }

        #endregion

        #region events
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
            if (cmbOncekiIslemleri.SelectedIndex != -1)
            {
                if (Common.TaburcuTxt == transfers.Find(x =>
                        x.DosyaNo == patient.DosyaNo &&
                        x.YapilanIslem == selectedOperation.IslemAdi)
                        .Taburcu)
                {
                    Messaging.DialogInfoMessage("Hasta bu sevkten taburcu edilmiş.");
                }
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
                if (patient != null && patient.DosyaNo == Convert.ToInt32(txtDosyaNo.Text))
                {
                    PatientInformation pinfo = new PatientInformation(patient);
                    pinfo.MdiParent = Main.ActiveForm;
                    pinfo.Show();
                }
                else
                {
                    PatientInformation pinfo = new PatientInformation(Convert.ToInt32(txtDosyaNo.Text));
                    pinfo.MdiParent = Main.ActiveForm;
                    pinfo.Show();
                }

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
            if (!Common.SpaceControlAll(ref pnlYeniEkle))
            {
                Messaging.DialogWarningMessage("zorunlu alanları doldurunuz.");
                return;
            }

            if (DosyaNo > 0 && patient.DosyaNo == DosyaNo && cmbYapilanIslem.SelectedIndex <= 0)
            {
                var transfer = new Transfer
                {
                    DosyaNo = int.Parse(txtDosyaNo.Text),
                    BirimFiyat = int.Parse(txtBirimFiyat.Text),
                    DrKod = (cmbDrKodu.SelectedItem as User).Kodu,
                    Miktar = Convert.ToInt32(cmbMiktar.Value),
                    Poliklinik = (cmbPoliklinik.SelectedItem as Polyclinic).PoliklinikAdi,
                    Saat = DateTime.Now.ToShortTimeString(),
                    SevkTarihi = DateTime.Today.Date,
                    Sira = Convert.ToInt32(cmbSiraNo.Text),
                    YapilanIslem = (cmbYapilanIslem.SelectedItem as Operation).IslemAdi,
                    Taburcu = Common.TaburcuTxt
                };

                InsertTransfer(transfer);
            }
            else
            {
                Messaging.DialogWarningMessage("Hatalı işlem. önce dosya numarası girip 'Enter' tuşuna basınız. daha sonra zorunlu alanlar doldurup ekleme yapabilirsiniz");
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

        /// <summary>
        /// miktar değiştiğinde tutar tekrar hesaplanır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbMiktar_ValueChanged(object sender, EventArgs e)
        {
            var birim = Convert.ToInt32(txtBirimFiyat.Text);
            if (birim > 0)
            {
                lblToplamTutarValue.Text = ((double)birim * (double)cmbMiktar.Value).ToString();
            }

        }

        /// <summary>
        /// seçili işlem değiştiğinde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbYapilanIslem_SelectedIndexChanged(object sender, EventArgs e)
        {
            var birim = operations.Find(x => x == cmbYapilanIslem.SelectedItem).BirimFiyat;
            txtBirimFiyat.Text = birim.ToString();
        }

        /// <summary>
        /// taburcu butonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTaburcu_Click(object sender, EventArgs e)
        {
            if (patient != null)
            {
                DischargedPanel dsgp = new DischargedPanel(patient);
                dsgp.MdiParent = Main.ActiveForm;
                dsgp.Show();
            }

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
                    GetTransferByDosyaNo();
                    SetComboboxItemsForPatient();
                }

            }
        }


        #endregion

        /// <summary>
        /// poliklinik seçim değiştiğinde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPoliklinik.SelectedIndex != -1)
            {
                cmbSiraNo.Text = Sira.GetNumber( (cmbPoliklinik.SelectedItem as Polyclinic).PoliklinikAdi ).ToString();
            }
        }


        /// <summary>
        /// selected operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbOncekiIslemleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOncekiIslemleri.SelectedItem != null)
            {
                var operat = (Transfer) cmbOncekiIslemleri.SelectedItem;

                selectedOperation = operations.Find(x => x.IslemAdi == operat.YapilanIslem);
            }
        }

        /// <summary>
        /// seç / sil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSecSil_Click(object sender, EventArgs e)
        {

        }
    }
}
