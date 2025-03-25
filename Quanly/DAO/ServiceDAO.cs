using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

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

        //public List<DTO.Service> LoadService()
        //{
        //    string query = "Select _Service.name,_Service.idService  FROM _Service";
        //    List<DTO.Service> list = new List<DTO.Service>();
        //    DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
        //    foreach (DataRow row in dataTable.Rows)
        //    {
        //        DTO.Service service = new DTO.Service(row);
        //        list.Add(service);
        //    }
        //    return list;
        //}
        public DataTable LoadDL()
        {
            string query = "SELECT idService, name FROM _Service";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public int getidService(int idMaterial)
        {
            string query = "SELECT idService FROM Service_Material where idMaterial = @idMaterial";
            object result = DAO.DataProvider.Instance.ExecuteScalar(query, new object[] { idMaterial });
            return (result != null) ? Convert.ToInt32(result) : -1;
        }

    }
}
