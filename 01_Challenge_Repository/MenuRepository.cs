using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge_Repository
{
    public class MenuRepository
    {
        private List<Menu> MenuRepo = new List<Menu>();

        public void AddMenu(Menu menu) => MenuRepo.Add(menu);
        public void DeleteMenu(Menu menu) => MenuRepo.Remove(menu);
        public List<Menu> ListMenu()
        {
            return MenuRepo;
        }
    }
}
