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
    public partial class frm_HocSinh : Form
    {
        public frm_HocSinh()
        {
            InitializeComponent();
        }
        Db Db = new Db();


        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "insert into HocSinh values (N'"+txt_mshs.Text+ "',N'"+txt_ten.Text+ "',N'"+txt_diachi.Text+ "',N'"+txt_diemso.Text+ "',N'"+txt_xeploai.Text+ "',N'"+txt_hocluc.Text+"')";
            int kq = Db.ThemSuaXoataikhoan(sql);
            if (kq > 0) MessageBox.Show("thêm Thành Công");
            else MessageBox.Show("thêm Không thành công");
            load();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "update HocSinh set TENHC = N'" + txt_ten.Text + "',DiaChi = N'" + txt_diachi.Text + "',DiemSo = N'" + txt_diemso.Text + "',Xeploai = N'" + txt_xeploai.Text + "',Hocluc = N'" + txt_hocluc.Text + "'where MSHC= N'" + txt_mshs.Text + "'";
            int kq = Db.ThemSuaXoataikhoan(sql);
            if (kq > 0) MessageBox.Show("Sửa Thành Công");
            else MessageBox.Show("Sửa Không thành công");
            load();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM HocSinh WHERE MSHC = '"+txt_mshs.Text+"'";
            int kq = Db.ThemSuaXoataikhoan(sql);
            if (kq > 0) MessageBox.Show("Xóa Thành Công");
            else MessageBox.Show("Xóa Không thành công");
            load();
        }

       

        private void frm_HocSinh_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            string sql = "select * from HOCSINH ";
            data_Gridhocsinh.DataSource = Db.Taigiatri(sql);
            
        }

       

        private void data_Gridhocsinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mshs.Text = data_Gridhocsinh.CurrentRow.Cells["MSHC"].Value.ToString();
            txt_ten.Text = data_Gridhocsinh.CurrentRow.Cells["TenHC"].Value.ToString();
            txt_diachi.Text = data_Gridhocsinh.CurrentRow.Cells["Diachi"].Value.ToString();
            txt_diemso.Text = data_Gridhocsinh.CurrentRow.Cells["DiemSo"].Value.ToString();
            txt_xeploai.Text = data_Gridhocsinh.CurrentRow.Cells["Xeploai"].Value.ToString();
            txt_hocluc.Text = data_Gridhocsinh.CurrentRow.Cells["Hocluc"].Value.ToString();
        }
    }
}
