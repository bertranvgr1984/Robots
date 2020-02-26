using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEDBCN_MonitorIT.Models
{
    public class Ejecucion_Robot
    {
        [Key]
        public int ID_Ejecucion { get; set; }

        public string Nombre_Robot_Base { get; set; }

        public string Modulo_Actual { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaInicio_Ejecucion { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaActual_Ejecucion { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaFin_Ejecucion { get; set; }

        public string EjecucionActiva { get; set; }

        public string Observaciones { get; set; }
    }
}
