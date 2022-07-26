using AutomacaoCSharp.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoCSharp.Steps
{
    [Binding]
    public class TentarRealizarUmaCompraSteps
    {
        string url = "https://www.saucedemo.com/";
        IWebDriver driver;
        LoginTwoPage loginTwoPage;
        TentarEfetuarUmaCompraPage tentarEfetuarUmaCompraPage;
       

        [Given(@"que eu acesso o site saucedemo com meu login")]
        public void DadoQueEuAcessoOSiteSaucedemoComMeuLogin()
        {
            driver = new ChromeDriver();
            loginTwoPage = new LoginTwoPage(driver);
            loginTwoPage.AcessarSite(url);
          
        }
        
        [Then(@"adiciono um produto no carrinho pelo botão ADD TO CART")]
        public void EntaoAdicionoUmProdutoNoCarrinhoPeoBotaoADDTOCART()
        {
            loginTwoPage.LoginTwo();
            tentarEfetuarUmaCompraPage = new TentarEfetuarUmaCompraPage(driver);
            tentarEfetuarUmaCompraPage.ClickAddto();
        }
        
        [Then(@"Tento realizar o chekout do produto")]
        public void EntaoTentoRealizarOChekoutDoProduto()
        {
            tentarEfetuarUmaCompraPage.ClickCar();
            tentarEfetuarUmaCompraPage.ClickChekout();
            Util.Util.FinalizarDriver(driver);

        }
    }
}
