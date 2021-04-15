using System;
using System.Collections.Generic;
using System.Text;


class MenuConstructor
{
    static int user_selected_option = 0;
    public static void Display(string[] options, string menu_name, int option_selected = 0)
    {
        int index = 0;
        Console.Clear();
        Console.WriteLine($"==========================[ {menu_name} ]==========================");
        foreach (string o in options)
        { 
            if (index == option_selected)
            {
                Console.WriteLine(o + "         <==");
            }
            else {
                Console.WriteLine(o);
            }
            index++;

        }
        Console.WriteLine($"==========================[ {menu_name} ]==========================");
        ConsoleKey key = Console.ReadKey().Key;
        if (key == ConsoleKey.UpArrow)
        {
            if (option_selected > 0)
            {
                MenuConstructor.Display(options, menu_name, option_selected - 1);
            }
            else
            {
                MenuConstructor.Display(options, menu_name, options.Length - 1);
            }

        }
        else if (key == ConsoleKey.DownArrow)
        {
            if (option_selected + 1 < options.Length)
            {
                MenuConstructor.Display(options, menu_name, option_selected + 1);
            }
            else
            {
                MenuConstructor.Display(options, menu_name, 0);
            }
        }
        else if (key == ConsoleKey.Enter)
        {
            MenuConstructor.user_selected_option = option_selected + 1;
        }

        else 
        {
            MenuConstructor.Display(options, menu_name, option_selected);
        }
    }
    public static int GetUserSelectedOption()
    {
        return MenuConstructor.user_selected_option;
    }

}