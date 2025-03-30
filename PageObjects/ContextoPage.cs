using System;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TesteVericode.PageObjects
{
    public class ContextoPage
    {
        // Driver do Selenium WebDriver
        private readonly IWebDriver driver;
        // URL da página Tricentis
        public const string Url = "https://sampleapp.tricentis.com/101/app.php";

        // Menu
        public IWebElement menuEnterVehicleData => driver.FindElement(By.Id("idealsteps-nav"));
        public IWebElement menuEnterInsurantData => driver.FindElement(By.Id("enterinsurantdata"));
        public IWebElement menuEnterProductData => driver.FindElement(By.Id("enterproductdata"));

        public ContextoPage(IWebDriver _driver)
        {
            // Inicializa o driver
            driver = _driver;
        }

        public void AcessarSistema()
        {
            // Navega para a URL do sistema
            driver.Navigate().GoToUrl(Url);
        }

        public string ObterUrlEsperada()
        {
            // Retorna a URL esperada
            return Url;
        }

        public string ObterUrlAtual()
        {
            // Retorna a URL atual
            return driver.Url;
        }
    }
}

