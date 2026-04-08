using Observatorio.LogicaNegocio.Enumeraciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observatorio.LogicaNegocio.Entidades
{
    internal class Camara: Equipo
    {
        public TipoCamara Sensor { get; set; }
        public string ResolucionPX { get; set; }
        public double PIxelSizeUM { get; set; }
        public Camara(string marca, string modelo, int stock, TipoCamara sensor, string resolucionPX, double pixelSizeUM)
            : base(marca, modelo, stock)
        {
            Sensor = sensor;
            ResolucionPX = resolucionPX;
            PIxelSizeUM = pixelSizeUM;
        }
    }
}
