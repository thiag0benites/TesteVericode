using System;
using OpenQA.Selenium;
using Reqnroll;
using TesteVericode.PageObjects;

namespace TesteVericode.StepDefinitions
{
    [Binding]
    public class ContextoSteps
    {
        private readonly IWebDriver driver;
        private readonly ContextoPage contextoPage;

        public ContextoSteps()
        {
            driver = Hooks.Driver;
            contextoPage = new ContextoPage(driver);
        }

        [Given("que eu acesse a pagina Tricentis")]
        public void GivenQueEuAcesseAPaginaTricentis()
        {
            contextoPage.AcessarSistema();
        }
    }
}
