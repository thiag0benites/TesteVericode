using System;
using NUnit.Framework;
using Reqnroll;

namespace TesteVericode.StepDefinitions
{
    [Binding]
    public class EnterVehicleDataSteps
    {
        [When("acessar a pagina Tricentis")]
        public void WhenAcessarAPaginaTricentis()
        {
            Assert.True(true);
        }

        [Then("o formulario Enter Vehicle Data deve ser exibido com os campos unicos")]
        public void ThenOFormularioEnterVehicleDataDeveSerExibidoComOsCamposUnicos(DataTable dataTable)
        {
            Assert.True(false);
        }
    }
}
