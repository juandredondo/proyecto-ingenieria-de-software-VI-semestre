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
    public partial class FormMarcas : Form
    {
        InsertarMarcas RegistrarMarca = new InsertarMarcas();
        MostrarMarcas MostrarMarca = new MostrarMarcas();
        EliminarMarcas EliminarMarca = new EliminarMarcas();
        public FormMarcas()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistrarMarca.InsertarBd("insertar_marcas", "Pnombre", Txtnombremarca.Text);
            MostrarMarca.MostrarDatos(Drglistamarcas, "mostrar_marcas", "", "Pnombre");
            limpiar();
        }
        public void limpiar() {
            Txtidmarca.Text = "";
            Txtnombremarca.Text = "";
            Txtbuscar.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMarcas_Load(object sender, EventArgs e)
        {
            MostrarMarca.MostrarDatos(Drglistamarcas, "mostrar_marcas", "", "Pnombre");
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Id = Convert.ToString(Drglistamarcas.CurrentRow.Cells["idmarcas"].Value);
            string Nombre = Convert.ToString(Drglistamarcas.CurrentRow.Cells["nombre"].Value);


            //MessageBox.Show(valor.ToString());

            DialogResult dialog = MessageBox.Show("Esta seguro que desea eliminar el este registro " + Id + " " + Nombre + " No se podran deshacer los cambios", "Eliminar Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (dialog == DialogResult.OK)
            {
                EliminarMarca.EliminarDatos("eliminar_marca", "Pidmarcas", Id);
                MostrarMarca.MostrarDatos(Drglistamarcas, "mostrar_marcas", "", "Pnombre");
                limpiar();
            }
        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarMarca.MostrarDatos(Drglistamarcas, "mostrar_marcas", Txtbuscar.Text, "Pnombre");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Txtnombremarca.Text = "";
            Txtbuscar.Text = "";
            Txtidmarca.Text = "";
            button6.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;
            RegistrarMarca.ModificarBd("editar_marca", "Pidmarca", "Pnombre", Txtidmarca.Text, Txtnombremarca.Text);
            MostrarMarca.MostrarDatos(Drglistamarcas, "mostrar_marcas", "", "Pnombre");
            limpiar();
           

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Txtidmarca.Enabled = false;
            button6.Enabled = false;
            Int64 varid = (Int64)Drglistamarcas.CurrentRow.Cells["idmarcas"].Value;
            string varnom = (string)Drglistamarcas.CurrentRow.Cells["nombre"].Value;
            Txtnombremarca.Text = varnom;
            Txtidmarca.Text = varid.ToString();
        }
    }
}
