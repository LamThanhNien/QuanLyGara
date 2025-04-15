namespace Quanly
{
    partial class QLThongKe
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            tbDoanhthu = new TextBox();
            label2 = new Label();
            dtgvRevenue = new DataGridView();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            btnBaocao = new Button();
            btnShow = new Button();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label3 = new Label();
            tabPage2 = new TabPage();
            panel4 = new Panel();
            dataGridViewProduct = new DataGridView();
            panel3 = new Panel();
            button3 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvRevenue).BeginInit();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1266, 663);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 38);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1258, 621);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thống kê doanh thu";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(tbDoanhthu);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dtgvRevenue);
            panel2.Location = new Point(3, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(1252, 502);
            panel2.TabIndex = 7;
            // 
            // tbDoanhthu
            // 
            tbDoanhthu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbDoanhthu.Location = new Point(947, 461);
            tbDoanhthu.Name = "tbDoanhthu";
            tbDoanhthu.ReadOnly = true;
            tbDoanhthu.Size = new Size(300, 35);
            tbDoanhthu.TabIndex = 11;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(799, 464);
            label2.Name = "label2";
            label2.Size = new Size(133, 29);
            label2.TabIndex = 12;
            label2.Text = "Doanh thu";
            // 
            // dtgvRevenue
            // 
            dtgvRevenue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvRevenue.BackgroundColor = SystemColors.Control;
            dtgvRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvRevenue.Location = new Point(0, 6);
            dtgvRevenue.Name = "dtgvRevenue";
            dtgvRevenue.RowHeadersWidth = 51;
            dtgvRevenue.Size = new Size(1252, 449);
            dtgvRevenue.TabIndex = 7;
            dtgvRevenue.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(btnBaocao);
            panel1.Controls.Add(btnShow);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1252, 113);
            panel1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            dateTimePicker1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(31, 61);
            dateTimePicker1.MinDate = new DateTime(2025, 4, 6, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(240, 35);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.Value = new DateTime(2025, 4, 6, 0, 0, 0, 0);
            // 
            // btnBaocao
            // 
            btnBaocao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBaocao.BackColor = Color.DodgerBlue;
            btnBaocao.ForeColor = Color.White;
            btnBaocao.Location = new Point(1080, 52);
            btnBaocao.Name = "btnBaocao";
            btnBaocao.Size = new Size(172, 55);
            btnBaocao.TabIndex = 4;
            btnBaocao.Text = "Xuất báo cáo";
            btnBaocao.UseVisualStyleBackColor = false;
            btnBaocao.Click += btnBaocao_Click;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.DodgerBlue;
            btnShow.ForeColor = Color.White;
            btnShow.Location = new Point(523, 52);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(133, 55);
            btnShow.TabIndex = 3;
            btnShow.Text = "Xem";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "MM/dd/yyyy";
            dateTimePicker2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(277, 61);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(240, 35);
            dateTimePicker2.TabIndex = 2;
            dateTimePicker2.Value = new DateTime(2025, 4, 10, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(343, 23);
            label1.Name = "label1";
            label1.Size = new Size(116, 27);
            label1.TabIndex = 10;
            label1.Text = "Đến ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(37, 23);
            label3.Name = "label3";
            label3.Size = new Size(102, 27);
            label3.TabIndex = 8;
            label3.Text = "Từ ngày";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(panel3);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1258, 625);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thống kê sản phẩm";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(dataGridViewProduct);
            panel4.Location = new Point(3, 74);
            panel4.Name = "panel4";
            panel4.Size = new Size(1252, 448);
            panel4.TabIndex = 8;
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProduct.BackgroundColor = SystemColors.Control;
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Location = new Point(0, 6);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.RowHeadersWidth = 51;
            dataGridViewProduct.Size = new Size(1252, 513);
            dataGridViewProduct.TabIndex = 2;
            dataGridViewProduct.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1252, 71);
            panel3.TabIndex = 1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.DodgerBlue;
            button3.ForeColor = Color.White;
            button3.Location = new Point(981, 3);
            button3.Name = "button3";
            button3.Size = new Size(256, 62);
            button3.TabIndex = 1;
            button3.Text = "Xuất báo cáo";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // QLThongKe
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 663);
            Controls.Add(tabControl1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "QLThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QLThongKe";
            Load += QLThongKe_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvRevenue).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private Panel panel2;
        private Button btnBaocao;
        private Button btnShow;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label3;
        private Panel panel4;
        private Panel panel3;
        private Button button3;
        private DataGridView dtgvRevenue;
        private DataGridView dataGridViewProduct;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox tbDoanhthu;
    }
}