using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEDBCN_MonitorIT.Models
{
    public class Estado_Robot
    {
        [Key]
        public int IDRobot { get; set; }

        public string Nombre { get; set; }

        public string Estado { get; set; }

        [DataType(DataType.Date)]
        public DateTime F_UltimaActualizacion { get; set; }

        public string TipoRobot { get; set; }

        public string RobotPadre { get; set; }

        public int Posicion { get; set; }

        public int ErroresDia { get; set; }

        public int ErroresCorregidos { get; set; }

        public int TotalAP_PLAT { get; set; }

        public int TotalEjecuciones { get; set; }

        public string Observaciones { get; set; }
    }
}
