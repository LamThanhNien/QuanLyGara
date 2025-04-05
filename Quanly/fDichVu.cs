using Quanly.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
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

            DataTable allMaterials = DAO.ServiceDAO.Instance.LoadDlByDichvu();
            comboBoxLoadMaterial.DataSource = allMaterials;
            comboBoxLoadMaterial.DisplayMember = "name";
            comboBoxLoadMaterial.ValueMember = "idService";
        }
        public void loadCombobox(int idMaterial)
        {


            DataTable dt = DAO.ServiceDAO.Instance.getIdServicebyfDichVu(idMaterial);
            if (dt == null) { return; }
            int materialId = Convert.ToInt32(dt.Rows[0]["idService"]);

            foreach (DataRowView row in comboBoxLoadMaterial.Items)
            {
                if (Convert.ToInt32(row["idService"]) == materialId)
                {
                    comboBoxLoadMaterial.SelectedItem = row;
                    break;
                }
            }
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
                tbType.Text = row.Cells["Type"].Value?.ToString();
                idMaterial = Convert.ToInt32(row.Cells["idMaterial"].Value?.ToString());

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
                loadCombobox(idMaterial);
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
            string type = tbType.Text;
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
        int IdSv = 0;
        private void comboBoxLoadMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLoadMaterial.SelectedValue != null &&
                int.TryParse(comboBoxLoadMaterial.SelectedValue.ToString(), out int selectedId))
            {
                IdSv = selectedId;
            }
        }
        private void AddDichvu_Click(object sender, EventArgs e)
        {
            int idSv = IdSv;
            string nameMaterial = tbnameMaterial.Text;
            string type = tbType.Text;
            string NoiSx = tbNoisx.Text;
            int quantity = Convert.ToInt32(tbQuantity.Text);
            float price = float.Parse(tbPrice.Text);
            string image = pictureBoxM.Tag as string ?? "";
            if (DAO.MaterialDAO.Instance.Insert_Material(idSv, nameMaterial, type, NoiSx, quantity, price, image) == 0)
            {
                MessageBox.Show("Thêm Thất bại");
                return;
            }
            MessageBox.Show("Thêm Thành công");
            loadDL();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int idSv = DAO.MaterialDAO.Instance.getidMeterrial(idMaterial);
            int idMt = idMaterial;
            if (idSv == -1 || idMt == 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ muốn xóa");
                return;
            }
            if (MessageBox.Show("Bạn có chác muốn xóa chứ", "thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            if (DAO.MaterialDAO.Instance.DeleteMaterial(idMt, idSv) == -1)
            {
                MessageBox.Show("xóa thất bại"); return;
            }
            MessageBox.Show("xóa thành công");
        }
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Ảnh (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg",
                Title = "Chọn ảnh"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                pictureBoxM.Image = Image.FromFile(filePath);
                pictureBoxM.Tag = filePath;
            }
        }
    }
}
