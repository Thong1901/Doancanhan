using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doancanhan
{
    public partial class frm_Dangnhap : Form
    {
        public frm_Dangnhap()
        {
            InitializeComponent();
        }
        Db Db = new Db();

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string sql = "SELECT COUNT(1) FROM NguoiDung WHERE tentk = N'"+txt_tentk.Text+"' AND mk = '"+txt_pass.Text+"'";
            if (Db.dangnhap(sql) == true)
            {
                frm_HocSinh HocSinh = new frm_HocSinh();
                HocSinh.Show();
            }
            else MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");


        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_dangki_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DangKi"] == null)
            {
                frm_DangKi dangki = new frm_DangKi();

                dangki.MdiParent = this;
                dangki.Show();
            }
            else Application.OpenForms["frm_DangKi"].Activate();
        }
    }
}
