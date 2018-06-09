namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LOGIN = new System.Windows.Forms.GroupBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.PUBLICACION = new System.Windows.Forms.ToolStripMenuItem();
            this.PUBLICAR = new System.Windows.Forms.ToolStripMenuItem();
            this.PUBLICAR_AMB = new System.Windows.Forms.ToolStripMenuItem();
            this.COMPRA = new System.Windows.Forms.ToolStripMenuItem();
            this.COMPRA_BUSCAR = new System.Windows.Forms.ToolStripMenuItem();
            this.COMPRA_Editar = new System.Windows.Forms.ToolStripMenuItem();
            this.miHistorialDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ABM = new System.Windows.Forms.ToolStripMenuItem();
            this.AMB_ROL = new System.Windows.Forms.ToolStripMenuItem();
            this.AMB_USUARIO = new System.Windows.Forms.ToolStripMenuItem();
            this.cAMBIARMIPWDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vERIFICARDUPLICADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTARESTADISTICASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTAFACTURASAVENDEDORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SALIR = new System.Windows.Forms.ToolStripMenuItem();
            this.STATUS = new System.Windows.Forms.StatusStrip();
            this.STATUS_LABEL = new System.Windows.Forms.ToolStripStatusLabel();
            this.idUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lidusuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.gboxHoraFechaSistema = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dTimePiker_HoraNueva = new System.Windows.Forms.DateTimePicker();
            this.btActualizarHora = new System.Windows.Forms.Button();
            this.dTimePiker_FechaNueva = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dTimePiker_HoraActual = new System.Windows.Forms.DateTimePicker();
            this.dTimePiker_FechaActual = new System.Windows.Forms.DateTimePicker();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.gboxElegirRol = new System.Windows.Forms.GroupBox();
            this.btAceptarElegirRol = new System.Windows.Forms.Button();
            this.comboElegirRol = new System.Windows.Forms.ComboBox();
            this.ABM_VIS = new System.Windows.Forms.ToolStripMenuItem();
            this.LOGIN.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.STATUS.SuspendLayout();
            this.gboxHoraFechaSistema.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gboxElegirRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mercado-Envio v1.0";
            // 
            // LOGIN
            // 
            this.LOGIN.Controls.Add(this.bLogin);
            this.LOGIN.Controls.Add(this.txtPassword);
            this.LOGIN.Controls.Add(this.txtUsuario);
            this.LOGIN.Controls.Add(this.label3);
            this.LOGIN.Controls.Add(this.label2);
            this.LOGIN.Location = new System.Drawing.Point(13, 45);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(259, 144);
            this.LOGIN.TabIndex = 1;
            this.LOGIN.TabStop = false;
            this.LOGIN.Text = "Login";
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(114, 110);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(139, 23);
            this.bLogin.TabIndex = 4;
            this.bLogin.Text = "Loguearse";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(90, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(163, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(90, 31);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(163, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Contraseña (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario (*)";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PUBLICACION,
            this.COMPRA,
            this.ABM,
            this.SALIR});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(284, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // PUBLICACION
            // 
            this.PUBLICACION.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PUBLICAR,
            this.PUBLICAR_AMB});
            this.PUBLICACION.Enabled = false;
            this.PUBLICACION.Name = "PUBLICACION";
            this.PUBLICACION.Size = new System.Drawing.Size(95, 20);
            this.PUBLICACION.Text = "PUBLICACION";
            this.PUBLICACION.Visible = false;
            // 
            // PUBLICAR
            // 
            this.PUBLICAR.Name = "PUBLICAR";
            this.PUBLICAR.Size = new System.Drawing.Size(117, 22);
            this.PUBLICAR.Text = "Publicar";
            this.PUBLICAR.Click += new System.EventHandler(this.VENTA_DIRECTA_Click);
            // 
            // PUBLICAR_AMB
            // 
            this.PUBLICAR_AMB.Enabled = false;
            this.PUBLICAR_AMB.Name = "PUBLICAR_AMB";
            this.PUBLICAR_AMB.Size = new System.Drawing.Size(117, 22);
            this.PUBLICAR_AMB.Text = "Editar";
            this.PUBLICAR_AMB.Visible = false;
            this.PUBLICAR_AMB.Click += new System.EventHandler(this.PUBLICAR_AMB_Click);
            // 
            // COMPRA
            // 
            this.COMPRA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.COMPRA_BUSCAR,
            this.COMPRA_Editar,
            this.miHistorialDeComprasToolStripMenuItem,
            this.calificarToolStripMenuItem});
            this.COMPRA.Enabled = false;
            this.COMPRA.Name = "COMPRA";
            this.COMPRA.Size = new System.Drawing.Size(69, 20);
            this.COMPRA.Text = "COMPRA";
            this.COMPRA.Visible = false;
            this.COMPRA.Click += new System.EventHandler(this.COMPRA_Click);
            // 
            // COMPRA_BUSCAR
            // 
            this.COMPRA_BUSCAR.Name = "COMPRA_BUSCAR";
            this.COMPRA_BUSCAR.Size = new System.Drawing.Size(198, 22);
            this.COMPRA_BUSCAR.Text = "Buscar";
            this.COMPRA_BUSCAR.Visible = false;
            this.COMPRA_BUSCAR.Click += new System.EventHandler(this.COMPRA_BUSCAR_Click);
            // 
            // COMPRA_Editar
            // 
            this.COMPRA_Editar.Enabled = false;
            this.COMPRA_Editar.Name = "COMPRA_Editar";
            this.COMPRA_Editar.Size = new System.Drawing.Size(198, 22);
            this.COMPRA_Editar.Text = "Editar";
            this.COMPRA_Editar.Visible = false;
            // 
            // miHistorialDeComprasToolStripMenuItem
            // 
            this.miHistorialDeComprasToolStripMenuItem.Name = "miHistorialDeComprasToolStripMenuItem";
            this.miHistorialDeComprasToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.miHistorialDeComprasToolStripMenuItem.Text = "Mi historial de compras";
            this.miHistorialDeComprasToolStripMenuItem.Visible = false;
            this.miHistorialDeComprasToolStripMenuItem.Click += new System.EventHandler(this.miHistorialDeComprasToolStripMenuItem_Click);
            // 
            // calificarToolStripMenuItem
            // 
            this.calificarToolStripMenuItem.Name = "calificarToolStripMenuItem";
            this.calificarToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.calificarToolStripMenuItem.Text = "Calificar";
            this.calificarToolStripMenuItem.Visible = false;
            this.calificarToolStripMenuItem.Click += new System.EventHandler(this.calificarToolStripMenuItem_Click);
            // 
            // ABM
            // 
            this.ABM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AMB_ROL,
            this.AMB_USUARIO,
            this.ABM_VIS,
            this.cAMBIARMIPWDToolStripMenuItem,
            this.vERIFICARDUPLICADOSToolStripMenuItem,
            this.cONSULTARESTADISTICASToolStripMenuItem,
            this.cONSULTAFACTURASAVENDEDORToolStripMenuItem});
            this.ABM.Enabled = false;
            this.ABM.Name = "ABM";
            this.ABM.Size = new System.Drawing.Size(45, 20);
            this.ABM.Text = "AMB";
            this.ABM.Visible = false;
            // 
            // AMB_ROL
            // 
            this.AMB_ROL.Name = "AMB_ROL";
            this.AMB_ROL.Size = new System.Drawing.Size(267, 22);
            this.AMB_ROL.Text = "ROL";
            this.AMB_ROL.Click += new System.EventHandler(this.AMB_ROL_Click);
            // 
            // AMB_USUARIO
            // 
            this.AMB_USUARIO.Name = "AMB_USUARIO";
            this.AMB_USUARIO.Size = new System.Drawing.Size(267, 22);
            this.AMB_USUARIO.Text = "USUARIO";
            this.AMB_USUARIO.Click += new System.EventHandler(this.AMB_USUARIO_Click);
            // 
            // cAMBIARMIPWDToolStripMenuItem
            // 
            this.cAMBIARMIPWDToolStripMenuItem.Name = "cAMBIARMIPWDToolStripMenuItem";
            this.cAMBIARMIPWDToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.cAMBIARMIPWDToolStripMenuItem.Text = "CAMBIAR MI PWD";
            this.cAMBIARMIPWDToolStripMenuItem.Click += new System.EventHandler(this.cAMBIARMIPWDToolStripMenuItem_Click);
            // 
            // vERIFICARDUPLICADOSToolStripMenuItem
            // 
            this.vERIFICARDUPLICADOSToolStripMenuItem.Name = "vERIFICARDUPLICADOSToolStripMenuItem";
            this.vERIFICARDUPLICADOSToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.vERIFICARDUPLICADOSToolStripMenuItem.Text = "VERIFICAR DUPLICADOS";
            this.vERIFICARDUPLICADOSToolStripMenuItem.Click += new System.EventHandler(this.vERIFICARDUPLICADOSToolStripMenuItem_Click);
            // 
            // cONSULTARESTADISTICASToolStripMenuItem
            // 
            this.cONSULTARESTADISTICASToolStripMenuItem.Name = "cONSULTARESTADISTICASToolStripMenuItem";
            this.cONSULTARESTADISTICASToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.cONSULTARESTADISTICASToolStripMenuItem.Text = "CONSULTAR ESTADISTICAS";
            this.cONSULTARESTADISTICASToolStripMenuItem.Click += new System.EventHandler(this.cONSULTARESTADISTICASToolStripMenuItem_Click);
            // 
            // cONSULTAFACTURASAVENDEDORToolStripMenuItem
            // 
            this.cONSULTAFACTURASAVENDEDORToolStripMenuItem.Name = "cONSULTAFACTURASAVENDEDORToolStripMenuItem";
            this.cONSULTAFACTURASAVENDEDORToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.cONSULTAFACTURASAVENDEDORToolStripMenuItem.Text = "CONSULTA FACTURAS A VENDEDOR";
            this.cONSULTAFACTURASAVENDEDORToolStripMenuItem.Visible = false;
            this.cONSULTAFACTURASAVENDEDORToolStripMenuItem.Click += new System.EventHandler(this.cONSULTAFACTURASAVENDEDORToolStripMenuItem_Click);
            // 
            // SALIR
            // 
            this.SALIR.Enabled = false;
            this.SALIR.Name = "SALIR";
            this.SALIR.Size = new System.Drawing.Size(49, 20);
            this.SALIR.Text = "SALIR";
            this.SALIR.Visible = false;
            this.SALIR.Click += new System.EventHandler(this.SALIR_Click);
            // 
            // STATUS
            // 
            this.STATUS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.STATUS_LABEL,
            this.idUsuario,
            this.lidusuario});
            this.STATUS.Location = new System.Drawing.Point(0, 240);
            this.STATUS.Name = "STATUS";
            this.STATUS.Size = new System.Drawing.Size(284, 22);
            this.STATUS.TabIndex = 6;
            this.STATUS.Text = "toolStripStatusLabel1";
            // 
            // STATUS_LABEL
            // 
            this.STATUS_LABEL.Name = "STATUS_LABEL";
            this.STATUS_LABEL.Size = new System.Drawing.Size(0, 17);
            // 
            // idUsuario
            // 
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // lidusuario
            // 
            this.lidusuario.Name = "lidusuario";
            this.lidusuario.Size = new System.Drawing.Size(0, 17);
            this.lidusuario.Visible = false;
            // 
            // gboxHoraFechaSistema
            // 
            this.gboxHoraFechaSistema.Controls.Add(this.groupBox3);
            this.gboxHoraFechaSistema.Controls.Add(this.groupBox2);
            this.gboxHoraFechaSistema.Enabled = false;
            this.gboxHoraFechaSistema.Location = new System.Drawing.Point(12, 45);
            this.gboxHoraFechaSistema.Name = "gboxHoraFechaSistema";
            this.gboxHoraFechaSistema.Size = new System.Drawing.Size(259, 192);
            this.gboxHoraFechaSistema.TabIndex = 5;
            this.gboxHoraFechaSistema.TabStop = false;
            this.gboxHoraFechaSistema.Text = "Hora y Fecha del Sistema";
            this.gboxHoraFechaSistema.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dTimePiker_HoraNueva);
            this.groupBox3.Controls.Add(this.btActualizarHora);
            this.groupBox3.Controls.Add(this.dTimePiker_FechaNueva);
            this.groupBox3.Location = new System.Drawing.Point(6, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 76);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nueva Hora y Fecha";
            // 
            // dTimePiker_HoraNueva
            // 
            this.dTimePiker_HoraNueva.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dTimePiker_HoraNueva.Enabled = false;
            this.dTimePiker_HoraNueva.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTimePiker_HoraNueva.Location = new System.Drawing.Point(8, 50);
            this.dTimePiker_HoraNueva.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dTimePiker_HoraNueva.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dTimePiker_HoraNueva.Name = "dTimePiker_HoraNueva";
            this.dTimePiker_HoraNueva.ShowUpDown = true;
            this.dTimePiker_HoraNueva.Size = new System.Drawing.Size(110, 20);
            this.dTimePiker_HoraNueva.TabIndex = 5;
            this.dTimePiker_HoraNueva.Value = new System.DateTime(2016, 6, 1, 12, 0, 0, 0);
            // 
            // btActualizarHora
            // 
            this.btActualizarHora.Location = new System.Drawing.Point(125, 47);
            this.btActualizarHora.Name = "btActualizarHora";
            this.btActualizarHora.Size = new System.Drawing.Size(115, 23);
            this.btActualizarHora.TabIndex = 6;
            this.btActualizarHora.Text = "Actualizar";
            this.btActualizarHora.UseVisualStyleBackColor = true;
            this.btActualizarHora.Click += new System.EventHandler(this.btActualizarHora_Click);
            // 
            // dTimePiker_FechaNueva
            // 
            this.dTimePiker_FechaNueva.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dTimePiker_FechaNueva.Location = new System.Drawing.Point(8, 20);
            this.dTimePiker_FechaNueva.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dTimePiker_FechaNueva.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dTimePiker_FechaNueva.Name = "dTimePiker_FechaNueva";
            this.dTimePiker_FechaNueva.Size = new System.Drawing.Size(232, 20);
            this.dTimePiker_FechaNueva.TabIndex = 4;
            this.dTimePiker_FechaNueva.Value = new System.DateTime(2016, 6, 1, 12, 0, 0, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dTimePiker_HoraActual);
            this.groupBox2.Controls.Add(this.dTimePiker_FechaActual);
            this.groupBox2.Location = new System.Drawing.Point(6, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 73);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actuales";
            // 
            // dTimePiker_HoraActual
            // 
            this.dTimePiker_HoraActual.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dTimePiker_HoraActual.Enabled = false;
            this.dTimePiker_HoraActual.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTimePiker_HoraActual.Location = new System.Drawing.Point(68, 46);
            this.dTimePiker_HoraActual.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dTimePiker_HoraActual.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dTimePiker_HoraActual.Name = "dTimePiker_HoraActual";
            this.dTimePiker_HoraActual.ShowUpDown = true;
            this.dTimePiker_HoraActual.Size = new System.Drawing.Size(110, 20);
            this.dTimePiker_HoraActual.TabIndex = 3;
            this.dTimePiker_HoraActual.Value = new System.DateTime(2016, 6, 1, 12, 0, 0, 0);
            // 
            // dTimePiker_FechaActual
            // 
            this.dTimePiker_FechaActual.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dTimePiker_FechaActual.Enabled = false;
            this.dTimePiker_FechaActual.Location = new System.Drawing.Point(8, 16);
            this.dTimePiker_FechaActual.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dTimePiker_FechaActual.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dTimePiker_FechaActual.Name = "dTimePiker_FechaActual";
            this.dTimePiker_FechaActual.Size = new System.Drawing.Size(232, 20);
            this.dTimePiker_FechaActual.TabIndex = 2;
            this.dTimePiker_FechaActual.Value = new System.DateTime(2016, 6, 1, 12, 0, 0, 0);
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(143, 28);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtIdUsuario.TabIndex = 7;
            this.txtIdUsuario.Visible = false;
            // 
            // gboxElegirRol
            // 
            this.gboxElegirRol.Controls.Add(this.btAceptarElegirRol);
            this.gboxElegirRol.Controls.Add(this.comboElegirRol);
            this.gboxElegirRol.Enabled = false;
            this.gboxElegirRol.Location = new System.Drawing.Point(4, 76);
            this.gboxElegirRol.Name = "gboxElegirRol";
            this.gboxElegirRol.Size = new System.Drawing.Size(268, 110);
            this.gboxElegirRol.TabIndex = 8;
            this.gboxElegirRol.TabStop = false;
            this.gboxElegirRol.Text = "Elegir Rol";
            this.gboxElegirRol.Visible = false;
            // 
            // btAceptarElegirRol
            // 
            this.btAceptarElegirRol.Location = new System.Drawing.Point(64, 74);
            this.btAceptarElegirRol.Name = "btAceptarElegirRol";
            this.btAceptarElegirRol.Size = new System.Drawing.Size(136, 23);
            this.btAceptarElegirRol.TabIndex = 1;
            this.btAceptarElegirRol.Text = "Aceptar";
            this.btAceptarElegirRol.UseVisualStyleBackColor = true;
            this.btAceptarElegirRol.Click += new System.EventHandler(this.btAceptarElegirRol_Click);
            // 
            // comboElegirRol
            // 
            this.comboElegirRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboElegirRol.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboElegirRol.Location = new System.Drawing.Point(19, 38);
            this.comboElegirRol.Name = "comboElegirRol";
            this.comboElegirRol.Size = new System.Drawing.Size(232, 21);
            this.comboElegirRol.TabIndex = 0;
            // 
            // ABM_VIS
            // 
            this.ABM_VIS.Enabled = false;
            this.ABM_VIS.Name = "ABM_VIS";
            this.ABM_VIS.Size = new System.Drawing.Size(267, 22);
            this.ABM_VIS.Text = "VISIBILIDAD";
            this.ABM_VIS.Visible = false;
            this.ABM_VIS.Click += new System.EventHandler(this.ABM_VIS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.gboxElegirRol);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.gboxHoraFechaSistema);
            this.Controls.Add(this.STATUS);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LOGIN.ResumeLayout(false);
            this.LOGIN.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.STATUS.ResumeLayout(false);
            this.STATUS.PerformLayout();
            this.gboxHoraFechaSistema.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gboxElegirRol.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox LOGIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ABM;
        private System.Windows.Forms.ToolStripMenuItem AMB_ROL;
        private System.Windows.Forms.ToolStripMenuItem AMB_USUARIO;
        private System.Windows.Forms.ToolStripMenuItem SALIR;
        private System.Windows.Forms.StatusStrip STATUS;
        private System.Windows.Forms.ToolStripStatusLabel STATUS_LABEL;
        private System.Windows.Forms.ToolStripMenuItem COMPRA;
        private System.Windows.Forms.ToolStripMenuItem COMPRA_BUSCAR;
        private System.Windows.Forms.ToolStripMenuItem COMPRA_Editar;
        private System.Windows.Forms.ToolStripMenuItem PUBLICACION;
        private System.Windows.Forms.ToolStripMenuItem PUBLICAR;
        private System.Windows.Forms.ToolStripMenuItem PUBLICAR_AMB;
        private System.Windows.Forms.GroupBox gboxHoraFechaSistema;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btActualizarHora;
        private System.Windows.Forms.DateTimePicker dTimePiker_HoraNueva;
        private System.Windows.Forms.DateTimePicker dTimePiker_FechaNueva;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dTimePiker_HoraActual;
        private System.Windows.Forms.DateTimePicker dTimePiker_FechaActual;
        private System.Windows.Forms.ToolStripStatusLabel idUsuario;
        public System.Windows.Forms.ToolStripStatusLabel lidusuario;
        private System.Windows.Forms.ToolStripMenuItem cAMBIARMIPWDToolStripMenuItem;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.ToolStripMenuItem vERIFICARDUPLICADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miHistorialDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTARESTADISTICASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTAFACTURASAVENDEDORToolStripMenuItem;
        private System.Windows.Forms.GroupBox gboxElegirRol;
        private System.Windows.Forms.Button btAceptarElegirRol;
        private System.Windows.Forms.ComboBox comboElegirRol;
        private System.Windows.Forms.ToolStripMenuItem ABM_VIS;
    }
}

