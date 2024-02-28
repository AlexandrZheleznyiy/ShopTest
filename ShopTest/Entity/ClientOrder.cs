using Microsoft.EntityFrameworkCore;
using ShopTest.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTest.Entity
{
    public class ClientOrder
    {
        private readonly ApplicationContext _context;
        public ClientOrder(ApplicationContext context)
        {
            _context = context;
        }
        public void Order(int id)
        {
            int count = int.Parse(Console.ReadLine());
            if(_context.Bread != null)
            {
                var bread = _context.Bread.FirstOrDefault(x => x.Id == id);
                bread.Count -= count;
                _context.SaveChanges();
            }
            Client client = new() { ClientName = "Покупатель", CountProd =  count };
            _context.Clients.Add(client);
            _context.SaveChanges();
        }
    }

}
