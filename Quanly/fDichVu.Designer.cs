namespace Quanly
{
    partial class fDichVu
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
            dtgvMaterial = new DataGridView();
            panel24 = new Panel();
            button7 = new Button();
            tbMaterial = new TextBox();
            pictureBoxM = new PictureBox();
            btnAddImage = new Button();
            panel25 = new Panel();
            tbnameMaterial = new TextBox();
            label13 = new Label();
            panel27 = new Panel();
            btnDichVu = new Button();
            comboBoxLoadMaterial = new ComboBox();
            label17 = new Label();
            panel32 = new Panel();
            tbPrice = new TextBox();
            label22 = new Label();
            panel33 = new Panel();
            tbNoisx = new TextBox();
            label1 = new Label();
            tbQuantity = new TextBox();
            label23 = new Label();
            button1 = new Button();
            btnDelete = new Button();
            btnFix = new Button();
            AddDichvu = new Button();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            tbType = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvMaterial).BeginInit();
            panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxM).BeginInit();
            panel25.SuspendLayout();
            panel27.SuspendLayout();
            panel32.SuspendLayout();
            panel33.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvMaterial
            // 
            dtgvMaterial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvMaterial.Location = new Point(0, -1);
            dtgvMaterial.Margin = new Padding(4, 3, 4, 3);
            dtgvMaterial.Name = "dtgvMaterial";
            dtgvMaterial.RowHeadersWidth = 62;
            dtgvMaterial.Size = new Size(563, 694);
            dtgvMaterial.TabIndex = 9;
            dtgvMaterial.CellClick += dtgvDichvu_CellClick;
            // 
            // panel24
            // 
            panel24.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel24.Controls.Add(button7);
            panel24.Controls.Add(tbMaterial);
            panel24.Location = new Point(572, -1);
            panel24.Margin = new Padding(5, 3, 5, 3);
            panel24.Name = "panel24";
            panel24.Size = new Size(569, 67);
            panel24.TabIndex = 21;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button7.Location = new Point(425, 15);
            button7.Margin = new Padding(5, 3, 5, 3);
            button7.Name = "button7";
            button7.Size = new Size(113, 34);
            button7.TabIndex = 1;
            button7.Text = "Tìm";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btnSearch_Click;
            // 
            // tbMaterial
            // 
            tbMaterial.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbMaterial.Location = new Point(25, 15);
            tbMaterial.Margin = new Padding(5, 3, 5, 3);
            tbMaterial.Name = "tbMaterial";
            tbMaterial.Size = new Size(378, 30);
            tbMaterial.TabIndex = 0;
            // 
            // pictureBoxM
            // 
            pictureBoxM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxM.BackColor = SystemColors.AppWorkspace;
            pictureBoxM.Location = new Point(6, 29);
            pictureBoxM.Name = "pictureBoxM";
            pictureBoxM.Size = new Size(273, 188);
            pictureBoxM.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxM.TabIndex = 26;
            pictureBoxM.TabStop = false;
            // 
            // btnAddImage
            // 
            btnAddImage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddImage.Location = new Point(285, 29);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(144, 58);
            btnAddImage.TabIndex = 32;
            btnAddImage.Text = "Thêm ảnh";
            btnAddImage.UseVisualStyleBackColor = true;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // panel25
            // 
            panel25.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel25.Controls.Add(tbnameMaterial);
            panel25.Controls.Add(label13);
            panel25.Location = new Point(6, 225);
            panel25.Margin = new Padding(4, 3, 4, 3);
            panel25.Name = "panel25";
            panel25.Size = new Size(513, 58);
            panel25.TabIndex = 33;
            // 
            // tbnameMaterial
            // 
            tbnameMaterial.Location = new Point(58, 13);
            tbnameMaterial.Margin = new Padding(4, 3, 4, 3);
            tbnameMaterial.Name = "tbnameMaterial";
            tbnameMaterial.Size = new Size(391, 30);
            tbnameMaterial.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ImageAlign = ContentAlignment.TopCenter;
            label13.Location = new Point(4, 16);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(46, 24);
            label13.TabIndex = 0;
            label13.Text = "Tên";
            // 
            // panel27
            // 
            panel27.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel27.Controls.Add(btnDichVu);
            panel27.Controls.Add(comboBoxLoadMaterial);
            panel27.Controls.Add(label17);
            panel27.Location = new Point(6, 355);
            panel27.Margin = new Padding(4, 3, 4, 3);
            panel27.Name = "panel27";
            panel27.Size = new Size(513, 58);
            panel27.TabIndex = 25;
            // 
            // btnDichVu
            // 
            btnDichVu.Anchor = AnchorStyles.None;
            btnDichVu.Location = new Point(373, -1);
            btnDichVu.Name = "btnDichVu";
            btnDichVu.Size = new Size(133, 58);
            btnDichVu.TabIndex = 111131;
            btnDichVu.Text = "Dịch vụ mới";
            btnDichVu.UseVisualStyleBackColor = true;
            btnDichVu.Click += btnDichVu_Click;
            // 
            // comboBoxLoadMaterial
            // 
            comboBoxLoadMaterial.FormattingEnabled = true;
            comboBoxLoadMaterial.Location = new Point(115, 13);
            comboBoxLoadMaterial.Name = "comboBoxLoadMaterial";
            comboBoxLoadMaterial.Size = new Size(236, 32);
            comboBoxLoadMaterial.TabIndex = 32;
            comboBoxLoadMaterial.SelectedIndexChanged += comboBoxLoadMaterial_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ImageAlign = ContentAlignment.TopCenter;
            label17.Location = new Point(4, 16);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(81, 24);
            label17.TabIndex = 0;
            label17.Text = "Dịch vụ";
            // 
            // panel32
            // 
            panel32.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel32.Controls.Add(tbPrice);
            panel32.Controls.Add(label22);
            panel32.Location = new Point(6, 419);
            panel32.Margin = new Padding(4, 3, 4, 3);
            panel32.Name = "panel32";
            panel32.Size = new Size(513, 58);
            panel32.TabIndex = 33;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(85, 16);
            tbPrice.Margin = new Padding(4, 3, 4, 3);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(266, 30);
            tbPrice.TabIndex = 1;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ImageAlign = ContentAlignment.TopCenter;
            label22.Location = new Point(4, 16);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(73, 24);
            label22.TabIndex = 0;
            label22.Text = "Giá Cả";
            // 
            // panel33
            // 
            panel33.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel33.Controls.Add(tbNoisx);
            panel33.Controls.Add(label1);
            panel33.Controls.Add(tbQuantity);
            panel33.Controls.Add(label23);
            panel33.Location = new Point(6, 483);
            panel33.Margin = new Padding(4, 3, 4, 3);
            panel33.Name = "panel33";
            panel33.Size = new Size(513, 58);
            panel33.TabIndex = 34;
            // 
            // tbNoisx
            // 
            tbNoisx.Location = new Point(87, 13);
            tbNoisx.Margin = new Padding(4, 3, 4, 3);
            tbNoisx.Name = "tbNoisx";
            tbNoisx.Size = new Size(202, 30);
            tbNoisx.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(4, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 24);
            label1.TabIndex = 2;
            label1.Text = "Nơi SX";
            // 
            // tbQuantity
            // 
            tbQuantity.Location = new Point(395, 13);
            tbQuantity.Margin = new Padding(4, 3, 4, 3);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(111, 30);
            tbQuantity.TabIndex = 1;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ImageAlign = ContentAlignment.TopCenter;
            label23.Location = new Point(289, 16);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(98, 24);
            label23.TabIndex = 0;
            label23.Text = "Số lượng";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("Arial", 10F, FontStyle.Bold);
            button1.Location = new Point(578, 625);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(104, 57);
            button1.TabIndex = 111127;
            button1.Text = "Xem";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnreLoad_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnDelete.Location = new Point(716, 625);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 57);
            btnDelete.TabIndex = 111128;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFix
            // 
            btnFix.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFix.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnFix.Location = new Point(857, 625);
            btnFix.Margin = new Padding(4, 3, 4, 3);
            btnFix.Name = "btnFix";
            btnFix.Size = new Size(104, 57);
            btnFix.TabIndex = 111129;
            btnFix.Text = "Sửa";
            btnFix.UseVisualStyleBackColor = true;
            btnFix.Click += btnFix_Click;
            // 
            // AddDichvu
            // 
            AddDichvu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddDichvu.BackColor = SystemColors.ActiveCaption;
            AddDichvu.Font = new Font("Arial", 10F, FontStyle.Bold);
            AddDichvu.Location = new Point(997, 625);
            AddDichvu.Margin = new Padding(4, 3, 4, 3);
            AddDichvu.Name = "AddDichvu";
            AddDichvu.Size = new Size(104, 57);
            AddDichvu.TabIndex = 111130;
            AddDichvu.Text = "Thêm";
            AddDichvu.UseVisualStyleBackColor = false;
            AddDichvu.Click += AddDichvu_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(pictureBoxM);
            groupBox1.Controls.Add(btnAddImage);
            groupBox1.Controls.Add(panel25);
            groupBox1.Controls.Add(panel27);
            groupBox1.Controls.Add(panel32);
            groupBox1.Controls.Add(panel33);
            groupBox1.Location = new Point(572, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(569, 547);
            groupBox1.TabIndex = 111131;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(tbType);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(6, 289);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(513, 58);
            panel1.TabIndex = 35;
            // 
            // tbType
            // 
            tbType.Location = new Point(58, 13);
            tbType.Name = "tbType";
            tbType.Size = new Size(196, 30);
            tbType.TabIndex = 111132;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(4, 16);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 24);
            label2.TabIndex = 0;
            label2.Text = "Loại";
            // 
            // fDichVu
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 694);
            Controls.Add(groupBox1);
            Controls.Add(AddDichvu);
            Controls.Add(btnFix);
            Controls.Add(btnDelete);
            Controls.Add(button1);
            Controls.Add(panel24);
            Controls.Add(dtgvMaterial);
            Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fDichVu";
            StartPosition = FormStartPosition.CenterScreen;
            Load += fDichVu_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvMaterial).EndInit();
            panel24.ResumeLayout(false);
            panel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxM).EndInit();
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            panel32.ResumeLayout(false);
            panel32.PerformLayout();
            panel33.ResumeLayout(false);
            panel33.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dtgvMaterial;
        private Panel panel24;
        private Button button7;
        private TextBox tbMaterial;
        private PictureBox pictureBoxM;
        private Button btnAddImage;
        private Panel panel25;
        private TextBox tbnameMaterial;
        private Label label13;
        private Panel panel27;
        private ComboBox comboBoxLoadMaterial;
        private Label label17;
        private Panel panel32;
        private TextBox tbPrice;
        private Panel panel33;
        private TextBox tbQuantity;
        private Label label23;
        private Button button1;
        private Button btnDelete;
        private Button btnFix;
        private Button AddDichvu;
        private Button btnDichVu;
        private GroupBox groupBox1;
        private Label label22;
        private TextBox tbNoisx;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox tbType;
    }
}