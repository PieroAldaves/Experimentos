using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.TestCases
{
    [TestFixture]
    public class LoginTest
    {
        protected IWebDriver Driver;

        [SetUp]
        public void BeforeTest()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://localhost:44352/Cuenta/Login");
        }

        [Test]
        public void SuccessLoginTest()
        {
            LoginPage loginpage = new LoginPage(Driver);
            UserPage userpage = loginpage.LoginAs("OSCARRDA", "12345");

            Assert.IsTrue(userpage.FromIsPresent());
        }

        [TearDown]
        public void AfterTest()
        {
            if(Driver != null)
            {
                Driver.Quit();
            }

        }
    }
}
