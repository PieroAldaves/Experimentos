using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTests
{
    class Nunit
    {
        IWebDriver webDriver;
        [SetUp]
        public void IniarChome()
        {
            webDriver = new ChromeDriver(@"C:\Desarrollador\Experimentos\TB2\Repo_Experimentos-feature-V0.1.0\MetroWeb\MetroWeb.Tests\bin\Debug\chromedriver.exe");
        }

        [Test]
        public void Test1()
        {
            webDriver.Navigate().GoToUrl("www.google.com");
        }

        [TearDown]
        public void Close()
        {
            webDriver.Close();
        }

    }
}