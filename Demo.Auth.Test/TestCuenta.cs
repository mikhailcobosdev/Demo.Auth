using Demo.Auth.Negocio;
using Demo.Auth.Servicio.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Demo.Auth.Test
{
    [TestClass]
    public class TestCuenta
    {
        [TestMethod]
        public void CrearCuentaTest()
        {
            // Arrange
            var mock = new Mock<INegocioCuenta>();
            mock.Setup(x => x.CrearCuenta()).Returns(new Entidades.Cuenta { });
            var controller = new CuentaController(null, mock.Object);

            // Act
            var result = controller.Get();

            // Assert
            Assert.AreEqual(200, ((OkObjectResult)result).StatusCode);
        }
    }
}