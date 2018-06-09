namespace WindowsFormsApplication1.ComprarOfertar
{
    partial class comprarofertar
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
            this.DGBuscar = new System.Windows.Forms.DataGridView();
            this.DGstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGdescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_publicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permitir_envio = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permitir_preguntas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.prbuscarproductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscar_producto = new WindowsFormsApplication1.buscar_producto();
            this.TBdescripcion = new System.Windows.Forms.TextBox();
            this.Bcomprar = new System.Windows.Forms.Button();
            this.CBEnvio = new System.Windows.Forms.CheckBox();
            this.Cantidad = new System.Windows.Forms.NumericUpDown();
            this.DGpreguntas = new System.Windows.Forms.DataGridView();
            this.preguntaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respuestaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prpreguntasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.preguntas = new WindowsFormsApplication1.preguntas();
            this.pr_preguntasTableAdapter = new WindowsFormsApplication1.preguntasTableAdapters.pr_preguntasTableAdapter();
            this.GBbuscar = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBbuscardesc = new System.Windows.Forms.TextBox();
            this.LBrubros = new System.Windows.Forms.ListBox();
            this.rubroBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.rubrosBusqueda = new WindowsFormsApplication1.rubrosBusqueda();
            this.botonespaginas = new System.Windows.Forms.Panel();
            this.laeldee = new System.Windows.Forms.Label();
            this.labelactual = new System.Windows.Forms.Label();
            this.actual = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.buttonultima = new System.Windows.Forms.Button();
            this.buttonsiguiente = new System.Windows.Forms.Button();
            this.buttonanterior = new System.Windows.Forms.Button();
            this.buttonprimera = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.pr_buscar_productoTableAdapter = new WindowsFormsApplication1.buscar_productoTableAdapters.pr_buscar_productoTableAdapter();
            this.display = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxpreguntas = new System.Windows.Forms.TextBox();
            this.preguntar = new System.Windows.Forms.Button();
            this.rubro = new WindowsFormsApplication1.Rubro();
            this.rubroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rubroTableAdapter = new WindowsFormsApplication1.RubroTableAdapters.rubroTableAdapter();
            this.rubroTableAdapter1 = new WindowsFormsApplication1.rubrosBusquedaTableAdapters.rubroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DGBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prbuscarproductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscar_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGpreguntas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prpreguntasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preguntas)).BeginInit();
            this.GBbuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBusqueda)).BeginInit();
            this.botonespaginas.SuspendLayout();
            this.display.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rubro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGBuscar
            // 
            this.DGBuscar.AllowUserToAddRows = false;
            this.DGBuscar.AllowUserToDeleteRows = false;
            this.DGBuscar.AllowUserToResizeColumns = false;
            this.DGBuscar.AllowUserToResizeRows = false;
            this.DGBuscar.AutoGenerateColumns = false;
            this.DGBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBuscar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGstock,
            this.paginas,
            this.idpublicacion,
            this.DGdescripcion,
            this.DGPrecio,
            this.tipo_publicacion,
            this.fecha_vencimiento,
            this.permitir_envio,
            this.idusuario,
            this.idrubro,
            this.permitir_preguntas});
            this.DGBuscar.DataSource = this.prbuscarproductoBindingSource;
            this.DGBuscar.Location = new System.Drawing.Point(9, 19);
            this.DGBuscar.Name = "DGBuscar";
            this.DGBuscar.ReadOnly = true;
            this.DGBuscar.RowHeadersVisible = false;
            this.DGBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGBuscar.Size = new System.Drawing.Size(604, 296);
            this.DGBuscar.TabIndex = 0;
            this.DGBuscar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DGBuscar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGBuscar_CellContentClick);
            // 
            // DGstock
            // 
            this.DGstock.DataPropertyName = "stock";
            this.DGstock.FillWeight = 60F;
            this.DGstock.HeaderText = "stock";
            this.DGstock.Name = "DGstock";
            this.DGstock.ReadOnly = true;
            this.DGstock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGstock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DGstock.Width = 60;
            // 
            // paginas
            // 
            this.paginas.DataPropertyName = "paginas";
            this.paginas.HeaderText = "paginas";
            this.paginas.Name = "paginas";
            this.paginas.ReadOnly = true;
            this.paginas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.paginas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.paginas.Visible = false;
            // 
            // idpublicacion
            // 
            this.idpublicacion.DataPropertyName = "idpublicacion";
            this.idpublicacion.HeaderText = "idpublicacion";
            this.idpublicacion.Name = "idpublicacion";
            this.idpublicacion.ReadOnly = true;
            this.idpublicacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idpublicacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idpublicacion.Visible = false;
            // 
            // DGdescripcion
            // 
            this.DGdescripcion.DataPropertyName = "descripcion";
            this.DGdescripcion.HeaderText = "descripcion";
            this.DGdescripcion.Name = "DGdescripcion";
            this.DGdescripcion.ReadOnly = true;
            this.DGdescripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGdescripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DGdescripcion.Width = 140;
            // 
            // DGPrecio
            // 
            this.DGPrecio.DataPropertyName = "precio";
            this.DGPrecio.HeaderText = "precio";
            this.DGPrecio.Name = "DGPrecio";
            this.DGPrecio.ReadOnly = true;
            this.DGPrecio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGPrecio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tipo_publicacion
            // 
            this.tipo_publicacion.DataPropertyName = "tipo_publicacion";
            this.tipo_publicacion.HeaderText = "Tipo";
            this.tipo_publicacion.Name = "tipo_publicacion";
            this.tipo_publicacion.ReadOnly = true;
            this.tipo_publicacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tipo_publicacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fecha_vencimiento
            // 
            this.fecha_vencimiento.DataPropertyName = "fecha_vencimiento";
            this.fecha_vencimiento.HeaderText = "Vencimiento";
            this.fecha_vencimiento.Name = "fecha_vencimiento";
            this.fecha_vencimiento.ReadOnly = true;
            this.fecha_vencimiento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fecha_vencimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // permitir_envio
            // 
            this.permitir_envio.DataPropertyName = "permitir_envio";
            this.permitir_envio.HeaderText = "permitir_envio";
            this.permitir_envio.Name = "permitir_envio";
            this.permitir_envio.ReadOnly = true;
            this.permitir_envio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // idusuario
            // 
            this.idusuario.DataPropertyName = "idusuario";
            this.idusuario.HeaderText = "idusuario";
            this.idusuario.Name = "idusuario";
            this.idusuario.ReadOnly = true;
            this.idusuario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idusuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idusuario.Visible = false;
            // 
            // idrubro
            // 
            this.idrubro.DataPropertyName = "idrubro";
            this.idrubro.HeaderText = "idrubro";
            this.idrubro.Name = "idrubro";
            this.idrubro.ReadOnly = true;
            this.idrubro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idrubro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idrubro.Visible = false;
            // 
            // permitir_preguntas
            // 
            this.permitir_preguntas.DataPropertyName = "permitir_preguntas";
            this.permitir_preguntas.HeaderText = "permitir_preguntas";
            this.permitir_preguntas.Name = "permitir_preguntas";
            this.permitir_preguntas.ReadOnly = true;
            this.permitir_preguntas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.permitir_preguntas.Visible = false;
            // 
            // prbuscarproductoBindingSource
            // 
            this.prbuscarproductoBindingSource.DataMember = "pr_buscar_producto";
            this.prbuscarproductoBindingSource.DataSource = this.buscar_producto;
            // 
            // buscar_producto
            // 
            this.buscar_producto.DataSetName = "buscar_producto";
            this.buscar_producto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBdescripcion
            // 
            this.TBdescripcion.Location = new System.Drawing.Point(3, 3);
            this.TBdescripcion.Multiline = true;
            this.TBdescripcion.Name = "TBdescripcion";
            this.TBdescripcion.ReadOnly = true;
            this.TBdescripcion.Size = new System.Drawing.Size(533, 157);
            this.TBdescripcion.TabIndex = 1;
            this.TBdescripcion.TextChanged += new System.EventHandler(this.TBdescripcion_TextChanged);
            // 
            // Bcomprar
            // 
            this.Bcomprar.Enabled = false;
            this.Bcomprar.Location = new System.Drawing.Point(416, 162);
            this.Bcomprar.Name = "Bcomprar";
            this.Bcomprar.Size = new System.Drawing.Size(75, 23);
            this.Bcomprar.TabIndex = 2;
            this.Bcomprar.Text = "Comprar";
            this.Bcomprar.UseVisualStyleBackColor = true;
            this.Bcomprar.Visible = false;
            this.Bcomprar.Click += new System.EventHandler(this.Bcomprar_Click);
            // 
            // CBEnvio
            // 
            this.CBEnvio.AutoSize = true;
            this.CBEnvio.Enabled = false;
            this.CBEnvio.Location = new System.Drawing.Point(357, 166);
            this.CBEnvio.Name = "CBEnvio";
            this.CBEnvio.Size = new System.Drawing.Size(53, 17);
            this.CBEnvio.TabIndex = 3;
            this.CBEnvio.Text = "Envio";
            this.CBEnvio.UseMnemonic = false;
            this.CBEnvio.UseVisualStyleBackColor = true;
            this.CBEnvio.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.Enabled = false;
            this.Cantidad.Location = new System.Drawing.Point(497, 166);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(63, 20);
            this.Cantidad.TabIndex = 4;
            this.Cantidad.Visible = false;
            // 
            // DGpreguntas
            // 
            this.DGpreguntas.AllowUserToDeleteRows = false;
            this.DGpreguntas.AutoGenerateColumns = false;
            this.DGpreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGpreguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.preguntaDataGridViewTextBoxColumn,
            this.respuestaDataGridViewTextBoxColumn});
            this.DGpreguntas.DataSource = this.prpreguntasBindingSource;
            this.DGpreguntas.Location = new System.Drawing.Point(3, 193);
            this.DGpreguntas.Name = "DGpreguntas";
            this.DGpreguntas.ReadOnly = true;
            this.DGpreguntas.Size = new System.Drawing.Size(604, 150);
            this.DGpreguntas.TabIndex = 5;
            this.DGpreguntas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGpreguntas_CellContentClick);
            // 
            // preguntaDataGridViewTextBoxColumn
            // 
            this.preguntaDataGridViewTextBoxColumn.DataPropertyName = "pregunta";
            this.preguntaDataGridViewTextBoxColumn.FillWeight = 150F;
            this.preguntaDataGridViewTextBoxColumn.HeaderText = "pregunta";
            this.preguntaDataGridViewTextBoxColumn.Name = "preguntaDataGridViewTextBoxColumn";
            this.preguntaDataGridViewTextBoxColumn.ReadOnly = true;
            this.preguntaDataGridViewTextBoxColumn.Width = 250;
            // 
            // respuestaDataGridViewTextBoxColumn
            // 
            this.respuestaDataGridViewTextBoxColumn.DataPropertyName = "respuesta";
            this.respuestaDataGridViewTextBoxColumn.FillWeight = 150F;
            this.respuestaDataGridViewTextBoxColumn.HeaderText = "respuesta";
            this.respuestaDataGridViewTextBoxColumn.Name = "respuestaDataGridViewTextBoxColumn";
            this.respuestaDataGridViewTextBoxColumn.ReadOnly = true;
            this.respuestaDataGridViewTextBoxColumn.Width = 250;
            // 
            // prpreguntasBindingSource
            // 
            this.prpreguntasBindingSource.DataMember = "pr_preguntas";
            this.prpreguntasBindingSource.DataSource = this.preguntas;
            // 
            // preguntas
            // 
            this.preguntas.DataSetName = "preguntas";
            this.preguntas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pr_preguntasTableAdapter
            // 
            this.pr_preguntasTableAdapter.ClearBeforeFill = true;
            // 
            // GBbuscar
            // 
            this.GBbuscar.Controls.Add(this.label2);
            this.GBbuscar.Controls.Add(this.label1);
            this.GBbuscar.Controls.Add(this.TBbuscardesc);
            this.GBbuscar.Controls.Add(this.LBrubros);
            this.GBbuscar.Controls.Add(this.botonespaginas);
            this.GBbuscar.Controls.Add(this.buttonBuscar);
            this.GBbuscar.Controls.Add(this.DGBuscar);
            this.GBbuscar.Location = new System.Drawing.Point(12, 21);
            this.GBbuscar.Name = "GBbuscar";
            this.GBbuscar.Size = new System.Drawing.Size(786, 377);
            this.GBbuscar.TabIndex = 6;
            this.GBbuscar.TabStop = false;
            this.GBbuscar.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Filtrar por Rubros:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filtrar por descripcion:";
            // 
            // TBbuscardesc
            // 
            this.TBbuscardesc.Location = new System.Drawing.Point(625, 178);
            this.TBbuscardesc.MaxLength = 255;
            this.TBbuscardesc.Name = "TBbuscardesc";
            this.TBbuscardesc.Size = new System.Drawing.Size(155, 20);
            this.TBbuscardesc.TabIndex = 12;
            // 
            // LBrubros
            // 
            this.LBrubros.DataSource = this.rubroBindingSource2;
            this.LBrubros.DisplayMember = "descripcion_corta";
            this.LBrubros.FormattingEnabled = true;
            this.LBrubros.Location = new System.Drawing.Point(625, 220);
            this.LBrubros.Name = "LBrubros";
            this.LBrubros.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LBrubros.Size = new System.Drawing.Size(155, 95);
            this.LBrubros.TabIndex = 11;
            this.LBrubros.ValueMember = "idrubro";
            // 
            // rubroBindingSource2
            // 
            this.rubroBindingSource2.DataMember = "rubro";
            this.rubroBindingSource2.DataSource = this.rubrosBusqueda;
            // 
            // rubrosBusqueda
            // 
            this.rubrosBusqueda.DataSetName = "rubrosBusqueda";
            this.rubrosBusqueda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // botonespaginas
            // 
            this.botonespaginas.Controls.Add(this.laeldee);
            this.botonespaginas.Controls.Add(this.labelactual);
            this.botonespaginas.Controls.Add(this.actual);
            this.botonespaginas.Controls.Add(this.Total);
            this.botonespaginas.Controls.Add(this.buttonultima);
            this.botonespaginas.Controls.Add(this.buttonsiguiente);
            this.botonespaginas.Controls.Add(this.buttonanterior);
            this.botonespaginas.Controls.Add(this.buttonprimera);
            this.botonespaginas.Enabled = false;
            this.botonespaginas.Location = new System.Drawing.Point(18, 321);
            this.botonespaginas.Name = "botonespaginas";
            this.botonespaginas.Size = new System.Drawing.Size(518, 33);
            this.botonespaginas.TabIndex = 10;
            this.botonespaginas.Visible = false;
            // 
            // laeldee
            // 
            this.laeldee.AutoSize = true;
            this.laeldee.Location = new System.Drawing.Point(458, 13);
            this.laeldee.Name = "laeldee";
            this.laeldee.Size = new System.Drawing.Size(19, 13);
            this.laeldee.TabIndex = 9;
            this.laeldee.Text = "de";
            // 
            // labelactual
            // 
            this.labelactual.AutoSize = true;
            this.labelactual.Location = new System.Drawing.Point(389, 10);
            this.labelactual.Name = "labelactual";
            this.labelactual.Size = new System.Drawing.Size(37, 13);
            this.labelactual.TabIndex = 8;
            this.labelactual.Text = "Actual";
            // 
            // actual
            // 
            this.actual.Enabled = false;
            this.actual.Location = new System.Drawing.Point(426, 8);
            this.actual.Name = "actual";
            this.actual.Size = new System.Drawing.Size(26, 20);
            this.actual.TabIndex = 7;
            // 
            // Total
            // 
            this.Total.Enabled = false;
            this.Total.Location = new System.Drawing.Point(483, 10);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(26, 20);
            this.Total.TabIndex = 6;
            // 
            // buttonultima
            // 
            this.buttonultima.Location = new System.Drawing.Point(299, 5);
            this.buttonultima.Name = "buttonultima";
            this.buttonultima.Size = new System.Drawing.Size(75, 23);
            this.buttonultima.TabIndex = 5;
            this.buttonultima.Text = "Ultima";
            this.buttonultima.UseVisualStyleBackColor = true;
            this.buttonultima.Click += new System.EventHandler(this.buttonultima_Click);
            // 
            // buttonsiguiente
            // 
            this.buttonsiguiente.Location = new System.Drawing.Point(200, 4);
            this.buttonsiguiente.Name = "buttonsiguiente";
            this.buttonsiguiente.Size = new System.Drawing.Size(75, 23);
            this.buttonsiguiente.TabIndex = 4;
            this.buttonsiguiente.Text = "Siguiente";
            this.buttonsiguiente.UseVisualStyleBackColor = true;
            this.buttonsiguiente.Click += new System.EventHandler(this.buttonsiguiente_Click);
            // 
            // buttonanterior
            // 
            this.buttonanterior.Location = new System.Drawing.Point(118, 5);
            this.buttonanterior.Name = "buttonanterior";
            this.buttonanterior.Size = new System.Drawing.Size(75, 23);
            this.buttonanterior.TabIndex = 3;
            this.buttonanterior.Text = "Anterior";
            this.buttonanterior.UseVisualStyleBackColor = true;
            this.buttonanterior.Click += new System.EventHandler(this.buttonanterior_Click);
            // 
            // buttonprimera
            // 
            this.buttonprimera.Location = new System.Drawing.Point(21, 5);
            this.buttonprimera.Name = "buttonprimera";
            this.buttonprimera.Size = new System.Drawing.Size(75, 23);
            this.buttonprimera.TabIndex = 2;
            this.buttonprimera.Text = "Primera";
            this.buttonprimera.UseVisualStyleBackColor = true;
            this.buttonprimera.Click += new System.EventHandler(this.buttonprimera_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(670, 329);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pr_buscar_productoTableAdapter
            // 
            this.pr_buscar_productoTableAdapter.ClearBeforeFill = true;
            // 
            // display
            // 
            this.display.Controls.Add(this.label3);
            this.display.Controls.Add(this.textBoxpreguntas);
            this.display.Controls.Add(this.preguntar);
            this.display.Controls.Add(this.Cantidad);
            this.display.Controls.Add(this.CBEnvio);
            this.display.Controls.Add(this.DGpreguntas);
            this.display.Controls.Add(this.Bcomprar);
            this.display.Controls.Add(this.TBdescripcion);
            this.display.Enabled = false;
            this.display.Location = new System.Drawing.Point(12, 404);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(648, 399);
            this.display.TabIndex = 7;
            this.display.Visible = false;
            this.display.Paint += new System.Windows.Forms.PaintEventHandler(this.display_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(6, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Preguntar:";
            this.label3.Visible = false;
            // 
            // textBoxpreguntas
            // 
            this.textBoxpreguntas.Enabled = false;
            this.textBoxpreguntas.Location = new System.Drawing.Point(73, 362);
            this.textBoxpreguntas.MaxLength = 255;
            this.textBoxpreguntas.Name = "textBoxpreguntas";
            this.textBoxpreguntas.Size = new System.Drawing.Size(463, 20);
            this.textBoxpreguntas.TabIndex = 9;
            this.textBoxpreguntas.Visible = false;
            // 
            // preguntar
            // 
            this.preguntar.Enabled = false;
            this.preguntar.Location = new System.Drawing.Point(550, 362);
            this.preguntar.Name = "preguntar";
            this.preguntar.Size = new System.Drawing.Size(75, 23);
            this.preguntar.TabIndex = 8;
            this.preguntar.Text = "Preguntar";
            this.preguntar.UseVisualStyleBackColor = true;
            this.preguntar.Visible = false;
            this.preguntar.Click += new System.EventHandler(this.preguntar_Click);
            // 
            // rubro
            // 
            this.rubro.DataSetName = "Rubro";
            this.rubro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubroBindingSource
            // 
            this.rubroBindingSource.DataSource = this.rubro;
            this.rubroBindingSource.Position = 0;
            // 
            // rubroBindingSource1
            // 
            this.rubroBindingSource1.DataMember = "rubro";
            this.rubroBindingSource1.DataSource = this.rubroBindingSource;
            // 
            // rubroTableAdapter
            // 
            this.rubroTableAdapter.ClearBeforeFill = true;
            // 
            // rubroTableAdapter1
            // 
            this.rubroTableAdapter1.ClearBeforeFill = true;
            // 
            // comprarofertar
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(810, 741);
            this.Controls.Add(this.display);
            this.Controls.Add(this.GBbuscar);
            this.Name = "comprarofertar";
            this.Text = "ComprarOfertar";
            this.Load += new System.EventHandler(this.comprarofertar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prbuscarproductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscar_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGpreguntas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prpreguntasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preguntas)).EndInit();
            this.GBbuscar.ResumeLayout(false);
            this.GBbuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubrosBusqueda)).EndInit();
            this.botonespaginas.ResumeLayout(false);
            this.botonespaginas.PerformLayout();
            this.display.ResumeLayout(false);
            this.display.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rubro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGBuscar;
        private System.Windows.Forms.BindingSource prbuscarproductoBindingSource;
        private buscar_producto buscar_producto;
        private buscar_productoTableAdapters.pr_buscar_productoTableAdapter pr_buscar_productoTableAdapter;
        private System.Windows.Forms.TextBox TBdescripcion;
        private System.Windows.Forms.Button Bcomprar;
        private System.Windows.Forms.CheckBox CBEnvio;
        private System.Windows.Forms.NumericUpDown Cantidad;
        private System.Windows.Forms.DataGridView DGpreguntas;
        private System.Windows.Forms.BindingSource prpreguntasBindingSource;
        private preguntas preguntas;
        private preguntasTableAdapters.pr_preguntasTableAdapter pr_preguntasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn preguntaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn respuestaDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox GBbuscar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Button buttonultima;
        private System.Windows.Forms.Button buttonsiguiente;
        private System.Windows.Forms.Button buttonanterior;
        private System.Windows.Forms.Button buttonprimera;
        private System.Windows.Forms.Label laeldee;
        private System.Windows.Forms.Label labelactual;
        private System.Windows.Forms.TextBox actual;
        private System.Windows.Forms.Panel display;
        private System.Windows.Forms.Panel botonespaginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn paginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGdescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_publicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_vencimiento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn permitir_envio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrubro;
        private System.Windows.Forms.DataGridViewCheckBoxColumn permitir_preguntas;
        private System.Windows.Forms.ListBox LBrubros;
        private System.Windows.Forms.BindingSource rubroBindingSource;
        private Rubro rubro;
        private System.Windows.Forms.BindingSource rubroBindingSource1;
        private RubroTableAdapters.rubroTableAdapter rubroTableAdapter;
        private rubrosBusqueda rubrosBusqueda;
        private System.Windows.Forms.BindingSource rubroBindingSource2;
        private rubrosBusquedaTableAdapters.rubroTableAdapter rubroTableAdapter1;
        private System.Windows.Forms.TextBox TBbuscardesc;
        private System.Windows.Forms.TextBox textBoxpreguntas;
        private System.Windows.Forms.Button preguntar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;

      
    }
}