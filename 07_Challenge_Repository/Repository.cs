using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Challenge_Repository
{
    public class Repository
    {
        // Types of booths and food
        public enum Boothtype { BurgerBooth, TreatBooth }
        public enum Food { Veggieburger, Hamburger, Hotdog, Popcorn, IceCream }
        
        // Constructor
        public Repository()
        {
            // For every entry in Food Price Dictionary, 
            // add an entry into TicketCounter dictionary.
            foreach (var item in Prices)
            {
                TicketCounter.Add(item.Key, 0);
            }
        }

        // Dictionaries [Prices hard-coded here]
        public Dictionary<Boothtype, float> DisposablePrices = new Dictionary<Boothtype, float>
        {
            { Boothtype.BurgerBooth, 30f },
            { Boothtype.TreatBooth, 25f }
        };

        public Dictionary<Food, float> Prices = new Dictionary<Food, float>()
        {
            { Food.Veggieburger, 2.00f },
            { Food.Hamburger, 1.50f },
            { Food.Hotdog, 1.00f },
            { Food.Popcorn, 0.50f },
            { Food.IceCream, 0.75f }
        };

        public Dictionary<Food, int> TicketCounter = new Dictionary<Food, int>();
        
        // Methods
        public int TotalTickets()
        {
            int Total = 0;
            foreach(var Ticket in TicketCounter)
            {
                Total += Ticket.Value;
            }
            return Total;
        }
    }
}
