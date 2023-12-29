using baitap.Control;
using baitap.Model;
using baitap.Object;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace baitap.View
{
    public partial class frmban : Form
    {
        private readonly ConnectToSQL conn = new ConnectToSQL();
        private readonly BanCtr banCtr = new BanCtr();

        public frmban()
        {
            InitializeComponent();
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            TaiDuLieuVaCapNhatMauPanel();

            if (dataGridView1.Rows.Count > 0)
            {
                string maBan = dataGridView1.Rows[0].Cells["MaBan"].Value.ToString();
                CapNhatMauPanel(maBan);
            }
        }

        private void CapNhatMauPanel(string maBan)
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
                            DatMauChoPanel(panel, trangThaiObj.ToString());
                        }
                    }
                }
            }
        }

        private void TaiDuLieuVaCapNhatMauPanel()
        {
            dataGridView1.DataSource = banCtr.LayDuLieuBan();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                string maBan = dataGridView1.SelectedRows[0].Cells["MaBan"].Value.ToString();
                CapNhatMauPanel(maBan);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                DienThongTinVaoText(row);

                string maBan = txtMaBan.Text;
                CapNhatMauPanel(maBan);
            }
        }

        private void DienThongTinVaoText(DataGridViewRow row)
        {
            txtMaBan.Text = row.Cells["MaBan"].Value.ToString();
            txtTenBan.Text = row.Cells["TenBan"].Value.ToString();
            txtLau.Text = row.Cells["Lau"].Value.ToString();
            txtGia.Text = row.Cells["Gia"].Value.ToString();
            txtTrangThai.Text = row.Cells["TrangThai"].Value.ToString();
        }

        private void DatMauChoPanel(Panel panel, string trangThai)
        {
            switch (trangThai)
            {
                case "Đang có khách":
                    panel.BackColor = System.Drawing.Color.Red;
                    break;
                case "Đang dọn dẹp":
                    panel.BackColor = System.Drawing.Color.LightBlue;
                    break;
                default:
                    panel.BackColor = System.Drawing.Color.LightGreen;
                    break;
            }
        }

        private BanObj LayBanObjTuForm()
        {
            return new BanObj
            {
                MaBan = txtMaBan.Text,
                TenBan = txtTenBan.Text,
                Lau = txtLau.Text,
                Gia = Convert.ToInt32(txtGia.Text),
                TrangThai = txtTrangThai.Text
            };
        }

        private void ThemBanMoi()
        {
            if (string.IsNullOrWhiteSpace(txtMaBan.Text) ||
                string.IsNullOrWhiteSpace(txtTenBan.Text) ||
                string.IsNullOrWhiteSpace(txtLau.Text) ||
                string.IsNullOrWhiteSpace(txtGia.Text) ||
                string.IsNullOrWhiteSpace(txtTrangThai.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            BanObj banObj = LayBanObjTuForm();

            if (banCtr.ThemDuLieuBan(banObj))
            {
                dataGridView1.DataSource = banCtr.LayDuLieuBan();
            }
        }

        private void SuaThongTinBan()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                BanObj banObj = LayBanObjTuForm();
                banCtr.CapNhatDuLieuBan(banObj);
                dataGridView1.DataSource = banCtr.LayDuLieuBan();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }

        private void XoaBan()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string maBan = dataGridView1.SelectedRows[0].Cells["MaBan"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá hàng hóa này?", "Xoá hàng hóa!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    banCtr.XoaDuLieuBan(maBan);
                    MessageBox.Show("Xoá dữ liệu thành công.");
                    ClearTextBox();
                    dataGridView1.DataSource = banCtr.LayDuLieuBan();
                }
                else
                {
                    MessageBox.Show("Xoá dữ liệu thất bại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }

        private void ClearTextBox()
        {
            txtMaBan.Text = "";
            txtTenBan.Text = "";
            txtTrangThai.Text = "";
            txtLau.Text = "";
            txtGia.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemBanMoi();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SuaThongTinBan();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            XoaBan();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }
    }
}
