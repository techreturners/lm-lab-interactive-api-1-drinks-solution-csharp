using API_Interactive_Lab_1.Controllers;
using API_Interactive_Lab_1.Models;
using NUnit.Framework;

namespace API_Interactive_Lab_1.Tests
{
    public class CoffeeControllerTests
    {

        [Test]
        public void Test_Get_CoffeeLover()
        {
            string expectedContent = "I like coffee!";

            var controller = new CoffeeController();

            var result = controller.GetCoffeeLover();

            Assert.AreEqual(expectedContent, result);
        }

        [Test]
        public void Test_Get_Coffee_No_Params()
        {
            Coffee expected = new Coffee { Name = "latte", Id = -1 };

            var controller = new CoffeeController();

            var result = controller.Get(null);

            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);
        }

        [Test]
        public void Test_Get_Coffee_By_Name()            
        {
            string name = "cappuccino";

            Coffee expected = new Coffee { Name = name, Id = 7 };

            var controller = new CoffeeController();

            var result = controller.Get(name);

            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);
        }
    }
}
