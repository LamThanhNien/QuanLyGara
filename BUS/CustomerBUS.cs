using Quanly.DTO;
using Quanly.DAO;
using System;
using System.Collections.Generic;

namespace Quanly.BUS
{
    public class CustomerBUS
    {
        private static CustomerBUS instance;
        public static CustomerBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerBUS();
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        private CustomerBUS() { }

        public List<Customer_Car> LoadDLByCustomer()
        {
            return CustomerDAO.Instance.LoadDLByCustomer();
        }
        public int DeleteCtn_Car(int id)
        {
            return CustomerDAO.Instance.DeleteCtn_Car(id);
        }
        public int FixCustomer_Car(int idCtm, string nameCtm, int sex, string address, string phone, string nameCar, string numCar, string hang, string color, string image)
        {
            return CustomerDAO.Instance.FixCustomer_Car(idCtm, nameCtm, sex, address, phone, nameCar, numCar, hang, color, image);
        }
        public bool AddCar_Customer(int idKhach, string name, string address, string numberphone, string namecar, string numcar, string hang, string logo, string filePath)
        {
            return CustomerDAO.Instance.AddCar_Customer(idKhach, name, address, numberphone, namecar, numcar, hang, logo, filePath);
        }
        public bool AddCustomer(string name, string address, string numberphone, string namecar, string numcar, string hang, string logo, string filePath)
        {
            return CustomerDAO.Instance.AddCustomer(name, address, numberphone, namecar, numcar, hang, logo, filePath);
        }
        public bool checkNumBerCar(string numberCar)
        {
            return CustomerDAO.Instance.checkNumBerCar(numberCar);
        }
        public bool checkidKhach(int idKhach)
        {
            return CustomerDAO.Instance.checkidKhach(idKhach);
        }
    }
}
