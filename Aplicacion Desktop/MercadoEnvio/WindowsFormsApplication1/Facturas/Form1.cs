using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Facturas
{
    public partial class Form1 : Form
    {

        string pagSize = "10";
        
        
        public Form1()
        {
            InitializeComponent();

            this.txtMontoFinal.Text = "";
            this.txtMontoInicial.Text = "";
            this.txtUsername.Text = "";
            this.dgvResultados.DataSource = null;
            this.checkFecha.Checked = true;
            this.checkFecha.Checked = false;

        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            this.txtMontoFinal.Text = "";
            this.txtMontoInicial.Text = "";
            this.txtUsername.Text = "";
            this.dgvResultados.DataSource = null;
            this.checkFecha.Checked = false;

            this.actual.Text = "0";
            this.botonespaginas.Enabled = false;
            this.botonespaginas.Visible = false;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.txtMontoInicial.Text))
            {
                if (!(System.Text.RegularExpressions.Regex.IsMatch(this.txtMontoInicial.Text, "[ ^0-9]")))
                {
                    MessageBox.Show("Por favor revise que en el monto inicial ingresado solamente numeros");
                    return;
                }
            }

            if (!String.IsNullOrWhiteSpace(this.txtMontoFinal.Text))
            {
                if (!(System.Text.RegularExpressions.Regex.IsMatch(this.txtMontoFinal.Text, "[ ^0-9]")))
                {
                    MessageBox.Show("Por favor revise que en el monto final ingresado solamente numeros");
                    return;
                }
            }


            if ((!String.IsNullOrWhiteSpace(this.txtMontoInicial.Text)) && (String.IsNullOrWhiteSpace(this.txtMontoFinal.Text)))
            {
                MessageBox.Show("Por favor revise que haya ingresado un rango en los montos.");
                return;
            }

            if ((String.IsNullOrWhiteSpace(this.txtMontoInicial.Text)) && (!String.IsNullOrWhiteSpace(this.txtMontoFinal.Text)))
            {
                MessageBox.Show("Por favor revise que haya ingresado un rango en los montos.");
                return;
            }

            if (!String.IsNullOrWhiteSpace(this.txtUsername.Text))
            {
                //if (!System.Text.RegularExpressions.Regex.IsMatch(this.txtBuscEmpRazonSocial.Text, "^[a-zA-Z]", System.Text.RegularExpressions.RegexOptions.IgnorePatternWhitespace))
                if (!this.txtUsername.Text.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == 'º' || c == ':' || Char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("En el nombre de usuario solo se pueden ingresar nombres del abecedario");
                    return;
                }
            }

            if( this.checkFecha.Checked ==true)
            {
                if ( (DateTime.Compare(this.dtp_FechaInicial.Value.Date, this.dtpFechaFinal.Value.Date) > 0) )
                {
                    MessageBox.Show("Revise el intervalo de fechas. ");
                    return;
                }
            }

            DataTable resultado2 = new DataTable();
            _conexionSQL conectarBD = _conexionSQL.Instance;



            string sql;
            // comienzo....
            if( this.checkFecha.Checked ==true)
            {
            sql = @"EXEC [DALE_SA].prConsultarFacturasAVendedores 
                            '" + this.txtUsername.Text + @"',
                            '" + this.txtMontoInicial.Text + @"',
                            '" + this.txtMontoFinal.Text + @"',
                            '" + this.dtp_FechaInicial.Value.Date.ToString("yyyy/MM/dd hh:mm:ss") + @"',
                            '" + this.dtpFechaFinal.Value.Date.ToString("yyyy/MM/dd hh:mm:ss") + @"'
                            ,0," + pagSize + @"
                        ";
            }
            else
            {
            sql = @"EXEC [DALE_SA].prConsultarFacturasAVendedores 
                            '" + this.txtUsername.Text + @"',
                            '" + this.txtMontoInicial.Text + @"',
                            '" + this.txtMontoFinal.Text + @"',
                            '" + "" + @"',
                            '" + "" + @"'
                            ,0," + pagSize + @"
                        ";
            }

            resultado2 = conectarBD.ejecutarUnaQuery(sql);
            this.dgvResultados.DataSource = resultado2;
            
            //comienzo del codigo para paginar..

            //DataGridViewRow fila;
            if (this.dgvResultados.RowCount > 0)
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
                if (this.checkFecha.Checked == true)
                {
                    sql = @"EXEC [DALE_SA].prConsultarFacturasAVendedores 
                            '" + this.txtUsername.Text + @"',
                            '" + this.txtMontoInicial.Text + @"',
                            '" + this.txtMontoFinal.Text + @"',
                            '" + this.dtp_FechaInicial.Value.Date.ToString("yyyy/MM/dd hh:mm:ss") + @"',
                            '" + this.dtpFechaFinal.Value.Date.ToString("yyyy/MM/dd hh:mm:ss") + @"'
                            ," + temporal + @"," + pagSize + @"
                        ";
                }
                else
                {
                    sql = @"EXEC [DALE_SA].prConsultarFacturasAVendedores 
                            '" + this.txtUsername.Text + @"',
                            '" + this.txtMontoInicial.Text + @"',
                            '" + this.txtMontoFinal.Text + @"',
                            '" + "" + @"',
                            '" + "" + @"'
                            ," + temporal + @"," + pagSize + @"
                        ";
                }

                resultado3 = conectarBD.ejecutarUnaQuery(sql);
                if (resultado3 != null)
                {
                    if (resultado3.Rows.Count > 0)
                        this.buttonsiguiente.Enabled = true;
                }



            }


        }

        private void checkFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkFecha.Checked == true)
            {
                this.dtp_FechaInicial.Enabled = true;
                this.dtpFechaFinal.Enabled = true;
            }
            else
            {
                this.dtp_FechaInicial.Enabled = false;
                this.dtpFechaFinal.Enabled = false;
            }
        }

        private void buttonsiguiente_Click(object sender, EventArgs e)
        {
            DataTable resultado2 = new DataTable();
            _conexionSQL conectarBD = _conexionSQL.Instance;

            //if (this.Total.Text ...comparar con actual
            this.actual.Text = ( (Convert.ToInt16(this.actual.Text) ) + (Convert.ToInt16(pagSize)) ).ToString();


            string sql;
            // comienzo....
            if (this.checkFecha.Checked == true)
            {
                sql = @"EXEC [DALE_SA].prConsultarFacturasAVendedores 
                            '" + this.txtUsername.Text + @"',
                            '" + this.txtMontoInicial.Text + @"',
                            '" + this.txtMontoFinal.Text + @"',
                            '" + this.dtp_FechaInicial.Value.Date.ToString("yyyy/MM/dd hh:mm:ss") + @"',
                            '" + this.dtpFechaFinal.Value.Date.ToString("yyyy/MM/dd hh:mm:ss") + @"'
                            ," + this.actual.Text + @"," + pagSize + @"
                        ";
            }
            else
            {
                sql = @"EXEC [DALE_SA].prConsultarFacturasAVendedores 
                            '" + this.txtUsername.Text + @"',
                            '" + this.txtMontoInicial.Text + @"',
                            '" + this.txtMontoFinal.Text + @"',
                            '" + "" + @"',
                            '" + "" + @"'
                            ," + this.actual.Text + @"," + pagSize + @"
                        ";
            }

            resultado2 = conectarBD.ejecutarUnaQuery(sql);
            this.dgvResultados.DataSource = resultado2;

            this.buttonanterior.Enabled = true;
            


            //repito el proceso y reviso si hay +....
            this.buttonsiguiente.Enabled = false;
            DataTable resultado3 = new DataTable();
            string temporal;
            temporal = ((Convert.ToInt16(this.actual.Text)) + (Convert.ToInt16(pagSize))).ToString();
            if (this.checkFecha.Checked == true)
            {
                sql = @"EXEC [DALE_SA].prConsultarFacturasAVendedores 
                            '" + this.txtUsername.Text + @"',
                            '" + this.txtMontoInicial.Text + @"',
                            '" + this.txtMontoFinal.Text + @"',
                            '" + this.dtp_FechaInicial.Value.Date.ToString("yyyy/MM/dd hh:mm:ss") + @"',
                            '" + this.dtpFechaFinal.Value.Date.ToString("yyyy/MM/dd hh:mm:ss") + @"'
                            ," + temporal + @"," + pagSize + @"
                        ";
            }
            else
            {
                sql = @"EXEC [DALE_SA].prConsultarFacturasAVendedores 
                            '" + this.txtUsername.Text + @"',
                            '" + this.txtMontoInicial.Text + @"',
                            '" + this.txtMontoFinal.Text + @"',
                            '" + "" + @"',
                            '" + "" + @"'
                            ," + temporal + @"," + pagSize + @"
                        ";
            }


            resultado3 = conectarBD.ejecutarUnaQuery(sql);
            if (resultado3 != null)
            {
                if (resultado3.Rows.Count > 0)
                    this.buttonsiguiente.Enabled = true;
            }
        }

        private void buttonanterior_Click(object sender, EventArgs e)
        {
            DataTable resultado2 = new DataTable();
            _conexionSQL conectarBD = _conexionSQL.Instance;

            //if (this.Total.Text ...comparar con actual
            this.actual.Text = ((Convert.ToInt16(this.actual.Text)) - (Convert.ToInt16(pagSize))).ToString();


            string sql;
            // comienzo....
            if (this.checkFecha.Checked == true)
            {
                sql = @"EXEC [DALE_SA].prConsultarFacturasAVendedores 
                            '" + this.txtUsername.Text + @"',
                            '" + this.txtMontoInicial.Text + @"',
                            '" + this.txtMontoFinal.Text + @"',
                            '" + this.dtp_FechaInicial.Value.Date.ToString("yyyy/MM/dd hh:mm:ss") + @"',
                            '" + this.dtpFechaFinal.Value.Date.ToString("yyyy/MM/dd hh:mm:ss") + @"'
                            ," + this.actual.Text + @"," + pagSize + @"
                        ";
            }
            else
            {
                sql = @"EXEC [DALE_SA].prConsultarFacturasAVendedores 
                            '" + this.txtUsername.Text + @"',
                            '" + this.txtMontoInicial.Text + @"',
                            '" + this.txtMontoFinal.Text + @"',
                            '" + "" + @"',
                            '" + "" + @"'
                            ," + this.actual.Text + @"," + pagSize + @"
                        ";
            }

            resultado2 = conectarBD.ejecutarUnaQuery(sql);
            this.dgvResultados.DataSource = resultado2;

            this.buttonsiguiente.Enabled = true;
            if (string.Compare(this.actual.Text, "0") == 0)
                this.buttonanterior.Enabled = false;
        }














    }
}
