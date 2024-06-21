using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Auth.Entidades
{
    internal class Cuenta
    {
        public string NumeroCuenta { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
