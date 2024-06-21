namespace Demo.Auth.Entidades
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public string NumeroDeCuenta { get; set; }
        public decimal SaldoInicial { get; set; }

        // Constructor vacío
        public Cliente() { }

        // Constructor con parámetros
        public Cliente(string nombre, string apellido, string dni, string email, string numeroDeCuenta, decimal saldoInicial)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Email = email;
            NumeroDeCuenta = numeroDeCuenta;
            SaldoInicial = saldoInicial;
        }
    }
}
