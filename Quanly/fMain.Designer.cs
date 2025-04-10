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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnLogout = new Button();
            btnThongke = new Button();
            btnEmployee = new Button();
            btnDichvu = new Button();
            btnCar = new Button();
            button1 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            tÀIKHOẢNToolStripMenuItem = new ToolStripMenuItem();
            đăngNhậpToolStripMenuItem = new ToolStripMenuItem();
            thôngTinToolStripMenuItem = new ToolStripMenuItem();
            cậpNhậtThôngTinToolStripMenuItem = new ToolStripMenuItem();
            phânQuyềnToolStripMenuItem = new ToolStripMenuItem();
            Exit = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            tbUsername = new TextBox();
            panelbody = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnMax_Normal = new Button();
            btnExit = new Button();
            btnMinimize = new Button();
            pnlTitleBar_MouseDown = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            pnlTitleBar_MouseDown.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnThongke);
            panel1.Controls.Add(btnEmployee);
            panel1.Controls.Add(btnDichvu);
            panel1.Controls.Add(btnCar);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 923);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_removebg_preview;
            pictureBox1.Location = new Point(12, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.BackColor = Color.SteelBlue;
            btnLogout.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(0, 876);
            btnLogout.Margin = new Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(196, 47);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Visible = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnThongke
            // 
            btnThongke.BackColor = Color.SteelBlue;
            btnThongke.FlatStyle = FlatStyle.Flat;
            btnThongke.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnThongke.ForeColor = SystemColors.ButtonHighlight;
            btnThongke.Location = new Point(4, 551);
            btnThongke.Margin = new Padding(4, 3, 4, 3);
            btnThongke.Name = "btnThongke";
            btnThongke.Size = new Size(188, 64);
            btnThongke.TabIndex = 5;
            btnThongke.Text = "Thống Kê";
            btnThongke.UseVisualStyleBackColor = false;
            btnThongke.Visible = false;
            btnThongke.Click += btnThongke_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.SteelBlue;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnEmployee.ForeColor = SystemColors.ButtonHighlight;
            btnEmployee.Location = new Point(4, 481);
            btnEmployee.Margin = new Padding(4, 3, 4, 3);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(188, 64);
            btnEmployee.TabIndex = 6;
            btnEmployee.Text = "QL Nhân Viên";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Visible = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnDichvu
            // 
            btnDichvu.BackColor = Color.SteelBlue;
            btnDichvu.FlatStyle = FlatStyle.Flat;
            btnDichvu.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnDichvu.ForeColor = SystemColors.ButtonHighlight;
            btnDichvu.Location = new Point(4, 411);
            btnDichvu.Margin = new Padding(4, 3, 4, 3);
            btnDichvu.Name = "btnDichvu";
            btnDichvu.Size = new Size(188, 64);
            btnDichvu.TabIndex = 4;
            btnDichvu.Text = "QL Dịch Vụ";
            btnDichvu.UseVisualStyleBackColor = false;
            btnDichvu.Click += btnDichvu_Click;
            // 
            // btnCar
            // 
            btnCar.BackColor = Color.SteelBlue;
            btnCar.FlatStyle = FlatStyle.Flat;
            btnCar.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnCar.ForeColor = SystemColors.ButtonHighlight;
            btnCar.Location = new Point(4, 341);
            btnCar.Margin = new Padding(4, 3, 4, 3);
            btnCar.Name = "btnCar";
            btnCar.Size = new Size(188, 64);
            btnCar.TabIndex = 3;
            btnCar.Text = "Xe";
            btnCar.UseVisualStyleBackColor = false;
            btnCar.Click += btnCar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 11F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(4, 271);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(188, 64);
            button1.TabIndex = 2;
            button1.Text = "Khách Hàng";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnCustomer_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 11F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(4, 201);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(188, 64);
            button2.TabIndex = 1;
            button2.Text = "Thanh Toán";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnThanhtoan_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(menuStrip1);
            panel2.Controls.Add(tbUsername);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(196, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(1215, 50);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(149, 29);
            label1.TabIndex = 2;
            label1.Text = "Thanh Toán";
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menuStrip1.AutoSize = false;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tÀIKHOẢNToolStripMenuItem, toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6 });
            menuStrip1.Location = new Point(1039, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(176, 44);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tÀIKHOẢNToolStripMenuItem
            // 
            tÀIKHOẢNToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngNhậpToolStripMenuItem, thôngTinToolStripMenuItem, Exit });
            tÀIKHOẢNToolStripMenuItem.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tÀIKHOẢNToolStripMenuItem.Image = Properties.Resources.download__4_1;
            tÀIKHOẢNToolStripMenuItem.Name = "tÀIKHOẢNToolStripMenuItem";
            tÀIKHOẢNToolStripMenuItem.Size = new Size(159, 40);
            tÀIKHOẢNToolStripMenuItem.Text = "TÀI KHOẢN";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            đăngNhậpToolStripMenuItem.Size = new Size(214, 34);
            đăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
            đăngNhậpToolStripMenuItem.Click += đăngNhậpToolStripMenuItem_Click;
            // 
            // thôngTinToolStripMenuItem
            // 
            thôngTinToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cậpNhậtThôngTinToolStripMenuItem, phânQuyềnToolStripMenuItem });
            thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            thôngTinToolStripMenuItem.Size = new Size(214, 34);
            thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // cậpNhậtThôngTinToolStripMenuItem
            // 
            cậpNhậtThôngTinToolStripMenuItem.Name = "cậpNhậtThôngTinToolStripMenuItem";
            cậpNhậtThôngTinToolStripMenuItem.Size = new Size(305, 34);
            cậpNhậtThôngTinToolStripMenuItem.Text = "Cập nhật thông tin";
            cậpNhậtThôngTinToolStripMenuItem.Click += cậpNhậtThôngTinToolStripMenuItem_Click;
            // 
            // phânQuyềnToolStripMenuItem
            // 
            phânQuyềnToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            phânQuyềnToolStripMenuItem.Name = "phânQuyềnToolStripMenuItem";
            phânQuyềnToolStripMenuItem.Size = new Size(305, 34);
            phânQuyềnToolStripMenuItem.Text = "Thêm Nhân viên mới";
            // 
            // Exit
            // 
            Exit.Enabled = false;
            Exit.Image = Properties.Resources.download__2_;
            Exit.Name = "Exit";
            Exit.RightToLeft = RightToLeft.Yes;
            Exit.Size = new Size(214, 34);
            Exit.Text = "Đăng xuất";
            Exit.TextImageRelation = TextImageRelation.TextBeforeImage;
            Exit.Click += đăngXuấtToolStripMenuItem_Click;
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
            // tbUsername
            // 
            tbUsername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbUsername.BackColor = SystemColors.ControlLight;
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(879, 11);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.ReadOnly = true;
            tbUsername.RightToLeft = RightToLeft.Yes;
            tbUsername.Size = new Size(157, 26);
            tbUsername.TabIndex = 1;
            tbUsername.Text = "Xin chào";
            // 
            // panelbody
            // 
            panelbody.Dock = DockStyle.Fill;
            panelbody.Location = new Point(196, 88);
            panelbody.Name = "panelbody";
            panelbody.Size = new Size(1215, 835);
            panelbody.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnMax_Normal
            // 
            btnMax_Normal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax_Normal.Location = new Point(1127, 0);
            btnMax_Normal.Name = "btnMax_Normal";
            btnMax_Normal.Size = new Size(41, 38);
            btnMax_Normal.TabIndex = 2;
            btnMax_Normal.Text = "⬜";
            btnMax_Normal.TextAlign = ContentAlignment.TopCenter;
            btnMax_Normal.UseVisualStyleBackColor = true;
            btnMax_Normal.Click += btnMaxsize_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(1174, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(41, 38);
            btnExit.TabIndex = 0;
            btnExit.Text = "✕";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Location = new Point(1080, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(41, 38);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "─";
            btnMinimize.TextAlign = ContentAlignment.TopCenter;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // pnlTitleBar_MouseDown
            // 
            pnlTitleBar_MouseDown.BackColor = Color.SteelBlue;
            pnlTitleBar_MouseDown.Controls.Add(btnMinimize);
            pnlTitleBar_MouseDown.Controls.Add(btnExit);
            pnlTitleBar_MouseDown.Controls.Add(btnMax_Normal);
            pnlTitleBar_MouseDown.Dock = DockStyle.Top;
            pnlTitleBar_MouseDown.Location = new Point(196, 0);
            pnlTitleBar_MouseDown.Name = "pnlTitleBar_MouseDown";
            pnlTitleBar_MouseDown.Size = new Size(1215, 38);
            pnlTitleBar_MouseDown.TabIndex = 2;
            pnlTitleBar_MouseDown.MouseDown += pnlTitleBar_MouseDown_MouseDown;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1411, 923);
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
        private Panel panelbody;
        private Button btnCar;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tÀIKHOẢNToolStripMenuItem;
        private ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem cậpNhậtThôngTinToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ContextMenuStrip contextMenuStrip1;
        public Button btnEmployee;
        public Button btnThongke;
        private Button btnDichvu;
        public ToolStripMenuItem Exit;
        public TextBox tbUsername;
        public Button btnLogout;
        public ToolStripMenuItem phânQuyềnToolStripMenuItem;
        private Button btnMax_Normal;
        private Button btnExit;
        private Button btnMinimize;
        private Panel pnlTitleBar_MouseDown;
    }
}