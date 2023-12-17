namespace baitap.View
{
    partial class frmTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            label6 = new Label();
            label7 = new Label();
            bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            groupBox3 = new GroupBox();
            kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            groupBox2 = new GroupBox();
            kryptonDateTimePicker2 = new Krypton.Toolkit.KryptonDateTimePicker();
            groupBox1 = new GroupBox();
            kryptonDateTimePicker1 = new Krypton.Toolkit.KryptonDateTimePicker();
            rjButton1 = new CustomControls.RJControls.RJButton();
            bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            timer1 = new System.Windows.Forms.Timer(components);
            bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            bunifuCards4 = new Bunifu.Framework.UI.BunifuCards();
            bunifuCards5 = new Bunifu.Framework.UI.BunifuCards();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bunifuCards1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 82);
            label6.Name = "label6";
            label6.Size = new Size(326, 90);
            label6.TabIndex = 0;
            label6.Text = "Chào mừng đến\r\nTrung Luxury Resort";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlDark;
            label7.Location = new Point(21, 183);
            label7.Name = "label7";
            label7.Size = new Size(456, 42);
            label7.TabIndex = 0;
            label7.Text = "Đem đến trải nghiệm tốt nhất cho khách hàng, bước đến vị trí\r\nsố 1 về Booking Resort\r\n";
            // 
            // bunifuCards1
            // 
            bunifuCards1.BackColor = Color.WhiteSmoke;
            bunifuCards1.BorderRadius = 20;
            bunifuCards1.BottomSahddow = true;
            bunifuCards1.BottomShadow = true;
            bunifuCards1.color = Color.Transparent;
            bunifuCards1.Controls.Add(groupBox3);
            bunifuCards1.Controls.Add(groupBox2);
            bunifuCards1.Controls.Add(groupBox1);
            bunifuCards1.Controls.Add(rjButton1);
            bunifuCards1.IndicatorColor = Color.Transparent;
            bunifuCards1.LeftSahddow = false;
            bunifuCards1.LeftShadow = false;
            bunifuCards1.Location = new Point(21, 247);
            bunifuCards1.Name = "bunifuCards1";
            bunifuCards1.RightSahddow = true;
            bunifuCards1.RightShadow = true;
            bunifuCards1.ShadowDepth = 20;
            bunifuCards1.Size = new Size(679, 110);
            bunifuCards1.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(kryptonComboBox1);
            groupBox3.Location = new Point(389, 10);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(166, 84);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Số người";
            // 
            // kryptonComboBox1
            // 
            kryptonComboBox1.DropDownWidth = 148;
            kryptonComboBox1.IntegralHeight = false;
            kryptonComboBox1.Items.AddRange(new object[] { "1 Người", "2 Người", "3 Người", "4 Người", "5 Người", "6 Người" });
            kryptonComboBox1.Location = new Point(6, 35);
            kryptonComboBox1.Name = "kryptonComboBox1";
            kryptonComboBox1.Size = new Size(154, 27);
            kryptonComboBox1.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonComboBox1.StateCommon.ComboBox.Border.Rounding = 5F;
            kryptonComboBox1.StateCommon.ComboBox.Border.Width = 2;
            kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonComboBox1.TabIndex = 0;
            kryptonComboBox1.Text = "Lựa chọn số người";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(kryptonDateTimePicker2);
            groupBox2.Location = new Point(201, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(182, 84);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ngày về";
            // 
            // kryptonDateTimePicker2
            // 
            kryptonDateTimePicker2.CustomFormat = "dddd, dd, MM, yyyy";
            kryptonDateTimePicker2.Format = DateTimePickerFormat.Custom;
            kryptonDateTimePicker2.Location = new Point(6, 35);
            kryptonDateTimePicker2.Name = "kryptonDateTimePicker2";
            kryptonDateTimePicker2.Size = new Size(167, 27);
            kryptonDateTimePicker2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonDateTimePicker2.StateCommon.Border.Rounding = 5F;
            kryptonDateTimePicker2.StateCommon.Border.Width = 2;
            kryptonDateTimePicker2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(kryptonDateTimePicker1);
            groupBox1.Location = new Point(13, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(182, 84);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ngày tới";
            // 
            // kryptonDateTimePicker1
            // 
            kryptonDateTimePicker1.CustomFormat = "dddd, dd, MM, yyyy";
            kryptonDateTimePicker1.Format = DateTimePickerFormat.Custom;
            kryptonDateTimePicker1.Location = new Point(6, 35);
            kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            kryptonDateTimePicker1.Size = new Size(167, 27);
            kryptonDateTimePicker1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonDateTimePicker1.StateCommon.Border.Rounding = 5F;
            kryptonDateTimePicker1.StateCommon.Border.Width = 2;
            kryptonDateTimePicker1.TabIndex = 0;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(255, 49, 101);
            rjButton1.BackgroundColor = Color.FromArgb(255, 49, 101);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 5;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(561, 32);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(102, 40);
            rjButton1.TabIndex = 1;
            rjButton1.Text = "Đặt ngay";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // bunifuCards2
            // 
            bunifuCards2.BackColor = Color.White;
            bunifuCards2.BackgroundImage = Properties.Resources.rs1;
            bunifuCards2.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuCards2.BorderRadius = 40;
            bunifuCards2.BottomSahddow = true;
            bunifuCards2.BottomShadow = true;
            bunifuCards2.color = Color.Transparent;
            bunifuCards2.IndicatorColor = Color.Transparent;
            bunifuCards2.LeftSahddow = false;
            bunifuCards2.LeftShadow = false;
            bunifuCards2.Location = new Point(761, 82);
            bunifuCards2.Name = "bunifuCards2";
            bunifuCards2.RightSahddow = true;
            bunifuCards2.RightShadow = true;
            bunifuCards2.ShadowDepth = 20;
            bunifuCards2.Size = new Size(640, 427);
            bunifuCards2.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Tick += ImageTimer_Tick;
            // 
            // bunifuCards3
            // 
            bunifuCards3.BackColor = Color.White;
            bunifuCards3.BackgroundImage = (Image)resources.GetObject("bunifuCards3.BackgroundImage");
            bunifuCards3.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuCards3.BorderRadius = 20;
            bunifuCards3.BottomSahddow = true;
            bunifuCards3.BottomShadow = true;
            bunifuCards3.color = Color.Transparent;
            bunifuCards3.IndicatorColor = Color.Transparent;
            bunifuCards3.LeftSahddow = false;
            bunifuCards3.LeftShadow = false;
            bunifuCards3.Location = new Point(21, 404);
            bunifuCards3.Name = "bunifuCards3";
            bunifuCards3.RightSahddow = true;
            bunifuCards3.RightShadow = true;
            bunifuCards3.ShadowDepth = 20;
            bunifuCards3.Size = new Size(195, 172);
            bunifuCards3.TabIndex = 4;
            // 
            // bunifuCards4
            // 
            bunifuCards4.BackColor = Color.White;
            bunifuCards4.BackgroundImage = (Image)resources.GetObject("bunifuCards4.BackgroundImage");
            bunifuCards4.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuCards4.BorderRadius = 20;
            bunifuCards4.BottomSahddow = true;
            bunifuCards4.BottomShadow = true;
            bunifuCards4.color = Color.Transparent;
            bunifuCards4.IndicatorColor = Color.Transparent;
            bunifuCards4.LeftSahddow = false;
            bunifuCards4.LeftShadow = false;
            bunifuCards4.Location = new Point(258, 404);
            bunifuCards4.Name = "bunifuCards4";
            bunifuCards4.RightSahddow = true;
            bunifuCards4.RightShadow = true;
            bunifuCards4.ShadowDepth = 20;
            bunifuCards4.Size = new Size(195, 172);
            bunifuCards4.TabIndex = 4;
            // 
            // bunifuCards5
            // 
            bunifuCards5.BackColor = Color.White;
            bunifuCards5.BackgroundImage = (Image)resources.GetObject("bunifuCards5.BackgroundImage");
            bunifuCards5.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuCards5.BorderRadius = 20;
            bunifuCards5.BottomSahddow = true;
            bunifuCards5.BottomShadow = true;
            bunifuCards5.color = Color.Transparent;
            bunifuCards5.IndicatorColor = Color.Transparent;
            bunifuCards5.LeftSahddow = false;
            bunifuCards5.LeftShadow = false;
            bunifuCards5.Location = new Point(505, 404);
            bunifuCards5.Name = "bunifuCards5";
            bunifuCards5.RightSahddow = true;
            bunifuCards5.RightShadow = true;
            bunifuCards5.ShadowDepth = 20;
            bunifuCards5.Size = new Size(195, 172);
            bunifuCards5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(58, 579);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 5;
            label1.Text = "Nghỉ dưỡng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(314, 579);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 5;
            label2.Text = "Bãi biển";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(566, 579);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 5;
            label3.Text = "Hồ bơi";
            // 
            // frmTrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 690);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bunifuCards5);
            Controls.Add(bunifuCards4);
            Controls.Add(bunifuCards3);
            Controls.Add(bunifuCards2);
            Controls.Add(bunifuCards1);
            Controls.Add(label7);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTrangChu";
            Text = "frmTrangChu";
            bunifuCards1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label7;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private CustomControls.RJControls.RJButton rjButton1;
        private GroupBox groupBox1;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private GroupBox groupBox3;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private GroupBox groupBox2;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private Bunifu.Framework.UI.BunifuCards bunifuCards4;
        private Bunifu.Framework.UI.BunifuCards bunifuCards5;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}