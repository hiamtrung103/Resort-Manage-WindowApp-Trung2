using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitap.View
{
    public partial class frmTrangChu : Form
    {
        private int currentImageIndex = 0;
        private string[] imagePaths = {
            @"D:\Visual studio\Repo\Resort-Manage-WindowApp-H-T\Resort-Manage-WindowApp-H-T\icons\resort.jpg",
            @"D:\Visual studio\Repo\Resort-Manage-WindowApp-H-T\Resort-Manage-WindowApp-H-T\icons\resort 2.jpg",
            @"D:\Visual studio\Repo\Resort-Manage-WindowApp-H-T\Resort-Manage-WindowApp-H-T\icons\resort 3.jpg",
            @"D:\Visual studio\Repo\Resort-Manage-WindowApp-H-T\Resort-Manage-WindowApp-H-T\icons\resort 4.jpg",
            @"D:\Visual studio\Repo\Resort-Manage-WindowApp-H-T\Resort-Manage-WindowApp-H-T\icons\resort 5.jpg",
            @"D:\Visual studio\Repo\Resort-Manage-WindowApp-H-T\Resort-Manage-WindowApp-H-T\icons\resort 6.jpg",
        };

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
                if (currentImageIndex < imagePaths.Length - 1)
                {
                    currentImageIndex++;
                }
                else
                {
                    currentImageIndex = 0;
                }

                Image backgroundImage = Image.FromFile(imagePaths[currentImageIndex]);
                bunifuCards2.BackgroundImage = backgroundImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải hình ảnh: {ex.Message}", "Hình ảnh lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
