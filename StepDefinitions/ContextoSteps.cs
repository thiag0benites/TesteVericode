using System;
using AngleSharp.Dom;
using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;
using TesteVericode.PageObjects;
using TesteVericode.Support;

namespace TesteVericode.StepDefinitions
{
    [Binding]
    public class ContextoSteps
    {
        // Driver do Selenium WebDriver
        private readonly IWebDriver driver;
        // Página de contexto
        private readonly ContextoPage contextoPage;

        public ContextoSteps()
        {
            // Inicializa o driver e a página de contexto
            driver = Hooks.Driver;
            contextoPage = new ContextoPage(driver);
        }

        [Given("que eu acesse a pagina Tricentis")]
        public void GivenQueEuAcesseAPaginaTricentis()
        {
            // Acessa a página Tricentis e verifica a URL
            contextoPage.AcessarSistema();
            string urlEsperada = contextoPage.ObterUrlEsperada();
            string urlAtual = contextoPage.ObterUrlAtual();
            Assert.AreEqual(urlEsperada, urlAtual, $"Falha ao acessar a URL esperada. URL atual: {urlAtual}");
        }

        [When("clico no botao Next do formulario {string}")]
        public void WhenClicoNoBotaoNextDoFormulario(string formulario)
        {
            // Clica no botão Next do formulário especificado
            switch (formulario)
            {
                case "Enter Vehicle Data":
                    EnterVehicleDataPage enterVehicleDataPage = new EnterVehicleDataPage(driver);
                    WebUtils.ClicarBotaoProximo(enterVehicleDataPage.btnNext);
                    break;
                case "Enter Insurant Data":
                    EnterInsurantDataPage enterInsurantDataPage = new EnterInsurantDataPage(driver);
                    WebUtils.ClicarBotaoProximo(enterInsurantDataPage.btnNext);
                    break;
            }
        }

        public bool ValidaAcessoMenu(IWebElement elementMenu)
        {
            // Valida se o menu está acessível
            string fontWeight = elementMenu.GetCssValue("font-weight");
            return fontWeight == "bold" || fontWeight == "700";
        }

        [When("deve ser apresentado o formulario {string}")]
        public void WhenDeveSerApresentadoOFormulario(string itemMenu)
        {
            // Verifica se o formulário especificado está acessível
            switch (itemMenu)
            {
                case "Enter Vehicle Data":
                    Assert.True(ValidaAcessoMenu(contextoPage.menuEnterVehicleData));
                    break;
                case "Enter Insurant Data":
                    Assert.True(ValidaAcessoMenu(contextoPage.menuEnterInsurantData));
                    break;
                case "Enter Product Data":
                    Assert.True(ValidaAcessoMenu(contextoPage.menuEnterProductData));
                    break;
            }
        }
    }
}

