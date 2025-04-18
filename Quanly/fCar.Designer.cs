namespace Quanly
{
    partial class fCar
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
            dtgvCar = new DataGridView();
            panel5 = new Panel();
            button6 = new Button();
            tbTimCar = new TextBox();
            pictureBoxCar = new PictureBox();
            btnAddImage1 = new Button();
            label9 = new Label();
            panel17 = new Panel();
            tbCustomer = new TextBox();
            label8 = new Label();
            panel1 = new Panel();
            tbPhone = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            tbHang = new TextBox();
            label5 = new Label();
            tbNameCar = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            tbNumCar = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            tbColor = new TextBox();
            label4 = new Label();
            AddCar = new Button();
            btnFix = new Button();
            btnShow = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvCar).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCar).BeginInit();
            panel17.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvCar
            // 
            dtgvCar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvCar.BackgroundColor = SystemColors.Control;
            dtgvCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCar.Location = new Point(2, 3);
            dtgvCar.Margin = new Padding(4, 3, 4, 3);
            dtgvCar.Name = "dtgvCar";
            dtgvCar.RowHeadersWidth = 62;
            dtgvCar.Size = new Size(755, 732);
            dtgvCar.TabIndex = 0;
            dtgvCar.TabStop = false;
            dtgvCar.CellClick += dtgvCar_CellClick;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.Controls.Add(button6);
            panel5.Controls.Add(tbTimCar);
            panel5.Location = new Point(766, 12);
            panel5.Margin = new Padding(5, 3, 5, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(614, 57);
            panel5.TabIndex = 0;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.Font = new Font("Arial", 10F, FontStyle.Bold);
            button6.Location = new Point(404, 12);
            button6.Margin = new Padding(5, 3, 5, 3);
            button6.Name = "button6";
            button6.Size = new Size(115, 35);
            button6.TabIndex = 2;
            button6.Text = "Tìm";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnSearch_Click;
            // 
            // tbTimCar
            // 
            tbTimCar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbTimCar.Location = new Point(5, 14);
            tbTimCar.Margin = new Padding(5, 3, 5, 3);
            tbTimCar.Name = "tbTimCar";
            tbTimCar.Size = new Size(378, 30);
            tbTimCar.TabIndex = 1;
            // 
            // pictureBoxCar
            // 
            pictureBoxCar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxCar.Location = new Point(766, 74);
            pictureBoxCar.Margin = new Padding(5, 3, 5, 3);
            pictureBoxCar.Name = "pictureBoxCar";
            pictureBoxCar.Size = new Size(303, 202);
            pictureBoxCar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCar.TabIndex = 11;
            pictureBoxCar.TabStop = false;
            // 
            // btnAddImage1
            // 
            btnAddImage1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddImage1.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnAddImage1.Location = new Point(1106, 127);
            btnAddImage1.Margin = new Padding(4, 3, 4, 3);
            btnAddImage1.Name = "btnAddImage1";
            btnAddImage1.Size = new Size(131, 48);
            btnAddImage1.TabIndex = 1;
            btnAddImage1.Text = "Thêm ảnh";
            btnAddImage1.UseVisualStyleBackColor = true;
            btnAddImage1.Click += btnAddImage1_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10F, FontStyle.Bold);
            label9.Location = new Point(766, 296);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(217, 24);
            label9.TabIndex = 0;
            label9.Text = "Thông tin khách hàng";
            // 
            // panel17
            // 
            panel17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel17.Controls.Add(tbCustomer);
            panel17.Controls.Add(label8);
            panel17.Location = new Point(766, 336);
            panel17.Margin = new Padding(5, 3, 5, 3);
            panel17.Name = "panel17";
            panel17.Size = new Size(576, 57);
            panel17.TabIndex = 2;
            // 
            // tbCustomer
            // 
            tbCustomer.Location = new Point(141, 17);
            tbCustomer.Margin = new Padding(5, 3, 5, 3);
            tbCustomer.Name = "tbCustomer";
            tbCustomer.ReadOnly = true;
            tbCustomer.Size = new Size(424, 30);
            tbCustomer.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10F, FontStyle.Bold);
            label8.Location = new Point(19, 17);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(112, 24);
            label8.TabIndex = 0;
            label8.Text = "Tên Khách";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(tbPhone);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(766, 396);
            panel1.Margin = new Padding(5, 3, 5, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 57);
            panel1.TabIndex = 3;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(141, 10);
            tbPhone.Margin = new Padding(5, 3, 5, 3);
            tbPhone.Name = "tbPhone";
            tbPhone.ReadOnly = true;
            tbPhone.Size = new Size(242, 30);
            tbPhone.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.Location = new Point(33, 14);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 24);
            label1.TabIndex = 0;
            label1.Text = "Số ĐT";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(tbHang);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(tbNameCar);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(766, 459);
            panel2.Margin = new Padding(5, 3, 5, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(622, 57);
            panel2.TabIndex = 4;
            // 
            // tbHang
            // 
            tbHang.Location = new Point(439, 12);
            tbHang.Margin = new Padding(5, 3, 5, 3);
            tbHang.Name = "tbHang";
            tbHang.Size = new Size(176, 30);
            tbHang.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold);
            label5.Location = new Point(369, 17);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 24);
            label5.TabIndex = 2;
            label5.Text = "Hãng";
            // 
            // tbNameCar
            // 
            tbNameCar.Location = new Point(141, 12);
            tbNameCar.Margin = new Padding(5, 3, 5, 3);
            tbNameCar.Name = "tbNameCar";
            tbNameCar.Size = new Size(218, 30);
            tbNameCar.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.Location = new Point(33, 17);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 24);
            label2.TabIndex = 0;
            label2.Text = "Tên Xe";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Controls.Add(tbNumCar);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(766, 523);
            panel3.Margin = new Padding(5, 3, 5, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(622, 57);
            panel3.TabIndex = 5;
            // 
            // tbNumCar
            // 
            tbNumCar.Location = new Point(141, 12);
            tbNumCar.Margin = new Padding(5, 3, 5, 3);
            tbNumCar.Name = "tbNumCar";
            tbNumCar.Size = new Size(242, 30);
            tbNumCar.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.Location = new Point(33, 14);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 24);
            label3.TabIndex = 0;
            label3.Text = "Số Xe";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.Controls.Add(tbColor);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(766, 586);
            panel4.Margin = new Padding(5, 3, 5, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(622, 57);
            panel4.TabIndex = 6;
            // 
            // tbColor
            // 
            tbColor.Location = new Point(141, 12);
            tbColor.Margin = new Padding(5, 3, 5, 3);
            tbColor.Name = "tbColor";
            tbColor.Size = new Size(153, 30);
            tbColor.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold);
            label4.Location = new Point(33, 14);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 24);
            label4.TabIndex = 0;
            label4.Text = "Màu Xe";
            // 
            // AddCar
            // 
            AddCar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddCar.BackColor = Color.SteelBlue;
            AddCar.Font = new Font("Arial", 10F, FontStyle.Bold);
            AddCar.ForeColor = SystemColors.Control;
            AddCar.Location = new Point(1247, 659);
            AddCar.Margin = new Padding(4, 3, 4, 3);
            AddCar.Name = "AddCar";
            AddCar.Size = new Size(107, 58);
            AddCar.TabIndex = 10;
            AddCar.Text = "Thêm";
            AddCar.UseVisualStyleBackColor = false;
            AddCar.Click += AddCar_Click;
            // 
            // btnFix
            // 
            btnFix.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFix.BackColor = Color.SteelBlue;
            btnFix.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnFix.ForeColor = SystemColors.Control;
            btnFix.Location = new Point(1106, 659);
            btnFix.Margin = new Padding(4, 3, 4, 3);
            btnFix.Name = "btnFix";
            btnFix.Size = new Size(113, 58);
            btnFix.TabIndex = 9;
            btnFix.Text = "Lưu";
            btnFix.UseVisualStyleBackColor = false;
            btnFix.Click += btnFix_Click;
            // 
            // btnShow
            // 
            btnShow.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnShow.BackColor = Color.SteelBlue;
            btnShow.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnShow.ForeColor = SystemColors.Control;
            btnShow.Location = new Point(785, 659);
            btnShow.Margin = new Padding(4, 3, 4, 3);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(113, 58);
            btnShow.TabIndex = 7;
            btnShow.Text = "Xem";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.BackColor = Color.SteelBlue;
            btnDelete.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(946, 659);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 58);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // fCar
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1394, 737);
            Controls.Add(btnDelete);
            Controls.Add(btnShow);
            Controls.Add(btnFix);
            Controls.Add(panel1);
            Controls.Add(AddCar);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel17);
            Controls.Add(label9);
            Controls.Add(btnAddImage1);
            Controls.Add(pictureBoxCar);
            Controls.Add(dtgvCar);
            Controls.Add(panel5);
            Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            ImeMode = ImeMode.Off;
            Margin = new Padding(4, 3, 4, 3);
            Name = "fCar";
            ShowIcon = false;
            Text = "Xe";
            Load += fCar_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvCar).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCar).EndInit();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvCar;
        private Panel panel5;
        private Button button6;
        private TextBox tbTimCar;
        private PictureBox pictureBoxCar;
        private Button btnAddImage1;
        private Label label9;
        private Panel panel17;
        private TextBox tbCustomer;
        private Label label8;
        private Panel panel1;
        private TextBox tbPhone;
        private Label label1;
        private Panel panel2;
        private TextBox tbNameCar;
        private Label label2;
        private Panel panel3;
        private TextBox tbNumCar;
        private Label label3;
        private Panel panel4;
        private TextBox tbColor;
        private Label label4;
        private Button AddCar;
        private Button btnFix;
        private Button btnShow;
        private TextBox tbHang;
        private Label label5;
        private Button btnDelete;
    }
}