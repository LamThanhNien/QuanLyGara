using Quanly.DTO;
using Quanly.BUS;
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
using System.Globalization;

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
            dtgvRevenue.RowHeadersVisible = false;
            dtgvRevenue.Columns[0].Width = 50;
            dtgvRevenue.Columns[0].HeaderText = "stt";
            dtgvRevenue.Columns[1].Width = 80;
            dtgvRevenue.Columns[1].HeaderText = "Số Bill";
            dtgvRevenue.Columns[2].HeaderText = "Tổng tiền";
            dtgvRevenue.Columns[3].HeaderText = "Ngày Lập Hóa Đơn";
            dtgvRevenue.Columns[4].HeaderText = "Ngày Thanh Toán";
            double tongTien = 0;
            foreach (DataRow row in tb.Rows)
            {
                tongTien += Convert.ToDouble(row[2]);
            }
            tbDoanhthu.Text = tongTien.ToString("c", new CultureInfo("vi-VN"));
        }
        public void loadProduct()
        {
            dataGridViewProduct.DataSource = MaterialBUS.Instance.LoadMaterial();
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduct.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                saveFileDialog.DefaultExt = "csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder csvContent = new StringBuilder();

                    for (int i = 0; i < dataGridViewProduct.Columns.Count; i++)
                    {
                        csvContent.Append(dataGridViewProduct.Columns[i].HeaderText);
                        if (i < dataGridViewProduct.Columns.Count - 1)
                            csvContent.Append(",");
                    }
                    csvContent.AppendLine();

                    foreach (DataGridViewRow row in dataGridViewProduct.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            for (int i = 0; i < dataGridViewProduct.Columns.Count; i++)
                            {
                                csvContent.Append(row.Cells[i].Value.ToString());
                                if (i < dataGridViewProduct.Columns.Count - 1)
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
