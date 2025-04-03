namespace Quanly
{
    partial class fMain
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
            panel1 = new Panel();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            btnThongke = new Button();
            btnDichvu = new Button();
            btnCar = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            tÀIKHOẢNToolStripMenuItem = new ToolStripMenuItem();
            đăngNhậpToolStripMenuItem = new ToolStripMenuItem();
            thôngTinToolStripMenuItem = new ToolStripMenuItem();
            cậpNhậtThôngTinToolStripMenuItem = new ToolStripMenuItem();
            phânQuyềnToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            textBox1 = new TextBox();
            panelbody = new Panel();
            pnlTitleBar_MouseDown = new Panel();
            btnMinimize = new Button();
            btnExit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            pnlTitleBar_MouseDown.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(btnThongke);
            panel1.Controls.Add(btnDichvu);
            panel1.Controls.Add(btnCar);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(177, 879);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(224, 224, 224);
            button2.Font = new Font("Arial", 11F, FontStyle.Bold);
            button2.Location = new Point(5, 147);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(169, 47);
            button2.TabIndex = 1;
            button2.Text = "Thanh Toán";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnThanhtoan_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images3;
            pictureBox1.Location = new Point(3, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Font = new Font("Arial", 11F, FontStyle.Bold);
            button5.Location = new Point(3, 820);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(169, 47);
            button5.TabIndex = 6;
            button5.Text = "ADMIN";
            button5.UseVisualStyleBackColor = false;
            // 
            // btnThongke
            // 
            btnThongke.BackColor = Color.FromArgb(224, 224, 224);
            btnThongke.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnThongke.Location = new Point(5, 359);
            btnThongke.Margin = new Padding(4, 3, 4, 3);
            btnThongke.Name = "btnThongke";
            btnThongke.Size = new Size(169, 47);
            btnThongke.TabIndex = 5;
            btnThongke.Text = "Thống Kê";
            btnThongke.UseVisualStyleBackColor = false;
            btnThongke.Click += btnThongke_Click;
            // 
            // btnDichvu
            // 
            btnDichvu.BackColor = Color.FromArgb(224, 224, 224);
            btnDichvu.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnDichvu.Location = new Point(5, 306);
            btnDichvu.Margin = new Padding(4, 3, 4, 3);
            btnDichvu.Name = "btnDichvu";
            btnDichvu.Size = new Size(169, 47);
            btnDichvu.TabIndex = 4;
            btnDichvu.Text = "QL Dịch Vụ";
            btnDichvu.UseVisualStyleBackColor = false;
            btnDichvu.Click += btnDichvu_Click;
            // 
            // btnCar
            // 
            btnCar.BackColor = Color.FromArgb(224, 224, 224);
            btnCar.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnCar.Location = new Point(5, 253);
            btnCar.Margin = new Padding(4, 3, 4, 3);
            btnCar.Name = "btnCar";
            btnCar.Size = new Size(169, 47);
            btnCar.TabIndex = 3;
            btnCar.Text = "Xe";
            btnCar.UseVisualStyleBackColor = false;
            btnCar.Click += btnCar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.Font = new Font("Arial", 11F, FontStyle.Bold);
            button1.Location = new Point(5, 200);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(169, 47);
            button1.TabIndex = 2;
            button1.Text = "Khách Hàng";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnCustomer_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(menuStrip1);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(179, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(1166, 50);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tÀIKHOẢNToolStripMenuItem, toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6 });
            menuStrip1.Location = new Point(990, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(176, 44);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tÀIKHOẢNToolStripMenuItem
            // 
            tÀIKHOẢNToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngNhậpToolStripMenuItem, thôngTinToolStripMenuItem, đăngXuấtToolStripMenuItem });
            tÀIKHOẢNToolStripMenuItem.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tÀIKHOẢNToolStripMenuItem.Image = Properties.Resources.download__4_1;
            tÀIKHOẢNToolStripMenuItem.Name = "tÀIKHOẢNToolStripMenuItem";
            tÀIKHOẢNToolStripMenuItem.Size = new Size(159, 40);
            tÀIKHOẢNToolStripMenuItem.Text = "TÀI KHOẢN";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            đăngNhậpToolStripMenuItem.Size = new Size(270, 34);
            đăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
            đăngNhậpToolStripMenuItem.Click += đăngNhậpToolStripMenuItem_Click;
            // 
            // thôngTinToolStripMenuItem
            // 
            thôngTinToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cậpNhậtThôngTinToolStripMenuItem, phânQuyềnToolStripMenuItem });
            thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            thôngTinToolStripMenuItem.Size = new Size(270, 34);
            thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // cậpNhậtThôngTinToolStripMenuItem
            // 
            cậpNhậtThôngTinToolStripMenuItem.Name = "cậpNhậtThôngTinToolStripMenuItem";
            cậpNhậtThôngTinToolStripMenuItem.Size = new Size(286, 34);
            cậpNhậtThôngTinToolStripMenuItem.Text = "Cập nhật thông tin";
            // 
            // phânQuyềnToolStripMenuItem
            // 
            phânQuyềnToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            phânQuyềnToolStripMenuItem.Enabled = false;
            phânQuyềnToolStripMenuItem.Name = "phânQuyềnToolStripMenuItem";
            phânQuyềnToolStripMenuItem.Size = new Size(286, 34);
            phânQuyềnToolStripMenuItem.Text = "Phân quyền";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Enabled = false;
            đăngXuấtToolStripMenuItem.Image = Properties.Resources.download__2_;
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.RightToLeft = RightToLeft.Yes;
            đăngXuấtToolStripMenuItem.Size = new Size(270, 34);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.TextImageRelation = TextImageRelation.TextBeforeImage;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(16, 40);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(16, 40);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(16, 40);
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(16, 40);
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(16, 40);
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(16, 40);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(863, 8);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(150, 39);
            textBox1.TabIndex = 1;
            textBox1.Text = "Xin chào LTN";
            // 
            // panelbody
            // 
            panelbody.Location = new Point(179, 96);
            panelbody.Name = "panelbody";
            panelbody.Size = new Size(1175, 758);
            panelbody.TabIndex = 2;
            // 
            // pnlTitleBar_MouseDown
            // 
            pnlTitleBar_MouseDown.BackColor = Color.FromArgb(45, 47, 51);
            pnlTitleBar_MouseDown.Controls.Add(btnMinimize);
            pnlTitleBar_MouseDown.Controls.Add(btnExit);
            pnlTitleBar_MouseDown.Dock = DockStyle.Top;
            pnlTitleBar_MouseDown.Location = new Point(0, 0);
            pnlTitleBar_MouseDown.Name = "pnlTitleBar_MouseDown";
            pnlTitleBar_MouseDown.Size = new Size(1357, 34);
            pnlTitleBar_MouseDown.TabIndex = 2;
            pnlTitleBar_MouseDown.MouseDown += pnlTitleBar_MouseDown_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Location = new Point(1269, 1);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(41, 34);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "−";
            btnMinimize.TextAlign = ContentAlignment.TopCenter;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1316, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(41, 34);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 879);
            Controls.Add(panelbody);
            Controls.Add(panel2);
            Controls.Add(pnlTitleBar_MouseDown);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fMain";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlTitleBar_MouseDown.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tÀIKHOẢNToolStripMenuItem;
        private Panel panelbody;
        private Button button5;
        private Button btnThongke;
        private Button btnDichvu;
        private Button btnCar;
        private Button button1;
        private ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem cậpNhậtThôngTinToolStripMenuItem;
        private ToolStripMenuItem phânQuyềnToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private TextBox textBox1;
        private Panel pnlTitleBar_MouseDown;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private Button btnMinimize;
        private Button btnExit;
        private Label label1;
        private Button button2;
    }
}