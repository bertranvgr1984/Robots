using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CEDBCN_MonitorIT.Models
{
    public class ConsultaServers
    {
        private SqlConnection con;

        private void Conectar()
        {
            //string constr = ApplicationIntent.app.ConnectionStrings["administracion"].ToString();
            con = new SqlConnection("Data Source = 10.234.12.5; Initial Catalog = Robots; Persist Security Info = True; User ID = tebexcorp1; Password = Nicosia4000");
           // Data Source = 10.234.12.5; Initial Catalog = Robots; Persist Security Info = True; User ID = tebexcorp1
        }

        public List<MonitorServers> RecuperarTodos()
        {
            Conectar();
            List<MonitorServers> monitores = new List<MonitorServers>();

            SqlCommand com = new SqlCommand("select MonitorServersID,UsuarioID,Usuario,Servidor,TipoServidor,fecha,cpu,memoria,usuarios,red from dbo.MonitorServers order by MonitorServersID DESC", con);
            con.Open();
            SqlDataReader registros = com.ExecuteReader();

            bool res = false;
            while (registros.Read())
            {
                try
                {
                    MonitorServers moServ = new MonitorServers
                    {                        
                        MonitorServersID = int.Parse(registros["MonitorServersID"].ToString()),
                        UsuarioID = extraerDatoInteger(registros["UsuarioID"].ToString()),                    
                        Usuario = registros["Usuario"].ToString(),
                        Servidor = registros["Servidor"].ToString(),
                        TipoServidor = registros["TipoServidor"].ToString(),
                        fecha = DateTime.Parse(registros["fecha"].ToString()),
                        cpu = int.Parse(registros["cpu"].ToString()),
                        memoria = int.Parse(registros["memoria"].ToString()),
                        usuarios = registros["usuarios"].ToString(),
                        red = extraerDatoInteger(registros["red"].ToString())                        
                    };

                    //Comprobamos que sino es del mismo día, no lo mostramos
                    string diaHoy = DateTime.Now.ToShortDateString();
                    string horaHoy = DateTime.Now.ToShortTimeString();
                    string horaFechaBD = DateTime.Now.ToShortTimeString();
                    string[] desgloseHoraHoy = horaFechaBD.Split(':');
                    string[] desgloseHoraFechaBD = horaFechaBD.Split(':');
                    int difMinutos = int.Parse(desgloseHoraHoy[1]) - int.Parse(desgloseHoraFechaBD[1]);

                    if (moServ.fecha.ToShortDateString() != diaHoy || ((difMinutos > 10) && (desgloseHoraHoy[0] == desgloseHoraFechaBD[0])))
                        continue;

                    monitores.Add(moServ);
                }
                catch (Exception ex)
                {}
                
            }

            con.Close();
            return monitores;
        }

        private bool IsHoraHoyCercana (string dato)
        {
            string[] desgloseFechaBD = dato.Split(' ');
            string[] desgloseHoraBD = desgloseFechaBD[1].Split(':');
            string fechaHoy = DateTime.Now.ToString();
            string[] desgloseFechaHoy = dato.Split('/');
            string[] desgloseHoraHoy = desgloseFechaHoy[1].Split(':');
            int difMinutos = int.Parse(desgloseHoraBD[2]) - int.Parse(desgloseHoraHoy[2]);
            if (difMinutos <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
        

        private static int extraerDatoInteger(string dato)
        {
            if (dato == null || dato == "")
                return 0;
            else
            {
                return int.Parse(dato);
            }
        }

        public List<MonitorServers> ContadorUsersPorServer()
        {
            Conectar();
            List<MonitorServers> monitores = new List<MonitorServers>();

            SqlCommand com = new SqlCommand("SELECT Servidor, count(Usuario) AS N_USERS FROM DBO.MonitorServers group by Servidor", con);
            con.Open();
            SqlDataReader registros = com.ExecuteReader();
            while (registros.Read())
            {
                MonitorServers moServ = new MonitorServers
                {
                    Servidor = registros["Servidor"].ToString(),
                    //Usuario = int.Parse(registros.FieldCount["Usuario"].ToString()),
                };
                monitores.Add(moServ);
            }
            con.Close();
            return monitores;
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
