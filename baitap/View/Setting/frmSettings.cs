using baitap.View.Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap.View
{
    public partial class frmSettings : Form
    {
        public Form frmConHientai;

        public frmSettings()
        {
            InitializeComponent();
        }

        public void MofrmCon(Form frmCon)
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

        private void frmSettings_Load(object sender, EventArgs e)
        {
            MofrmCon(new frmSettingKhachHang());
        }

        private void SettingKhachHangOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmSettingKhachHang());
        }

        private void SettingMatKhauOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmSettingMatKhau());
        }

        private void SettingThongBaoOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmSettingThongBao());
        }

        private void SettingHoTroOpen(object sender, EventArgs e)
        {
            MofrmCon(new frmSettingHoTro());
        }
    }
}
