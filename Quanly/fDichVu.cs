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
            dtgvMaterial.RowPostPaint += dataGridView_RowPostPaint;
            dtgvMaterial.Columns[0].Width = 170;
            dtgvMaterial.Columns[0].HeaderText = "Tên phụ tùng";
            dtgvMaterial.Columns[1].HeaderText = "Loại";
            dtgvMaterial.Columns[2].HeaderText = "Xuất sứ";
            dtgvMaterial.Columns[3].HeaderText = "Giá";
            dtgvMaterial.Columns[4].HeaderText = "Tồn kho";

            dtgvMaterial.Columns[5].Visible = false;
            dtgvMaterial.Columns[6].Visible = false;


            DataTable dt = DAO.ServiceDAO.Instance.LoadDlByDichvu();
            comboBoxLoadMaterial.DataSource = dt;
            comboBoxLoadMaterial.DisplayMember = "name";
            comboBoxLoadMaterial.ValueMember = "idService";
        }
        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            string stt = (e.RowIndex + 1).ToString();
            using (SolidBrush brush = new SolidBrush(dgv.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(stt,
                                      dgv.Font,
                                      brush,
                                      e.RowBounds.Location.X + 10,
                                      e.RowBounds.Location.Y + 4);
            }
        }
        public void loadCombobox(int idMaterial)
        {
            DataTable dt = DAO.ServiceDAO.Instance.getIdServiceLoadComboBox(idMaterial);
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
            dtgvDichvu_CellClick(null, new DataGridViewCellEventArgs(0, 0));
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
            fDichVu_Load(this, EventArgs.Empty);

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
            fDichVu_Load(this, EventArgs.Empty);
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
            string nameSv = comboBoxLoadMaterial.Text;
            int idSv = DAO.ServiceDAO.Instance.getidServiceByfDichvu(nameSv);
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
            //loadDL();
            fDichVu_Load(this, EventArgs.Empty);
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
            if (DAO.MaterialDAO.Instance.DeleteMaterial(idSv, idMt) == -1)
            {
                MessageBox.Show("xóa thất bại");
                return;
            }
            fDichVu_Load(this, EventArgs.Empty);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<DTO.Material> materials = DAO.Search.Instance.searchMaterialbyname(tbMaterial.Text);
            dtgvMaterial.DataSource = materials;
            dtgvDichvu_CellClick(null, new DataGridViewCellEventArgs(0, 0));
        }
    }
}
