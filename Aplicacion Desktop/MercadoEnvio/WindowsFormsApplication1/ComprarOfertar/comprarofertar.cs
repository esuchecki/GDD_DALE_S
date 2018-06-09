using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ComprarOfertar
{
    public partial class comprarofertar : Form
    {
        private string id;
        DateTime fechaHoraLocal = Properties.Settings.Default.FECHA_HORA_APP;       //con esto averigua la fechaHora local del sistema
        private publicar_dto dto;
        private int actualidx;
        private int totalidx;
        private int tamanoidx;
        private string filtrodescripcion;
        private string filtrorubros;
            public comprarofertar(string id)
        {
            InitializeComponent();
            this.id = id;
            this.dto = new publicar_dto();
            this.tamanoidx = 10;
            

            
        }

            private void comprarofertar_Load(object sender, EventArgs e)
            {
                // TODO: esta línea de código carga datos en la tabla 'rubrosBusqueda.rubro' Puede moverla o quitarla según sea necesario.
                this.rubroTableAdapter1.Fill(this.rubrosBusqueda.rubro);
                // TODO: esta línea de código carga datos en la tabla 'rubro.rubro' Puede moverla o quitarla según sea necesario.
                this.rubroTableAdapter.Fill(this.rubro.rubro);
                this.LBrubros.ClearSelected();
                //this.pr_buscar_productoTableAdapter.Fill(this.buscar_producto.pr_buscar_producto,1,100 ,id,"","");

            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    this.display.Enabled = true;
                    this.display.Visible = true;
                    DataGridViewRow fila = this.DGBuscar.Rows[e.RowIndex];
                    if (Convert.ToString(fila.Cells["tipo_publicacion"].Value).Equals("Compra Inmediata"))
                    {
                        this.Bcomprar.Enabled = true;
                        this.Bcomprar.Visible = true;
                        this.Bcomprar.Text = "Comprar";
                        this.Cantidad.Enabled = true;
                        this.Cantidad.Visible = true;
                        this.Cantidad.Minimum = 1;
                        this.Cantidad.Value = 1;
                        this.Cantidad.DecimalPlaces = 0;
                        
                        
                        this.Cantidad.Increment = 1;
                        this.Cantidad.Maximum = Convert.ToInt32(fila.Cells["DGstock"].Value);
                    }
                    else {
                        this.Bcomprar.Enabled = true;
                        this.Bcomprar.Visible = true;
                        this.Bcomprar.Text = "Ofertar";
                        this.Cantidad.Enabled = true;
                        this.Cantidad.Visible = true;
                        this.Cantidad.Minimum = Convert.ToDecimal(fila.Cells["DGprecio"].Value)+1;
                        this.Cantidad.Maximum = 99999999;
                        this.Cantidad.DecimalPlaces = 2;
                        this.Cantidad.Increment = Convert.ToDecimal(0.5);
                        this.Cantidad.Value = Convert.ToDecimal(fila.Cells["DGprecio"].Value)+1;
                        
                       
                    }
                   
                    String texto = "";
                    texto += @"Descripcion: " + Convert.ToString(fila.Cells["DGdescripcion"].Value) + System.Environment.NewLine;
                    texto += @"Stock: " + Convert.ToString(fila.Cells["DGstock"].Value) + System.Environment.NewLine;
                    
                    texto += @"Precio: " + Convert.ToString(fila.Cells["DGprecio"].Value) + System.Environment.NewLine;
                    texto += @"Vencimiento: " + Convert.ToString(fila.Cells["fecha_vencimiento"].Value) + System.Environment.NewLine;
                    texto += @"Rubro: " + Convert.ToString(fila.Cells["idrubro"].Value) + System.Environment.NewLine;
                    texto += @"Tipo: " + Convert.ToString(fila.Cells["tipo_publicacion"].Value) + System.Environment.NewLine;
                    texto += @"Preguntas: " + Convert.ToString(fila.Cells["permitir_preguntas"].Value) + System.Environment.NewLine;
                    if (fila.Cells["permitir_preguntas"].Value.Equals(true))
                    {
                        //this.pr_buscar_productoTableAdapter.Fill(this.buscar_producto.pr_buscar_producto, 1, 5, id, "", "");
                        this.DGpreguntas.Visible = true;
                        this.DGpreguntas.Enabled = true;
                        this.preguntar.Visible = true;
                        this.preguntar.Enabled = true;
                        this.textBoxpreguntas.Visible = true;
                        this.textBoxpreguntas.Enabled = true;
                        this.label3.Visible = true;
                        this.label3.Enabled = true;
                        this.pr_preguntasTableAdapter.Fill(this.preguntas.pr_preguntas, Convert.ToString(fila.Cells["idpublicacion"].Value));
                    }
                    else {
                        this.DGpreguntas.Visible = false;
                        this.DGpreguntas.Enabled = false;
                        this.preguntar.Visible = false;
                        this.preguntar.Enabled = false;
                        this.textBoxpreguntas.Visible = false;
                        this.textBoxpreguntas.Enabled = false;
                        this.label3.Visible = false;
                        this.label3.Enabled = false;
                    }
                    
                    texto += @"Envio: " + Convert.ToString(fila.Cells["permitir_envio"].Value) + System.Environment.NewLine;
                    if (Convert.ToString(fila.Cells["permitir_envio"].Value).Equals("True"))
                    {
                        this.CBEnvio.Visible = true;
                        this.CBEnvio.Enabled = true;
                    }
                    else
                    {
                        this.CBEnvio.Visible = false;
                        this.CBEnvio.Enabled = false;
                    }

                    texto += @"PublicionId: " + Convert.ToString(fila.Cells["idpublicacion"].Value) + System.Environment.NewLine;
                    texto += @"Vendedor: " + Convert.ToString(fila.Cells["idusuario"].Value);
                    this.TBdescripcion.Text = texto;
                    
                          
                    dto.setidusuario(id);
                    dto.setidpublicacion(Convert.ToString(fila.Cells["idpublicacion"].Value));
                   
                     dto.setfechasys(this.fechaHoraLocal);
                    
                    //
                     dto.setprecio(Convert.ToString(fila.Cells["DGprecio"].Value));
                }
            }

            private void Bcomprar_Click(object sender, EventArgs e)
            {
                int d = this.DGBuscar.CurrentCell.RowIndex;
                DataGridViewRow row = this.DGBuscar.Rows[d];
                //se supone que en la columna nº 0 esta el stock
                if (String.Compare(row.Cells[0].Value.ToString(), "0") == 0)
                {
                    MessageBox.Show("La publicacion se quedo sin stock. Aguarde a que lo repongan.");
                    return;
                }
                
                
                _conexionSQL conectarBD = _conexionSQL.Instance;
                Boolean retorno = false;
                DataTable resultado2 = new DataTable();
                string sql;
                // comienzo....
                sql = @"select count(com.idcompra)
                        from DALE_SA.compra com
                        where com.idUsuario = " + dto.getidusuario() + @"
                            and	not exists (select *
							                    from DALE_SA.calificacion cal
											    where cal.idcompra=com.idcompra)
                        ";

                resultado2 = conectarBD.ejecutarUnaQuery(sql);
                if (Int32.Parse(resultado2.Rows[0][0].ToString())> 3) 
                {
                    MessageBox.Show("Tiene mas de tres compras sin calificar, complete esto para operar");
                    return;
                }


                if (CBEnvio.Checked == true) dto.setenvio("1");
                else dto.setenvio("0");

               


                if (Bcomprar.Text.Equals("Comprar"))
                {
                    dto.setstock(Cantidad.Value.ToString());
                    retorno = conectarBD.comprar(dto);
                }

                else
                {
                    dto.setprecio(Cantidad.Value.ToString());
                    retorno = conectarBD.ofertar(dto);
                }




                if (retorno == true && Bcomprar.Text.Equals("Comprar"))
                {
                    MessageBox.Show("Compra exitosa");
                    this.Dispose();

                }
                else if (retorno == false && Bcomprar.Text.Equals("Comprar")) { MessageBox.Show("Problemas con la base de datos"); }




                if (retorno == true && Bcomprar.Text.Equals("Ofertar"))
                {
                    MessageBox.Show("Oferta exitosa");
                    this.Dispose();

                }
                else if (retorno == false && Bcomprar.Text.Equals("Ofertar")) { MessageBox.Show("Problemas con la base de datos"); }


            }

            private void TBdescripcion_TextChanged(object sender, EventArgs e)
            {

            }

            private void DGBuscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {
                this.filtrorubros = "";
                this.filtrodescripcion = "";
                int cantrubros = LBrubros.SelectedItems.Count;
                foreach (DataRowView r in this.LBrubros.SelectedItems)
                {
                   
                     
                     this.filtrorubros += r.Row[0].ToString();
                    cantrubros--;
                    if (!cantrubros.Equals(0)) this.filtrorubros += ',';
                }
               // MessageBox.Show("Rurbo ids: "+this.filtrorubros);
                this.filtrodescripcion = this.TBbuscardesc.Text;
               this.pr_buscar_productoTableAdapter.Fill(this.buscar_producto.pr_buscar_producto, 1, this.tamanoidx, id, this.filtrodescripcion, this.filtrorubros);
               this.display.Enabled = false;
               this.display.Visible = false;
                
                DataGridViewRow fila;
              
                if (this.DGBuscar.RowCount > 0)
                {
                    fila = this.DGBuscar.Rows[0];
                    this.Total.Text = Convert.ToString(fila.Cells["paginas"].Value);
                    this.totalidx = Int32.Parse(fila.Cells["paginas"].Value.ToString());
                    this.actual.Text = "1";
                    this.actualidx = 1;
                    this.botonespaginas.Enabled = true;
                    this.botonespaginas.Visible = true;
                    

                }
                else
                {
                    MessageBox.Show("No hay registro con esos filtros");
                    this.botonespaginas.Visible = false;
                    this.botonespaginas.Enabled = false;
                }
                this.LBrubros.ClearSelected();
                this.TBbuscardesc.Clear();
               
            }

            private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void buttonprimera_Click(object sender, EventArgs e)
            {
                this.display.Enabled = false;
                this.display.Visible = false;
                this.actual.Text = "1";
                this.actualidx = 1;
                this.pr_buscar_productoTableAdapter.Fill(this.buscar_producto.pr_buscar_producto, this.actualidx, this.tamanoidx, id, this.filtrodescripcion, this.filtrorubros);
            }

            private void buttonultima_Click(object sender, EventArgs e)
            {
                this.display.Enabled = false;
                this.display.Visible = false;
                this.actual.Text = this.Total.Text;
                this.actualidx = this.totalidx;
                this.pr_buscar_productoTableAdapter.Fill(this.buscar_producto.pr_buscar_producto, this.actualidx, this.tamanoidx, id, this.filtrodescripcion, this.filtrorubros);
            }

            private void buttonanterior_Click(object sender, EventArgs e)
            {
                if (this.actualidx > 1)
                {
                    this.display.Enabled = false;
                    this.display.Visible = false;
                    this.actualidx--;
                    this.actual.Text = this.actualidx.ToString();
                    this.pr_buscar_productoTableAdapter.Fill(this.buscar_producto.pr_buscar_producto, this.actualidx, this.tamanoidx, id, this.filtrodescripcion, this.filtrorubros);
                } 
            }

            private void buttonsiguiente_Click(object sender, EventArgs e)
            {
                if (this.actualidx < this.totalidx)
                {
                    this.display.Enabled = false;
                    this.display.Visible = false;
                    this.actualidx++;
                    this.actual.Text = this.actualidx.ToString();
                    this.pr_buscar_productoTableAdapter.Fill(this.buscar_producto.pr_buscar_producto, this.actualidx, this.tamanoidx, id, this.filtrodescripcion,this.filtrorubros);
                }
            }

            private void DGpreguntas_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void display_Paint(object sender, PaintEventArgs e)
            {

            }

            private void preguntar_Click(object sender, EventArgs e)
            {
                _conexionSQL conectarBD = _conexionSQL.Instance;
            
                
                
                DataTable resultado2 = new DataTable();
                string sql;
                if (this.textBoxpreguntas.TextLength == 0)
                {
                    MessageBox.Show("No pregunta no puede ser vacia");
                    return;
                }
                sql = @"INSERT INTO [DALE_SA].[preguntas]
           ([idpublicacion]
           ,[pregunta])
     VALUES
           ("+dto.getidpubliacion()+",'"
           +this.textBoxpreguntas.Text+@"')";
                
                resultado2 = conectarBD.ejecutarUnaQuery(sql);
                if (resultado2==null) {MessageBox.Show("Problemas con la consulta, revise su conexion");}
                else {
                    this.textBoxpreguntas.Clear();
                    this.pr_preguntasTableAdapter.Fill(this.preguntas.pr_preguntas, dto.getidpubliacion()); 
                }
            }

     
    }
}
