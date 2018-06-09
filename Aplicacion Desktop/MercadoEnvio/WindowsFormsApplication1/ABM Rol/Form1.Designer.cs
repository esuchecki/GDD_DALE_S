namespace WindowsFormsApplication1.ABM_Rol
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gboxVerRolesGrupo = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvFuncionalidadesDelRol = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.idrolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBMROL1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBM_ROL1 = new WindowsFormsApplication1.ABM_Rol.ABM_ROL();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtIdRol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRolSeleccionado = new System.Windows.Forms.TextBox();
            this.rolfuncionalidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBM_ROL_FUNCIONALIDAD = new WindowsFormsApplication1.ABM_Rol.ABM_ROL_FUNCIONALIDAD();
            this.rolTableAdapter = new WindowsFormsApplication1.ABM_Rol.ABM_ROLTableAdapters.rolTableAdapter();
            this.rol_funcionalidadTableAdapter = new WindowsFormsApplication1.ABM_Rol.ABM_ROL_FUNCIONALIDADTableAdapters.rol_funcionalidadTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNuevoRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEliminarRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionalidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNuevaFuncionalidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarFuncionalidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarFuncionalidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionalidadxrolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gboxCrearModificarGrupo = new System.Windows.Forms.GroupBox();
            this.bt_Izq_A_Der = new System.Windows.Forms.Button();
            this.bt_Der_A_Izq = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvFuncionesAsignadas = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvFuncionesDisp = new System.Windows.Forms.DataGridView();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtIdModificar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNuevoRol = new System.Windows.Forms.TextBox();
            this.btDeshacerCambios = new System.Windows.Forms.Button();
            this.btGuardarCambios = new System.Windows.Forms.Button();
            this.gboxVerRolesGrupo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidadesDelRol)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMROL1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBM_ROL1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolfuncionalidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBM_ROL_FUNCIONALIDAD)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadxrolBindingSource)).BeginInit();
            this.gboxCrearModificarGrupo.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionesAsignadas)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionesDisp)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxVerRolesGrupo
            // 
            this.gboxVerRolesGrupo.Controls.Add(this.groupBox3);
            this.gboxVerRolesGrupo.Controls.Add(this.groupBox2);
            this.gboxVerRolesGrupo.Controls.Add(this.groupBox4);
            this.gboxVerRolesGrupo.Location = new System.Drawing.Point(6, 57);
            this.gboxVerRolesGrupo.Name = "gboxVerRolesGrupo";
            this.gboxVerRolesGrupo.Size = new System.Drawing.Size(911, 312);
            this.gboxVerRolesGrupo.TabIndex = 0;
            this.gboxVerRolesGrupo.TabStop = false;
            this.gboxVerRolesGrupo.Text = "Listado de Roles y Funcionalidades";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvFuncionalidadesDelRol);
            this.groupBox3.Location = new System.Drawing.Point(392, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(513, 205);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Funcionalidad";
            // 
            // dgvFuncionalidadesDelRol
            // 
            this.dgvFuncionalidadesDelRol.AllowUserToAddRows = false;
            this.dgvFuncionalidadesDelRol.AllowUserToDeleteRows = false;
            this.dgvFuncionalidadesDelRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionalidadesDelRol.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFuncionalidadesDelRol.Location = new System.Drawing.Point(11, 19);
            this.dgvFuncionalidadesDelRol.Name = "dgvFuncionalidadesDelRol";
            this.dgvFuncionalidadesDelRol.ReadOnly = true;
            this.dgvFuncionalidadesDelRol.Size = new System.Drawing.Size(502, 180);
            this.dgvFuncionalidadesDelRol.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvRoles);
            this.groupBox2.Location = new System.Drawing.Point(6, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 205);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rol";
            // 
            // dgvRoles
            // 
            this.dgvRoles.AllowUserToAddRows = false;
            this.dgvRoles.AllowUserToDeleteRows = false;
            this.dgvRoles.AutoGenerateColumns = false;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idrolDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn});
            this.dgvRoles.DataSource = this.rolBindingSource;
            this.dgvRoles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvRoles.Location = new System.Drawing.Point(6, 19);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.ReadOnly = true;
            this.dgvRoles.Size = new System.Drawing.Size(356, 180);
            this.dgvRoles.TabIndex = 1;
            this.dgvRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellClick);
            // 
            // idrolDataGridViewTextBoxColumn
            // 
            this.idrolDataGridViewTextBoxColumn.DataPropertyName = "idrol";
            this.idrolDataGridViewTextBoxColumn.HeaderText = "idrol";
            this.idrolDataGridViewTextBoxColumn.Name = "idrolDataGridViewTextBoxColumn";
            this.idrolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            this.estadoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "rol";
            this.rolBindingSource.DataSource = this.aBMROL1BindingSource;
            // 
            // aBMROL1BindingSource
            // 
            this.aBMROL1BindingSource.DataSource = this.aBM_ROL1;
            this.aBMROL1BindingSource.Position = 0;
            // 
            // aBM_ROL1
            // 
            this.aBM_ROL1.DataSetName = "ABM_ROL";
            this.aBM_ROL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtIdRol);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtRolSeleccionado);
            this.groupBox4.Location = new System.Drawing.Point(7, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(898, 52);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // txtIdRol
            // 
            this.txtIdRol.Location = new System.Drawing.Point(28, 19);
            this.txtIdRol.Name = "txtIdRol";
            this.txtIdRol.Size = new System.Drawing.Size(35, 20);
            this.txtIdRol.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rol Seleccionado:";
            // 
            // txtRolSeleccionado
            // 
            this.txtRolSeleccionado.BackColor = System.Drawing.Color.White;
            this.txtRolSeleccionado.Location = new System.Drawing.Point(253, 20);
            this.txtRolSeleccionado.Name = "txtRolSeleccionado";
            this.txtRolSeleccionado.ReadOnly = true;
            this.txtRolSeleccionado.Size = new System.Drawing.Size(362, 20);
            this.txtRolSeleccionado.TabIndex = 7;
            this.txtRolSeleccionado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rolfuncionalidadBindingSource
            // 
            this.rolfuncionalidadBindingSource.DataMember = "rol_funcionalidad";
            this.rolfuncionalidadBindingSource.DataSource = this.aBM_ROL_FUNCIONALIDAD;
            // 
            // aBM_ROL_FUNCIONALIDAD
            // 
            this.aBM_ROL_FUNCIONALIDAD.DataSetName = "ABM_ROL_FUNCIONALIDAD";
            this.aBM_ROL_FUNCIONALIDAD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
            // 
            // rol_funcionalidadTableAdapter
            // 
            this.rol_funcionalidadTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolToolStripMenuItem,
            this.funcionalidadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rolToolStripMenuItem
            // 
            this.rolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNuevoRolToolStripMenuItem,
            this.modificarEliminarRolToolStripMenuItem,
            this.eliminarRolToolStripMenuItem});
            this.rolToolStripMenuItem.Name = "rolToolStripMenuItem";
            this.rolToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.rolToolStripMenuItem.Text = "Rol";
            // 
            // crearNuevoRolToolStripMenuItem
            // 
            this.crearNuevoRolToolStripMenuItem.Name = "crearNuevoRolToolStripMenuItem";
            this.crearNuevoRolToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.crearNuevoRolToolStripMenuItem.Text = "Crear Nuevo (Rol)";
            this.crearNuevoRolToolStripMenuItem.Click += new System.EventHandler(this.crearNuevoRolToolStripMenuItem_Click);
            // 
            // modificarEliminarRolToolStripMenuItem
            // 
            this.modificarEliminarRolToolStripMenuItem.Name = "modificarEliminarRolToolStripMenuItem";
            this.modificarEliminarRolToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.modificarEliminarRolToolStripMenuItem.Text = "Modificar (Rol)";
            this.modificarEliminarRolToolStripMenuItem.Click += new System.EventHandler(this.modificarEliminarRolToolStripMenuItem_Click);
            // 
            // eliminarRolToolStripMenuItem
            // 
            this.eliminarRolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habilitarToolStripMenuItem,
            this.desToolStripMenuItem});
            this.eliminarRolToolStripMenuItem.Name = "eliminarRolToolStripMenuItem";
            this.eliminarRolToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.eliminarRolToolStripMenuItem.Text = "Cambiar Estado (Rol)";
            // 
            // habilitarToolStripMenuItem
            // 
            this.habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            this.habilitarToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.habilitarToolStripMenuItem.Text = "Habilitar";
            this.habilitarToolStripMenuItem.Click += new System.EventHandler(this.habilitarToolStripMenuItem_Click);
            // 
            // desToolStripMenuItem
            // 
            this.desToolStripMenuItem.Name = "desToolStripMenuItem";
            this.desToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.desToolStripMenuItem.Text = "Des-Habilitar";
            this.desToolStripMenuItem.Click += new System.EventHandler(this.desToolStripMenuItem_Click);
            // 
            // funcionalidadToolStripMenuItem
            // 
            this.funcionalidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNuevaFuncionalidadToolStripMenuItem,
            this.modificarFuncionalidadToolStripMenuItem,
            this.eliminarFuncionalidadToolStripMenuItem});
            this.funcionalidadToolStripMenuItem.Name = "funcionalidadToolStripMenuItem";
            this.funcionalidadToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.funcionalidadToolStripMenuItem.Text = "Funcionalidad";
            // 
            // crearNuevaFuncionalidadToolStripMenuItem
            // 
            this.crearNuevaFuncionalidadToolStripMenuItem.Name = "crearNuevaFuncionalidadToolStripMenuItem";
            this.crearNuevaFuncionalidadToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.crearNuevaFuncionalidadToolStripMenuItem.Text = "Crear Nueva (Funcionalidad)";
            // 
            // modificarFuncionalidadToolStripMenuItem
            // 
            this.modificarFuncionalidadToolStripMenuItem.Name = "modificarFuncionalidadToolStripMenuItem";
            this.modificarFuncionalidadToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.modificarFuncionalidadToolStripMenuItem.Text = "Modificar (Funcionalidad)";
            // 
            // eliminarFuncionalidadToolStripMenuItem
            // 
            this.eliminarFuncionalidadToolStripMenuItem.Name = "eliminarFuncionalidadToolStripMenuItem";
            this.eliminarFuncionalidadToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.eliminarFuncionalidadToolStripMenuItem.Text = "Eliminar (Funcionalidad)";
            // 
            // gboxCrearModificarGrupo
            // 
            this.gboxCrearModificarGrupo.Controls.Add(this.bt_Izq_A_Der);
            this.gboxCrearModificarGrupo.Controls.Add(this.bt_Der_A_Izq);
            this.gboxCrearModificarGrupo.Controls.Add(this.groupBox6);
            this.gboxCrearModificarGrupo.Controls.Add(this.groupBox7);
            this.gboxCrearModificarGrupo.Controls.Add(this.groupBox8);
            this.gboxCrearModificarGrupo.Location = new System.Drawing.Point(6, 69);
            this.gboxCrearModificarGrupo.Name = "gboxCrearModificarGrupo";
            this.gboxCrearModificarGrupo.Size = new System.Drawing.Size(911, 312);
            this.gboxCrearModificarGrupo.TabIndex = 8;
            this.gboxCrearModificarGrupo.TabStop = false;
            this.gboxCrearModificarGrupo.Text = "Crear / Moficiar Roles";
            // 
            // bt_Izq_A_Der
            // 
            this.bt_Izq_A_Der.Location = new System.Drawing.Point(403, 226);
            this.bt_Izq_A_Der.Name = "bt_Izq_A_Der";
            this.bt_Izq_A_Der.Size = new System.Drawing.Size(41, 23);
            this.bt_Izq_A_Der.TabIndex = 9;
            this.bt_Izq_A_Der.Text = "--- >";
            this.bt_Izq_A_Der.UseVisualStyleBackColor = true;
            this.bt_Izq_A_Der.Click += new System.EventHandler(this.bt_Izq_A_Der_Click);
            // 
            // bt_Der_A_Izq
            // 
            this.bt_Der_A_Izq.Location = new System.Drawing.Point(403, 187);
            this.bt_Der_A_Izq.Name = "bt_Der_A_Izq";
            this.bt_Der_A_Izq.Size = new System.Drawing.Size(41, 23);
            this.bt_Der_A_Izq.TabIndex = 8;
            this.bt_Der_A_Izq.Text = "< ----";
            this.bt_Der_A_Izq.UseVisualStyleBackColor = true;
            this.bt_Der_A_Izq.Click += new System.EventHandler(this.bt_Der_A_Izq_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvFuncionesAsignadas);
            this.groupBox6.Location = new System.Drawing.Point(467, 101);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(438, 205);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Funcionalidades Asignadas";
            // 
            // dgvFuncionesAsignadas
            // 
            this.dgvFuncionesAsignadas.AllowUserToAddRows = false;
            this.dgvFuncionesAsignadas.AllowUserToDeleteRows = false;
            this.dgvFuncionesAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionesAsignadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFuncionesAsignadas.Location = new System.Drawing.Point(11, 19);
            this.dgvFuncionesAsignadas.Name = "dgvFuncionesAsignadas";
            this.dgvFuncionesAsignadas.ReadOnly = true;
            this.dgvFuncionesAsignadas.Size = new System.Drawing.Size(421, 180);
            this.dgvFuncionesAsignadas.TabIndex = 4;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvFuncionesDisp);
            this.groupBox7.Location = new System.Drawing.Point(6, 101);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(380, 205);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Funcionalidades Disponibles";
            // 
            // dgvFuncionesDisp
            // 
            this.dgvFuncionesDisp.AllowUserToAddRows = false;
            this.dgvFuncionesDisp.AllowUserToDeleteRows = false;
            this.dgvFuncionesDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionesDisp.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFuncionesDisp.Location = new System.Drawing.Point(6, 19);
            this.dgvFuncionesDisp.Name = "dgvFuncionesDisp";
            this.dgvFuncionesDisp.ReadOnly = true;
            this.dgvFuncionesDisp.Size = new System.Drawing.Size(356, 180);
            this.dgvFuncionesDisp.TabIndex = 1;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtIdModificar);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.txtNuevoRol);
            this.groupBox8.Location = new System.Drawing.Point(7, 20);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(898, 52);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            // 
            // txtIdModificar
            // 
            this.txtIdModificar.Location = new System.Drawing.Point(28, 19);
            this.txtIdModificar.Name = "txtIdModificar";
            this.txtIdModificar.Size = new System.Drawing.Size(35, 20);
            this.txtIdModificar.TabIndex = 9;
            this.txtIdModificar.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rol Seleccionado:";
            // 
            // txtNuevoRol
            // 
            this.txtNuevoRol.BackColor = System.Drawing.Color.White;
            this.txtNuevoRol.Location = new System.Drawing.Point(253, 20);
            this.txtNuevoRol.Name = "txtNuevoRol";
            this.txtNuevoRol.Size = new System.Drawing.Size(362, 20);
            this.txtNuevoRol.TabIndex = 7;
            this.txtNuevoRol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btDeshacerCambios
            // 
            this.btDeshacerCambios.Location = new System.Drawing.Point(546, 30);
            this.btDeshacerCambios.Name = "btDeshacerCambios";
            this.btDeshacerCambios.Size = new System.Drawing.Size(179, 23);
            this.btDeshacerCambios.TabIndex = 11;
            this.btDeshacerCambios.Text = "Deshacer Cambios";
            this.btDeshacerCambios.UseVisualStyleBackColor = true;
            this.btDeshacerCambios.Click += new System.EventHandler(this.btDeshacerCambios_Click);
            // 
            // btGuardarCambios
            // 
            this.btGuardarCambios.Location = new System.Drawing.Point(731, 30);
            this.btGuardarCambios.Name = "btGuardarCambios";
            this.btGuardarCambios.Size = new System.Drawing.Size(180, 23);
            this.btGuardarCambios.TabIndex = 8;
            this.btGuardarCambios.Text = "Guardar Cambios";
            this.btGuardarCambios.UseVisualStyleBackColor = true;
            this.btGuardarCambios.Click += new System.EventHandler(this.btGuardarCambios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 387);
            this.Controls.Add(this.gboxCrearModificarGrupo);
            this.Controls.Add(this.btGuardarCambios);
            this.Controls.Add(this.btDeshacerCambios);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gboxVerRolesGrupo);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxVerRolesGrupo.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidadesDelRol)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBMROL1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBM_ROL1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolfuncionalidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBM_ROL_FUNCIONALIDAD)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionalidadxrolBindingSource)).EndInit();
            this.gboxCrearModificarGrupo.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionesAsignadas)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionesDisp)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxVerRolesGrupo;
        private ABM_ROL aBM_ROL;
        private System.Windows.Forms.BindingSource aBMROL1BindingSource;
        private ABM_ROL aBM_ROL1;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private ABM_ROLTableAdapters.rolTableAdapter rolTableAdapter;
        private ABM_ROL_FUNCIONALIDAD aBM_ROL_FUNCIONALIDAD;
        private System.Windows.Forms.BindingSource rolfuncionalidadBindingSource;
        private ABM_ROL_FUNCIONALIDADTableAdapters.rol_funcionalidadTableAdapter rol_funcionalidadTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNuevoRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEliminarRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desToolStripMenuItem;
        private System.Windows.Forms.BindingSource funcionalidadxrolBindingSource;
        private ABM_ROL_PROC_FXR aBM_ROL_PROC_FXR;
        private ABM_ROL_PROC_FXRTableAdapters.funcionalidad_x_rolTableAdapter funcionalidad_x_rolTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem funcionalidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNuevaFuncionalidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarFuncionalidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarFuncionalidadToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvFuncionalidadesDelRol;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRolSeleccionado;
        private System.Windows.Forms.TextBox txtIdRol;
        private System.Windows.Forms.GroupBox gboxCrearModificarGrupo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvFuncionesAsignadas;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvFuncionesDisp;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtIdModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNuevoRol;
        private System.Windows.Forms.Button bt_Der_A_Izq;
        private System.Windows.Forms.Button bt_Izq_A_Der;
        private System.Windows.Forms.Button btDeshacerCambios;
        private System.Windows.Forms.Button btGuardarCambios;



    }
}