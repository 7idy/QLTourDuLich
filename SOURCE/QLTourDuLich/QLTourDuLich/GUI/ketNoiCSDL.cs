using QLTourDuLich.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTourDuLich.GUI
{
    public partial class ketNoiCSDL : Form
    {
        public ketNoiCSDL()
        {
            InitializeComponent();
        }

        // Lưu tên sever, mật khẩu
        public static string severName = "";
        public static string pass = "";

        public void luuBienCB()
        {
            XuLyKetNoi.svName = txtUserName.Text;
            XuLyKetNoi.pass = txtMK.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text =  DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss");
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            luuBienCB();
            Frm_DangNhap dn = new Frm_DangNhap();
            dn.Show();
            this.Hide();
        }
    }
}