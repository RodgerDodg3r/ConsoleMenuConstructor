using System;

namespace ConsoleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menu_options = new string[] {"1","2","3","4"};
            MenuConstructor.Display(menu_options,"Main Menu", 0);

            switch (MenuConstructor.GetUserSelectedOption())
            {
                case 1:
                    Console.WriteLine("asdasdasd");
                    break;
                case 2:
                    Console.WriteLine("sadasd213123");
                    break;
            }
        }
    }
}