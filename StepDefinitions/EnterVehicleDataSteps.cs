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
        // Driver do Selenium WebDriver
        private readonly IWebDriver driver;
        // Página de dados do veículo
        private readonly EnterVehicleDataPage enterVehicleDataPage;

        public EnterVehicleDataSteps()
        {
            // Inicializa o driver e a página de dados do veículo
            driver = Hooks.Driver;
            enterVehicleDataPage = new EnterVehicleDataPage(driver);
        }

        [When("o [Campo] for preenchido com [Valor] invalido e exibido o [Aviso]")]
        public void WhenOCampoForPreenchidoComValorInvalidoEExibidoOAviso(Table dataTable)
        {
            // Preenche campos com valores inválidos e verifica avisos
            foreach (var row in dataTable.Rows)
            {
                string campo = row["Campo"];
                string valor = row["Valor"];
                string aviso = row["Aviso"];
                enterVehicleDataPage.PreencherCampo(campo, valor);
                string mensagemAviso = enterVehicleDataPage.ObterMensagemAviso(campo);
                Assert.AreEqual(aviso, mensagemAviso, $"O aviso esperado para o campo {campo} não foi exibido.");
            }
        }

        [When("preencho os campos do formulario Enter Vehicle Data com valores validos")]
        public void WhenPreenchoOsCamposDoFormularioEnterVehicleDataComValoresValidos(DataTable dataTable)
        {
            // Preenche campos com valores válidos
            foreach (var row in dataTable.Rows)
            {
                string campo = row["Campo"];
                string valor = row["Valor"];
                enterVehicleDataPage.PreencherCampo(campo, valor);
            }
        }
    }
}

