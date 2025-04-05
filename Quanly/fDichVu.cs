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
            DAO.MaterialDAO.Instance.LoadMaterial(dtgvMaterial);
        }
        public void loadCombobox(int idService)
        {
            int idMeterrial = DAO.MaterialDAO.Instance.getidMeterrial(idService);
            DataTable data = DAO.MaterialDAO.Instance.ComboBoxMaterial();
            comboBoxLoadMaterial.DataSource = data;
            comboBoxLoadMaterial.DisplayMember = "name";
            comboBoxLoadMaterial.ValueMember = "idService";
            DataTable dt = DAO.MaterialDAO.Instance.ComboBoxLoad(idMeterrial);
            int index = comboBoxLoadMaterial.Items.IndexOf(dt);
            comboBoxLoadMaterial.SelectedItem = index;
        }
        private void fDichVu_Load(object sender, EventArgs e)
        {
            loadDL();
        }
        int idMaterial = 0;
        private void dtgvDichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvMaterial.Rows.Count > 0)
            {
                DataGridViewRow row = dtgvMaterial.Rows[e.RowIndex];
                tbnameMaterial.Text = row.Cells["Name"].Value?.ToString();
                tbLoad.Text = row.Cells["Type"].Value?.ToString();
                idMaterial = Convert.ToInt32(row.Cells["idMaterial"].Value?.ToString());
                int idService = DAO.MaterialDAO.Instance.getidMeterrial(idMaterial);
                tbPrice.Text = row.Cells["Price"].Value?.ToString();
                tbNoisx.Text = row.Cells["NoiSx"].Value?.ToString();
                tbQuantity.Text = row.Cells["Sl"].Value?.ToString();
                string imagePath = row.Cells["Image"].Value?.ToString();
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    pictureBoxM.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBoxM.Image = null;
                }
                loadCombobox(idService);
            }
        }
        private void btnDichVu_Click(object sender, EventArgs e)
        {
            fThemDichVu fThem = new fThemDichVu();
            fThem.ShowDialog();
        }
        private void btnreLoad_Click(object sender, EventArgs e)
        {
            loadDL();
        }
        private void btnFix_Click(object sender, EventArgs e)
        {
            int id = idMaterial;
            if (idMaterial == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng");
                return;
            }
            string nameMaterial = tbnameMaterial.Text;
            string type = comboBoxLoadMaterial.Text;
            string NoiSx = tbNoisx.Text;
            string quantity = tbQuantity.Text;
            string price = tbPrice.Text;
            string image = pictureBoxM.Tag as string ?? "";
            int result = DAO.MaterialDAO.Instance.fixMaterial(id, nameMaterial, type, NoiSx, quantity, price, image);
            if (result == 0)
            {
                MessageBox.Show("Cập nhật thất bại");
                return;
            }
            MessageBox.Show("Cập nhật thành công");
            loadDL();
        }

        private void AddCar_Click(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private void comboBoxLoadMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataTable data = DAO.MaterialDAO.Instance.ComboBoxMaterial();
            //comboBoxLoadMaterial.DataSource = data;
            //comboBoxLoadMaterial.DisplayMember = "name";
            //comboBoxLoadMaterial.ValueMember = "idService";
        }
    }
}
