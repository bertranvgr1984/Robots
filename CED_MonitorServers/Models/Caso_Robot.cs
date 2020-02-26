using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEDBCN_MonitorIT.Models
{
    public class Caso_Robot
    {
		[Key]
		public int ID_CasoRobot { get; set; }
		public int EjecucionID { get; set; }

        public int CiaID { get; set; }
		public string NomCompania { get; set; }

        public int SucursalID { get; set; }

		[DataType(DataType.Date)]
		public DateTime FechaWeb { get; set; }

		[DataType(DataType.Date)]
		public DateTime FechaEntrada { get; set; }

		public string Siniestro { get; set; }

		public string Lesionado { get; set; }

		public int CasoID { get; set; }

		public string TipoCaso { get; set; }

		public string TipoEncargo { get; set; }

		public string Aperturado { get; set; }

		public string GetDatos { get; set; }

		public string SetDatos { get; set; }

		public string UpObservacionesApertura { get; set; }

		public string Documentos { get; set; }

		public string UpDocumentos { get; set; }

		public string Comunicaciones { get; set; }

		public string UpComunicaciones { get; set; }

		public string Plataforma { get; set; }

		public string FinCorrecto { get; set; }

		public string Observaciones { get; set; }
    }
}
