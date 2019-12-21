
using HastaneOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon.UIForms
{
    public partial class Login : Form
    {
        #region properties
        List<User> userList;

        string username;
        string password;
        #endregion
        public Login()
        {
            InitializeComponent();

        }

        /// <summary>
        /// uygulamay kapatır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Load(object sender, EventArgs e)
        {
            GetUsers();
        }

        /// <summary>
        /// kullanıcıları al
        /// </summary>
        private void GetUsers()
        {
            userList = new List<User>();

            Request<User, List<User>> request = new Request<User, List<User>>();
            request.MethodName = "SelectUser";

            GenericResponse<List<User>> responseUser = request.Execute();

            if (!responseUser.Success)
            {
                Common.WriteLog("veri tabanı", "kullanıcı listesi alınamadı.");
                return;
            }

            userList = responseUser.Value;
        }

        /// <summary>
        /// giriş event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_giriş_Click(object sender, EventArgs e)
        {
            if(!Common.SpaceControlAll(ref pnl_login))
            {
                Messaging.DialogWarningMessage(Messaging.msg_zorunluAlanWarning);
                return;
            }

            if (!UserControl())
            {
                Messaging.DialogWarningMessage(Messaging.msg_kullaniciBulunamadı);
                return;
            }

            if (!AdminControl())
            {
                Messaging.DialogWarningMessage(Messaging.msg_yetkiliDegil);
                return;
            }

            SetLoginUser();
            this.Close();
            Main.menum.Visible = true;
            Main.menuReferansBilgisi.Visible = true;
        }

        #region Metods

        /// <summary>
        /// kullanıcı doğrulama
        /// </summary>
        /// <returns></returns>
        private bool UserControl()
        {
            username = txt_username.Text;
            password = txt_password.Text;

            bool correct = (userList.Where(x => x.UserName == username && x.Sifre == password).Count() > 0) ? true : false;

            return correct;
        }

        /// <summary>
        /// yetki kontrolü
        /// </summary>
        /// <returns></returns>
        private bool AdminControl()
        {
            if( userList.Find(x=> x.UserName == username).Yetki != Common.AdminText)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// login user bilgisi tutulur
        /// </summary>
        private void SetLoginUser()
        {
            Common.LoginUser = userList.Find(x => x.UserName == username && x.Sifre == password);
        }

        #endregion

        /// <summary>
        /// alanları temizler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clean_Click(object sender, EventArgs e)
        {
            Common.CleanTextControls(ref pnl_login);
        }
    }
}
