using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CEDBCN_MonitorIT.Models
{
    public class ConsultaCasosRobots
    {
        private SqlConnection con;

        private void Conectar()
        {
            //string constr = ApplicationIntent.app.ConnectionStrings["administracion"].ToString();
            con = new SqlConnection("Data Source = 10.234.12.5; Initial Catalog = Robots; Persist Security Info = True; User ID = tebexcorp1; Password = Nicosia4000");
           // Data Source = 10.234.12.5; Initial Catalog = Robots; Persist Security Info = True; User ID = tebexcorp1
        }

        public List<Caso_Robot> RecuperarTodosCasos()
        {
            Conectar();
            List<Caso_Robot> casos = new List<Caso_Robot>();

            SqlCommand com = new SqlCommand("select top 10 ID_CasoRobot,EjecucionID,Siniestro,Lesionado,NomCompania,Aperturado from dbo.Caso_Robot order by ID_CasoRobot DESC", con);
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

        public List<Caso_Robot> RecuperarTodosCasosNoAperturados()
        {
            Conectar();
            List<Caso_Robot> casos = new List<Caso_Robot>();

            SqlCommand com = new SqlCommand("select ID_CasoRobot,EjecucionID,Siniestro,Lesionado,NomCompania,FinCorrecto from dbo.Caso_Robot where FinCorrecto = 'N' and PLATAFORMA IS NULL order by ID_CasoRobot DESC", con);
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
                    FinCorrecto = registros["FinCorrecto"].ToString()
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
            comando.Parameters.Add("@les", SqlDbType.NVarChar);
            comando.Parameters["@les"].Value = les;
            con.Open();
            SqlDataReader registros = comando.ExecuteReader();
            Caso_Robot caso = new Caso_Robot();
            if (registros.Read())
            {

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

        public Caso_Robot RecuperarCasoFallido(int idcaso)
        {
            Conectar();
            SqlCommand comando = new SqlCommand("select * from dbo.Caso_Robot where ID_CasoRobot=@idcaso", con);
            comando.Parameters.Add("@idcaso", SqlDbType.Int);
            comando.Parameters["@idcaso"].Value = idcaso;

            con.Open();
            SqlDataReader registros = comando.ExecuteReader();
            Caso_Robot caso = new Caso_Robot();
            if (registros.Read())
            {

                caso.ID_CasoRobot = int.Parse(registros["ID_CasoRobot"].ToString());
                caso.EjecucionID = int.Parse(registros["EjecucionID"].ToString());
                caso.CiaID = int.Parse(registros["EjecucionID"].ToString());
                caso.NomCompania = registros["NomCompania"].ToString();
                if (registros["SucursalID"].ToString() != "" && registros["SucursalID"].ToString() != null)
                    caso.SucursalID = int.Parse(registros["SucursalID"].ToString());
                if (registros["FechaWeb"].ToString() != "" && registros["FechaWeb"].ToString() != null)
                    caso.FechaWeb = DateTime.Parse(registros["FechaWeb"].ToString());
                if (registros["FechaEntrada"].ToString() != "" && registros["FechaEntrada"].ToString() != null)
                    caso.FechaEntrada = DateTime.Parse(registros["FechaEntrada"].ToString());
                caso.Siniestro = registros["Siniestro"].ToString();
                caso.Lesionado = registros["Lesionado"].ToString();
                caso.CasoID = int.Parse(registros["CasoID"].ToString());
                caso.TipoCaso = registros["TipoCaso"].ToString();
                caso.TipoEncargo = registros["TipoEncargo"].ToString();
                caso.Aperturado = registros["Aperturado"].ToString();
                caso.GetDatos = registros["GetDatos"].ToString();
                caso.SetDatos = registros["SetDatos"].ToString();
                caso.UpObservacionesApertura = registros["UpObservacionesApertura"].ToString();
                caso.Documentos = registros["Documentos"].ToString();
                caso.UpDocumentos = registros["UpDocumentos"].ToString();
                caso.Comunicaciones = registros["Comunicaciones"].ToString();
                caso.UpComunicaciones = registros["UpComunicaciones"].ToString();
                caso.Plataforma = registros["Plataforma"].ToString();
                caso.FinCorrecto = registros["FinCorrecto"].ToString();
                caso.Observaciones = registros["Observaciones"].ToString();
            }
            con.Close();
            return caso;
        }
    }
}
