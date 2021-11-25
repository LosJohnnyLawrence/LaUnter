using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.API.Controllers
{
    public class TurnoMozo
    {
        public int Id { get; set; }
        public DayOfWeek Dia { get; set; }
        public TimeSpan Horario { get; set; }
        public Mozo Mozo { get; set; }
        public Sector Sector { get; set; }


    }
}
