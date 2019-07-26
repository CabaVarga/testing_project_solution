using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testing_project.Controllers;

namespace testing_project.Tests.Controllers
{
    [TestClass]
    public class AssertExampleTest
    {
        [TestMethod]
        public void GreetingShouldReturnMessage()
        {
            var controller = new HomeController();
            controller.Request = new System.Net.Http.HttpRequestMessage();
            controller.RequestContext = new System.Web.Http.Controllers.HttpRequestContext();

            Assert.AreEqual("Hello World", controller.GetGreeting());
        }
    }
}
