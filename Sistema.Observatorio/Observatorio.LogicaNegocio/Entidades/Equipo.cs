using System;
using System.Collections.Generic;
using System.Text;

namespace Observatorio.LogicaNegocio.Entidades
{
    abstract class Equipo
    {
        private static int contadorId = 0;

        public int Id { get; private set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Stock { get; set; }

    

    public Equipo (string marca, string modelo, int stock)
    {
        Id = ++contadorId;
        Marca = marca;
        Modelo = modelo;
        Stock = stock;
    }

}
}


