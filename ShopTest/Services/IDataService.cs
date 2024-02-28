using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTest.Services
{
    public interface IDataService<T> where T : class
    {
        void AddEntity(params T[] store);
        T DropEntity(T store);
        T UpdateEntity(T store);
        T? SearchEntity(int id);
        List<T> GetEntities();
    }
}
