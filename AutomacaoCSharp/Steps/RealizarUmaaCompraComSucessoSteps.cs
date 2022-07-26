using AutomacaoCSharp.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoCSharp.Steps
{
    [Binding]
    public class RealizarUmaaCompraComSucessoSteps
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
        
        [Given(@"desejo ordenar os produtos '(.*)'")]
        public void DadoDesejoOrdenarOsProdutos(string p0)
        {
            loginPage.AcessarSite(url);
            loginPage.Login();
            realizarUmaCompraComSucessoPage = new RealizarUmaCompraComSucessoPage(driver);
            realizarUmaCompraComSucessoPage.Fist();

        }
        
        [When(@"seleciono um produto para compra")]
        public void QuandoSelecionoUmProdutoParaCompra()
        {
            realizarUmaCompraComSucessoPage.ClickItem();
        }
        
        [When(@"eu acesso o carinho")]
        public void QuandoEuAcessoOCarinho()
        {
            realizarUmaCompraComSucessoPage.ClickCar();
        }
        
        [When(@"Realizo o checkout")]
        public void QuandoRealizoOCheckout()
        {
            realizarUmaCompraComSucessoPage.Checkout();

        }

        [Then(@"eu finalizo minha compra")]
        public void EntaoEuFinalizoMinhaCompra()
        {
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
