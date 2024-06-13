using PuertoRepaso.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuertoRepaso.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void recogidaInformancion(List<vehiculosDto> listaVehiculos)
        {
            string mensaje = "";
            FicheroInterfaz fichero = new FicheroImplementacion();
            string control = "";
            try
            {
            do { 
            vehiculosDto vehiculoN = new vehiculosDto();
            mensaje = "Se piden los datos de un nuevo vehiculo";
            fichero.ficheroLog(mensaje);
            Console.WriteLine("Puerta Sur");
            Console.WriteLine("----------");
            Console.WriteLine("Matrícula");
            vehiculoN.Matricula = Console.ReadLine();

            Console.WriteLine("Tipo de vehículo [P (particulares), F (camiones frigorificos), A (camiones articulados)]");
            vehiculoN.Tipo = Console.ReadLine();

            if (vehiculoN.Tipo.Equals("P"))
            {
                vehiculoN.ZonaDestino = "Puerta Oeste";
                vehiculoN.FechaDePaso = DateTime.Now;
                vehiculoN.Revision = "No necesaria";
            }
                    if (!vehiculoN.Tipo.Equals("P"))
                    {

                        Console.WriteLine("Tiene mercancia [S] o [N]");
                        string mercancia = Console.ReadLine();

                        if (mercancia.Equals("S"))
                        {
                            vehiculoN.Mercancia = true;
                        }
                        else
                        {
                            vehiculoN.Mercancia = false;
                        }
                    }

                 if(vehiculoN.Tipo.Equals("F") && vehiculoN.Mercancia == false)
                 {
                    vehiculoN.ZonaDestino = "Puerta Norte";
                    vehiculoN.FechaDePaso = DateTime.Now;
                 }

                if (vehiculoN.Tipo.Equals("F") && vehiculoN.Mercancia == true)
                {
                    vehiculoN.ZonaDestino = "Puerta Este";
                    vehiculoN.FechaDePaso = DateTime.Now;
                }

                if (vehiculoN.Tipo.Equals("A") && vehiculoN.Mercancia == false)
                {
                    vehiculoN.ZonaDestino = "Puerta Norte";
                    vehiculoN.FechaDePaso = DateTime.Now;
                }

                if (vehiculoN.Tipo.Equals("A") && vehiculoN.Mercancia == true)
                {
                    vehiculoN.ZonaDestino = "Puerta Este";
                    vehiculoN.FechaDePaso = DateTime.Now;
                }
                

                listaVehiculos.Add(vehiculoN);
                mensaje = "Nuevo vehiculo registrado";
                fichero.ficheroLog(mensaje);
                Console.WriteLine("¿Registrar nuevo vehiculo? [SI o NO]");
                control = Console.ReadLine();
            }while (control.Equals("SI"));
            
            
            }catch(Exception ex)
            {
                mensaje = "Error al registrar un nuevo vehiculo";
                fichero.ficheroLog(mensaje);
            } 

        }
        public void pif(List<vehiculosDto> listaVehiculos)
        {
            string mensaje = "";
            FicheroInterfaz fichero = new FicheroImplementacion();
            bool coche = false;
            foreach(vehiculosDto vehiculos in listaVehiculos)
            {
                mensaje = "Entrando en pif";
                fichero.ficheroLog(mensaje);

                if(vehiculos.ZonaDestino.Equals("Puerta Este") && vehiculos.Mercancia == true)
                {

                    vehiculos.ZonaDestino = "Puerta Noreste";
                    vehiculos.FechaDePaso = DateTime.Now;
                    vehiculos.Revision = "Apto";
                    mensaje = "El coche es apto";
                    fichero.ficheroLog(mensaje);

                }
                if(vehiculos.ZonaDestino.Equals("Puerta Este") && vehiculos.Mercancia == false)
                {
                    vehiculos.ZonaDestino = "Puerta Sur";
                    vehiculos.FechaDePaso = DateTime.Now;
                    vehiculos.Revision = "No Apto";
                    mensaje = "El coche no es apto";
                    fichero.ficheroLog(mensaje);
                }

            }


        }


    }

}