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
    public partial class PatientOperations : Form
    {
        #region properties
        List<Patient> patients;
        List<User> users;
        List<Operation> operations;
        List<Polyclinic> polyclinics;
        List<Transfer> transfers;

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
                Common.DialogErrorMessage(responseUser.ErrorMessage);
                return;
            }

            users = responseUser.Value;
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
                Common.DialogErrorMessage(responseUser.ErrorMessage);
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
                Common.DialogErrorMessage(responseUser.ErrorMessage);
                return;
            }

            operations = responseUser.Value;
        }

        /// <summary>
        /// sevk getir
        /// </summary>
        private void GetTransfers()
        {
            transfers = new List<Transfer>();

            Request<Transfer, List<Transfer>> request = new Request<Transfer, List<Transfer>>();
            request.MethodName = "SelectTransfer";

            GenericResponse<List<Transfer>> responseUser = request.Execute(new object[] {null, "dosyano = '" + txtDosyaNo.Text + "' AND yapilanislem = '"+cmbOncekiIslemleri.Text+"'" });

            if (!responseUser.Success)
            {
                Common.DialogErrorMessage(responseUser.ErrorMessage);
                return;
            }

            transfers = responseUser.Value;
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
                GetTransfers();
            }
        }
    }
}
