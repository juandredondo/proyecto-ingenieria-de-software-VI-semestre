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
    public partial class FormDiagnostico : Form
    {
        Insertar RegistrarDiagnostico = new Insertar();
        Mostrar MostrarDiagnostico = new Mostrar();
        Eliminar EliminarDiagnostico = new Eliminar();
        public FormDiagnostico()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistrarDiagnostico.InsertarBd2("insertar_diagnostico", "Pnombre", "Pdescripcion", Txtnombrediagnostico.Text, richTextBox1.Text);
            MostrarDiagnostico.MostrarDatos(Drglistadiagnosticos, "mostrar_diagnostico", "", "Pnombre");  
            limpiar();
            Txtiddiagnostico.Enabled = false;

        }
        public void limpiar() {
            richTextBox1.Text = "";
            Txtiddiagnostico.Text = "";
            Txtnombrediagnostico.Text = "";
            Txtbuscar.Text = "";
        }

        private void FormDiagnostico_Load(object sender, EventArgs e)
        {
            MostrarDiagnostico.MostrarDatos(Drglistadiagnosticos, "mostrar_diagnostico", "", "Pnombre");  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Txtiddiagnostico.Text = "";
            Txtnombrediagnostico.Text = "";
            Txtbuscar.Text = "";
            btnguardar.Enabled = true;
        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarDiagnostico.MostrarDatos(Drglistadiagnosticos, "mostrar_diagnostico", Txtbuscar.Text, "Pnombre");  
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Id = Convert.ToString(Drglistadiagnosticos.CurrentRow.Cells["iddiagnostico"].Value);
            string Nombre = Convert.ToString(Drglistadiagnosticos.CurrentRow.Cells["nombre"].Value);


            //MessageBox.Show(valor.ToString());

            DialogResult dialog = MessageBox.Show("Esta seguro que desea eliminar el este registro " + Id + " " + Nombre + " No se podran deshacer los cambios", "Eliminar Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (dialog == DialogResult.OK)
            {
                EliminarDiagnostico.EliminarDatos("eliminar_diagnostico", "Piddiagnostico", Id);
                MostrarDiagnostico.MostrarDatos(Drglistadiagnosticos, "mostrar_diagnostico", "", "Pnombre");
                limpiar();
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Txtiddiagnostico.Enabled = false;
            btnguardar.Enabled = false;
            Int64 varid = (Int64)Drglistadiagnosticos.CurrentRow.Cells["iddiagnostico"].Value;
            string varnom = (string)Drglistadiagnosticos.CurrentRow.Cells["nombre"].Value;
            string vardesc = (string)Drglistadiagnosticos.CurrentRow.Cells["descripcion"].Value;
            Txtiddiagnostico.Text = varid.ToString();
            Txtnombrediagnostico.Text = varnom;
            richTextBox1.Text = vardesc;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegistrarDiagnostico.ModificarBd("editar_diagnostico", "Piddiagnostico", "Pnombre", "Pdescripcion", Txtiddiagnostico.Text, Txtnombrediagnostico.Text, richTextBox1.Text);
            MostrarDiagnostico.MostrarDatos(Drglistadiagnosticos, "mostrar_diagnostico", "", "Pnombre");
            limpiar();
            btnguardar.Enabled = true;
        }

        private void Txtnombrediagnostico_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
