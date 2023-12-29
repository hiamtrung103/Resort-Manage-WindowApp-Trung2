using baitap.Model;
using baitap.Object;
using baitap.View.Management;
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

        private void btnToggleSidebar_Click(object sender, EventArgs e)
        {
            int minSize = 50;
            panelSidebar.Width = (panelSidebar.Width == minSize) ? 200 : minSize;

            NutBam(btnTrangChu, "Trang Chủ");
            NutBam(btnKhachHang, "Khách Hàng");
            NutBam(btnNhanVien, "Nhân Viên");
            NutBam(btnKeToan, "Kế Toán");
            NutBam(btnHangHoa, "Hàng Hóa");
            NutBam(btnHoaDon, "Hóa Đơn");
            NutBam(btnFeedBack, "Danh sách FeedBack");
            NutBam(btnCaiDat, "Cài Đặt");
            NutBam(btnDangXuat, "Đăng Xuất");
        }

        private void NutBam(Button button, string originalText)
        {
            button.ImageAlign = (button.ImageAlign == ContentAlignment.MiddleLeft) ? ContentAlignment.MiddleCenter : ContentAlignment.MiddleLeft;
            button.Text = (button.Text == originalText) ? "" : originalText;
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

                            if (quyenHan.ToLower() == "administrator" || quyenHan.ToLower() == role.ToLower())
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
            CheckQuyenHan("Manager", new frmNhanVien());
        }

        private void KeToanOpen(object sender, EventArgs e)
        {
            CheckQuyenHan("Accountant", new frmban());
        }
        private void HangHoaOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmHangHoa());
        }
        private void HoaDonOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmHoaDon());
        }

        private void FeedBackOpen(object sender, EventArgs e)
        {
            CheckQuyenHan("Manager", new frmFeedBack2());
        }
        private void CaiDatOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmCaiDat());
        }

        private void frmMain2_Load(object sender, EventArgs e)
        {
            MofrmCon(new frmTrangChu2());

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
                            label2.Text = nhanVienDataTable.Rows[0]["HoTen"].ToString();
                            object avatarObject = nhanVienDataTable.Rows[0]["Avatar"];

                            if (avatarObject != DBNull.Value && avatarObject != null)
                            {
                                byte[] hinhAnh = (byte[])avatarObject;
                                HienThiAnhDaiDien(hinhAnh);
                            }
                            else
                            {
                                pictureBox3.Image = null;
                            }
                        }
                    }
                }
            }
        }

        public void HienThiAnhDaiDien(byte[] hinhAnh)
        {
            if (hinhAnh != null && hinhAnh.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(hinhAnh))
                {
                    pictureBox3.Image = Image.FromStream(ms);
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else
            {
                pictureBox3.Image = null;
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
