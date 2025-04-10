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
                if (MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    loadRevenue();
                }
                return;
            }
            dtgvRevenue.DataSource = result;
        }
        private void btnBaocao_Click(object sender, EventArgs e)
        {
            if (dtgvRevenue.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                saveFileDialog.DefaultExt = "csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder csvContent = new StringBuilder();

                    for (int i = 0; i < dtgvRevenue.Columns.Count; i++)
                    {
                        csvContent.Append(dtgvRevenue.Columns[i].HeaderText);
                        if (i < dtgvRevenue.Columns.Count - 1)
                            csvContent.Append(",");
                    }
                    csvContent.AppendLine();

                    foreach (DataGridViewRow row in dtgvRevenue.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            for (int i = 0; i < dtgvRevenue.Columns.Count; i++)
                            {
                                csvContent.Append(row.Cells[i].Value.ToString());
                                if (i < dtgvRevenue.Columns.Count - 1)
                                    csvContent.Append(",");
                            }
                            csvContent.AppendLine();
                        }
                    }

                    System.IO.File.WriteAllText(saveFileDialog.FileName, csvContent.ToString());
                    MessageBox.Show("Đã xuất ra file CSV thành công!");
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
            }
        }
    }
}
