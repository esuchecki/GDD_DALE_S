using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Historial_Cliente
{
    public partial class Form1 : Form
    {
        string pagSize = "5";
        
        public Form1(string idUsuario, bool elUsuarioQuiereCalificar)
        {
            InitializeComponent();
            this.txtIdUsuario.Text = idUsuario;
            //this.btNext100.Enabled = false;

            this.btCalificar.Enabled = false;
            this.btVerCalificacion.Enabled = false;

            //relleno el dato de operaciones sin calificar...
            DataTable resultado2 = new DataTable();
            _conexionSQL conectarBD = _conexionSQL.Instance;

            string sql;
            // comienzo....
            sql = @"select count(com.idcompra)
                        from DALE_SA.compra com
                        where com.idUsuario = " + this.txtIdUsuario.Text + @"
                            and	not exists (select *
							                    from DALE_SA.calificacion cal
											    where cal.idcompra=com.idcompra)
                        ";

            resultado2 = conectarBD.ejecutarUnaQuery(sql);
            this.txtOperacionesNoCalificadas.Text = resultado2.Rows[0][0].ToString();

            //cantidad de compras inmediatas:
            sql = @"select count(t1.idcompra) from DALE_SA.compra t1, DALE_SA.publicacion t2 
                        where t1.idusuario = " + this.txtIdUsuario.Text + @"
                        and t1.idpublicacion = t2.idpublicacion
                        and t2.tipo_publicacion = 'Compra Inmediata'
                        ";

            resultado2 = conectarBD.ejecutarUnaQuery(sql);
            this.txtCantComprasDirectas.Text = resultado2.Rows[0][0].ToString();

            //cantidad de subastas:
            sql = @"select count(t1.idcompra) from DALE_SA.compra t1, DALE_SA.publicacion t2 
                        where t1.idusuario = " + this.txtIdUsuario.Text + @"
                        and t1.idpublicacion = t2.idpublicacion
                        and t2.tipo_publicacion = 'Subasta'
                        ";

            resultado2 = conectarBD.ejecutarUnaQuery(sql);
            this.txtCantidadSubastas.Text = resultado2.Rows[0][0].ToString();


            //--------------------------------------------------------------


            //relleno estrellas
            int contadorDeEstrellas = 0;
            sql = @"select count(*)
		                from DALE_SA.calificacion cal
		                where cal.idusuariocomprador=" + this.txtIdUsuario.Text + @" and cal.cantidad_estrella=1
                        ";

            resultado2 = conectarBD.ejecutarUnaQuery(sql);
            this.txt1estrella.Text = resultado2.Rows[0][0].ToString();
            contadorDeEstrellas = contadorDeEstrellas + ( ( Convert.ToInt32(resultado2.Rows[0][0]) ) * 1 );
            //---------------------------
            sql = @"select count(*)
		                from DALE_SA.calificacion cal
		                where cal.idusuariocomprador=" + this.txtIdUsuario.Text + @" and cal.cantidad_estrella=2
                        ";

            resultado2 = conectarBD.ejecutarUnaQuery(sql);
            this.txt2estrellas.Text = resultado2.Rows[0][0].ToString();
            contadorDeEstrellas = contadorDeEstrellas + ((Convert.ToInt32(resultado2.Rows[0][0])) * 2);
            //---------------------------
            sql = @"select count(*)
		                from DALE_SA.calificacion cal
		                where cal.idusuariocomprador=" + this.txtIdUsuario.Text + @" and cal.cantidad_estrella=3
                        ";

            resultado2 = conectarBD.ejecutarUnaQuery(sql);
            this.txt3estrellas.Text = resultado2.Rows[0][0].ToString();
            contadorDeEstrellas = contadorDeEstrellas + ((Convert.ToInt32(resultado2.Rows[0][0])) * 3);
            //---------------------------
            sql = @"select count(*)
		                from DALE_SA.calificacion cal
		                where cal.idusuariocomprador=" + this.txtIdUsuario.Text + @" and cal.cantidad_estrella=4
                        ";

            resultado2 = conectarBD.ejecutarUnaQuery(sql);
            this.txt4estrellas.Text = resultado2.Rows[0][0].ToString();
            contadorDeEstrellas = contadorDeEstrellas + ((Convert.ToInt32(resultado2.Rows[0][0])) * 4);
            //---------------------------
            sql = @"select count(*)
		                from DALE_SA.calificacion cal
		                where cal.idusuariocomprador=" + this.txtIdUsuario.Text + @" and cal.cantidad_estrella=5
                        ";

            resultado2 = conectarBD.ejecutarUnaQuery(sql);
            this.txt5estrellas.Text = resultado2.Rows[0][0].ToString();
            contadorDeEstrellas = contadorDeEstrellas + ((Convert.ToInt32(resultado2.Rows[0][0])) * 5);

            //relleno lo demas.....
            this.txtTotalEstrellas.Text = contadorDeEstrellas.ToString();

            if (elUsuarioQuiereCalificar)
            {
                this.rbtCompraDirecta.Checked = true;
                this.rbtVerSinCalificar.Checked = true;
            }

        }

        private void rbtVerTodas_CheckedChanged(object sender, EventArgs e)
        {
            this.btCalificar.Enabled = false;
            this.btVerCalificacion.Enabled = false;
            
            if (this.rbtCompraDirecta.Checked == true && this.rbtVerTodas.Checked == true)
            {
                //traemos los datos de la compra directa

                DataTable resultado2 = new DataTable();
                _conexionSQL conectarBD = _conexionSQL.Instance;

                string sql;
                /*
                sql = @"SELECT * FROM [DALE_SA].view_CompraInmediata(" + this.txtIdUsuario.Text + @")
                        ";
                */
                sql = @"EXEC [DALE_SA].[prPaginar_view_CompraInmediata] 
                            '" + this.txtIdUsuario.Text + @"'
                            ,0," + pagSize + @"
                        ";

                resultado2 = conectarBD.ejecutarUnaQuery(sql);


                this.dgvHistorial.DataSource = resultado2;

                //comienzo del codigo para paginar..

                //DataGridViewRow fila;
                if (this.dgvHistorial.RowCount > 0)
                {
                    this.actual.Text = "0";
                    this.botonespaginas.Enabled = true;
                    this.botonespaginas.Visible = true;


                    //repito el proceso y reviso si hay +....
                    this.buttonsiguiente.Enabled = false;
                    this.buttonanterior.Enabled = false;
                    DataTable resultado3 = new DataTable();
                    string temporal;
                    temporal = ((Convert.ToInt16(this.actual.Text)) + (Convert.ToInt16(pagSize))).ToString();
                    sql = @"EXEC [DALE_SA].[prPaginar_view_CompraInmediata] 
                            '" + this.txtIdUsuario.Text + @"'
                            ," + temporal + @"," + pagSize + @"
                        ";

                    resultado3 = conectarBD.ejecutarUnaQuery(sql);

                    if (resultado3 != null)
                    {
                        if (resultado3.Rows.Count > 0)
                            this.buttonsiguiente.Enabled = true;
                    }
                }

                //this.btNext100.Enabled = true;
            }

            if (this.rbtSubasta.Checked == true && this.rbtVerTodas.Checked == true)
            {
                //traemos los datos de la subasta

                DataTable resultado2 = new DataTable();
                _conexionSQL conectarBD = _conexionSQL.Instance;

                string sql;
                /*
                sql = @"SELECT * FROM [DALE_SA].view_CompraInmediata(" + this.txtIdUsuario.Text + @")
                        ";
                */
                sql = @"EXEC [DALE_SA].[prPaginar_view_CompraSubasta] 
                            '" + this.txtIdUsuario.Text + @"'
                            ,0," + pagSize + @"
                        ";

                resultado2 = conectarBD.ejecutarUnaQuery(sql);


                this.dgvHistorial.DataSource = resultado2;

                //comienzo del codigo para paginar..

                //DataGridViewRow fila;
                if (this.dgvHistorial.RowCount > 0)
                {
                    this.actual.Text = "0";
                    this.botonespaginas.Enabled = true;
                    this.botonespaginas.Visible = true;


                    //repito el proceso y reviso si hay +....
                    this.buttonsiguiente.Enabled = false;
                    this.buttonanterior.Enabled = false;
                    DataTable resultado3 = new DataTable();
                    string temporal;
                    temporal = ((Convert.ToInt16(this.actual.Text)) + (Convert.ToInt16(pagSize))).ToString();
                    sql = @"EXEC [DALE_SA].[prPaginar_view_CompraSubasta] 
                            '" + this.txtIdUsuario.Text + @"'
                            ," + temporal + @"," + pagSize + @"
                        ";

                    resultado3 = conectarBD.ejecutarUnaQuery(sql);

                    if (resultado3 != null)
                    {
                        if (resultado3.Rows.Count > 0)
                            this.buttonsiguiente.Enabled = true;
                    }
                }

                //this.btNext100.Enabled = true;
            }



        }

        private void rbtVer5Calificadas_CheckedChanged(object sender, EventArgs e)
        {
            this.btCalificar.Enabled = false;
            this.btVerCalificacion.Enabled = false;
            this.botonespaginas.Enabled = false;
            this.botonespaginas.Visible = false;
            
            if (this.rbtCompraDirecta.Checked == true && this.rbtVer5Calificadas.Checked == true)
            {
                //traemos los datos de la compra directa

                DataTable resultado2 = new DataTable();
                _conexionSQL conectarBD = _conexionSQL.Instance;

                string sql;
                /*
                sql = @"select top 5 com.idcompra from DALE_SA.compra com where com.idusuario =" + this.txtIdUsuario.Text + @"order by fecha desc
                        ";
                */
                sql = @"
                        SELECT * FROM [DALE_SA].view_CompraInmediata(" + this.txtIdUsuario.Text + @") tablita where idcompra IN
                        (
	                    select top 5 com.idcompra from DALE_SA.compra com, DALE_SA.publicacion t2 where (com.idusuario = " + this.txtIdUsuario.Text + @" and 	(t2.tipo_publicacion = 'Compra Inmediata') and com.idpublicacion = t2.idpublicacion and ([DALE_SA].fcEstaCompraFueCalificada(com.idcompra) = 1))order by com.fecha desc
                        )
                        ";

                resultado2 = conectarBD.ejecutarUnaQuery(sql);

                this.dgvHistorial.DataSource = resultado2;




                //this.btNext100.Enabled = false;
            }

            if (this.rbtSubasta.Checked == true && this.rbtVer5Calificadas.Checked == true)
            {
                //traemos los datos de la subasta
                DataTable resultado2 = new DataTable();
                _conexionSQL conectarBD = _conexionSQL.Instance;

                string sql;
                sql = @"
                        SELECT * FROM [DALE_SA].view_CompraSubasta(" + this.txtIdUsuario.Text + @") tablita where idpublicacion IN
                        (
	                    select top 5 com.idpublicacion from DALE_SA.compra com, DALE_SA.publicacion t2 where (com.idusuario = " + this.txtIdUsuario.Text + @" and 	(t2.tipo_publicacion = 'Subasta') and com.idpublicacion = t2.idpublicacion  and ([DALE_SA].fcEstaCompraFueCalificada(com.idcompra) = 1) )order by com.fecha desc
                        )
                        ";
                resultado2 = conectarBD.ejecutarUnaQuery(sql);
                this.dgvHistorial.DataSource = resultado2;


                //this.btNext100.Enabled = false;
            }
        }

        private void rbtVerSinCalificar_CheckedChanged(object sender, EventArgs e)
        {
            this.btCalificar.Enabled = false;
            this.btVerCalificacion.Enabled = false;
            this.botonespaginas.Enabled = false;
            this.botonespaginas.Visible = false;
            
            if (this.rbtCompraDirecta.Checked == true && this.rbtVerSinCalificar.Checked == true)
            {
                //traemos los datos de la compra directa
                DataTable resultado2 = new DataTable();
                _conexionSQL conectarBD = _conexionSQL.Instance;

                string sql;
                sql = @"SELECT * FROM [DALE_SA].view_CompraInmediata(" + this.txtIdUsuario.Text + @") t1
                            where t1.CALIFICADA = 'NO'
                        ";

                resultado2 = conectarBD.ejecutarUnaQuery(sql);

                this.dgvHistorial.DataSource = resultado2;


                //this.btNext100.Enabled = true;
            }

            if (this.rbtSubasta.Checked == true && this.rbtVerSinCalificar.Checked == true)
            {
                //traemos los datos de la subasta
                DataTable resultado2 = new DataTable();
                _conexionSQL conectarBD = _conexionSQL.Instance;

                string sql;
                sql = @"SELECT * FROM [DALE_SA].view_CompraSubasta(" + this.txtIdUsuario.Text + @") t1
                            where t1.CALIFICADA = 'NO'
                        ";

                resultado2 = conectarBD.ejecutarUnaQuery(sql);

                this.dgvHistorial.DataSource = resultado2;



                //this.btNext100.Enabled = true;
            }
        }

        private void btCalificar_Click(object sender, EventArgs e)
        {

            //TextBox txt = (TextBox)frm.Controls.Find("txtIdPublicacion", true)[0];
            int d = this.dgvHistorial.CurrentCell.RowIndex;
            DataGridViewRow row = this.dgvHistorial.Rows[d];

            //Suponemos: 0  -> publicacionId 
            //           1  -> ??
            //           2  -> ??


            //txt.Text = row.Cells[0].Value.ToString();

            if (this.rbtSubasta.Checked == true)
            {
                WindowsFormsApplication1.Historial_Cliente.Calificaciones frm = new WindowsFormsApplication1.Historial_Cliente.Calificaciones(row.Cells[0].Value.ToString(), false, null);
                frm.Show();
            }
            if (this.rbtCompraDirecta.Checked == true)
            {
                //Si es compra directa en el la columna 9 (osea 9-1= 8), tenes el id de compra..
                WindowsFormsApplication1.Historial_Cliente.Calificaciones frm = new WindowsFormsApplication1.Historial_Cliente.Calificaciones(row.Cells[0].Value.ToString(), false, row.Cells[8].Value.ToString());
                frm.Show();
            }
        }

        private void btVerCalificacion_Click(object sender, EventArgs e)
        {
            //TextBox txt = (TextBox)frm.Controls.Find("txtIdPublicacion", true)[0];
            int d = this.dgvHistorial.CurrentCell.RowIndex;
            DataGridViewRow row = this.dgvHistorial.Rows[d];

            //Suponemos: 0  -> publicacionId 
            //           1  -> ??
            //           2  -> ??


            //txt.Text = row.Cells[0].Value.ToString();
            if (this.rbtSubasta.Checked == true)
            {
                WindowsFormsApplication1.Historial_Cliente.Calificaciones frm = new WindowsFormsApplication1.Historial_Cliente.Calificaciones(row.Cells[0].Value.ToString(), true, null);
                frm.Show();
            }
            if (this.rbtCompraDirecta.Checked == true)
            {
                //Si es compra directa en el la columna 9 (osea 9-1= 8), tenes el id de compra..
                WindowsFormsApplication1.Historial_Cliente.Calificaciones frm = new WindowsFormsApplication1.Historial_Cliente.Calificaciones(row.Cells[0].Value.ToString(), true, row.Cells[8].Value.ToString());
                frm.Show();
            }


        }

        private void dgvHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Hacemos que cuando cliqueamos en el datagrid, cambie el valor del textbox
                int d = dgvHistorial.CurrentCell.RowIndex;
                DataGridViewRow row = this.dgvHistorial.Rows[d];

                //Suponemos: 0  ->   
                //           1  -> 
                //           2  -> 

                //para compra_directa.. califida = 7
                //para subasta.. califida = 10
                this.btCalificar.Enabled = false;
                this.btVerCalificacion.Enabled = false;

                if (this.rbtSubasta.Checked == true)
                {
                    if (String.Compare(row.Cells[10].Value.ToString(), "CALIFICADA") == 0)
                    {
                        this.btCalificar.Enabled = false;
                        this.btVerCalificacion.Enabled = true;
                    }

                    if (String.Compare(row.Cells[10].Value.ToString(), "NO") == 0)
                    {
                        this.btCalificar.Enabled = true;
                        this.btVerCalificacion.Enabled = false;
                    }

                }
                if (this.rbtCompraDirecta.Checked == true)
                {
                    if (String.Compare(row.Cells[7].Value.ToString(), "CALIFICADA") == 0)
                    {
                        this.btCalificar.Enabled = false;
                        this.btVerCalificacion.Enabled = true;
                    }

                    if (String.Compare(row.Cells[7].Value.ToString(), "NO") == 0)
                    {
                        this.btCalificar.Enabled = true;
                        this.btVerCalificacion.Enabled = false;
                    }
                }


            }



        }

        private void rbtSubasta_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtSubasta.Checked == true)
            {
                //les aviso que alguien cambio el rbuton de subasta
                if (this.rbtVer5Calificadas.Checked == true)
                {
                    this.rbtVer5Calificadas.Checked = false;
                    this.rbtVer5Calificadas.Checked = true;
                }

                if (this.rbtVerSinCalificar.Checked == true)
                {
                    this.rbtVerSinCalificar.Checked = false;
                    this.rbtVerSinCalificar.Checked = true;
                }

                if (this.rbtVerTodas.Checked == true)
                {
                    this.rbtVerTodas.Checked = false;
                    this.rbtVerTodas.Checked = true;
                }
            }
        }

        private void rbtCompraDirecta_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtCompraDirecta.Checked == true)
            {
                //les aviso que alguien cambio el rbuton de subasta
                if (this.rbtVer5Calificadas.Checked == true)
                {
                    this.rbtVer5Calificadas.Checked = false;
                    this.rbtVer5Calificadas.Checked = true;
                }

                if (this.rbtVerSinCalificar.Checked == true)
                {
                    this.rbtVerSinCalificar.Checked = false;
                    this.rbtVerSinCalificar.Checked = true;
                }

                if (this.rbtVerTodas.Checked == true)
                {
                    this.rbtVerTodas.Checked = false;
                    this.rbtVerTodas.Checked = true;
                }
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            if (this.rbtCompraDirecta.Checked == true)
            {
                //les aviso que alguien cambio el rbuton de subasta
                if (this.rbtVer5Calificadas.Checked == true)
                {
                    this.rbtVer5Calificadas.Checked = false;
                    this.rbtVer5Calificadas.Checked = true;
                }

                if (this.rbtVerSinCalificar.Checked == true)
                {
                    this.rbtVerSinCalificar.Checked = false;
                    this.rbtVerSinCalificar.Checked = true;
                }

                if (this.rbtVerTodas.Checked == true)
                {
                    this.rbtVerTodas.Checked = false;
                    this.rbtVerTodas.Checked = true;
                }
            }

            if (this.rbtSubasta.Checked == true)
            {
                //les aviso que alguien cambio el rbuton de subasta
                if (this.rbtVer5Calificadas.Checked == true)
                {
                    this.rbtVer5Calificadas.Checked = false;
                    this.rbtVer5Calificadas.Checked = true;
                }

                if (this.rbtVerSinCalificar.Checked == true)
                {
                    this.rbtVerSinCalificar.Checked = false;
                    this.rbtVerSinCalificar.Checked = true;
                }

                if (this.rbtVerTodas.Checked == true)
                {
                    this.rbtVerTodas.Checked = false;
                    this.rbtVerTodas.Checked = true;
                }
            }

        }

        private void buttonanterior_Click(object sender, EventArgs e)
        {
            this.actual.Text = ((Convert.ToInt16(this.actual.Text)) - (Convert.ToInt16(pagSize))).ToString();

            if (this.rbtCompraDirecta.Checked == true && this.rbtVerTodas.Checked == true)
            {
                //traemos los datos de la compra directa

                DataTable resultado2 = new DataTable();
                _conexionSQL conectarBD = _conexionSQL.Instance;

                string sql;
                /*
                sql = @"SELECT * FROM [DALE_SA].view_CompraInmediata(" + this.txtIdUsuario.Text + @")
                        ";
                */
                sql = @"EXEC [DALE_SA].[prPaginar_view_CompraInmediata] 
                            '" + this.txtIdUsuario.Text + @"'
                            ," + this.actual.Text + @"," + pagSize + @"
                        ";

                resultado2 = conectarBD.ejecutarUnaQuery(sql);


                this.dgvHistorial.DataSource = resultado2;
                this.buttonsiguiente.Enabled = true;

                this.buttonsiguiente.Enabled = true;
                if (string.Compare(this.actual.Text, "0") == 0)
                    this.buttonanterior.Enabled = false;

                //this.btNext100.Enabled = true;
            }

            if (this.rbtSubasta.Checked == true && this.rbtVerTodas.Checked == true)
            {
                //traemos los datos de la subasta

                DataTable resultado2 = new DataTable();
                _conexionSQL conectarBD = _conexionSQL.Instance;

                string sql;
                /*
                sql = @"SELECT * FROM [DALE_SA].view_CompraInmediata(" + this.txtIdUsuario.Text + @")
                        ";
                */
                sql = @"EXEC [DALE_SA].[prPaginar_view_CompraSubasta] 
                            '" + this.txtIdUsuario.Text + @"'
                            ," + this.actual.Text + @"," + pagSize + @"
                        ";

                resultado2 = conectarBD.ejecutarUnaQuery(sql);


                this.dgvHistorial.DataSource = resultado2;

                this.buttonsiguiente.Enabled = true;

                this.buttonsiguiente.Enabled = true;
                if (string.Compare(this.actual.Text, "0") == 0)
                    this.buttonanterior.Enabled = false;
            }
        
        
        
                    
        }

        private void buttonsiguiente_Click(object sender, EventArgs e)
        {
            this.actual.Text = ((Convert.ToInt16(this.actual.Text)) + (Convert.ToInt16(pagSize))).ToString();

            if (this.rbtCompraDirecta.Checked == true && this.rbtVerTodas.Checked == true)
            {
                //traemos los datos de la compra directa

                DataTable resultado2 = new DataTable();
                _conexionSQL conectarBD = _conexionSQL.Instance;

                string sql;
                /*
                sql = @"SELECT * FROM [DALE_SA].view_CompraInmediata(" + this.txtIdUsuario.Text + @")
                        ";
                */
                sql = @"EXEC [DALE_SA].[prPaginar_view_CompraInmediata] 
                            '" + this.txtIdUsuario.Text + @"'
                            ," + this.actual.Text + @"," + pagSize + @"
                        ";

                resultado2 = conectarBD.ejecutarUnaQuery(sql);


                this.dgvHistorial.DataSource = resultado2;

                //comienzo del codigo para paginar..

                //DataGridViewRow fila;
                if (this.dgvHistorial.RowCount > 0)
                {
                    //this.actual.Text = "0";
                    this.botonespaginas.Enabled = true;
                    this.botonespaginas.Visible = true;


                    //repito el proceso y reviso si hay +....
                    this.buttonsiguiente.Enabled = false;
                    this.buttonanterior.Enabled = true;
                    DataTable resultado3 = new DataTable();
                    string temporal;
                    temporal = ((Convert.ToInt16(this.actual.Text)) + (Convert.ToInt16(pagSize))).ToString();
                    sql = @"EXEC [DALE_SA].[prPaginar_view_CompraInmediata] 
                            '" + this.txtIdUsuario.Text + @"'
                            ," + temporal + @"," + pagSize + @"
                        ";

                    resultado3 = conectarBD.ejecutarUnaQuery(sql);

                    if (resultado3 != null)
                    {
                        if (resultado3.Rows.Count > 0)
                            this.buttonsiguiente.Enabled = true;
                    }
                }

                //this.btNext100.Enabled = true;
            }

            if (this.rbtSubasta.Checked == true && this.rbtVerTodas.Checked == true)
            {
                //traemos los datos de la subasta

                DataTable resultado2 = new DataTable();
                _conexionSQL conectarBD = _conexionSQL.Instance;

                string sql;
                /*
                sql = @"SELECT * FROM [DALE_SA].view_CompraInmediata(" + this.txtIdUsuario.Text + @")
                        ";
                */
                sql = @"EXEC [DALE_SA].[prPaginar_view_CompraSubasta] 
                            '" + this.txtIdUsuario.Text + @"'
                            ," + this.actual.Text + @"," + pagSize + @"
                        ";

                resultado2 = conectarBD.ejecutarUnaQuery(sql);


                this.dgvHistorial.DataSource = resultado2;

                //comienzo del codigo para paginar..

                //DataGridViewRow fila;
                if (this.dgvHistorial.RowCount > 0)
                {
                    //this.actual.Text = "0";
                    this.botonespaginas.Enabled = true;
                    this.botonespaginas.Visible = true;


                    //repito el proceso y reviso si hay +....
                    this.buttonsiguiente.Enabled = false;
                    this.buttonanterior.Enabled = true;
                    DataTable resultado3 = new DataTable();
                    string temporal;
                    temporal = ((Convert.ToInt16(this.actual.Text)) + (Convert.ToInt16(pagSize))).ToString();
                    sql = @"EXEC [DALE_SA].[prPaginar_view_CompraSubasta] 
                            '" + this.txtIdUsuario.Text + @"'
                            ," + temporal + @"," + pagSize + @"
                        ";

                    resultado3 = conectarBD.ejecutarUnaQuery(sql);

                    if (resultado3 != null)
                    {
                        if (resultado3.Rows.Count > 0)
                            this.buttonsiguiente.Enabled = true;
                    }
                }

                //this.btNext100.Enabled = true;
            }
        
        
        
        
        }






    }
}
