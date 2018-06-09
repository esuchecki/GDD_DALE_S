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
    public partial class Calificaciones : Form
    {
        public Calificaciones(string idPublicacion, bool yaCalificado, string idCompra)
        {
            InitializeComponent();
            this.txtIdPublicacion.Text = idPublicacion;

            if (yaCalificado)
            {
                // ya se califico
                this.btCalificar.Enabled = false;
                this.btCalificar.Visible = false;
                this.btCancelar.Enabled = true;
                this.btCancelar.Visible = true;

                this.txtDesc.ReadOnly = true;
                this.txtDesc.Enabled = false;
                this.combEstrellas.Enabled = false;

                if (idCompra == null)    //es una subasta
                {
                    DataTable resultado2 = new DataTable();
                    _conexionSQL conectarBD = _conexionSQL.Instance;

                    string sql;
                    sql = @"  select t1.cantidad_estrella, t1.descripcion
                                  from DALE_SA.calificacion t1, DALE_SA.compra t2
                                  where 
                                  t2.idcompra = t1.idcompra 
                                  and
                                  t2.idpublicacion = " + idPublicacion + @"
                        ";

                    resultado2 = conectarBD.ejecutarUnaQuery(sql);

                    this.combEstrellas.SelectedIndex = (Convert.ToInt16(resultado2.Rows[0][0])) - 1;
                    this.txtDesc.Text = resultado2.Rows[0][1].ToString();                 
                }
                if (idCompra != null)    //es una compra inmediata
                {
                    DataTable resultado2 = new DataTable();
                    _conexionSQL conectarBD = _conexionSQL.Instance;

                    string sql;
                    sql = @"  select t1.cantidad_estrella, t1.descripcion
                                  from DALE_SA.calificacion t1, DALE_SA.compra t2
                                  where 
                                  t2.idcompra = t1.idcompra 
                                  and
                                  t2.idpublicacion = " + idPublicacion + @"
                                  and
                                  t2.idcompra = " + idCompra + @"
                        ";

                    resultado2 = conectarBD.ejecutarUnaQuery(sql);

                    this.combEstrellas.SelectedIndex = (Convert.ToInt16(resultado2.Rows[0][0]))-1;
                    this.txtDesc.Text = resultado2.Rows[0][1].ToString();
                }


                
            }
            else
            {
                // no se califico
                this.btCalificar.Enabled = true;
                this.btCalificar.Visible = true;
                this.btCancelar.Enabled = true;
                this.btCancelar.Visible = true;

                this.txtDesc.ReadOnly = false;
                this.txtDesc.Enabled = true;
                this.combEstrellas.Enabled = true;
                this.txtDesc.Text = "";

                if (idCompra == null)    //es una subasta
                    this.txtEsCompraDirecta.Text = "0";
                else
                    this.txtEsCompraDirecta.Text = "1";

                if (idCompra != null)    //es una compra directa
                    this.txtIdCompra.Text = idCompra;

            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btCalificar_Click(object sender, EventArgs e)
        {
            if (String.Compare(this.txtDesc.Text, "") != 0)
            {
                if ((!this.txtDesc.Text.All(c => Char.IsLetterOrDigit(c) || c == ' ' || Char.IsWhiteSpace(c))))
                {
                    MessageBox.Show("La descripcion puede ir vacia, o solo con letras del abecedario y numeros..");
                    return;
                }
            }

            /*
            if (this.combEstrellas.SelectedValue == null)
            {
                MessageBox.Show("Por favor califique de 1 a 5 estrellas..");
                return;
            }*/

            if (!((String.Compare(this.combEstrellas.SelectedIndex.ToString(), "0") == 0) || (String.Compare(this.combEstrellas.SelectedIndex.ToString(), "1") == 0) || (String.Compare(this.combEstrellas.SelectedIndex.ToString(), "2") == 0) || (String.Compare(this.combEstrellas.SelectedIndex.ToString(), "3") == 0) || (String.Compare(this.combEstrellas.SelectedIndex.ToString(), "4") == 0)))
            {
                MessageBox.Show("Por favor califique de 1 a 5 estrellas..");
                return;
            }
            
            DataTable resultado2 = new DataTable();
            _conexionSQL conectarBD = _conexionSQL.Instance;
            string sql;

            if (String.Compare(this.txtEsCompraDirecta.Text, "0")==0)   //es una subasta
            {


                sql = @"EXEC DALE_SA.pr_CalificarSubasta 
                            '" + this.txtIdPublicacion.Text + @"',
                            '" + this.txtIdCompra.Text + @"',
                            '" + ((this.combEstrellas.SelectedIndex)+1).ToString() + @"',
                            '" + this.txtDesc.Text + @"'
                        ";
                resultado2 = conectarBD.ejecutarUnaQuery(sql);
                if (resultado2 != null)
                {
                    //if (resultado2.Rows[0][0].Equals(1))
                    //{
                        MessageBox.Show("Calificacion Exitosa");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("No se pudo calificar.. reintente");
                    //    return;
                    //}
                }
                else
                {
                    MessageBox.Show("No se pudo calificar.. reintente");
                    return;
                }

            }

            if (String.Compare(this.txtEsCompraDirecta.Text, "1") == 0)   //es compra directa
            {


                sql = @"EXEC DALE_SA.pr_CalificarCompraInmediata
                            '" + this.txtIdPublicacion.Text + @"',
                            '" + this.txtIdCompra.Text + @"',
                            '" + ((this.combEstrellas.SelectedIndex) + 1).ToString() + @"',
                            '" + this.txtDesc.Text + @"'
                        ";
                resultado2 = conectarBD.ejecutarUnaQuery(sql);
                if (resultado2 != null)
                {
                    //if (resultado2.Rows[0][0].Equals(1))
                    //{
                        MessageBox.Show("Calificacion Exitosa");
                    //}
                    //else
                    //{
                     //   MessageBox.Show("No se pudo calificar.. reintente");
                     //   return;
                    //}
                }
                else
                {
                    MessageBox.Show("No se pudo calificar.. reintente");
                    return;
                }
            }


            //elimino los formularios abiertos de historial de cliente y lo actualizo..
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Text == "Mi Historial de Compras")
                    Application.OpenForms[i].Close();
            }

            WindowsFormsApplication1.Historial_Cliente.Form1 frm = new WindowsFormsApplication1.Historial_Cliente.Form1( resultado2.Rows[0][0].ToString() , true);
            frm.Show();
            this.btCancelar.PerformClick(); //salimos...

        }
    }
}
