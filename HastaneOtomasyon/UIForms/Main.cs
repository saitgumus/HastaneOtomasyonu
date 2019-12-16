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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public static MenuStrip menum;
        public static ToolStripMenuItem menuReferansBilgisi;

        /// <summary>
        /// form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Show();

            menum = MainMenuStrip;
            menuReferansBilgisi = menuReferanslar;
        }
    }
}
