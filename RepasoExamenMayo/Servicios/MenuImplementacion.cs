using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamenMayo.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int menuInicial()
        {

            Console.WriteLine("Menú inicial");
            Console.WriteLine("------------");
            Console.WriteLine("[0] - Cerrar menú");
            Console.WriteLine("[1] - Registro de llegada");
            Console.WriteLine("[2] - Listado de consultas");
            Console.WriteLine("------------");
            int op = Convert.ToInt32(Console.ReadLine());

            return op;

        }

        public int menuConsultas()
        {
            Console.WriteLine("Listado de consulta");
            Console.WriteLine("------------");
            Console.WriteLine("[0] - Volver");
            Console.WriteLine("[1] - Mostrar consultas");
            Console.WriteLine("[2] - Imprimir consultas");
            Console.WriteLine("------------");
            int op = Convert.ToInt32(Console.ReadLine());

            return op;
        }
        public int menuEspecialidad()
        {
            Console.WriteLine("Especialidad");
            Console.WriteLine("------------");
            Console.WriteLine("[0] - Volver");
            Console.WriteLine("[1] - Psicología");
            Console.WriteLine("[2] - Traumatología");
            Console.WriteLine("[3] - Fisioterapia");
            Console.WriteLine("------------");
            int op = Convert.ToInt32(Console.ReadLine());

            return op;
        }



    }
}
