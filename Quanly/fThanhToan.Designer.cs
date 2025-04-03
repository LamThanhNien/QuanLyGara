namespace Quanly
{
    partial class fThanhToan
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
            dtgvCustomer = new DataGridView();
            listViewPrice = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            tbTotal = new TextBox();
            btnThanhToan = new Button();
            panel2 = new Panel();
            label20 = new Label();
            label12 = new Label();
            numericUpDown = new NumericUpDown();
            btnAddBill = new Button();
            cbbSp = new ComboBox();
            comboBoxLoad = new ComboBox();
            panel3 = new Panel();
            tbCtm = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            tbnumCar = new TextBox();
            label3 = new Label();
            textBox8 = new TextBox();
            btntim = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvCustomer).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvCustomer
            // 
            dtgvCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCustomer.Location = new Point(5, 3);
            dtgvCustomer.Margin = new Padding(4, 3, 4, 3);
            dtgvCustomer.Name = "dtgvCustomer";
            dtgvCustomer.RowHeadersWidth = 62;
            dtgvCustomer.Size = new Size(686, 844);
            dtgvCustomer.TabIndex = 1;
            dtgvCustomer.CellClick += dtgvCustomer_CellClick;
            // 
            // listViewPrice
            // 
            listViewPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listViewPrice.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewPrice.GridLines = true;
            listViewPrice.Location = new Point(701, 282);
            listViewPrice.Margin = new Padding(4, 3, 4, 3);
            listViewPrice.Name = "listViewPrice";
            listViewPrice.Size = new Size(635, 495);
            listViewPrice.TabIndex = 12;
            listViewPrice.UseCompatibleStateImageBehavior = false;
            listViewPrice.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên Phụ Tùng";
            columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "SL";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Giá";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tiền";
            columnHeader4.Width = 180;
            // 
            // tbTotal
            // 
            tbTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbTotal.Location = new Point(708, 798);
            tbTotal.Margin = new Padding(5, 3, 5, 3);
            tbTotal.Name = "tbTotal";
            tbTotal.ReadOnly = true;
            tbTotal.Size = new Size(362, 30);
            tbTotal.TabIndex = 13;
            tbTotal.Text = "0";
            tbTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThanhToan.Location = new Point(1105, 789);
            btnThanhToan.Margin = new Padding(5, 3, 5, 3);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(228, 48);
            btnThanhToan.TabIndex = 14;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(label20);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(numericUpDown);
            panel2.Controls.Add(btnAddBill);
            panel2.Controls.Add(cbbSp);
            panel2.Controls.Add(comboBoxLoad);
            panel2.Location = new Point(701, 181);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(635, 95);
            panel2.TabIndex = 15;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new Font("Arial", 10F, FontStyle.Bold);
            label20.Location = new Point(7, 53);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(50, 24);
            label20.TabIndex = 5;
            label20.Text = "Loại";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 10F, FontStyle.Bold);
            label12.Location = new Point(7, 11);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(104, 24);
            label12.TabIndex = 4;
            label12.Text = "Phân Loại";
            // 
            // numericUpDown
            // 
            numericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            numericUpDown.Location = new Point(553, 30);
            numericUpDown.Margin = new Padding(4, 3, 4, 3);
            numericUpDown.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDown.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(79, 30);
            numericUpDown.TabIndex = 3;
            numericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddBill
            // 
            btnAddBill.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddBill.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnAddBill.Location = new Point(412, 21);
            btnAddBill.Margin = new Padding(4, 3, 4, 3);
            btnAddBill.Name = "btnAddBill";
            btnAddBill.Size = new Size(134, 46);
            btnAddBill.TabIndex = 2;
            btnAddBill.Text = "Thêm";
            btnAddBill.UseVisualStyleBackColor = true;
            btnAddBill.Click += btnAddBill_Click;
            // 
            // cbbSp
            // 
            cbbSp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cbbSp.FormattingEnabled = true;
            cbbSp.Location = new Point(151, 50);
            cbbSp.Margin = new Padding(4, 3, 4, 3);
            cbbSp.Name = "cbbSp";
            cbbSp.Size = new Size(252, 32);
            cbbSp.TabIndex = 1;
            // 
            // comboBoxLoad
            // 
            comboBoxLoad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            comboBoxLoad.FormattingEnabled = true;
            comboBoxLoad.Location = new Point(151, 11);
            comboBoxLoad.Margin = new Padding(4, 3, 4, 3);
            comboBoxLoad.Name = "comboBoxLoad";
            comboBoxLoad.Size = new Size(252, 32);
            comboBoxLoad.TabIndex = 0;
            comboBoxLoad.SelectedIndexChanged += comboBoxLoad_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Controls.Add(tbCtm);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(701, 55);
            panel3.Margin = new Padding(5, 3, 5, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(635, 56);
            panel3.TabIndex = 16;
            // 
            // tbCtm
            // 
            tbCtm.Location = new Point(185, 15);
            tbCtm.Margin = new Padding(5, 3, 5, 3);
            tbCtm.Name = "tbCtm";
            tbCtm.ReadOnly = true;
            tbCtm.Size = new Size(419, 30);
            tbCtm.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.Location = new Point(5, 15);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 24);
            label2.TabIndex = 0;
            label2.Text = "Tên Khách";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.Controls.Add(tbnumCar);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(701, 118);
            panel4.Margin = new Padding(5, 3, 5, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(635, 56);
            panel4.TabIndex = 16;
            // 
            // tbnumCar
            // 
            tbnumCar.Location = new Point(182, 15);
            tbnumCar.Margin = new Padding(5, 3, 5, 3);
            tbnumCar.Name = "tbnumCar";
            tbnumCar.ReadOnly = true;
            tbnumCar.Size = new Size(419, 30);
            tbnumCar.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.Location = new Point(5, 15);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 24);
            label3.TabIndex = 0;
            label3.Text = "Biển số xe";
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox8.Location = new Point(701, 14);
            textBox8.Margin = new Padding(5, 3, 5, 3);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(448, 30);
            textBox8.TabIndex = 17;
            // 
            // btntim
            // 
            btntim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btntim.Font = new Font("Arial", 10F, FontStyle.Bold);
            btntim.Location = new Point(1161, 14);
            btntim.Margin = new Padding(5, 3, 5, 3);
            btntim.Name = "btntim";
            btntim.Size = new Size(172, 34);
            btntim.TabIndex = 18;
            btntim.Text = "Tìm";
            btntim.UseVisualStyleBackColor = true;
            btntim.Click += btntim_Click;
            // 
            // fThanhToan
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 850);
            Controls.Add(btntim);
            Controls.Add(textBox8);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnThanhToan);
            Controls.Add(tbTotal);
            Controls.Add(listViewPrice);
            Controls.Add(dtgvCustomer);
            Font = new Font("Arial", 10F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fThanhToan";
            ShowIcon = false;
            Load += fThanhToan_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvCustomer).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvCustomer;
        private ListView listViewPrice;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox tbTotal;
        private Button btnThanhToan;
        private Panel panel2;
        private Label label20;
        private Label label12;
        private NumericUpDown numericUpDown;
        private Button btnAddBill;
        private ComboBox cbbSp;
        private ComboBox comboBoxLoad;
        private Panel panel3;
        private TextBox tbCtm;
        private Label label2;
        private Panel panel4;
        private TextBox tbnumCar;
        private Label label3;
        private TextBox textBox8;
        private Button btntim;
    }
}