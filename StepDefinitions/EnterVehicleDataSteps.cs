using System;
using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;
using TesteVericode.PageObjects;

namespace TesteVericode.StepDefinitions
{
    [Binding]
    public class EnterVehicleDataSteps
    {
        private readonly IWebDriver driver;
        private readonly EnterVehicleDataPage enterVehicleDataPage;

        public EnterVehicleDataSteps()
        {
            driver = Hooks.Driver;
            enterVehicleDataPage = new EnterVehicleDataPage(driver);
        }

        [When("o [Campo] for preenchido com [Valor] invalido e exibido o [Aviso]")]
        public void WhenOCampoForPreenchidoComValorInvalidoEExibidoOAviso(Table dataTable)
        {
            foreach (var row in dataTable.Rows)
            {
                string campo = row["Campo"];
                string valor = row["Valor"];
                string aviso = row["Aviso"];

                // Aqui você pode usar os valores para preencher os campos e verificar os avisos
                // Exemplo:
                enterVehicleDataPage.PreencherCampo(campo, valor);
                string mensagemAviso = enterVehicleDataPage.ObterMensagemAviso(campo);
                Assert.AreEqual(aviso, mensagemAviso, $"O aviso esperado para o campo {campo} não foi exibido.");
            }
        }

        [When("preencho os campos com valores validos")]
        public void WhenPreenchoOsCamposComValoresValidos(DataTable dataTable)
        {
            foreach (var row in dataTable.Rows)
            {
                string campo = row["Campo"];
                string valor = row["Valor"];

                // Aqui você pode usar os valores para preencher os campos
                // Exemplo:
                enterVehicleDataPage.PreencherCampo(campo, valor);
            }
        }

        [When("clico no botao Next")]
        public void WhenClicoNoBotaoNext()
        {
            enterVehicleDataPage.ClicarProximo();
        }

        [Then("deve ser apresentado o formulario {string}")]
        public void ThenDeveSerApresentadoOFormulario(string itemMenu)
        {
            Assert.True(enterVehicleDataPage.ValidaAcessoMenu(itemMenu));
        }

    }
}
