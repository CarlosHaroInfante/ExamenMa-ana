using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamenMayo.Dtos
{
    internal class citas
    {
        long id;

        string dni = "aaaaa";

        string nombre = "aaaaa";

        string apellidos = "aaaaa";

        string especialidad = "aaaaa";

        DateTime fecha = new DateTime(9999, 12, 31);

        bool asistencia = false;

        /*public citas(long id, string dni, string nombre, string apellidos, string especialidad, DateTime fecha, bool asistencia)
        {
            this.id = id;
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.especialidad = especialidad;
            this.fecha = fecha;
            this.asistencia = asistencia;
        }*/

        public long Id { get => id; set => id = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public bool Asistencia { get => asistencia; set => asistencia = value; }


        public override string ToString()
        {
            string mensaje = String.Concat(this.dni, ";", this.nombre, ";", this.apellidos,
                                   ";", this.especialidad, ";", this.fecha, ";", this.asistencia);

            return mensaje;
        }
    }

   
}
