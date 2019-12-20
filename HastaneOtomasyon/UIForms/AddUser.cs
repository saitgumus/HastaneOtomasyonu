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
    public partial class AddUser : Form
    {
        #region properties
        List<User> userList;
        User selectedUser;
        
        #endregion


        public AddUser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// kullanıcı ekle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            UserDefinition userDefinition = new UserDefinition();
            userDefinition.MdiParent = Main.ActiveForm;
            userDefinition.Show();
        }

        /// <summary>
        /// kullanıcıları getir
        /// </summary>
        private void GetUsers()
        {
            var request = new Request<User, List<User>>();
            request.MethodName = "SelectUser";

           var response = request.Execute();
            if (!response.Success)
            {
                Common.DialogErrorMessage(Common.msg_selectHata);
                return;
            }
            userList = response.Value;
            userList.Insert(0, new User { UserName = Common.msg_seciniz });

            cmb_kullanicilar.DataSource = userList;
            cmb_kullanicilar.DisplayMember = "UserName";
        }

        /// <summary>
        /// load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbl_userCode_Load(object sender, EventArgs e)
        {
            userList = new List<User>();
            selectedUser = new User();

            GetUsers();
        }

        /// <summary>
        /// selected changd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_kullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
         if(cmb.SelectedIndex > 0)
            {
                selectedUser = (User)cmb.SelectedItem;
            }
        }

        /// <summary>
        /// enter yakalama
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_kullanicilar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if( selectedUser.Kodu > 0)
                {
                 UserDefinition userDef = new UserDefinition(selectedUser);
                    userDef.MdiParent = Main.ActiveForm;
                 userDef.Show();
                }
            }
        }
    }
}
