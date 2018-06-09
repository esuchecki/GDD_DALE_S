namespace WindowsFormsApplication1.Generar_Publicación
{
    partial class publicacion
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
            this.button1 = new System.Windows.Forms.Button();
            this.Cvisibilidad = new System.Windows.Forms.ComboBox();
            this.visibilidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visibikidad = new WindowsFormsApplication1.Visibikidad();
            this.visibilidadTableAdapter = new WindowsFormsApplication1.VisibikidadTableAdapters.visibilidadTableAdapter();
            this.labelVisibilidad = new System.Windows.Forms.Label();
            this.NUstock = new System.Windows.Forms.NumericUpDown();
            this.Stock = new System.Windows.Forms.Label();
            this.Tdescripcon = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.Label();
            this.incio = new System.Windows.Forms.DateTimePicker();
            this.fin = new System.Windows.Forms.DateTimePicker();
            this.Linicio = new System.Windows.Forms.Label();
            this.Lfin = new System.Windows.Forms.Label();
            this.preguntas = new System.Windows.Forms.CheckBox();
            this.NUprecio = new System.Windows.Forms.NumericUpDown();
            this.precio = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.Label();
            this.Crubro = new System.Windows.Forms.ComboBox();
            this.rubroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2016DataSet1 = new WindowsFormsApplication1.GD1C2016DataSet1();
            this.rubro = new System.Windows.Forms.Label();
            this.rubroTableAdapter = new WindowsFormsApplication1.GD1C2016DataSet1TableAdapters.rubroTableAdapter();
            this.Cestado = new System.Windows.Forms.ComboBox();
            this.estadopublicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estado = new WindowsFormsApplication1.Estado();
            this.estado_publicacionTableAdapter = new WindowsFormsApplication1.EstadoTableAdapters.estado_publicacionTableAdapter();
            this.Lestado = new System.Windows.Forms.Label();
            this.RBCompraInmediata = new System.Windows.Forms.RadioButton();
            this.RBSubasta = new System.Windows.Forms.RadioButton();
            this.CBenvio = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.visibilidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visibikidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUprecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadopublicacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estado)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Publicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cvisibilidad
            // 
            this.Cvisibilidad.DataSource = this.visibilidadBindingSource;
            this.Cvisibilidad.DisplayMember = "descripcion";
            this.Cvisibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cvisibilidad.FormattingEnabled = true;
            this.Cvisibilidad.Location = new System.Drawing.Point(81, 95);
            this.Cvisibilidad.Name = "Cvisibilidad";
            this.Cvisibilidad.Size = new System.Drawing.Size(121, 21);
            this.Cvisibilidad.TabIndex = 1;
            this.Cvisibilidad.ValueMember = "idvisibilidad";
            // 
            // visibilidadBindingSource
            // 
            this.visibilidadBindingSource.DataMember = "visibilidad";
            this.visibilidadBindingSource.DataSource = this.visibikidad;
            // 
            // visibikidad
            // 
            this.visibikidad.DataSetName = "Visibikidad";
            this.visibikidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visibilidadTableAdapter
            // 
            this.visibilidadTableAdapter.ClearBeforeFill = true;
            // 
            // labelVisibilidad
            // 
            this.labelVisibilidad.AutoSize = true;
            this.labelVisibilidad.Location = new System.Drawing.Point(22, 98);
            this.labelVisibilidad.Name = "labelVisibilidad";
            this.labelVisibilidad.Size = new System.Drawing.Size(56, 13);
            this.labelVisibilidad.TabIndex = 2;
            this.labelVisibilidad.Text = "Visibilidad:";
            // 
            // NUstock
            // 
            this.NUstock.Location = new System.Drawing.Point(152, 123);
            this.NUstock.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.NUstock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUstock.Name = "NUstock";
            this.NUstock.Size = new System.Drawing.Size(49, 20);
            this.NUstock.TabIndex = 3;
            this.NUstock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Location = new System.Drawing.Point(40, 125);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(38, 13);
            this.Stock.TabIndex = 4;
            this.Stock.Text = "Stock:";
            // 
            // Tdescripcon
            // 
            this.Tdescripcon.Location = new System.Drawing.Point(84, 180);
            this.Tdescripcon.MaxLength = 255;
            this.Tdescripcon.Multiline = true;
            this.Tdescripcon.Name = "Tdescripcon";
            this.Tdescripcon.Size = new System.Drawing.Size(305, 87);
            this.Tdescripcon.TabIndex = 5;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(6, 183);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(72, 13);
            this.Descripcion.TabIndex = 6;
            this.Descripcion.Text = "Descricpcion:";
            // 
            // incio
            // 
            this.incio.Location = new System.Drawing.Point(81, 273);
            this.incio.Name = "incio";
            this.incio.Size = new System.Drawing.Size(200, 20);
            this.incio.TabIndex = 8;
            // 
            // fin
            // 
            this.fin.Location = new System.Drawing.Point(81, 299);
            this.fin.Name = "fin";
            this.fin.Size = new System.Drawing.Size(200, 20);
            this.fin.TabIndex = 9;
            // 
            // Linicio
            // 
            this.Linicio.AutoSize = true;
            this.Linicio.Location = new System.Drawing.Point(40, 273);
            this.Linicio.Name = "Linicio";
            this.Linicio.Size = new System.Drawing.Size(35, 13);
            this.Linicio.TabIndex = 10;
            this.Linicio.Text = "Inicio:";
            // 
            // Lfin
            // 
            this.Lfin.AutoSize = true;
            this.Lfin.Location = new System.Drawing.Point(40, 305);
            this.Lfin.Name = "Lfin";
            this.Lfin.Size = new System.Drawing.Size(24, 13);
            this.Lfin.TabIndex = 11;
            this.Lfin.Text = "Fin:";
            // 
            // preguntas
            // 
            this.preguntas.AutoSize = true;
            this.preguntas.Location = new System.Drawing.Point(84, 157);
            this.preguntas.Name = "preguntas";
            this.preguntas.Size = new System.Drawing.Size(73, 17);
            this.preguntas.TabIndex = 12;
            this.preguntas.Text = "preguntas";
            this.preguntas.UseVisualStyleBackColor = true;
            // 
            // NUprecio
            // 
            this.NUprecio.DecimalPlaces = 2;
            this.NUprecio.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.NUprecio.Location = new System.Drawing.Point(270, 125);
            this.NUprecio.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.NUprecio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUprecio.Name = "NUprecio";
            this.NUprecio.Size = new System.Drawing.Size(67, 20);
            this.NUprecio.TabIndex = 13;
            this.NUprecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Location = new System.Drawing.Point(226, 130);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(40, 13);
            this.precio.TabIndex = 14;
            this.precio.Text = "Precio:";
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.Location = new System.Drawing.Point(22, 68);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(31, 13);
            this.tipo.TabIndex = 16;
            this.tipo.Text = "Tipo:";
            // 
            // Crubro
            // 
            this.Crubro.DataSource = this.rubroBindingSource;
            this.Crubro.DisplayMember = "descripcion_corta";
            this.Crubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Crubro.Location = new System.Drawing.Point(81, 41);
            this.Crubro.Name = "Crubro";
            this.Crubro.Size = new System.Drawing.Size(174, 21);
            this.Crubro.TabIndex = 17;
            this.Crubro.ValueMember = "idrubro";
            // 
            // rubroBindingSource
            // 
            this.rubroBindingSource.DataMember = "rubro";
            this.rubroBindingSource.DataSource = this.gD1C2016DataSet1;
            // 
            // gD1C2016DataSet1
            // 
            this.gD1C2016DataSet1.DataSetName = "GD1C2016DataSet1";
            this.gD1C2016DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubro
            // 
            this.rubro.AutoSize = true;
            this.rubro.Location = new System.Drawing.Point(22, 41);
            this.rubro.Name = "rubro";
            this.rubro.Size = new System.Drawing.Size(39, 13);
            this.rubro.TabIndex = 18;
            this.rubro.Text = "Rubro:";
            // 
            // rubroTableAdapter
            // 
            this.rubroTableAdapter.ClearBeforeFill = true;
            // 
            // Cestado
            // 
            this.Cestado.DataSource = this.estadopublicacionBindingSource;
            this.Cestado.DisplayMember = "descripcion";
            this.Cestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cestado.FormattingEnabled = true;
            this.Cestado.Location = new System.Drawing.Point(80, 12);
            this.Cestado.Name = "Cestado";
            this.Cestado.Size = new System.Drawing.Size(121, 21);
            this.Cestado.TabIndex = 19;
            this.Cestado.ValueMember = "idestado_publicacion";
            // 
            // estadopublicacionBindingSource
            // 
            this.estadopublicacionBindingSource.DataMember = "estado_publicacion";
            this.estadopublicacionBindingSource.DataSource = this.estado;
            // 
            // estado
            // 
            this.estado.DataSetName = "Estado";
            this.estado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estado_publicacionTableAdapter
            // 
            this.estado_publicacionTableAdapter.ClearBeforeFill = true;
            // 
            // Lestado
            // 
            this.Lestado.AutoSize = true;
            this.Lestado.Location = new System.Drawing.Point(31, 12);
            this.Lestado.Name = "Lestado";
            this.Lestado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lestado.Size = new System.Drawing.Size(40, 13);
            this.Lestado.TabIndex = 20;
            this.Lestado.Text = "Estado";
            // 
            // RBCompraInmediata
            // 
            this.RBCompraInmediata.AutoSize = true;
            this.RBCompraInmediata.Checked = true;
            this.RBCompraInmediata.Location = new System.Drawing.Point(81, 69);
            this.RBCompraInmediata.Name = "RBCompraInmediata";
            this.RBCompraInmediata.Size = new System.Drawing.Size(110, 17);
            this.RBCompraInmediata.TabIndex = 21;
            this.RBCompraInmediata.TabStop = true;
            this.RBCompraInmediata.Text = "Compra Inmediata";
            this.RBCompraInmediata.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RBCompraInmediata.UseVisualStyleBackColor = true;
            this.RBCompraInmediata.CheckedChanged += new System.EventHandler(this.RBCompraInmediata_CheckedChanged);
            // 
            // RBSubasta
            // 
            this.RBSubasta.AutoSize = true;
            this.RBSubasta.Location = new System.Drawing.Point(191, 69);
            this.RBSubasta.Name = "RBSubasta";
            this.RBSubasta.Size = new System.Drawing.Size(64, 17);
            this.RBSubasta.TabIndex = 22;
            this.RBSubasta.Text = "Subasta";
            this.RBSubasta.UseVisualStyleBackColor = true;
            this.RBSubasta.Click += new System.EventHandler(this.RBSubasta_CheckedChanged);
            // 
            // CBenvio
            // 
            this.CBenvio.AutoSize = true;
            this.CBenvio.Location = new System.Drawing.Point(172, 157);
            this.CBenvio.Name = "CBenvio";
            this.CBenvio.Size = new System.Drawing.Size(52, 17);
            this.CBenvio.TabIndex = 23;
            this.CBenvio.Text = "envio";
            this.CBenvio.UseVisualStyleBackColor = true;
            // 
            // publicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 365);
            this.Controls.Add(this.CBenvio);
            this.Controls.Add(this.RBSubasta);
            this.Controls.Add(this.RBCompraInmediata);
            this.Controls.Add(this.Lestado);
            this.Controls.Add(this.Cestado);
            this.Controls.Add(this.rubro);
            this.Controls.Add(this.Crubro);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.NUprecio);
            this.Controls.Add(this.preguntas);
            this.Controls.Add(this.Lfin);
            this.Controls.Add(this.Linicio);
            this.Controls.Add(this.fin);
            this.Controls.Add(this.incio);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.Tdescripcon);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.NUstock);
            this.Controls.Add(this.labelVisibilidad);
            this.Controls.Add(this.Cvisibilidad);
            this.Controls.Add(this.button1);
            this.Name = "publicacion";
            this.Text = "Publicacion:";
            this.Load += new System.EventHandler(this.publicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visibilidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visibikidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUprecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadopublicacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Cvisibilidad;
        private Visibikidad visibikidad;
        private System.Windows.Forms.BindingSource visibilidadBindingSource;
        private VisibikidadTableAdapters.visibilidadTableAdapter visibilidadTableAdapter;
        private System.Windows.Forms.Label labelVisibilidad;
        private System.Windows.Forms.NumericUpDown NUstock;
        private System.Windows.Forms.Label Stock;
        private System.Windows.Forms.TextBox Tdescripcon;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.DateTimePicker incio;
        private System.Windows.Forms.DateTimePicker fin;
        private System.Windows.Forms.Label Linicio;
        private System.Windows.Forms.Label Lfin;
        private System.Windows.Forms.CheckBox preguntas;
        private System.Windows.Forms.NumericUpDown NUprecio;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.ComboBox Crubro;
        private System.Windows.Forms.Label rubro;
        private GD1C2016DataSet1 gD1C2016DataSet1;
        private System.Windows.Forms.BindingSource rubroBindingSource;
        private GD1C2016DataSet1TableAdapters.rubroTableAdapter rubroTableAdapter;
        private System.Windows.Forms.ComboBox Cestado;
        private Estado estado;
        private System.Windows.Forms.BindingSource estadopublicacionBindingSource;
        private EstadoTableAdapters.estado_publicacionTableAdapter estado_publicacionTableAdapter;
        private System.Windows.Forms.Label Lestado;
        private System.Windows.Forms.RadioButton RBCompraInmediata;
        private System.Windows.Forms.RadioButton RBSubasta;
        private System.Windows.Forms.CheckBox CBenvio;
    }
}