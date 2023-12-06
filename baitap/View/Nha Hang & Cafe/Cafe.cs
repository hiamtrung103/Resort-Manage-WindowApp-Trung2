using baitap.View.Nha_Hang___Cafe;
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
    public partial class Cafe : Form
    {
        private Form frmConHientai;
        public Cafe()
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

            panel4.Controls.Add(frmCon);
            panel4.Tag = frmCon;
            frmCon.BringToFront();
            frmCon.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MofrmCon(new Cafe2());
        }
    }
}
