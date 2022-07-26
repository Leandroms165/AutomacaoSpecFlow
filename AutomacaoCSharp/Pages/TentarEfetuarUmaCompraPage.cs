using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoCSharp.Pages
{
    public class TentarEfetuarUmaCompraPage
    {
        public IWebDriver driver;

        public TentarEfetuarUmaCompraPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void Acessar(string url)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }
        #region Metodos de ação
        private IWebElement Addtoart()
        {
            return driver.FindElement(By.XPath("//*[@id='add-to-cart-sauce-labs-backpack']"));
        }
        public void ClickAddto()
        {
            Addtoart().Click();
        }
        private IWebElement Car()
        {
            return driver.FindElement(By.Id("shopping_cart_container"));
        }
        public void ClickCar()
        {
            Car().Click();
        }
        private IWebElement Checkout()
        {
            return driver.FindElement(By.Id("checkout"));
        }
        public void ClickChekout()
        {
            Checkout().Click();
        }
        
        #endregion
    }
}
