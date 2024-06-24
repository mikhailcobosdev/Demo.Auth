using Demo.Auth.Entidades;
namespace Demo.Auth.Negocio
{
    public class NegocioCuenta : INegocioCuenta
    {
        public Cuenta CrearCuenta()
        {
            Cuenta cuenta = new Cuenta
            {
                Identificador = Guid.NewGuid().ToString(),
                FechaCreacion = DateTime.Now,
                NumeroCuenta = Guid.NewGuid().ToString(),
                Saldo = 0,
                Titular = "Juan Perez"

            };

            return cuenta;
        }
    }
}
