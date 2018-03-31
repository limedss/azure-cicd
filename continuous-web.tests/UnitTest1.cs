using Microsoft.VisualStudio.TestTools.UnitTesting;
using continuous_web.Controllers;

namespace ContinuousWeb.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void AboutPageTest()
        {
            var homeController = new HomeController();
            var result = homeController.About();
        }
    }
}