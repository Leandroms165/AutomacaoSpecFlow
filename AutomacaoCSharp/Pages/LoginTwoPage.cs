using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoCSharp.Pages
{
    public class LoginTwoPage
    {
        private IWebDriver driver;

        public LoginTwoPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void AcessarSite(string url)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

        private IWebElement UsernameTwo()
        {
            return driver.FindElement(By.XPath("//*[@id='user-name']"));
        }
        private IWebElement PasswordTwo()
        {
            return driver.FindElement(By.XPath("//*[@id='password']"));
        }
        private IWebElement ButtonTwo()
        {
            return driver.FindElement(By.Id("login-button"));
        }
        public void LoginTwo()
        {
            UsernameTwo().SendKeys("problem_user");
            PasswordTwo().SendKeys("secret_sauce");
            ButtonTwo().Click();
        }
    }
}
