using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanly.DAO
{
    public class Search
    {
        public static void searchDataGridView(DataGridView dataGridView, string phoneNum, string searchText)
        {
            if(dataGridView.DataSource is DataTable dt)
            {
                if (string.IsNullOrEmpty(searchText))
                {
                    dt.DefaultView.RowFilter = "";
                }
                else
                {
                    dt.DefaultView.RowFilter = string.Format("{0} LIKE '%{1}%'", phoneNum, searchText.Trim());
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ hoặc DataGridView chưa có DataTable!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
