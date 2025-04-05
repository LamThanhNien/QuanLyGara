using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanly
{
    public partial class QLThongKe : Form
    {
        public QLThongKe()
        {
            InitializeComponent();
        }
        public void load()
        {
            string query = "select * from Revenue";
            DataTable tb = DAO.DataProvider.Instance.ExecuteQuery(query);
            dtgvRevenue.DataSource = tb;
        }
        private void QLThongKe_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
