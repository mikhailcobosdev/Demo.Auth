using System;
using TechTalk.SpecFlow;

namespace Demo.Auth.BDD.StepDefinitions
{
    [Binding]
    public class CreacionDeUnaCuentaDigitalStepDefinitions
    {
        [Given(@"que estoy en la página de de creación de cuenta digital")]
        public void GivenQueEstoyEnLaPaginaDeDeCreacionDeCuentaDigital()
        {
            //throw new PendingStepException();
        }

        [Given(@"los Datos del cliente '([^']*)' ,'([^']*)', '([^']*)'")]
        public void GivenLosDatosDelCliente(string nombre, string apellido, string fechaNacimiento)
        {
            //throw new PendingStepException();
        }

        [When(@"pulso sobre el boton de Crear cuenta")]
        public void WhenPulsoSobreElBotonDeCrearCuenta()
        {
            //throw new PendingStepException();
        }

        [Then(@"Cuenta digital creada")]
        public void ThenCuentaDigitalCreada()
        {
            //throw new PendingStepException();
        }

        [Given(@"los Datos del cliente  '([^']*)'")]
        public void GivenLosDatosDelCliente(string p0)
        {
            //throw new PendingStepException();
        }

        [Then(@"Error cliente no existe")]
        public void ThenErrorClienteNoExiste()
        {
            //throw new PendingStepException();
        }
    }
}
