using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07_Challenge_Repository;

namespace _07_Challenge_Console
{
    class ProgramUI
    {
        public void Run()
        {
            Repository repository = new Repository();
            Console.WriteLine("BoothType:\n" +
                              "1. Burger\n" +
                              "2. Treat");
            switch (Console.ReadLine())
            {
                case "1":
                    BurgerBooth();
                    break;
                case "2":
                    TreatBooth();
                    break;
            }

            void BurgerBooth()
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Make Transaction (Press '4' to see results).\n\n" +
                                      "1. Veggieburger\n" +
                                      "2. Hamburger\n" +
                                      "3. Hotdog\n\n" +
                                      $"Counter: {repository.TotalTickets()}");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            repository.TicketCounter[Repository.Food.Veggieburger] += 1;
                            break;
                        case "2":
                            repository.TicketCounter[Repository.Food.Hamburger] += 1;
                            break;
                        case "3":
                            repository.TicketCounter[Repository.Food.Hotdog] += 1;
                            break;
                        case "4":
                            DisplayResults(repository);
                            break;
                    } 
                }
            }
            void TreatBooth()
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Make Transaction (Press '4' to see results):\n\n" +
                                      "1. Popcorn\n" +
                                      "2. Icecream\n\n" +
                                      $"Counter: {repository.TotalTickets()}");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            repository.TicketCounter[Repository.Food.Popcorn] += 1;
                            break;
                        case "2":
                            repository.TicketCounter[Repository.Food.IceCream] += 1;
                            break;
                        case "4":
                            DisplayResults(repository);
                            break;
                    } 
                }
            }
        }
        public void DisplayResults(Repository repository)
        {
            Console.Clear();
            float TotalCost = 0;
            Console.WriteLine("Results (Press '4' to make transactions):\n");
            Console.WriteLine($"Name" +
                              $"{String.Concat(Enumerable.Repeat(' ', 16 - "Name".Length))}" +
                              $"Amount\t" +
                              $"Total");
            foreach (var item in repository.TicketCounter)
            {
                float cost = item.Value * repository.Prices[item.Key];
                Console.WriteLine($"{item.Key}" +
                                  $"{String.Concat(Enumerable.Repeat(' ', 16 - item.Key.ToString().Length))}" +
                                  $"{item.Value}\t" +
                                  $"{cost.ToString("C", new System.Globalization.CultureInfo("en-US"))}");
                TotalCost += cost;
            }
            float DisposableCost = 0;
            foreach (var item in repository.DisposablePrices)
            {
                DisposableCost += item.Value;
                TotalCost += item.Value;
            }
            Console.WriteLine($"\nDisposables" +
                              $"{String.Concat(Enumerable.Repeat(' ', 24 - "Disposables".ToString().Length))}" +
                              $"{DisposableCost.ToString("C", new System.Globalization.CultureInfo("en-US"))}\n");
            Console.WriteLine($"Total" +
                              $"{String.Concat(Enumerable.Repeat(' ', 16 - "Total".ToString().Length))}{repository.TotalTickets()}\t" +
                              $"{TotalCost.ToString("C", new System.Globalization.CultureInfo("en-US"))}");
            while (true)
            {
                if (Console.ReadLine() == "4")
                {
                    break;
                }
            }
        }
    }
}
