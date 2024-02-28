using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTest.Entity
{
    public class Manager
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public int? Age { get; set; }
        public int? ProductStore_Id { get; set; }
        public int? Department_Id { get; set; }
        public ProductStore? ProductStore { get; set; }
        public Department? Department { get; set; }
    }
}
