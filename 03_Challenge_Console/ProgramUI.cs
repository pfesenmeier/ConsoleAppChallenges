using _03_Challenge_Repository;
using System;

namespace _03_Challenge_Console
{
    class ProgramUI
    {
        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hello Security Admin, What would you like to do?\n\n" +
                                  "1. Add a badge\n" +
                                  "2. Edit a badge\n" +
                                  "3. List all badges");
                switch (Console.ReadLine())
                {
                    case "1":
                        AddBadge();
                        break;
                    case "2":
                        EditBadge();
                        break;
                    case "3":
                        ListBadges();
                        break;
                }
                Console.ReadLine();
            }
        }
        public void AddBadge()
        {
            Console.Clear();
            Console.WriteLine("What is the number on the badge?");
            Badge badge = new Badge(int.Parse(Console.ReadLine()));
            Console.Clear();
            while (true)
            {
                Console.WriteLine("List a door that it needs access to:");
                Doors door = (Doors)Enum.Parse(typeof(Doors), Console.ReadLine());
                Badge.BadgeDictionary[badge].Add(door);
                Console.WriteLine("Any other doors (y/n)?");
                if (Console.ReadLine() == "n") { break; }
                Console.Clear();
            }
            Console.Clear();
            PrintAccessSummary(badge);
        }
        public void ListBadges()
        {
            Console.Clear();
            Console.WriteLine("Badge#\tDoor Access");
            foreach (Badge badge in Badge.BadgeDictionary.Keys)
            {
                Console.WriteLine($"{badge.BadgeId}\t{String.Join(", ", badge.AccessibleDoors)}");
            }
        }
        public void EditBadge()
        {
            Console.Clear();
            Console.WriteLine("What is the badge number to update?");
            int input = int.Parse(Console.ReadLine());
            foreach (Badge badge in Badge.BadgeDictionary.Keys)
            {
                if (badge.BadgeId == input)
                {
                    Console.WriteLine();
                    PrintAccessSummary(badge);
                    Console.WriteLine("What would you like to do?\n\n" +
                                      "1. Remove a door\n" +
                                      "2. Add a door");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("\nWhich door would you like to remove?");
                            Doors door = (Doors)Enum.Parse(typeof(Doors), Console.ReadLine());
                            Badge.BadgeDictionary[badge].Remove(door);
                            Console.WriteLine("\nDoor Removed;");
                            break;
                        case "2":
                            Console.WriteLine("\nWhich door would you like to add?");
                            door = (Doors)Enum.Parse(typeof(Doors), Console.ReadLine());
                            Badge.BadgeDictionary[badge].Add(door);
                            break;
                    }
                    PrintAccessSummary(badge);
                }
            }
        }
        public void PrintAccessSummary(Badge badge)
        {
            Console.WriteLine($"{badge.BadgeId} has access to doors " +
                              $"{String.Join(", ", badge.AccessibleDoors)}.");
        }
    }
}
