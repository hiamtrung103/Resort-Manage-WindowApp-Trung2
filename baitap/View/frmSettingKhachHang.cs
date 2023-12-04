using baitap.Model;
using baitap.Object;
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
        private frmKhachHang kh = new frmKhachHang();
        private ConnectToSQL conn = new ConnectToSQL();
        public frmSettingKhachHang()
        {
            InitializeComponent();
        }

        private void frmSettingKhachHang_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session.TenTaiKhoan))
            {
                string tenTaiKhoan = Session.TenTaiKhoan;

                string selectKhachHangSql = "SELECT * FROM KhachHang WHERE TenTaiKhoan=@tenTaiKhoan";
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
                            txtTenTaiKhoan.Texts = khachHangDataTable.Rows[0]["TenTaiKhoan"].ToString();
                            txtHoTen.Texts = khachHangDataTable.Rows[0]["HoTen"].ToString();
                            txtGioiTinh.Texts = khachHangDataTable.Rows[0]["GioiTinh"].ToString();
                            txtNamSinh.Texts = khachHangDataTable.Rows[0]["NamSinh"].ToString();
                            txtDiaChi.Texts = khachHangDataTable.Rows[0]["DiaChi"].ToString();
                            txtDienThoai.Texts = khachHangDataTable.Rows[0]["DienThoai"].ToString();
                            txtEmail.Texts = khachHangDataTable.Rows[0]["Email"].ToString();
                            txtPassword.Texts = khachHangDataTable.Rows[0]["Password"].ToString();
                        }
                    }
                }
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            kh.SuaKhachHang();
        }
    }
}
