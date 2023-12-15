using baitap.Control;
using baitap.Model;
using baitap.Object;
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
    public partial class frmTrangChu2 : Form
    {
        private ConnectToSQL conn = new ConnectToSQL();
        public frmTrangChu2()
        {
            InitializeComponent();
        }

        private void frmTrangChu2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LayDuLieuKhachHang();
            if (!string.IsNullOrEmpty(Session.TenTaiKhoan))
            {
                string tenTaiKhoan = Session.TenTaiKhoan;

                string selectKhachHangSql = "SELECT * FROM NhanVien WHERE TenTaiKhoan=@tenTaiKhoan";
                using (SqlCommand selectKhachHangCmd = new SqlCommand(selectKhachHangSql, conn.KetNoi))
                {
                    conn.MoKetNoi();
                    selectKhachHangCmd.Parameters.AddWithValue("@tenTaiKhoan", tenTaiKhoan);

                    using (SqlDataAdapter khachHangDataAdapter = new SqlDataAdapter(selectKhachHangCmd))
                    {
                        DataTable khachHangDataTable = new DataTable();
                        khachHangDataAdapter.Fill(khachHangDataTable);

                        if (khachHangDataTable.Rows.Count > 0)
                        {
                            txtTenTaiKhoan.Text = khachHangDataTable.Rows[0]["TenTaiKhoan"].ToString();
                            txtHoTen.Text = khachHangDataTable.Rows[0]["HoTen"].ToString();
                            txtGioiTinh.Text = khachHangDataTable.Rows[0]["GioiTinh"].ToString();
                            txtNamSinh.Text = khachHangDataTable.Rows[0]["NamSinh"].ToString();
                            txtDiaChi.Text = khachHangDataTable.Rows[0]["DiaChi"].ToString();
                            txtDienThoai.Text = khachHangDataTable.Rows[0]["DienThoai"].ToString();
                            txtEmail.Text = khachHangDataTable.Rows[0]["Email"].ToString();
                            txtQuyenHan.Text = khachHangDataTable.Rows[0]["QuyenHan"].ToString();
                        }
                    }
                }
            }
        }

        private void XuLyLoi(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DataTable LayDuLieuKhachHang()
        {
            DataTable dt = new DataTable();

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM ThongTinDangNhap", conn.KetNoi))
            {
                try
                {
                    conn.MoKetNoi();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                }
                catch (Exception ex)
                {
                    XuLyLoi("Lỗi kết nối hoặc đọc dữ liệu", ex);
                }
                finally
                {
                    conn.DongKetNoi();
                }
            }

            return dt;
        }
    }
}
