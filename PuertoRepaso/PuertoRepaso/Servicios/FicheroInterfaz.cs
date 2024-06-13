using PuertoRepaso.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuertoRepaso.Servicios
{
    internal interface FicheroInterfaz
    {
        public void ficheroLog(string mensaje);

        public void vehiculosRegistrados(List<vehiculosDto> listaVehiculos);
    }
}
