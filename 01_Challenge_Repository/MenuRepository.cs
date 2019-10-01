using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge_Repository
{
    public class MenuRepository
    {
        public List<Menu> MenuRepo { get; set; } = new List<Menu>();

        public void AddMenu(Menu menu) => MenuRepo.Add(menu);
        public void DeleteMenu(Menu menu) => MenuRepo.Remove(menu);
        public bool DeleteMenu(int number)
        {
            return MenuRepo.Remove(MenuRepo.Find(item => item.MealNumber == number));
        }
    }
}
