namespace WindowsFormsApplication1.Listado_Estadistico
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usuarioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.estadoIntentos = new WindowsFormsApplication1.EstadoIntentos();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rubro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.publicacionBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2016DataSet2 = new WindowsFormsApplication1.GD1C2016DataSet2();
            this.publicacionBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.publicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2016DataSet = new WindowsFormsApplication1.GD1C2016DataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new WindowsFormsApplication1.GD1C2016DataSetTableAdapters.usuarioTableAdapter();
            this.usuarioTableAdapter1 = new WindowsFormsApplication1.EstadoIntentosTableAdapters.usuarioTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CBvis = new System.Windows.Forms.ComboBox();
            this.rubroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubro1 = new WindowsFormsApplication1.Rubro();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.estado = new WindowsFormsApplication1.Estado();
            this.estadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publicacionTableAdapter = new WindowsFormsApplication1.GD1C2016DataSet2TableAdapters.publicacionTableAdapter();
            this.estadopublicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estado_publicacionTableAdapter = new WindowsFormsApplication1.EstadoTableAdapters.estado_publicacionTableAdapter();
            this.rubro1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubroTableAdapter = new WindowsFormsApplication1.RubroTableAdapters.rubroTableAdapter();
            this.publicacionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.publicacionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.publicacionBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.filtrovisibilidad = new WindowsFormsApplication1.filtrovisibilidad();
            this.visibilidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visibilidadTableAdapter = new WindowsFormsApplication1.filtrovisibilidadTableAdapters.visibilidadTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoIntentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadopublicacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubro1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtrovisibilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visibilidadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleName = "";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(462, 350);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // usuarioBindingSource2
            // 
            this.usuarioBindingSource2.DataMember = "usuario";
            this.usuarioBindingSource2.DataSource = this.estadoIntentos;
            // 
            // estadoIntentos
            // 
            this.estadoIntentos.DataSetName = "EstadoIntentos";
            this.estadoIntentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Primero";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(72, 6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Segundo";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(146, 6);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Tercero";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rubro
            // 
            this.rubro.AutoSize = true;
            this.rubro.Location = new System.Drawing.Point(23, 21);
            this.rubro.Name = "rubro";
            this.rubro.Size = new System.Drawing.Size(29, 13);
            this.rubro.TabIndex = 19;
            this.rubro.Text = "Año:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Trimestre:";
            // 
            // publicacionBindingSource3
            // 
            this.publicacionBindingSource3.DataMember = "publicacion";
            this.publicacionBindingSource3.DataSource = this.gD1C2016DataSet2;
            // 
            // gD1C2016DataSet2
            // 
            this.gD1C2016DataSet2.DataSetName = "GD1C2016DataSet2";
            this.gD1C2016DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // publicacionBindingSource5
            // 
            this.publicacionBindingSource5.DataMember = "publicacion";
            this.publicacionBindingSource5.DataSource = this.gD1C2016DataSet2;
            // 
            // publicacionBindingSource
            // 
            this.publicacionBindingSource.DataMember = "publicacion";
            this.publicacionBindingSource.DataSource = this.gD1C2016DataSet2;
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "usuario";
            this.usuarioBindingSource1.DataSource = this.gD1C2016DataSet;
            // 
            // gD1C2016DataSet
            // 
            this.gD1C2016DataSet.DataSetName = "GD1C2016DataSet";
            this.gD1C2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.gD1C2016DataSet;
            this.usuarioBindingSource.CurrentChanged += new System.EventHandler(this.usuarioBindingSource_CurrentChanged);
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tipo de listado:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 80);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(166, 17);
            this.radioButton4.TabIndex = 25;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Vendedores con mas facturas";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 53);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(210, 17);
            this.radioButton5.TabIndex = 24;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Clientes con mas productos comprados";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(236, 17);
            this.radioButton6.TabIndex = 23;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Vendedores con mas productos no vendidos";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(6, 104);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(214, 17);
            this.radioButton7.TabIndex = 26;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Vendedores con mayor monto facturado";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton8);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(108, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 26);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(214, 6);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(56, 17);
            this.radioButton8.TabIndex = 8;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Cuarto";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CBvis);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Location = new System.Drawing.Point(108, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 136);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // CBvis
            // 
            this.CBvis.DataSource = this.visibilidadBindingSource;
            this.CBvis.DisplayMember = "descripcion";
            this.CBvis.FormattingEnabled = true;
            this.CBvis.Location = new System.Drawing.Point(246, 21);
            this.CBvis.Name = "CBvis";
            this.CBvis.Size = new System.Drawing.Size(121, 21);
            this.CBvis.TabIndex = 30;
            this.CBvis.ValueMember = "idvisibilidad";
            this.CBvis.SelectedIndexChanged += new System.EventHandler(this.CBvis_SelectedIndexChanged);
            // 
            // rubroBindingSource
            // 
            this.rubroBindingSource.DataMember = "rubro";
            this.rubroBindingSource.DataSource = this.rubro1;
            // 
            // rubro1
            // 
            this.rubro1.DataSetName = "Rubro";
            this.rubro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(246, 103);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 29;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(245, 76);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 28;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.rubroBindingSource;
            this.comboBox1.DisplayMember = "descripcion_corta";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(246, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.ValueMember = "descripcion_corta";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // estado
            // 
            this.estado.DataSetName = "Estado";
            this.estado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadoBindingSource
            // 
            this.estadoBindingSource.DataSource = this.estado;
            this.estadoBindingSource.Position = 0;
            // 
            // publicacionTableAdapter
            // 
            this.publicacionTableAdapter.ClearBeforeFill = true;
            // 
            // estadopublicacionBindingSource
            // 
            this.estadopublicacionBindingSource.DataMember = "estado_publicacion";
            this.estadopublicacionBindingSource.DataSource = this.estadoBindingSource;
            // 
            // estado_publicacionTableAdapter
            // 
            this.estado_publicacionTableAdapter.ClearBeforeFill = true;
            // 
            // rubro1BindingSource
            // 
            this.rubro1BindingSource.DataSource = this.rubro1;
            this.rubro1BindingSource.Position = 0;
            // 
            // rubroTableAdapter
            // 
            this.rubroTableAdapter.ClearBeforeFill = true;
            // 
            // publicacionBindingSource1
            // 
            this.publicacionBindingSource1.DataMember = "publicacion";
            this.publicacionBindingSource1.DataSource = this.gD1C2016DataSet2;
            // 
            // publicacionBindingSource2
            // 
            this.publicacionBindingSource2.DataMember = "publicacion";
            this.publicacionBindingSource2.DataSource = this.gD1C2016DataSet2;
            // 
            // publicacionBindingSource4
            // 
            this.publicacionBindingSource4.DataMember = "publicacion";
            this.publicacionBindingSource4.DataSource = this.gD1C2016DataSet2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 31;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // filtrovisibilidad
            // 
            this.filtrovisibilidad.DataSetName = "filtrovisibilidad";
            this.filtrovisibilidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visibilidadBindingSource
            // 
            this.visibilidadBindingSource.DataMember = "visibilidad";
            this.visibilidadBindingSource.DataSource = this.filtrovisibilidad;
            // 
            // visibilidadTableAdapter
            // 
            this.visibilidadTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 669);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rubro);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Estadistico";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoIntentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2016DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rubroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadopublicacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubro1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtrovisibilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visibilidadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GD1C2016DataSet gD1C2016DataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private GD1C2016DataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
        private EstadoIntentos estadoIntentos;
        private System.Windows.Forms.BindingSource usuarioBindingSource2;
        private EstadoIntentosTableAdapters.usuarioTableAdapter usuarioTableAdapter1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label rubro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Estado estado;
        private System.Windows.Forms.BindingSource estadoBindingSource;
        private System.Windows.Forms.RadioButton radioButton8;
        private GD1C2016DataSet2 gD1C2016DataSet2;
        private System.Windows.Forms.BindingSource publicacionBindingSource;
        private GD1C2016DataSet2TableAdapters.publicacionTableAdapter publicacionTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource estadopublicacionBindingSource;
        private EstadoTableAdapters.estado_publicacionTableAdapter estado_publicacionTableAdapter;
        private System.Windows.Forms.BindingSource rubro1BindingSource;
        private Rubro rubro1;
        private System.Windows.Forms.BindingSource rubroBindingSource;
        private RubroTableAdapters.rubroTableAdapter rubroTableAdapter;
        private System.Windows.Forms.BindingSource publicacionBindingSource3;
        private System.Windows.Forms.BindingSource publicacionBindingSource2;
        private System.Windows.Forms.BindingSource publicacionBindingSource1;
        private System.Windows.Forms.BindingSource publicacionBindingSource5;
        private System.Windows.Forms.BindingSource publicacionBindingSource4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox CBvis;
        private filtrovisibilidad filtrovisibilidad;
        private System.Windows.Forms.BindingSource visibilidadBindingSource;
        private filtrovisibilidadTableAdapters.visibilidadTableAdapter visibilidadTableAdapter;
    }
}