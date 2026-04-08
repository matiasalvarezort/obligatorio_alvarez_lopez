using System;
using System.Collections.Generic;
using System.Text;

namespace Observatorio.LogicaNegocio.Entidades
{
    internal class Telescopio : Equipo
    {
  

        public int AperturaMM { get; set; }
        public string RelacionFocal { get; set; }

        public string DistanciaFocalMM { get; set; }
        public double PesoKG { get; set; }

        public Telescopio(string marca, string modelo, int stock, int aperturaMM, string relacionFocal, string distanciaFocalMM, double pesoKG)
            : base(marca, modelo, stock)
        {
            AperturaMM = aperturaMM;
            RelacionFocal = relacionFocal;
            DistanciaFocalMM = distanciaFocalMM;
            PesoKG = pesoKG;
        }


    }
}
