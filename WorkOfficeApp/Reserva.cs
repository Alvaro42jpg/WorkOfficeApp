using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOfficeApp
{
    class Reserva
    {
        public int Id { get; set; }
        public int IdSala { get; set; }
        public DateTime Horario { get; set; }
        public string PersonaReserva { get; set; }
        public int Menu1 { get; set; }
        public int Menu2 { get; set; }
        public int Menu3 { get; set; }
        public decimal Total { get; set; }
    }
}
