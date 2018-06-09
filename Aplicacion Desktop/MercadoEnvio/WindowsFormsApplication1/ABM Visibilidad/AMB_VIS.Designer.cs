namespace WindowsFormsApplication1.ABM_Visibilidad
{
    partial class AMB_VIS
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idvisibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentaje_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_publicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_envio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visibilidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBM_VISDs = new WindowsFormsApplication1.ABM_VISDs();
            this.modificar = new System.Windows.Forms.Panel();
            this.borrar = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.TextBox();
            this.Envio = new System.Windows.Forms.NumericUpDown();
            this.precio = new System.Windows.Forms.NumericUpDown();
            this.porcentaje = new System.Windows.Forms.NumericUpDown();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.nuevo = new System.Windows.Forms.Button();
            this.idvisibilidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visibilidadTableAdapter = new WindowsFormsApplication1.ABM_VISDsTableAdapters.visibilidadTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visibilidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBM_VISDs)).BeginInit();
            this.modificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Envio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentaje)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvisibilidad,
            this.descripcionDV,
            this.porcentaje_venta,
            this.precio_publicacion,
            this.precio_envio,
            this.codigoDV});
            this.dataGridView1.DataSource = this.visibilidadBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(504, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.EnabledChanged += new System.EventHandler(this.dataGridView1_EnabledChanged);
            // 
            // idvisibilidad
            // 
            this.idvisibilidad.DataPropertyName = "idvisibilidad";
            this.idvisibilidad.HeaderText = "idvisibilidad";
            this.idvisibilidad.Name = "idvisibilidad";
            this.idvisibilidad.ReadOnly = true;
            this.idvisibilidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idvisibilidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idvisibilidad.Visible = false;
            // 
            // descripcionDV
            // 
            this.descripcionDV.DataPropertyName = "descripcion";
            this.descripcionDV.HeaderText = "Descripcion";
            this.descripcionDV.Name = "descripcionDV";
            this.descripcionDV.ReadOnly = true;
            this.descripcionDV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.descripcionDV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // porcentaje_venta
            // 
            this.porcentaje_venta.DataPropertyName = "porcentaje_venta";
            this.porcentaje_venta.HeaderText = "Porcentaje";
            this.porcentaje_venta.Name = "porcentaje_venta";
            this.porcentaje_venta.ReadOnly = true;
            this.porcentaje_venta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.porcentaje_venta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // precio_publicacion
            // 
            this.precio_publicacion.DataPropertyName = "precio_publicacion";
            this.precio_publicacion.HeaderText = "Precio";
            this.precio_publicacion.Name = "precio_publicacion";
            this.precio_publicacion.ReadOnly = true;
            this.precio_publicacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precio_publicacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // precio_envio
            // 
            this.precio_envio.DataPropertyName = "precio_envio";
            this.precio_envio.HeaderText = "Envio";
            this.precio_envio.Name = "precio_envio";
            this.precio_envio.ReadOnly = true;
            this.precio_envio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precio_envio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // codigoDV
            // 
            this.codigoDV.DataPropertyName = "codigo";
            this.codigoDV.HeaderText = "Codigo";
            this.codigoDV.Name = "codigoDV";
            this.codigoDV.ReadOnly = true;
            this.codigoDV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.codigoDV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // visibilidadBindingSource
            // 
            this.visibilidadBindingSource.DataMember = "visibilidad";
            this.visibilidadBindingSource.DataSource = this.aBM_VISDs;
            // 
            // aBM_VISDs
            // 
            this.aBM_VISDs.DataSetName = "ABM_VISDs";
            this.aBM_VISDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modificar
            // 
            this.modificar.Controls.Add(this.label9);
            this.modificar.Controls.Add(this.label8);
            this.modificar.Controls.Add(this.label7);
            this.modificar.Controls.Add(this.label6);
            this.modificar.Controls.Add(this.label5);
            this.modificar.Controls.Add(this.label4);
            this.modificar.Controls.Add(this.label3);
            this.modificar.Controls.Add(this.label2);
            this.modificar.Controls.Add(this.label1);
            this.modificar.Controls.Add(this.borrar);
            this.modificar.Controls.Add(this.actualizar);
            this.modificar.Controls.Add(this.codigo);
            this.modificar.Controls.Add(this.Envio);
            this.modificar.Controls.Add(this.precio);
            this.modificar.Controls.Add(this.porcentaje);
            this.modificar.Controls.Add(this.TBDescripcion);
            this.modificar.Enabled = false;
            this.modificar.Location = new System.Drawing.Point(6, 31);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(504, 100);
            this.modificar.TabIndex = 1;
            this.modificar.Visible = false;
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(314, 71);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(75, 23);
            this.borrar.TabIndex = 6;
            this.borrar.Text = "Borrar";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // actualizar
            // 
            this.actualizar.Location = new System.Drawing.Point(405, 71);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(75, 23);
            this.actualizar.TabIndex = 5;
            this.actualizar.Text = "Actualizar";
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(403, 1);
            this.codigo.MaxLength = 18;
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(100, 20);
            this.codigo.TabIndex = 4;
            // 
            // Envio
            // 
            this.Envio.DecimalPlaces = 2;
            this.Envio.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.Envio.Location = new System.Drawing.Point(318, 0);
            this.Envio.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Envio.Name = "Envio";
            this.Envio.Size = new System.Drawing.Size(71, 20);
            this.Envio.TabIndex = 3;
            this.Envio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // precio
            // 
            this.precio.DecimalPlaces = 2;
            this.precio.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.precio.Location = new System.Drawing.Point(216, 0);
            this.precio.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(71, 20);
            this.precio.TabIndex = 2;
            this.precio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // porcentaje
            // 
            this.porcentaje.DecimalPlaces = 2;
            this.porcentaje.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.porcentaje.Location = new System.Drawing.Point(124, 0);
            this.porcentaje.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.porcentaje.Name = "porcentaje";
            this.porcentaje.Size = new System.Drawing.Size(64, 20);
            this.porcentaje.TabIndex = 1;
            this.porcentaje.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Location = new System.Drawing.Point(0, 0);
            this.TBDescripcion.MaxLength = 255;
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(100, 20);
            this.TBDescripcion.TabIndex = 0;
            // 
            // nuevo
            // 
            this.nuevo.Location = new System.Drawing.Point(7, 6);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(170, 23);
            this.nuevo.TabIndex = 2;
            this.nuevo.Text = "Crear Nueva Visibilidad";
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // idvisibilidadDataGridViewTextBoxColumn
            // 
            this.idvisibilidadDataGridViewTextBoxColumn.DataPropertyName = "idvisibilidad";
            this.idvisibilidadDataGridViewTextBoxColumn.HeaderText = "idvisibilidad";
            this.idvisibilidadDataGridViewTextBoxColumn.Name = "idvisibilidadDataGridViewTextBoxColumn";
            this.idvisibilidadDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idvisibilidadDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idvisibilidadDataGridViewTextBoxColumn.Visible = false;
            // 
            // visibilidadTableAdapter
            // 
            this.visibilidadTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(4, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 192);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grilla de Visibilidades Existentes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.modificar);
            this.groupBox2.Location = new System.Drawing.Point(4, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 137);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cambiar Valores de Visibilidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "% de";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Comision";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Comision";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Codigo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "comision";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "x Publicacion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "x Producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "x Envio";
            // 
            // AMB_VIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 388);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "AMB_VIS";
            this.Text = "AMB Visibilidad";
            this.Load += new System.EventHandler(this.AMB_VIS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visibilidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBM_VISDs)).EndInit();
            this.modificar.ResumeLayout(false);
            this.modificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Envio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentaje)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ABM_VISDs aBM_VISDs;
        private System.Windows.Forms.BindingSource visibilidadBindingSource;
        private ABM_VISDsTableAdapters.visibilidadTableAdapter visibilidadTableAdapter;
        private System.Windows.Forms.Panel modificar;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.NumericUpDown Envio;
        private System.Windows.Forms.NumericUpDown precio;
        private System.Windows.Forms.NumericUpDown porcentaje;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvisibilidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvisibilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentaje_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_publicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_envio;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}