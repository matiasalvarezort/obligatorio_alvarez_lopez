using System;
using System.Collections.Generic;
using System.Text;

namespace Observatorio.LogicaNegocio.Entidades
{
    internal class Ocular : Equipo
    {
        public int DiametroMM { get; set; }
        public int CampoVisualGrados { get; set; }
        public Ocular(string marca, string modelo, int stock, int diametroMM, int campoVisualGrados)
            : base(marca, modelo, stock)
        {
            DiametroMM = diametroMM;
            CampoVisualGrados = campoVisualGrados;
        }
    }
}
