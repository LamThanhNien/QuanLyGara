using Quanly.DAO;
using Quanly.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quanly
{
    public partial class fThanhToan : Form
    {
        public fThanhToan()
        {
            InitializeComponent();
        }
        void loadThanhToan()
        {
            DAO.ThanhToanDAO.Instance.LoadDL(dtgvCustomer);
        }
        private void fThanhToan_Load(object sender, EventArgs e)
        {
            loadThanhToan();
            dtgvCustomer_CellClick(null, new DataGridViewCellEventArgs(0, 0));
            LoadCombobox_Service();
        }

        void LoadCombobox_Service()
        {
            DataTable data = DAO.ServiceDAO.Instance.LoadDL();
            comboBoxLoad.DataSource = data;
            comboBoxLoad.DisplayMember = "name";
            comboBoxLoad.ValueMember = "idService";
            comboBoxLoad.DataSource = data;
            comboBoxLoad.DisplayMember = "name";
            comboBoxLoad.ValueMember = "idService";
            if (comboBoxLoad.Items.Count > 0)
            {
                comboBoxLoad.SelectedIndex = 0;
                int idService = Convert.ToInt32(comboBoxLoad.SelectedValue);
                LoadCombobox_Material(idService);
            }
        }
        void LoadCombobox_Material(int idService)
        {
            DataTable data = DAO.MaterialDAO.Instance.ComboBoxLoad(idService);
            cbbSp.DataSource = data;
            cbbSp.DisplayMember = "name";
            cbbSp.ValueMember = "idMaterial";

            if (cbbSp.Items.Count > 0)
            {
                cbbSp.SelectedIndex = 0;
            }
        }
        private void comboBoxLoad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLoad.SelectedValue != null)
            {
                int idService = Convert.ToInt32(cbbSp.SelectedValue);
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

        private void btntim_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                loadThanhToan();
                dtgvCustomer_CellClick(null, new DataGridViewCellEventArgs(0, 0));
            }
            List<ThanhToan> listCustomer = DAO.Search.Instance.searchCustomerbyname(textBox8.Text);
            dtgvCustomer.DataSource = listCustomer;
            textBox8.Text = "";

        }

        int idCustomer = 0;
        private void dtgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0 && dtgvCustomer.Rows.Count > 0)
            {
                DataGridViewRow row = dtgvCustomer.Rows[e.RowIndex];
                tbCtm.Text = row.Cells["name"].Value?.ToString();
                tbnumCar.Text = row.Cells["numberCar"].Value?.ToString();
                object idValue = row.Cells["idCustomer"].Value;
                idCustomer = (idValue != DBNull.Value && idValue != null) ? Convert.ToInt32(idValue) : 0;

                if (idCustomer > 0)
                {
                    showBill(idCustomer); 
                }
                else
                {
                    MessageBox.Show("Khách hàng chưa có hóa đơn!");
                }
            }
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            int status = BillDAO.Instance.GetStatus(idCustomer);

            int idBill = BillDAO.Instance.GetIdBill(idCustomer);
            int IdService = comboBoxLoad.SelectedValue != null ? Convert.ToInt32(comboBoxLoad.SelectedValue) : -1;
            int IdMaterial = cbbSp.SelectedValue != null ? Convert.ToInt32(cbbSp.SelectedValue) : -1;
            int count = (int)numericUpDown.Value;
            if (idBill <= 0)
            {
                idBill = BillDAO.Instance.InsertBill(idCustomer);
            }
            if (idBill <= 0)
            {
                idBill = BillDAO.Instance.InsertBill(idCustomer);
            }

            if (idBill > 0)
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, IdService, IdMaterial, count);
                showBill(idCustomer);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
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

            DialogResult check = MessageBox.Show("Thanh toán cho Khách hàng Tên: " + tbCtm.Text + "\nTổng hóa đơn phải thanh toán là: " + tbTotal.Text, "Xác nhận Thanh toán", MessageBoxButtons.YesNo
            );

            if (check == DialogResult.Yes)
            {
                int result = DAO.ThanhToanDAO.Instance.ThanhToan(idBill);
                if (result > 0)
                {
                    showBill(idCustomer);
                    //LoadMaterial();
                    listViewPrice.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Thanh toán thất bại. Vui lòng thử lại.");
                }
            }
        }
    }
}
