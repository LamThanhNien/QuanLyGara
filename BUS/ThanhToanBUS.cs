using System.Collections.Generic;
using Quanly.DAO;
using Quanly.DTO;

namespace Quanly.BUS
{
    public class ThanhToanBUS
    {
        private static ThanhToanBUS instance;
        public static ThanhToanBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThanhToanBUS();
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        private ThanhToanBUS() { }

        public List<ThanhToan> LoadDuLieuThanhToan()
        {
            return ThanhToanDAO.Instance.LoadDL();
        }

        public int ThucHienThanhToan(int idBill)
        {
            return ThanhToanDAO.Instance.ThanhToan(idBill);
        }
    }
}
