using API_Interactive_Lab_1.Controllers;
using NUnit.Framework;

namespace API_Interactive_Lab_1.Tests
{
    public class HomeControllerTests
    {                

        [Test]
        public void TestGetHome()
        {
            string expectedContent = "Welcome to the Drinks API!";

            var controller = new HomeController();

            var result = controller.Get();

            Assert.AreEqual(expectedContent, result);
        }
    }
}
