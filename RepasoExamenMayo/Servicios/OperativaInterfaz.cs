using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamenMayo.Servicios
{
    internal interface OperativaInterfaz
    {

        public void registroLlegada();

        public void mostrarConsutasPsico();

        public void mostrarConsutasTrauma();

        public void mostrarConsultasFisio();

        public void escribirConsultasPsico();

        public void escribirConsultasTrauma();

        public void escribirConsultasFisio();

    }
}
