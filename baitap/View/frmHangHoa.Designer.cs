namespace baitap.View
{
    partial class frmHangHoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            rjButton4 = new CustomControls.RJControls.RJButton();
            rjButton3 = new CustomControls.RJControls.RJButton();
            rjButton2 = new CustomControls.RJControls.RJButton();
            rjButton1 = new CustomControls.RJControls.RJButton();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            txtDonGia = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            txtSoLuong = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            txtMaHangHoa = new Krypton.Toolkit.KryptonTextBox();
            txtTenHangHoa = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            pictureBox1 = new PictureBox();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 36;
            label1.Text = "Hàng Hóa";
            // 
            // rjButton4
            // 
            rjButton4.BackColor = Color.FromArgb(255, 224, 102);
            rjButton4.BackgroundColor = Color.FromArgb(255, 224, 102);
            rjButton4.BorderColor = Color.PaleVioletRed;
            rjButton4.BorderRadius = 5;
            rjButton4.BorderSize = 0;
            rjButton4.FlatAppearance.BorderSize = 0;
            rjButton4.FlatStyle = FlatStyle.Flat;
            rjButton4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton4.ForeColor = Color.White;
            rjButton4.Location = new Point(304, 196);
            rjButton4.Name = "rjButton4";
            rjButton4.Size = new Size(91, 30);
            rjButton4.TabIndex = 32;
            rjButton4.Text = "Huỷ";
            rjButton4.TextColor = Color.White;
            rjButton4.UseVisualStyleBackColor = false;
            rjButton4.Click += btnHuy_Click;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.FromArgb(13, 135, 242);
            rjButton3.BackgroundColor = Color.FromArgb(13, 135, 242);
            rjButton3.BorderColor = Color.PaleVioletRed;
            rjButton3.BorderRadius = 5;
            rjButton3.BorderSize = 0;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton3.ForeColor = Color.White;
            rjButton3.Location = new Point(207, 196);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(91, 30);
            rjButton3.TabIndex = 33;
            rjButton3.Text = "Sửa";
            rjButton3.TextColor = Color.White;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += btnSua_Click;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.FromArgb(244, 91, 105);
            rjButton2.BackgroundColor = Color.FromArgb(244, 91, 105);
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 5;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton2.ForeColor = Color.White;
            rjButton2.Location = new Point(110, 196);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(91, 30);
            rjButton2.TabIndex = 34;
            rjButton2.Text = "Xoá";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += btnXoa_Click;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(63, 194, 138);
            rjButton1.BackgroundColor = Color.FromArgb(63, 194, 138);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 5;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(13, 196);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(91, 30);
            rjButton1.TabIndex = 35;
            rjButton1.Text = "Thêm";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 232);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(693, 217);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dữ liệu";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(666, 184);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(kryptonLabel3);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(kryptonLabel7);
            groupBox1.Controls.Add(txtMaHangHoa);
            groupBox1.Controls.Add(txtTenHangHoa);
            groupBox1.Controls.Add(kryptonLabel1);
            groupBox1.Controls.Add(kryptonLabel2);
            groupBox1.Location = new Point(12, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(687, 153);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chỉnh sửa";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(96, 76);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(226, 29);
            txtDonGia.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDonGia.StateCommon.Border.Rounding = 5F;
            txtDonGia.StateCommon.Border.Width = 2;
            txtDonGia.TabIndex = 2;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(6, 80);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(53, 20);
            kryptonLabel3.TabIndex = 1;
            kryptonLabel3.Values.Text = "Đơn giá";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(440, 76);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(226, 29);
            txtSoLuong.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSoLuong.StateCommon.Border.Rounding = 5F;
            txtSoLuong.StateCommon.Border.Width = 2;
            txtSoLuong.TabIndex = 2;
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(350, 80);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(60, 20);
            kryptonLabel7.TabIndex = 1;
            kryptonLabel7.Values.Text = "Số lượng";
            // 
            // txtMaHangHoa
            // 
            txtMaHangHoa.Enabled = false;
            txtMaHangHoa.Location = new Point(96, 27);
            txtMaHangHoa.Name = "txtMaHangHoa";
            txtMaHangHoa.Size = new Size(226, 29);
            txtMaHangHoa.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtMaHangHoa.StateCommon.Border.Rounding = 5F;
            txtMaHangHoa.StateCommon.Border.Width = 2;
            txtMaHangHoa.TabIndex = 2;
            // 
            // txtTenHangHoa
            // 
            txtTenHangHoa.Location = new Point(440, 27);
            txtTenHangHoa.Name = "txtTenHangHoa";
            txtTenHangHoa.Size = new Size(226, 29);
            txtTenHangHoa.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTenHangHoa.StateCommon.Border.Rounding = 5F;
            txtTenHangHoa.StateCommon.Border.Width = 2;
            txtTenHangHoa.TabIndex = 2;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(6, 31);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(86, 20);
            kryptonLabel1.TabIndex = 1;
            kryptonLabel1.Values.Text = "Mã Hàng Hóa";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(350, 31);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(89, 20);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Tên Hàng Hóa";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(705, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 153);
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(776, 196);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(60, 20);
            kryptonLabel4.TabIndex = 1;
            kryptonLabel4.Values.Text = "Hình ảnh";
            // 
            // frmHangHoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 644);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(rjButton4);
            Controls.Add(rjButton3);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(groupBox2);
            Controls.Add(kryptonLabel4);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHangHoa";
            Text = "frmHangHoa";
            Load += frmHangHoa_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CustomControls.RJControls.RJButton rjButton4;
        private CustomControls.RJControls.RJButton rjButton3;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Krypton.Toolkit.KryptonTextBox txtDonGia;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox txtSoLuong;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonTextBox txtMaHangHoa;
        private Krypton.Toolkit.KryptonTextBox txtTenHangHoa;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
    }
}