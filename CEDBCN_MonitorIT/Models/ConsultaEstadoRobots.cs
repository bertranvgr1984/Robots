using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CEDBCN_MonitorIT.Models
{
    public class ConsultaEstadoRobots
    {
        private SqlConnection con;

        private void Conectar()
        {
            //string constr = ApplicationIntent.app.ConnectionStrings["administracion"].ToString();
            con = new SqlConnection("Data Source = 10.234.12.5; Initial Catalog = Robots; Persist Security Info = True; User ID = tebexcorp1; Password = Nicosia4000");
           // Data Source = 10.234.12.5; Initial Catalog = Robots; Persist Security Info = True; User ID = tebexcorp1
        }

        public List<Robot> RecuperarTodos()
        {
            Conectar();
            List<Robot> robots = new List<Robot>();

            SqlCommand com = new SqlCommand("SELECT IDRobot,Nombre,Estado,F_UltimaActualizacion,EnFuncionamiento,RobotPadre,Posicion,ErroresDia,ErroresCorregidos,TotalAP_PLAT,TotalEjecuciones,Observaciones from dbo.Robot order by IDRobot ASC", con);
            con.Open();
            SqlDataReader registros = com.ExecuteReader();
            while (registros.Read())
            {
                Robot robot = new Robot
                {                  
                    IDRobot = int.Parse(registros["IDRobot"].ToString()),
                    Nombre = registros["Nombre"].ToString(),
                    Estado = registros["Estado"].ToString(),
                    F_UltimaActualizacion = DateTime.Parse(registros["F_UltimaActualizacion"].ToString()),
                    EnFuncionamiento = bool.Parse(registros["EnFuncionamiento"].ToString()),
                    RobotPadre = registros["RobotPadre"].ToString(),
                    Posicion = int.Parse(registros["Posicion"].ToString()),
                    ErroresDia = int.Parse(registros["ErroresDia"].ToString()),
                    ErroresCorregidos = int.Parse(registros["ErroresCorregidos"].ToString()),
                    TotalAP_PLAT = int.Parse(registros["TotalAP_PLAT"].ToString()),
                    TotalEjecuciones = int.Parse(registros["TotalEjecuciones"].ToString()),
                    Observaciones = registros["Observaciones"].ToString()
                };
                robots.Add(robot);
            }
            con.Close();
            return robots;
        }

        public List<Caso_Robot> RecuperarTodosCasosNoAperturados()
        {
            Conectar();
            List<Caso_Robot> casos = new List<Caso_Robot>();

            SqlCommand com = new SqlCommand("select top 10 ID_CasoRobot,EjecucionID,Siniestro,Lesionado,NomCompania,Aperturado from dbo.Caso_Robot where Aperturado = 'N' order by ID_CasoRobot DESC", con);
            con.Open();
            SqlDataReader registros = com.ExecuteReader();
            while (registros.Read())
            {
                Caso_Robot caso = new Caso_Robot
                {
                    ID_CasoRobot = int.Parse(registros["ID_CasoRobot"].ToString()),
                    EjecucionID = int.Parse(registros["EjecucionID"].ToString()),
                    Siniestro = registros["Siniestro"].ToString(),
                    Lesionado = registros["Lesionado"].ToString(),
                    NomCompania = registros["NomCompania"].ToString(),
                    Aperturado = registros["Aperturado"].ToString()
                    //Precio = float.Parse(registros["precio"].ToString())
                };
                casos.Add(caso);
            }
            con.Close();
            return casos;
        }

        public Caso_Robot RecuperarCasoPorSiniestroLesionado(string sin, string les)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("select ID_CasoRobot,EjecucionID,Siniestro,Lesionado,NomCompania,Aperturado from dbo.Caso_Robot where siniestro=@sin and lesionado=@les", con);
            comando.Parameters.Add("@sin", SqlDbType.NVarChar);
            comando.Parameters["@sin"].Value = sin;
            con.Open();
            SqlDataReader registros = comando.ExecuteReader();
            Caso_Robot caso = new Caso_Robot();
            if (registros.Read())
            {
                //ID_CasoRobot = int.Parse(registros["ID_CasoRobot"].ToString()),
                //EjecucionID = int.Parse(registros["EjecucionID"].ToString()),
                //Siniestro = registros["Siniestro"].ToString(),
                //Lesionado = registros["Lesionado"].ToString(),
                //NomCompania = registros["NomCompania"].ToString(),
                //Aperturado = registros["Aperturado"].ToString()

                caso.ID_CasoRobot = int.Parse(registros["ID_CasoRobot"].ToString());
                caso.EjecucionID = int.Parse(registros["EjecucionID"].ToString());
                caso.Siniestro = registros["Siniestro"].ToString();
                caso.Lesionado = registros["Lesionado"].ToString();
                caso.NomCompania = registros["NomCompania"].ToString();
                caso.Aperturado = registros["Aperturado"].ToString();
                //caso.Precio = float.Parse(registros["precio"].ToString());
            }
            con.Close();
            return caso;
        }

        //public Caso_Robot 
    }
}
