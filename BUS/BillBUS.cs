using System;
using Quanly.DAO;

namespace Quanly.BUS
{
    public class BillBUS
    {
        private static BillBUS instance;
        public static BillBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillBUS();
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        private BillBUS() { }

        public int GetIdBill(int idCustomer)
        {
            return BillDAO.Instance.GetIdBill(idCustomer);
        }

        public int GetStatus(int idCustomer)
        {
            return BillDAO.Instance.GetStatus(idCustomer);
        }

        public int InsertBill(int idCustomer)
        {
            return BillDAO.Instance.InsertBill(idCustomer);
        }

        public int GetBillCount(int idCustomer, int status)
        {
            return BillDAO.Instance.slBill(idCustomer, status);
        }
    }
}
