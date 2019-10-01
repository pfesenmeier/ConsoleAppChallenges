using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge_Repository
{
    public class Badge
    {
        // Constructor
        public Badge(int badgeid)
        {
            BadgeId = badgeid;
            BadgeDictionary.Add(this, new List<Doors>());
        }
        // Instance Properties
        public int BadgeId { get; set; }
        public List<Doors> AccessibleDoors => BadgeDictionary[this];

        // Static properties (Badge Repository)
        private static Dictionary<Badge, List<Doors>> badgeDictionary = new Dictionary<Badge, List<Doors>>();
        public static Dictionary<Badge, List<Doors>> BadgeDictionary { get => badgeDictionary; set => badgeDictionary = value; }
    }
    // Hard-coded Door List
    public enum Doors { A1, A5, B4, B5, B6, C10, C11, C12, D1, D2, D3, D4, D5 }
   
}
