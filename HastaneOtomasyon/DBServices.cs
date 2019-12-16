using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using HastaneOtomasyon.Models;

namespace HastaneOtomasyon
{
    public class DBServices
    {
        SqlConnection conSOHATS;

        public DBServices()
        {
        }

        #region baglanti islemleri

        /// <summary>
        /// veri tabanına bağlanır
        /// </summary>
        private void ConnectDB()
        {
            conSOHATS = new SqlConnection(Common.ConnectionString);

            try
            {
                conSOHATS.Open();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message.ToString());
            }

        }

        /// <summary>
        /// veri tabanı bağlantısınık sonlandırır
        /// </summary>
        public void endConnectDB()
        {
            try
            {
                conSOHATS.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message.ToString());
            }
        }
        #endregion


        #region kullanıcı işlemleri

        #region kullanıcı kaydet
        public GenericResponse InsertUser(User user)
        {
            var returnObject = new GenericResponse(user);



            return returnObject;
        }

        #endregion


        #endregion
    }
}
