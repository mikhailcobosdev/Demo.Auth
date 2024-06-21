using System;

namespace Demo.Auth.Entidades
{
    public class Canal
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Canal() { }

        public Canal(string nombre, string descripcion, DateTime fechaCreacion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            FechaCreacion = fechaCreacion;
        }
    }
}
