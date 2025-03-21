﻿using Quanly.DAO;
using System.Data.SqlClient;

namespace Quanly
{
    public partial class fAddCustomer : Form
    {
        public fAddCustomer()
        {
            InitializeComponent();
        }
        private int idKhach;
        public fAddCustomer(int idCustomer, string nameCustomer, string phone, string address)
        {
            InitializeComponent();
            this.idKhach = idCustomer;
            tbCustomer.Text = nameCustomer;
            tbphone.Text = phone;
            tbAddress.Text = address;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Ảnh (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg",
                Title = "Chọn ảnh"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(filePath);
                pictureBox1.Tag = filePath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int sex = comboBoxSex.SelectedIndex; // 0: Nam, 1: Nữ
            //MessageBox.Show("tbAge.Text" + tbAge.Text);
            //int age;
            //if (!int.TryParse(tbAge.Text, out age))
            //{
            //    MessageBox.Show("Vui lòng nhập tuổi hợp lệ (số nguyên)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    tbAge.Focus();
            //    return;
            //}

            string filePath = pictureBox1.Tag as string ?? ""; // Lấy đường dẫn ảnh
            if (!check_thongtin()) return;   
            if (CustomerDAO.Instance.checkNumBerCar(textBox2.Text))
            {
                MessageBox.Show("Xe đã tồn tại, vui lòng nhập biển số xe khác", "thông báo", MessageBoxButtons.OK);
                textBox2.Focus();
                return;
            }
            else if (!insert(idKhach,tbCustomer.Text, tbAddress.Text, tbphone.Text, textBox1.Text, textBox2.Text, textBox3.Text, filePath))
            {
                MessageBox.Show("Quá trình thêm đã thất bại do nguyên nhân không rõ", "thông báo", MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show("Đã thêm khách hàng", "thông báo", MessageBoxButtons.OK);
            this.Close();
        }
        public bool insert(int idKhach, string name, string address, string numberphone, string namecar, string numcar, string logo, string filePath)
        {
            if (!DAO.CustomerDAO.Instance.checkidKhach(idKhach))
            {
                return DAO.CustomerDAO.Instance.AddCustomer(name, address, numberphone, namecar, numcar, logo, filePath);
            }
            return DAO.CustomerDAO.Instance.AddCar_Customer(idKhach, name, address, numberphone, namecar, numcar, logo, filePath);
        }
        public bool check_thongtin()
        {
            if (tbCustomer.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên Khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbCustomer.Focus();
                return false;
            }
            if(tbAge.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tuổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbAge.Focus();
                return false;
            }   
            if(comboBoxSex.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxSex.Focus();
                return false;
            }    
            if (tbAddress.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbAddress.Focus();
                return false;
            }
            if (tbphone.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbphone.Focus();
                return false;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
                return false;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Focus();
                return false;
            }
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh xe!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbCustomer.Text = "";
            tbAddress.Text = "";
            tbphone.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            pictureBox1.Image = null;
            pictureBox1.Tag = null;
            tbCustomer.Focus();
        }
    }
}
