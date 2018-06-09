using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Usuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.rbtBuscarClientes.Checked = true;  //por defecto muestra la busqueda de clientes.
            this.rbtBuscarEmpresas.Checked = false;
            this.txtBuscClieApellido.Text = "";
            this.txtBuscClieDNI.Text = "";
            this.txtBuscClieEMAIL.Text = "";
            this.txtBuscClieNombre.Text = "";
            this.txtBuscEmpCuit.Text = "";
            this.txtBuscEmpEmail.Text = "";
            this.txtBuscEmpRazonSocial.Text = "";

            this.gboxEmpresas.Visible = false;
            this.gboxEmpresas.Enabled = false;
            this.gboxClientes.Visible = true;
            this.gboxClientes.Enabled = true;
            this.cambiarMenuContextual(false);   //deshabilito las opciones

            this.gboxCrearModificarUsuario.Enabled = false;
            this.gboxCrearModificarUsuario.Visible = false;


        }

        private void rbtBuscarClientes_CheckedChanged(object sender, EventArgs e)
        {
                this.gboxEmpresas.Visible = false;
                this.gboxEmpresas.Enabled = false;
                this.gboxClientes.Visible = true;
                this.gboxClientes.Enabled = true;
                this.btLimpiar.PerformClick();
        }

        private void rbtBuscarEmpresas_CheckedChanged(object sender, EventArgs e)
        {
                this.gboxEmpresas.Visible = true;
                this.gboxEmpresas.Enabled = true;
                this.gboxClientes.Visible = false;
                this.gboxClientes.Enabled = false;
                this.btLimpiar.PerformClick();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            this.txtBuscClieApellido.Text = "";
            this.txtBuscClieDNI.Text = "";
            this.txtBuscClieEMAIL.Text = "";
            this.txtBuscClieNombre.Text = "";
            this.txtBuscEmpCuit.Text = "";
            this.txtBuscEmpEmail.Text = "";
            this.txtBuscEmpRazonSocial.Text = "";

            this.dgvResultados.DataSource = null;
            this.cambiarMenuContextual(false);   //deshabilito las opciones
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (this.rbtBuscarClientes.Checked == false && this.rbtBuscarEmpresas.Checked == false)
            {
                MessageBox.Show("Por favor seleccione si va a buscar un cliente o una empresa ");
                return;
            }


            if(this.rbtBuscarClientes.Checked == true)
            {
                if (!String.IsNullOrWhiteSpace(this.txtBuscClieDNI.Text))
                {
                    if (!(System.Text.RegularExpressions.Regex.IsMatch(this.txtBuscClieDNI.Text, @"[ ^ 0-9]")))
                    {
                        MessageBox.Show("Por favor revise que el DNI haya ingresado solamente numeros");
                        return;
                    }
                }


                if ( !String.IsNullOrWhiteSpace(this.txtBuscClieApellido.Text) )
                {
                    //if (!(System.Text.RegularExpressions.Regex.IsMatch(this.txtBuscClieApellido.Text, @"(^([\\s]*|[ ]*|[a-z]*|[A-Z]*|[0-9]*|[\\s]*|[ ]*)$)|(^(?!\s*$).*)|(^[\\w\\s]*$)")))
                    if (!this.txtBuscClieApellido.Text.All(c => Char.IsLetterOrDigit(c) || c == ' ' || Char.IsWhiteSpace(c)))
                    {
                        MessageBox.Show("En el apellido solo se pueden ingresar letras del abecedario");
                        return;
                    }
                }

                if (!String.IsNullOrWhiteSpace(this.txtBuscClieNombre.Text))
                {
                    //if (!(System.Text.RegularExpressions.Regex.IsMatch(this.txtBuscClieNombre.Text, @"^[a-zA-Z\\s]", System.Text.RegularExpressions.RegexOptions.IgnorePatternWhitespace)))
                    if (!this.txtBuscClieNombre.Text.All(c => Char.IsLetterOrDigit(c) || c == ' ' || Char.IsWhiteSpace(c)))
                    {
                        MessageBox.Show("En el nombre solo se pueden ingresar letras del abecedario");
                        return;
                    }
                }

                /*regex for email:
                 * "^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@)) 
                    (?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,24}))$"
                 */
                if (!String.IsNullOrWhiteSpace(this.txtBuscClieEMAIL.Text))
                {
                    /* este metodo sirve para cuando se crea el email que lo valide...
                    try
                    {
                        var test = new System.Net.Mail.MailAddress(this.txtBuscClieEMAIL.Text);
                    }
                    catch (FormatException ex)
                    {
                        // wrong format for email
                        MessageBox.Show("Revise si ingreso un e-mail valido por favor");
                        return;
                    }
                     */

                    if (!this.txtBuscClieEMAIL.Text.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == '@' || c == '.' || Char.IsWhiteSpace(c)))
                    {
                        MessageBox.Show("En la razon social solo se pueden ingresar letras del abecedario");
                        return;
                    }
                }

                //llamar a la BD CLIENTE

                //cargamos los datos actuales en la tabla
                DataTable resultado = new DataTable(); ;
                _conexionSQL conectarBD = _conexionSQL.Instance;
                conectarBD.prConsultaUsuarioCliente(this.txtBuscClieNombre.Text, this.txtBuscClieApellido.Text, this.txtBuscClieEMAIL.Text, this.txtBuscClieDNI.Text, ref resultado);
                this.dgvResultados.DataSource = resultado;
                
            }

            if (this.rbtBuscarEmpresas.Checked == true)
            {
                if (!String.IsNullOrWhiteSpace(this.txtBuscEmpCuit.Text))
                {
                    if (!(System.Text.RegularExpressions.Regex.IsMatch(this.txtBuscEmpCuit.Text, "[ ^ 0-9-]", System.Text.RegularExpressions.RegexOptions.IgnorePatternWhitespace)))
                    {
                        MessageBox.Show("Por favor revise que el CUIT haya ingresado solamente numeros");
                        return;
                    }
                }

                if (!String.IsNullOrWhiteSpace(this.txtBuscEmpRazonSocial.Text))
                {
                    //if (!System.Text.RegularExpressions.Regex.IsMatch(this.txtBuscEmpRazonSocial.Text, "^[a-zA-Z]", System.Text.RegularExpressions.RegexOptions.IgnorePatternWhitespace))
                    if (!this.txtBuscEmpRazonSocial.Text.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == 'º' || c == ':'|| Char.IsWhiteSpace(c)))
                    {
                        MessageBox.Show("En la razon social solo se pueden ingresar letras del abecedario");
                        return;
                    }
                }

                /*regex for email:
                 * "^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@)) 
(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,24}))$"
                 */

                if (!String.IsNullOrWhiteSpace(this.txtBuscEmpEmail.Text))
                {
                    /* este metodo sirve para cuando se crea el email que lo valide...
                    try
                    {
                        var test = new System.Net.Mail.MailAddress(this.txtBuscEmpEmail.Text);
                    }
                    catch (FormatException ex)
                    {
                        // wrong format for email
                        MessageBox.Show("Revise si ingreso un e-mail valido por favor");
                        return;
                    }
                     */
                    if (!this.txtBuscEmpEmail.Text.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == '@' || c == '.' || Char.IsWhiteSpace(c)))
                    {
                        MessageBox.Show("En la razon social solo se pueden ingresar letras del abecedario");
                        return;
                    }
                }

                //llamar a la BD EMPRESA

                //cargamos los datos actuales en la tabla
                DataTable resultado2 = new DataTable(); 
                _conexionSQL conectarBD = _conexionSQL.Instance;
                conectarBD.prConsultaUsuarioEmpresa(this.txtBuscEmpRazonSocial.Text, this.txtBuscEmpEmail.Text, this.txtBuscEmpCuit.Text, ref resultado2);
                this.dgvResultados.DataSource = resultado2;

            }




        }

        private void cambiarPWDUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ABM_Usuario.NewPWD frm = new WindowsFormsApplication1.ABM_Usuario.NewPWD();
            //Hacemos que cuando cliqueamos en el datagrid, cambie el valor del textbox
            int d = this.dgvResultados.CurrentCell.RowIndex;
            DataGridViewRow row = this.dgvResultados.Rows[d];
                
                //Suponemos: 0  -> userid   
                //           1  -> username
                //           2  -> ??.. etc

            TextBox txt = (TextBox)frm.Controls.Find("txtUsername", true)[0];
            txt.Text = row.Cells[1].Value.ToString();
            TextBox txt2 = (TextBox)frm.Controls.Find("txtIdUsuario", true)[0];
            txt2.Text = row.Cells[0].Value.ToString();

            frm.Show();
        }


        private void dgvResultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Hacemos que cuando cliqueamos en el datagrid, habilite los menues..
                this.cambiarMenuContextual(true);   //habilito opciones

                //Hacemos que cuando cliqueamos en el datagrid, cambie el valor del textbox
                int d = dgvResultados.CurrentCell.RowIndex;
                DataGridViewRow row = this.dgvResultados.Rows[d];

                //Suponemos: 0  -> userid 
                //           1  -> 
                //           2  -> estado

                menuHabilitarDeshabilitar(Convert.ToBoolean(row.Cells[2].Value.ToString()));
            }
        }

        private void cambiarMenuContextual(bool habilitar)
        {
            if (habilitar)
            {
                this.modificarUsuarioToolStripMenuItem.Enabled = true;
                this.habilitarToolStripMenuItem.Enabled = true;
                this.desHabilitarToolStripMenuItem.Enabled = true;
                this.cambiarPWDUsuarioToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.modificarUsuarioToolStripMenuItem.Enabled = false;
                this.habilitarToolStripMenuItem.Enabled = false;
                this.desHabilitarToolStripMenuItem.Enabled = false;
                this.cambiarPWDUsuarioToolStripMenuItem.Enabled = false;
            }
        }

        private void menuHabilitarDeshabilitar(bool habilitar)
        {
            if (habilitar)
            {
                this.habilitarToolStripMenuItem.Enabled = false;
                this.desHabilitarToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.habilitarToolStripMenuItem.Enabled = true;
                this.desHabilitarToolStripMenuItem.Enabled = false;
            }
        }

        private void habilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _conexionSQL conectarBD = _conexionSQL.Instance;

            int d = this.dgvResultados.CurrentCell.RowIndex;
            DataGridViewRow row = this.dgvResultados.Rows[d];

            //Suponemos: 0  -> userid   
            //           1  -> username
            //           2  -> estado
            //           3  -> ??.. etc

            conectarBD.cambiar_estado_usuario(Convert.ToInt32(row.Cells[0].Value.ToString()), 1);

            //refresco el datagrid para ver los cambios
            DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
            ch1 = (DataGridViewCheckBoxCell)dgvResultados.Rows[dgvResultados.CurrentRow.Index].Cells[2];
            ch1.Value = true;
            menuHabilitarDeshabilitar(true);

        }

        private void desHabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _conexionSQL conectarBD = _conexionSQL.Instance;

            int d = this.dgvResultados.CurrentCell.RowIndex;
            DataGridViewRow row = this.dgvResultados.Rows[d];

            //Suponemos: 0  -> userid   
            //           1  -> username
            //           2  -> estado
            //           3  -> ??.. etc

            conectarBD.cambiar_estado_usuario(Convert.ToInt32(row.Cells[0].Value.ToString()), 0);

            //refresco el datagrid para ver los cambios
            DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
            ch1 = (DataGridViewCheckBoxCell)dgvResultados.Rows[dgvResultados.CurrentRow.Index].Cells[2];
            ch1.Value = false;
            menuHabilitarDeshabilitar(false);

        }

        private void crearNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.gboxCrearModificarUsuario.Enabled = true;
            this.gboxCrearModificarUsuario.Visible = true;

            this.gboxBuscarUsuarios.Enabled = false;
            this.gboxBuscarUsuarios.Visible = false;

            this.rbtEmpresa.Enabled = true;
            this.rbtEmpresa.Visible = true;
            this.rbtCliente.Enabled = true;
            this.rbtCliente.Visible = true;

            //limpio todos los textbox a la vez...
            foreach (Control x in this.gboxCrearModificarUsuario.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }
            foreach (Control x in this.gboxDatosComUsuarios.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }


            //this.rbtCliente.CheckedChanged();
            this.rbtEmpresa.Checked = true;
            this.rbtEmpresa.Checked = false;
            this.rbtCliente.Checked = true;

            this.gboxCrearModificarUsuario.Text = "Crear Nuevo (Usuario)";
            //this.gboxCrearModificarUsuario.Text = "Modificar (Usuario)";
            this.gboxCrearModificarUsuarioCliente.Text = "Datos Nuevo Cliente";
            //this.gboxCrearModificarUsuarioCliente.Text = "Datos Cliente";
            this.gboxCrearModificarEmpresa.Text = "Datos Nueva Empresa";
            //this.gboxCrearModificarEmpresa.Text = "Datos Empresa";
            this.rbtCliente.Text = "Nuevo Cliente (Compradores)";
            //this.rbtCliente.Text = "Cliente (Compradores)";
            this.rbtEmpresa.Text = "Nueva Empresa (Vendedores)";
            //this.rbtEmpresa.Text = "Empresa (Vendedores)";


            this.txtUsername.ReadOnly = false;


            this.LabelEstado.Visible = false;
            this.labelIntentos.Visible = false;
            this.label17.Visible = true;
            this.label18.Visible = true;
            this.txtPWD.Visible = true;
            this.txtPWDconfirmar.Visible = true;


            this.cambiarMenuContextual(false);
            this.crearNuevoUsuarioToolStripMenuItem.Enabled = false;

            DateTime fechaHoraLocal = Properties.Settings.Default.FECHA_HORA_APP;       //con esto averigua la fechaHora local del sistema
            this.dTimePickerFechaAlta.Value = fechaHoraLocal;
            this.dTimePickerFechaAlta2.Value = fechaHoraLocal;

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.gboxCrearModificarUsuario.Enabled = false;
            this.gboxCrearModificarUsuario.Visible = false;

            this.gboxBuscarUsuarios.Enabled = true;
            this.gboxBuscarUsuarios.Visible = true;


            //limpio todos los textbox a la vez...
            foreach (Control x in this.gboxCrearModificarUsuario.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }
            this.cambiarMenuContextual(false);
            this.crearNuevoUsuarioToolStripMenuItem.Enabled = true;
        }

        private void rbtCliente_CheckedChanged(object sender, EventArgs e)
        {
            //limpio todos los textbox a la vez... de lo que no se tiene que poder editar
            foreach (Control x in this.gboxCrearModificarEmpresa.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                    ((TextBox)x).Enabled = false;
                }
            }

            this.gboxCrearModificarEmpresa.Visible = false;
            this.gboxCrearModificarEmpresa.Enabled = false;

            foreach (Control x in this.gboxCrearModificarUsuarioCliente.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                    ((TextBox)x).Enabled = true;
                }
            }

            this.gboxCrearModificarUsuarioCliente.Visible = true;
            this.gboxCrearModificarUsuarioCliente.Enabled = true;
        }

        private void rbtEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            //limpio todos los textbox a la vez... de lo que no se tiene que poder editar
            foreach (Control x in this.gboxCrearModificarUsuarioCliente.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                    ((TextBox)x).Enabled = false;
                }
            }
            this.gboxCrearModificarUsuarioCliente.Visible = false;
            this.gboxCrearModificarUsuarioCliente.Enabled = false;

            foreach (Control x in this.gboxCrearModificarEmpresa.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                    ((TextBox)x).Enabled = true;
                }
            }

            this.gboxCrearModificarEmpresa.Visible = true;
            this.gboxCrearModificarEmpresa.Enabled = true;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (this.rbtCliente.Checked == true && this.gboxCrearModificarUsuarioCliente.Visible == true)
            {
                //empezamos validando los campos...

                //todos los textbox tienen que tener algo escrito
                foreach (Control x in this.gboxCrearModificarUsuarioCliente.Controls)
                {
                    if (x is TextBox)
                    {
                        if (String.IsNullOrWhiteSpace(((TextBox)x).Text))
                        {
                            MessageBox.Show("Por favor complete los campos que estan vacios");
                            return;
                        }
                    }
                }

                //otras validaciones genericas..
                if (!(System.Text.RegularExpressions.Regex.IsMatch(this.txtClientePiso.Text, @"[ ^ 0-9]")))
                {
                    MessageBox.Show("Por favor revise que en el nº de piso, haya ingresado solamente numeros");
                    return;
                }

                if (!(System.Text.RegularExpressions.Regex.IsMatch(this.txtClienteNumCalle.Text, @"[ ^ 0-9]")))
                {
                    MessageBox.Show("Por favor revise que en el nº de calle, haya ingresado solamente numeros");
                    return;
                }

                if (!(System.Text.RegularExpressions.Regex.IsMatch(this.txtClieNumDNI.Text, @"[ ^ 0-9]")))
                {
                    MessageBox.Show("Por favor revise que en el DNI, haya ingresado solamente numeros");
                    return;
                }

                if (string.Compare(this.gboxCrearModificarUsuario.Text, "Modificar (Usuario)") == 0)
                {
                    // validaciones para modificar un usuario
                }
                else
                {
                    //  validaciones para crear un usuario
                    if (String.Compare(this.txtPWD.Text, this.txtPWDconfirmar.Text) != 0)
                    {
                        MessageBox.Show("La contraseña y la confirmacion no coinciden");
                        return;
                    }

                    if (this.txtPWD.Text.Length < _Parametros._longitudMinimaDePWD)
                    {
                        MessageBox.Show("La nueva contraseña es muy corta");
                        return;
                    }

                    if (this.txtUsername.Text.Length < _Parametros._longitudMinimaDePWD)
                    {
                        MessageBox.Show("El nombre de usuario es muy corto");
                        return;
                    }

                    if (!this.txtUsername.Text.All(c => Char.IsLetterOrDigit(c)))
                    {
                        MessageBox.Show("En el nombre de usuario solo se pueden ingresar letras del abecedario o digitos");
                        return;
                    }
                    //
                }



                if (!String.IsNullOrWhiteSpace(this.txtClienteEmail.Text))
                {
                    // este metodo sirve para cuando se crea el email que lo valide...
                    try
                    {
                        var test = new System.Net.Mail.MailAddress(this.txtClienteEmail.Text);
                    }
                    catch (FormatException ex)
                    {
                        // wrong format for email
                        MessageBox.Show("Revise si ingreso un e-mail valido por favor");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Por favor complete el email");
                    return;
                }




                if (!this.txtClienteCodPostal.Text.All(c => Char.IsLetterOrDigit(c) || c == ' ' || Char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("En el codigo postal solo se pueden ingresar letras del abecedario o digitos");
                    return;
                }

                if (!this.txtClienteDireccionCalle.Text.All(c => Char.IsLetterOrDigit(c) || c == ' ' || Char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("En la direccion de calle solo se pueden ingresar letras del abecedario o digitos");
                    return;
                }

                if (!this.txtClienteDpto.Text.All(c => Char.IsLetterOrDigit(c) || c == ' ' || Char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("En el departamento solo se pueden ingresar letras del abecedario o digitos");
                    return;
                }

                if (!this.txtClienteTelefono.Text.All(c => Char.IsDigit(c) || c == ' ' || Char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("En el telefono solo se pueden ingresar digitos");
                    return;
                }

                if (!this.txtClienteNombre.Text.All(c => Char.IsLetterOrDigit(c) || c == ' ' || Char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("En el nombre del cliente solo se pueden ingresar letras del abecedario o digitos");
                    return;
                }

                if (!this.txtClienteApellido.Text.All(c => Char.IsLetterOrDigit(c) || c == ' ' || Char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("En el apellido del cliente solo se pueden ingresar letras del abecedario o digitos");
                    return;
                }


                DateTime myDate =  this.dTimePiker_FechaNac.Value.Date;

                if ((DateTime.Compare(myDate, (DateTime)Properties.Settings.Default.FECHA_HORA_APP)) > 0)
                {
                    MessageBox.Show("No se puede settear una fecha de nacimiento posterior a la fecha actual.");
                    return;
                }

                DataTable resultado2 = new DataTable();
                _conexionSQL conectarBD = _conexionSQL.Instance;
                string sql;

                if (string.Compare(this.gboxCrearModificarUsuario.Text, "Modificar (Usuario)") == 0)
                {
                    // validaciones para modificar un usuario
                }
                else
                {
                    //  validaciones para crear un usuario

                    //validamos que el usuario no exista...

                    sql = @"select count(t1.username) 
                            from DALE_SA.usuario t1 
                            where t1.username = Rtrim(Ltrim('" + this.txtUsername.Text + @"'))
                        ";
                    resultado2 = conectarBD.ejecutarUnaQuery(sql);

                    if (resultado2.Rows[0][0].Equals(0))
                    {
                        //no existia
                    }
                    else
                    {
                        MessageBox.Show("El usuario ya existe en la BD, por favor pruebe otro..");
                        return;
                    }
                }


                if (string.Compare(this.gboxCrearModificarUsuario.Text, "Modificar (Usuario)") == 0)
                {
                    // validaciones para modificar un usuario

                    sql = @"select count(t1.dni) 
                            from DALE_SA.data_cliente t1 
                            where t1.dni = " + this.txtClieNumDNI.Text + @" and t1.idusuario != " + this.labelIDusuario.Text + @"
                        ";
                }
                else
                {
                    //  validaciones para crear un usuario


                    //validamos que el DNI sea unico
                    sql = @"select count(t1.dni) 
                            from DALE_SA.data_cliente t1 
                            where t1.dni = " + this.txtClieNumDNI.Text + @"
                        ";
                }
                    
                resultado2 = conectarBD.ejecutarUnaQuery(sql);
                //Convert.ToInt32(texto...)

                if (resultado2.Rows[0][0].Equals(0))
                {
                    //no existia
                }
                else
                {
                    MessageBox.Show("El DNI ya existe en la BD, por favor pruebe otro..");
                    return;
                }
                

                //--------------------------------------------------------

                //hacer el save en la BD
                string password;
                password = _SHA256Encrypt.encriptar(this.txtPWD.Text);

                int tipoDni = 1;    //valor fijo para esta etapa del tp (solo acepta DNI).


                if (string.Compare(this.gboxCrearModificarUsuario.Text, "Modificar (Usuario)") == 0)
                {
                    // validaciones para modificar un usuario

                    sql = @"EXEC DALE_SA.prModificarUsuarioCliente 
                            '" + this.labelIDusuario.Text + @"',
                            '" + this.txtClienteNombre.Text + @"',
                            '" + this.txtClienteApellido.Text + @"',
                            '" + this.txtClieNumDNI.Text + @"',
                            '" + this.txtClienteEmail.Text + @"',
                            '" + this.txtClienteTelefono.Text + @"',
                            '" + this.txtClienteCodPostal.Text + @"',
                            '" + this.txtClienteDireccionCalle.Text + @"',
                            '" + this.txtClienteNumCalle.Text + @"',
                            '" + this.txtClientePiso.Text + @"',
                            '" + this.txtClienteDpto.Text + @"',
                            '" + this.dTimePiker_FechaNac.Value.ToString("yyyy-MM-dd hh:mm:ss") + @"'
                        ";
                    resultado2 = conectarBD.ejecutarUnaQuery(sql);
                    //Convert.ToInt32(texto...)

                    if (resultado2.Rows[0][0].Equals(1))
                    {
                        //exito!
                        MessageBox.Show("El usuario se modifico correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al modificar el usuario. Intente nuevamente..");
                        return;
                    }



                }
                else
                {
                    //  validaciones para crear un usuario

                    sql = @"EXEC DALE_SA.prCrearUsuarioCliente 
                            '" + this.txtUsername.Text + @"',
                            '" + password + @"',
                            '" + this.txtClienteNombre.Text + @"',
                            '" + this.txtClienteApellido.Text + @"',
                            '" + tipoDni.ToString() + @"',
                            '" + this.txtClieNumDNI.Text + @"',
                            '" + this.txtClienteEmail.Text + @"',
                            '" + this.txtClienteTelefono.Text + @"',
                            '" + this.txtClienteCodPostal.Text + @"',
                            '" + this.txtClienteDireccionCalle.Text + @"',
                            '" + this.txtClienteNumCalle.Text + @"',
                            '" + this.txtClientePiso.Text + @"',
                            '" + this.txtClienteDpto.Text + @"',
                            '" + this.dTimePiker_FechaNac.Value.ToString("yyyy-MM-dd hh:mm:ss") + @"',
                            '" + this.dTimePickerFechaAlta.Value.ToString("yyyy-MM-dd hh:mm:ss") + @"'
                        ";
                    resultado2 = conectarBD.ejecutarUnaQuery(sql);
                    //Convert.ToInt32(texto...)

                    if (resultado2.Rows[0][0].Equals(1))
                    {
                        //exito!
                        MessageBox.Show("El usuario se creo correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al crear el usuario. Intente nuevamente..");
                        return;
                    }

                }


            }
            else
            {       //es empresa...................
                //empezamos validando los campos...


                //todos los textbox tienen que tener algo escrito
                foreach (Control x in this.gboxCrearModificarEmpresa.Controls)
                {
                    if (x is TextBox)
                    {
                        if (String.IsNullOrWhiteSpace(((TextBox)x).Text))
                        {
                            MessageBox.Show("Por favor complete los campos que estan vacios");
                            return;
                        }
                    }
                }

                //otras validaciones genericas..
                if (!(System.Text.RegularExpressions.Regex.IsMatch(this.txtEmpresaPiso.Text, @"[ ^ 0-9]")))
                {
                    MessageBox.Show("Por favor revise que en el nº de piso, haya ingresado solamente numeros");
                    return;
                }

                if (!(System.Text.RegularExpressions.Regex.IsMatch(this.txtEmpresNumCalle.Text, @"[ ^ 0-9]")))
                {
                    MessageBox.Show("Por favor revise que en el nº de calle, haya ingresado solamente numeros");
                    return;
                }

                if (string.Compare(this.gboxCrearModificarUsuario.Text, "Modificar (Usuario)") == 0)
                {
                    // validaciones para modificar un usuario
                }
                else
                {
                    // validaciones para crear un usuario
                    if (String.Compare(this.txtPWD.Text, this.txtPWDconfirmar.Text) != 0)
                    {
                        MessageBox.Show("La contraseña y la confirmacion no coinciden");
                        return;
                    }

                    if (this.txtPWD.Text.Length < _Parametros._longitudMinimaDePWD)
                    {
                        MessageBox.Show("La nueva contraseña es muy corta");
                        return;
                    }

                    if (this.txtUsername.Text.Length < _Parametros._longitudMinimaDePWD)
                    {
                        MessageBox.Show("El nombre de usuario es muy corto");
                        return;
                    }

                    if (!this.txtUsername.Text.All(c => Char.IsLetterOrDigit(c)))
                    {
                        MessageBox.Show("En el nombre de usuario solo se pueden ingresar letras del abecedario o digitos");
                        return;
                    }

                }




                if (!String.IsNullOrWhiteSpace(this.txtEmpresaEmail.Text))
                {
                    // este metodo sirve para cuando se crea el email que lo valide...
                    try
                    {
                        var test = new System.Net.Mail.MailAddress(this.txtEmpresaEmail.Text);
                    }
                    catch (FormatException ex)
                    {
                        // wrong format for email
                        MessageBox.Show("Revise si ingreso un e-mail valido por favor");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Por favor complete el email");
                    return;
                }



                if (!(System.Text.RegularExpressions.Regex.IsMatch(this.txtEmpresaCuit.Text, @"^[0-9]{2}-[0-9]{8}-[0-9]{2}$")))
                {
                    MessageBox.Show("En el cuit solo se pueden ingresar digitos o guiones medios, con el siguiente formato: 12-3456789X-XX");
                    return;
                }


                if (!this.txtEmpresaRazonSocial.Text.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == 'º' || c == ':' || Char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("En la razon social solo se pueden ingresar letras del abecedario, digitos y caracteres como º,:");
                    return;
                }


                if (!this.txtEmpresaDpto.Text.All(c => Char.IsLetterOrDigit(c) || c == ' ' || Char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("En el departamento solo se pueden ingresar letras del abecedario o digitos");
                    return;
                }

                if (!this.txtEmpresaTelefono.Text.All(c => Char.IsDigit(c) || c == ' ' || Char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("En el telefono solo se pueden ingresar digitos");
                    return;
                }


                if (!this.txtEmpresaCodPostal.Text.All(c => Char.IsLetterOrDigit(c) || c == ' ' || Char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("En el codigo postal solo se pueden ingresar letras del abecedario o digitos");
                    return;
                }

                if (!this.txtEmpresaDireccionCalle.Text.All(c => Char.IsLetterOrDigit(c) || c == ' ' || Char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("En la direccion de calle solo se pueden ingresar letras del abecedario o digitos");
                    return;
                }


                if (!this.txtEmpresaCiudad.Text.All(c => Char.IsLetterOrDigit(c) || c == ' ' || Char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("En la ciudad de la empresa solo se pueden ingresar letras del abecedario o digitos");
                    return;
                }

                if (!this.txtEmpresaRubroPpal.Text.All(c => Char.IsLetterOrDigit(c) || c == ' ' || Char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("En el rubro principal de la empresa solo se pueden ingresar letras del abecedario o digitos");
                    return;
                }

                if (!this.txtEmpresaContacto.Text.All(c => Char.IsLetterOrDigit(c) || c == ' ' || Char.IsWhiteSpace(c)))
                {
                    MessageBox.Show("En el contacto de la empresa solo se pueden ingresar letras del abecedario o digitos");
                    return;
                }




                DataTable resultado2 = new DataTable();
                _conexionSQL conectarBD = _conexionSQL.Instance;
                string sql;

                if (string.Compare(this.gboxCrearModificarUsuario.Text, "Modificar (Usuario)") == 0)
                {
                    // validaciones para modificar un usuario
                }
                else
                {
                    //  validaciones para crear un usuario

                    //validamos que el usuario no exista...

                    sql = @"select count(t1.username) 
                            from DALE_SA.usuario t1 
                            where t1.username = Rtrim(Ltrim('" + this.txtUsername.Text + @"'))
                        ";
                    resultado2 = conectarBD.ejecutarUnaQuery(sql);

                    if (resultado2.Rows[0][0].Equals(0))
                    {
                        //no existia
                    }
                    else
                    {
                        MessageBox.Show("El usuario ya existe en la BD, por favor pruebe otro..");
                        return;
                    }
                }

                //validamos que el CUIT sea unico

                if (string.Compare(this.gboxCrearModificarUsuario.Text, "Modificar (Usuario)") == 0)
                {
                    // validaciones para modificar un usuario

                    sql = @"select count(t1.cuit) 
                            from DALE_SA.data_empresa t1 
                            where t1.cuit = Rtrim(Ltrim('" + this.txtEmpresaCuit.Text + @"')) and t1.idusuario != " + this.labelIDusuario.Text + @"
                        ";
                }
                else
                {
                    //  validaciones para crear un usuario

                    sql = @"select count(t1.cuit) 
                            from DALE_SA.data_empresa t1 
                            where t1.cuit = Rtrim(Ltrim('" + this.txtEmpresaCuit.Text + @"'))
                        ";
                }

                resultado2 = conectarBD.ejecutarUnaQuery(sql);
                //Convert.ToInt32(texto...)

                if (resultado2.Rows[0][0].Equals(0))
                {
                    //no existia
                }
                else
                {
                    MessageBox.Show("El CUIT ya existe en la BD, por favor pruebe otro..");
                    return;
                }



                //validamos que la razonSocial sea unica

                if (string.Compare(this.gboxCrearModificarUsuario.Text, "Modificar (Usuario)") == 0)
                {
                    // validaciones para modificar un usuario

                    sql = @"select count(t1.razon_social) 
                            from DALE_SA.data_empresa t1 
                            where t1.razon_social = Rtrim(Ltrim('" + this.txtEmpresaRazonSocial.Text + @"')) and t1.idusuario != " + this.labelIDusuario.Text + @"
                        ";
                }
                else
                {
                    //  validaciones para crear un usuario

                    sql = @"select count(t1.razon_social) 
                            from DALE_SA.data_empresa t1 
                            where t1.razon_social = Rtrim(Ltrim('" + this.txtEmpresaRazonSocial.Text + @"'))
                        ";
                }

                resultado2 = conectarBD.ejecutarUnaQuery(sql);
                //Convert.ToInt32(texto...)

                if (resultado2.Rows[0][0].Equals(0))
                {
                    //no existia
                }
                else
                {
                    MessageBox.Show("La Razon Social ya existe en la BD, por favor pruebe otro..");
                    return;
                }


                //--------------------------------------------------------

                if (string.Compare(this.gboxCrearModificarUsuario.Text, "Modificar (Usuario)") == 0)
                {
                    // validaciones para modificar un usuario
                    
                    sql = @"EXEC DALE_SA.prModificarUsuarioEmpresa
                            '" + this.labelIDusuario.Text + @"',
                            '" + this.txtEmpresaCuit.Text + @"',
                            '" + this.txtEmpresaRazonSocial.Text + @"',
                            '" + this.txtEmpresaRubroPpal.Text + @"',
                            '" + this.txtEmpresaCiudad.Text + @"',
                            '" + this.txtEmpresaEmail.Text + @"',
                            '" + this.txtEmpresaTelefono.Text + @"',
                            '" + this.txtEmpresaCodPostal.Text + @"',
                            '" + this.txtEmpresaDireccionCalle.Text + @"',
                            '" + this.txtEmpresNumCalle.Text + @"',
                            '" + this.txtEmpresaPiso.Text + @"',
                            '" + this.txtEmpresaDpto.Text + @"',
                            '" + this.txtEmpresaContacto.Text + @"'
                        ";
                    resultado2 = conectarBD.ejecutarUnaQuery(sql);
                     
                    //Convert.ToInt32(texto...)

                    if (resultado2.Rows[0][0].Equals(1))
                    {
                        //exito!
                        MessageBox.Show("El usuario se modifico correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al modificar el usuario. Intente nuevamente..");
                        return;
                    }

                }
                else
                {
                    //  validaciones para crear un usuario

                    //hacer el save en la BD
                    string password;
                    password = _SHA256Encrypt.encriptar(this.txtPWD.Text);

                    //int tipoDni = 1;    //valor fijo para esta etapa del tp (solo acepta DNI).

                    sql = @"EXEC DALE_SA.prCrearUsuarioEmpresa
                            '" + this.txtUsername.Text + @"',
                            '" + password + @"',
                            '" + this.txtEmpresaCuit.Text + @"',
                            '" + this.txtEmpresaRazonSocial.Text + @"',
                            '" + this.txtEmpresaRubroPpal.Text + @"',
                            '" + this.txtEmpresaCiudad.Text + @"',
                            '" + this.txtEmpresaEmail.Text + @"',
                            '" + this.txtEmpresaTelefono.Text + @"',
                            '" + this.txtEmpresaCodPostal.Text + @"',
                            '" + this.txtEmpresaDireccionCalle.Text + @"',
                            '" + this.txtEmpresNumCalle.Text + @"',
                            '" + this.txtEmpresaPiso.Text + @"',
                            '" + this.txtEmpresaDpto.Text + @"',
                            '" + this.txtEmpresaContacto.Text + @"',
                            '" + ((DateTime)Properties.Settings.Default.FECHA_HORA_APP).ToString("yyyy-MM-dd hh:mm:ss") + @"'
                        ";
                    resultado2 = conectarBD.ejecutarUnaQuery(sql);
                    //Convert.ToInt32(texto...)

                    if (resultado2.Rows[0][0].Equals(1))
                    {
                        //exito!
                        MessageBox.Show("El usuario se creo correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al crear el usuario. Intente nuevamente..");
                        return;
                    }
                }

            }




            //do....
            this.cambiarMenuContextual(false);
            this.crearNuevoUsuarioToolStripMenuItem.Enabled = true;
            this.btCancelar.PerformClick();
            //actualizar datos de busqueda o limpiar...
            this.btLimpiar.PerformClick();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (habilitarToolStripMenuItem.Enabled == true)  //si esta deshabilitado
            {
                MessageBox.Show("Por favor seleccione algun usuario habilitado.");
                return;
            }

            this.gboxCrearModificarUsuario.Enabled = true;
            this.gboxCrearModificarUsuario.Visible = true;

            this.gboxBuscarUsuarios.Enabled = false;
            this.gboxBuscarUsuarios.Visible = false;

            this.LabelEstado.Visible = true;
            this.labelIntentos.Visible = true;

            this.label17.Visible = false;
            this.label18.Visible = false;
            this.txtPWD.Visible = false;
            this.txtPWDconfirmar.Visible = false;

            //limpio todos los textbox a la vez...
            foreach (Control x in this.gboxCrearModificarUsuario.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }

            foreach (Control x in this.gboxDatosComUsuarios.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }

            //this.rbtCliente.CheckedChanged();
            this.rbtEmpresa.Checked = true;
            this.rbtEmpresa.Checked = false;
            this.rbtCliente.Checked = true;

            this.cambiarMenuContextual(false);
            this.crearNuevoUsuarioToolStripMenuItem.Enabled = false;

            DateTime fechaHoraLocal = Properties.Settings.Default.FECHA_HORA_APP;       //con esto averigua la fechaHora local del sistema
            this.dTimePickerFechaAlta.Value = fechaHoraLocal;
            this.dTimePickerFechaAlta2.Value = fechaHoraLocal;

            //this.gboxCrearModificarUsuario.Text = "Crear Nuevo (Usuario)";
            this.gboxCrearModificarUsuario.Text = "Modificar (Usuario)";
            //this.gboxCrearModificarUsuarioCliente.Text = "Datos Nuevo Cliente";
            this.gboxCrearModificarUsuarioCliente.Text = "Datos Cliente";
            //this.gboxCrearModificarEmpresa.Text = "Datos Nueva Empresa";
            this.gboxCrearModificarEmpresa.Text = "Datos Empresa";
            //this.rbtCliente.Text = "Nuevo Cliente (Compradores)";
            this.rbtCliente.Text = "Cliente (Compradores)";
            //this.rbtEmpresa.Text = "Nueva Empresa (Vendedores)";
            this.rbtEmpresa.Text = "Empresa (Vendedores)";

            this.txtUsername.ReadOnly = true;

            //de aca para atras es el mismo codigo que crear..
            //aca voy a poner lo nuevo para hacer las modificaciones..

            if (this.rbtBuscarClientes.Checked == true)
            {
                this.rbtEmpresa.Enabled = false;
                this.rbtEmpresa.Visible = false;
                this.rbtCliente.Enabled = true;
                this.rbtCliente.Visible = true;
                //tengo que cargar los datos de un cliente


                int d = this.dgvResultados.CurrentCell.RowIndex;
                DataGridViewRow row = this.dgvResultados.Rows[d];

                //Suponemos: 0  -> userid   
                //           1  -> username
                //           2  -> estado
                //           3  -> mail
                //           4  -> nombre
                //           5  -> apellido
                //           6  -> dni
                //           7  -> tipo_documento
                //           8  -> fechaCreacion
                //           9  -> telefono
                //           10 -> intentos fallidos
                //           11  -> fecha_nacimiento
                //           12  -> calle
                //           13  -> cod_postal
                //           14  -> dpto
                //           15  -> numero
                //           16  -> piso

                this.labelIDusuario.Text = row.Cells[0].Value.ToString();
                this.txtUsername.Text = row.Cells[1].Value.ToString();
                //if (String.Compare(row.Cells[2].Value.ToString(), "1") == 0)
                //{
                    this.LabelEstado.Text = "Usuario HABILITADO";
                //}
                //else
                //{
                //    this.LabelEstado.Text = "Usuario DES-HABILITADO";
                //}
                this.txtClienteEmail.Text = row.Cells[3].Value.ToString();
                this.txtClienteNombre.Text = row.Cells[4].Value.ToString();
                this.txtClienteApellido.Text = row.Cells[5].Value.ToString();
                this.txtClieNumDNI.Text = row.Cells[6].Value.ToString();
                //this..Text = row.Cells[7].Value.ToString();
                this.dTimePickerFechaAlta.Value = (DateTime)row.Cells[8].Value;
                this.txtClienteTelefono.Text = row.Cells[9].Value.ToString();
                this.labelIntentos.Text = "Intentos Fallidos: " + row.Cells[10].Value.ToString();
                this.dTimePiker_FechaNac.Value = (DateTime)row.Cells[11].Value;
                this.txtClienteDireccionCalle.Text = row.Cells[12].Value.ToString();
                this.txtClienteCodPostal.Text = row.Cells[13].Value.ToString();
                this.txtClienteDpto.Text = row.Cells[14].Value.ToString();
                this.txtClienteNumCalle.Text = row.Cells[15].Value.ToString();
                this.txtClientePiso.Text = row.Cells[16].Value.ToString();


            }
            else
            {
                this.rbtEmpresa.Enabled = true;
                this.rbtEmpresa.Visible = true;
                this.rbtCliente.Enabled = false;
                this.rbtCliente.Visible = false;
                //tengo que cargar los datos de una empresa...

                this.gboxCrearModificarUsuario.Enabled = true;
                this.gboxCrearModificarUsuario.Visible = true;

                this.gboxBuscarUsuarios.Enabled = false;
                this.gboxBuscarUsuarios.Visible = false;

                //limpio todos los textbox a la vez...
                foreach (Control x in this.gboxCrearModificarUsuario.Controls)
                {
                    if (x is TextBox)
                    {
                        ((TextBox)x).Text = String.Empty;
                    }
                }

                //this.rbtCliente.CheckedChanged();
                this.rbtCliente.Checked = true;
                this.rbtCliente.Checked = false;
                this.rbtEmpresa.Checked = false;
                this.rbtEmpresa.Checked = true;


                this.cambiarMenuContextual(false);
                this.crearNuevoUsuarioToolStripMenuItem.Enabled = false;


                //de aca para atras es el mismo codigo que crear..
                //aca voy a poner lo nuevo para hacer las modificaciones..

                if (this.rbtBuscarEmpresas.Checked == true)
                {
                    //tengo que cargar los datos de un cliente


                    int d = this.dgvResultados.CurrentCell.RowIndex;
                    DataGridViewRow row = this.dgvResultados.Rows[d];

                    //Suponemos: 0  -> userid   
                    //           1  -> username
                    //           2  -> estado
                    //           3  -> mail
                    //           4  -> razon_social
                    //           5  -> cuit
                    //           6  -> rubroempresa
                    //           7  -> contacto
                    //           8  -> fechaCreacion
                    //           9  -> telefono
                    //           10 -> intentos fallidos
                    //           11  -> ciudad
                    //           12  -> calle
                    //           13  -> cod_postal
                    //           14  -> dpto
                    //           15  -> numero
                    //           16  -> piso

                    this.labelIDusuario.Text = row.Cells[0].Value.ToString();
                    this.txtUsername.Text = row.Cells[1].Value.ToString();
                    //if (String.Compare(row.Cells[2].Value.ToString(), "1") == 0)
                    //{
                        this.LabelEstado.Text = "Usuario HABILITADO";
                    //}
                    //else
                    //{
                    //    this.LabelEstado.Text = "Usuario DES-HABILITADO";
                    //}
                    this.txtEmpresaEmail.Text = row.Cells[3].Value.ToString();
                    this.txtEmpresaRazonSocial.Text = row.Cells[4].Value.ToString();
                    this.txtEmpresaCuit.Text = row.Cells[5].Value.ToString();
                    this.txtEmpresaRubroPpal.Text = row.Cells[6].Value.ToString();
                    this.txtEmpresaContacto.Text = row.Cells[7].Value.ToString();
                    this.dTimePickerFechaAlta2.Value = (DateTime)row.Cells[8].Value;
                    this.txtEmpresaTelefono.Text = row.Cells[9].Value.ToString();
                    this.labelIntentos.Text = "Intentos Fallidos: " + row.Cells[10].Value.ToString();
                    this.txtEmpresaCiudad.Text = row.Cells[11].Value.ToString();
                    this.txtEmpresaDireccionCalle.Text = row.Cells[12].Value.ToString();
                    this.txtEmpresaCodPostal.Text = row.Cells[13].Value.ToString();
                    this.txtEmpresaDpto.Text = row.Cells[14].Value.ToString();
                    this.txtEmpresNumCalle.Text = row.Cells[15].Value.ToString();
                    this.txtEmpresaPiso.Text = row.Cells[16].Value.ToString();
                }
            }
        }


    }
}
