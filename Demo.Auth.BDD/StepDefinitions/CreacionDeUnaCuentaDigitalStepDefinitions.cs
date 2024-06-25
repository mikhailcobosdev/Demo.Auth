using System;
using TechTalk.SpecFlow;

namespace Demo.Auth.BDD.StepDefinitions
{
    [Binding]
    public class CreacionDeUnaCuentaDigitalStepDefinitions
    {
        [Given(@"La página de registro de cuenta")]
        public void GivenLaPaginaDeRegistroDeCuenta()
        {
            throw new PendingStepException();
        }

        [Given(@"los Datos del cliente \[Juan, Pérez, (.*)A, jperez@banco\.com, (.*)]")]
        public void GivenLosDatosDelClienteJuanPerezAJperezBanco_Com(string nombre, string apellido, string identificacion, string email, string telefono)
        {
            throw new PendingStepException();
        }

        [When(@"pulson sobre el boton de Crear cuenta")]
        public void WhenPulsonSobreElBotonDeCrearCuenta()
        {
            throw new PendingStepException();
        }

        [Then(@"Cuenta digital creada")]
        public void ThenCuentaDigitalCreada()
        {
            throw new PendingStepException();
        }
    }
}
