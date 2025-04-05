using Quanly.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanly.DAO
{
    public class Search
    {
        private static Search instance;
        public static Search Instance
        {
            get
            {
                if (instance == null)
                    instance = new Search();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        private Search() { }
        public List<DTO.Customer_Car> searchCustomer(string name)
        {
            string query = string.Format("SELECT cs.name, cs.sex,cs.address,cs.phoneNum,\r\n\t\tC.name As nameCar, C.numberCar, C.Hang, C.Color AS color, C.Image, cs.idCustomer\r\nFROM Customer cs INNER JOIN Car c ON cs.idCustomer = c.idCustomer \r\nWHERE dbo.RemoveDiacritics(cs.name) like N'%'+dbo.RemoveDiacritics(N'{0}')+'%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<DTO.Customer_Car> listTT = new List<DTO.Customer_Car>();
            foreach (DataRow row in data.Rows)
            {
                DTO.Customer_Car Item = new DTO.Customer_Car(row);
                listTT.Add(Item);
            }
            return listTT;
        }
        public List<Car> searchCarbyname(string name)
        {
            string query = string.Format("SELECT cs.name as NameCustomer, c.name AS Namecar, c.NumberCar,c.Color as Color ,c.Hang ,cs.address, cs.phoneNum as Phonenum, c.Image as Image, c.idCustomer as idCtm, c.idCar as IdCar FROM Customer cs INNER JOIN Car c ON cs.idCustomer = c.idCustomer where dbo.RemoveDiacritics(c.numberCar) like N'%'+dbo.RemoveDiacritics(N'{0}')+'%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<Car> list = new List<Car>();
            foreach (DataRow row in data.Rows)
            {
                DTO.Car Item = new DTO.Car(row);
                list.Add(Item);
            }
            return list;
        }


        //fix sau
        public List<ThanhToan> searchCustomerbyname(string name)
        {
            string query = string.Format("SELECT cs.name, cs.address, cs.phoneNum, c.name AS namecar,c.numberCar,c.Color, cs.idCustomer \r\nFROM Customer cs INNER JOIN Car c ON cs.idCustomer = c.idCustomer WHERE dbo.RemoveDiacritics(cs.name) like N'%'+dbo.RemoveDiacritics(N'{0}')+'%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<ThanhToan> listTT = new List<ThanhToan>();
            foreach (DataRow row in data.Rows)
            {
                DTO.ThanhToan Item = new DTO.ThanhToan(row);
                listTT.Add(Item);
            }
            return listTT;
        }
        public List<Customer> searchCtmbyname(string name)
        {
            string query = string.Format("Select name,phoneNum,address,idCustomer FROM Customer\r\nwhere dbo.RemoveDiacritics(name) like N'%'+dbo.RemoveDiacritics(N'{0}')+'%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<Customer> list = new List<Customer>();
            foreach (DataRow row in data.Rows)
            {
                DTO.Customer Item = new DTO.Customer(row);
                list.Add(Item);
            }
            return list;
        }
        public List<DTO.Material> searchMaterialbyname(string name)
        {
            string query = string.Format("SELECT * FROM Material where dbo.RemoveDiacritics(name) like N'%'+ dbo.RemoveDiacritics(N'{0}')+'%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<DTO.Material> list = new List<DTO.Material>();
            foreach (DataRow row in data.Rows)
            {
                DTO.Material Item = new DTO.Material(row);
                list.Add(Item);
            }
            return list;
        }
    }
}
