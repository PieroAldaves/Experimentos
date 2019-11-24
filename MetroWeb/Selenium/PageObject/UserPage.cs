using OpenQA.Selenium;
using Selenium.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.PageObject
{
    public class UserPage
    {
        protected IWebDriver Driver;

        protected By Form = By.Id("form");




        public UserPage(IWebDriver driver)
        {
            Driver = driver;
            if (!Driver.Title.Equals("Home Page - MetroWeb"))
                throw new Exception("No es la Login Page");
        }


        public bool FromIsPresent()
        {
            //return WaitHandler.ElementisPresent(Driver, Form);
            if (Driver.Title.Equals("Home Page - MetroWeb"))
            {
                return true;
            }
            return false;
        }

    }
}
