using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneOtomasyon.Models;
using System.IO;

namespace HastaneOtomasyon
{
    public class Common
    {
        #region LoginUser
        private static User loginUser;
        public static User LoginUser
        {
            get
            {
                return loginUser;
            }
            set
            {
                loginUser = value;
                WriteLog("Giriş", "giriş yapıldı.");
            }
        }
        #endregion

        #region methods

        #region message metods
        /// <summary>
        /// uyarı mesajı
        /// </summary>
        /// <param name="message"></param>
        public static void DialogWarningMessage(string message)
        {
            MessageBox.Show(message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// hata mesajı verir
        /// </summary>
        /// <param name="message"></param>
        public static void DialogErrorMessage(string message)
        {
            MessageBox.Show(message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// bilgi mesajı verir
        /// </summary>
        /// <param name="message"></param>
        public static void DialogInfoMessage(string message)
        {
            MessageBox.Show(message, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// deger döndüren mesaj verir
        /// </summary>
        /// <param name="message"></param>
        public static bool DialogExamMessage(string message)
        {
            var result = MessageBox.Show(message, "Bilgilendirme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                return true;
            }

            return false;
        }


        #endregion

        #region Log
        /// <summary>
        /// Loglama Metodu
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        public static void WriteLog(string subject,string message)
        {
            StreamWriter streamWriter = new StreamWriter(LogPath, true);

            streamWriter.WriteLine(
                String.Format("Time:{0} \t Subject:{1} \n\t message: {2}",
                                DateTime.Now,
                                subject,
                                message)
                );
        }


        #endregion

        #endregion

        #region types
        public const string ConnectionString = @"Server=.\; Database=SOHATS; Integrated Security = SSPI";
        public const string LogPath = @"C:\LOG\SOHATS_LOG.txt";

        #endregion
    }
}
