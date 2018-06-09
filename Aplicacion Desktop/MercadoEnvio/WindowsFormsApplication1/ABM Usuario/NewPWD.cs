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
    public partial class NewPWD : Form
    {
        public NewPWD()
        {
            InitializeComponent();
            this.txtConfirmarPWD.Text = "";
            this.txtNewPWD.Text = "";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.txtConfirmarPWD.Text = "";
            this.txtNewPWD.Text = "";
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (String.Compare(this.txtNewPWD.Text, this.txtConfirmarPWD.Text) != 0)
            {
                MessageBox.Show("La nueva contraseña y la confirmacion no coinciden");
                return;
            }

            if (this.txtNewPWD.Text.Length < _Parametros._longitudMinimaDePWD)
            {
                MessageBox.Show("La nueva contraseña es muy corta");
                return;
            }

            if ( (String.IsNullOrWhiteSpace(this.txtIdUsuario.Text)) || (String.IsNullOrWhiteSpace(this.txtUsername.Text)) )
            {
                MessageBox.Show("Hubo un problema al identificar el usuario al cual se quiere cambiar la contraseña");
                return;
            }

            string password;
            password = _SHA256Encrypt.encriptar(this.txtNewPWD.Text);

            //conectar a la BD y cambiar las cosas..
            string sql;
            sql = @"EXEC DALE_SA.prCambiarPWD   '" + this.txtIdUsuario.Text + @"'
                                                ,'" + password + @"'
                        ";

            DataTable respuesta = new DataTable(); 

            _conexionSQL conectarBD = _conexionSQL.Instance;
            respuesta = conectarBD.ejecutarUnaQuery(sql);

            if (!respuesta.Rows[0][0].Equals(1))
            {
                MessageBox.Show("Hubo un problema al cambiar la contraseña");
                return;
            }
            else
            {
                MessageBox.Show("Se cambio la contraseña");
                this.btCancelar.PerformClick();
            }



        }
    }
}
