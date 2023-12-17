using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitap.View
{
    public partial class frmTrangChu : Form
    {
        private int currentImageIndex = 0;
        private string[] imageNames = { "rs1", "rs2", "rs3", "rs4", "rs5", "rs6", "rs7" };

        public frmTrangChu()
        {
            InitializeComponent();
            SetupImageTimer();
        }

        private void SetupImageTimer()
        {
            System.Windows.Forms.Timer imageTimer = new System.Windows.Forms.Timer();
            imageTimer.Interval = 5000;
            imageTimer.Tick += ImageTimer_Tick;
            imageTimer.Start();
        }

        private void ImageTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                currentImageIndex = (currentImageIndex + 1) % imageNames.Length;

                Image backgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(imageNames[currentImageIndex]);
                bunifuCards2.BackgroundImage = backgroundImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải hình ảnh: {ex.Message}", "Hình ảnh lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
