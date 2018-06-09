using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Z_Codigos_Auxiliares
{
    public partial class FormDuplicados : Form
    {
        public FormDuplicados()
        {
            InitializeComponent();
            this.labelUsuario.Text = "¡TODO OK!  -- No hay registros criticos duplicados";

            /////////////////////////////////////////////////////////////////
            DataTable resultado2 = new DataTable();
            _conexionSQL conectarBD = _conexionSQL.Instance;
            string sql;


            sql = @"SELECT
                        username, COUNT(*) As Cantidad_Repeticiones
                    FROM
                        DALE_SA.usuario
                    GROUP BY
                        username
                    HAVING 
                        COUNT(*) > 1
                    ";
            resultado2 = conectarBD.ejecutarUnaQuery(sql);

            if (resultado2.Rows.Count > 0)
            {
                //do your code 
                this.labelUsuario.Text = "ATENCION! - HAY REGISTROS DUPLICADOS";
            }


            sql = @"SELECT
                        cuit, COUNT(*) As Cantidad_Repeticiones
                    FROM
                        DALE_SA.data_empresa
                    GROUP BY
                        cuit
                    HAVING 
                        COUNT(*) > 1
                    ";
            resultado2 = conectarBD.ejecutarUnaQuery(sql);

            if (resultado2.Rows.Count > 0)
            {
                //do your code 
                this.labelUsuario.Text = "ATENCION! - HAY REGISTROS DUPLICADOS";
            }


            sql = @"SELECT
                        razon_social, COUNT(*) As Cantidad_Repeticiones
                    FROM
                        DALE_SA.data_empresa
                    GROUP BY
                        razon_social
                    HAVING 
                        COUNT(*) > 1
                    ";
            resultado2 = conectarBD.ejecutarUnaQuery(sql);

            if (resultado2.Rows.Count > 0)
            {
                //do your code 
                this.labelUsuario.Text = "ATENCION! - HAY REGISTROS DUPLICADOS";
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DataTable resultado2 = new DataTable();
            _conexionSQL conectarBD = _conexionSQL.Instance;
            string sql;


            sql = @"SELECT
                        username, COUNT(*) As Cantidad_Repeticiones
                    FROM
                        DALE_SA.usuario
                    GROUP BY
                        username
                    HAVING 
                        COUNT(*) > 1
                    ";
            resultado2 = conectarBD.ejecutarUnaQuery(sql);

            this.dataGridView1.DataSource = resultado2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            DataTable resultado2 = new DataTable();
            _conexionSQL conectarBD = _conexionSQL.Instance;
            string sql;


            sql = @"SELECT
                        cuit, COUNT(*) As Cantidad_Repeticiones
                    FROM
                        DALE_SA.data_empresa
                    GROUP BY
                        cuit
                    HAVING 
                        COUNT(*) > 1
                    ";
            resultado2 = conectarBD.ejecutarUnaQuery(sql);

            this.dataGridView1.DataSource = resultado2;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DataTable resultado2 = new DataTable();
            _conexionSQL conectarBD = _conexionSQL.Instance;
            string sql;


            sql = @"SELECT
                        razon_social, COUNT(*) As Cantidad_Repeticiones
                    FROM
                        DALE_SA.data_empresa
                    GROUP BY
                        razon_social
                    HAVING 
                        COUNT(*) > 1
                    ";
            resultado2 = conectarBD.ejecutarUnaQuery(sql);

            this.dataGridView1.DataSource = resultado2;

        }
    }
}
