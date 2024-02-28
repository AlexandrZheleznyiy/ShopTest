using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTest.Entity
{
    public class ProductStore
    {
        public int Id { get; set; }
        public string? Name_Store { get; set; }
        public string? Address_Store { get; set; }
        public string? Phone_Store { get; set; }
        public string? Email_Store { get; set; }
        public List<Department> Departments { get; set; } = new List<Department>();
        public List<Manager> Managers { get; set; } = new List<Manager>();
        public List<BreadDep> Breads { get; set; } = new List<BreadDep>();
        public List<FishDep> Fish { get; set; } = new List<FishDep>();
        public List<MeatDep> Meat { get; set; } = new List<MeatDep>();
        public List<MilkDep> Milk { get; set; } = new List<MilkDep>();
    }
}
