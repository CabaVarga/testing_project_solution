using Microsoft.Owin.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace testing_project.Tests
{
    [TestClass]
    public class HttpRequestTest
    {
        [TestMethod]
        public async Task GreetingEndpintShouldReturnHelloWorldMessage()
        {
            // Kao parametar se stavlja klasa koja nam omogucava da pokrenemo owin aplikaciju
            // Kao da smo podigli nasu aplikaciju sa Debug
            using (var server = TestServer.Create<Startup>())
            {
                // Httpclient je nacin da programski pristupimo apijima
                // obrati paznju na URL -> samo api/home, ne localhost etc
                var result = await server.HttpClient.GetAsync("api/home");


                string responseContent = await result.Content.ReadAsStringAsync();
                Assert.AreEqual("\"Hello World\"", responseContent);
            }
        }
    }
}
