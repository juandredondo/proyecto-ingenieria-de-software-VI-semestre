using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// clases mas utilizadas
using System.Data;// para operaciones con datos 
using MySql.Data;// para operacines con mysql 
using MySql.Data.MySqlClient;
using Sisveug.MisClases;


namespace Sisveug.Formularios
{
    public partial class FormEquipos : Form
    {
        Insertar RegistrarEquipo= new Insertar();
        Mostrar MostrarEquipo=new Mostrar();
        Eliminar EliminarEquipo = new Eliminar();
        public FormEquipos()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistrarEquipo.InsertarBd2("insertar_equipo", "Pnombreequipo", "Pserie", Txtnombreequipo.Text, Txtserie.Text);
            MostrarEquipo.MostrarDatos(Drglistaequipo, "mostrar_equipo", "", "Pnombreequipo");
            limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Txtbuscar.Text = "";
            Txtidequipo.Text = "";
            Txtnombreequipo.Text = "";
            Txtserie.Text = "";
            btnguardar.Enabled = true;
        }

        private void FormEquipos_Load(object sender, EventArgs e)
        {
            MostrarEquipo.MostrarDatos(Drglistaequipo, "mostrar_equipo", "", "Pnombreequipo");
            Txtidequipo.Enabled = false;
        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarEquipo.MostrarDatos(Drglistaequipo, "mostrar_equipo", Txtbuscar.Text, "Pnombreequipo");
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Id = Convert.ToString(Drglistaequipo.CurrentRow.Cells["idequipo"].Value);
            string Nombre = Convert.ToString(Drglistaequipo.CurrentRow.Cells["nombreequipo"].Value);


            //MessageBox.Show(valor.ToString());

            DialogResult dialog = MessageBox.Show("Esta seguro que desea eliminar el este registro " + Id + " " + Nombre + " No se podran deshacer los cambios", "Eliminar Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (dialog == DialogResult.OK)
            {
                EliminarEquipo.EliminarDatos("eliminar_equipo", "Pidequipo", Id);
                MostrarEquipo.MostrarDatos(Drglistaequipo, "mostrar_equipo", " ", "Pnombreequipo");
                limpiar();
            }
        }
        public void limpiar() {
            Txtidequipo.Text = "";
            Txtnombreequipo.Text = "";
            Txtserie.Text = "";
            Txtbuscar.Text = "";
            btnguardar.Enabled = true;
        }
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int64 varid = (Int64)Drglistaequipo.CurrentRow.Cells["idequipo"].Value;
            string varnom = (string)Drglistaequipo.CurrentRow.Cells["nombreequipo"].Value;
            string varser = (string)Drglistaequipo.CurrentRow.Cells["serie"].Value;
            Txtidequipo.Text = varid.ToString();
            Txtnombreequipo.Text = varnom;
            Txtserie.Text = varser;
            btnguardar.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegistrarEquipo.ModificarBd("editar_equipo", "Pidequipo", "Pnombreequipo", "Pserie", Txtidequipo.Text, Txtnombreequipo.Text, Txtserie.Text);
            MostrarEquipo.MostrarDatos(Drglistaequipo, "mostrar_equipo", " ", "Pnombreequipo");
            btnguardar.Enabled = true;
            limpiar();
            
        }
    }
}
