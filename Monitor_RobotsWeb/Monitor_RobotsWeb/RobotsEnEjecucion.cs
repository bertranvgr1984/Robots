using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Monitor_RobotsWeb
{
    public partial class frmRobEjec : Form
    {
        //VARIABLES
        string estadoRobotEnCurso = string.Empty;
        public string nombreRobotEnCurso = string.Empty;
        string ultimaHoraGestion = string.Empty;
        string casoActual = string.Empty;


        public frmRobEjec()
        {
            InitializeComponent();
        }

        private void frmRobEjec_Load(object sender, EventArgs e)
        {
            ComprobarEstatusRobotEnCurso();
        }

        private void ComprobarEstatusRobotEnCurso()
        {
            string fechaHoy = DateTime.Now.ToString("dd/MM/yyyy").ToString();
            //fechaHoy = "06/07/2018";

            try
            {
                using (StreamReader r = File.OpenText("Z:\\Proyectos\\LogsRobots\\" + "EstatusRobot.txt"))
                {
                    DumpLogEstatusRobotEnCurso(r, fechaHoy);
                }
            }
            catch (Exception ex)
            { }

            if (nombreRobotEnCurso != null && nombreRobotEnCurso != "")
            {
                txtRobotEjecucion.Text = nombreRobotEnCurso;
                txtHoraUltmGestion.Text = ultimaHoraGestion;
                txtCasoActual.Text = casoActual;
                txtEstadoRobot.Text = estadoRobotEnCurso;
                if (estadoRobotEnCurso == "En Curso")
                    txtEstadoRobot.ForeColor = Color.Green;
                else
                    txtEstadoRobot.ForeColor = Color.Red;

                frmEstAct.CambiarEstadoRobot();
            }
        }

        private void DumpLogEstatusRobotEnCurso(StreamReader r, string fechaHoy)
        {
            string line = string.Empty;
            string diaHoy = string.Empty;
            string horaActual = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            string[] desgloseLinea = null;
            string[] desgloseNombreRobot = null;

            while ((line = r.ReadLine()) != null)
            {
                try
                {
                    if (line == "" || line.Trim(' ') == "")
                        continue;
                    if (line != "" || line.Trim(' ') != "")
                    {
                        if (desgloseLinea == null)
                            desgloseLinea = line.Split('|');

                        if (desgloseLinea != null)
                        {
                            //Extraer Nombre Robot
                            if (desgloseLinea[0].Contains("("))
                            {
                                desgloseNombreRobot = desgloseLinea[0].Split('(');
                                if (desgloseNombreRobot[1].Contains("Aperturas"))
                                {
                                    if (desgloseNombreRobot[0].Contains("Allianz") || desgloseNombreRobot[0].Contains("Fenix") || desgloseNombreRobot[0].Contains("Helvetia"))
                                        nombreRobotEnCurso = desgloseNombreRobot[0] + "AP";
                                    else
                                        nombreRobotEnCurso = desgloseNombreRobot[0];
                                }
                                else
                                {
                                    if (desgloseNombreRobot[0] == "Allianz" || desgloseNombreRobot[0] == "Fenix" || desgloseNombreRobot[0] == "Helvetia")
                                        nombreRobotEnCurso = desgloseNombreRobot[0] + "PLAT";
                                    else
                                        nombreRobotEnCurso = desgloseNombreRobot[0];
                                }
                            }
                            else
                                nombreRobotEnCurso = desgloseNombreRobot[0];

                            //Extraer Caso Actual
                            casoActual = desgloseLinea[1] + " - " + desgloseLinea[2];


                            //Extraer Hora Ultima Gestion Robot
                            //for (int i = 0; i < desgloseLinea.Length; i++)
                            //{
                            //    desgloseLinea[i] = ((desgloseLinea[i].Replace('|', ' ')).TrimStart(' ')).TrimEnd(' ');
                            //    desgloseLinea[i] = desgloseLinea[i].Trim(' ');
                            //}
                            ultimaHoraGestion = desgloseLinea[desgloseLinea.Length - 1].Trim(' ');

                            //Extraer Estado
                            string[] desgloseHoraRobot = ultimaHoraGestion.Split(':');
                            string[] desgloseHoraActual = horaActual.Split(':');

                            int diferenciaMinutos = int.Parse(desgloseHoraActual[1]) - int.Parse(desgloseHoraRobot[1]);
                            int diferenciaHora = int.Parse(desgloseHoraActual[0]) - int.Parse(desgloseHoraRobot[0]);
                            if (diferenciaHora > 0)
                                diferenciaMinutos = diferenciaMinutos + (diferenciaHora * 60);

                            if (diferenciaMinutos > 30)
                                estadoRobotEnCurso = "Bloqueado";
                            else
                                estadoRobotEnCurso = "En Curso";

                            break;
                        }
                    }
                }
                catch (Exception ex)
                { }
            }
            r.Close();
        }
    }
}
