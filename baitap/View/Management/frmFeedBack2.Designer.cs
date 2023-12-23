namespace baitap.View.Management
{
    partial class frmFeedBack2
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            bunifuCards9 = new Bunifu.Framework.UI.BunifuCards();
            label23 = new Label();
            dataGridViewFeedback = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            lbTieuDe = new Label();
            txtHoTen = new CustomControls.RJControls.RJTextBox();
            txtTrangThai = new CustomControls.RJControls.RJTextBox();
            txtPhanHoi = new Krypton.Toolkit.KryptonRichTextBox();
            lbThoiGian = new Label();
            label4 = new Label();
            bunifuCards9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFeedback).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 25);
            label1.TabIndex = 21;
            label1.Text = "Danh Sách FeedBack";
            // 
            // bunifuCards9
            // 
            bunifuCards9.BackColor = Color.White;
            bunifuCards9.BorderRadius = 20;
            bunifuCards9.BottomSahddow = true;
            bunifuCards9.BottomShadow = true;
            bunifuCards9.color = Color.Transparent;
            bunifuCards9.Controls.Add(label23);
            bunifuCards9.Controls.Add(dataGridViewFeedback);
            bunifuCards9.IndicatorColor = Color.Transparent;
            bunifuCards9.LeftSahddow = false;
            bunifuCards9.LeftShadow = false;
            bunifuCards9.Location = new Point(373, 60);
            bunifuCards9.Name = "bunifuCards9";
            bunifuCards9.RightSahddow = true;
            bunifuCards9.RightShadow = true;
            bunifuCards9.ShadowDepth = 20;
            bunifuCards9.Size = new Size(732, 441);
            bunifuCards9.TabIndex = 22;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(3, 12);
            label23.Name = "label23";
            label23.Size = new Size(135, 25);
            label23.TabIndex = 1;
            label23.Text = "FeedBack Log";
            // 
            // dataGridViewFeedback
            // 
            dataGridViewFeedback.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFeedback.BorderStyle = BorderStyle.None;
            dataGridViewFeedback.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewFeedback.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewFeedback.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewFeedback.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewFeedback.Dock = DockStyle.Bottom;
            dataGridViewFeedback.Location = new Point(0, 40);
            dataGridViewFeedback.Name = "dataGridViewFeedback";
            dataGridViewFeedback.ReadOnly = true;
            dataGridViewFeedback.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewFeedback.RowHeadersVisible = false;
            dataGridViewFeedback.RowTemplate.Height = 25;
            dataGridViewFeedback.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFeedback.Size = new Size(732, 401);
            dataGridViewFeedback.TabIndex = 0;
            dataGridViewFeedback.CellContentClick += dataGridViewFeedback_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 21;
            label2.Text = "Khách Hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 21;
            label3.Text = "Trạng Thái";
            // 
            // lbTieuDe
            // 
            lbTieuDe.AutoSize = true;
            lbTieuDe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTieuDe.Location = new Point(71, 211);
            lbTieuDe.Name = "lbTieuDe";
            lbTieuDe.Size = new Size(68, 21);
            lbTieuDe.TabIndex = 21;
            lbTieuDe.Text = "Tiêu Đề";
            // 
            // txtHoTen
            // 
            txtHoTen.BackColor = SystemColors.Window;
            txtHoTen.BorderColor = Color.RoyalBlue;
            txtHoTen.BorderFocusColor = Color.HotPink;
            txtHoTen.BorderRadius = 5;
            txtHoTen.BorderSize = 2;
            txtHoTen.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoTen.ForeColor = Color.FromArgb(64, 64, 64);
            txtHoTen.Location = new Point(13, 85);
            txtHoTen.Margin = new Padding(4);
            txtHoTen.Multiline = false;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Padding = new Padding(10, 7, 10, 7);
            txtHoTen.PasswordChar = false;
            txtHoTen.PlaceholderColor = Color.DarkGray;
            txtHoTen.PlaceholderText = "";
            txtHoTen.Size = new Size(312, 31);
            txtHoTen.TabIndex = 23;
            txtHoTen.Texts = "";
            txtHoTen.UnderlinedStyle = false;
            // 
            // txtTrangThai
            // 
            txtTrangThai.BackColor = SystemColors.Window;
            txtTrangThai.BorderColor = Color.RoyalBlue;
            txtTrangThai.BorderFocusColor = Color.HotPink;
            txtTrangThai.BorderRadius = 5;
            txtTrangThai.BorderSize = 2;
            txtTrangThai.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtTrangThai.ForeColor = Color.FromArgb(64, 64, 64);
            txtTrangThai.Location = new Point(13, 145);
            txtTrangThai.Margin = new Padding(4);
            txtTrangThai.Multiline = false;
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Padding = new Padding(10, 7, 10, 7);
            txtTrangThai.PasswordChar = false;
            txtTrangThai.PlaceholderColor = Color.DarkGray;
            txtTrangThai.PlaceholderText = "";
            txtTrangThai.Size = new Size(312, 31);
            txtTrangThai.TabIndex = 23;
            txtTrangThai.Texts = "";
            txtTrangThai.UnderlinedStyle = false;
            // 
            // txtPhanHoi
            // 
            txtPhanHoi.Location = new Point(13, 235);
            txtPhanHoi.Name = "txtPhanHoi";
            txtPhanHoi.Size = new Size(312, 228);
            txtPhanHoi.StateCommon.Border.Color1 = Color.RoyalBlue;
            txtPhanHoi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPhanHoi.StateCommon.Border.Rounding = 5F;
            txtPhanHoi.StateCommon.Border.Width = 2;
            txtPhanHoi.TabIndex = 25;
            txtPhanHoi.Text = "";
            // 
            // lbThoiGian
            // 
            lbThoiGian.AutoSize = true;
            lbThoiGian.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbThoiGian.Location = new Point(13, 180);
            lbThoiGian.Name = "lbThoiGian";
            lbThoiGian.Size = new Size(75, 21);
            lbThoiGian.TabIndex = 21;
            lbThoiGian.Text = "Thời gian";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 211);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 21;
            label4.Text = "Tiêu đề:";
            // 
            // frmFeedBack2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 667);
            Controls.Add(txtPhanHoi);
            Controls.Add(txtTrangThai);
            Controls.Add(txtHoTen);
            Controls.Add(bunifuCards9);
            Controls.Add(label4);
            Controls.Add(lbThoiGian);
            Controls.Add(lbTieuDe);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFeedBack2";
            Text = "frmFeedBack2";
            Load += frmFeedBack2_Load;
            bunifuCards9.ResumeLayout(false);
            bunifuCards9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFeedback).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards9;
        private DataGridView dataGridViewFeedback;
        private Label label23;
        private Krypton.Toolkit.KryptonTextBox txtHoTenKhachHang;
        private Label label2;
        private Label label3;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Label lbTieuDe;
        private CustomControls.RJControls.RJTextBox txtHoTen;
        private CustomControls.RJControls.RJTextBox txtTrangThai;
        private Krypton.Toolkit.KryptonRichTextBox txtPhanHoi;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Label lbThoiGian;
        private Label label4;
    }
}