using _01_Challenge_Repository;
using System;

namespace _01_Challenge_Console
{
    class ProgramUI
    {
        public void Run()
        {
            MenuRepository menuRepo = new MenuRepository();
            while (true)
            {
                Console.Clear();
                int input = RunMenu();
                Console.Clear();
                switch (input)
                {
                    case 1:
                        PrintMenu(menuRepo);
                        break;
                    case 2:
                        AddItem(menuRepo);
                        break;
                    case 3:
                        DeleteItem(menuRepo);
                        break;
                }
                Console.ReadLine();
            }
        }
        public void AddItem(MenuRepository menuRepo)
        {
            Console.Out.NewLine = "";
            Console.WriteLine("Number: ");
            int menuNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Name: ");
            string menuName = Console.ReadLine();
            Console.WriteLine("Ingredients: ");
            string menuIngredients = Console.ReadLine();
            Console.WriteLine("Price : $");
            float menuPrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Description: ");
            string menuDescription = Console.ReadLine();
            Menu menu = new Menu(menuNumber,
                                 menuName,
                                 menuDescription,
                                 menuIngredients,
                                 menuPrice);
            menuRepo.AddMenu(menu);
            Console.WriteLine("\nSuccess");
        }
        public void PrintMenu(MenuRepository menuRepo)
        {
            foreach (Menu menu in menuRepo.MenuRepo)
            {
                Console.WriteLine($"{menu.MealNumber}\n" +
                                  $"{menu.MealName}\n" +
                                  $"{menu.MealDescription}\n" +
                                  $"{menu.MealIngredients}\n" +
                                  $"{menu.MealPrice}");
                Console.WriteLine();
            }
        }
        public int RunMenu()
        {
            //commands
            Console.Out.NewLine = "";
            Console.WriteLine("Komodo Cafe\n\n" +
                              "1. See Items\n" +
                              "2. Add Item\n" +
                              "3. Delete Item\n" +
                              "> ");
            Console.Out.NewLine = null;
            return int.Parse(Console.ReadLine());

        }
        public void DeleteItem(MenuRepository menuRepo)
        {
            Console.Out.NewLine = "";
            Console.WriteLine("Item Number: ");
            Console.Out.NewLine = null;
            int input = int.Parse(Console.ReadLine());
            bool success = menuRepo.DeleteMenu(input);
            if (success) { Console.WriteLine("Success"); }
        }
    }
}
