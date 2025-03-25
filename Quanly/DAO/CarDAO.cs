using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public void LoadDL(DataGridView dtgvCar)
        {
            string query = @"
                SELECT cs.name as NameCustomer, c.name AS Namecar, c.NumberCar,c.logo as Logo ,
                       cs.address, cs.phoneNum as Phonenum, c.ImageBase64 as Image, c.idCustomer as idCtm ,c.idCar as IdCar
                FROM Customer cs
                INNER JOIN Car c ON cs.idCustomer = c.idCustomer;";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<DTO.Car> listCar = new List<DTO.Car>();
            foreach(DataRow row in data.Rows)
            {
                DTO.Car Caritem = new DTO.Car(row);
                listCar.Add(Caritem);
            }
            dtgvCar.DataSource = listCar;
        }

        // Thêm xe mới
        public int GetCar(int idCustomer, string namecar, int numcar, string logo, string filePath)
        {
            string query = "USP_insertCar @idCustomer, @namecar , @numcar , @logo , @filePath";
            object result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idCustomer, namecar, numcar, logo, filePath });

            return (result != null) ? Convert.ToInt32(result) : -1;
        }

        // Lấy ID của xe theo ID khách hàng
        //public int getidCar(int idCustomer)
        //{
        //    string query = "SELECT idCar FROM Car WHERE idCustomer = @idCustomer ";
        //    object result = DataProvider.Instance.ExecuteScalar(query, new object[] {idCustomer });

        //    return (result != null) ? Convert.ToInt32(result) : -1;
        //}

        // Cập nhật thông tin xe
        public int FixCar(int idCar, string name, string numcar, string color, string image)
        {
            // Nếu không có ảnh mới, lấy ảnh cũ từ CSDL
            if (string.IsNullOrEmpty(image))
            {
                string queryGetImage = "SELECT ImageBase64 FROM Car WHERE idCar = @idCar";
                object oldImage = DataProvider.Instance.ExecuteScalar(queryGetImage, new object[] { idCar });

                image = oldImage != null ? oldImage.ToString() : null; // Giữ ảnh cũ nếu có
            }

            string query = "USP_UpdateCar @idCar , @name , @numCar , @mau , @Image ";
            object imgValue = string.IsNullOrEmpty(image) ? (object)DBNull.Value : image;

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { idCar, name, numcar, color, imgValue });

            return result;
        }

    }
}
