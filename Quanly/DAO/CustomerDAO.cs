using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

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
        public void LoadDL(DataGridView Customer)
        {
            string query = " ";
            Customer.DataSource = DAO.DataProvider.Instance.ExecuteQuery(query);
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
        public bool AddCustomer(string name, string address, string numberphone, string namecar, string numcar, string logo, string filePath)
        {
            string query = "InsertCustomer @dk , @idKhach , @Ten , @address , @Mobile , @namecar , @numcar , @logo , @filePath ";
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] {0, 0, name, address, numberphone, namecar, numcar, logo, filePath });

            return result > 0;
        }
        public bool AddCar_Customer(int idKhach,string name, string address, string numberphone, string namecar, string numcar, string logo, string filePath)
        {
            string query = "InsertCustomer @dk , @idKhach , @Ten , @address , @Mobile , @namecar , @numcar , @logo , @filePath ";
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] {1, idKhach, name, address, numberphone, namecar, numcar, logo, filePath });

            return result > 0;
        }
    }
}
