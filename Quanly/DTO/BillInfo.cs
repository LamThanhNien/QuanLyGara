using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanly.DTO
{
   public class BillInfo
    {
        public BillInfo(int idBillInfo, int idBill,int idService, float totalprice, int quantity)
        {
            this.idBillInfo = idBillInfo;
            this.idBill = idBill;
            this.idService = idService;
            this.totalprice = totalprice;
            this.quantity = quantity;
        }
        public BillInfo(DataRow row)
        {
            this.idBillInfo = (int)row["idBillInfo"];
            this.idBill = (int)row["idBill"];
            this.idService = (int)row["idService"];
            this.totalprice = Convert.ToSingle(row["totalprice"]);
            this.quantity = (int)row["quantity"];
        }


        private int quantity;
        private float totalprice;
        private int idService;
        private int idBill;
        private int idBillInfo;
        public int IdBillInfo { get => idBillInfo; set => idBillInfo = value; }
        public int IdBill { get => idBill; set => idBill = value; }
        public int IdService { get => idService; set => idService = value; }
        public float Totalprice { get => totalprice; set => totalprice = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
