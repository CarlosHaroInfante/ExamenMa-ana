using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuertoRepaso.Dtos
{
    internal class vehiculosDto
    {
        long id;

        string matricula = "aaaaa";

        string tipo = "aaaaa";

        string zonaDestino = "aaaaa";

        bool mercancia = false;

        DateTime fechaDePaso = DateTime.Now;

        string revision = "aaaaa";

        public long Id { get => id; set => id = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string ZonaDestino { get => zonaDestino; set => zonaDestino = value; }
        public bool Mercancia { get => mercancia; set => mercancia = value; }
        public DateTime FechaDePaso { get => fechaDePaso; set => fechaDePaso = value; }
        public string Revision { get => revision; set => revision = value; }
    }
}
