using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitap.View
{
    public partial class frmTrangChu : Form
    {
        private int hinhanhHienTai = 0;
        private string[] HinhAnh = { "rs1", "rs2", "rs3", "rs4", "rs5", "rs6", "rs7" };

        public frmTrangChu()
        {
            InitializeComponent();
            HinhAnhTimer();
        }

        private void HinhAnhTimer()
        {
            System.Windows.Forms.Timer imageTimer = new System.Windows.Forms.Timer();
            imageTimer.Interval = 10000;
            imageTimer.Tick += ImageTimer_Tick;
            imageTimer.Start();
        }

        private void ImageTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                hinhanhHienTai = (hinhanhHienTai + 1) % HinhAnh.Length;

                Image backgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(HinhAnh[hinhanhHienTai]);
                bunifuCards2.BackgroundImage = backgroundImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải hình ảnh: {ex.Message}", "Hình ảnh lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
