namespace baitap.View
{
    partial class frmDanhGia
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTieuDe = new ComboBox();
            txtPhanHoi = new Krypton.Toolkit.KryptonRichTextBox();
            FeedBack_RatTe = new PictureBox();
            FeedBack_NhamChan = new PictureBox();
            FeedBack_BinhThuong = new PictureBox();
            FeedBack_VuiVe = new PictureBox();
            FeedBack_RatVuiVe = new PictureBox();
            lbFeedBack = new Label();
            rjButton1 = new CustomControls.RJControls.RJButton();
            txtHoTen = new Label();
            label4 = new Label();
            bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            ((System.ComponentModel.ISupportInitialize)FeedBack_RatTe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FeedBack_NhamChan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FeedBack_BinhThuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FeedBack_VuiVe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FeedBack_RatVuiVe).BeginInit();
            bunifuCards1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 29;
            label1.Text = "Đánh giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 15);
            label2.Name = "label2";
            label2.Size = new Size(336, 32);
            label2.TabIndex = 29;
            label2.Text = "Đánh giá chất lượng dịch vụ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(17, 47);
            label3.Name = "label3";
            label3.Size = new Size(309, 45);
            label3.TabIndex = 29;
            label3.Text = "*Bắt buộc bấm icon 1 trong 5 biểu cảm tương ứng 1-5 sao\r\n*Bạn có thể thêm lời đánh giá về dịch vụ và những \r\nthứ bạn chưa hài lòng";
            // 
            // txtTieuDe
            // 
            txtTieuDe.FormattingEnabled = true;
            txtTieuDe.Items.AddRange(new object[] { "Dịch vụ làm tôi thất vọng", "Dịch vụ không đúng như mô tả", "Tôi không thích cách phục vụ của nhân viên" });
            txtTieuDe.Location = new Point(17, 213);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(332, 23);
            txtTieuDe.TabIndex = 30;
            // 
            // txtPhanHoi
            // 
            txtPhanHoi.Location = new Point(13, 242);
            txtPhanHoi.Name = "txtPhanHoi";
            txtPhanHoi.Size = new Size(340, 160);
            txtPhanHoi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPhanHoi.StateCommon.Border.Rounding = 2F;
            txtPhanHoi.StateCommon.Border.Width = 2;
            txtPhanHoi.TabIndex = 31;
            txtPhanHoi.Text = "";
            // 
            // FeedBack_RatTe
            // 
            FeedBack_RatTe.Image = Properties.Resources.unhappy_50;
            FeedBack_RatTe.Location = new Point(17, 104);
            FeedBack_RatTe.Name = "FeedBack_RatTe";
            FeedBack_RatTe.Size = new Size(50, 50);
            FeedBack_RatTe.SizeMode = PictureBoxSizeMode.StretchImage;
            FeedBack_RatTe.TabIndex = 32;
            FeedBack_RatTe.TabStop = false;
            FeedBack_RatTe.Click += FeedBack_RatTe_Click;
            // 
            // FeedBack_NhamChan
            // 
            FeedBack_NhamChan.Image = Properties.Resources.bored_50;
            FeedBack_NhamChan.Location = new Point(73, 104);
            FeedBack_NhamChan.Name = "FeedBack_NhamChan";
            FeedBack_NhamChan.Size = new Size(50, 50);
            FeedBack_NhamChan.SizeMode = PictureBoxSizeMode.StretchImage;
            FeedBack_NhamChan.TabIndex = 32;
            FeedBack_NhamChan.TabStop = false;
            FeedBack_NhamChan.Click += FeedBack_NhamChan_Click;
            // 
            // FeedBack_BinhThuong
            // 
            FeedBack_BinhThuong.Image = Properties.Resources.neutral_50;
            FeedBack_BinhThuong.Location = new Point(129, 104);
            FeedBack_BinhThuong.Name = "FeedBack_BinhThuong";
            FeedBack_BinhThuong.Size = new Size(50, 50);
            FeedBack_BinhThuong.SizeMode = PictureBoxSizeMode.StretchImage;
            FeedBack_BinhThuong.TabIndex = 32;
            FeedBack_BinhThuong.TabStop = false;
            FeedBack_BinhThuong.Click += FeedBack_BinhThuong_Click;
            // 
            // FeedBack_VuiVe
            // 
            FeedBack_VuiVe.Image = Properties.Resources.happy_50;
            FeedBack_VuiVe.Location = new Point(185, 104);
            FeedBack_VuiVe.Name = "FeedBack_VuiVe";
            FeedBack_VuiVe.Size = new Size(50, 50);
            FeedBack_VuiVe.SizeMode = PictureBoxSizeMode.StretchImage;
            FeedBack_VuiVe.TabIndex = 32;
            FeedBack_VuiVe.TabStop = false;
            FeedBack_VuiVe.Click += FeedBack_VuiVe_Click;
            // 
            // FeedBack_RatVuiVe
            // 
            FeedBack_RatVuiVe.Image = Properties.Resources.smiling_face_with_heart_50;
            FeedBack_RatVuiVe.Location = new Point(241, 104);
            FeedBack_RatVuiVe.Name = "FeedBack_RatVuiVe";
            FeedBack_RatVuiVe.Size = new Size(50, 50);
            FeedBack_RatVuiVe.SizeMode = PictureBoxSizeMode.StretchImage;
            FeedBack_RatVuiVe.TabIndex = 32;
            FeedBack_RatVuiVe.TabStop = false;
            FeedBack_RatVuiVe.Click += FeedBack_RatVuiVe_Click;
            // 
            // lbFeedBack
            // 
            lbFeedBack.AutoSize = true;
            lbFeedBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbFeedBack.Location = new Point(17, 164);
            lbFeedBack.Name = "lbFeedBack";
            lbFeedBack.Size = new Size(79, 21);
            lbFeedBack.TabIndex = 33;
            lbFeedBack.Text = "Trạng thái";
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.RoyalBlue;
            rjButton1.BackgroundColor = Color.RoyalBlue;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 5;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(17, 408);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(150, 40);
            rjButton1.TabIndex = 34;
            rjButton1.Text = "Đánh giá";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += btnLuu_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.AutoSize = true;
            txtHoTen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtHoTen.Location = new Point(111, 189);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(61, 21);
            txtHoTen.TabIndex = 35;
            txtHoTen.Text = "Họ tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 189);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 35;
            label4.Text = "Khách Hàng:";
            // 
            // bunifuCards1
            // 
            bunifuCards1.BackColor = Color.White;
            bunifuCards1.BorderRadius = 20;
            bunifuCards1.BottomSahddow = true;
            bunifuCards1.BottomShadow = true;
            bunifuCards1.color = Color.Transparent;
            bunifuCards1.Controls.Add(label4);
            bunifuCards1.Controls.Add(txtHoTen);
            bunifuCards1.Controls.Add(rjButton1);
            bunifuCards1.Controls.Add(lbFeedBack);
            bunifuCards1.Controls.Add(label2);
            bunifuCards1.Controls.Add(FeedBack_RatVuiVe);
            bunifuCards1.Controls.Add(label3);
            bunifuCards1.Controls.Add(FeedBack_VuiVe);
            bunifuCards1.Controls.Add(txtTieuDe);
            bunifuCards1.Controls.Add(FeedBack_BinhThuong);
            bunifuCards1.Controls.Add(txtPhanHoi);
            bunifuCards1.Controls.Add(FeedBack_NhamChan);
            bunifuCards1.Controls.Add(FeedBack_RatTe);
            bunifuCards1.IndicatorColor = Color.Transparent;
            bunifuCards1.LeftSahddow = false;
            bunifuCards1.LeftShadow = false;
            bunifuCards1.Location = new Point(12, 44);
            bunifuCards1.Name = "bunifuCards1";
            bunifuCards1.RightSahddow = true;
            bunifuCards1.RightShadow = true;
            bunifuCards1.ShadowDepth = 20;
            bunifuCards1.Size = new Size(384, 477);
            bunifuCards1.TabIndex = 36;
            // 
            // frmDanhGia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1534, 690);
            Controls.Add(bunifuCards1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDanhGia";
            Text = "frmDanhGia";
            Load += frmDanhGia_Load;
            ((System.ComponentModel.ISupportInitialize)FeedBack_RatTe).EndInit();
            ((System.ComponentModel.ISupportInitialize)FeedBack_NhamChan).EndInit();
            ((System.ComponentModel.ISupportInitialize)FeedBack_BinhThuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)FeedBack_VuiVe).EndInit();
            ((System.ComponentModel.ISupportInitialize)FeedBack_RatVuiVe).EndInit();
            bunifuCards1.ResumeLayout(false);
            bunifuCards1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox txtTieuDe;
        private Krypton.Toolkit.KryptonRichTextBox txtPhanHoi;
        private PictureBox FeedBack_RatTe;
        private PictureBox FeedBack_NhamChan;
        private PictureBox FeedBack_BinhThuong;
        private PictureBox FeedBack_VuiVe;
        private PictureBox FeedBack_RatVuiVe;
        private Label lbFeedBack;
        private CustomControls.RJControls.RJButton rjButton1;
        private Label txtHoTen;
        private Label label4;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
    }
}