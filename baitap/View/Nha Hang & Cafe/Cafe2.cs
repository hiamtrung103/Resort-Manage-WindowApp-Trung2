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
    public partial class Cafe2 : Form
    {
        private Form frmConHientai;

        public Cafe2()
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

            panel2.Controls.Add(frmCon);
            panel2.Tag = frmCon;
            frmCon.BringToFront();
            frmCon.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MofrmCon(new Cafe());
        }
    }
}
