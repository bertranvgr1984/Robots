using IU_ModernosAndTemasMultColor;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Monitor_RobotsWeb
{
    public partial class frmMonitorRobots : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public frmMonitorRobots()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitulo.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCerrarFormHijo.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContenido.Controls.Add(childForm);
            this.panelContenido.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTituloPrincipal.Text = childForm.Text;
        }
        private void btnEstad_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmEstAct(), sender);
        }
        private void btnRobotEjec_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRobEjec(), sender);
        }
        private void btnDetail_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDetail(), sender);
        }
        //private void btneport_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new Forms.FormReporting(), sender);
        //}
        private void btnNotificationes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNotif(), sender);
        }
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmConfig(), sender);
        }
        private void btnCerrarFormHijo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblTituloPrincipal.Text = "MENU PRINCIPAL";
            panelTitulo.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCerrarFormHijo.Visible = false;
        }
        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void Form1_Load(object sender, EventArgs e)
        {         
            

            //ComprobarEstadoRobots();

            
        }      

        

        private void btnVerAllianzAP_Click(object sender, EventArgs e)
        {
            VerDetalleRobot("AllianzAP");
        }

        private void VerDetalleRobot(string nombreRobot)
        {
            ExtraerDetalleLog(nombreRobot);

            //switch (nombreRobot)
            //{
            //    case "AllianzAP": 
            //        break;
            //    case "AllianzPLAT":
            //        break;
            //    case "FenixAP":
            //        break;
            //    case "FenixPLAT":
            //        break;
            //    case "Caser":
            //        break;
            //    case "Consorcio":
            //        break;
            //    case "GES":
            //        break;
            //    case "HelvetiaAP":
            //        break;
            //    case "HelvetiaPLAT":
            //        break;
            //    case "Liberty":
            //        break;
            //    case "MGS":
            //        break;
            //    case "Reale":
            //        break;
            //    case "RealeED":
            //        break;
            //    case "Segurcaixa":
            //        break;
            //    case "Admiral":
            //        break;
            //}
        }

        private void ExtraerDetalleLog(string nombreRobot)
        {
            throw new NotImplementedException();
        }

        private void btnVerFenixAP_Click(object sender, EventArgs e)
        {
            VerDetalleRobot("FenixAP");
        }

        private void btnVerGES_Click(object sender, EventArgs e)
        {
            VerDetalleRobot("GES");
        }

        private void btnVerCaser_Click(object sender, EventArgs e)
        {
            VerDetalleRobot("Caser");
        }

        private void btnVerLiberty_Click(object sender, EventArgs e)
        {
            VerDetalleRobot("Liberty");
        }

        private void btnVerHelvetia_Click(object sender, EventArgs e)
        {
            VerDetalleRobot("Helvetia");
        }

        private void btnVerMGS_Click(object sender, EventArgs e)
        {
            VerDetalleRobot("MGS");
        }

        private void btnVerReale_Click(object sender, EventArgs e)
        {
            VerDetalleRobot("Reale");
        }

        private void btnVerRealeED_Click(object sender, EventArgs e)
        {
            VerDetalleRobot("RealeED");
        }

        private void brnVerSegurcaixa_Click(object sender, EventArgs e)
        {
            VerDetalleRobot("Segurcaixa");
        }

        private void btnVerAdmiral_Click(object sender, EventArgs e)
        {
            VerDetalleRobot("Admiral");
        }

        private void btnVerConsorcio_Click(object sender, EventArgs e)
        {
            VerDetalleRobot("Consorcio");
        }

        private void btnVerAllianzPLAT_Click(object sender, EventArgs e)
        {
            VerDetalleRobot("AllianzPLAT");
        }

        private void btnVerFenixPLAT_Click(object sender, EventArgs e)
        {
            VerDetalleRobot("FenixPLAT");
        }

        private void btnVerHelvetiaPLAT_Click(object sender, EventArgs e)
        {
            VerDetalleRobot("HelvetiaPLAT");
        }
    }
}
