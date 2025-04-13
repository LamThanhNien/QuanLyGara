using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Quanly.DAO
{
    public class ServiceDAO
    {
        private static ServiceDAO instance;
        public static ServiceDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ServiceDAO();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        private ServiceDAO() { }

        public List<DTO.Service> LoadService()
        {
            string query = "Select _Service.name,_Service.idService  FROM _Service";
            List<DTO.Service> list = new List<DTO.Service>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                DTO.Service service = new DTO.Service(row);
                list.Add(service);
            }
            return list;
        }
        public List<DTO.Service> LoadDLByThanhToan()
        {
            List<DTO.Service> list = new List<DTO.Service>();
            string query = "SELECT * FROM _Service";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                DTO.Service  item= new DTO.Service(row);
                list.Add(item);
            }    
            return list;
        }
        public DataTable LoadDlByDichvu()
        {
            string query = "SELECT * FROM _Service";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable getIdServiceLoadComboBox(int idMaterial)
        {
            string query = @"SELECT s.idService,s.name 
            FROM _Service s
            INNER JOIN Service_Material SM 
            ON s.idService = SM.idService
            WHERE SM.idMaterial = @idMaterial ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idMaterial });
            return data;
        }
        public int getidServiceByfDichvu(string name)
        {
            string query = "SELECT idService FROM _Service where name = @name ";
            object result = DAO.DataProvider.Instance.ExecuteScalar(query, new object[] { name });
            return (result != null) ? Convert.ToInt32(result) : -1;
        }

        public int CheckDichvu_in_Billinfo(int idDichvu)
        {
            string query = "select count(*) from BillInfo where idService = @idService";
            object result = DAO.DataProvider.Instance.ExecuteScalar(query, new object[] { idDichvu });
            return  result!=null? Convert.ToInt32(result): -1;
        }

        public int DelDichvu(int idDichvu)
        {  
            string query = "DELETE _Service where idService = @idService ";
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { idDichvu });
            return result > 0 ? 1 : -1;
        }

    }
}
