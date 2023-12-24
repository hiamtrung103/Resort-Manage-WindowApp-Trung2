namespace baitap.View
{
    partial class frmSettingKhachHang
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
            components = new System.ComponentModel.Container();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            rjButton3 = new CustomControls.RJControls.RJButton();
            btn_Luu = new CustomControls.RJControls.RJButton();
            rjButton4 = new CustomControls.RJControls.RJButton();
            txtTenTaiKhoan = new CustomControls.RJControls.RJTextBox();
            txtNamSinh = new CustomControls.RJControls.RJTextBox();
            txtDiaChi = new CustomControls.RJControls.RJTextBox();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            txtGioiTinh = new CustomControls.RJControls.RJComboBox();
            txtHoTen = new CustomControls.RJControls.RJTextBox();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            rjButton1 = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.BaseFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonCustomPaletteBase1.BaseFontSize = 9F;
            kryptonCustomPaletteBase1.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            kryptonCustomPaletteBase1.ButtonSpecs.FormClose.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            kryptonCustomPaletteBase1.ButtonSpecs.FormClose.Image = Properties.Resources.red_16;
            kryptonCustomPaletteBase1.ButtonSpecs.FormMax.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            kryptonCustomPaletteBase1.ButtonSpecs.FormMax.Image = Properties.Resources.yellow_16;
            kryptonCustomPaletteBase1.ButtonSpecs.FormMin.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            kryptonCustomPaletteBase1.ButtonSpecs.FormMin.Image = Properties.Resources.green16;
            kryptonCustomPaletteBase1.ButtonSpecs.FormRestore.Image = Properties.Resources.yellow_16;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Rounding = 16F;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Width = 1;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(245, 32);
            label1.TabIndex = 28;
            label1.Text = "Cài Đặt Người Dùng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 29;
            label3.Text = "Họ tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(11, 128);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 29;
            label4.Text = "Tài khoản";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(11, 201);
            label7.Name = "label7";
            label7.Size = new Size(70, 21);
            label7.TabIndex = 29;
            label7.Text = "Giới tính";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(11, 246);
            label8.Name = "label8";
            label8.Size = new Size(77, 21);
            label8.TabIndex = 29;
            label8.Text = "Năm sinh";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(11, 296);
            label9.Name = "label9";
            label9.Size = new Size(57, 21);
            label9.TabIndex = 29;
            label9.Text = "Địa chỉ";
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
            rjButton3.Location = new Point(450, 304);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(91, 30);
            rjButton3.TabIndex = 32;
            rjButton3.Text = "Tải ảnh";
            rjButton3.TextColor = Color.White;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += btnChonAnhDaiDien_Click;
            // 
            // btn_Luu
            // 
            btn_Luu.BackColor = Color.FromArgb(63, 194, 138);
            btn_Luu.BackgroundColor = Color.FromArgb(63, 194, 138);
            btn_Luu.BorderColor = Color.PaleVioletRed;
            btn_Luu.BorderRadius = 5;
            btn_Luu.BorderSize = 0;
            btn_Luu.FlatAppearance.BorderSize = 0;
            btn_Luu.FlatStyle = FlatStyle.Flat;
            btn_Luu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Luu.ForeColor = Color.White;
            btn_Luu.Location = new Point(12, 338);
            btn_Luu.Name = "btn_Luu";
            btn_Luu.Size = new Size(91, 30);
            btn_Luu.TabIndex = 33;
            btn_Luu.Text = "Lưu";
            btn_Luu.TextColor = Color.White;
            btn_Luu.UseVisualStyleBackColor = false;
            btn_Luu.Click += btn_Luu_Click;
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
            rjButton4.Location = new Point(109, 338);
            rjButton4.Name = "rjButton4";
            rjButton4.Size = new Size(91, 30);
            rjButton4.TabIndex = 34;
            rjButton4.Text = "Huỷ";
            rjButton4.TextColor = Color.White;
            rjButton4.UseVisualStyleBackColor = false;
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.BackColor = SystemColors.Window;
            txtTenTaiKhoan.BorderColor = Color.CornflowerBlue;
            txtTenTaiKhoan.BorderFocusColor = Color.HotPink;
            txtTenTaiKhoan.BorderRadius = 5;
            txtTenTaiKhoan.BorderSize = 2;
            txtTenTaiKhoan.Enabled = false;
            txtTenTaiKhoan.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenTaiKhoan.ForeColor = Color.FromArgb(64, 64, 64);
            txtTenTaiKhoan.Location = new Point(93, 123);
            txtTenTaiKhoan.Margin = new Padding(4);
            txtTenTaiKhoan.Multiline = false;
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Padding = new Padding(10, 7, 10, 7);
            txtTenTaiKhoan.PasswordChar = false;
            txtTenTaiKhoan.PlaceholderColor = Color.DarkGray;
            txtTenTaiKhoan.PlaceholderText = "";
            txtTenTaiKhoan.Size = new Size(313, 31);
            txtTenTaiKhoan.TabIndex = 35;
            txtTenTaiKhoan.Texts = "";
            txtTenTaiKhoan.UnderlinedStyle = false;
            // 
            // txtNamSinh
            // 
            txtNamSinh.BackColor = SystemColors.Window;
            txtNamSinh.BorderColor = Color.CornflowerBlue;
            txtNamSinh.BorderFocusColor = Color.HotPink;
            txtNamSinh.BorderRadius = 5;
            txtNamSinh.BorderSize = 2;
            txtNamSinh.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtNamSinh.ForeColor = Color.FromArgb(64, 64, 64);
            txtNamSinh.Location = new Point(93, 241);
            txtNamSinh.Margin = new Padding(4);
            txtNamSinh.Multiline = false;
            txtNamSinh.Name = "txtNamSinh";
            txtNamSinh.Padding = new Padding(10, 7, 10, 7);
            txtNamSinh.PasswordChar = false;
            txtNamSinh.PlaceholderColor = Color.DarkGray;
            txtNamSinh.PlaceholderText = "";
            txtNamSinh.Size = new Size(313, 31);
            txtNamSinh.TabIndex = 35;
            txtNamSinh.Texts = "";
            txtNamSinh.UnderlinedStyle = false;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BackColor = SystemColors.Window;
            txtDiaChi.BorderColor = Color.CornflowerBlue;
            txtDiaChi.BorderFocusColor = Color.HotPink;
            txtDiaChi.BorderRadius = 5;
            txtDiaChi.BorderSize = 2;
            txtDiaChi.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.ForeColor = Color.FromArgb(64, 64, 64);
            txtDiaChi.Location = new Point(93, 291);
            txtDiaChi.Margin = new Padding(4);
            txtDiaChi.Multiline = false;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Padding = new Padding(10, 7, 10, 7);
            txtDiaChi.PasswordChar = false;
            txtDiaChi.PlaceholderColor = Color.DarkGray;
            txtDiaChi.PlaceholderText = "";
            txtDiaChi.Size = new Size(313, 31);
            txtDiaChi.TabIndex = 35;
            txtDiaChi.Texts = "";
            txtDiaChi.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pablita_loading;
            pictureBox1.Location = new Point(450, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(502, 280);
            label11.Name = "label11";
            label11.Size = new Size(97, 21);
            label11.TabIndex = 29;
            label11.Text = "Ảnh đại diện";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(94, 158);
            label12.Name = "label12";
            label12.Size = new Size(298, 30);
            label12.TabIndex = 29;
            label12.Text = "*Bạn cần phải đăng xuất và đăng nhập lại để xem mọi \r\nthay đổi có hiệu lực\r\n";
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.BackColor = Color.WhiteSmoke;
            txtGioiTinh.BorderColor = Color.CornflowerBlue;
            txtGioiTinh.BorderSize = 2;
            txtGioiTinh.DropDownStyle = ComboBoxStyle.DropDown;
            txtGioiTinh.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtGioiTinh.ForeColor = Color.DimGray;
            txtGioiTinh.IconColor = Color.RoyalBlue;
            txtGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            txtGioiTinh.ListBackColor = Color.FromArgb(230, 228, 245);
            txtGioiTinh.ListTextColor = Color.DimGray;
            txtGioiTinh.Location = new Point(93, 196);
            txtGioiTinh.MinimumSize = new Size(200, 30);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Padding = new Padding(2);
            txtGioiTinh.Size = new Size(313, 30);
            txtGioiTinh.TabIndex = 38;
            txtGioiTinh.Texts = "";
            // 
            // txtHoTen
            // 
            txtHoTen.BackColor = SystemColors.Window;
            txtHoTen.BorderColor = Color.CornflowerBlue;
            txtHoTen.BorderFocusColor = Color.HotPink;
            txtHoTen.BorderRadius = 5;
            txtHoTen.BorderSize = 2;
            txtHoTen.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoTen.ForeColor = Color.FromArgb(64, 64, 64);
            txtHoTen.Location = new Point(93, 77);
            txtHoTen.Margin = new Padding(4);
            txtHoTen.Multiline = false;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Padding = new Padding(10, 7, 10, 7);
            txtHoTen.PasswordChar = false;
            txtHoTen.PlaceholderColor = Color.DarkGray;
            txtHoTen.PlaceholderText = "";
            txtHoTen.Size = new Size(313, 31);
            txtHoTen.TabIndex = 35;
            txtHoTen.Texts = "";
            txtHoTen.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(450, 337);
            label2.Name = "label2";
            label2.Size = new Size(167, 34);
            label2.TabIndex = 29;
            label2.Text = "*Bạn có thể tải ảnh đại diện \r\ncủa bản thân lên";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
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
            rjButton1.Location = new Point(559, 304);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(91, 30);
            rjButton1.TabIndex = 33;
            rjButton1.Text = "Lưu";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // frmSettingKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 690);
            Controls.Add(txtGioiTinh);
            Controls.Add(pictureBox1);
            Controls.Add(txtTenTaiKhoan);
            Controls.Add(txtHoTen);
            Controls.Add(txtDiaChi);
            Controls.Add(txtNamSinh);
            Controls.Add(rjButton4);
            Controls.Add(rjButton3);
            Controls.Add(rjButton1);
            Controls.Add(btn_Luu);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label11);
            Controls.Add(label3);
            Controls.Add(label12);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSettingKhachHang";
            Palette = kryptonCustomPaletteBase1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            Text = "frmSettingKhachHang";
            Load += frmSettingKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Label label1;
        private Label label3;
        private Label label4;
#pragma warning disable CS0169 // The field 'frmSettingKhachHang.txtTaiKhoan' is never used
        private CustomControls.RJControls.RJTextBox txtTaiKhoan;
        private Label label7;
        private Label label8;
        private Label label9;
        private CustomControls.RJControls.RJButton rjButton3;
        private CustomControls.RJControls.RJButton btn_Luu;
        private CustomControls.RJControls.RJButton rjButton4;
#pragma warning disable CS0169 // The field 'frmSettingKhachHang.kryptonTextBox1' is never used
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
#pragma warning restore CS0169 // The field 'frmSettingKhachHang.kryptonTextBox1' is never used
#pragma warning disable CS0169 // The field 'frmSettingKhachHang.kryptonTextBox2' is never used
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
#pragma warning restore CS0169 // The field 'frmSettingKhachHang.kryptonTextBox2' is never used
#pragma warning disable CS0169 // The field 'frmSettingKhachHang.kryptonTextBox3' is never used
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
#pragma warning restore CS0169 // The field 'frmSettingKhachHang.kryptonTextBox3' is never used
#pragma warning disable CS0169 // The field 'frmSettingKhachHang.kryptonTextBox4' is never used
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox4;
#pragma warning restore CS0169 // The field 'frmSettingKhachHang.kryptonTextBox4' is never used
#pragma warning disable CS0169 // The field 'frmSettingKhachHang.kryptonTextBox5' is never used
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox5;
#pragma warning restore CS0169 // The field 'frmSettingKhachHang.kryptonTextBox5' is never used
#pragma warning disable CS0169 // The field 'frmSettingKhachHang.kryptonTextBox6' is never used
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox6;
        private CustomControls.RJControls.RJTextBox txtTenTaiKhoan;
        private CustomControls.RJControls.RJTextBox txtNamSinh;
        private CustomControls.RJControls.RJTextBox txtDiaChi;
        private PictureBox pictureBox1;
        private Label label11;
        private Label label12;
        private CustomControls.RJControls.RJComboBox txtGioiTinh;
        private CustomControls.RJControls.RJTextBox txtHoTen;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private CustomControls.RJControls.RJButton rjButton1;
    }
}