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
    public partial class frm_DangKi : Form
    {
        public frm_DangKi()
        {
            InitializeComponent();
        }
        Db Db = new Db();

        private void btn_dangki_Click(object sender, EventArgs e)
        {
            
            string sql = "insert into NguoiDung Values (N'" + txt_tentk.Text + "',N'" + txt_pass.Text + "')";
            int kq = Db.ThemSuaXoataikhoan(sql);
            if (kq > 0) MessageBox.Show("Thêm tài khoản thành công");
            else MessageBox.Show("Thêm Tài khoản thất bại");
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
