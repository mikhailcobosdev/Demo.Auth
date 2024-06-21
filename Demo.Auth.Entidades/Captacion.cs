using System;

namespace Demo.Auth.Entidades
{
    public class Captacion
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; } // Por ejemplo, depósito, transferencia, etc.
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public Captacion() { }

        public Captacion(decimal monto, DateTime fecha, string tipo, int clienteId)
        {
            Monto = monto;
            Fecha = fecha;
            Tipo = tipo;
            ClienteId = clienteId;
        }
    }
}

