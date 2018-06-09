using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Listado_Estadistico
{
    public partial class Form1 : Form
    {
        private int ano;
        private int trimestre;
        private String rub;
        private int idRubro;
        private String mes;
        private String key;
        private List<String> mesesElegidos = new List<String>();
        private String[,] meses = new String [12, 2];

        //private Dictionary<string,int> meses = new Dictionary<string, int>();
        private void inicializarMeses()
        {

            meses[0, 0] = "01";
            meses[0, 1] = "Enero";

            meses[1, 0] = "02";
            meses[1, 1] = "Febrero";

            meses[2, 0] = "03";
            meses[2, 1] = "Marzo";

            meses[3, 0] = "04";
            meses[3, 1] = "Abril";

            meses[4, 0] = "05";
            meses[4, 1] = "Mayo";

            meses[5, 0] = "06";
            meses[5, 1] = "Junio";

            meses[6, 0] = "07";
            meses[6, 1] = "Julio";

            meses[7, 0] = "08";
            meses[7, 1] = "Agosto";

            meses[8, 0] = "09";
            meses[8, 1] = "Septiembre";

            meses[9, 0] = "10";
            meses[9, 1] = "Octubre";

            meses[10, 0] = "11";
            meses[10, 1] = "Noviembre";

            meses[11, 0] = "12";
            meses[11, 1] = "Diciembre";

        }

         public string getKey(string mes)
                {
	                for(int i=0;i<12;i++)
	                {
		                if (meses[i, 1]==mes)
		                {
			                return meses[i, 0];
		                }
	                }
	                return "What is wrong with you";
                }
        


     

        public Form1()
        {
            InitializeComponent();
            inicializarMeses();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'filtrovisibilidad.visibilidad' Puede moverla o quitarla según sea necesario.
            this.visibilidadTableAdapter.Fill(this.filtrovisibilidad.visibilidad);
            // TODO: esta línea de código carga datos en la tabla 'rubro1.rubro' Puede moverla o quitarla según sea necesario.
            this.rubroTableAdapter.Fill(this.rubro1.rubro);
            // TODO: esta línea de código carga datos en la tabla 'estado.estado_publicacion' Puede moverla o quitarla según sea necesario.
            //this.estado_publicacionTableAdapter.Fill(this.estado.estado_publicacion);
            // TODO: esta línea de código carga datos en la tabla 'gD1C2016DataSet2.publicacion' Puede moverla o quitarla según sea necesario.
            //this.publicacionTableAdapter.Fill(this.gD1C2016DataSet2.publicacion);
            // TODO: esta línea de código carga datos en la tabla 'estadoIntentos.usuario' Puede moverla o quitarla según sea necesario.
            //this.usuarioTableAdapter1.Fill(this.estadoIntentos.usuario);
            // TODO: esta línea de código carga datos en la tabla 'gD1C2016DataSet.usuario' Puede moverla o quitarla según sea necesario.
            //this.usuarioTableAdapter.Fill(this.gD1C2016DataSet.usuario);
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usuarioTableAdapter.FillBy(this.gD1C2016DataSet.usuario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void usuarioBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            trimestre = 1;
            this.comboBox2.DataSource = null;
            this.comboBox3.DataSource = null;
            mesesElegidos.Clear();
            mesesElegidos.Add("Enero");
            mesesElegidos.Add("Febrero");
            mesesElegidos.Add("Marzo");
            this.comboBox2.DataSource = mesesElegidos;
            this.comboBox3.DataSource = mesesElegidos;
        }

        private void Cestado_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            trimestre = 2;
            this.comboBox2.DataSource = null;
            this.comboBox3.DataSource = null;
            mesesElegidos.Clear();
            mesesElegidos.Add("Abril");
            mesesElegidos.Add("Mayo");
            mesesElegidos.Add("Junio");
            this.comboBox2.DataSource = mesesElegidos;
            this.comboBox3.DataSource = mesesElegidos;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(System.Text.RegularExpressions.Regex.IsMatch(this.textBox1.Text, @"^[2][0][0-2][0-9]")))
            {
                MessageBox.Show("Por favor revise el año ingresado. Intervalo 2000 al 2029.");
                return;
            }
            
            if (this.radioButton6.Checked)
            {
                string visibilidadid = this.CBvis.SelectedValue.ToString();
                if (trimestre == 1)
                {
                    DataTable resultado;
                    _conexionSQL conectarBD = _conexionSQL.Instance;
                    resultado = conectarBD.ejecutarUnaQuery("select top 5 uss.username,sum(pub.stock) As Productos, vis.descripcion from DALE_SA.publicacion pub, DALE_SA.visibilidad vis, DALE_SA.usuario uss where pub.idusuario=uss.idusuario AND pub.idvisibilidad=vis.idvisibilidad AND (pub.estado=1 AND year(pub.fecha_inicio)=" + ano + ") AND (month(pub.fecha_inicio)=01 OR month(pub.fecha_inicio)=02 OR month(pub.fecha_inicio)=03) and pub.stock >0 AND pub.idvisibilidad=" + visibilidadid + " group by uss.username, vis.descripcion order by 2 desc, 3 desc");
                    this.dataGridView1.DataSource = resultado;
                }

                if (trimestre == 2)
                {
                    DataTable resultado;
                    _conexionSQL conectarBD = _conexionSQL.Instance;
                    resultado = conectarBD.ejecutarUnaQuery("select top 5 uss.username,sum(pub.stock) As Productos, vis.descripcion from DALE_SA.publicacion pub, DALE_SA.visibilidad vis, DALE_SA.usuario uss where pub.idusuario=uss.idusuario AND pub.idvisibilidad=vis.idvisibilidad AND(pub.estado=1 AND year(pub.fecha_inicio)=" + ano + ") AND (month(pub.fecha_inicio)=04 OR month(pub.fecha_inicio)=05 OR month(pub.fecha_inicio)=06) and pub.stock >0 AND pub.idvisibilidad=" + visibilidadid + " group by uss.username, vis.descripcion order by 2 desc, 3 desc");
                    this.dataGridView1.DataSource = resultado;
                }

                if (trimestre == 3)
                {
                    DataTable resultado;
                    _conexionSQL conectarBD = _conexionSQL.Instance;
                    resultado = conectarBD.ejecutarUnaQuery("select top 5 uss.username,sum(pub.stock) As Productos, vis.descripcion from DALE_SA.publicacion pub, DALE_SA.visibilidad vis, DALE_SA.usuario uss where pub.idusuario=uss.idusuario AND pub.idvisibilidad=vis.idvisibilidad AND (pub.estado=1 AND year(pub.fecha_inicio)=" + ano + ") AND (month(pub.fecha_inicio)=07 OR month(pub.fecha_inicio)=08 OR month(pub.fecha_inicio)=09) and pub.stock >0 AND pub.idvisibilidad=" + visibilidadid + " group by uss.username, vis.descripcion order by 2 desc, 3 desc");
                    this.dataGridView1.DataSource = resultado;
                }

                if (trimestre == 4)
                {
                    DataTable resultado;
                    _conexionSQL conectarBD = _conexionSQL.Instance;
                    resultado = conectarBD.ejecutarUnaQuery("select top 5 uss.username,sum(pub.stock) As Productos, vis.descripcion from DALE_SA.publicacion pub, DALE_SA.visibilidad vis, DALE_SA.usuario uss where pub.idusuario=uss.idusuario AND pub.idvisibilidad=vis.idvisibilidad AND (pub.estado=1 AND year(pub.fecha_inicio)=" + ano + ") AND (month(pub.fecha_inicio)=10 OR month(pub.fecha_inicio)=11 OR month(pub.fecha_inicio)=12) and pub.stock >0 AND pub.idvisibilidad=" + visibilidadid + "  group by uss.username, vis.descripcion order by 2 desc, 3 desc");
                    this.dataGridView1.DataSource = resultado;
                }
            }

            if (this.radioButton4.Checked)
            {

                mes = this.comboBox2.Text;
                key = getKey(mes);

                DataTable resultado;
                _conexionSQL conectarBD = _conexionSQL.Instance;
                //resultado = conectarBD.ejecutarUnaQuery("select distinct top 5 facturas.username, facturas.facturas from (select count(pub.idfactura) AS facturas, uss.username from DALE_SA.usuario uss, DALE_SA.publicacion pub where uss.idusuario=pub.idusuario AND pub.estado=1 AND YEAR(pub.fecha_inicio)="+ano+" AND (month(pub.fecha_inicio)="+key+") group by uss.username) facturas order by 2 desc");
                
                 resultado = conectarBD.ejecutarUnaQuery("select  TOP 5 VENDEDOR,count(*) as facturas from DALE_SA.vw_facturasAlVendedor vb  where YEAR(vb.fecha)="+ano+" and MONTH(vb.fecha)="+key+" group by VENDEDOR order by 2 desc" );
                
                this.dataGridView1.DataSource = resultado;
            }

            if (this.radioButton7.Checked)
            {

                 mes = this.comboBox2.Text;
                 mes = this.comboBox2.Text;
                 key = getKey(mes);

                DataTable resultado;
                _conexionSQL conectarBD = _conexionSQL.Instance;
                //resultado = conectarBD.ejecutarUnaQuery("select top 5 usu.username, sum(fac.total) AS Totales from DALE_SA.usuario usu, DALE_SA.factura fac, DALE_SA.publicacion pub where usu.idusuario=pub.idusuario and pub.idfactura=fac.idfactura and YEAR(pub.fecha_inicio)=" + ano + " and (month(pub.fecha_inicio)="+key+") group by usu.username having sum(fac.total)>0 order by 2 desc");
                resultado = conectarBD.ejecutarUnaQuery("select  TOP 5 VENDEDOR,sum(total) AS Totales  from DALE_SA.vw_facturasAlVendedor vb  where YEAR(vb.fecha)=" + ano + " and month(vb.fecha)=" + key + " group by VENDEDOR order by 2 desc ");
                this.dataGridView1.DataSource = resultado;
            }

            if (this.radioButton5.Checked)
            {

                mes = this.comboBox2.Text;
                mes = this.comboBox2.Text;
                key = getKey(mes);

                rub = this.comboBox1.Text;
                DataTable resultado0;
                _conexionSQL conectarBD0 = _conexionSQL.Instance;
                resultado0 = conectarBD0.ejecutarUnaQuery("select rub.idrubro  from DALE_SA.rubro rub where rub.descripcion_corta ='" + rub+"'");
                idRubro =  Int32.Parse(resultado0.Rows[0][0].ToString());

                if (trimestre == 1)
                {
                    DataTable resultado;
                    _conexionSQL conectarBD = _conexionSQL.Instance;
                    resultado = conectarBD.ejecutarUnaQuery("Select top 5 compras.username, compras.compras, compras.rubro from (select SUM(com.cantidad) AS compras, uss.username, rub.descripcion_corta as rubro from DALE_SA.compra com, DALE_SA.publicacion pub,DALE_SA.usuario uss,  DALE_SA.rubro rub where pub.idpublicacion = com.idpublicacion and pub.idrubro = rub.idrubro and pub.idrubro =" + idRubro + " and (year (com.fecha)=" + ano + " AND uss.idusuario=com.idusuario AND (month(com.fecha)=01 OR month(com.fecha)=02 OR month(com.fecha)=03)) group by uss.username, rub.descripcion_corta ) compras order by 2 desc");
                   
                    this.dataGridView1.DataSource = resultado;
                }
                if (trimestre == 2)
                {
                    DataTable resultado;
                    _conexionSQL conectarBD = _conexionSQL.Instance;
                    resultado = conectarBD.ejecutarUnaQuery("Select top 5 compras.username, compras.compras, compras.rubro from (select SUM(com.cantidad) AS compras, uss.username, rub.descripcion_corta as rubro from DALE_SA.compra com, DALE_SA.publicacion pub,DALE_SA.usuario uss,  DALE_SA.rubro rub where pub.idpublicacion = com.idpublicacion and pub.idrubro = rub.idrubro and pub.idrubro = " + idRubro + " and (year (com.fecha)=" + ano + " AND uss.idusuario=com.idusuario AND (month(com.fecha)=04 OR month(com.fecha)=05 OR month(com.fecha)=06)) group by uss.username, rub.descripcion_corta ) compras order by 2 desc");
                    this.dataGridView1.DataSource = resultado;
                }
                if (trimestre == 3)
                {
                    DataTable resultado;
                    _conexionSQL conectarBD = _conexionSQL.Instance;
                    resultado = conectarBD.ejecutarUnaQuery("Select top 5 compras.username, compras.compras, compras.rubro from (select SUM(com.cantidad) AS compras, uss.username, rub.descripcion_corta as rubro from DALE_SA.compra com, DALE_SA.publicacion pub,DALE_SA.usuario uss,  DALE_SA.rubro rub where pub.idpublicacion = com.idpublicacion and pub.idrubro = rub.idrubro and pub.idrubro = " + idRubro + " and (year (com.fecha)=" + ano + " AND uss.idusuario=com.idusuario AND (month(com.fecha)=07 OR month(com.fecha)=08 OR month(com.fecha)=09)) group by uss.username, rub.descripcion_corta) compras order by 2 desc");
                    this.dataGridView1.DataSource = resultado;
                }
                  if (trimestre == 4)
                {
                    DataTable resultado;
                    _conexionSQL conectarBD = _conexionSQL.Instance;
                    resultado = conectarBD.ejecutarUnaQuery("Select top 5 compras.username, compras.compras, compras.rubro from (select SUM(com.cantidad) AS compras, uss.username, rub.descripcion_corta as rubro from DALE_SA.compra com, DALE_SA.publicacion pub,DALE_SA.usuario uss,  DALE_SA.rubro rub where pub.idpublicacion = com.idpublicacion and pub.idrubro = rub.idrubro and pub.idrubro = " + idRubro + " and (year (com.fecha)=" + ano + " AND uss.idusuario=com.idusuario AND (month(com.fecha)=10 OR month(com.fecha)=11 OR month(com.fecha)=12)) group by uss.username, rub.descripcion_corta ) compras order by 2 desc");
                    this.dataGridView1.DataSource = resultado;
                }


            }


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            trimestre = 3;
            this.comboBox2.DataSource = null;
            this.comboBox3.DataSource = null;
            mesesElegidos.Clear();
            mesesElegidos.Add("Julio");
            mesesElegidos.Add("Agosto");
            mesesElegidos.Add("Septiembre");
            this.comboBox2.DataSource = mesesElegidos;
            this.comboBox3.DataSource = mesesElegidos;

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            trimestre = 4;
            this.comboBox2.DataSource = null;
            this.comboBox3.DataSource = null;
            mesesElegidos.Clear();
            mesesElegidos.Add("Octubre");
            mesesElegidos.Add("Noviembre");
            mesesElegidos.Add("Diciembre");
            this.comboBox2.DataSource = mesesElegidos;
            this.comboBox3.DataSource = mesesElegidos;

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.publicacionTableAdapter.Fill(this.gD1C2016DataSet2.publicacion);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.publicacionTableAdapter.FillBy(this.gD1C2016DataSet2.publicacion);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.publicacionTableAdapter.FillBy1(this.gD1C2016DataSet2.publicacion);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ano = Int32.Parse(this.textBox1.Text);
            }
            catch
            {
                ano = 0;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CBvis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
