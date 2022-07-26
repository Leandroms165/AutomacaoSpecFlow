using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoCSharp.Pages
{
    public class LoginPage
    {
        public IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AcessarSite(string url)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

       
        private IWebElement Username()
        {
            return driver.FindElement(By.Id("user-name"));
        }
        private IWebElement Password()
        {
            return driver.FindElement(By.Id("password"));
        }
        private IWebElement Button()
        {
            return driver.FindElement(By.Id("login-button"));
        }

        #region Login realizar uma compra com sucesso
        public void Login()
        {
            Username().SendKeys("performance_glitch_user");
            Password().SendKeys("secret_sauce");
            Button().Click();
        }
        #endregion
        //public void LoginTwo(string url)
        //{
        //    Username().SendKeys("problem_use");
        //    Password().SendKeys("secret_sauce");
        //    Button().Click();
        //}
    }
}
