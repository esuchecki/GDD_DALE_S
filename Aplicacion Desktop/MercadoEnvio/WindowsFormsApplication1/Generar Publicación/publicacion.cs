using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Generar_Publicación
{
    public partial class publicacion : Form
    {
        private string id;
        
        public publicacion(string id)
        {
            this.id = id;
            InitializeComponent();
            DateTime fechaHoraLocal = Properties.Settings.Default.FECHA_HORA_APP;       //con esto averigua la fechaHora local del sistema
            this.incio.Value = fechaHoraLocal;
            this.fin.Value = fechaHoraLocal;

        }

        private void publicacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'estado.estado_publicacion' Puede moverla o quitarla según sea necesario.
            this.estado_publicacionTableAdapter.Fill(this.estado.estado_publicacion);
            // TODO: esta línea de código carga datos en la tabla 'gD1C2016DataSet1.rubro' Puede moverla o quitarla según sea necesario.
            this.rubroTableAdapter.Fill(this.gD1C2016DataSet1.rubro);
            // TODO: esta línea de código carga datos en la tabla 'visibikidad.visibilidad' Puede moverla o quitarla según sea necesario.
            this.visibilidadTableAdapter.Fill(this.visibikidad.visibilidad);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime myDate = this.incio.Value.Date; //+
                        //dTimePiker_HoraNueva.Value.TimeOfDay;
            if (this.Tdescripcon.TextLength == 0)
            {
                MessageBox.Show("La descripcion no puede ser vacia");
                return;
            }

            
            
            
            if ((DateTime.Compare(myDate, ((DateTime)Properties.Settings.Default.FECHA_HORA_APP).Date )) < 0)
            {
                MessageBox.Show("No se puede settear una fecha de publicacion anterior a la actual.");
                return;
            }

            DateTime myDate2 = this.fin.Value.Date; //+
            //dTimePiker_HoraNueva.Value.TimeOfDay;

            if ( (DateTime.Compare(myDate, myDate2) ) >= 0)
            {
                MessageBox.Show("La publicacion minima es de 1 dia.");
                return;
            }
            
            string datos = "";  
           
            datos += @"Estado: "+this.Cestado.SelectedValue.ToString();
            datos += @"Rubro: " + this.Crubro.SelectedValue.ToString();
            if (this.RBCompraInmediata.Checked == true) datos += @"Tipo: Compra Inmediata";
            else datos += @"Tipo: Subasta";
            if (preguntas.Checked == true) datos += @"Preguntas: 1";
            else datos += @"Preguntas: 0";
            datos += @"Stock: " + this.NUstock.Value.ToString() ;
            datos += @"Precio: " + this.NUprecio.Value.ToString();
            datos += @"Inicio: " + this.incio.Value.Date.ToString();
            datos += @"Fin: " + this.fin.Value.Date.ToString();
            

            publicar_dto dto=new publicar_dto();

            
            dto.setestado(this.Cestado.SelectedValue.ToString());
            dto.setidrubro(this.Crubro.SelectedValue.ToString());
            
            if (this.RBCompraInmediata.Checked == true) dto.settipo_publicacion("Compra Inmediata");
            else dto.settipo_publicacion("Subasta");
            
            if (preguntas.Checked == true) dto.setpermitir_preguntas("1");
            else dto.setpermitir_preguntas("0");

            if (CBenvio.Checked == true) dto.setenvio("1");
            else dto.setenvio("0");

            if (this.Cvisibilidad.Items.Count > 0)
            { dto.setidvisibilidad(this.Cvisibilidad.SelectedValue.ToString()); }
            else
            {
                MessageBox.Show("No hay visibilidades, consulte a su administrador, no se podra publicar");
                return;
            } 
            
            dto.setstock(this.NUstock.Value.ToString());
            dto.setprecio(this.NUprecio.Value.ToString());
            dto.setcosto(this.NUprecio.Value.ToString());
                 
           // MessageBox.Show("Precio "+dto.getprecio());
            dto.setfecha_inicio(this.incio.Value.Date);
           // MessageBox.Show("Fecha I " + dto.getfecha_inicio());
            dto.setfecha_vencimiento(this.fin.Value.Date);
           // MessageBox.Show("Fecha V " + dto.getfecha_vencimiento());
            
            dto.setdescp(this.Tdescripcon.Text.ToString());
            dto.setidusuario(this.id);
            _conexionSQL conectarBD = _conexionSQL.Instance;
            Boolean retorno = conectarBD.publicar(dto);
            if (retorno == true) { MessageBox.Show("Publicacion exitosa");
            //this.Tdescripcon.Text += datos;
            }
            else { MessageBox.Show("Problemas con la base de datos"); }
        }

        private void RBSubasta_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RBSubasta.Checked == false)
            {
               

                
            }
            this.NUstock.Enabled = false;
            this.NUstock.Visible = false;
            this.NUstock.Value = 1;
 


        }

        private void RBCompraInmediata_CheckedChanged(object sender, EventArgs e)
        {
            this.NUstock.Enabled = true;
            this.NUstock.Visible = true;
            
        }

        
       
       

        

       
    }
}
