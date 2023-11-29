using QL_QuanCafe_Trung_Hai.View;
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
    public partial class loadingUI : Form
    {
        private int progressValue = 0;

        public loadingUI()
        {
            InitializeComponent();
            SetupProgressBar();
        }

        private void SetupProgressBar()
        {
            progressBar1.Maximum = 100;

            progressBar1.Minimum = 0;

            timer1.Start();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (progressValue < progressBar1.Maximum)
            {
                progressValue++;
                progressBar1.Value = progressValue;
                label3.Text = $"{progressValue}%";

                if (progressValue == 50)
                {
                    label4.Text = "Mọi ưu tiên trải nghiệm của \nkhách hàng đặt lên mọi hàng đầu!!";
                    pictureBox2.Image = Image.FromFile("D:\\Visual studio\\Repo\\Resort-Manage-WindowApp-H-T\\Resort-Manage-WindowApp-H-T\\icons\\dazzle-cloud-software.gif");
                }
            }
            else
            {
                timer1.Stop();

                await Task.Delay(1000);

                this.Hide();
                frmMain UI = new frmMain();
                UI.Show();
            }
        }
    }
}
