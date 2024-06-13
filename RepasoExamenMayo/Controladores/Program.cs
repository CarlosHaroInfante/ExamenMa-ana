using RepasoExamenMayo.Dtos;
using RepasoExamenMayo.Servicios;

namespace RepasoExamenMayo.Controladores
{

    class Program
    {

        public static List<citas> citas = new List<citas>();
        static void Main(string[] args)
        {
            FicheroInterfaz fichero = new FicheroImplementacion();
            MenuInterfaz menu = new MenuImplementacion();
            OperativaInterfaz operativa = new OperativaImplementacion();
            string mensaje;
            fichero.cargaInicial();

            foreach(citas cita in Program.citas) { 
                
                Console.WriteLine(cita.ToString());
            
            }

            try { 
            bool cerrarMenu = false;

            while(!cerrarMenu)
            {
               
                int opcion = menu.menuInicial();
                mensaje = "Menú Inicial";
                fichero.ficheroLog(mensaje);

                switch(opcion)
                {

                    case 0:
                        cerrarMenu = true;
                        mensaje = "Se cierra el menú";
                        fichero.ficheroLog(mensaje);
                        break;

                    case 1:
                        mensaje = "Registro de llegada";
                        operativa.registroLlegada();
                        fichero.ficheroLog(mensaje);
                        break;

                    case 2:
                        int consultas = menu.menuConsultas();
                        mensaje = "Listado de Consultas";
                        fichero.ficheroLog(mensaje);
                        switch (consultas)
                        {
                            case 0:
                                mensaje = "Volver a menú principal";
                                fichero.ficheroLog(mensaje);
                                break;
                            case 1:
                                int especialidad = menu.menuEspecialidad();
                                mensaje = "Opción de Mostrar Consultas";
                                fichero.ficheroLog(mensaje);
                                switch (especialidad)
                                {
                                    case 0:

                                        mensaje = "Volver a menú principal";
                                        fichero.ficheroLog(mensaje);
                                        break;
                                    case 1:
                                        operativa.mostrarConsutasPsico();
                                        mensaje = "Opción Psicología";
                                        fichero.ficheroLog(mensaje);
                                        break;
                                    case 2:
                                        operativa.mostrarConsutasTrauma();
                                        mensaje = "Opción Traumatología";
                                        fichero.ficheroLog(mensaje);
                                        break;
                                    case 3:
                                        operativa.mostrarConsultasFisio();
                                        mensaje = "Opción Fisioterapia";
                                        fichero.ficheroLog(mensaje);
                                        break;
                                    default:
                                        Console.WriteLine("Opción no válida");
                                        mensaje = "Opción no válida";
                                        fichero.ficheroLog(mensaje);
                                        break;
                                }
                                break;
                            case 2:

                                int especialidad2 = menu.menuEspecialidad();
                                mensaje = "Opción de Imprimir Consultas";
                                fichero.ficheroLog(mensaje);
                                switch (especialidad2)
                                {
                                    case 0:

                                        mensaje = "Volver a menú principal";
                                        fichero.ficheroLog(mensaje);
                                        break;
                                    case 1:
                                        operativa.escribirConsultasPsico();
                                        mensaje = "Opción Psicología";
                                        fichero.ficheroLog(mensaje);
                                        break;
                                    case 2:
                                        operativa.escribirConsultasTrauma();
                                        mensaje = "Opción Traumatología";
                                        fichero.ficheroLog(mensaje);
                                        break;
                                    case 3:
                                        operativa.escribirConsultasFisio();
                                        mensaje = "Opción Fisioterapia";
                                        fichero.ficheroLog(mensaje);
                                        break;
                                    default:
                                        Console.WriteLine("Opción no válida");
                                        mensaje = "Opción no válida";
                                        fichero.ficheroLog(mensaje);
                                        break;

                                }
                                break;
                                
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        mensaje = "Opción no válida";
                        fichero.ficheroLog(mensaje);
                        break;
                }
                

            }

            }catch(Exception ex)
            {
                Console.WriteLine("Error tipo I/O exception " + ex.ToString());
                mensaje = "Error tipo I/O exception";
                fichero.ficheroLog(mensaje);
            }

        }
    }


}
