using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanly.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MenuDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private MenuDAO() { }

        public List<DTO.Menu> GetListMenuByTable(int id)
        {
            List<DTO.Menu> listMenu = new List<DTO.Menu>();

            string query = @"SELECT 
                                s.name, 
                                s.price, 
                                bi.quantity, 
                                b.idBill,
                                (bi.quantity* s.price) AS totalPrice
                            FROM Bill b
                            JOIN BillInfo bi ON b.idBill = bi.idBill
                            JOIN _Service s ON bi.idService = s.idService
                            JOIN Material m ON bi.idMaterial = m.idMaterial
                            WHERE b.idBill = @id";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

            foreach (DataRow row in data.Rows)
            {
                DTO.Menu menuItem = new DTO.Menu(row);
                listMenu.Add(menuItem);
            }

            return listMenu;
        }

    }
}
