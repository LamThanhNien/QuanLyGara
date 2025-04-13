using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanly.DAO
{
    public class CarDAO
    {
        private static CarDAO instance;
        public static CarDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CarDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private CarDAO() { }

        // Tải dữ liệu vào DataGridView
        public List<DTO.Car> LoadDL()
        {
            string query = @"
                SELECT cs.name as NameCustomer, c.name AS Namecar, c.NumberCar,c.Color as Color , c.Hang,
                       cs.address, cs.phoneNum as Phonenum, c.Image as Image, c.idCustomer as idCtm ,c.idCar as IdCar
                FROM Customer cs
                INNER JOIN Car c ON cs.idCustomer = c.idCustomer";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<DTO.Car> listCar = new List<DTO.Car>();
            foreach(DataRow row in data.Rows)
            {
                DTO.Car Caritem = new DTO.Car(row);
                listCar.Add(Caritem);
            }
            return listCar;
        }
        public int GetCar(int idCustomer, string namecar, int numcar, string logo, string filePath)
        {
            string query = "USP_insertCar @idCustomer, @namecar , @numcar , @logo , @filePath";
            object result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idCustomer, namecar, numcar, logo, filePath });

            return (result != null) ? Convert.ToInt32(result) : -1;
        }
        public int AddCar(int idCustomer, string namecar, string numcar, string color, string filePath, string hang)
        {
            string query = "USP_InsertCar @idCustomer , @nameCar , @numCar , @Color , @image , @Hang ";
            object result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idCustomer, namecar, numcar, color, filePath , hang});

            return (result != null) ? Convert.ToInt32(result) : -1;
        }
        public int FixCar(int idCar, string name, string numcar, string color, string hang, string image)
        {
            // Nếu không có ảnh mới, lấy ảnh cũ từ CSDL
            if (string.IsNullOrEmpty(image))
            {
                string queryGetImage = "SELECT Image FROM Car WHERE idCar = @idCar";
                object oldImage = DataProvider.Instance.ExecuteScalar(queryGetImage, new object[] { idCar });

                image = oldImage != null ? oldImage.ToString() : null; // Giữ ảnh cũ nếu có
            }
            string query = "USP_UpdateCar @idCar , @name , @numCar , @mau , @Hang , @Image ";
            object imgValue = string.IsNullOrEmpty(image) ? (object)DBNull.Value : image;

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idCar, name, numcar, color,hang, imgValue });

            return result;
        }
        public int DeleteCar(int Car)
        {
            string query = "delete Car where idCar = @idCar ";
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { Car });
            return result > 0 ? 1 : 0;
        }
    }
}
