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
    public partial class DischargedPanel : Form
    {
        #region properties

        private Patient patient;
        private Discharged dataContract;
        private List<string> odemeTurleri;
        #endregion

        public DischargedPanel()
        {
            InitializeComponent();
            this.patient = new Patient();
        }
        public DischargedPanel(Patient patient) : this()
        {
            this.patient = patient;
        }

        /// <summary>
        /// form yüklendiğinde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DischargedPanel_Load(object sender, EventArgs e)
        {
            GetOdeme();
            SetFields();
        }

        /// <summary>
        /// alanları doldurur
        /// </summary>
        private void SetFields()
        {
            cmbOdemeSekli.DataSource = odemeTurleri;
            txtDosyaNo.Text = patient.DosyaNo.ToString();
            txtDosyaNo.ReadOnly = true;

            dateSevkTarihi.Value = DateTime.Today;
            dateCikisTarihi.Value = DateTime.Today;
        }

        /// <summary>
        /// odeme türlerini alır
        /// </summary>
        private void GetOdeme()
        {
            var request = new Request<bool, List<string>>();
            request.MethodName = "SelectOdeme";

            var response = request.Execute();
            if (!response.Success)
            {
                Messaging.DialogErrorMessage("Odeme türü bilgileri alınamadı.");
                return;
            }

            odemeTurleri = response.Value;
        }
    }
}
