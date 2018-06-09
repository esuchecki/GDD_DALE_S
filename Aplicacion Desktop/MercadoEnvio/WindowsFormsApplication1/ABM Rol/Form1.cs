using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.txtEjemplo.Visible = false;
            //this.Text = _Parametros._infoGrupoGD + " - " + _Parametros._nombreAplicacion;
            this.Text = "ABM_ROL";

            this.modificarFuncionalidadToolStripMenuItem.Enabled = false;
            this.crearNuevaFuncionalidadToolStripMenuItem.Enabled = false;
            this.eliminarFuncionalidadToolStripMenuItem.Enabled = false;
            this.txtIdRol.Visible = false;
            this.btGuardarCambios.Visible = false;
            this.btDeshacerCambios.Visible = false;
            this.gboxCrearModificarGrupo.Enabled = false;
            this.gboxCrearModificarGrupo.Visible = false;
            this.btDeshacerCambios.PerformClick();
            this.dgvFuncionesAsignadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //hago que seleccione toda la fila
            this.dgvFuncionesDisp.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //hago que seleccione toda la fila
            this.habilitarToolStripMenuItem.Enabled = false;
            this.desToolStripMenuItem.Enabled = false;
            this.modificarEliminarRolToolStripMenuItem.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aBM_ROL_FUNCIONALIDAD.rol_funcionalidad' Puede moverla o quitarla según sea necesario.
            this.rol_funcionalidadTableAdapter.Fill(this.aBM_ROL_FUNCIONALIDAD.rol_funcionalidad);
            // TODO: esta línea de código carga datos en la tabla 'aBM_ROL1.rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.aBM_ROL1.rol);

        }

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Hacemos que cuando cliqueamos en el datagrid, cambie el valor del textbox
                int d = dgvRoles.CurrentCell.RowIndex;
                DataGridViewRow row = this.dgvRoles.Rows[d];
                
                //Suponemos: 0  -> rolid   
                //           1  -> nombre
                //           2  -> estado

                txtRolSeleccionado.Text = row.Cells[1].Value.ToString();
                txtIdRol.Text = row.Cells[0].Value.ToString();
                DataTable resultado = new DataTable();

                _conexionSQL conectarBD = _conexionSQL.Instance;
                //retorno=conectarBD.prueba_login(user, password);
                conectarBD.consultar_rol_x_funcionalidad( Convert.ToInt32(row.Cells[0].Value.ToString()) , true, ref resultado);
                
                dgvFuncionalidadesDelRol.DataSource = resultado;


                menuContextual(Convert.ToBoolean (row.Cells[2].Value.ToString()));

                //si el rol es administrador, no se puede modificar, ni cambiar el estado.
                if (String.Compare(txtRolSeleccionado.Text, _Parametros._SQL_nombreAdministrador) == 0)
                {
                    modificarEliminarRolToolStripMenuItem.Enabled = false;
                    habilitarToolStripMenuItem.Enabled = false;
                    desToolStripMenuItem.Enabled = false;
                }
                else
                {
                    modificarEliminarRolToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void habilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _conexionSQL conectarBD = _conexionSQL.Instance;
            conectarBD.cambiar_estado_rol(Convert.ToInt32(txtIdRol.Text), 1);
            menuContextual(true);
            MessageBox.Show("Puede que algunos cambios no surtan efecto hasta que se vuelva a ingresar al aplicativo");
            //El msgbox esta debido a que un usuario puede estar logueado haciendo cosas y el aplicativo no valida si se dio de baja algun rol.

            //refresco el datagrid para ver los cambios
            DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
            ch1 = (DataGridViewCheckBoxCell)dgvRoles.Rows[dgvRoles.CurrentRow.Index].Cells[2];
            ch1.Value = true;
        }

        private void desToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _conexionSQL conectarBD = _conexionSQL.Instance;
            conectarBD.cambiar_estado_rol(Convert.ToInt32(txtIdRol.Text), 0);
            menuContextual(false);
            MessageBox.Show("Puede que algunos cambios no surtan efecto hasta que se vuelva a ingresar al aplicativo");
            //El msgbox esta debido a que un usuario puede estar logueado haciendo cosas y el aplicativo no valida si se dio de baja algun rol.

            //refresco el datagrid para ver los cambios
            DataGridViewCheckBoxCell ch1 = new DataGridViewCheckBoxCell();
            ch1 = (DataGridViewCheckBoxCell)dgvRoles.Rows[dgvRoles.CurrentRow.Index].Cells[2];
            ch1.Value = false;
        }

        private void menuContextual(Boolean asd)
        {
            //tuneamos un poco el menu para que solo deje habilitar o inhabilitar segun corresponda.

            if (asd)    //si esta activo
            {
                habilitarToolStripMenuItem.Enabled = false;
                desToolStripMenuItem.Enabled = true;
            }
            if (!asd)    //si esta deshabilitado
            {
                habilitarToolStripMenuItem.Enabled = true;
                desToolStripMenuItem.Enabled = false;
            }
        }

        private void crearNuevoRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.gboxVerRolesGrupo.Enabled = false;
            this.gboxVerRolesGrupo.Visible = false;
            this.gboxCrearModificarGrupo.Enabled = true;
            this.gboxCrearModificarGrupo.Visible = true;
            //this.dataGridView4 datagrid de la izquierda
            //this.datagridview3 -> de la derecha
            this.gboxCrearModificarGrupo.Text = "Crear Nuevo Rol";
            this.label2.Text = "Nombre: ";
            this.txtNuevoRol.Text = "";
            this.btGuardarCambios.Visible = true;
            this.btDeshacerCambios.Visible= true;

            DataTable resultado;
            _conexionSQL conectarBD = _conexionSQL.Instance;
            resultado = conectarBD.ejecutarUnaQuery(_Parametros._SQL_verFuncionalidades);
            this.dgvFuncionesDisp.DataSource = resultado;
            this.dgvFuncionesAsignadas.DataSource = null;
            

        }

        private void btDeshacerCambios_Click(object sender, EventArgs e)
        {
            this.gboxVerRolesGrupo.Enabled = true;
            this.gboxVerRolesGrupo.Visible = true;
            this.gboxCrearModificarGrupo.Enabled = false;
            this.gboxCrearModificarGrupo.Visible = false;
            //this.dataGridView4 datagrid de la izquierda
            //this.datagridview3 -> de la derecha
            //this.CrearModificarGrupo.Text = "Crear Nuevo Rol";
            //this.label2.Text = "Nombre: ";
            //this.txtNuevoRol.Text = "";
            this.btGuardarCambios.Visible = false;
            this.btDeshacerCambios.Visible = false;
            this.dgvFuncionesDisp.DataSource = null;
            this.dgvFuncionesAsignadas.DataSource = null;
            this.modificarFuncionalidadToolStripMenuItem.Enabled = false;
            this.crearNuevaFuncionalidadToolStripMenuItem.Enabled = false;
            this.eliminarFuncionalidadToolStripMenuItem.Enabled = false;
            this.habilitarToolStripMenuItem.Enabled = false;
            this.desToolStripMenuItem.Enabled = false;
            this.modificarEliminarRolToolStripMenuItem.Enabled = false;
        }

        private void bt_Izq_A_Der_Click(object sender, EventArgs e)
        {
            //Este metodo me pasa las funcionalidades de izquierda a derecha.
            

            //primero recorro la tabla de la derecha y rearmo la lista
             List<object> destList = new List<object>();
            foreach (DataGridViewRow row in dgvFuncionesAsignadas.Rows)       
                destList.Add(row.DataBoundItem);

            //dps agrego las nuevas filas seleccionadas
            foreach (DataGridViewRow row in dgvFuncionesDisp.SelectedRows)
            {
                destList.Add(row.DataBoundItem);
                //y las borro de la tabla de la izquierda.
                dgvFuncionesDisp.Rows.RemoveAt(row.Index);
            }
            
            //se las asgino a la tabla de la derecha.
            dgvFuncionesAsignadas.DataSource = new BindingList<object>(destList);   //hago asi para despues poder eliminar los registros de la otra tabla.
            dgvFuncionesAsignadas.Refresh();
        }

        private void bt_Der_A_Izq_Click(object sender, EventArgs e)
        {
                //primero recorro la tabla de la izquierda y rearmo la lista
                List<object> destList = new List<object>();
                foreach (DataGridViewRow row in dgvFuncionesDisp.Rows)
                    destList.Add(row.DataBoundItem);

                //dps agrego las nuevas filas seleccionadas
                foreach (DataGridViewRow row in dgvFuncionesAsignadas.SelectedRows)
                {
                    destList.Add(row.DataBoundItem);
                    //y las borro de la tabla de la izquierda.
                    dgvFuncionesAsignadas.Rows.RemoveAt(row.Index);
                }

                //se las asgino a la tabla de la izquierda.

                var bindingList = new BindingList<object>(destList);
                var source = new BindingSource(bindingList, null);
                dgvFuncionesDisp.DataSource = source;
        }

        private void btGuardarCambios_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNuevoRol.Text))
            {
                MessageBox.Show("Por favor escriba un nombre");
                return;
            }

            //if (String.Compare(txtNuevoRol.Text, _Parametros._SQL_nombreAdministrador)==0)
            if (txtNuevoRol.Text.Contains(_Parametros._SQL_nombreAdministrador) == true)
            {
                MessageBox.Show("No se puede crear un rol con el nombre: "+ _Parametros._SQL_nombreAdministrador +". Este nombre se encuentra reservado");
                return;
            }


            DataTable resultado2 = new DataTable();
            _conexionSQL conectarBD = _conexionSQL.Instance;

            if (String.Compare(this.gboxCrearModificarGrupo.Text, "Crear Nuevo Rol") == 0)
            {
                //validamos que el rol no exista...
                string sql;
                sql = @"select count(t1.nombre) 
                            from DALE_SA.rol t1 
                            where t1.nombre = Rtrim(Ltrim('" + this.txtNuevoRol.Text + @"'))
                        ";
                resultado2 = conectarBD.ejecutarUnaQuery(sql);

                if (resultado2.Rows[0][0].Equals(0))
                {
                    //no existia
                }
                else
                {
                    MessageBox.Show("El nombre del rol ya existe en la BD, por favor pruebe otro..");
                    return;
                }

            }

            if (String.Compare(this.gboxCrearModificarGrupo.Text, "Modificar Rol Seleccionado") == 0)
            {
                //tenemos que validar si el usuario existia pero que no sea el mismo...
                string sql;
                sql = @"select count(t1.nombre) 
                            from DALE_SA.rol t1 
                            where t1.nombre = Rtrim(Ltrim('" + this.txtNuevoRol.Text + @"')) and t1.idrol != " + this.txtIdRol.Text + @"
                        ";
                resultado2 = conectarBD.ejecutarUnaQuery(sql);

                if (resultado2.Rows[0][0].Equals(0))
                {
                    //no existia
                }
                else
                {
                    MessageBox.Show("El nombre del rol ya existe en la BD, por favor pruebe otro..");
                    return;
                }

            }


            List<object> destList = new List<object>();
            foreach (DataGridViewRow row in dgvFuncionesAsignadas.Rows)
                destList.Add(row.DataBoundItem);

            if (destList.Count < 1)
            {
                MessageBox.Show("Por favor Agrege al menos 1 funcionalidad");
                return;
            }



            //_conexionSQL conectarBD = _conexionSQL.Instance;
            int idNuevoRol = 0;

            if (String.Compare(this.gboxCrearModificarGrupo.Text, "Modificar Rol Seleccionado") ==0)
            {
                idNuevoRol = Convert.ToInt32(this.txtIdRol.Text);
            }
            else
            {
                //si no estaba creado el rol, lo creo
                // luego le agrego las funcionalidades...
                idNuevoRol = conectarBD.crearRol(txtNuevoRol.Text);

                if (idNuevoRol == 0)
                {
                    MessageBox.Show("Hubo algun problema al crear el nuevo Rol. Revise si el nombre ya existia");
                    return;
                }
            }
            DataTable dt = new DataTable();
            //dt = (DataTable) (dataGridView3.DataSource);

            //BindingSource bs = (BindingSource)dataGridView3.DataSource; // Se convierte el DataSource 
            //DataTable dt = (DataTable)bs.DataSource;

            dt = GetDataTableFromDGV(dgvFuncionesAsignadas);

            Boolean resultado = conectarBD.modificar_Rol_Funcionalidad(idNuevoRol, txtNuevoRol.Text, dt);

            if (!(resultado))
            {
                if (String.Compare(this.gboxCrearModificarGrupo.Text, "Modificar Rol Seleccionado") ==0)
                {
                    MessageBox.Show("Hubo problemas al cambiar el nombre o asignar las funcionalidades del nuevo Rol. Revise si el nombre ya existia.");
                    return;
                }
                else
                {
                    MessageBox.Show("Se creo el nuevo rol pero hubo algun problema al crear las funcionalidades del nuevo Rol.");
                    return;
                }
            }

            MessageBox.Show("Todo bien. Puede que algunos cambios no surtan efecto hasta que se vuelva a ingresar al aplicativo");

            btDeshacerCambios.PerformClick();     //salgo de todo esto
            
            WindowsFormsApplication1.ABM_Rol.Form1 frm = new WindowsFormsApplication1.ABM_Rol.Form1();
            frm.Show();

            this.Close();



        }


        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    // You could potentially name the column based on the DGV column name (beware of dupes)
                    // or assign a type based on the data type of the data bound to this DGV column.
                    dt.Columns.Add();
                }
            }

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }

            return dt;
        }

        private void modificarEliminarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtIdRol.Text))
            {
                MessageBox.Show("Por favor seleccione algun rol para modificar.");
                return;
            }

            if (desToolStripMenuItem.Enabled == false)  //si esta deshabilitado
            {
                MessageBox.Show("Por favor seleccione algun rol habilitado.");
                return;
            }
            else
            {
                this.gboxVerRolesGrupo.Enabled = false;
                this.gboxVerRolesGrupo.Visible = false;
                this.gboxCrearModificarGrupo.Enabled = true;
                this.gboxCrearModificarGrupo.Visible = true;
                //this.dataGridView4 datagrid de la izquierda
                //this.datagridview3 -> de la derecha
                this.gboxCrearModificarGrupo.Text = "Modificar Rol Seleccionado";
                this.label2.Text = "Nombre: ";
                this.txtNuevoRol.Text = txtRolSeleccionado.Text;
                this.btGuardarCambios.Visible = true;
                this.btDeshacerCambios.Visible = true;
                habilitarToolStripMenuItem.Enabled = false;
                desToolStripMenuItem.Enabled = false;



                //cargamos los datos actuales en la tabla de la derecha
                DataTable resultado = new DataTable(); ;
                _conexionSQL conectarBD = _conexionSQL.Instance;
                resultado = conectarBD.ejecutarUnaQuery(_Parametros._SQL_verFuncionalidades);
                dgvFuncionesAsignadas.DataSource = resultado;

                
                //Este metodo me pasa las funcionalidades de izquierda a derecha.

                var resultado2 = new DataTable();
                conectarBD.consultar_rol_x_funcionalidad(Convert.ToInt32(txtIdRol.Text), false, ref resultado2);
                dgvFuncionesDisp.DataSource = resultado2;

                //primero recorro la tabla de la derecha y rearmo la lista
                List<object> destList = new List<object>();
                foreach (DataGridViewRow row in dgvFuncionesDisp.Rows)
                {
                    foreach (DataGridViewRow row2 in dgvFuncionesAsignadas.Rows)
                    {
                        if (string.Compare(row.Cells[0].Value.ToString(), row2.Cells[0].Value.ToString()) == 0)
                        {
                            if (string.Compare(row.Cells[0].Value.ToString(), _Parametros._SQL_idDeLaFuncionalidadAdministrador) == 0)
                            {
                                //hacemos que no se le pueda asignar la funcionalidad de administrador a un nuevo rol.
                                //ni tampoco modificar.. (segun enunciado, administradores son fijos).
                                dgvFuncionesAsignadas.Rows.RemoveAt(row2.Index);
                            }
                            else
                            {
                                destList.Add(row2.DataBoundItem);
                                dgvFuncionesAsignadas.Rows.RemoveAt(row2.Index);
                            }
                        }
                    }
                }

                //dps agrego las nuevas filas seleccionadas
                dgvFuncionesDisp.DataSource = new BindingList<object>(destList);   //hago asi para despues poder eliminar los registros de la otra tabla.
                dgvFuncionesDisp.Refresh();

            }
        }






    }
}
