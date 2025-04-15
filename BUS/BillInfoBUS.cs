using System;
using Quanly.DAO;

namespace Quanly.BUS
{
    public class BillInfoBUS
    {
        private static BillInfoBUS instance;
        public static BillInfoBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInfoBUS();
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        private BillInfoBUS() { }
        public void InsertBillInfo(int IdBill, int IdService, int IdMaterial, int Quantity)
        {
<<<<<<< HEAD
           BillInfoDAO.Instance.InsertBillInfo(IdBill,IdService,IdMaterial,Quantity);
=======
            BillInfoDAO.Instance.InsertBillInfo(IdBill,IdService,IdMaterial,Quantity);
>>>>>>> eb25c5702db72402f863ba55e48ffe7f92c58b0c
        }
        public bool DeleteBillInfo(string name)
        {
            return DeleteBillInfo(name);
        }
    }
}
