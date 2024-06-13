using RepasoExamenMayo.Controladores;
using RepasoExamenMayo.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamenMayo.Servicios
{
    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void cargaInicial()
        {

            string carga = "C:\\Users\\Carlos\\Desktop\\Prog\\ExamenMayo110624-main\\RepasoExamenMayo\\citasPrevias.txt";

            try
            {

                using (StreamReader lee = new StreamReader(carga))
                {

                    string linea;

                    while((linea = lee.ReadLine()) != null) {
                    
                        citas citasNuevas = new citas();
                        string[] separa = linea.Split(";");
                        citasNuevas.Dni = separa[0];
                        citasNuevas.Nombre = separa[1];
                        citasNuevas.Apellidos = separa[2];
                        citasNuevas.Especialidad = separa[3];
                        citasNuevas.Fecha = Convert.ToDateTime(separa[4]);
                        citasNuevas.Asistencia = Convert.ToBoolean(separa[5]);

                        Program.citas.Add(citasNuevas);
                    
                    }

                }

            }catch (Exception ex)
            {
                Console.WriteLine("Error en la carga inicial" + ex.ToString());
            }

        }
        public void ficheroLog(string mensaje)
        {

            

            try {
                DateTime fechaHoy = DateTime.Now;

                string fecha = fechaHoy.ToString("ddMMyyyy");
                string ruta = "C:\\Users\\Carlos\\Desktop\\Prog\\ExamenMayo110624-main\\RepasoExamenMayo\\CarpetaLog\\";
                string nombreLog = $"log-{fecha}.txt";
                string rutaFinal = string.Concat(ruta, nombreLog);

            using(StreamWriter escribe = new StreamWriter(rutaFinal, true)) {

                escribe.Write(mensaje + "\n");
                escribe.Close();
         
            }
            
            }catch(Exception ex)
            {
                Console.WriteLine("Error al escribir en el fichero log" + ex.ToString());
            }


        }

        public void ficheroCitas(string frase)
        {
            try { 
            DateTime fechaHoy = DateTime.Now;
            string fechaformateada = fechaHoy.ToString("ddMMyyyy");

            string nombreFichero = string.Concat($"citasConAsistencia-", fechaformateada, ".txt");

            string ruta = string.Concat("C:\\Users\\Carlos\\Desktop\\Prog\\ExamenMayo110624-main\\RepasoExamenMayo\\", nombreFichero);

            using (StreamWriter escribe = new StreamWriter(ruta, true))
            {
                escribe.Write(frase + "\n");
                escribe.Close();
            }
            
            }catch(Exception ex) 
            { 
                Console.WriteLine("Error en el fichero citas " + ex.ToString()); 
            }

        }
    }
}
