using System;
using System.Collections.Generic;
using System.Text;

namespace Observatorio.LogicaNegocio.Entidades
{
    internal class PrestamoDatos
    {
        private static int contadorId = 0;
        public int id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Telescopio TelescopioPrestado { get; set; }
        public Ocular OcularPrestado { get; set; }
        public Camara CamaraPrestada { get; set; }
        public Montura MonturaPrestada { get; set; }
        public PrestamoDatos(DateTime fechaInicio, DateTime fechaFin, Telescopio telescopioPrestado, Ocular ocularPrestado, Camara camaraPrestada, Montura monturaPrestada)
        {
            id = ++contadorId;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            TelescopioPrestado = telescopioPrestado;
            OcularPrestado = ocularPrestado;
            CamaraPrestada = camaraPrestada;
            MonturaPrestada = monturaPrestada;
        }
    }
}
