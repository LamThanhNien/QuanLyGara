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
        public int Insert_Material(int dk, int idService, int idMaterial, string name, string type, string Phanloai, string noiSX, int sl, float price, string image)
        {
            if (string.IsNullOrEmpty(image))
            {
                string queryGetImage = "SELECT images FROM Material where idMaterial  = @idMaterial";
                object oldImage = DataProvider.Instance.ExecuteScalar(queryGetImage, new object[] { idMaterial });

                image = oldImage != null ? oldImage.ToString() : null; // Giữ ảnh cũ nếu có
            }
            string query = "UPS_Material @dk , @idService , @idMaterial , @name , @type , @PhanLoai , @noiSx , @quantity , @price , @image ";
            object imgValue = string.IsNullOrEmpty(image) ? (object)DBNull.Value : image;
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] {dk,idService,idMaterial,name, type,Phanloai, noiSX, sl, price , imgValue });
            return result;
        }
    }
}
