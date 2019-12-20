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
        private List<string> filterHeads;
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
            cmbKriterBaslık.DataSource = filterHeads = Common.GetClassProperties<Patient>();
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

                var response = request.Execute(new object[] {null, string.Format("{0} = '{1}'", filterHead, filterStr)});
                if (!response.Success)
                {
                    Common.DialogErrorMessage(response.ErrorMessage);
                    return;
                }

                dtgridHasta.DataSource = response.Value;
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
                filterHead = filterHeads.Find(x => x == cmbKriterBaslık.Text);
            }
        }
    }
}
