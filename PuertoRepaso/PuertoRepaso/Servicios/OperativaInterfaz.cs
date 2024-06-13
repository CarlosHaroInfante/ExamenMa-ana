using PuertoRepaso.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuertoRepaso.Servicios
{
    internal interface OperativaInterfaz
    {
        public void recogidaInformancion(List<vehiculosDto> listaVehiculos);

        public void pif(List<vehiculosDto> listaVehiculos);
    }
}
