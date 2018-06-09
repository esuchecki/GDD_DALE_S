namespace WindowsFormsApplication1.Facturas
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
            this.gboxClientes = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontoInicial = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.gboxResultados = new System.Windows.Forms.GroupBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMontoFinal = new System.Windows.Forms.TextBox();
            this.dtp_FechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.checkFecha = new System.Windows.Forms.CheckBox();
            this.botonespaginas = new System.Windows.Forms.Panel();
            this.labelactual = new System.Windows.Forms.Label();
            this.actual = new System.Windows.Forms.TextBox();
            this.buttonsiguiente = new System.Windows.Forms.Button();
            this.buttonanterior = new System.Windows.Forms.Button();
            this.gboxClientes.SuspendLayout();
            this.gboxResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.botonespaginas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxClientes
            // 
            this.gboxClientes.Controls.Add(this.checkFecha);
            this.gboxClientes.Controls.Add(this.label4);
            this.gboxClientes.Controls.Add(this.label2);
            this.gboxClientes.Controls.Add(this.dtpFechaFinal);
            this.gboxClientes.Controls.Add(this.dtp_FechaInicial);
            this.gboxClientes.Controls.Add(this.label8);
            this.gboxClientes.Controls.Add(this.txtMontoFinal);
            this.gboxClientes.Controls.Add(this.label5);
            this.gboxClientes.Controls.Add(this.label3);
            this.gboxClientes.Controls.Add(this.label1);
            this.gboxClientes.Controls.Add(this.txtMontoInicial);
            this.gboxClientes.Controls.Add(this.txtUsername);
            this.gboxClientes.Controls.Add(this.shapeContainer1);
            this.gboxClientes.Location = new System.Drawing.Point(12, 12);
            this.gboxClientes.Name = "gboxClientes";
            this.gboxClientes.Size = new System.Drawing.Size(820, 89);
            this.gboxClientes.TabIndex = 4;
            this.gboxClientes.TabStop = false;
            this.gboxClientes.Text = "Filtros de Busqueda de Vendedores:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "(Busqueda Libre)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Monto Inicial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // txtMontoInicial
            // 
            this.txtMontoInicial.Location = new System.Drawing.Point(496, 27);
            this.txtMontoInicial.Name = "txtMontoInicial";
            this.txtMontoInicial.Size = new System.Drawing.Size(102, 20);
            this.txtMontoInicial.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(70, 28);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(191, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // gboxResultados
            // 
            this.gboxResultados.Controls.Add(this.botonespaginas);
            this.gboxResultados.Controls.Add(this.dgvResultados);
            this.gboxResultados.Controls.Add(this.btBuscar);
            this.gboxResultados.Controls.Add(this.btLimpiar);
            this.gboxResultados.Location = new System.Drawing.Point(12, 107);
            this.gboxResultados.Name = "gboxResultados";
            this.gboxResultados.Size = new System.Drawing.Size(820, 419);
            this.gboxResultados.TabIndex = 5;
            this.gboxResultados.TabStop = false;
            this.gboxResultados.Text = "Cuadro de Resultados";
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(10, 49);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(804, 325);
            this.dgvResultados.TabIndex = 2;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(638, 19);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(176, 23);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(12, 19);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(152, 23);
            this.btLimpiar.TabIndex = 0;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(618, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Monto Final:";
            // 
            // txtMontoFinal
            // 
            this.txtMontoFinal.Location = new System.Drawing.Point(694, 27);
            this.txtMontoFinal.Name = "txtMontoFinal";
            this.txtMontoFinal.Size = new System.Drawing.Size(102, 20);
            this.txtMontoFinal.TabIndex = 11;
            // 
            // dtp_FechaInicial
            // 
            this.dtp_FechaInicial.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtp_FechaInicial.Location = new System.Drawing.Point(236, 63);
            this.dtp_FechaInicial.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtp_FechaInicial.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtp_FechaInicial.Name = "dtp_FechaInicial";
            this.dtp_FechaInicial.Size = new System.Drawing.Size(232, 20);
            this.dtp_FechaInicial.TabIndex = 13;
            this.dtp_FechaInicial.Value = new System.DateTime(2016, 6, 1, 12, 0, 0, 0);
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dtpFechaFinal.Location = new System.Drawing.Point(564, 63);
            this.dtpFechaFinal.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpFechaFinal.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(232, 20);
            this.dtpFechaFinal.TabIndex = 14;
            this.dtpFechaFinal.Value = new System.DateTime(2016, 6, 1, 12, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fecha Inicial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fecha Final:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(814, 70);
            this.shapeContainer1.TabIndex = 17;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 397;
            this.lineShape1.X2 = 397;
            this.lineShape1.Y1 = -15;
            this.lineShape1.Y2 = 39;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 810;
            this.lineShape2.X2 = 0;
            this.lineShape2.Y1 = 39;
            this.lineShape2.Y2 = 39;
            // 
            // checkFecha
            // 
            this.checkFecha.AutoSize = true;
            this.checkFecha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkFecha.Location = new System.Drawing.Point(12, 63);
            this.checkFecha.Name = "checkFecha";
            this.checkFecha.Size = new System.Drawing.Size(92, 17);
            this.checkFecha.TabIndex = 18;
            this.checkFecha.Text = "Filtrar x Fecha";
            this.checkFecha.UseVisualStyleBackColor = true;
            this.checkFecha.CheckedChanged += new System.EventHandler(this.checkFecha_CheckedChanged);
            // 
            // botonespaginas
            // 
            this.botonespaginas.Controls.Add(this.labelactual);
            this.botonespaginas.Controls.Add(this.actual);
            this.botonespaginas.Controls.Add(this.buttonsiguiente);
            this.botonespaginas.Controls.Add(this.buttonanterior);
            this.botonespaginas.Enabled = false;
            this.botonespaginas.Location = new System.Drawing.Point(141, 380);
            this.botonespaginas.Name = "botonespaginas";
            this.botonespaginas.Size = new System.Drawing.Size(518, 33);
            this.botonespaginas.TabIndex = 11;
            this.botonespaginas.Visible = false;
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
            // buttonsiguiente
            // 
            this.buttonsiguiente.Enabled = false;
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
            this.buttonanterior.Enabled = false;
            this.buttonanterior.Location = new System.Drawing.Point(118, 5);
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
            this.ClientSize = new System.Drawing.Size(841, 538);
            this.Controls.Add(this.gboxClientes);
            this.Controls.Add(this.gboxResultados);
            this.Name = "Form1";
            this.Text = "Facturas Realizadas al Vendedor";
            this.gboxClientes.ResumeLayout(false);
            this.gboxClientes.PerformLayout();
            this.gboxResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.botonespaginas.ResumeLayout(false);
            this.botonespaginas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxClientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMontoInicial;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox gboxResultados;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMontoFinal;
        private System.Windows.Forms.CheckBox checkFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtp_FechaInicial;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel botonespaginas;
        private System.Windows.Forms.Label labelactual;
        private System.Windows.Forms.TextBox actual;
        private System.Windows.Forms.Button buttonsiguiente;
        private System.Windows.Forms.Button buttonanterior;
    }
}