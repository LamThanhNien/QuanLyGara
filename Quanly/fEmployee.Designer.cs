namespace Quanly
{
    partial class fEmployee
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
            dtgvEmployee = new DataGridView();
            panel1 = new Panel();
            button1 = new Button();
            tbSearch = new TextBox();
            panel29 = new Panel();
            tbName = new TextBox();
            label4 = new Label();
            panel28 = new Panel();
            tbPhone = new TextBox();
            label3 = new Label();
            panel27 = new Panel();
            cbbType = new ComboBox();
            label2 = new Label();
            panel30 = new Panel();
            button3 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            tbChucvu = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            tbLuong = new TextBox();
            label5 = new Label();
            panel4 = new Panel();
            tbDay = new TextBox();
            label6 = new Label();
            checkBoxOut = new CheckBox();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtgvEmployee).BeginInit();
            panel1.SuspendLayout();
            panel29.SuspendLayout();
            panel28.SuspendLayout();
            panel27.SuspendLayout();
            panel30.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvEmployee
            // 
            dtgvEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvEmployee.BackgroundColor = SystemColors.Control;
            dtgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvEmployee.Location = new Point(4, 2);
            dtgvEmployee.Margin = new Padding(4, 3, 4, 3);
            dtgvEmployee.Name = "dtgvEmployee";
            dtgvEmployee.RowHeadersWidth = 62;
            dtgvEmployee.Size = new Size(800, 592);
            dtgvEmployee.TabIndex = 14;
            dtgvEmployee.TabStop = false;
            dtgvEmployee.CellClick += dtgvEmployee_CellClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(tbSearch);
            panel1.Location = new Point(812, 2);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 68);
            panel1.TabIndex = 15;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Arial", 11F, FontStyle.Bold);
            button1.Location = new Point(336, 19);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(116, 35);
            button1.TabIndex = 1;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbSearch.Location = new Point(6, 19);
            tbSearch.Margin = new Padding(4, 3, 4, 3);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(323, 33);
            tbSearch.TabIndex = 0;
            // 
            // panel29
            // 
            panel29.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel29.Controls.Add(tbName);
            panel29.Controls.Add(label4);
            panel29.Location = new Point(812, 87);
            panel29.Margin = new Padding(4, 3, 4, 3);
            panel29.Name = "panel29";
            panel29.Size = new Size(452, 58);
            panel29.TabIndex = 16;
            // 
            // tbName
            // 
            tbName.Location = new Point(86, 12);
            tbName.Margin = new Padding(4, 3, 4, 3);
            tbName.Name = "tbName";
            tbName.Size = new Size(345, 33);
            tbName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11F, FontStyle.Bold);
            label4.Location = new Point(4, 12);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 26);
            label4.TabIndex = 0;
            label4.Text = "Tên";
            // 
            // panel28
            // 
            panel28.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel28.Controls.Add(tbPhone);
            panel28.Controls.Add(label3);
            panel28.Location = new Point(812, 151);
            panel28.Margin = new Padding(4, 3, 4, 3);
            panel28.Name = "panel28";
            panel28.Size = new Size(467, 58);
            panel28.TabIndex = 17;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(157, 9);
            tbPhone.Margin = new Padding(4, 3, 4, 3);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(298, 33);
            tbPhone.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11F, FontStyle.Bold);
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(4, 16);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 26);
            label3.TabIndex = 0;
            label3.Text = "Số điện thoại";
            // 
            // panel27
            // 
            panel27.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel27.Controls.Add(cbbType);
            panel27.Controls.Add(label2);
            panel27.Location = new Point(812, 407);
            panel27.Margin = new Padding(4, 3, 4, 3);
            panel27.Name = "panel27";
            panel27.Size = new Size(467, 58);
            panel27.TabIndex = 21;
            // 
            // cbbType
            // 
            cbbType.FormattingEnabled = true;
            cbbType.Items.AddRange(new object[] { "Admin", "Nhân viên" });
            cbbType.Location = new Point(159, 8);
            cbbType.Margin = new Padding(4, 3, 4, 3);
            cbbType.Name = "cbbType";
            cbbType.Size = new Size(207, 34);
            cbbType.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11F, FontStyle.Bold);
            label2.Location = new Point(4, 11);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 26);
            label2.TabIndex = 0;
            label2.Text = "Loại Account";
            // 
            // panel30
            // 
            panel30.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel30.Controls.Add(button3);
            panel30.Controls.Add(button6);
            panel30.Controls.Add(button5);
            panel30.Controls.Add(button4);
            panel30.Location = new Point(806, 541);
            panel30.Margin = new Padding(4, 3, 4, 3);
            panel30.Name = "panel30";
            panel30.Size = new Size(458, 53);
            panel30.TabIndex = 23;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Location = new Point(343, 10);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(97, 35);
            button3.TabIndex = 4;
            button3.Text = "Xem";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnShow_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button6.Location = new Point(4, 10);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(102, 35);
            button6.TabIndex = 1;
            button6.Text = "Thêm";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnAdd_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.Location = new Point(119, 10);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(105, 35);
            button5.TabIndex = 2;
            button5.Text = "Lưu";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnFix_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.Location = new Point(234, 10);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(101, 35);
            button4.TabIndex = 3;
            button4.Text = "Xóa";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnDelete_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(tbChucvu);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(812, 215);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(467, 58);
            panel2.TabIndex = 18;
            // 
            // tbChucvu
            // 
            tbChucvu.Location = new Point(113, 9);
            tbChucvu.Margin = new Padding(4, 3, 4, 3);
            tbChucvu.Name = "tbChucvu";
            tbChucvu.Size = new Size(298, 33);
            tbChucvu.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11F, FontStyle.Bold);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(4, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 26);
            label1.TabIndex = 0;
            label1.Text = "Chức vụ";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Controls.Add(tbLuong);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(812, 279);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(467, 58);
            panel3.TabIndex = 19;
            // 
            // tbLuong
            // 
            tbLuong.Location = new Point(113, 9);
            tbLuong.Margin = new Padding(4, 3, 4, 3);
            tbLuong.Name = "tbLuong";
            tbLuong.Size = new Size(298, 33);
            tbLuong.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11F, FontStyle.Bold);
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(4, 16);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(83, 26);
            label5.TabIndex = 0;
            label5.Text = "Lương";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.Controls.Add(tbDay);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(812, 343);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(467, 58);
            panel4.TabIndex = 20;
            // 
            // tbDay
            // 
            tbDay.Location = new Point(113, 13);
            tbDay.Margin = new Padding(4, 3, 4, 3);
            tbDay.Name = "tbDay";
            tbDay.Size = new Size(298, 33);
            tbDay.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11F, FontStyle.Bold);
            label6.ImageAlign = ContentAlignment.TopCenter;
            label6.Location = new Point(4, 16);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(108, 26);
            label6.TabIndex = 0;
            label6.Text = "Ngày vào";
            // 
            // checkBoxOut
            // 
            checkBoxOut.AutoSize = true;
            checkBoxOut.Location = new Point(15, 15);
            checkBoxOut.Name = "checkBoxOut";
            checkBoxOut.Size = new Size(134, 30);
            checkBoxOut.TabIndex = 3;
            checkBoxOut.Text = "Đang làm";
            checkBoxOut.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.Controls.Add(checkBoxOut);
            panel5.Location = new Point(812, 471);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(467, 58);
            panel5.TabIndex = 22;
            // 
            // fEmployee
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 598);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel30);
            Controls.Add(panel27);
            Controls.Add(panel28);
            Controls.Add(panel29);
            Controls.Add(panel1);
            Controls.Add(dtgvEmployee);
            Font = new Font("Arial", 11F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fEmployee";
            Text = "fEmployee";
            Load += fEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvEmployee).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel29.ResumeLayout(false);
            panel29.PerformLayout();
            panel28.ResumeLayout(false);
            panel28.PerformLayout();
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            panel30.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvEmployee;
        private Panel panel1;
        private TextBox tbSearch;
        private Button button1;
        private Panel panel29;
        private TextBox tbName;
        private Label label4;
        private Panel panel28;
        private TextBox tbPhone;
        private Label label3;
        private Panel panel27;
        private ComboBox cbbType;
        private Label label2;
        private Panel panel30;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel panel2;
        private TextBox tbChucvu;
        private Label label1;
        private Panel panel3;
        private TextBox tbLuong;
        private Label label5;
        private Panel panel4;
        private TextBox tbDay;
        private Label label6;
        private CheckBox checkBoxOut;
        private Panel panel5;
    }
}