using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CEDBCN_MonitorIT.Models
{
    public class MonitorRobotsDbContext : DbContext
    {
        public MonitorRobotsDbContext(DbContextOptions<MonitorRobotsDbContext> data)
        : base(data) { }


        public DbSet<Caso_Robot> CasoRobot { get; set; }
        public DbSet<Ejecucion_Robot> EjecucionRobot { get; set; }
        public DbSet<Robot> Robot { get; set; }

        public DbSet<MonitorServers> MonitorServers { get; set; }
    }
}
