using Quanly.DAO;
using Quanly.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

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
            List<DTO.Service> data = DAO.ServiceDAO.Instance.LoadDLByThanhToan();
            comboBoxLoad.DataSource = data;
            comboBoxLoad.DisplayMember = "name";
            comboBoxLoad.ValueMember = "Id";
        }

        void LoadCombobox_Material(int idService)
        {
            List<DTO.Material> data = DAO.MaterialDAO.Instance.ComboBoxLoadbyThanhToan(idService);
            cbbSp.DataSource = data;
            cbbSp.DisplayMember = "name";
            //cbbSp.ValueMember = "idMaterial";
        }

        private void comboBoxLoad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null) return;
            //DTO.Service selected = comboBox.SelectedItem as DTO.Service;
            id = (comboBox.SelectedItem as DTO.Service).Id;
            LoadCombobox_Material(id);
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
                lvItem.SubItems.Add("Xóa");
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
            if (e.RowIndex >= 0 && dtgvCustomer.Rows.Count > 0)
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
            //int IdMaterial = Convert.ToInt32(cbbSp.SelectedValue);
            int IdMaterial = (cbbSp.SelectedItem as DTO.Material)?.IdMaterial ?? 0;
            int count = (int)numericUpDown.Value;
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
        private void listViewPrice_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo hit = listViewPrice.HitTest(e.Location);

            if (hit.Item != null && hit.SubItem != null)
            {
                int columnIndex = hit.Item.SubItems.IndexOf(hit.SubItem);
                if (columnIndex == 4)
                {
                    string itemName = hit.Item.SubItems[0].Text;
                    DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa: {itemName}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        DAO.BillInfoDAO.Instance.DeleteBillInfo(itemName);
                        listViewPrice.Items.Remove(hit.Item);
                    }
                }
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
