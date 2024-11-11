using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOfficeApp
{
    class Sala
    {
        public int Id { get; set; }
        public bool Disponibilidad { get; set; }
        public int Capacidad { get; set; }
        public string Ubicacion { get; set; }
        public string Distribucion { get; set; }
        public bool Proyector { get; set; }
        public bool Oasis { get; set; }
        public bool Cafetera { get; set; }
    }
}
