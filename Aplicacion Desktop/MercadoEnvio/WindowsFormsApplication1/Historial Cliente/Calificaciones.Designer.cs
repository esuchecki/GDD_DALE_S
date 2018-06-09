namespace WindowsFormsApplication1.Historial_Cliente
{
    partial class Calificaciones
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
            this.combEstrellas = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btCalificar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.txtIdPublicacion = new System.Windows.Forms.TextBox();
            this.txtEsCompraDirecta = new System.Windows.Forms.TextBox();
            this.txtIdCompra = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combEstrellas);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cantidad de Estrellas (*)";
            // 
            // combEstrellas
            // 
            this.combEstrellas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combEstrellas.FormattingEnabled = true;
            this.combEstrellas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.combEstrellas.Location = new System.Drawing.Point(73, 19);
            this.combEstrellas.Name = "combEstrellas";
            this.combEstrellas.Size = new System.Drawing.Size(121, 21);
            this.combEstrellas.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDesc);
            this.groupBox2.Location = new System.Drawing.Point(13, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descripcion (Opcional)";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(7, 20);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(246, 110);
            this.txtDesc.TabIndex = 0;
            // 
            // btCalificar
            // 
            this.btCalificar.Location = new System.Drawing.Point(172, 227);
            this.btCalificar.Name = "btCalificar";
            this.btCalificar.Size = new System.Drawing.Size(75, 23);
            this.btCalificar.TabIndex = 2;
            this.btCalificar.Text = "Calificar";
            this.btCalificar.UseVisualStyleBackColor = true;
            this.btCalificar.Click += new System.EventHandler(this.btCalificar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(43, 227);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // txtIdPublicacion
            // 
            this.txtIdPublicacion.Location = new System.Drawing.Point(161, 0);
            this.txtIdPublicacion.Name = "txtIdPublicacion";
            this.txtIdPublicacion.Size = new System.Drawing.Size(100, 20);
            this.txtIdPublicacion.TabIndex = 4;
            this.txtIdPublicacion.Visible = false;
            // 
            // txtEsCompraDirecta
            // 
            this.txtEsCompraDirecta.Location = new System.Drawing.Point(172, 59);
            this.txtEsCompraDirecta.Name = "txtEsCompraDirecta";
            this.txtEsCompraDirecta.Size = new System.Drawing.Size(100, 20);
            this.txtEsCompraDirecta.TabIndex = 1;
            this.txtEsCompraDirecta.Visible = false;
            // 
            // txtIdCompra
            // 
            this.txtIdCompra.Location = new System.Drawing.Point(56, 59);
            this.txtIdCompra.Name = "txtIdCompra";
            this.txtIdCompra.Size = new System.Drawing.Size(100, 20);
            this.txtIdCompra.TabIndex = 5;
            this.txtIdCompra.Visible = false;
            // 
            // Calificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtIdCompra);
            this.Controls.Add(this.txtEsCompraDirecta);
            this.Controls.Add(this.txtIdPublicacion);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btCalificar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Calificaciones";
            this.Text = "Calificaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combEstrellas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btCalificar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox txtIdPublicacion;
        private System.Windows.Forms.TextBox txtEsCompraDirecta;
        private System.Windows.Forms.TextBox txtIdCompra;
    }
}