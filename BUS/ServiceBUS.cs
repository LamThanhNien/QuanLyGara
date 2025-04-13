using System.Collections.Generic;
using System.Data;
using Quanly.DAO;
using Quanly.DTO;

namespace Quanly.BUS
{
    public class ServiceBUS
    {
        private static ServiceBUS instance;
        public static ServiceBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ServiceBUS();
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        private ServiceBUS() { }

        public List<Service> LoadService()
        {
            return ServiceDAO.Instance.LoadService();
        }

        public List<Service> LoadDLByThanhToan()
        {
            return ServiceDAO.Instance.LoadDLByThanhToan();
        }

        public DataTable LoadDlByDichvu()
        {
            return ServiceDAO.Instance.LoadDlByDichvu();
        }

        public DataTable getIdServiceLoadComboBox(int idMaterial)
        {
            return ServiceDAO.Instance.getIdServiceLoadComboBox(idMaterial);
        }

        public int getidServiceByfDichvu(string name)
        {
            return ServiceDAO.Instance.getidServiceByfDichvu(name);
        }

        public int CheckServiceInBillInfo(int idService)
        {
            return ServiceDAO.Instance.CheckDichvu_in_Billinfo(idService);
        }

        public bool DelDichvu(int idService)
        {
            return ServiceDAO.Instance.DelDichvu(idService) > 0;
        }
    }
}
