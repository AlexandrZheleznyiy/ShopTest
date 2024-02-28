using ShopTest.Context;
using ShopTest.Entity;

namespace ShopTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext appContext = new ApplicationContext())
            {
                ClientOrder clientOrder = new(appContext);
                MenuNavigation menuNavigation = new(clientOrder);
                menuNavigation.MainMenu();
                menuNavigation.MenuStore();
            }
        }
    }
}
