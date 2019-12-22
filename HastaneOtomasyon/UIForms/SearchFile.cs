using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.Reflection;
using HastaneOtomasyon.Models;

namespace HastaneOtomasyon.UIForms
{
    public partial class SearchFile : Form
    {
        #region properties

        private string filterHead, filterStr;
        private Patient p;
        private Dictionary<string, Type> fltrNameAndTypes;
        #endregion
        public SearchFile()
        {
            InitializeComponent();
        }

        /// <summary>
        /// form load olduğunda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchFile_Load(object sender, EventArgs e)
        {
           p = new Patient();
           fltrNameAndTypes = new Dictionary<string, Type>();
           fltrNameAndTypes = Common.GetClassPropertyDictionary<Patient>();

           cmbKriterBaslık.DataSource = fltrNameAndTypes.Keys.ToList();
        }

        /// <summary>
        /// filtre ayrıntı
         /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_bilgi_TextChanged(object sender, EventArgs e)
        {
            filterStr = txt_bilgi.Text;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBul_Click(object sender, EventArgs e)
        {
            if (Common.SpaceControl(filterStr))
            {
                var request = new Request<Patient,List<Patient>>();
                request.MethodName = "SelectPatient";

                var response = request.Execute(null, string.Format("{0} = '{1}'", filterHead, filterStr));
                if (!response.Success)
                {
                    Messaging.DialogErrorMessage(response.ErrorMessage);
                    return;
                }

                dtgridHasta.DataSource = response.Value;
            }
            else
            {
                Messaging.DialogWarningMessage("kriter giriniz.");
            }
        }



        /// <summary>
        /// seçili başlık değiştiğinde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbKriterBaslık_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbKriterBaslık.SelectedIndex >= 0)
            {
                txt_bilgi.Text = "";
                filterHead =  fltrNameAndTypes.Keys.ToList().Find(x => x == cmbKriterBaslık.Text);
                var Type = fltrNameAndTypes.FirstOrDefault(x => x.Key == filterHead).Value;
                if (Type == typeof(Int32))
                {
                    txt_bilgi.KeyPress += CheckNumeric;
                }
                else
                {
                    txt_bilgi.KeyPress -= CheckNumeric;
                }
            }
        }


        /// <summary>
        /// eğer sadece alfabetik veya silme tuşu kontrol.
        /// event fonksiyonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckAlphabetic(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Common.ControlAlphabetic(e);
        }

        /// <summary>
        /// eğer sadece numeric veya silme tuşu control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckNumeric(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Common.ControlNumeric(e);
        }
    }
}
