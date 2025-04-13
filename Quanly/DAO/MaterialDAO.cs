using Quanly.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public void LoadMaterial(DataGridView dtgvMaterial)
        {
            List<DTO.Material> listM = new List<DTO.Material>();
            string query = "SELECT * FROM Material";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                DTO.Material item = new DTO.Material(row);
                listM.Add(item);
            }
            dtgvMaterial.DataSource = listM;
        }
        public List<DTO.Material> ComboBoxLoadbyThanhToan(int idService)
        {
            List<DTO.Material> list = new List<Material>();
            string query = @"SELECT * --M.idMaterial, M.name 
                     FROM Material M 
                     INNER JOIN Service_Material SM 
                     ON M.idMaterial = SM.idMaterial 
                     WHERE SM.idService = @idService ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idService });
            foreach (DataRow row in data.Rows)
            {
                DTO.Material item = new DTO.Material(row);
                list.Add(item);
            }
            return list;
        }

        public int getidMeterrial(int idMaterial)
        {
            string query = "select s.idService\r\nfrom _Service s,Material m, Service_Material ms \r\nwhere s.idService = ms.idService and ms.idMaterial = m.idMaterial  and m.idMaterial = @idMaterial ";
            object result = DAO.DataProvider.Instance.ExecuteScalar(query, new object[] { idMaterial });
            return result != null ? Convert.ToInt32(result) : -1;
        }

        public int Insert_Material(int idService, string name, string type, string noiSX, int sl, float price, string image)
        {
            string query = "USP_AddMaterial @idService , @name , @type , @noiSx , @quantity , @price , @image ";
            object imgValue = string.IsNullOrEmpty(image) ? (object)DBNull.Value : image;
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] {idService,name, type,noiSX, sl, price , imgValue });
            return result;
        }

        public int fixMaterial(int idMaterial, string nameMaterial, string type, string NoiSx, string quantity, string price, string image)
        {
            // Nếu không có ảnh mới, lấy ảnh cũ từ CSDL
            if (string.IsNullOrEmpty(image))
            {
                string queryGetImage = "SELECT images FROM Material WHERE idMaterial = @idMaterial";
                object oldImage = DataProvider.Instance.ExecuteScalar(queryGetImage, new object[] { idMaterial });

                image = oldImage != null ? oldImage.ToString() : null; // Giữ ảnh cũ nếu có
            }
            string query = "USP_FixMaterial @idMaterial , @name , @type , @NoiSx , @quantity , @price , @image ";
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { idMaterial, nameMaterial, type, NoiSx, quantity, price, image });
            return result > 0 ? 1 : 0;
        }
        public int DeleteMaterial(int idSv, int idMt)
        {
            string query = "USP_DeleteMaterial @idMaterial , @idService ";
            object result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { idMt, idSv });
            return result != null ? Convert.ToInt32(result) : -1;
        }
        public int GetCountInMaterial(int idMaterial)
        {
            string query = "SELECT quantity FROM Material WHERE idMaterial = @idMaterial ";
            object result = DAO.DataProvider.Instance.ExecuteScalar(query, new object[] { idMaterial });
            return result != null ? Convert.ToInt32(result) : -1;
        }
        public int UpdateCountByMaterial(string name, string count)
        {
            string query = "UPDATE Material SET quantity = quantity + @count WHERE idMaterial = (SELECT idMaterial FROM Material WHERE name = @name )";
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { count, name });
            return result > 0 ? 1 : -1;
        }

    }
}
