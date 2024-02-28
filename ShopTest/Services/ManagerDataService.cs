using ShopTest.Context;
using ShopTest.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTest.Services
{
    public class ManagerDataService : IDataService<Manager>
    {
        ApplicationContext _context;
        public ManagerDataService(ApplicationContext context)
        {
            _context = context;
        }

        public void AddEntity(params Manager[] manager)
        {
            _context.Managers.AddRange(manager);
            _context.SaveChanges();
        }

        public Manager DropEntity(Manager manager)
        {
            _context.Managers.Remove(manager);
            _context.SaveChanges();
            return manager;
        }

        public List<Manager> GetEntities()
        {
            return _context.Managers.ToList();
        }

        public Manager? SearchEntity(int id)
        {
            return _context.Managers.FirstOrDefault(x => x.Id == id);
        }

        public Manager UpdateEntity(Manager manager)
        {
            _context.Managers.Update(manager);
            _context.SaveChanges();
            return manager;
        }
    }
}
