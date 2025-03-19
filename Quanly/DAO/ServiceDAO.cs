using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
