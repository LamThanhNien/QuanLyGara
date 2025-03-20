using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanly.DAO
{
    public class MaterialDAO
    {
        private static MaterialDAO instance;
        public static MaterialDAO Instance 
        {
            get
            {
                if (instance == null) instance = new MaterialDAO();
                return instance;
            }
            set { instance = value; }
        }
        private MaterialDAO() { }
        public void LoadDL(DataGridView dtgvMaterial)
        {
            string query = "SELECT * FROM Material";
            dtgvMaterial.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        public void ComboBoxLoad(ComboBox comboBox2, int idService)
        {
            string query = @"SELECT M.idMaterial, M.name 
                     FROM Material M 
                     INNER JOIN Service_Material SM 
                     ON M.idMaterial = SM.idMaterial 
                     WHERE SM.idService = @idService";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idService });
            comboBox2.DataSource = data;
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "idMaterial";

            if (comboBox2.Items.Count > 0)
            {
                comboBox2.SelectedIndex = 0;
            }
        }
    }
}
