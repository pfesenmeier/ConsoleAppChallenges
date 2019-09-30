using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _07_Challenge_Repository;

namespace _07_Challenge_UnitTests
{
    [TestClass]
    public class Challenge_UnitTests
    {
        
        public Repository repository = new Repository();
            
        
        [TestMethod]
        public void CheckIfEveryFoodHasAnEntryInPriceDictionary()
        {
            //check if every Food type is in the Price Dictionary 
            foreach (var food in (Repository.Food[])Enum.GetValues(typeof(Repository.Food)))
            {
                Assert.IsNotNull(repository.Prices[food]);
            }
        }
        [TestMethod]
        public void TotalTickets()
        {
            repository.TicketCounter[Repository.Food.Hamburger] += 42;
            Assert.AreEqual(42, repository.TotalTickets());
        }
    }
}
