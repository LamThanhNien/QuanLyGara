using Quanly.DAO;
using Quanly.DTO;
using System.Collections.Generic;
using System.Data;

namespace Quanly.BUS
{
    public class MenuBUS
    {
        private static MenuBUS instance;
        public static MenuBUS Instance
        {
            get
            {
                if (instance == null) instance = new MenuBUS();
                return instance;
            }
            set => instance = value;
        }

        private MenuBUS() { }
        public List<DTO.Menu> GetListMenuByTable(int id)
        {
            return MenuDAO.Instance.GetListMenuByTable(id);

        }
    }
}
