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
            LoadMaterial();

            LoadCombobox_Service();
        }
        //Phân load các tapcontrol
        void loadThanhToan()
        {
            string query = @"
            SELECT 
                cs.name, 
                cs.address, 
                cs.phoneNum, 
                c.name AS namecar, 
                c.numberCar, 
                c.logo,
                cs.idCustomer
            FROM Customer cs 
            INNER JOIN Car c ON cs.idCustomer = c.idCustomer
            ";
            dtgvCustomer.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtgvCustomer.Columns[0].Width = 250;
            dtgvCustomer.Columns[0].HeaderText = "Tên Khách hàng";
            dtgvCustomer.Columns[1].Width = 300;
            dtgvCustomer.Columns[1].HeaderText = "Địa chỉ";
            dtgvCustomer.Columns[2].Width = 150;
            dtgvCustomer.Columns[2].HeaderText = "Số điện thoại";
            dtgvCustomer.Columns[3].Width = 150;
            dtgvCustomer.Columns[3].HeaderText = "Tên xe";
            dtgvCustomer.Columns[4].Width = 150;
            dtgvCustomer.Columns[4].HeaderText = "Số xe";
            dtgvCustomer.Columns[5].Width = 150;
            dtgvCustomer.Columns[5].HeaderText = "Tên hãng";
        }
        //LEFT JOIN Bill b ON b.idCar = c.idCar
        //    where b.DateCheckOut IS NULL
        void loadCar()
        {
            string query = "SELECT cs.name, c.name as namecar,c.numberCar,cs.address,cs.phoneNum, c.ImageBase64\r\nFROM Customer cs \r\nINNER JOIN Car c ON cs.idCustomer = c.idCustomer;";
            dtgvCar.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void LoadMaterial()
        {
            string query = "SELECT * FROM Material";
            dtgvMaterial.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        //
        //Phần Load Combobox
        void LoadCombobox_Service()
        {
            string query = "SELECT idService, name FROM _Service";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
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
            string query = @"SELECT M.idMaterial, M.name 
                     FROM Material M 
                     INNER JOIN Service_Material SM 
                     ON M.idMaterial = SM.idMaterial 
                     WHERE SM.idService = @idService";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idService });
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
        //


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
        //Phần timd kiếm
        private void btntim_Click_1(object sender, EventArgs e)
        {
            DAO.Search.searchDataGridView(dtgvCustomer, "phoneNum", textBox8.Text);
            if (dtgvCustomer.Rows.Count > 0)
            {
                dtgvCustomer_CellClick(null, new DataGridViewCellEventArgs(0, 0));
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            DAO.Search.searchDataGridView(dtgvCar, "name", textBox5.Text);
            if (dtgvCar.Rows.Count > 0)
            {
                dtgvCar_CellClick(null, new DataGridViewCellEventArgs(0, 0));
            }
            else
            {
                tbCustomer1.Text = "";
                tbNCar1.Text = "";
                tbNumCar1.Text = "";
                tbAddress1.Text = "";
                tbphone1.Text = "";
                pictureBox1.Image = Image.FromFile("");
            }
        }
        private void fManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //
        //Phần dtgv
        private void dtgvCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvCar.Rows.Count > 0)
            {
                DataGridViewRow row = dtgvCar.Rows[e.RowIndex];
                tbCustomer1.Text = row.Cells["name"].Value?.ToString();
                tbNCar1.Text = row.Cells["namecar"].Value?.ToString();
                tbNumCar1.Text = row.Cells["numberCar"].Value?.ToString();
                tbAddress1.Text = row.Cells["address"].Value?.ToString();
                tbphone1.Text = row.Cells["phoneNum"].Value?.ToString();
                pictureBox1.Image = Image.FromFile(row.Cells["ImageBase64"].Value?.ToString());
            }

        }
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
                BillInfoDAO.Instance.InsertBillInfo(idBill, IdService, IdMaterial, count);
                showBill(idBill);
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

            if (status == 0) // Hóa đơn chưa thanh toán
            {
                DialogResult check = MessageBox.Show(
                    "Thanh toán cho Khách hàng: " + tbCtm.Text + "\nTổng hóa đơn là: " + tbTotal.Text,
                    "Xác nhận Thanh toán", MessageBoxButtons.YesNo);

                if (check == DialogResult.Yes)
                {
                    string query = "USP_ThanhToan @idBill";
                    int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBill });

                    if (result > 0)
                    {
                        MessageBox.Show("Thanh Toán Hoàn Tất!");
                        loadThanhToan();
                        listViewPrice.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Thanh toán thất bại. Vui lòng thử lại.");
                    }
                }
            }
            else if (status == 1) // Hóa đơn đã thanh toán một phần
            {
                string query = "USP_lastBill @idBill";
                object lastTotal = DataProvider.Instance.ExecuteScalar(query, new object[] { idBill });
                int totalLast = (lastTotal != null && lastTotal != DBNull.Value) ? Convert.ToInt32(lastTotal) : 0;
                if (totalLast <= 0)
                {
                    MessageBox.Show("Không có sản phẩm mới nào cần thanh toán");
                    return;
                }
                DialogResult check = MessageBox.Show("Khách hàng " + tbCtm.Text + " đã thanh toán trước đó." +
                    "\nSố tiền còn lại phải thanh toán: " + totalLast.ToString("N0") + " VND",
                    "Xác nhận Thanh toán", MessageBoxButtons.YesNo);
                if (check == DialogResult.Yes)
                {
                    string updateQuery = "USP_UpdateBillInfo @idBill";
                    int result = DataProvider.Instance.ExecuteNonQuery(updateQuery, new object[] { idBill });

                    if (result > 0)
                    {
                        MessageBox.Show("Thanh Toán Hoàn Tất!");
                        loadThanhToan();
                        listViewPrice.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Thanh toán thất bại. Vui lòng thử lại.");
                    }
                }
            }
        }
        private void AddCar_Click(object sender, EventArgs e)
        {
            string nameCustomer = tbCustomer1.Text;
            string phone = tbphone1.Text;
            string address = tbAddress1.Text;
            fAddCustomer fAdd = new fAddCustomer(nameCustomer, phone, address);
            fAdd.ShowDialog();
            this.Show();

        }
    }
    //
}

