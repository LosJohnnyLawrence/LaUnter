using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos
{
    public class TurnoMozo
    {
        [Key]
        public int Id { get; set; }
        public DayOfWeek Dia { get; set; }
        public TimeSpan InicioTurno { get; set; }
        public TimeSpan FinTurno { get; set; }

        public Mozo Mozo { get; set; }
        public Sector Sector { get; set; }


    }
}
