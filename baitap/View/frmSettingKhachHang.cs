using Krypton.Toolkit;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap.View
{
    public partial class frmSettingKhachHang : KryptonForm
    {
        private int userId;
        public frmSettingKhachHang(int userId = 1)
        {
            InitializeComponent();

            this.userId = userId;

            HienThiThongTinTaiKhoan();
        }


        private void HienThiThongTinTaiKhoan()
        {
            string sql = "SELECT * FROM KhachHang WHERE ID=@userId";

            using (SqlConnection conn = new SqlConnection(@"Data Source=Trunq;Initial Catalog=ql_resort;Integrated Security=True"))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);

                        using (SqlDataAdapter dta = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            dta.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                DataRow row = dataTable.Rows[0];

                                // Hiển thị thông tin người dùng trong các textbox
                                txtHoTen.Text = row["HoTen"].ToString();
                                txtGioiTinh.Text = row["GioiTinh"].ToString();
                                // Thêm các dòng này cho các textbox khác để hiển thị thông tin khác của người dùng
                            }
                            else
                            {
                                // Xử lý trường hợp không tìm thấy thông tin người dùng
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }
        }
    }
}
