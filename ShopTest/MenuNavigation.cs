using ShopTest.Context;
using ShopTest.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTest
{
    public class MenuNavigation
    {
        private ClientOrder _clientOrder;
        public MenuNavigation(ClientOrder clientOrder)
        {
            _clientOrder = clientOrder;
        }
        public void MainMenu()
        {
            Console.WriteLine("Выберите продукт: Ржаной F1, Белый F2, Бездрожжевой F3, Белковый F4, Лаваш F5");
        }
        public void MenuStore()
        {
            ConsoleKey consoleKey = Console.ReadKey().Key;
            switch(consoleKey)
            {
                case ConsoleKey.F1:
                    Console.WriteLine("Введите количество: ");
                    _clientOrder.Order(1);
                    break;
                case ConsoleKey.F2:
                    Console.WriteLine("Введите количество: ");
                    _clientOrder.Order(2);
                    break;
                case ConsoleKey.F3:
                    Console.WriteLine("Введите количество: ");
                    _clientOrder.Order(3);
                    break;
                case ConsoleKey.F4:
                    Console.WriteLine("Введите количество: ");
                    _clientOrder.Order(4);
                    break;
                case ConsoleKey.F5:
                    Console.WriteLine("Введите количество: ");
                    _clientOrder.Order(5);
                    break;

            }
        }
    }
}
