using System;
using System.Collections.Generic;
using System.Text;

namespace Observatorio.LogicaNegocio.Entidades
{
    internal class Observacion
    {
        private static int contadorId = 0;
        public int id { get; set; }
        public DateTime FechaObservacion { get; set; }
        public Prestamo Equipamiento { get; set; }
        public ObjetoCeleste ObjetoObservado { get; set; }
public Observacion(DateTime fechaObservacion, Prestamo equipamiento, ObjetoCeleste objetoObservado)
        {
            id = ++contadorId;
            FechaObservacion = fechaObservacion;
            Equipamiento = equipamiento;
            ObjetoObservado = objetoObservado;
        }
    }
}
