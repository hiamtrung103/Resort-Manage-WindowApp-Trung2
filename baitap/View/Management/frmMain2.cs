using baitap.Model;
using baitap.Object;
using Krypton.Toolkit;
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
            Label label = sender as Label;
            if (label != null)
            {
                label.ForeColor = Color.LightBlue;
                label.BackColor = Color.Gray;
            }
        }

        private void DoiMauLabel2_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                label.ForeColor = Color.Red;
            }
        }

        private void DoiMauLabel_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                label.ForeColor = Color.Black;
                label.BackColor = Color.FromArgb(1, 126, 245);
            }
        }

        private void btnToggleSidebar_Click(object sender, EventArgs e)
        {
            int minSize = 50;

            if (panelSidebar.Width == minSize)
            {
                panelSidebar.Width = 200;
            }
            else
            {
                panelSidebar.Width = minSize;
            }
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

        private void TrangChuOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmTrangChu2());
        }
        private void KhachHangOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmKhachHang());
        }

        private void NhanVienOpen(object sender, EventArgs e)
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

                            if (quyenHan.ToLower() == "admin" || quyenHan.ToLower() == "manager")
                            {
                                MofrmCon(new frmNhanVien());
                            }
                            else
                            {
                                MessageBox.Show("Bạn không có quyền truy cập vào. Chỉ có Admin/Manager", "Từ chối truy cập!");
                            }
                        }
                    }
                }
            }
        }

        private void KeToanOpen(object sender, EventArgs e)
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

                            if (quyenHan.ToLower() == "admin" || quyenHan.ToLower() == "Accountant")
                            {
                                MofrmCon(new frmKeToan());
                            }
                            else
                            {
                                MessageBox.Show("Bạn không có quyền truy cập vào. Chỉ có Admin/Accountant", "Từ chối truy cập!");
                            }
                        }
                    }
                }
            }
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
