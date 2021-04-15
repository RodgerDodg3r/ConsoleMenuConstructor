# ConsoleMenuContructor
A simple way to create interactive menus in Console. It allways to navigate menu by clicking arrows keys

## Features

- Simple and short code
- No need of editing CMC to add funcionality after clicking option




## Example of use
```bash
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
```

## Screenshot
[alt text](https://i.imgur.com/yAirN5z.png)
