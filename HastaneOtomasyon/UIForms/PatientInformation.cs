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
        public string DosyaNo { get; private set; }

        #endregion
        public PatientInformation()
        {
            InitializeComponent();
        } 
        public PatientInformation(string dosyaNo):this()
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
            GetPatient();
        }

        /// <summary>
        /// dosya numarası enter'a basıldığında
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDosyaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
