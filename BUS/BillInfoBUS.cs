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
            InsertBillInfo(IdBill,IdService,IdMaterial,Quantity);
        }
        public bool DeleteBillInfo(string name)
        {
            return DeleteBillInfo(name);
        }
    }
}
