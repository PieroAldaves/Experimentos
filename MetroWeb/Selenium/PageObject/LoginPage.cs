using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.PageObject
{
    public class LoginPage
    {
        protected IWebDriver Driver;

        protected By UserInput = By.Id("Usuario");
        protected By PasswordInput = By.Id("Contrasenia");
        protected By LoginButton = By.Id("buttonlogin");



        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
            if (!Driver.Title.Equals("Login - MetroWeb"))
                throw new Exception("No es la Login Page");
        }


        public void TypeUserName(string user)
        {
            Driver.FindElement(UserInput).SendKeys(user);
        }

        public void TypeUserPassword(string password)
        {
            Driver.FindElement(PasswordInput).SendKeys(password);
        }

        public void ClickLogin()
        {
            Driver.FindElement(LoginButton).Click();
        }


        public UserPage LoginAs(string user, string pass)
        {
            TypeUserName(user);
            TypeUserPassword(pass);
            ClickLogin();
            return new UserPage(Driver);
        }

    }
}
