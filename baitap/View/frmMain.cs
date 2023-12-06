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
using baitap.Model;
using baitap.Object;
using baitap.View;
using baitap.View.Nha_Hang___Cafe;
using Bunifu.Framework.UI;
using Krypton.Toolkit;
using Microsoft.VisualBasic.ApplicationServices;

namespace QL_QuanCafe_Trung_Hai.View
{
    public partial class frmMain : KryptonForm
    {
        public Form frmConHientai;
        private ConnectToSQL conn = new ConnectToSQL();

        public frmMain()
        {
            InitializeComponent();
            MofrmCon(new frmTrangChu());
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
            ThayDoiMauLabel(sender, anhClick ? Color.White : SystemColors.ControlText, anhClick ? Color.FromArgb(51, 51, 51) : Color.FromArgb(1, 126, 245));
        }

        private bool anhClick = false;

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

        public void MofrmCon(Form frmCon)
        {
            if (frmConHientai != null)
            {
                frmConHientai.FormClosed -= frmCon_Tat;
                frmConHientai.Close();
            }

            frmConHientai = frmCon;
            frmConHientai.FormClosed += frmCon_Tat;

//            ThayDoiMauLabel(sender, anhClick ? Color.White : SystemColors.ControlText, anhClick ? Color.FromArgb(51, 51, 51) : Color.FromArgb(1, 126, 245));

            frmCon.TopLevel = false;
            frmCon.FormBorderStyle = FormBorderStyle.None;
            frmCon.Dock = DockStyle.Fill;

            panelMain.Controls.Add(frmCon);
            panelMain.Tag = frmCon;
            frmCon.BringToFront();
            frmCon.Show();
        }

        public void frmCon_Tat(object sender, FormClosedEventArgs e)
        {
            Form closedForm = sender as Form;
            if (closedForm != null)
            {
                closedForm.Dispose();
            }
        }

        private void TrangChuOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmTrangChu());
        }

        private void ThueResortOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmDatPhong());
        }

        private void NhaHangOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmNhaHang());
        }

        private void NhaHang2Open(object sender, EventArgs e)
        {
            MofrmCon(new frmCafe());
        }

        private void DanhGiaOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmDanhGia());
        }

        private void NhanVienOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmNhanVien());
        }

        private void KhachHangOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmKhachHang());
        }

        private void SettingKhachHangOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmSettingKhachHang());
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadThongTinKhachHang();
        }

        private void LoadThongTinKhachHang()
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
                            label2.Text = khachHangDataTable.Rows[0]["HoTen"].ToString();
                        }
                    }
                }
            }
        }
    }
}
