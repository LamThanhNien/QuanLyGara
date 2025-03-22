namespace Quanly
{
    partial class fAdmin
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
            tcAdmin = new TabControl();
            tabPageDT = new TabPage();
            dtgvDt = new DataGridView();
            panel1 = new Panel();
            button1 = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            tabPagecar = new TabPage();
            panel2 = new Panel();
            panel7 = new Panel();
            textBox4 = new TextBox();
            labelLogocar = new Label();
            label1 = new Label();
            panel3 = new Panel();
            btnseeCar = new Button();
            btnDeleteCar = new Button();
            btnfixCar = new Button();
            btnAddCar = new Button();
            panel4 = new Panel();
            textBox3 = new TextBox();
            labelNumcar = new Label();
            btnTim = new Button();
            panel5 = new Panel();
            textBox2 = new TextBox();
            labelNamecar = new Label();
            textBoxTim = new TextBox();
            dtgvCar = new DataGridView();
            tpcustomer = new TabPage();
            panel8 = new Panel();
            panel9 = new Panel();
            tbphone = new TextBox();
            labelNumCtm = new Label();
            panel12 = new Panel();
            btnseecustomer = new Button();
            btndeletecustomer = new Button();
            btnfixcustomer = new Button();
            btnAddcustomer = new Button();
            panel10 = new Panel();
            tbAddress = new TextBox();
            labelAdressCtm = new Label();
            panel13 = new Panel();
            btntim2 = new Button();
            textBox8 = new TextBox();
            panel11 = new Panel();
            tbCustomer = new TextBox();
            labelNameCtm = new Label();
            dtgvCustomer = new DataGridView();
            tpService = new TabPage();
            panel16 = new Panel();
            panel20 = new Panel();
            btnSeeSv = new Button();
            btnDeleteSv = new Button();
            btnFixSv = new Button();
            btnAddSv = new Button();
            panel17 = new Panel();
            textBox5 = new TextBox();
            labelPricrSv = new Label();
            panel14 = new Panel();
            comboBox1 = new ComboBox();
            label8 = new Label();
            panel19 = new Panel();
            textBox7 = new TextBox();
            labelNamePt = new Label();
            panel26 = new Panel();
            textBox11 = new TextBox();
            labelNameSv = new Label();
            panel18 = new Panel();
            numericUpDown1 = new NumericUpDown();
            labelQtt = new Label();
            panel15 = new Panel();
            dtgvDv = new DataGridView();
            label9 = new Label();
            tpAccount = new TabPage();
            panel25 = new Panel();
            btnSeeAc = new Button();
            btnDeleteAc = new Button();
            btnFixAc = new Button();
            btnAddAc = new Button();
            panel21 = new Panel();
            btnUpdatePassword = new Button();
            panel22 = new Panel();
            textBox6 = new TextBox();
            labelTypeAc = new Label();
            panel23 = new Panel();
            textBox9 = new TextBox();
            labelDisplayAc = new Label();
            panel24 = new Panel();
            textBox10 = new TextBox();
            labelNameAc = new Label();
            dtgvAccount = new DataGridView();
            tcAdmin.SuspendLayout();
            tabPageDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDt).BeginInit();
            panel1.SuspendLayout();
            tabPagecar.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCar).BeginInit();
            tpcustomer.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel12.SuspendLayout();
            panel10.SuspendLayout();
            panel13.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCustomer).BeginInit();
            tpService.SuspendLayout();
            panel16.SuspendLayout();
            panel20.SuspendLayout();
            panel17.SuspendLayout();
            panel14.SuspendLayout();
            panel19.SuspendLayout();
            panel26.SuspendLayout();
            panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDv).BeginInit();
            tpAccount.SuspendLayout();
            panel25.SuspendLayout();
            panel21.SuspendLayout();
            panel22.SuspendLayout();
            panel23.SuspendLayout();
            panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            SuspendLayout();
            // 
            // tcAdmin
            // 
            tcAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tcAdmin.Controls.Add(tabPageDT);
            tcAdmin.Controls.Add(tabPagecar);
            tcAdmin.Controls.Add(tpcustomer);
            tcAdmin.Controls.Add(tpService);
            tcAdmin.Controls.Add(tpAccount);
            tcAdmin.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tcAdmin.Location = new Point(3, 0);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(1105, 723);
            tcAdmin.TabIndex = 0;
            // 
            // tabPageDT
            // 
            tabPageDT.Controls.Add(dtgvDt);
            tabPageDT.Controls.Add(panel1);
            tabPageDT.Location = new Point(4, 35);
            tabPageDT.Name = "tabPageDT";
            tabPageDT.Padding = new Padding(3);
            tabPageDT.Size = new Size(1097, 684);
            tabPageDT.TabIndex = 0;
            tabPageDT.Text = "Doanh Thu";
            tabPageDT.UseVisualStyleBackColor = true;
            // 
            // dtgvDt
            // 
            dtgvDt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvDt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDt.Location = new Point(3, 71);
            dtgvDt.Name = "dtgvDt";
            dtgvDt.RowHeadersWidth = 62;
            dtgvDt.Size = new Size(1091, 610);
            dtgvDt.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1076, 59);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(917, 13);
            button1.Name = "button1";
            button1.Size = new Size(139, 34);
            button1.TabIndex = 2;
            button1.Text = "Thống kê";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(435, 14);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(395, 33);
            dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 14);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(417, 33);
            dateTimePicker1.TabIndex = 0;
            // 
            // tabPagecar
            // 
            tabPagecar.Controls.Add(panel2);
            tabPagecar.Controls.Add(dtgvCar);
            tabPagecar.Location = new Point(4, 35);
            tabPagecar.Name = "tabPagecar";
            tabPagecar.Padding = new Padding(3);
            tabPagecar.Size = new Size(1097, 684);
            tabPagecar.TabIndex = 1;
            tabPagecar.Text = "Quản lý xe";
            tabPagecar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(btnTim);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(textBoxTim);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(639, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(455, 678);
            panel2.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.Controls.Add(textBox4);
            panel7.Controls.Add(labelLogocar);
            panel7.Location = new Point(31, 239);
            panel7.Name = "panel7";
            panel7.Size = new Size(395, 56);
            panel7.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(139, 15);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(246, 33);
            textBox4.TabIndex = 1;
            // 
            // labelLogocar
            // 
            labelLogocar.AutoSize = true;
            labelLogocar.Location = new Point(14, 15);
            labelLogocar.Name = "labelLogocar";
            labelLogocar.Size = new Size(64, 26);
            labelLogocar.TabIndex = 0;
            labelLogocar.Text = "Logo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(245, 26);
            label1.TabIndex = 5;
            label1.Text = "Nhập biển số xe để tìm";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(btnseeCar);
            panel3.Controls.Add(btnDeleteCar);
            panel3.Controls.Add(btnfixCar);
            panel3.Controls.Add(btnAddCar);
            panel3.Location = new Point(4, 574);
            panel3.Name = "panel3";
            panel3.Size = new Size(451, 101);
            panel3.TabIndex = 2;
            // 
            // btnseeCar
            // 
            btnseeCar.Location = new Point(324, 23);
            btnseeCar.Name = "btnseeCar";
            btnseeCar.Size = new Size(102, 47);
            btnseeCar.TabIndex = 3;
            btnseeCar.Text = "Xem";
            btnseeCar.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCar
            // 
            btnDeleteCar.Location = new Point(216, 23);
            btnDeleteCar.Name = "btnDeleteCar";
            btnDeleteCar.Size = new Size(102, 47);
            btnDeleteCar.TabIndex = 2;
            btnDeleteCar.Text = "Xóa";
            btnDeleteCar.UseVisualStyleBackColor = true;
            // 
            // btnfixCar
            // 
            btnfixCar.Location = new Point(108, 23);
            btnfixCar.Name = "btnfixCar";
            btnfixCar.Size = new Size(102, 47);
            btnfixCar.TabIndex = 1;
            btnfixCar.Text = "Sửa";
            btnfixCar.UseVisualStyleBackColor = true;
            // 
            // btnAddCar
            // 
            btnAddCar.Location = new Point(0, 23);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(102, 47);
            btnAddCar.TabIndex = 0;
            btnAddCar.Text = "Thêm";
            btnAddCar.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(labelNumcar);
            panel4.Location = new Point(31, 177);
            panel4.Name = "panel4";
            panel4.Size = new Size(397, 56);
            panel4.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(139, 15);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(246, 33);
            textBox3.TabIndex = 1;
            // 
            // labelNumcar
            // 
            labelNumcar.AutoSize = true;
            labelNumcar.ImageAlign = ContentAlignment.TopCenter;
            labelNumcar.Location = new Point(14, 15);
            labelNumcar.Name = "labelNumcar";
            labelNumcar.Size = new Size(119, 26);
            labelNumcar.TabIndex = 0;
            labelNumcar.Text = "Biển số xe";
            // 
            // btnTim
            // 
            btnTim.Location = new Point(328, 49);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(95, 48);
            btnTim.TabIndex = 1;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(labelNamecar);
            panel5.Location = new Point(31, 115);
            panel5.Name = "panel5";
            panel5.Size = new Size(394, 56);
            panel5.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 15);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 33);
            textBox2.TabIndex = 1;
            // 
            // labelNamecar
            // 
            labelNamecar.AutoSize = true;
            labelNamecar.Location = new Point(14, 15);
            labelNamecar.Name = "labelNamecar";
            labelNamecar.Size = new Size(82, 26);
            labelNamecar.TabIndex = 0;
            labelNamecar.Text = "Tên xe";
            // 
            // textBoxTim
            // 
            textBoxTim.Location = new Point(38, 57);
            textBoxTim.Name = "textBoxTim";
            textBoxTim.Size = new Size(268, 33);
            textBoxTim.TabIndex = 0;
            // 
            // dtgvCar
            // 
            dtgvCar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCar.Location = new Point(3, 6);
            dtgvCar.Name = "dtgvCar";
            dtgvCar.RowHeadersWidth = 62;
            dtgvCar.Size = new Size(630, 672);
            dtgvCar.TabIndex = 0;
            // 
            // tpcustomer
            // 
            tpcustomer.Controls.Add(panel8);
            tpcustomer.Controls.Add(dtgvCustomer);
            tpcustomer.Location = new Point(4, 35);
            tpcustomer.Name = "tpcustomer";
            tpcustomer.Padding = new Padding(3);
            tpcustomer.Size = new Size(1097, 684);
            tpcustomer.TabIndex = 2;
            tpcustomer.Text = "Khách hàng";
            tpcustomer.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(panel12);
            panel8.Controls.Add(panel10);
            panel8.Controls.Add(panel13);
            panel8.Controls.Add(panel11);
            panel8.Dock = DockStyle.Right;
            panel8.Location = new Point(653, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(441, 678);
            panel8.TabIndex = 10;
            // 
            // panel9
            // 
            panel9.Controls.Add(tbphone);
            panel9.Controls.Add(labelNumCtm);
            panel9.Location = new Point(15, 221);
            panel9.Name = "panel9";
            panel9.Size = new Size(397, 56);
            panel9.TabIndex = 6;
            // 
            // tbphone
            // 
            tbphone.Location = new Point(180, 11);
            tbphone.Name = "tbphone";
            tbphone.Size = new Size(214, 33);
            tbphone.TabIndex = 1;
            // 
            // labelNumCtm
            // 
            labelNumCtm.AutoSize = true;
            labelNumCtm.Location = new Point(3, 18);
            labelNumCtm.Name = "labelNumCtm";
            labelNumCtm.Size = new Size(145, 26);
            labelNumCtm.TabIndex = 0;
            labelNumCtm.Text = "Số điện thoại";
            // 
            // panel12
            // 
            panel12.Controls.Add(btnseecustomer);
            panel12.Controls.Add(btndeletecustomer);
            panel12.Controls.Add(btnfixcustomer);
            panel12.Controls.Add(btnAddcustomer);
            panel12.Location = new Point(7, 578);
            panel12.Name = "panel12";
            panel12.Size = new Size(394, 89);
            panel12.TabIndex = 9;
            // 
            // btnseecustomer
            // 
            btnseecustomer.Location = new Point(301, 29);
            btnseecustomer.Name = "btnseecustomer";
            btnseecustomer.Size = new Size(78, 34);
            btnseecustomer.TabIndex = 3;
            btnseecustomer.Text = "Xem";
            btnseecustomer.UseVisualStyleBackColor = true;
            // 
            // btndeletecustomer
            // 
            btndeletecustomer.Location = new Point(203, 29);
            btndeletecustomer.Name = "btndeletecustomer";
            btndeletecustomer.Size = new Size(78, 34);
            btndeletecustomer.TabIndex = 2;
            btndeletecustomer.Text = "Xóa";
            btndeletecustomer.UseVisualStyleBackColor = true;
            // 
            // btnfixcustomer
            // 
            btnfixcustomer.Location = new Point(100, 29);
            btnfixcustomer.Name = "btnfixcustomer";
            btnfixcustomer.Size = new Size(78, 34);
            btnfixcustomer.TabIndex = 1;
            btnfixcustomer.Text = "Sửa";
            btnfixcustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddcustomer
            // 
            btnAddcustomer.Location = new Point(3, 29);
            btnAddcustomer.Name = "btnAddcustomer";
            btnAddcustomer.Size = new Size(78, 34);
            btnAddcustomer.TabIndex = 0;
            btnAddcustomer.Text = "Thêm";
            btnAddcustomer.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            panel10.Controls.Add(tbAddress);
            panel10.Controls.Add(labelAdressCtm);
            panel10.Location = new Point(15, 159);
            panel10.Name = "panel10";
            panel10.Size = new Size(397, 56);
            panel10.TabIndex = 5;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(180, 12);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(214, 33);
            tbAddress.TabIndex = 1;
            // 
            // labelAdressCtm
            // 
            labelAdressCtm.AutoSize = true;
            labelAdressCtm.ImageAlign = ContentAlignment.TopCenter;
            labelAdressCtm.Location = new Point(3, 15);
            labelAdressCtm.Name = "labelAdressCtm";
            labelAdressCtm.Size = new Size(81, 26);
            labelAdressCtm.TabIndex = 0;
            labelAdressCtm.Text = "Địa chỉ";
            // 
            // panel13
            // 
            panel13.Controls.Add(btntim2);
            panel13.Controls.Add(textBox8);
            panel13.Location = new Point(15, 15);
            panel13.Name = "panel13";
            panel13.Size = new Size(400, 67);
            panel13.TabIndex = 8;
            // 
            // btntim2
            // 
            btntim2.Location = new Point(262, 15);
            btntim2.Name = "btntim2";
            btntim2.Size = new Size(110, 34);
            btntim2.TabIndex = 1;
            btntim2.Text = "Tìm";
            btntim2.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(14, 15);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(233, 33);
            textBox8.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.Controls.Add(tbCustomer);
            panel11.Controls.Add(labelNameCtm);
            panel11.Location = new Point(15, 97);
            panel11.Name = "panel11";
            panel11.Size = new Size(397, 56);
            panel11.TabIndex = 4;
            // 
            // tbCustomer
            // 
            tbCustomer.Location = new Point(180, 12);
            tbCustomer.Name = "tbCustomer";
            tbCustomer.Size = new Size(214, 33);
            tbCustomer.TabIndex = 1;
            // 
            // labelNameCtm
            // 
            labelNameCtm.AutoSize = true;
            labelNameCtm.Location = new Point(3, 15);
            labelNameCtm.Name = "labelNameCtm";
            labelNameCtm.Size = new Size(181, 26);
            labelNameCtm.TabIndex = 0;
            labelNameCtm.Text = "Tên Khách hàng";
            // 
            // dtgvCustomer
            // 
            dtgvCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCustomer.Location = new Point(6, 6);
            dtgvCustomer.Name = "dtgvCustomer";
            dtgvCustomer.RowHeadersWidth = 62;
            dtgvCustomer.Size = new Size(641, 672);
            dtgvCustomer.TabIndex = 7;
            // 
            // tpService
            // 
            tpService.Controls.Add(panel16);
            tpService.Controls.Add(panel15);
            tpService.Location = new Point(4, 35);
            tpService.Name = "tpService";
            tpService.Padding = new Padding(3);
            tpService.Size = new Size(1097, 684);
            tpService.TabIndex = 3;
            tpService.Text = "Dịch vụ";
            tpService.UseVisualStyleBackColor = true;
            // 
            // panel16
            // 
            panel16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel16.Controls.Add(panel20);
            panel16.Controls.Add(panel17);
            panel16.Controls.Add(panel14);
            panel16.Controls.Add(panel19);
            panel16.Controls.Add(panel26);
            panel16.Controls.Add(panel18);
            panel16.Location = new Point(673, 6);
            panel16.Name = "panel16";
            panel16.Size = new Size(418, 670);
            panel16.TabIndex = 11;
            // 
            // panel20
            // 
            panel20.Controls.Add(btnSeeSv);
            panel20.Controls.Add(btnDeleteSv);
            panel20.Controls.Add(btnFixSv);
            panel20.Controls.Add(btnAddSv);
            panel20.Location = new Point(6, 567);
            panel20.Name = "panel20";
            panel20.Size = new Size(406, 89);
            panel20.TabIndex = 12;
            // 
            // btnSeeSv
            // 
            btnSeeSv.Location = new Point(301, 29);
            btnSeeSv.Name = "btnSeeSv";
            btnSeeSv.Size = new Size(78, 34);
            btnSeeSv.TabIndex = 3;
            btnSeeSv.Text = "Xem";
            btnSeeSv.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSv
            // 
            btnDeleteSv.Location = new Point(203, 29);
            btnDeleteSv.Name = "btnDeleteSv";
            btnDeleteSv.Size = new Size(78, 34);
            btnDeleteSv.TabIndex = 2;
            btnDeleteSv.Text = "Xóa";
            btnDeleteSv.UseVisualStyleBackColor = true;
            // 
            // btnFixSv
            // 
            btnFixSv.Location = new Point(100, 29);
            btnFixSv.Name = "btnFixSv";
            btnFixSv.Size = new Size(78, 34);
            btnFixSv.TabIndex = 1;
            btnFixSv.Text = "Sửa";
            btnFixSv.UseVisualStyleBackColor = true;
            // 
            // btnAddSv
            // 
            btnAddSv.Location = new Point(3, 29);
            btnAddSv.Name = "btnAddSv";
            btnAddSv.Size = new Size(78, 34);
            btnAddSv.TabIndex = 0;
            btnAddSv.Text = "Thêm";
            btnAddSv.UseVisualStyleBackColor = true;
            // 
            // panel17
            // 
            panel17.Controls.Add(textBox5);
            panel17.Controls.Add(labelPricrSv);
            panel17.Location = new Point(9, 338);
            panel17.Name = "panel17";
            panel17.Size = new Size(406, 56);
            panel17.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(139, 15);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(264, 33);
            textBox5.TabIndex = 1;
            // 
            // labelPricrSv
            // 
            labelPricrSv.AutoSize = true;
            labelPricrSv.Location = new Point(3, 18);
            labelPricrSv.Name = "labelPricrSv";
            labelPricrSv.Size = new Size(46, 26);
            labelPricrSv.TabIndex = 0;
            labelPricrSv.Text = "Giá";
            // 
            // panel14
            // 
            panel14.Controls.Add(comboBox1);
            panel14.Controls.Add(label8);
            panel14.Location = new Point(9, 12);
            panel14.Name = "panel14";
            panel14.Size = new Size(409, 108);
            panel14.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(5, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(398, 34);
            comboBox1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 12);
            label8.Name = "label8";
            label8.Size = new Size(186, 26);
            label8.TabIndex = 2;
            label8.Text = "Chọn tên dịch vụ";
            // 
            // panel19
            // 
            panel19.Controls.Add(textBox7);
            panel19.Controls.Add(labelNamePt);
            panel19.Location = new Point(9, 211);
            panel19.Name = "panel19";
            panel19.Size = new Size(406, 56);
            panel19.TabIndex = 4;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(139, 15);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(264, 33);
            textBox7.TabIndex = 1;
            // 
            // labelNamePt
            // 
            labelNamePt.AutoSize = true;
            labelNamePt.Location = new Point(3, 15);
            labelNamePt.Name = "labelNamePt";
            labelNamePt.Size = new Size(159, 26);
            labelNamePt.TabIndex = 0;
            labelNamePt.Text = "Tên Phụ Tùng";
            // 
            // panel26
            // 
            panel26.Controls.Add(textBox11);
            panel26.Controls.Add(labelNameSv);
            panel26.Location = new Point(9, 149);
            panel26.Name = "panel26";
            panel26.Size = new Size(406, 56);
            panel26.TabIndex = 6;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(139, 15);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(264, 33);
            textBox11.TabIndex = 1;
            // 
            // labelNameSv
            // 
            labelNameSv.AutoSize = true;
            labelNameSv.Location = new Point(3, 15);
            labelNameSv.Name = "labelNameSv";
            labelNameSv.Size = new Size(133, 26);
            labelNameSv.TabIndex = 0;
            labelNameSv.Text = "Tên dịch vụ";
            // 
            // panel18
            // 
            panel18.Controls.Add(numericUpDown1);
            panel18.Controls.Add(labelQtt);
            panel18.Location = new Point(9, 273);
            panel18.Name = "panel18";
            panel18.Size = new Size(406, 56);
            panel18.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(139, 13);
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(91, 33);
            numericUpDown1.TabIndex = 1;
            // 
            // labelQtt
            // 
            labelQtt.AutoSize = true;
            labelQtt.ImageAlign = ContentAlignment.TopCenter;
            labelQtt.Location = new Point(3, 15);
            labelQtt.Name = "labelQtt";
            labelQtt.Size = new Size(109, 26);
            labelQtt.TabIndex = 0;
            labelQtt.Text = "Số lượng";
            // 
            // panel15
            // 
            panel15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel15.Controls.Add(dtgvDv);
            panel15.Controls.Add(label9);
            panel15.Location = new Point(6, 6);
            panel15.Name = "panel15";
            panel15.Size = new Size(667, 672);
            panel15.TabIndex = 5;
            // 
            // dtgvDv
            // 
            dtgvDv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvDv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDv.Location = new Point(7, 52);
            dtgvDv.Name = "dtgvDv";
            dtgvDv.RowHeadersWidth = 62;
            dtgvDv.Size = new Size(654, 617);
            dtgvDv.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 12);
            label9.Name = "label9";
            label9.Size = new Size(400, 26);
            label9.TabIndex = 4;
            label9.Text = "Các phụ tùng  cho dịch vụ được chọn";
            // 
            // tpAccount
            // 
            tpAccount.Controls.Add(panel25);
            tpAccount.Controls.Add(panel21);
            tpAccount.Controls.Add(dtgvAccount);
            tpAccount.Location = new Point(4, 35);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(1097, 684);
            tpAccount.TabIndex = 4;
            tpAccount.Text = "Account";
            tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel25
            // 
            panel25.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel25.Controls.Add(btnSeeAc);
            panel25.Controls.Add(btnDeleteAc);
            panel25.Controls.Add(btnFixAc);
            panel25.Controls.Add(btnAddAc);
            panel25.Location = new Point(6, 587);
            panel25.Name = "panel25";
            panel25.Size = new Size(552, 89);
            panel25.TabIndex = 12;
            // 
            // btnSeeAc
            // 
            btnSeeAc.Location = new Point(414, 29);
            btnSeeAc.Name = "btnSeeAc";
            btnSeeAc.Size = new Size(135, 34);
            btnSeeAc.TabIndex = 3;
            btnSeeAc.Text = "Xem";
            btnSeeAc.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAc
            // 
            btnDeleteAc.Location = new Point(279, 29);
            btnDeleteAc.Name = "btnDeleteAc";
            btnDeleteAc.Size = new Size(135, 34);
            btnDeleteAc.TabIndex = 2;
            btnDeleteAc.Text = "Xóa";
            btnDeleteAc.UseVisualStyleBackColor = true;
            // 
            // btnFixAc
            // 
            btnFixAc.Location = new Point(144, 29);
            btnFixAc.Name = "btnFixAc";
            btnFixAc.Size = new Size(135, 34);
            btnFixAc.TabIndex = 1;
            btnFixAc.Text = "Sửa";
            btnFixAc.UseVisualStyleBackColor = true;
            // 
            // btnAddAc
            // 
            btnAddAc.Location = new Point(3, 29);
            btnAddAc.Name = "btnAddAc";
            btnAddAc.Size = new Size(135, 34);
            btnAddAc.TabIndex = 0;
            btnAddAc.Text = "Thêm";
            btnAddAc.UseVisualStyleBackColor = true;
            // 
            // panel21
            // 
            panel21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel21.Controls.Add(btnUpdatePassword);
            panel21.Controls.Add(panel22);
            panel21.Controls.Add(panel23);
            panel21.Controls.Add(panel24);
            panel21.Location = new Point(586, 6);
            panel21.Name = "panel21";
            panel21.Size = new Size(505, 269);
            panel21.TabIndex = 11;
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdatePassword.Location = new Point(261, 203);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(230, 34);
            btnUpdatePassword.TabIndex = 13;
            btnUpdatePassword.Text = "Đặt Lại Mật Khẩu";
            btnUpdatePassword.UseVisualStyleBackColor = true;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // panel22
            // 
            panel22.Controls.Add(textBox6);
            panel22.Controls.Add(labelTypeAc);
            panel22.Location = new Point(3, 127);
            panel22.Name = "panel22";
            panel22.Size = new Size(499, 56);
            panel22.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(171, 11);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(230, 33);
            textBox6.TabIndex = 1;
            // 
            // labelTypeAc
            // 
            labelTypeAc.AutoSize = true;
            labelTypeAc.Location = new Point(3, 18);
            labelTypeAc.Name = "labelTypeAc";
            labelTypeAc.Size = new Size(145, 26);
            labelTypeAc.TabIndex = 0;
            labelTypeAc.Text = "Loại Account";
            // 
            // panel23
            // 
            panel23.Controls.Add(textBox9);
            panel23.Controls.Add(labelDisplayAc);
            panel23.Location = new Point(3, 65);
            panel23.Name = "panel23";
            panel23.Size = new Size(499, 56);
            panel23.TabIndex = 5;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(170, 15);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(230, 33);
            textBox9.TabIndex = 1;
            // 
            // labelDisplayAc
            // 
            labelDisplayAc.AutoSize = true;
            labelDisplayAc.ImageAlign = ContentAlignment.TopCenter;
            labelDisplayAc.Location = new Point(3, 15);
            labelDisplayAc.Name = "labelDisplayAc";
            labelDisplayAc.Size = new Size(135, 26);
            labelDisplayAc.TabIndex = 0;
            labelDisplayAc.Text = "Tên Hiển thị";
            // 
            // panel24
            // 
            panel24.Controls.Add(textBox10);
            panel24.Controls.Add(labelNameAc);
            panel24.Location = new Point(3, 3);
            panel24.Name = "panel24";
            panel24.Size = new Size(499, 56);
            panel24.TabIndex = 4;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(171, 12);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(230, 33);
            textBox10.TabIndex = 1;
            // 
            // labelNameAc
            // 
            labelNameAc.AutoSize = true;
            labelNameAc.Location = new Point(3, 15);
            labelNameAc.Name = "labelNameAc";
            labelNameAc.Size = new Size(166, 26);
            labelNameAc.TabIndex = 0;
            labelNameAc.Text = "Tên đăng nhập";
            // 
            // dtgvAccount
            // 
            dtgvAccount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(6, 6);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersWidth = 62;
            dtgvAccount.Size = new Size(574, 575);
            dtgvAccount.TabIndex = 0;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 723);
            Controls.Add(tcAdmin);
            Name = "fAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fAdmin";
            Load += fAdmin_Load;
            tcAdmin.ResumeLayout(false);
            tabPageDT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvDt).EndInit();
            panel1.ResumeLayout(false);
            tabPagecar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCar).EndInit();
            tpcustomer.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel12.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCustomer).EndInit();
            tpService.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvDv).EndInit();
            tpAccount.ResumeLayout(false);
            panel25.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel23.ResumeLayout(false);
            panel23.PerformLayout();
            panel24.ResumeLayout(false);
            panel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcAdmin;
        private TabPage tabPageDT;
        private TabPage tabPagecar;
        private TabPage tpcustomer;
        private TabPage tpService;
        private DataGridView dtgvDt;
        private Panel panel1;
        private Button button1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TabPage tpAccount;
        private Panel panel2;
        private TextBox textBoxTim;
        private DataGridView dtgvCar;
        private Panel panel5;
        private TextBox textBox2;
        private Label labelNamecar;
        private Panel panel3;
        private Label label1;
        private Button btnTim;
        private Panel panel7;
        private TextBox textBox4;
        private Label labelLogocar;
        private Panel panel4;
        private TextBox textBox3;
        private Label labelNumcar;
        private Button btnseeCar;
        private Button btnDeleteCar;
        private Button btnfixCar;
        private Button btnAddCar;
        private Panel panel8;
        private Panel panel9;
        private TextBox tbphone;
        private Label labelNumCtm;
        private Panel panel10;
        private TextBox tbAddress;
        private Label labelAdressCtm;
        private Panel panel11;
        private TextBox tbCustomer;
        private Label labelNameCtm;
        private Panel panel12;
        private Button btnseecustomer;
        private Button btndeletecustomer;
        private Button btnfixcustomer;
        private Button btnAddcustomer;
        private Panel panel13;
        private Button btntim2;
        private TextBox textBox8;
        private DataGridView dtgvCustomer;
        private ComboBox comboBox1;
        private Panel panel14;
        private Label label8;
        private Label label9;
        private Panel panel20;
        private Button btnSeeSv;
        private Button btnDeleteSv;
        private Button btnFixSv;
        private Button btnAddSv;
        private Panel panel16;
        private Panel panel17;
        private TextBox textBox5;
        private Label labelPricrSv;
        private Panel panel18;
        private NumericUpDown numericUpDown1;
        private Label labelQtt;
        private Panel panel19;
        private TextBox textBox7;
        private Label labelNamePt;
        private Panel panel15;
        private Panel panel21;
        private Panel panel22;
        private TextBox textBox6;
        private Label labelTypeAc;
        private Panel panel23;
        private TextBox textBox9;
        private Label labelDisplayAc;
        private Panel panel24;
        private TextBox textBox10;
        private Label labelNameAc;
        private DataGridView dtgvAccount;
        private Button btnUpdatePassword;
        private Panel panel25;
        private Button btnSeeAc;
        private Button btnDeleteAc;
        private Button btnFixAc;
        private Button btnAddAc;
        private Panel panel26;
        private TextBox textBox11;
        private Label labelNameSv;
        private DataGridView dtgvDv;
    }
}