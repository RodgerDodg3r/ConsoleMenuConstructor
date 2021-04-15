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

```

## Screenshot
![](https://i.imgur.com/yAirN5z.png)
