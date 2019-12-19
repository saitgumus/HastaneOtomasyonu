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
            menum = HomeMenuStrip;
            menuReferansBilgisi = menuReferanslar;

            Login login = new Login();
            login.MdiParent = this;
            login.Show();

        }

        /// <summary>
        /// poliklinik tanıtma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuPoliklinik_Click(object sender, EventArgs e)
        {
            AddPolyclinic add = new AddPolyclinic();
            add.MdiParent = this;
            add.Show();
        }

        /// <summary>
        /// Log out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        /// kullanıcı tanıtma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuKullanici_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.MdiParent = this;
            addUser.Show();

        }

        /// <summary>
        /// hasta işlemlerini açar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuHastaIslemleri_Click(object sender, EventArgs e)
        {
            PatientOperations patientOperations = new PatientOperations();
            patientOperations.MdiParent = this;
            patientOperations.Show();
        }
    }
}
