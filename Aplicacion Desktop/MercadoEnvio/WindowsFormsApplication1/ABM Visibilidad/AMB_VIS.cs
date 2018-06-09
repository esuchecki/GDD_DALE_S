using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ABM_Visibilidad
{
    public partial class AMB_VIS : Form
    {
        private publicar_dto dto;
        public AMB_VIS()
        {
            InitializeComponent();
            dto = new publicar_dto();
        }

        private void AMB_VIS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aBM_VISDs.visibilidad' Puede moverla o quitarla según sea necesario.
            this.visibilidadTableAdapter.Fill(this.aBM_VISDs.visibilidad);
            this.dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {
           
            if (e.RowIndex >= 0)
                {
                    //this.dataGridView1.Visible = true;
                    this.modificar.Enabled = true;
                    this.modificar.Visible = true;
                    this.borrar.Visible = true;
                    this.borrar.Enabled = true;
                    this.actualizar.Text = "Actualizar";
                    this.borrar.Text = "Borrar";
                    DataGridViewRow fila = this.dataGridView1.Rows[e.RowIndex];




                    this.dto.setidvisibilidad(fila.Cells["idvisibilidad"].Value.ToString());
                    
                        this.TBDescripcion.Text= fila.Cells["descripcionDV"].Value.ToString();
                        this.dto.setdescp(this.TBDescripcion.Text);
                        this.codigo.Text = fila.Cells["codigoDv"].Value.ToString();
                        this.dto.setidrubro(this.codigo.Text);
                        this.porcentaje.Value = System.Convert.ToDecimal(fila.Cells["porcentaje_venta"].Value);
                        this.dto.setporc(this.porcentaje.Value.ToString());
                        this.Envio.Value = System.Convert.ToDecimal(fila.Cells["precio_envio"].Value);
                        this.dto.setcosto(this.Envio.Value.ToString());
                        this.precio.Value = System.Convert.ToDecimal(fila.Cells["precio_publicacion"].Value);
                        this.dto.setprecio(this.precio.Value.ToString());
                        this.dto.settipo_publicacion("2");
                    }
                       
                    
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            this.dto.settipo_publicacion("1"); 
            this.modificar.Enabled = true;
            this.modificar.Visible = true;
            //this.borrar.Enabled = false;
            //this.borrar.Visible = false;
            this.TBDescripcion.Text = "";
            this.codigo.Text = "";
            this.porcentaje.Value = 0;
            this.precio.Value = 0;
            this.Envio.Value = 0;
            this.actualizar.Text = "Guardar";
            this.borrar.Text = "Cancelar";

            //this.dataGridView1.Visible = false;
            this.dataGridView1.ClearSelection();
            this.dto.setidvisibilidad("0");
            this.dto.setestado("1");

            this.dataGridView1.Enabled = false;
            //this.dataGridView1.ReadOnly = true;
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            if (this.borrar.Text == "Borrar")
            {
                int retorno;
                this.dto.setestado("0");
                this.dto.settipo_publicacion("3");



                this.dto.setdescp(this.TBDescripcion.Text);

                this.dto.setidrubro(this.codigo.Text);

                this.dto.setporc(this.porcentaje.Value.ToString());

                this.dto.setcosto(this.Envio.Value.ToString());

                this.dto.setprecio(this.precio.Value.ToString());

                _conexionSQL conectarBD = _conexionSQL.Instance;
                retorno = conectarBD.AMBvisibilidad(this.dto);
                if (retorno.Equals(3)) MessageBox.Show("Visibilidad borrada correctamente");
                else MessageBox.Show("Hubo un problema con la peticion, intente mas tarde");

                this.visibilidadTableAdapter.Fill(this.aBM_VISDs.visibilidad);
                this.dataGridView1.ClearSelection();
                this.modificar.Enabled = false;
                this.modificar.Visible = false;
            }
            else
            {
                this.dataGridView1.Enabled = true;
                //this.dataGridView1.ReadOnly = false;
                this.visibilidadTableAdapter.Fill(this.aBM_VISDs.visibilidad);
                this.dataGridView1.ClearSelection();
                this.modificar.Enabled = false;
                this.modificar.Visible = false;
            }
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            int retorno;
            _conexionSQL conectarBD = _conexionSQL.Instance;
            //this.dto.setidvisibilidad(fila.Cells["idvisibilidad"].Value.ToString());
            //MessageBox.Show("idv"+dto.getidvisibilidad());
            //this.TBDescripcion.Text = fila.Cells["descripcionDV"].Value.ToString();
            this.dto.setdescp(this.TBDescripcion.Text);
            if (dto.getdescripcion().Equals(""))
            {
                MessageBox.Show("Descripcion no puede ser vacio");
                return;
            }
            this.dto.setestado("1");
            //MessageBox.Show("D"+dto.getdescripcion());
           // this.codigo.Text = fila.Cells["codigoDv"].Value.ToString();
            this.dto.setidrubro(this.codigo.Text);
            if (dto.getidrubro().Equals(""))
            {
                MessageBox.Show("Rubro no puede ser vacio");
                return;
            }
            //MessageBox.Show("C"+dto.getidrubro());
            //this.porcentaje.Value = System.Convert.ToDecimal(fila.Cells["porcentaje_venta"].Value);
            this.dto.setporc(this.porcentaje.Value.ToString());
            //MessageBox.Show("P"+dto.getporc());
            //this.Envio.Value = System.Convert.ToDecimal(fila.Cells["precio_envio"].Value);
            this.dto.setcosto(this.Envio.Value.ToString());
            //MessageBox.Show("E"+dto.getcosto());
            //this.precio.Value = System.Convert.ToDecimal(fila.Cells["precio_publicacion"].Value);
            this.dto.setprecio(this.precio.Value.ToString());
            //MessageBox.Show("Preci"+dto.getprecio());
            if (this.actualizar.Text == "Actualizar") 
                this.dto.settipo_publicacion("2");

           retorno=conectarBD.AMBvisibilidad(this.dto);
           if (retorno.Equals(2)) MessageBox.Show("Visibilidad actualizada correctamente");
           if (retorno.Equals(1)) MessageBox.Show("Visibilidad guardada correctamente");
           if (retorno.Equals(-2)) MessageBox.Show("Visibilidad no actualizada, descripcion repetida");
           if (retorno.Equals(-1)) MessageBox.Show("Visibilidad no guardada, descripcion repetida");
           if (retorno.Equals(1) || retorno.Equals(2))
           {
               this.dataGridView1.Enabled = true;
              // this.dataGridView1.ReadOnly = false;
               this.visibilidadTableAdapter.Fill(this.aBM_VISDs.visibilidad);
               this.dataGridView1.ClearSelection();
               this.modificar.Enabled = false;
               this.modificar.Visible = false;

           }
        }

        //C# version for buttons also. Inspired by sveilleux2.
        private void dataGridView1_EnabledChanged(object sender, EventArgs e)
        {
            if (!this.dataGridView1.Enabled)
            {
                this.dataGridView1.DefaultCellStyle.BackColor = SystemColors.Control;
                this.dataGridView1.DefaultCellStyle.ForeColor = SystemColors.GrayText;
                this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.GrayText;
                //Disable two colums of buttons
                /*
                for (int i = 0; i < this.dataGridView1.RowCount; i++)
                {
                    DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)this.dataGridView1.Rows[i].Cells[1];
                    buttonCell.FlatStyle = FlatStyle.Popup;
                    buttonCell.Style.ForeColor = SystemColors.GrayText;
                    buttonCell.Style.BackColor = SystemColors.Control;
                    DataGridViewButtonCell buttonCell_2 = (DataGridViewButtonCell)this.dataGridView1.Rows[i].Cells[6];
                    buttonCell_2.FlatStyle = FlatStyle.Popup;
                    buttonCell_2.Style.ForeColor = SystemColors.GrayText;
                    buttonCell_2.Style.BackColor = SystemColors.Control;
                }
                */
                //this.dataGridView1.Columns[1].DefaultCellStyle.ForeColor = SystemColors.GrayText;
               // this.dataGridView1.Columns[1].DefaultCellStyle.BackColor = SystemColors.Control;
                //this.dataGridView1.ReadOnly = true;
                this.dataGridView1.EnableHeadersVisualStyles = false;
                this.dataGridView1.CurrentCell = null;
            }
            else
            {
                this.dataGridView1.DefaultCellStyle.BackColor = SystemColors.Window;
                this.dataGridView1.DefaultCellStyle.ForeColor = SystemColors.ControlText;
                this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Window;
                this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;
                //this.dataGridView1.ReadOnly = false;
                this.dataGridView1.EnableHeadersVisualStyles = false;

                /*
                //Enable two colums of buttons
                for (int i = 0; i < this.dataGridView1.RowCount; i++)
                {
                    DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)this.dataGridView1.Rows[i].Cells[1];
                    buttonCell.FlatStyle = FlatStyle.Standard;
                    DataGridViewButtonCell buttonCell_2 = (DataGridViewButtonCell)this.dataGridView1.Rows[i].Cells[6];
                    buttonCell_2.FlatStyle = FlatStyle.Standard;
                }
                 * */
            }
        }






    }
}
