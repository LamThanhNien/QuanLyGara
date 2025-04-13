using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Data;
using Quanly.DTO;

namespace Quanly.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;
        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerDAO();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        private CustomerDAO() { }

        public List<DTO.Customer_Car> LoadDLByCustomer()
        {
            List<DTO.Customer_Car> list = new List<DTO.Customer_Car>();
            string query = @"SELECT 
                                CT.name, 
                                CT.sex, 
                                CT.address, 
                                CT.phoneNum, 
                                C.name As nameCar, 
                                C.numberCar, 
                                C.Hang,
                                C.Color As color, 
                                C.Image, 
                                CT.idCustomer 
                            FROM Customer CT 
                            INNER JOIN Car C ON CT.idCustomer = C.idCustomer";
            DataTable data = DAO.DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                DTO.Customer_Car item = new DTO.Customer_Car(row);
                list.Add(item);
            }
            var displayList = list.Select(c => new
            {
                c.NameCtm,Sex = c.Sex == 0 ? "Nam" : "Nữ", 
                c.Address,c.Phone,c.NameCar,c.NumCar,c.Hang,c.Color,c.Image,c.IdCustomer
            }).ToList();
            return list;
        }
        public int DeleteCtn_Car(int id)
        {
            string query = "DeleteCustomer @idCustomer ";
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result>0?1:0;
        }

        public int FixCustomer_Car(int idCtm, string nameCtm, int sex, string address, string phone, string nameCar, string numCar, string hang, string color, string image)
        {
            string query = "EditCustomer_Car @idCustomer , @Ten , @sex , @address , @Mobile , @nameCar , @numCar , @hang , @color , @Image ";
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] {idCtm,nameCtm,sex,address,phone,nameCar,numCar,hang, color,image});
            return (result > 1) ? 1 : 0;
        }
        public bool AddCar_Customer(int idKhach, string name, string address, string numberphone, string namecar, string numcar, string hang, string logo, string filePath)
        {
            string query = "InsertCustomer @dk , @idKhach , @Ten , @address , @Mobile , @namecar , @numcar , @Hang , @logo , @filePath ";
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { 1, idKhach, name, address, numberphone, namecar, numcar, hang, logo, filePath });

            return result > 0;
        }

        public bool AddCustomer(string name, string address, string numberphone, string namecar, string numcar,string hang, string logo, string filePath)
        {
            string query = "InsertCustomer @dk , @idKhach , @Ten , @address , @Mobile , @namecar , @numcar , @Hang , @logo , @filePath ";
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] {0, 0, name, address, numberphone, namecar, numcar, hang, logo, filePath });

            return result > 0;
        }

        public bool checkNumBerCar(string numberCar)
        {
            string query = "SELECT COUNT(*) FROM Car WHERE numberCar = @numberCar";
            object result = DAO.DataProvider.Instance.ExecuteScalar(query, new object[] { numberCar });

            return Convert.ToInt32(result) > 0;
        }
        public bool checkidKhach(int idKhach)
        {
            string query = "SELECT COUNT(*) FROM Customer C WHERE C.idCustomer = @idKhach";
            object result = DAO.DataProvider.Instance.ExecuteScalar(query, new object[] { idKhach });
            return Convert.ToInt32(result) > 0;
        }
    }
}
