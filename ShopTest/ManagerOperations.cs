using ShopTest.Context;
using ShopTest.Entity;
using ShopTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTest
{
    public class ManagerOperations
    {
        private readonly ApplicationContext _context;
        private readonly ManagerDataService _managerDataService;
        public ManagerOperations(ManagerDataService managerDataService, ApplicationContext context)
        {
            _managerDataService = managerDataService;
            _context = context;
        }
        public void AddManager()
        {
            Manager manager1 = new Manager() { Name = "Алексей", LastName = "Попов", Phone = "937", Email = "alex@mail.ru", Age = 18, ProductStore_Id = 1, Department_Id = 1 };
            Manager manager2 = new Manager() { Name = "Сергей", LastName = "Городний", Phone = "938", Email = "serg@mail.ru", Age = 18, ProductStore_Id = 1, Department_Id = 1 };
            Manager manager3 = new Manager() { Name = "Юлия", LastName = "Иванова", Phone = "939", Email = "juli@mail.ru", Age = 18, ProductStore_Id = 1, Department_Id = 2 };
            Manager manager4 = new Manager() { Name = "Наталья", LastName = "Воронова", Phone = "940", Email = "nata@mail.ru", Age = 18, ProductStore_Id = 1, Department_Id = 2 };
            Manager manager5 = new Manager() { Name = "Васильй", LastName = "Глянцев", Phone = "941", Email = "vas@mail.ru", Age = 18, ProductStore_Id = 1, Department_Id = 3 };
            Manager manager6 = new Manager() { Name = "Татьяна", LastName = "Сидорова", Phone = "942", Email = "taniag@mail.ru", Age = 18, ProductStore_Id = 1, Department_Id = 3 };
            Manager manager7 = new Manager() { Name = "Юлия", LastName = "Никифорова", Phone = "943", Email = "ju@mail.ru", Age = 18, ProductStore_Id = 1, Department_Id = 4 };
            Manager manager8 = new Manager() { Name = "Иван", LastName = "Игнатов", Phone = "944", Email = "ivan@mail.ru", Age = 18, ProductStore_Id = 1, Department_Id = 4 };

            _managerDataService.AddEntity(manager1, manager2, manager3, manager4, manager5, manager6, manager7, manager8);
        }
        public void GetManagers()
        {
            List<Manager> managers = _managerDataService.GetEntities();
            foreach (Manager manager in managers)
            {
                Console.WriteLine($"{manager?.Name} {manager?.LastName} {manager?.Age} {manager?.Phone} {manager?.Email} {manager?.ProductStore_Id} {manager?.Department_Id}");
            }
        }
        public void SearchManager()
        {
            Manager? manager = _managerDataService.SearchEntity(2);
            Console.WriteLine($"{manager?.Name} {manager?.LastName} {manager?.Age} {manager?.Phone} {manager?.Email} {manager?.ProductStore_Id} {manager?.Department_Id}");
        }
        public void UpdateManager()
        {
            if (_context.Managers != null)
            {
                Manager? manager = _managerDataService.SearchEntity(2);
                manager.Name = "Вячеслав";
                manager.LastName = "Илов";
                manager.Phone = "539";
                manager.Email = "vach@mail.ru";
                manager.Age = 25;
                manager.ProductStore_Id = 1;
                manager.Department_Id = 4;
                _managerDataService.UpdateEntity(manager);
            }
        }
        public void DropManager()
        {
            Manager? manager = _managerDataService.SearchEntity(2);
            if(manager != null)
            {
                _managerDataService.DropEntity(manager);
            }
        }
    }
}
