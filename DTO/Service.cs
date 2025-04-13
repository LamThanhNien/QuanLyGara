using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanly.DTO
{
    public class Service
    {
        public Service( int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public Service(DataRow row)
        {
            this.Id = row.Field<int>("idService");
            this.Name = row["name"] != DBNull.Value ? row["name"].ToString() : string.Empty;
        }
        private int id;
        public int Id { get => id; set => id = value; }

        private string name;
        public string Name { get => name; set => name = value; }
    }
}
