using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
        public DataTable ComboBoxLoad(int idService)
        {
            string query = @"SELECT M.idMaterial, M.name 
                     FROM Material M 
                     INNER JOIN Service_Material SM 
                     ON M.idMaterial = SM.idMaterial 
                     WHERE SM.idService = @idService";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idService });
           return data;
        }
        public int Insert_Material(int idMaterial, string name, string type, string noiSX, int sl, Decimal price)
        {
            string query = "UPS_InsertMaterial @idMaterial , @name , @type , @noiSx , @quantity , @price ";
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { idMaterial, name, type, noiSX, sl, price });
            return result;
        }
    }
}
