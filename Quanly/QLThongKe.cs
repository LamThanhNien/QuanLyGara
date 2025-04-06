using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Quanly
{
    public partial class QLThongKe : Form
    {
        public QLThongKe()
        {
            InitializeComponent();
        }
        public void loadRevenue()
        {
            string query = "select * from Revenue";
            DataTable tb = DAO.DataProvider.Instance.ExecuteQuery(query);
            dtgvRevenue.DataSource = tb;

        }
        public void loadProduct()
        {
            DAO.MaterialDAO.Instance.LoadMaterial(dataGridViewProduct);
        }
        private void QLThongKe_Load(object sender, EventArgs e)
        {
            loadRevenue();
            loadProduct();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            string dayin = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            string dayout = dateTimePicker2.Value.ToString("MM/dd/yyyy");
            string query = "SELECT * \r\nFROM Revenue\r\nWHERE datein >= @NgayBatDau AND dateRevenue <= @NgayKetThuc ";
            DataTable result = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { dayin, dayout });
            if (result.Rows.Count == 0)
            {
                if(MessageBox.Show("Không có dữ liệu","Thông báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    loadRevenue();
                }
                return;
            }
            dtgvRevenue.DataSource = result;
        }
    }
}
