using System;
using System.Collections.Generic;
using System.Text;


class MenuConstructor
{
    static int user_selected_option = 0;
    public void Display(string[] options, string menu_name, int option_selected = 0)
    {
        int index = 0;
        Console.Clear();
        Console.WriteLine($"==========================[ {menu_name} ]==========================");
        foreach (string o in options)
        { 
            if (index == option_selected)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(o);
                Console.ResetColor();
            }
            else {
                Console.WriteLine(o);
            }
            index++;

        }
        Console.WriteLine($"==========================[ {menu_name} ]==========================");
        ConsoleKey key = Console.ReadKey().Key;
        switch (key)
        {
            case ConsoleKey.UpArrow:
                if (option_selected > 0)
                {
                    Display(options, menu_name, option_selected - 1);
                }
                else
                {
                    Display(options, menu_name, options.Length - 1);
                }
                break;
            case ConsoleKey.DownArrow:
                if (option_selected + 1 < options.Length)
                {
                    Display(options, menu_name, option_selected + 1);
                }
                else
                {
                    Display(options, menu_name, 0);
                }
                break;
            case ConsoleKey.Enter:
                MenuConstructor.user_selected_option = option_selected + 1;
                break;
            default:
                Display(options, menu_name, option_selected);
                break;

        }
    }
    public int GetUserSelectedOption()
    {
        return MenuConstructor.user_selected_option;
    }

}