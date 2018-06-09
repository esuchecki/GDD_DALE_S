namespace WindowsFormsApplication1.Historial_Cliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtCantidadSubastas = new System.Windows.Forms.TextBox();
            this.txtCantComprasDirectas = new System.Windows.Forms.TextBox();
            this.txtTotalEstrellas = new System.Windows.Forms.TextBox();
            this.txtOperacionesNoCalificadas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtSubasta = new System.Windows.Forms.RadioButton();
            this.rbtCompraDirecta = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtVerSinCalificar = new System.Windows.Forms.RadioButton();
            this.rbtVer5Calificadas = new System.Windows.Forms.RadioButton();
            this.rbtVerTodas = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt5estrellas = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt4estrellas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt3estrellas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt2estrellas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt1estrella = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.btCalificar = new System.Windows.Forms.Button();
            this.btVerCalificacion = new System.Windows.Forms.Button();
            this.botonespaginas = new System.Windows.Forms.Panel();
            this.labelactual = new System.Windows.Forms.Label();
            this.actual = new System.Windows.Forms.TextBox();
            this.buttonsiguiente = new System.Windows.Forms.Button();
            this.buttonanterior = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.botonespaginas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdUsuario);
            this.groupBox1.Controls.Add(this.txtCantidadSubastas);
            this.groupBox1.Controls.Add(this.txtCantComprasDirectas);
            this.groupBox1.Controls.Add(this.txtTotalEstrellas);
            this.groupBox1.Controls.Add(this.txtOperacionesNoCalificadas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadisticas";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(314, -11);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtIdUsuario.TabIndex = 2;
            this.txtIdUsuario.Visible = false;
            // 
            // txtCantidadSubastas
            // 
            this.txtCantidadSubastas.BackColor = System.Drawing.Color.White;
            this.txtCantidadSubastas.Location = new System.Drawing.Point(519, 37);
            this.txtCantidadSubastas.Name = "txtCantidadSubastas";
            this.txtCantidadSubastas.ReadOnly = true;
            this.txtCantidadSubastas.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadSubastas.TabIndex = 6;
            this.txtCantidadSubastas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCantComprasDirectas
            // 
            this.txtCantComprasDirectas.BackColor = System.Drawing.Color.White;
            this.txtCantComprasDirectas.Location = new System.Drawing.Point(519, 15);
            this.txtCantComprasDirectas.Name = "txtCantComprasDirectas";
            this.txtCantComprasDirectas.ReadOnly = true;
            this.txtCantComprasDirectas.Size = new System.Drawing.Size(100, 20);
            this.txtCantComprasDirectas.TabIndex = 5;
            this.txtCantComprasDirectas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalEstrellas
            // 
            this.txtTotalEstrellas.BackColor = System.Drawing.Color.White;
            this.txtTotalEstrellas.Location = new System.Drawing.Point(248, 37);
            this.txtTotalEstrellas.Name = "txtTotalEstrellas";
            this.txtTotalEstrellas.ReadOnly = true;
            this.txtTotalEstrellas.Size = new System.Drawing.Size(100, 20);
            this.txtTotalEstrellas.TabIndex = 5;
            this.txtTotalEstrellas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOperacionesNoCalificadas
            // 
            this.txtOperacionesNoCalificadas.BackColor = System.Drawing.Color.White;
            this.txtOperacionesNoCalificadas.Location = new System.Drawing.Point(248, 15);
            this.txtOperacionesNoCalificadas.Name = "txtOperacionesNoCalificadas";
            this.txtOperacionesNoCalificadas.ReadOnly = true;
            this.txtOperacionesNoCalificadas.Size = new System.Drawing.Size(100, 20);
            this.txtOperacionesNoCalificadas.TabIndex = 4;
            this.txtOperacionesNoCalificadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cant. de Subastas Ganadas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de Compras Directas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estrellas totales asignadas en Mis Operaciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operaciones No calificadas:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtSubasta);
            this.groupBox2.Controls.Add(this.rbtCompraDirecta);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(625, 42);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione el tipo de Compra";
            // 
            // rbtSubasta
            // 
            this.rbtSubasta.AutoSize = true;
            this.rbtSubasta.Location = new System.Drawing.Point(330, 19);
            this.rbtSubasta.Name = "rbtSubasta";
            this.rbtSubasta.Size = new System.Drawing.Size(69, 17);
            this.rbtSubasta.TabIndex = 1;
            this.rbtSubasta.TabStop = true;
            this.rbtSubasta.Text = "Subastas";
            this.rbtSubasta.UseVisualStyleBackColor = true;
            this.rbtSubasta.CheckedChanged += new System.EventHandler(this.rbtSubasta_CheckedChanged);
            // 
            // rbtCompraDirecta
            // 
            this.rbtCompraDirecta.AutoSize = true;
            this.rbtCompraDirecta.Location = new System.Drawing.Point(178, 19);
            this.rbtCompraDirecta.Name = "rbtCompraDirecta";
            this.rbtCompraDirecta.Size = new System.Drawing.Size(108, 17);
            this.rbtCompraDirecta.TabIndex = 0;
            this.rbtCompraDirecta.Text = "Compras Directas";
            this.rbtCompraDirecta.UseVisualStyleBackColor = true;
            this.rbtCompraDirecta.CheckedChanged += new System.EventHandler(this.rbtCompraDirecta_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtVerSinCalificar);
            this.groupBox3.Controls.Add(this.rbtVer5Calificadas);
            this.groupBox3.Controls.Add(this.rbtVerTodas);
            this.groupBox3.Location = new System.Drawing.Point(12, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(625, 42);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Otras opciones para las estadisticas";
            // 
            // rbtVerSinCalificar
            // 
            this.rbtVerSinCalificar.AutoSize = true;
            this.rbtVerSinCalificar.Location = new System.Drawing.Point(373, 20);
            this.rbtVerSinCalificar.Name = "rbtVerSinCalificar";
            this.rbtVerSinCalificar.Size = new System.Drawing.Size(96, 17);
            this.rbtVerSinCalificar.TabIndex = 2;
            this.rbtVerSinCalificar.TabStop = true;
            this.rbtVerSinCalificar.Text = "Ver sin calificar";
            this.rbtVerSinCalificar.UseVisualStyleBackColor = true;
            this.rbtVerSinCalificar.CheckedChanged += new System.EventHandler(this.rbtVerSinCalificar_CheckedChanged);
            // 
            // rbtVer5Calificadas
            // 
            this.rbtVer5Calificadas.AutoSize = true;
            this.rbtVer5Calificadas.Location = new System.Drawing.Point(175, 20);
            this.rbtVer5Calificadas.Name = "rbtVer5Calificadas";
            this.rbtVer5Calificadas.Size = new System.Drawing.Size(138, 17);
            this.rbtVer5Calificadas.TabIndex = 1;
            this.rbtVer5Calificadas.TabStop = true;
            this.rbtVer5Calificadas.Text = "Ver ultimas 5 calificadas";
            this.rbtVer5Calificadas.UseVisualStyleBackColor = true;
            this.rbtVer5Calificadas.CheckedChanged += new System.EventHandler(this.rbtVer5Calificadas_CheckedChanged);
            // 
            // rbtVerTodas
            // 
            this.rbtVerTodas.AutoSize = true;
            this.rbtVerTodas.Location = new System.Drawing.Point(53, 19);
            this.rbtVerTodas.Name = "rbtVerTodas";
            this.rbtVerTodas.Size = new System.Drawing.Size(74, 17);
            this.rbtVerTodas.TabIndex = 0;
            this.rbtVerTodas.Text = "Ver Todas";
            this.rbtVerTodas.UseVisualStyleBackColor = true;
            this.rbtVerTodas.CheckedChanged += new System.EventHandler(this.rbtVerTodas_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btRefresh);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txt5estrellas);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txt4estrellas);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txt3estrellas);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txt2estrellas);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txt1estrella);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(625, 94);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cantidad de Estrellas asignadas en mis operaciones";
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(519, 66);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(97, 23);
            this.btRefresh.TabIndex = 7;
            this.btRefresh.Text = "Refrescar";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Visible = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(332, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "operaciones";
            // 
            // txt5estrellas
            // 
            this.txt5estrellas.BackColor = System.Drawing.Color.White;
            this.txt5estrellas.Location = new System.Drawing.Point(248, 68);
            this.txt5estrellas.Name = "txt5estrellas";
            this.txt5estrellas.ReadOnly = true;
            this.txt5estrellas.Size = new System.Drawing.Size(78, 20);
            this.txt5estrellas.TabIndex = 14;
            this.txt5estrellas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(162, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "5 estrellas:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(492, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "operaciones";
            // 
            // txt4estrellas
            // 
            this.txt4estrellas.BackColor = System.Drawing.Color.White;
            this.txt4estrellas.Location = new System.Drawing.Point(408, 41);
            this.txt4estrellas.Name = "txt4estrellas";
            this.txt4estrellas.ReadOnly = true;
            this.txt4estrellas.Size = new System.Drawing.Size(78, 20);
            this.txt4estrellas.TabIndex = 11;
            this.txt4estrellas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(322, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "4 estrellas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(492, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "operaciones";
            // 
            // txt3estrellas
            // 
            this.txt3estrellas.BackColor = System.Drawing.Color.White;
            this.txt3estrellas.Location = new System.Drawing.Point(408, 20);
            this.txt3estrellas.Name = "txt3estrellas";
            this.txt3estrellas.ReadOnly = true;
            this.txt3estrellas.Size = new System.Drawing.Size(78, 20);
            this.txt3estrellas.TabIndex = 8;
            this.txt3estrellas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(322, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "3 estrellas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "operaciones";
            // 
            // txt2estrellas
            // 
            this.txt2estrellas.BackColor = System.Drawing.Color.White;
            this.txt2estrellas.Location = new System.Drawing.Point(93, 41);
            this.txt2estrellas.Name = "txt2estrellas";
            this.txt2estrellas.ReadOnly = true;
            this.txt2estrellas.Size = new System.Drawing.Size(78, 20);
            this.txt2estrellas.TabIndex = 5;
            this.txt2estrellas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "2 estrellas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "operaciones";
            // 
            // txt1estrella
            // 
            this.txt1estrella.BackColor = System.Drawing.Color.White;
            this.txt1estrella.Location = new System.Drawing.Point(93, 17);
            this.txt1estrella.Name = "txt1estrella";
            this.txt1estrella.ReadOnly = true;
            this.txt1estrella.Size = new System.Drawing.Size(78, 20);
            this.txt1estrella.TabIndex = 2;
            this.txt1estrella.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "1 estrella:";
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(13, 278);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(515, 184);
            this.dgvHistorial.TabIndex = 4;
            this.dgvHistorial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorial_CellClick);
            // 
            // btCalificar
            // 
            this.btCalificar.Location = new System.Drawing.Point(540, 306);
            this.btCalificar.Name = "btCalificar";
            this.btCalificar.Size = new System.Drawing.Size(97, 23);
            this.btCalificar.TabIndex = 5;
            this.btCalificar.Text = "Calificar";
            this.btCalificar.UseVisualStyleBackColor = true;
            this.btCalificar.Click += new System.EventHandler(this.btCalificar_Click);
            // 
            // btVerCalificacion
            // 
            this.btVerCalificacion.Location = new System.Drawing.Point(540, 332);
            this.btVerCalificacion.Name = "btVerCalificacion";
            this.btVerCalificacion.Size = new System.Drawing.Size(97, 26);
            this.btVerCalificacion.TabIndex = 6;
            this.btVerCalificacion.Text = "Ver Calificacion";
            this.btVerCalificacion.UseVisualStyleBackColor = true;
            this.btVerCalificacion.Click += new System.EventHandler(this.btVerCalificacion_Click);
            // 
            // botonespaginas
            // 
            this.botonespaginas.Controls.Add(this.labelactual);
            this.botonespaginas.Controls.Add(this.actual);
            this.botonespaginas.Controls.Add(this.buttonsiguiente);
            this.botonespaginas.Controls.Add(this.buttonanterior);
            this.botonespaginas.Enabled = false;
            this.botonespaginas.Location = new System.Drawing.Point(552, 364);
            this.botonespaginas.Name = "botonespaginas";
            this.botonespaginas.Size = new System.Drawing.Size(85, 98);
            this.botonespaginas.TabIndex = 12;
            this.botonespaginas.Visible = false;
            // 
            // labelactual
            // 
            this.labelactual.AutoSize = true;
            this.labelactual.Location = new System.Drawing.Point(3, 71);
            this.labelactual.Name = "labelactual";
            this.labelactual.Size = new System.Drawing.Size(37, 13);
            this.labelactual.TabIndex = 8;
            this.labelactual.Text = "Actual";
            // 
            // actual
            // 
            this.actual.Enabled = false;
            this.actual.Location = new System.Drawing.Point(48, 68);
            this.actual.Name = "actual";
            this.actual.Size = new System.Drawing.Size(26, 20);
            this.actual.TabIndex = 7;
            // 
            // buttonsiguiente
            // 
            this.buttonsiguiente.Enabled = false;
            this.buttonsiguiente.Location = new System.Drawing.Point(3, 35);
            this.buttonsiguiente.Name = "buttonsiguiente";
            this.buttonsiguiente.Size = new System.Drawing.Size(75, 23);
            this.buttonsiguiente.TabIndex = 4;
            this.buttonsiguiente.Text = "Siguiente";
            this.buttonsiguiente.UseVisualStyleBackColor = true;
            this.buttonsiguiente.Click += new System.EventHandler(this.buttonsiguiente_Click);
            // 
            // buttonanterior
            // 
            this.buttonanterior.Enabled = false;
            this.buttonanterior.Location = new System.Drawing.Point(3, 6);
            this.buttonanterior.Name = "buttonanterior";
            this.buttonanterior.Size = new System.Drawing.Size(75, 23);
            this.buttonanterior.TabIndex = 3;
            this.buttonanterior.Text = "Anterior";
            this.buttonanterior.UseVisualStyleBackColor = true;
            this.buttonanterior.Click += new System.EventHandler(this.buttonanterior_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 474);
            this.Controls.Add(this.botonespaginas);
            this.Controls.Add(this.btVerCalificacion);
            this.Controls.Add(this.btCalificar);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Mi Historial de Compras";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.botonespaginas.ResumeLayout(false);
            this.botonespaginas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCantidadSubastas;
        private System.Windows.Forms.TextBox txtCantComprasDirectas;
        private System.Windows.Forms.TextBox txtTotalEstrellas;
        private System.Windows.Forms.TextBox txtOperacionesNoCalificadas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtSubasta;
        private System.Windows.Forms.RadioButton rbtCompraDirecta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtVerSinCalificar;
        private System.Windows.Forms.RadioButton rbtVer5Calificadas;
        private System.Windows.Forms.RadioButton rbtVerTodas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt5estrellas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt4estrellas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt3estrellas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt2estrellas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt1estrella;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Button btCalificar;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Button btVerCalificacion;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Panel botonespaginas;
        private System.Windows.Forms.Label labelactual;
        private System.Windows.Forms.TextBox actual;
        private System.Windows.Forms.Button buttonsiguiente;
        private System.Windows.Forms.Button buttonanterior;
    }
}