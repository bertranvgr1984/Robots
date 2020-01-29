using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEDBCN_MonitorIT.Models
{
    public class MonitorServers
    {
        public int MonitorServersID { get; set; }

        public int UsuarioID { get; set; }

        public string Usuario { get; set; }

        public string Servidor { get; set; }

        public string TipoServidor { get; set; }

        [DataType(DataType.Date)]
        public DateTime fecha { get; set; }

        public int cpu { get; set; }

        public int memoria { get; set; }

        public string usuarios { get; set; }

        public int red { get; set; }
    }
}
