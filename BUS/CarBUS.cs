using System.Collections.Generic;
using Quanly.DAO;
using Quanly.DTO;

namespace Quanly.BUS
{
    public class CarBUS
    {
        private static CarBUS instance;
        public static CarBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new CarBUS();
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        private CarBUS() { }

        public List<Car> LoadDL()
        {
            return CarDAO.Instance.LoadDL();
        }
        public int GetCar(int idCustomer, string namecar, int numcar, string logo, string filePath)
        {
            return CarDAO.Instance.GetCar(idCustomer, namecar, numcar, logo, filePath);
        }
        public int AddCar(int idCustomer, string namecar, string numcar, string color, string filePath, string hang)
        {
            return CarDAO.Instance.AddCar(idCustomer, namecar, numcar, color, filePath, hang);
        }
        public int FixCar(int idCar, string name, string numcar, string color, string hang, string image)
        {
            return CarDAO.Instance.FixCar(idCar, name, numcar, color, hang, image);
        }
        public int DeleteCar(int Car)
        {
            return CarDAO.Instance.DeleteCar(Car);
        }
    }
}
