namespace Monitor_RobotsWeb
{
    partial class frmMonitorRobots
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.robotEnCurso = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnCerrarPrincipal = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrarFormHijo = new System.Windows.Forms.Button();
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnNotificaciones = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnRobotEjec = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnEstAct = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // robotEnCurso
            // 
            this.robotEnCurso.AutoSize = true;
            this.robotEnCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robotEnCurso.Location = new System.Drawing.Point(16, 50);
            this.robotEnCurso.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.robotEnCurso.Name = "robotEnCurso";
            this.robotEnCurso.Size = new System.Drawing.Size(128, 16);
            this.robotEnCurso.TabIndex = 49;
            this.robotEnCurso.Text = "Robot en Ejecución:";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.btnNotificaciones);
            this.panelMenu.Controls.Add(this.btnConfiguracion);
            this.panelMenu.Controls.Add(this.btnRobotEjec);
            this.panelMenu.Controls.Add(this.btnDetail);
            this.panelMenu.Controls.Add(this.btnEstAct);
            this.panelMenu.Location = new System.Drawing.Point(0, 113);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(177, 531);
            this.panelMenu.TabIndex = 80;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.YellowGreen;
            this.panelTitulo.Controls.Add(this.btnCerrarPrincipal);
            this.panelTitulo.Controls.Add(this.btnMaximizar);
            this.panelTitulo.Controls.Add(this.btnMinimizar);
            this.panelTitulo.Controls.Add(this.btnCerrarFormHijo);
            this.panelTitulo.Controls.Add(this.lblTituloPrincipal);
            this.panelTitulo.Location = new System.Drawing.Point(177, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1049, 114);
            this.panelTitulo.TabIndex = 81;
            // 
            // btnCerrarPrincipal
            // 
            this.btnCerrarPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPrincipal.ForeColor = System.Drawing.Color.Red;
            this.btnCerrarPrincipal.Location = new System.Drawing.Point(1016, 12);
            this.btnCerrarPrincipal.Name = "btnCerrarPrincipal";
            this.btnCerrarPrincipal.Size = new System.Drawing.Size(21, 21);
            this.btnCerrarPrincipal.TabIndex = 4;
            this.btnCerrarPrincipal.Text = "X";
            this.btnCerrarPrincipal.UseVisualStyleBackColor = true;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.Location = new System.Drawing.Point(962, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 21);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.Text = "_";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // btnCerrarFormHijo
            // 
            this.btnCerrarFormHijo.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarFormHijo.Location = new System.Drawing.Point(21, 35);
            this.btnCerrarFormHijo.Name = "btnCerrarFormHijo";
            this.btnCerrarFormHijo.Size = new System.Drawing.Size(30, 30);
            this.btnCerrarFormHijo.TabIndex = 1;
            this.btnCerrarFormHijo.Text = "X";
            this.btnCerrarFormHijo.UseVisualStyleBackColor = true;
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Roboto Cn", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrincipal.ForeColor = System.Drawing.Color.Black;
            this.lblTituloPrincipal.Location = new System.Drawing.Point(420, 35);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(215, 33);
            this.lblTituloPrincipal.TabIndex = 0;
            this.lblTituloPrincipal.Text = "MONITOR ROBOTS";
            this.lblTituloPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelContenido.Controls.Add(this.pictureBox2);
            this.panelContenido.Controls.Add(this.pictureBox1);
            this.panelContenido.Location = new System.Drawing.Point(177, 113);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1048, 530);
            this.panelContenido.TabIndex = 82;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Monitor_RobotsWeb.Properties.Resources.monitorRobots;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(426, 290);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 155);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Monitor_RobotsWeb.Properties.Resources.CEDLogo_letras;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(313, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 169);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::Monitor_RobotsWeb.Properties.Resources.logoCED_2;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(177, 114);
            this.panelLogo.TabIndex = 5;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackgroundImage = global::Monitor_RobotsWeb.Properties.Resources.maximizar;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.Location = new System.Drawing.Point(989, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(21, 21);
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            // 
            // btnNotificaciones
            // 
            this.btnNotificaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotificaciones.FlatAppearance.BorderSize = 0;
            this.btnNotificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificaciones.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotificaciones.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNotificaciones.Image = global::Monitor_RobotsWeb.Properties.Resources.alarm__1_;
            this.btnNotificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotificaciones.Location = new System.Drawing.Point(0, 240);
            this.btnNotificaciones.Name = "btnNotificaciones";
            this.btnNotificaciones.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNotificaciones.Size = new System.Drawing.Size(177, 60);
            this.btnNotificaciones.TabIndex = 6;
            this.btnNotificaciones.Text = "Notificaciones";
            this.btnNotificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotificaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotificaciones.UseVisualStyleBackColor = true;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConfiguracion.Image = global::Monitor_RobotsWeb.Properties.Resources.settings;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 180);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnConfiguracion.Size = new System.Drawing.Size(177, 60);
            this.btnConfiguracion.TabIndex = 4;
            this.btnConfiguracion.Text = "Configuración";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            // 
            // btnRobotEjec
            // 
            this.btnRobotEjec.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRobotEjec.FlatAppearance.BorderSize = 0;
            this.btnRobotEjec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRobotEjec.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRobotEjec.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRobotEjec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRobotEjec.Location = new System.Drawing.Point(0, 120);
            this.btnRobotEjec.Name = "btnRobotEjec";
            this.btnRobotEjec.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRobotEjec.Size = new System.Drawing.Size(177, 60);
            this.btnRobotEjec.TabIndex = 3;
            this.btnRobotEjec.Text = "Robot en Ejecución";
            this.btnRobotEjec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRobotEjec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRobotEjec.UseVisualStyleBackColor = true;
            // 
            // btnDetail
            // 
            this.btnDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetail.FlatAppearance.BorderSize = 0;
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetail.Location = new System.Drawing.Point(0, 60);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDetail.Size = new System.Drawing.Size(177, 60);
            this.btnDetail.TabIndex = 2;
            this.btnDetail.Text = "Detalle Robots";
            this.btnDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetail.UseVisualStyleBackColor = true;
            // 
            // btnEstAct
            // 
            this.btnEstAct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstAct.FlatAppearance.BorderSize = 0;
            this.btnEstAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstAct.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstAct.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEstAct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstAct.Location = new System.Drawing.Point(0, 0);
            this.btnEstAct.Name = "btnEstAct";
            this.btnEstAct.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEstAct.Size = new System.Drawing.Size(177, 60);
            this.btnEstAct.TabIndex = 1;
            this.btnEstAct.Text = "Estado Actual (Todos)";
            this.btnEstAct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstAct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstAct.UseVisualStyleBackColor = true;
            // 
            // frmMonitorRobots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 644);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMonitorRobots";
            this.Text = "Monitor Robots";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label robotEnCurso;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Button btnRobotEjec;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnEstAct;
        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnCerrarPrincipal;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrarFormHijo;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNotificaciones;
    }
}

