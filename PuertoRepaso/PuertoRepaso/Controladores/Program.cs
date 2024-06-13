using PuertoRepaso.Dtos;
using PuertoRepaso.Servicios;

namespace PuertoRepaso.Controladores
{


    class Program
    {

        public static void Main(string[] args)
        {

            List<vehiculosDto> vehiculos = new List<vehiculosDto>();

            OperativaInterfaz operativa = new OperativaImplementacion();
            FicheroInterfaz fichero = new FicheroImplementacion();

            operativa.recogidaInformancion(vehiculos);

            operativa.pif(vehiculos);

            foreach(vehiculosDto vehiculo  in vehiculos)
            {
                string texto = string.Concat("Matricula: ", vehiculo.Matricula, " Tipo de vehiculo: ", vehiculo.Tipo, " Zona de destino: ", vehiculo.ZonaDestino, 
                    " mercancia: ", vehiculo.Mercancia, " fecha de paso por control: ", vehiculo.FechaDePaso, " revisión: ", vehiculo.Revision);

                Console.WriteLine(texto);
            }

            fichero.vehiculosRegistrados(vehiculos);
        }


    }


}