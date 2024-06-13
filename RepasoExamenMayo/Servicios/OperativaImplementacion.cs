
using RepasoExamenMayo.Controladores;
using RepasoExamenMayo.Dtos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamenMayo.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {

        public void registroLlegada()
        {

            Console.WriteLine("DNI del paciente");
            string dni = Console.ReadLine();

                if (dniValido(dni))
                {

                bool tieneCita = false;
                DateTime fechaHoy = DateTime.Today;

                    foreach(citas citasPrevias in Program.citas)
                    {
                        if(citasPrevias.Dni == dni && citasPrevias.Fecha.Date == fechaHoy)
                        {
                        Console.WriteLine(citasPrevias.Nombre + " " + citasPrevias.Apellidos + " Espere su turno para la consulta de Psicología en la sala de espera. Su especialista le avisará.");
                        citasPrevias.Asistencia = true; 
                        tieneCita = true;
                        break;
                        }

                    }
                    
                    if (!tieneCita)
                    {
                        Console.WriteLine("No dispone de fecha de cita para hoy");
                    }
                }
               
                
            else
            {
                Console.WriteLine("Su dni no es válido");
            }



        }

        public void mostrarConsutasPsico()
        {


            Console.WriteLine("Fecha de la cita [dd-MM-yyyy]");
            string fecha = Console.ReadLine();  
            try
            {
                DateTime fechaN = DateTime.ParseExact(fecha, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                

                bool tieneCita = false;

               foreach(citas cita in Program.citas)
               {

                     if(fechaN.Date.Equals(cita.Fecha.Date) && cita.Especialidad.Equals("Psicología"))
                     {

                        Console.WriteLine("Nombre Completo: " + cita.Nombre + " " + cita.Apellidos + ",  Hora: " + cita.Fecha.Hour + ":" + cita.Fecha.Minute);
                        tieneCita = true;

                     }

               }

               if(!tieneCita)
               {
                  Console.WriteLine("No dispone de fecha de cita para hoy");
               }


            }
            catch (FormatException)
            {
                Console.WriteLine("Formato de fecha no válido. Intente nuevamente.");
            }
            


        }

        public void mostrarConsutasTrauma()
        {

            Console.WriteLine("Fecha de la cita [dd-MM-yyyy]");
            string fecha = Console.ReadLine();
            try
            {
                DateTime fechaN = DateTime.ParseExact(fecha, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                

                bool tieneCita = false;

                foreach (citas cita in Program.citas)
                {

                    if (fechaN.Date.Equals(cita.Fecha.Date) && cita.Especialidad.Equals("Traumatología"))
                    {

                        Console.WriteLine("Nombre Completo: " + cita.Nombre + " " + cita.Apellidos + ",  Hora: " + cita.Fecha.Hour + ":" + cita.Fecha.Minute);
                        tieneCita = true;

                    }

                }

                if (!tieneCita)
                {
                    Console.WriteLine("No dispone de fecha de cita para hoy");
                }


            }
            catch (FormatException)
            {
                Console.WriteLine("Formato de fecha no válido. Intente nuevamente.");
            }

        }
        public void mostrarConsultasFisio()
        {

            Console.WriteLine("Fecha de la cita [dd-MM-yyyy]");
            string fecha = Console.ReadLine();
            try
            {
                DateTime fechaN = DateTime.ParseExact(fecha, "dd-MM-yyyy", CultureInfo.InvariantCulture);
                

                bool tieneCita = false;

                foreach (citas cita in Program.citas)
                {

                    if (fechaN.Date.Equals(cita.Fecha.Date) && cita.Especialidad.Equals("Fisioterapia"))
                    {

                        Console.WriteLine("Nombre Completo: " + cita.Nombre + " " + cita.Apellidos + ",  Hora: " + cita.Fecha.Hour + ":" + cita.Fecha.Minute);
                        tieneCita = true;

                    }

                }

                if (!tieneCita)
                {
                    Console.WriteLine("No dispone de fecha de cita para hoy");
                }


            }
            catch (FormatException)
            {
                Console.WriteLine("Formato de fecha no válido. Intente nuevamente.");
            }

        }

        public void escribirConsultasPsico()
        {
            FicheroInterfaz fichero = new FicheroImplementacion();
            Console.WriteLine("Fecha de la cita [dd-MM-yyyy]");
            string fecha = Console.ReadLine();
            string texto = "";
            try
            {
                DateTime fechaN = DateTime.ParseExact(fecha, "dd-MM-yyyy", CultureInfo.InvariantCulture);


                bool tieneCita = false;

                foreach (citas cita in Program.citas)
                {

                    if (fechaN.Date.Equals(cita.Fecha.Date) && cita.Especialidad.Equals("Psicología") && cita.Asistencia.Equals(true))
                    {

                        texto = string.Concat("Nombre Completo: " , cita.Nombre , " " , cita.Apellidos , ",  Hora: " , cita.Fecha.Hour , ":" ,cita.Fecha.Minute);
                        fichero.ficheroCitas(texto);
                        Console.WriteLine("Escrito correctamente");
                        tieneCita = true;

                    }

                }

                if (!tieneCita)
                {
                    texto = "No hay datos disponibles para la especialidad y fecha indicada.";
                    fichero.ficheroCitas(texto);
                    Console.WriteLine("No hay datos disponibles para la especialidad y fecha indicada.");

                }


            }
            catch (FormatException)
            {
                Console.WriteLine("Formato de fecha no válido. Intente nuevamente.");
            }

        }

        public void escribirConsultasTrauma()
        {

            FicheroInterfaz fichero = new FicheroImplementacion();
            Console.WriteLine("Fecha de la cita [dd-MM-yyyy]");
            string fecha = Console.ReadLine();
            string texto = "";
            try
            {
                DateTime fechaN = DateTime.ParseExact(fecha, "dd-MM-yyyy", CultureInfo.InvariantCulture);


                bool tieneCita = false;

                foreach (citas cita in Program.citas)
                {

                    if (fechaN.Date.Equals(cita.Fecha.Date) && cita.Especialidad.Equals("Traumatología") && cita.Asistencia.Equals(true))
                    {

                        texto = string.Concat("Nombre Completo: ", cita.Nombre, " ", cita.Apellidos, ",  Hora: ", cita.Fecha.Hour, ":", cita.Fecha.Minute);
                        fichero.ficheroCitas(texto);
                        Console.WriteLine("Escrito correctamente");
                        tieneCita = true;

                    }

                }

                if (!tieneCita)
                {
                    texto = "No hay datos disponibles para la especialidad y fecha indicada.";
                    fichero.ficheroCitas(texto);
                    Console.WriteLine("No hay datos disponibles para la especialidad y fecha indicada.");

                }


            }
            catch (FormatException)
            {
                Console.WriteLine("Formato de fecha no válido. Intente nuevamente.");
            }

        }

        public void escribirConsultasFisio()
        {

            FicheroInterfaz fichero = new FicheroImplementacion();
            Console.WriteLine("Fecha de la cita [dd-MM-yyyy]");
            string fecha = Console.ReadLine();
            string texto = "";
            try
            {
                DateTime fechaN = DateTime.ParseExact(fecha, "dd-MM-yyyy", CultureInfo.InvariantCulture);


                bool tieneCita = false;

                foreach (citas cita in Program.citas)
                {

                    if (fechaN.Date.Equals(cita.Fecha.Date) && cita.Especialidad.Equals("Fisioterapia") && cita.Asistencia == true)
                    {

                        texto = string.Concat("Nombre Completo: ", cita.Nombre, " ", cita.Apellidos, ",  Hora: ", cita.Fecha.Hour, ":", cita.Fecha.Minute);
                        fichero.ficheroCitas(texto);
                        Console.WriteLine("Escrito correctamente");
                        tieneCita = true;

                    }

                }

                if (!tieneCita)
                {
                    texto = "No hay datos disponibles para la especialidad y fecha indicada.";
                    fichero.ficheroCitas(texto);
                    Console.WriteLine("No hay datos disponibles para la especialidad y fecha indicada.");
                }


            }
            catch (FormatException)
            {
                Console.WriteLine("Formato de fecha no válido. Intente nuevamente.");
            }

        }

        private bool dniValido(string dni)
        {
            
            if(dni.Length != 9)
            {
                return false;
            }

            string numeroDni = dni.Substring(0, 8);
            char letra = char.ToUpper(dni[8]);
            string letrasValidas = "TRWAGMYFPDXBNJZSQVHLCKE";
            int resto;

            if(!int.TryParse(numeroDni, out resto))
            {
                return false;
            }

            resto = resto % 23;

            char letraCalculada = letrasValidas[resto];

            return letra == letraCalculada;

        }

    }
}
