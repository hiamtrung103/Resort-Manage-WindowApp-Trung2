using baitap.Control;
using baitap.Model;
using baitap.Object;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace baitap.View
{
    public partial class frmban : Form
    {
        private ConnectToSQL conn = new ConnectToSQL();
        BanCtr pCtr = new BanCtr();

        public frmban()
        {
            InitializeComponent();
        }
        private void frmPhong_Load(object sender, EventArgs e)
        {
            LoadDataAndPanelColors();

            if (dataGridView1.Rows.Count > 0)
            {
                DataGridViewRow firstRow = dataGridView1.Rows[0];
                string maPhong = firstRow.Cells["MaBan"].Value.ToString();
                UpdatePanelColors(maPhong);
            }
        }

        private void UpdatePanelColors(string maBan)
        {
            for (int i = 1; i <= 16; i++)
            {
                Panel panel = this.Controls.Find("panel" + i, true).FirstOrDefault() as Panel;

                if (panel != null)
                {
                    string query = "SELECT TrangThai FROM Ban WHERE MaBan = @MaBan";
                    using (SqlCommand cmd = new SqlCommand(query, conn.KetNoi))
                    {
                        conn.MoKetNoi();
                        cmd.Parameters.AddWithValue("@MaBan", "P" + i);
                        object trangThaiObj = cmd.ExecuteScalar();

                        if (trangThaiObj != null && trangThaiObj != DBNull.Value)
                        {
                            string trangThai = trangThaiObj.ToString();
                            if (trangThai == "Đang có khách")
                            {
                                panel.BackColor = Color.Red;
                            }
                            else if(trangThai == "Đang dọn dẹp")
                            {
                                panel.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                panel.BackColor = Color.LightGreen;
                            }
                        }
                    }
                }
            }
        }

        private void LoadDataAndPanelColors()
        {
            dataGridView1.DataSource = pCtr.LayDuLieuBan();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                string maBan = dataGridView1.SelectedRows[0].Cells["MaBan"].Value.ToString();
                UpdatePanelColors(maBan);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaBan.Text = row.Cells["MaBan"].Value.ToString();
                txtTenBan.Text = row.Cells["TenBan"].Value.ToString();
                txtLau.Text = row.Cells["Lau"].Value.ToString();
                txtGia.Text = row.Cells["Gia"].Value.ToString();
                txtTrangThai.Text = row.Cells["TrangThai"].Value.ToString();

                string maBan = txtMaBan.Text;
                UpdatePanelColors(maBan);
            }
        }


        private void btnThemBan()
        {
            string maPhong = txtMaBan.Text;
            string tenPhong = txtTenBan.Text;
            string lau = txtLau.Text;
            decimal gia = Convert.ToDecimal(txtGia.Text);
            string trangThai = txtTrangThai.Text;

            BanObj banObj = new BanObj(maPhong, tenPhong, lau, gia, trangThai);

            if (pCtr.ThemDuLieuBan(banObj))
            {
                dataGridView1.DataSource = pCtr.LayDuLieuBan();
            }
        }

        public void btnSuaBan()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                BanObj banObj = new BanObj();
                banObj.MaBan = txtMaBan.Text;
                banObj.TenBan = txtTenBan.Text;
                banObj.Lau = txtLau.Text;
                banObj.TrangThai = txtTrangThai.Text;
                if (decimal.TryParse(txtGia.Text, out decimal gia))
                {
                    banObj.Gia = gia;
                }

                pCtr.CapNhatDuLieuBan(banObj);
                dataGridView1.DataSource = pCtr.LayDuLieuBan();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }

        private void btnXoaBan() 
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string maPhong = dataGridView1.SelectedRows[0].Cells["MaBan"].Value.ToString();

                if (pCtr.XoaDuLieuBan(maPhong))
                {
                    dataGridView1.DataSource = pCtr.LayDuLieuBan();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThemBan();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            btnSuaBan();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            btnXoaBan();
        }
    }
}
