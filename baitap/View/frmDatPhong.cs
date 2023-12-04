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
    public partial class frmDatPhong : Form
    {

        public frmDatPhong()
        {
            InitializeComponent();
        }

        private void ComboBox_DiaDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string diadiem = ComboBox_DiaDiem.SelectedItem.ToString();

            txtDiaDiem.Text = diadiem;
        }
        private void datetimepicker_NgayDen_ValueChanged(object sender, EventArgs e)
        {
            string ngayden = kryptonDateTimePicker1.Value.ToString("dddd, dd MMMM, yyyy");

            txtNgayDen.Text = ngayden;
        }
        private void datetimepicker_NgayDi_ValueChanged(object sender, EventArgs e)
        {
            string ngaydi = kryptonDateTimePicker2.Value.ToString("dddd, dd MMMM, yyyy");

            txtNgayDi.Text = ngaydi;
        }
        private void ComboBox_SoNguoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string songuoi = ComboBox_SoNguoi.SelectedItem.ToString();

            txtSoNguoi.Text = songuoi;
        }

        private void frmDieuKhien_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session.TenTaiKhoan))
            {
                string tenTaiKhoan = Session.TenTaiKhoan;

                string selectKhachHangSql = "SELECT * FROM KhachHang WHERE TenTaiKhoan=@tenTaiKhoan";
                using (SqlConnection conn = new SqlConnection(@"Data Source=Trunq;Initial Catalog=ql_resort;Integrated Security=True"))
                {
                    conn.Open();

                    using (SqlCommand selectKhachHangCmd = new SqlCommand(selectKhachHangSql, conn))
                    {
                        selectKhachHangCmd.Parameters.AddWithValue("@tenTaiKhoan", tenTaiKhoan);

                        using (SqlDataAdapter khachHangDataAdapter = new SqlDataAdapter(selectKhachHangCmd))
                        {
                            DataTable khachHangDataTable = new DataTable();
                            khachHangDataAdapter.Fill(khachHangDataTable);

                            if (khachHangDataTable.Rows.Count > 0)
                            {
                                txtHoTen.Text = khachHangDataTable.Rows[0]["HoTen"].ToString();
                                txtGioiTinh.Text = khachHangDataTable.Rows[0]["GioiTinh"].ToString();
                                txtNamSinh.Text = khachHangDataTable.Rows[0]["NamSinh"].ToString();
                                txtDiaChi.Text = khachHangDataTable.Rows[0]["DiaChi"].ToString();
                                txtDienThoai.Text = khachHangDataTable.Rows[0]["DienThoai"].ToString();
                                txtEmail.Text = khachHangDataTable.Rows[0]["Email"].ToString();
                                txtMaGiamGia.Text = khachHangDataTable.Rows[0]["MaGiamGia"].ToString();
                            }
                        }
                    }
                }
            }
        }
    }
}
