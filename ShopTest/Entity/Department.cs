using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTest.Entity
{
    public class Department
    {
        public int Id { get; set; }
        public string? Name_Department { get; set; }
        public int? ProductStore_Id { get; set; }
        public ProductStore? ProductStore { get; set; }
        public List<Manager> Managers { get; set; } = new List<Manager>();
        public List<BreadDep> Breads { get; set; } = new List<BreadDep>();
        public List<FishDep> Fish { get; set; } = new List<FishDep>();
        public List<MeatDep> Meat { get; set; } = new List<MeatDep>();
        public List<MilkDep> Milk { get; set; } = new List<MilkDep>();

    }
}
