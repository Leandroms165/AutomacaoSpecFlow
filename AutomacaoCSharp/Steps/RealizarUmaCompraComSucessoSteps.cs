using AutomacaoCSharp.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoCSharp.Steps
{
    [Binding]
    public class RealizarUmaCompraComSucessoSteps
    {
        string url = "https://www.saucedemo.com/";
        IWebDriver driver;
        LoginPage loginPage;
        RealizarUmaCompraComSucessoPage realizarUmaCompraComSucessoPage;
        YourInformationPage yourInformationPage;

        [Given(@"eu acesso o site saucedemo")]
        public void DadoEuAcessoOSiteSaucedemo()
        {
            driver = Util.Util.IniciarDriver();
            loginPage = new LoginPage(driver);
        }
        /// <summary>
        /// 
        /// </summary>
        /// 
        
        [When(@"desejo ordenar os produtos 'NAME Z TO A'")]
        public void DesejoOrdenarOsProdutos()
        {
            loginPage.AcessarSite(url);
            loginPage.Login();
            realizarUmaCompraComSucessoPage = new RealizarUmaCompraComSucessoPage(driver);
            realizarUmaCompraComSucessoPage.ClickItem();
         }
        [Then(@"seleciono um produto para compra")]
        public void EntaoEuClicoNoBotaoAddToCart()
        {
            loginPage.AcessarSite(url);
            loginPage.Login();
            realizarUmaCompraComSucessoPage.ClickItem();
        }
        
        [When(@"eu acesso o carinho")]
        public void QuandoEuAcessoOCarinho()
        {
            loginPage.AcessarSite(url);
            loginPage.Login();
            realizarUmaCompraComSucessoPage.ClickAddToCar();
            realizarUmaCompraComSucessoPage.ClickCar();
        }
        
        [When(@"Realizo o checkout")]
        public void QuandoClicoEmCheckout()
        {
            loginPage.AcessarSite(url);
            loginPage.Login();
            realizarUmaCompraComSucessoPage.ClickCar();
            realizarUmaCompraComSucessoPage.Checkout();
           
        }

        [Given(@"que eu preencho o meus dados")]
        public void DadoQueEuPreenchoOMeusDados()
        {
            loginPage.AcessarSite(url);
            loginPage.Login();
            realizarUmaCompraComSucessoPage.ClickCar();
            realizarUmaCompraComSucessoPage.Checkout();
            yourInformationPage = new YourInformationPage(driver);
            yourInformationPage.DadosFist();
            yourInformationPage.DadosLast();
            yourInformationPage.DadosCep();
            yourInformationPage.ClickContinue();
        }
       
        [Then(@"eu finalizo minha compra")]
        public void EntaoEuFinalizoMinhaCompra()
        {
           
            loginPage.AcessarSite(url);
            loginPage.Login();
            realizarUmaCompraComSucessoPage.ClickCar();
            realizarUmaCompraComSucessoPage.Checkout();
            yourInformationPage = new YourInformationPage(driver);
            yourInformationPage.DadosFist();
            yourInformationPage.DadosLast();
            yourInformationPage.DadosCep();
            yourInformationPage.ClickContinue();
            yourInformationPage.ClickFinish();
            
            Util.Util.FinalizarDriver(driver);
        }
    }
}
