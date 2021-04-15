using System;
using System.Collections.Generic;
using System.Text;


class example
{
    public static void Main()
    {
        string[] options = new string[] { "1. New Game", "2. Load Game", "3. Exit" };
        MenuConstructor menu = new MenuConstructor();
        menu.Display(options, "RPG GAME", 0);
        switch (menu.GetUserSelectedOption())
        {
            case 1:
                Console.WriteLine("You have selected option nr. 1");
                break;
            case 2:
                Console.WriteLine("You have selected option nr. 2");
                break;
            case 3:
                Console.WriteLine("You have selected option nr. 3");
                break;
        }
        
    }


}
