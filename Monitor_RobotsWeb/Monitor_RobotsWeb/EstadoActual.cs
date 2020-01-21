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
    public partial class frmEstAct : Form
    {
        //VARIABLES
        public static string estadoRobotEnCurso = string.Empty;
        public static string nombreRobotEnCurso = string.Empty;

        string ultimaHoraGestion = string.Empty;
        string casoActual = string.Empty;

        public frmEstAct()
        {
            InitializeComponent();
        }

        private void frmEstAct_Load(object sender, EventArgs e)
        {
            //Se inicializan todos a Ok, hasta proxima actualización donde comprobará si algún robot está fallando.
            CambiarEstadoTodos("OK");
        }

        public void CambiarEstadoRobot()
        {
            switch (nombreRobotEnCurso)
            {
                case "RobotWebAllianzAP":
                    {
                        if (estadoRobotEnCurso == "En Curso")
                            btnAllianzAP.BackColor = Color.Lime;
                        else
                            btnAllianzAP.BackColor = Color.Red;
                    }
                    break;
                case "RobotWebAllianzPLAT":
                    {
                        if (estadoRobotEnCurso == "En Ejecucion")
                            btnAllianzPLAT.BackColor = Color.Lime;
                        else
                            btnAllianzPLAT.BackColor = Color.Red;
                    }
                    break;
                case "RobotWebFenixAP":
                    {
                        if (estadoRobotEnCurso == "En Ejecucion")
                            btnFenixAP.BackColor = Color.Lime;
                        else
                            btnFenixAP.BackColor = Color.Red;
                    }
                    break;
                case "RobotWebFenixPLAT":
                    {
                        if (estadoRobotEnCurso == "En Ejecucion")
                            btnFenixPLAT.BackColor = Color.Lime;
                        else
                            btnFenixPLAT.BackColor = Color.Red;
                    }
                    break;
                case "RobotWebCaser":
                    {
                        if (estadoRobotEnCurso == "En Ejecucion")
                            btnCaser.BackColor = Color.Lime;
                        else
                            btnCaser.BackColor = Color.Red;
                    }
                    break;
                case "RobotWebConsorcio":
                    {
                        if (estadoRobotEnCurso == "En Ejecucion")
                            btnConsorcio.BackColor = Color.Lime;
                        else
                            btnConsorcio.BackColor = Color.Red;
                    }
                    break;
                case "RobotWebGES":
                    {
                        if (estadoRobotEnCurso == "En Ejecucion")
                            btnGES.BackColor = Color.Lime;
                        else
                            btnGES.BackColor = Color.Red;
                    }
                    break;
                case "RobotWebHelvetiaAP":
                    {
                        if (estadoRobotEnCurso == "En Ejecucion")
                            btnHelvetiaAP.BackColor = Color.Lime;
                        else
                            btnHelvetiaAP.BackColor = Color.Red;
                    }
                    break;
                case "RobotWebHelvetiaPLAT":
                    {
                        if (estadoRobotEnCurso == "En Ejecucion")
                            btnHelvetiaPLAT.BackColor = Color.Lime;
                        else
                            btnHelvetiaPLAT.BackColor = Color.Red;
                    }
                    break;
                case "RobotWebLiberty":
                    {
                        if (estadoRobotEnCurso == "En Ejecucion")
                            btnLiberty.BackColor = Color.Lime;
                        else
                            btnLiberty.BackColor = Color.Red;
                    }
                    break;
                case "RobotWebMGS":
                    {
                        if (estadoRobotEnCurso == "En Ejecucion")
                            btnMGS.BackColor = Color.Lime;
                        else
                            btnMGS.BackColor = Color.Red;
                    }
                    break;
                case "RobotWebReale":
                    {
                        if (estadoRobotEnCurso == "En Ejecucion")
                            btnReale.BackColor = Color.Lime;
                        else
                            btnReale.BackColor = Color.Red;
                    }
                    break;
                case "RobotWebRealeED":
                    {
                        if (estadoRobotEnCurso == "En Ejecucion")
                            btnRealeED.BackColor = Color.Lime;
                        else
                            btnRealeED.BackColor = Color.Red;
                    }
                    break;
                case "RobotWebSegurcaixa":
                    {
                        if (estadoRobotEnCurso == "En Ejecucion")
                            btnSegurcaixa.BackColor = Color.Lime;
                        else
                            btnSegurcaixa.BackColor = Color.Red;
                    }
                    break;
                case "RobotWebAdmiral":
                    {
                        if (estadoRobotEnCurso == "En Ejecucion")
                            btnAdmiral.BackColor = Color.Lime;
                        else
                            btnAdmiral.BackColor = Color.Red;
                    }
                    break;
            }
        }

        public void DumpLogEstatusRobotEnCurso(StreamReader r, string fechaHoy)
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

        public void CambiarEstadoTodos(string estado)
        {
            if (estado == "OK")
            {
                btnAllianzAP.BackColor = Color.Lime;
                btnFenixAP.BackColor = Color.Lime;
                btnGES.BackColor = Color.Lime;
                btnCaser.BackColor = Color.Lime;
                btnLiberty.BackColor = Color.Lime;
                btnHelvetiaAP.BackColor = Color.Lime;
                btnMGS.BackColor = Color.Lime;
                btnReale.BackColor = Color.Lime;
                btnRealeED.BackColor = Color.Lime;
                btnSegurcaixa.BackColor = Color.Lime;
                btnAdmiral.BackColor = Color.Lime;
                btnConsorcio.BackColor = Color.Lime;
                btnAllianzPLAT.BackColor = Color.Lime;
                btnFenixPLAT.BackColor = Color.Lime;
                btnHelvetiaPLAT.BackColor = Color.Lime;
            }
            else
            {
                if (estado == "KO")
                {
                    btnAllianzAP.BackColor = Color.Red;
                    btnFenixAP.BackColor = Color.Red;
                    btnGES.BackColor = Color.Red;
                    btnCaser.BackColor = Color.Red;
                    btnLiberty.BackColor = Color.Red;
                    btnHelvetiaAP.BackColor = Color.Red;
                    btnMGS.BackColor = Color.Red;
                    btnReale.BackColor = Color.Red;
                    btnRealeED.BackColor = Color.Red;
                    btnSegurcaixa.BackColor = Color.Red;
                    btnAdmiral.BackColor = Color.Red;
                    btnConsorcio.BackColor = Color.Red;
                    btnAllianzPLAT.BackColor = Color.Red;
                    btnFenixPLAT.BackColor = Color.Red;
                    btnHelvetiaPLAT.BackColor = Color.Red;
                }
            }
        }
    }
}
