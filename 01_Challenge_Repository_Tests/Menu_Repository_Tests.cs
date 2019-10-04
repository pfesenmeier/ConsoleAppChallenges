using _01_Challenge_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace _01_Challenge_Repository_Tests
{
    [TestClass]
    public class Menu_Repository_Tests
    {
        MenuRepository MenuRepo;
        Menu menu0;
        Menu menu1;
        Menu menu2;

        [TestInitialize]
        public void TestInitialize()
        {
            MenuRepo = new MenuRepository();
            menu0 = new Menu()
            {
                MealNumber = 42,
                MealName = "hamburger",
                MealDescription = "American Classic",
                MealIngredients = "Bun, Cheese, Ketchup, Patty",
                MealPrice = 4.00f
            };
            menu1 = new Menu()
            {
                MealNumber = 43,
                MealName = "Wedge Salad",
                MealDescription = "Delicious vegetables on a plate",
                MealIngredients = "Iceberg lettuce and ranch",
                MealPrice = 3.00f
            };
            menu2 = new Menu()
            {
                MealNumber = 44,
                MealName = "Fries",
                MealDescription = "Shoestring potatoes",
                MealIngredients = "potatoes, salt, oil",
                MealPrice = 2.00f
            };
            MenuRepo.AddMenu(menu0);
            MenuRepo.AddMenu(menu1);
            MenuRepo.AddMenu(menu2);
        }
        [TestMethod]
        public void AddMenuTest()
        {
            Menu menu3 = new Menu()
            {
                MealNumber = 45,
                MealName = "Milkshake",
                MealDescription = "Sweet Dairy",
                MealIngredients = "Sugar, Milk",
                MealPrice = 2.00f
            };
            MenuRepo.AddMenu(menu3);
            Assert.AreEqual(4, MenuRepo.MenuRepo.Count);
        }
        [TestMethod]
        public void DeleteMenuTest()
        {
            MenuRepo.DeleteMenu(menu2);
            Assert.AreEqual(2, MenuRepo.MenuRepo.Count);
        }
        [TestMethod]
        public void ListMenuTest()
        {
            Assert.AreEqual(3, MenuRepo.MenuRepo.Count);
            List<Menu> menuList = new List<Menu>()
            {
                menu0,
                menu1,
                menu2
            };
            Assert.AreEqual(menuList.Count, MenuRepo.MenuRepo.Count);
        }
    }
}
