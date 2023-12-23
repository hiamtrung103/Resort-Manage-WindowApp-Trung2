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

namespace baitap.View.Management
{
    public partial class frmCaiDat : Form
    {
        ConnectToSQL conn = new ConnectToSQL();
        public frmCaiDat()
        {
            InitializeComponent();
        }
        private void frmCaiDat_Load(object sender, EventArgs e)
        {
            HienThiThongTinNhanVien();
        }

        private void HienThiThongTinNhanVien()
        {
            if (!string.IsNullOrEmpty(Session.TenTaiKhoan))
            {
                string tenTaiKhoan = Session.TenTaiKhoan;

                string selectNhanVienSql = "SELECT * FROM NhanVien WHERE TenTaiKhoan=@tenTaiKhoan";
                using (SqlCommand selectNhanVienCmd = new SqlCommand(selectNhanVienSql, conn.KetNoi))
                {
                    conn.MoKetNoi();
                    selectNhanVienCmd.Parameters.AddWithValue("@tenTaiKhoan", tenTaiKhoan);

                    using (SqlDataAdapter nhanVienDataAdapter = new SqlDataAdapter(selectNhanVienCmd))
                    {
                        DataTable nhanVienDataTable = new DataTable();
                        nhanVienDataAdapter.Fill(nhanVienDataTable);

                        if (nhanVienDataTable.Rows.Count > 0)
                        {
                            txtTenTaiKhoan.Text = nhanVienDataTable.Rows[0]["TenTaiKhoan"].ToString();
                            txtHoTen.Text = nhanVienDataTable.Rows[0]["HoTen"].ToString();
                            txtGioiTinh.Text = nhanVienDataTable.Rows[0]["GioiTinh"].ToString();
                            txtNamSinh.Text = nhanVienDataTable.Rows[0]["NamSinh"].ToString();
                            txtDiaChi.Text = nhanVienDataTable.Rows[0]["DiaChi"].ToString();
                            txtDienThoai.Text = nhanVienDataTable.Rows[0]["DienThoai"].ToString();
                            txtEmail.Text = nhanVienDataTable.Rows[0]["Email"].ToString();
                            txtQuyenHan.Text = nhanVienDataTable.Rows[0]["QuyenHan"].ToString();
                        }
                    }
                }
            }
        }
    }
}
