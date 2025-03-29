using System;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TesteVericode.PageObjects
{
    public class ContextoPage
    {
        private readonly IWebDriver driver;
        public const string Url = "https://sampleapp.tricentis.com/101/app.php";

        public ContextoPage(IWebDriver _driver)
        {
            driver = _driver;
        }

        public void AcessarSistema()
        {
            driver.Navigate().GoToUrl(Url);
        }

        public string ObterUrlEsperada()
        {
            return Url;
        }

        public string ObterUrlAtual()
        {
            return driver.Url;
        }
    }
}
