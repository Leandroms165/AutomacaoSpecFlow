using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoCSharp.Pages
{
    public class YourInformationPage
    {
        private IWebDriver driver;

        public YourInformationPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void AcessarSite(string url)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

        #region Metodos de ação
        private IWebElement FirstName()
        {
            return driver.FindElement(By.Name("firstName"));
        } 
        public void DadosFist()
        {
            FirstName().SendKeys("Geraldo");
        }
        private IWebElement LastName()
        {
            return driver.FindElement(By.Name("lastName"));
        }
        public void DadosLast()
        {
            LastName().SendKeys("Fonseca");
        }
        private IWebElement Cep()
        {
            return driver.FindElement(By.Name("postalCode"));
        }
        public void DadosCep()
        {
            Cep().SendKeys("306095554");
        }
        private IWebElement ButtonContinue()
        {
            return driver.FindElement(By.Name("continue"));
        }
        public void ClickContinue()
        {
            ButtonContinue().Click();
        }
        private IWebElement Finish()
        {
            return driver.FindElement(By.Name("finish"));
        }
        public void ClickFinish()
        {
            Finish().Click();
        }
        #endregion

        //public void teste (IWebDriver driver)
        //{
        //    

        //}
        
    }

}