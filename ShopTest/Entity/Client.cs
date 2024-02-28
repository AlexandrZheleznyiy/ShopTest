using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTest.Entity
{
    public class Client
    {
        public int Id { get; set; }
        public string? ClientName { get; set; }
        public int? CountProd { get; set; }
    }
}
