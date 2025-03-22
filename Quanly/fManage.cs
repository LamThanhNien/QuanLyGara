using Microsoft.VisualBasic.Logging;
using Quanly.DAO;
using Quanly.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quanly
{
    public partial class fManage : Form
    {
        public fManage()
        {
            InitializeComponent();
            loadThanhToan();
            loadCar();
            loadCustomer();
            LoadMaterial();
            LoadCombobox_Service();
        }
        //Phân load các tapcontrol
        void loadThanhToan()
        {
            DAO.ThanhToanDAO.Instance.LoadDL(dtgvCustomer);
        }
        void loadCar()
        {
            DAO.CarDAO.Instance.LoadDL(dtgvCar);
        }
        void loadCustomer()
        {
            DAO.CustomerDAO.Instance.LoadDL(dtgvCustomer0);
        }
        void LoadMaterial()
        {
            DAO.MaterialDAO.Instance.LoadDL(dtgvService);
        }

        //
        //Phần Load Combobox
        void LoadCombobox_Service()
        {
            DataTable data = DAO.ServiceDAO.Instance.LoadDL();
            comboBox1.DataSource = data;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "idService";
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
                int idService = Convert.ToInt32(comboBox1.SelectedValue);
                LoadCombobox_Material(idService);
            }
        }

        void LoadCombobox_Material(int idService)
        {
            DataTable data = DAO.MaterialDAO.Instance.ComboBoxLoad(idService);
            comboBox2.DataSource = data;
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "idMaterial";

            if (comboBox2.Items.Count > 0)
            {
                comboBox2.SelectedIndex = 0;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                int idService = Convert.ToInt32(comboBox1.SelectedValue);
                LoadCombobox_Material(idService);
            }
        }

        void showBill(int idCustomer)
        {
            listViewPrice.Items.Clear();
            tbTotal.Clear();
            int idBIll = DAO.BillDAO.Instance.GetIdBill(idCustomer);

            List<DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(idBIll);
            float totalPrice = 0;

            foreach (DTO.Menu item in listBillInfo)
            {
                ListViewItem lvItem = new ListViewItem(item.Name);
                lvItem.SubItems.Add(item.Count.ToString());
                lvItem.SubItems.Add(item.Price.ToString("N0"));
                lvItem.SubItems.Add(item.TotalPrice.ToString("N0"));
                totalPrice += item.TotalPrice;
                listViewPrice.Items.Add(lvItem);
            }

            tbTotal.Text = totalPrice.ToString("c", new CultureInfo("vi-VN"));
        }


        //Phần chuyển giao diện
        private void button1_Click(object sender, EventArgs e)
        {
            fAddCustomer fAdd = new fAddCustomer();
            fAdd.ShowDialog();
            loadThanhToan();
            loadCar();
            loadCustomer();
            LoadMaterial();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAdmin fAdmin = new fAdmin();
            fAdmin.ShowDialog();
            this.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            fAccountProfile fAccountProfile = new fAccountProfile();
            fAccountProfile.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chứ", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();

            }
        }
        private void fManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }




        //Phần timd kiếm
        private void btntim_Click_1(object sender, EventArgs e)
        {
            DAO.Search.searchDataGridView(dtgvCustomer, "phoneNum", textBox8.Text);
            if (dtgvCustomer.Rows.Count > 0)
            {
                dtgvCustomer_CellClick(null, new DataGridViewCellEventArgs(0, 0));
            }
        }
        //
        //Phần dtgv

        int idCustomer;
        private void dtgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvCustomer.Rows.Count > 0)
            {
                DataGridViewRow row = dtgvCustomer.Rows[e.RowIndex];

                tbCtm.Text = row.Cells["name"].Value?.ToString();
                textBox19.Text = row.Cells["numberCar"].Value?.ToString();

                // Lấy idCustomer từ DataGridView
                object idValue = row.Cells["idCustomer"].Value;
                idCustomer = (idValue != DBNull.Value && idValue != null) ? Convert.ToInt32(idValue) : 0;

                if (idCustomer > 0)
                {
                    showBill(idCustomer); // Gọi hàm hiển thị hóa đơn
                }
                else
                {
                    MessageBox.Show("Khách hàng chưa có hóa đơn!");
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            DAO.Search.searchDataGridView(dtgvCar, "numberCar", textBox5.Text);
            if (dtgvCar.Rows.Count > 0)
            {
                dtgvCar_CellClick(null, new DataGridViewCellEventArgs(0, 0));
            }
            else
            {
                tbCustomer1.Text = "";
                tbNCar1.Text = "";
                tbNumCar1.Text = "";
                tbColor.Text = "";
                tbphone1.Text = "";
                pictureBoxCar.Image = Image.FromFile("");
            }
        }
        int idKhach = 0;
        int idCar = 0;
        private void dtgvCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvCar.Rows.Count > 0)
            {
                DataGridViewRow row = dtgvCar.Rows[e.RowIndex];
                tbCustomer1.Text = row.Cells["name"].Value?.ToString();
                tbNCar1.Text = row.Cells["namecar"].Value?.ToString();
                tbNumCar1.Text = row.Cells["numberCar"].Value?.ToString();
                tbColor.Text = row.Cells["address"].Value?.ToString();
                tbphone1.Text = row.Cells["phoneNum"].Value?.ToString();
                //pictureBoxCar.Image = Image.FromFile(row.Cells["ImageBase64"].Value?.ToString());
                string imagePath = row.Cells["ImageBase64"].Value?.ToString();
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    pictureBoxCar.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBoxCar.Image = null; // Không có ảnh thì xóa ảnh cũ
                }
                object value = row.Cells["idCustomer"].Value;
                idKhach = (value != null && value != DBNull.Value) ? Convert.ToInt32(value) : 0;
                object value1 = row.Cells["idCar"].Value;
                idCar = (value != null && value1 != DBNull.Value) ? Convert.ToInt32(value1) : 0;
            }

        }
        private void Search_Click(object sender, EventArgs e)
        {
            DAO.Search.searchDataGridView(dtgvCustomer0, "phoneNum", textBox6.Text);
            if (dtgvCustomer0.Rows.Count > 0)
            {
                dtgvCustomer0_CellClick(null, new DataGridViewCellEventArgs(0, 0));
            }
            else
            {
                tbn.Text = "";
                tbAdr.Text = "";
                tbPhone.Text = "";
            }
        }
        int idCtm = 0;
        private void dtgvCustomer0_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvCustomer0.Rows.Count > 0)
            {
                DataGridViewRow row = dtgvCustomer0.Rows[e.RowIndex];

                // Kiểm tra và gán giá trị an toàn
                tbn.Text = row.Cells["name"].Value?.ToString() ?? "";
                tbAdr.Text = row.Cells["address"].Value?.ToString() ?? "";
                tbPhone.Text = row.Cells["phoneNum"].Value?.ToString() ?? "";
                object value = row.Cells["idCustomer"].Value;
                idCtm = (value != null && value != DBNull.Value) ? Convert.ToInt32(value) : 0;
            }
        }
        private void tim_Click(object sender, EventArgs e)
        {
            DAO.Search.searchDataGridView(dtgvService, "name", tbSv.Text);
            if (dtgvService.Rows.Count > 0)
            {
                dtgvService_CellClick(null, new DataGridViewCellEventArgs(0, 0));
            }
            else
            {
                tbnameSv.Text = "";
                tbPrice.Text = "";
                tbQuantity.Text = "";
                tbXuatsu.Text = "";
                tbType.Text = "";

            }
        }
        private void dtgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvService.Rows.Count > 0)
            {
                DataGridViewRow row = dtgvService.Rows[e.RowIndex];
                tbnameSv.Text = row.Cells["name"].Value?.ToString() ?? "";
                tbType.Text = row.Cells["type"].Value?.ToString() ?? "";
                tbXuatsu.Text = row.Cells["NoiSx"].Value?.ToString() ?? "";
                tbQuantity.Text = row.Cells["quantity"].Value?.ToString() ?? "";
                tbPrice.Text = row.Cells["price"].Value?.ToString() ?? "";
            }
        }


        private void ThemBill_Click(object sender, EventArgs e)
        {
            int idBill = BillDAO.Instance.GetIdBill(idCustomer);
            int IdService = comboBox1.SelectedValue != null ? Convert.ToInt32(comboBox1.SelectedValue) : -1;
            int IdMaterial = comboBox2.SelectedValue != null ? Convert.ToInt32(comboBox2.SelectedValue) : -1;
            int count = (int)numericUpDown1.Value;

            if (idBill <= 0)
            {
                idBill = BillDAO.Instance.InsertBill(idCustomer);
            }

            if (idBill > 0)
            {
                int status = BillDAO.Instance.GetStatus(idCustomer); // Kiểm tra trạng thái hóa đơn
                BillInfoDAO.Instance.InsertBillInfo(idBill, IdService, IdMaterial, count);

                // Chỉ cập nhật số lượng mới thêm nếu hóa đơn đã thanh toán
                if (status == 1)
                {
                    DAO.BillInfoDAO.Instance.UpdateBillInfo(0, idBill, IdMaterial);
                    showBill(idCustomer);
                }
            }
        }



        private void Thanhtoan_Click(object sender, EventArgs e)
        {
            int status = BillDAO.Instance.GetStatus(idCustomer);
            int idBill = DAO.BillDAO.Instance.GetIdBill(idCustomer);

            if (idBill <= 0)
            {
                MessageBox.Show("Không tìm thấy hóa đơn cho khách hàng này!");
                return;
            }
            if (tbTotal.Text == "0 ₫")
            {
                MessageBox.Show("Không có sản phẩm nào cần thanh toán", "thông báo", MessageBoxButtons.OK);
                return;
            }

            DialogResult check = MessageBox.Show("Thanh toán cho Khách hàng Tên: " + tbCtm.Text + "\nTổng hóa đơn phải thanh toán là: " + tbTotal.Text, "Xác nhận Thanh toán", MessageBoxButtons.YesNo);

            if (check == DialogResult.Yes)
            {
                int result = DAO.ThanhToanDAO.Instance.ThanhToan(idBill);
                if (result > 0)
                {
                    DAO.BillInfoDAO.Instance.UpdateBillInfo(1, idBill, 0);
                    MessageBox.Show("Thanh Toán Hoàn Tất!");
                    showBill(idCustomer);
                    listViewPrice.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Thanh toán thất bại. Vui lòng thử lại.");
                }
            }
        }
        //Phần Tap Car



        private void AddCar_Click(object sender, EventArgs e)
        {
            int Idcustomer = idKhach;
            string nameCustomer = tbCustomer1.Text;
            string phone = tbphone1.Text;
            string address = tbColor.Text;
            fAddCustomer fAdd = new fAddCustomer(Idcustomer, nameCustomer, phone, address);
            fAdd.ShowDialog();
            loadThanhToan();
            loadCar();
            this.Show();

        }
        private void btnAddImage1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Ảnh (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg",
                Title = "Chọn ảnh"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                pictureBoxCar.Image = Image.FromFile(filePath);
                pictureBoxCar.Tag = filePath;
            }
        }
        private void btnFix0_Click(object sender, EventArgs e)
        {
            int idCarr = idCar;
            if (idCar == -1) { MessageBox.Show("Không tìm thấy xe"); return; }
            string name = tbNCar1.Text;
            string numcar = tbNumCar1.Text;
            string color = tbColor.Text;
            string image = pictureBoxCar.Tag as string ?? "";
            DAO.CarDAO.Instance.FixCar(idCarr, name, numcar, color, image);
            loadCar();
        }

        private void btnDelete0_Click(object sender, EventArgs e)
        {
            pictureBoxCar.Image = null;
            tbCustomer1.Text = "";
            tbphone1.Text = "";
            tbNCar1.Text = "";
            tbNumCar1.Text = "";
            tbColor.Text = "";

        }

        //Phần tap Khách Hàng

        private void btnFix_Click(object sender, EventArgs e)
        {
            int idCtms = idCtm;
            string name = tbn.Text;
            string address = tbAdr.Text;
            string phone = tbPhone.Text;
            DAO.CustomerDAO.Instance.FixCustomer(idCtms, name, address, phone);
            loadCustomer();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = 0;
            string name = tbnameSv.Text;
            string type = tbType.Text;
            string noiSX = tbXuatsu.Text;
            int sl = Convert.ToInt32(tbQuantity.Text);
            decimal gia = Convert.ToDecimal(tbPrice);
            DAO.MaterialDAO.Instance.Insert_Material(id, name, type, noiSX, sl, gia);
            LoadMaterial();
        }
    }
}

