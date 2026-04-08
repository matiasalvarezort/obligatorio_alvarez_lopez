using System;

namespace Observatorio.LogicaNegocio.Entidades
{
    public class Socio
    {
        private static int contadorId = 0;

        public int Id { get; private set; }   
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }

       
        public Socio(string nombre, string direccion, int telefono, string email, string usuario, string password)
        {
            Id = ++contadorId;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            Usuario = usuario;
            Password = password;
        }
    }
}