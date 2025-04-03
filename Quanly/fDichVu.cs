using Quanly.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanly
{
    public partial class fDichVu : Form
    {
        public fDichVu()
        {
            InitializeComponent();
        }
        #region Control
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void pnlTitleBar_MouseDown_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0); // Di chuyển form
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Thu nhỏ Form
        }
        #endregion
        public void loadDL()
        {
            DAO.ServiceDAO.Instance.LoadService(dtgvDichvu);
        }
        private void fDichVu_Load(object sender, EventArgs e)
        {
            loadDL();
        }
        private void dtgvDichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvDichvu.Rows.Count > 0)
            {
                DataGridViewRow row = dtgvDichvu.Rows[e.RowIndex];
                //tbCustomer.Text = row.Cells["NameCustomer"].Value?.ToString();
            }
        }

        private void btnreLoad_Click(object sender, EventArgs e)
        {
            loadDL();
        }
    }
}
