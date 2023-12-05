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
    public partial class frmNhaHang2 : Form
    {
        private Form frmConHientai;
        public frmNhaHang2()
        {
            InitializeComponent();
        }

        private void frmNhaHang2_Load(object sender, EventArgs e)
        {
            MofrmCon(new NhaHang());
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

        private void label3_Click(object sender, EventArgs e)
        {
            MofrmCon(new NhaHang());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MofrmCon(new NhaHang2());
        }
    }
}
