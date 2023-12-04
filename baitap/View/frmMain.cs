using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using baitap.View;
using Bunifu.Framework.UI;
using Krypton.Toolkit;
using Microsoft.VisualBasic.ApplicationServices;

namespace QL_QuanCafe_Trung_Hai.View
{
    public partial class frmMain : KryptonForm
    {
        private Form frmConHientai;
        public frmMain()
        {
            InitializeComponent();
            MofrmCon(new frmTrangChu());
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

        private void DoiMauLabel3_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                label.ForeColor = Color.LightBlue;
            }
        }

        private void DoiMauLabel_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                label.ForeColor = anhClick ? Color.White : SystemColors.ControlText;
                label.BackColor = anhClick ? Color.FromArgb(51, 51, 51) : Color.FromArgb(1, 126, 245);
            }
        }

        private void DoiMauLabel2_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                label.ForeColor = Color.Black;
            }
        }

        private void Doimaulabel(params Label[] labels)
        {
            foreach (Label label in labels)
            {
                if (label != null)
                {
                    label.ForeColor = Color.White;
                }
            }
        }

        private void Doimaulabel2(params Label[] labels)
        {
            foreach (Label label in labels)
            {
                if (label != null)
                {
                    label.ForeColor = Color.Black;
                }
            }
        }

        private bool anhClick = false;

        private void CheDoToi_Click(object sender, EventArgs e)
        {
            if (!anhClick)
            {
                panel1.BackColor = Color.FromArgb(51, 51, 51);
                panelSidebar.BackColor = Color.FromArgb(51, 51, 51);
                Doimaulabel(label1, label2, lbTrangChu, lbDatPhong, lbThucDon, lbNhanVien, lbGiaoDich, lbDanhGia, lbCaiDat, lbThoat);
                pictureBox5.Image = Image.FromFile("D:\\Visual studio\\Repo\\Resort-Manage-WindowApp-H-T\\Resort-Manage-WindowApp-H-T\\icons\\Day.gif");

            }
            else
            {
                panel1.BackColor = SystemColors.Control;
                panelSidebar.BackColor = Color.FromArgb(1, 126, 245);
                Doimaulabel2(label1, label2, lbTrangChu, lbDatPhong, lbThucDon, lbNhanVien, lbGiaoDich, lbDanhGia, lbCaiDat, lbThoat);
                pictureBox5.Image = Image.FromFile("D:\\Visual studio\\Repo\\Resort-Manage-WindowApp-H-T\\Resort-Manage-WindowApp-H-T\\icons\\dark.gif");

            }

            anhClick = !anhClick;
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

        private void btnToggleSidebar2_Click(object sender, EventArgs e)
        {
            int minSize = 10;

            if (panel2.Height == minSize)
            {
                panel2.Height = 100;
            }
            else
            {
                panel2.Height = minSize;
            }
        }

        private void MofrmCon(Form frmCon)
        {
            if (frmConHientai != null)
            {
                frmConHientai.FormClosed -= frmCon_Tat;
                frmConHientai.Close();
            }

            frmConHientai = frmCon;
            frmConHientai.FormClosed += frmCon_Tat;

            frmCon.TopLevel = false;
            frmCon.FormBorderStyle = FormBorderStyle.None;
            frmCon.Dock = DockStyle.Fill;

            panelMain.Controls.Add(frmCon);
            panelMain.Tag = frmCon;
            frmCon.BringToFront();
            frmCon.Show();
        }

        private void frmCon_Tat(object sender, FormClosedEventArgs e)
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

    }
}
