using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //actualizo dinamicamente el nombre de la aplicacion.
            this.label1.Text = _Parametros._nombreAplicacion;
            this.Text = _Parametros._infoGrupoGD + " - " + _Parametros._nombreAplicacion ;

            this.AcceptButton = this.bLogin;
            this.txtIdUsuario.Text = "";
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            // levanto usuario y contraseña
            string user = null;
            string password = null;
            string retorno;
            user = this.txtUsuario.Text;
            password = this.txtPassword.Text;

            if (( String.IsNullOrWhiteSpace (user) ) || ( String.IsNullOrWhiteSpace (password) ) )
            {
                MessageBox.Show("Por favor complete Usuario y/o contraseña");
                return;
            }

            password = _SHA256Encrypt.encriptar(this.txtPassword.Text);

            //Hago una prueba con la palabra hola -> b221d9dbb083a7f33428d7c2a3c3198ae925614d70210e28716ccaa7cd4ddb79

           /* System.Console.WriteLine(_SHA256Encrypt.encriptar("dcappa"));
            System.Console.WriteLine(_SHA256Encrypt.encriptar("esuchecki"));
            System.Console.WriteLine(_SHA256Encrypt.encriptar("lmontavan"));
            System.Console.WriteLine(_SHA256Encrypt.encriptar("amarcovecchio"));
            */
            //Se loguea en la BD.
            _conexionSQL conectarBD = _conexionSQL.Instance;
            retorno=conectarBD.prueba_login(user, password);
            //MessageBox.Show(retorno);
            if (retorno.Equals("-3"))
            {
                MessageBox.Show("Problemas con la base de datos");
                this.txtPassword.Text = "";
                this.txtUsuario.Text = "";
                return;
            }

            if (retorno.Equals("-2"))
            {
                MessageBox.Show("Usuario bloqueado conecte a administracion");
                this.txtPassword.Text = "";
                this.txtUsuario.Text = "";
                return;
            }
            if (retorno.Equals("-1"))
            {
                MessageBox.Show("Usuario o contraseña invalida");
                this.txtPassword.Text = "";
                //this.txtUsuario.Text = "";
                return;
            }
              
            
            this.MENU_OPEN(retorno);
            this.txtIdUsuario.Text = retorno;

            
        }

        

        private void SALIR_Click(object sender, EventArgs e)
        {

            this.txtPassword.Text = "";
            this.txtUsuario.Text = "";
            //this.ABM.Visible = false;
            //this.ABM.Enabled = false;
            this.SALIR.Visible = false;
            this.SALIR.Enabled = false;
            this.LOGIN.Enabled = true;
            this.LOGIN.Visible = true;
            this.COMPRA.Enabled = false;
            this.COMPRA.Visible = false;
            this.PUBLICACION.Enabled = false;
            this.PUBLICACION.Visible = false;
            this.STATUS_LABEL.Text = @"";
            this.gboxHoraFechaSistema.Visible = false;  //que NO se vea la hora
            this.gboxHoraFechaSistema.Enabled = false;

            //this.SALIR.Visible = true;
            this.AMB_ROL.Visible = false;
            this.AMB_USUARIO.Visible = false;
            this.cAMBIARMIPWDToolStripMenuItem.Visible = false;
            this.cAMBIARMIPWDToolStripMenuItem.Enabled = false;

            this.ABM.Visible = false;
            this.ABM.Enabled = false;
            this.ABM.Enabled = false;
            this.SALIR.Enabled = true;
            this.AMB_ROL.Enabled = false;
            this.AMB_USUARIO.Enabled = false;
            this.txtIdUsuario.Text = "";


            //this.COMPRA_BUSCAR.Enabled = false;
            this.COMPRA_BUSCAR.Visible = false;
            this.miHistorialDeComprasToolStripMenuItem.Visible = false;
            //this.miHistorialDeComprasToolStripMenuItem.Enabled = false;
            this.calificarToolStripMenuItem.Visible = false;
           // this.calificarToolStripMenuItem.Enabled = false;


            //cierro todos los formularios abiertos exepto este...
            //for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            //foreach (var form in Application.OpenForms)
            //{
             //   if ( != this.Name)
             //       Application.OpenForms[i].Close();
            //}
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Text != this.Text)
                    Application.OpenForms[i].Close();
            }

        }

        private void AMB_USUARIO_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ABM_Usuario.Form1 frm = new WindowsFormsApplication1.ABM_Usuario.Form1();
            
            frm.Show();
        }

        private void AMB_ROL_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.ABM_Rol.Form1 frm = new WindowsFormsApplication1.ABM_Rol.Form1();

            frm.Show();
            //_conexionSQL conectarBD = _conexionSQL.Instance;
           
        }
        private void MENU_OPEN(string user)
        {
            this.AcceptButton = null;
            this.LOGIN.Visible = false;
            this.LOGIN.Enabled = false;

            this.ABM.Visible = true;
            this.ABM.Enabled = true;

            this.AMB_ROL.Visible = false;
            this.AMB_USUARIO.Visible = false;
            this.AMB_ROL.Enabled = false;
            this.AMB_USUARIO.Enabled = false;
            this.ABM_VIS.Enabled = false;
            this.ABM_VIS.Visible = false;
            this.cAMBIARMIPWDToolStripMenuItem.Visible = true;
            this.cAMBIARMIPWDToolStripMenuItem.Enabled = true;

            this.cONSULTARESTADISTICASToolStripMenuItem.Enabled = false;
            this.cONSULTARESTADISTICASToolStripMenuItem.Visible = false;

            this.vERIFICARDUPLICADOSToolStripMenuItem.Enabled = false;
            this.vERIFICARDUPLICADOSToolStripMenuItem.Visible = false;

            this.cONSULTAFACTURASAVENDEDORToolStripMenuItem.Enabled = false;
            this.cONSULTAFACTURASAVENDEDORToolStripMenuItem.Visible = false;

            _conexionSQL conectarBD = _conexionSQL.Instance;
            DataTable resultadoConsulta=new DataTable();
            Boolean retorno = conectarBD.prueba_data(user,ref resultadoConsulta);
            //resultadoConsulta.Columns.Remove


            if (resultadoConsulta.Rows.Count > 1)
            {
                //tiene mas de 1 rol!

                this.comboElegirRol.Items.Clear();

                foreach (DataRow dtRow in resultadoConsulta.Rows)
                {
                    //this.comboElegirRol.Items.Add
                    this.comboElegirRol.Items.Add( dtRow["nombre"].ToString() );
                    //dtRow["nombre"].ToString();

                }

                this.gboxHoraFechaSistema.Visible = false;  //que NO se vea la hora
                this.gboxHoraFechaSistema.Enabled = false;
                this.gboxElegirRol.Visible = true;
                this.gboxElegirRol.Enabled = true;

            }
            else
            {
                this.gboxHoraFechaSistema.Visible = true;  //que se vea la hora
                this.gboxHoraFechaSistema.Enabled = true;

                fcAuxiliarLogin(ref resultadoConsulta);
 



            }


            this.STATUS_LABEL.Text = @"Bienvenido: " + this.txtUsuario.Text;
            this.lidusuario.Text = user;
    
            

            DateTime fechaHoraLocal = Properties.Settings.Default.FECHA_HORA_APP;       //con esto averigua la fechaHora local del sistema
            this.dTimePiker_FechaActual.Value = fechaHoraLocal;
            this.dTimePiker_HoraActual.Value = fechaHoraLocal;
            this.dTimePiker_HoraNueva.Value = fechaHoraLocal;
            this.dTimePiker_FechaNueva.Value = fechaHoraLocal;


            // hago la llamada a la bd con la hora y fecha del sistema..
            this.consultarBDporFechayHora(fechaHoraLocal);
            //agrego unas cosas de la configuracion regional para evitar problemas...

            

         }


        private void fcAuxiliarLogin(ref DataTable resultadoConsulta)
        {

            bool flagAdministrador = false;
            
            //en teoria ahora va a ser solamente 1..
            foreach (DataRow dtRow in resultadoConsulta.Rows)
            {
                switch (dtRow["nombre"].ToString())
                {
                    case "ADMINISTRADOR":
                        
                        /*
                        this.SALIR.Visible = true;
                        this.AMB_ROL.Visible = true;
                        this.AMB_USUARIO.Visible = true;
                        this.cAMBIARMIPWDToolStripMenuItem.Visible = true;

                        this.SALIR.Enabled = true;
                        this.AMB_ROL.Enabled = true;
                        this.AMB_USUARIO.Enabled = true;

                        this.vERIFICARDUPLICADOSToolStripMenuItem.Enabled = true;
                        this.vERIFICARDUPLICADOSToolStripMenuItem.Visible = true;

                        this.cONSULTARESTADISTICASToolStripMenuItem.Enabled = true;
                        this.cONSULTARESTADISTICASToolStripMenuItem.Visible = true;

                        this.cONSULTAFACTURASAVENDEDORToolStripMenuItem.Enabled = true;
                        this.cONSULTAFACTURASAVENDEDORToolStripMenuItem.Visible = true;
                        */
                        fcFuncionalidadDelRol("ADMINISTRADOR");
                        flagAdministrador = true;
                        this.SALIR.Enabled = true;
                        this.SALIR.Visible = true;
                        break;
                        /*
                    case "CLIENTE":
                        this.COMPRA.Enabled = true;
                        this.COMPRA.Visible = true;
                        this.SALIR.Enabled = true;
                        this.SALIR.Visible = true;
                        break;
                        /*
                    case "VENDEDOR":
                        this.PUBLICACION.Visible = true;
                        this.PUBLICACION.Enabled = true;
                        this.SALIR.Enabled = true;
                        this.SALIR.Visible = true;
                        break;
                         * */
                        /*
                    case "EMPRESA":
                        this.PUBLICACION.Visible = true;
                        this.PUBLICACION.Enabled = true;
                        this.SALIR.Enabled = true;
                        this.SALIR.Visible = true;
                        break;
                        */
                    default:
                        this.SALIR.Enabled = true;
                        this.SALIR.Visible = true;
                        fcFuncionalidadDelRol( dtRow["nombre"].ToString() );
                        break;
                         
                }
            }

            if (flagAdministrador)
            {
                this.vERIFICARDUPLICADOSToolStripMenuItem.PerformClick();
                //reviso los registros duplicados...
            }


        }



        private void fcFuncionalidadDelRol(string nombreRol)
        {
            DataTable resultado2 = new DataTable();
            _conexionSQL conectarBD = _conexionSQL.Instance;

            string sql;
            // comienzo....
            sql =  @"   select t3.descripcion as NombreFuncionalidad
                        from DALE_SA.rol t1, DALE_SA.rol_funcionalidad t2, DALE_SA.funcionalidad t3
                        where t1.nombre = RTRIM(LTRIM('" + nombreRol + @"')) 
                            and t1.idrol = t2.idrol and t2.idfuncionalidad = t3.idfuncionalidad
            ";

            resultado2 = conectarBD.ejecutarUnaQuery(sql);
            
            //habilito o deshabilito los menues segun funcionalidades
            foreach (DataRow dtRow in resultado2.Rows)
            {
                switch (dtRow["NombreFuncionalidad"].ToString())
                {
                    case "ABM de ROL":
                        this.AMB_ROL.Visible = true;
                        this.AMB_ROL.Enabled = true;
                        break;
                    case "ABM de USUARIOS":
                        this.AMB_USUARIO.Visible = true;
                        this.AMB_USUARIO.Enabled = true;
                        break;
                    case "ABM de VISIBILIDAD":
                        this.ABM_VIS.Visible = true;
                        this.ABM_VIS.Enabled = true;
                        break;
                    case "ABM de RUBRO":
                        break;
                    case "Facturas por Vendedor":
                        this.cONSULTAFACTURASAVENDEDORToolStripMenuItem.Enabled = true;
                        this.cONSULTAFACTURASAVENDEDORToolStripMenuItem.Visible = true;
                        break;
                    case "Listado Estadistico":
                        this.cONSULTARESTADISTICASToolStripMenuItem.Enabled = true;
                        this.cONSULTARESTADISTICASToolStripMenuItem.Visible = true;
                        break;
                    case "Comprar y Ofertar":
                        this.COMPRA.Enabled = true;
                        this.COMPRA.Visible = true;
                        this.COMPRA_BUSCAR.Enabled = true;
                        this.COMPRA_BUSCAR.Visible = true;
                        break;
                    case "Historial del Cliente y Calificacion":
                        this.miHistorialDeComprasToolStripMenuItem.Visible = true;
                        this.miHistorialDeComprasToolStripMenuItem.Enabled = true;
                        this.calificarToolStripMenuItem.Visible = true;
                        this.calificarToolStripMenuItem.Enabled = true;
                        break;
                    case "Generar Publicacion":
                        this.PUBLICACION.Enabled = true;
                        this.PUBLICACION.Visible = true;
                        this.COMPRA_BUSCAR.Enabled = true;
                        break;
                }
            }

        
        
        }



         private void COMPRA_Click(object sender, EventArgs e)
        {
          //  _conexionSQL conectarBD = _conexionSQL.Instance;
           
        }

         private void Form1_Load(object sender, EventArgs e)
         {
            // _conexionSQL conectarBD = _conexionSQL.Instance;

         }

         private void VENTA_DIRECTA_Click(object sender, EventArgs e)
         {
             WindowsFormsApplication1.Generar_Publicación.publicacion frm = new WindowsFormsApplication1.Generar_Publicación.publicacion(this.lidusuario.Text.ToString());
             frm.Show();


         }

         private void btActualizarHora_Click(object sender, EventArgs e)
         {
             DateTime myDate = dTimePiker_FechaNueva.Value.Date +
                    dTimePiker_HoraNueva.Value.TimeOfDay;

             if ((DateTime.Compare(myDate, (DateTime)Properties.Settings.Default.FECHA_HORA_APP)) < 0)
             {
                 MessageBox.Show("No se puede settear una fecha anterior a la actual.");
                 return;
             }

             Properties.Settings.Default.FECHA_HORA_APP = myDate;
             Properties.Settings.Default.Save();
             Properties.Settings.Default.Reload();

             this.dTimePiker_FechaActual.Value = myDate;
             this.dTimePiker_HoraActual.Value = myDate;
             this.dTimePiker_HoraNueva.Value = myDate;
             this.dTimePiker_FechaNueva.Value = myDate;

             this.consultarBDporFechayHora(myDate);
         }

         private void consultarBDporFechayHora(DateTime myDate)
         {
             //llamar a algun metodo en la BD.
             _conexionSQL conectarBD = _conexionSQL.Instance;
             DataTable resultadoConsulta = new DataTable();

             //string fechaSQL = Properties.Settings.Default.FECHA_HORA_APP.Date.ToString("dd-MM-yyyy hh:mm:ss");

             resultadoConsulta = conectarBD.ejecutarUnaQuery(@"exec DALE_SA.ActualizarFechaHoraBD '" + myDate.ToString("yyyy/MM/dd hh:mm:ss") + @"'");
             System.Console.WriteLine("NUEVA FECHA Y HORA: " + Properties.Settings.Default.FECHA_HORA_APP.ToString("yyyy/MM/dd hh:mm:ss"));
             if (resultadoConsulta != null)
             {
                 System.Console.WriteLine("NUEVA FECHA Y HORA: " + resultadoConsulta.Rows[0][0].ToString());

                 //if (String.Compare(Properties.Settings.Default.FECHA_HORA_APP.ToString(), (DateTime.Parse(resultadoConsulta.Rows[0][0].ToString())).ToString()) == 0)
                 if ((DateTime.Compare(myDate, (DateTime)resultadoConsulta.Rows[0][0])) == 0)
                 {
                     //MessageBox.Show("Se cambio OK la Fecha y Hora en la BD");
                 }
                 else
                 {
                     MessageBox.Show("Hubo problemas al cambiar la fecha y hora en la BD. Por favor revise la conexion");
                 }
                 //Usa un dataTable porque esta usando un metodo generico... para este caso es idem que sea void.
             }
             else
             {
                 MessageBox.Show("Hubo problemas al cambiar la fecha y hora en la BD(Al cerrar publicaciones). Por favor revise la conexion");
             }
         }

         private void COMPRA_BUSCAR_Click(object sender, EventArgs e)
         {
             WindowsFormsApplication1.ComprarOfertar.comprarofertar frm = new WindowsFormsApplication1.ComprarOfertar.comprarofertar(this.lidusuario.Text.ToString());

             frm.Show();
         }

         private void cAMBIARMIPWDToolStripMenuItem_Click(object sender, EventArgs e)
         {
             WindowsFormsApplication1.ABM_Usuario.NewPWD frm = new WindowsFormsApplication1.ABM_Usuario.NewPWD();
             TextBox txt = (TextBox)frm.Controls.Find("txtUsername", true)[0];
             txt.Text = this.txtUsuario.Text;
             TextBox txt2 = (TextBox)frm.Controls.Find("txtIdUsuario", true)[0];
             txt2.Text = this.txtIdUsuario.Text;

             frm.Show();
         }

         private void PUBLICAR_AMB_Click(object sender, EventArgs e)
         {
             

         }

         private void vERIFICARDUPLICADOSToolStripMenuItem_Click(object sender, EventArgs e)
         {
             WindowsFormsApplication1.Z_Codigos_Auxiliares.FormDuplicados frm = new WindowsFormsApplication1.Z_Codigos_Auxiliares.FormDuplicados();

             frm.Show();
         }

         private void miHistorialDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
         {
             WindowsFormsApplication1.Historial_Cliente.Form1 frm = new WindowsFormsApplication1.Historial_Cliente.Form1(this.txtIdUsuario.Text, false);
             
             //TextBox txt = (TextBox)frm.Controls.Find("txtIdUsuario", true)[0];
             //txt.Text = this.txtIdUsuario.Text;
             //MessageBox.Show(this.txtIdUsuario.Text);
             frm.Show();
         }

         private void calificarToolStripMenuItem_Click(object sender, EventArgs e)
         {
             WindowsFormsApplication1.Historial_Cliente.Form1 frm = new WindowsFormsApplication1.Historial_Cliente.Form1(this.txtIdUsuario.Text, true);
             frm.Show();
         }

         private void cONSULTARESTADISTICASToolStripMenuItem_Click(object sender, EventArgs e)
         {
             WindowsFormsApplication1.Listado_Estadistico.Form1 frm = new WindowsFormsApplication1.Listado_Estadistico.Form1();

             frm.Show();
         }

         private void cONSULTAFACTURASAVENDEDORToolStripMenuItem_Click(object sender, EventArgs e)
         {
             WindowsFormsApplication1.Facturas.Form1 frm = new WindowsFormsApplication1.Facturas.Form1();
             frm.Show();
         }

         private void btAceptarElegirRol_Click(object sender, EventArgs e)
         {
             //MessageBox.Show(this.comboElegirRol.Text);


             DataTable resultado2 = new DataTable();
             _conexionSQL conectarBD = _conexionSQL.Instance;

             string sql;
             // comienzo....
             sql = @"select t1.nombre as nombre from DALE_SA.rol t1 where t1.nombre = 
                        RTRIM(LTRIM('" + this.comboElegirRol.Text + @"'))";

             resultado2 = conectarBD.ejecutarUnaQuery(sql);
             fcAuxiliarLogin(ref resultado2);

             this.gboxElegirRol.Visible = false;
             this.gboxElegirRol.Enabled = false;

             this.gboxHoraFechaSistema.Visible = true;  //que se vea la hora
             this.gboxHoraFechaSistema.Enabled = true;
         }

         private void ABM_VIS_Click(object sender, EventArgs e)
         {
             WindowsFormsApplication1.ABM_Visibilidad.AMB_VIS frm = new WindowsFormsApplication1.ABM_Visibilidad.AMB_VIS();
             frm.Show();
         }





        


    }
}
