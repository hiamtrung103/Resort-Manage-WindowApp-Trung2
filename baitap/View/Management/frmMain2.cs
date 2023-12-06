using baitap.Model;
using baitap.Object;
using Krypton.Toolkit;
using QL_QuanCafe_Trung_Hai.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap.View
{
    public partial class frmMain2 : KryptonForm
    {
        private ConnectToSQL conn = new ConnectToSQL();
        private Form frmConHientai;

        public frmMain2()
        {
            InitializeComponent();
        }

        private void DoiMauLabel_MouseEnter(object sender, EventArgs e)
        {
            ThayDoiMauLabel(sender, Color.LightBlue, Color.Gray);
        }

        private void DoiMauLabel2_MouseEnter(object sender, EventArgs e)
        {
            ThayDoiMauLabel(sender, Color.Red);
        }

        private void DoiMauLabel_MouseLeave(object sender, EventArgs e)
        {
            ThayDoiMauLabel(sender, Color.Black, Color.FromArgb(1, 126, 245));
        }

        private void ThayDoiMauLabel(object sender, Color foreColor, Color? backColor = null)
        {
            Label label = sender as Label;
            if (label != null)
            {
                label.ForeColor = foreColor;
                label.BackColor = backColor ?? (foreColor == Color.LightBlue ? Color.Gray : Color.FromArgb(1, 126, 245));
            }
        }

        private void btnToggleSidebar_Click(object sender, EventArgs e)
        {
            int minSize = 50;
            panelSidebar.Width = (panelSidebar.Width == minSize) ? 200 : minSize;
        }

        private void MofrmCon(Form frmCon)
        {
            if (frmConHientai != null)
            {
                frmConHientai.Close();
            }

            frmConHientai = frmCon;

            frmCon.TopLevel = false;
            frmCon.FormBorderStyle = FormBorderStyle.None;
            frmCon.Dock = DockStyle.Fill;

            panelMain.Controls.Add(frmCon);
            panelMain.Tag = frmCon;
            frmCon.BringToFront();
            frmCon.Show();
        }

        private void CheckQuyenHan(string role, Form form)
        {
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
                            string quyenHan = khachHangDataTable.Rows[0]["QuyenHan"].ToString();

                            if (quyenHan.ToLower() == "admin" || quyenHan.ToLower() == role.ToLower())
                            {
                                MofrmCon(form);
                            }
                            else
                            {
                                MessageBox.Show($"Bạn không có quyền truy cập vào. Chỉ có Admin/{role}", "Từ chối truy cập!");
                            }
                        }
                    }
                }
            }
        }
        private void TrangChuOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmTrangChu2());
        }
        private void KhachhangOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmKhachHang());
        }

        private void NhanVienOpen(object sender, EventArgs e)
        {
            CheckQuyenHan("manager", new frmNhanVien());
        }

        private void KeToanOpen(object sender, EventArgs e)
        {
            CheckQuyenHan("accountant", new frmKeToan());
        }

        private void frmMain2_Load(object sender, EventArgs e)
        {
            MofrmCon(new frmTrangChu2());

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
                            label2.Text = khachHangDataTable.Rows[0]["HoTen"].ToString();
                        }
                    }
                }
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất khỏi ứng dụng vừa đăng nhập không?", "Đăng xuất khỏi ứng dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login frm1 = new Login();
                frm1.Show();
            }
        }
    }
}
