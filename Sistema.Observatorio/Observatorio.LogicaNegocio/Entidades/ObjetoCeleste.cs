using Observatorio.LogicaNegocio.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observatorio.LogicaNegocio.Entidades
{
    internal class ObjetoCeleste
    {
        private static int contadorId = 0;
        public int id { get; set; }
        public string Nombre { get; set; }
        public TipoObjetoCeleste ObjCeleste { get; set; }
        public double Magnitud { get; set; }
        public ObjetoCeleste(string nombre, TipoObjetoCeleste objCeleste, double magnitud)
        {
            id = ++contadorId;
            Nombre = nombre;
            ObjCeleste = objCeleste;
            Magnitud = magnitud;
        }

    }
}
