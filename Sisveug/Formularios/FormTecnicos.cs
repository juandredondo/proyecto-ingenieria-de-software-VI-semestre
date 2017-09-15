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
    public partial class FormTecnicos : Form
    {
        Insertar InsertarRegistros = new Insertar();
        Mostrar MostrarTecnico = new Mostrar();
        Eliminar EliminarTecnico = new Eliminar();
        Insertar EditarTecnico= new Insertar();

        public FormTecnicos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            InsertarRegistros.InsertarBd("insertar_tecnicos", "Pidtecnico", "Pnombre",  "Pdireccion" ,"Ptelefono", "Pemail", Txtidtecnico.Text, Txtnombretecnico.Text,  Txtdireccion.Text, Txttef.Text, Txtemail.Text);
            MostrarTecnico.MostrarDatos(Drglistaclientes, "mostrar_tecnico", "", "Pnombre");
            LimpiarTxt();
        }
        private void LimpiarTxt()
        {

            Txtdireccion.Text = "";
            Txtemail.Text = "";
            Txtidtecnico.Text = "";
            Txtnombretecnico.Text = "";
            Txttef.Text = "";
        }
        private void SalirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTecnicos_Load(object sender, EventArgs e)
        {
            MostrarTecnico.MostrarDatos(Drglistaclientes, "mostrar_tecnico", "", "Pnombre");
        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarTecnico.MostrarDatos(Drglistaclientes, "mostrar_tecnico", Txtbuscar.Text, "Pnombre");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Id = Convert.ToString(Drglistaclientes.CurrentRow.Cells["idtecnico"].Value);
            string Nombre = Convert.ToString(Drglistaclientes.CurrentRow.Cells["nombre"].Value);

            DialogResult dialog = MessageBox.Show("Esta seguro que desea eliminar el este registro " + Id + " " + Nombre + " No se podran deshacer los cambios", "Eliminar Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (dialog == DialogResult.OK)
            {
                EliminarTecnico.EliminarDatos("eliminar_tecnico", "Pidtecnico", Id);
                MostrarTecnico.MostrarDatos(Drglistaclientes, "mostrar_tecnico", "", "Pnombre");
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Txtidtecnico.Enabled = false;
            BtnGuardar.Enabled = false;
            string varid = (string)Drglistaclientes.CurrentRow.Cells["idtecnico"].Value;
            string varnombre = (string)Drglistaclientes.CurrentRow.Cells["nombre"].Value;
            string vartelf = (string)Drglistaclientes.CurrentRow.Cells["telefono"].Value;
            string vardir = (string)Drglistaclientes.CurrentRow.Cells["direccion"].Value;
            string varemail = (string)Drglistaclientes.CurrentRow.Cells["email"].Value;
            Txtnombretecnico.Text = varnombre;
            Txttef.Text = vartelf;
            Txtdireccion.Text = vardir;
            Txtemail.Text = varemail;
            Txtidtecnico.Text = varid;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            InsertarRegistros.InsertarBd("editar_tecnico", "Pidtecnico", "Pnombre", "Pdireccion", "Ptelefono", "Pemail", Txtidtecnico.Text, Txtnombretecnico.Text, Txtdireccion.Text, Txttef.Text, Txtemail.Text);
           MostrarTecnico.MostrarDatos(Drglistaclientes, "mostrar_tecnico", " ", "Pnombre"); // volvemos a mostrar los datos guardados 
            Txtidtecnico.Focus();
            LimpiarTxt();
            Txtidtecnico.Enabled = true;
            BtnGuardar.Enabled = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarTxt();
            BtnGuardar.Enabled = true;
        }
    }
}
