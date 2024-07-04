using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doancanhan
{
    class Db
    {
        string ketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Tài liệu học\Net\Doancanhan\Doancanhan\data.mdf;Integrated Security=True";
        SqlConnection connection;
        
        public Db()
        {
            connection = new SqlConnection(ketnoi);
        }
        public bool dangnhap(string sql)
        {
            
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            int count = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return count == 1;
        }
        public int ThemSuaXoataikhoan(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            int kq = command.ExecuteNonQuery();
            connection.Close();
            return kq;
        }
        public DataTable Taigiatri(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
