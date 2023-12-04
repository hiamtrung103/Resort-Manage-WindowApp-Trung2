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
            comboBox1 = new ComboBox();
            kryptonRichTextBox1 = new Krypton.Toolkit.KryptonRichTextBox();
            FeedBack_RatTe = new PictureBox();
            FeedBack_NhamChan = new PictureBox();
            FeedBack_BinhThuong = new PictureBox();
            FeedBack_VuiVe = new PictureBox();
            FeedBack_RatVuiVe = new PictureBox();
            lbFeedBack = new Label();
            rjButton1 = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)FeedBack_RatTe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FeedBack_NhamChan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FeedBack_BinhThuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FeedBack_VuiVe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FeedBack_RatVuiVe).BeginInit();
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
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(336, 32);
            label2.TabIndex = 29;
            label2.Text = "Đánh giá chất lượng dịch vụ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(299, 51);
            label3.TabIndex = 29;
            label3.Text = "Chọn từ icon theo cảm nhận của bạn!!\r\nBạn có thể thêm lời đánh giá về dịch vụ và những \r\nthứ bạn chưa hài lòng";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tôi cảm thấy rất hài lòng", "Tôi cảm thấy không hài lòng", "Dịch vụ làm tôi thất vọng", "Dịch vụ không đúng như mô tả", "Tôi không thích cách phục vụ của nhân viên" });
            comboBox1.Location = new Point(12, 262);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(336, 23);
            comboBox1.TabIndex = 30;
            // 
            // kryptonRichTextBox1
            // 
            kryptonRichTextBox1.Location = new Point(8, 291);
            kryptonRichTextBox1.Name = "kryptonRichTextBox1";
            kryptonRichTextBox1.Size = new Size(340, 160);
            kryptonRichTextBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonRichTextBox1.StateCommon.Border.Rounding = 2F;
            kryptonRichTextBox1.StateCommon.Border.Width = 2;
            kryptonRichTextBox1.TabIndex = 31;
            kryptonRichTextBox1.Text = "";
            // 
            // FeedBack_RatTe
            // 
            FeedBack_RatTe.Image = Properties.Resources.unhappy_50;
            FeedBack_RatTe.Location = new Point(12, 174);
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
            FeedBack_NhamChan.Location = new Point(68, 174);
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
            FeedBack_BinhThuong.Location = new Point(124, 174);
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
            FeedBack_VuiVe.Location = new Point(180, 174);
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
            FeedBack_RatVuiVe.Location = new Point(236, 174);
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
            lbFeedBack.Location = new Point(16, 236);
            lbFeedBack.Name = "lbFeedBack";
            lbFeedBack.Size = new Size(79, 21);
            lbFeedBack.TabIndex = 33;
            lbFeedBack.Text = "Trạng thái";
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.MediumSlateBlue;
            rjButton1.BackgroundColor = Color.MediumSlateBlue;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 5;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(91, 457);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(150, 40);
            rjButton1.TabIndex = 34;
            rjButton1.Text = "Đánh giá";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // frmDanhGia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 690);
            Controls.Add(rjButton1);
            Controls.Add(lbFeedBack);
            Controls.Add(FeedBack_RatVuiVe);
            Controls.Add(FeedBack_VuiVe);
            Controls.Add(FeedBack_BinhThuong);
            Controls.Add(FeedBack_NhamChan);
            Controls.Add(FeedBack_RatTe);
            Controls.Add(kryptonRichTextBox1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDanhGia";
            Text = "frmDanhGia";
            ((System.ComponentModel.ISupportInitialize)FeedBack_RatTe).EndInit();
            ((System.ComponentModel.ISupportInitialize)FeedBack_NhamChan).EndInit();
            ((System.ComponentModel.ISupportInitialize)FeedBack_BinhThuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)FeedBack_VuiVe).EndInit();
            ((System.ComponentModel.ISupportInitialize)FeedBack_RatVuiVe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBox1;
        private PictureBox FeedBack_RatTe;
        private PictureBox FeedBack_NhamChan;
        private PictureBox FeedBack_BinhThuong;
        private PictureBox FeedBack_VuiVe;
        private PictureBox FeedBack_RatVuiVe;
        private Label lbFeedBack;
        private CustomControls.RJControls.RJButton rjButton1;
    }
}