using Quanly.DAO;
using Quanly.DTO;
using System.Collections.Generic;
using System.Data;

namespace Quanly.BUS
{
    public class MaterialBUS
    {
        private static MaterialBUS instance;
        public static MaterialBUS Instance
        {
            get
            {
                if (instance == null) instance = new MaterialBUS();
                return instance;
            }
            set => instance = value;
        }

        private MaterialBUS() { }

        public List<Material> LoadMaterial()
        {
            return MaterialDAO.Instance.LoadMaterial();
        }

        public List<Material> ComboBoxLoadbyThanhToan(int idService)
        {
            return MaterialDAO.Instance.ComboBoxLoadbyThanhToan(idService);
        }

        public int getidMeterrial(int idMaterial)
        {
            return MaterialDAO.Instance.getidMeterrial(idMaterial);
        }

        public int Insert_Material(int idService, string name, string type, string noiSX, int quantity, float price, string image)
        {
            return MaterialDAO.Instance.Insert_Material(idService, name, type, noiSX, quantity, price, image);
        }

        public int fixMaterial(int idMaterial, string name, string type, string noiSX, string quantity, string price, string image)
        {
            return MaterialDAO.Instance.fixMaterial(idMaterial, name, type, noiSX, quantity, price, image);
        }

        public int DeleteMaterial(int idService, int idMaterial)
        {
            return MaterialDAO.Instance.DeleteMaterial(idService, idMaterial);
        }

        public int GetCountInMaterial(int idMaterial)
        {
            return MaterialDAO.Instance.GetCountInMaterial(idMaterial);
        }

        public int UpdateCountByMaterial(string name, string count)
        {
            return MaterialDAO.Instance.UpdateCountByMaterial(name, count);
        }
    }
}
