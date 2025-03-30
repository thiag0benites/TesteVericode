using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using TesteVericode.PageObjects;

namespace TesteVericode.StepDefinitions
{
    [Binding]
    public class EnterInsurantDataSteps
    {
        // Driver do Selenium WebDriver
        private readonly IWebDriver driver;
        // Página de dados do segurado
        private readonly EnterInsurantDataPage enterInsurantDataPage;

        public EnterInsurantDataSteps()
        {
            // Inicializa o driver e a página de dados do segurado
            driver = Hooks.Driver;
            enterInsurantDataPage = new EnterInsurantDataPage(driver);
        }

        [When("preencho os campos do formulario Enter Insurant Data com valores validos")]
        public void WhenPreenchoOsCamposDoFormularioEnterInsurantDataComValoresValidos(DataTable dataTable)
        {
            // Preenche os campos do formulário com valores válidos
            foreach (var row in dataTable.Rows)
            {
                string campo = row["Campo"];
                string valor = row["Valor"];
                enterInsurantDataPage.PreencherCampo(campo, valor);
            }
        }
    }
}

