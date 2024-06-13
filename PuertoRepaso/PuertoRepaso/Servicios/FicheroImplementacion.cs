using PuertoRepaso.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuertoRepaso.Servicios
{
    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void ficheroLog(string mensaje)
        {


            try
            {
                DateTime hoy = DateTime.Now;

                string fechaFormateada = hoy.ToString("dd-MM-yyyy");

                string rutaCarpeta = "C:\\Users\\Carlos\\source\\repos\\PuertoRepaso\\PuertoRepaso\\FicheroLog\\";

                string ruta = string.Concat(rutaCarpeta, "log-" ,fechaFormateada, ".txt");

                using(StreamWriter escribe = new StreamWriter(ruta, true))
                {
                    escribe.Write(mensaje +"\n");
                    escribe.Close();
                }


            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al crear el fichero log " + ex.Message);
            }


        }
        public void vehiculosRegistrados(List<vehiculosDto> listaVehiculos)
        {
            try
            {
                DateTime hoy = DateTime.Now;

                string fechaFormateada = hoy.ToString("dd-MM-yyyy");

                string rutaCarpeta = "C:\\Users\\Carlos\\source\\repos\\PuertoRepaso\\PuertoRepaso\\";

                string ruta = string.Concat(rutaCarpeta, fechaFormateada, "-entidad.txt");

                using(StreamWriter escribeN = new StreamWriter(ruta, true))
                {
                    foreach(vehiculosDto vehiculos in listaVehiculos)
                    {

                        string texto = string.Concat(vehiculos.Matricula,";", vehiculos.Tipo,";", vehiculos.ZonaDestino,
                        ";", vehiculos.Mercancia,";", vehiculos.FechaDePaso,";", vehiculos.Revision);
                        escribeN.Write(texto + "\n");
                        
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al crear el fichero de vehiculos " + ex.Message);
            }
        }

    }
}
