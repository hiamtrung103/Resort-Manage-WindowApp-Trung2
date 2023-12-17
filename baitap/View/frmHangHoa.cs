using baitap.Control;
using baitap.Object;
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
    public partial class frmHangHoa : Form
    {
        private HangHoaCtr hhCtr = new HangHoaCtr();
        public frmHangHoa()
        {
            InitializeComponent();
        }
        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hhCtr.LayDuLieuHangHoa();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaHangHoa.Text = row.Cells["ID"].Value.ToString();
                txtTenHangHoa.Text = row.Cells["TenHangHoa"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
            }
        }

        public void btnThem()
        {
            if (string.IsNullOrWhiteSpace(txtTenHangHoa.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            HanghoaObj hhObj = new HanghoaObj();
            hhObj.TenHangHoa = txtTenHangHoa.Text;
            hhObj.DonGia = txtDonGia.Text;
            hhObj.SoLuong = txtSoLuong.Text;


            bool result = hhCtr.ThemDuLieuHangHoa(hhObj);

            if (result)
            {
                MessageBox.Show("Thêm dữ liệu thành công.");
                dataGridView1.DataSource = hhCtr.LayDuLieuHangHoa();
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại.");
            }
        }

        public void btnXoa()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá người dùng này?", "Xoá người dùng!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    hhCtr.XoaDuLieuHangHoa(id);
                    MessageBox.Show("Xoá dữ liệu thành công.");
                    ClearTextBox();
                    dataGridView1.DataSource = hhCtr.LayDuLieuHangHoa();
                }
                else
                {
                    MessageBox.Show("Xoá dữ liệu thất bại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xoá.");
            }
        }

        public void btnSua()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                HanghoaObj hhObj = new HanghoaObj();
                hhObj.TenHangHoa = txtTenHangHoa.Text;
                hhObj.DonGia = txtDonGia.Text;
                hhObj.SoLuong = txtSoLuong.Text;
                hhObj.MaHangHoa = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();

                hhCtr.CapNhatDuLieuHangHoa(hhObj);
                dataGridView1.DataSource = hhCtr.LayDuLieuHangHoa();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }

        public void ClearTextBox()
        {
            txtTenHangHoa.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            txtMaHangHoa.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnXoa();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        public void nhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChiNhapSo(e);
        }

        public void ChiNhapSo(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
