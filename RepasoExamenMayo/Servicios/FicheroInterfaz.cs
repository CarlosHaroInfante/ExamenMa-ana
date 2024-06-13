using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamenMayo.Servicios
{
    internal interface FicheroInterfaz
    {
        public void cargaInicial();

        public void ficheroLog(string mensaje);

        public void ficheroCitas(string frase);
    }
}
