using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanly.DTO
{
    public class Table
    {
        public Table(int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }
        public Table(DataRow row)
        {
            this.ID = (int)row["idCar"];
            this.Name = (string)row["name"];
            this.Status = (string)row["status"];
        }

        private int id;
        private string name;
        private string status;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }

    }
}
