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
    public partial class FormClientes : Form
    {

        // espacio para declarar objetos 
        Insertar InsertarRegistros = new Insertar();
        Mostrar MostrarCliente = new Mostrar();
        Eliminar EliminarCliente = new Eliminar();
        Insertar EditarCliente = new Insertar();



        public FormClientes()
        {
            InitializeComponent();
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            InsertarRegistros.InsertarBd("insertar_cliente", "Pidcliente", "Pnombre", "Ptelefono", "Pdireccion", "Pemail",Txtidcliente.Text, Txtnombrecliente.Text, Txttef.Text, Txtdireccion.Text, Txtemail.Text);
            MostrarCliente.MostrarDatos(Drglistaclientes, "mostrar_cliente", "", "Pnombre");
            LimpiarTxt();


        }
        private  void LimpiarTxt()
        {

            Txtdireccion.Text="";
              Txtemail.Text="";
              Txtidcliente.Text="";
              Txtnombrecliente.Text="";
            Txttef.Text="";
            Txtbuscar.Text = "";
        }

        private void FormEjemplo_Load(object sender, EventArgs e)
        {
            MostrarCliente.MostrarDatos(Drglistaclientes, "mostrar_cliente", "", "Pnombre");

        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarCliente.MostrarDatos(Drglistaclientes, "mostrar_cliente", Txtbuscar.Text, "Pnombre");
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Id = Convert.ToString(Drglistaclientes.CurrentRow.Cells["idcliente"].Value);
            string Nombre = Convert.ToString(Drglistaclientes.CurrentRow.Cells["nombre"].Value);


            //MessageBox.Show(valor.ToString());

            DialogResult dialog = MessageBox.Show("Esta seguro que desea eliminar el este registro " + Id + " " + Nombre + " No se podran deshacer los cambios", "Eliminar Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (dialog == DialogResult.OK)
            {
                EliminarCliente.EliminarDatos("eliminar_cliente", "Pidcliente", Id);
                MostrarCliente.MostrarDatos(Drglistaclientes, "mostrar_cliente", "", "Pnombre");
            }






        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            BtnGuardar.Enabled = true;
           
            InsertarRegistros.InsertarBd("editar_cliente", "Pidcliente", "Pnombre", "Ptelefono", "Pdireccion", "Pemail", Txtidcliente.Text, Txtnombrecliente.Text, Txttef.Text, Txtdireccion.Text, Txtemail.Text);
            MostrarCliente.MostrarDatos(Drglistaclientes, "mostrar_cliente", " ", "Pnombre"); // volvemos a mostrar los datos guardados 
            Txtidcliente.Focus();
            LimpiarTxt();
            Txtidcliente.Enabled = true;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

        }






        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Txtidcliente.Enabled = false;
            BtnGuardar.Enabled = false;
            string varid = (string)Drglistaclientes.CurrentRow.Cells["idcliente"].Value;
            string varnombre = (string)Drglistaclientes.CurrentRow.Cells["nombre"].Value;
            string vartelf = (string)Drglistaclientes.CurrentRow.Cells["telefono"].Value;
            string vardir = (string)Drglistaclientes.CurrentRow.Cells["direccion"].Value;
            string varemail = (string)Drglistaclientes.CurrentRow.Cells["email"].Value;
            Txtnombrecliente.Text = varnombre;
            Txttef.Text = vartelf;
            Txtdireccion.Text = vardir;
            Txtemail.Text = varemail;
            Txtidcliente.Text = varid;
            
        }
        
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Txtidcliente.Text = "";
            Txtdireccion.Text = "";
            Txtemail.Text = "";
            Txtnombrecliente.Text = "";
            Txttef.Text = "";
            Txtbuscar.Text = "";
            BtnGuardar.Enabled = true;

        }


    }
}
