using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanly.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status)
        {
            this.Id = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
        }

        public Bill(DataRow row)
        {
            this.Id = (int)row["idBill"];
            this.DateCheckIn = (DateTime?)row["DateCheckIn"];
            var dateCheckoutTemp = row["DateCheckOut"];
            if (dateCheckoutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)row["dateCheckoutTemp"];
            this.Status = (int)row["status"];
        }

        public int Id { get; set; }
        public DateTime? DateCheckIn { get; set; }
        public DateTime? DateCheckOut { get; set; }
        public int Status { get; set; }
    }
}
