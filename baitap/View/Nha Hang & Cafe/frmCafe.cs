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

namespace baitap.View.Nha_Hang___Cafe
{
    public partial class frmCafe : Form
    {
        private Form frmConHientai;
        public frmCafe()
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

        private void frmCafe_Load(object sender, EventArgs e)
        {
            MofrmCon(new Cafe());
        }

        private void CafeOpen(object sender, EventArgs e)
        {
            MofrmCon(new Cafe());
        }
        private void Cafe3Open(object sender, EventArgs e)
        {
            MofrmCon(new Cafe3());
        }
    }
}
