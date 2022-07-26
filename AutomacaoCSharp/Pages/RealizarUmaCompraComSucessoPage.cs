using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoCSharp.Pages
{
    public class RealizarUmaCompraComSucessoPage
    {

        private IWebDriver driver;

        public RealizarUmaCompraComSucessoPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void AcessarSite(string url)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }
        #region Metodos de ação
        private IWebElement AddToCart()
        {
            return driver.FindElement(By.ClassName("inventory_item_name"));
        }

        public void ClickItem()
        {
            AddToCart().Click();
        }
        private IWebElement AddToCar()
        {
            return driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        }
        public void ClickAddToCar()
        {
            AddToCar().Click();
        }
        private IWebElement Carrinho()
        {
            return driver.FindElement(By.ClassName("shopping_cart_link"));
        }
        public void ClickCar()
        {
            Carrinho().Click();
        }

        private IWebElement ClickCheckout()
        {
            return driver.FindElement(By.Name("checkout"));
        }
        public void Checkout()
        {
            ClickCheckout().Click();
        }

        #endregion
        private IWebElement Clickt()
        {
            return driver.FindElement(By.ClassName("product_sort_container"));
        }
        public void Fist()
        {
            new SelectElement(Clickt()).SelectByText("Name (Z to A)");
        }
    }
}
