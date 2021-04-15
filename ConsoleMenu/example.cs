using System;
using System.Collections.Generic;
using System.Text;


class example
{
    public static void Main()
    {
        string[] options = new string[] { "1. New Game", "2. Load Game", "3. Exit" };
        MenuConstructor.Display(options, "RPG GAME", 0);
        switch (MenuConstructor.GetUserSelectedOption())
        {
            case 1:
                Console.WriteLine("You have selected 1st option");
                break;
            case 2:
                Console.WriteLine("You have selected 2nd option");
                break;
            case 3:
                Console.WriteLine("You have selected 3rd option");
                break;
        }
    }


}
