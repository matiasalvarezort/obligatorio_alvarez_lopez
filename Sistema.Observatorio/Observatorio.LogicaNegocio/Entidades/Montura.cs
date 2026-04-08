using Observatorio.LogicaNegocio.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observatorio.LogicaNegocio.Entidades
{
    internal class Montura:Equipo
    {
        public double CargaUtilKG { get; set; }
        public bool Computarizada { get; set; }
        public TipoMontura montura { get; set; }

        public Montura(string marca, string modelo, int stock, double cargaUtilKG, bool computarizada, TipoMontura tipoMontura)
            : base(marca, modelo, stock)
        {
            CargaUtilKG = cargaUtilKG;
            Computarizada = computarizada;
            montura = tipoMontura;

        }
    }
}
