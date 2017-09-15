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
    public partial class FormCategorias : Form
    {
        InsertarMarcas RegistrarCategoria = new InsertarMarcas();
        EliminarMarcas EliminarMarca = new EliminarMarcas();
        MostrarMarcas MostrarMarca = new MostrarMarcas();
        public FormCategorias()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Txtidcategoria.Enabled = false;
            RegistrarCategoria.InsertarBd("insertar_categorias", "Pnombre", Txtnombrecategoria.Text);
            MostrarMarca.MostrarDatos(Drglistacategorias, "mostrar_categorias", "", "Pnombre");
            limpiar();

        }
        public void limpiar() {
            Txtnombrecategoria.Text = "";
            Txtidcategoria.Text = "";
            Txtbuscar.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;
            Txtidcategoria.Enabled = false;
            Txtnombrecategoria.Text = "";
            Txtbuscar.Text = "";
            Txtidcategoria.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Id = Convert.ToString(Drglistacategorias.CurrentRow.Cells["idcategorias"].Value);
            string Nombre = Convert.ToString(Drglistacategorias.CurrentRow.Cells["nombre"].Value);


            //MessageBox.Show(valor.ToString());

            DialogResult dialog = MessageBox.Show("Esta seguro que desea eliminar el este registro " + Id + " " + Nombre + " No se podran deshacer los cambios", "Eliminar Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (dialog == DialogResult.OK)
            {
                EliminarMarca.EliminarDatos("eliminar_categoria", "Pidcategoria", Id);
                MostrarMarca.MostrarDatos(Drglistacategorias, "mostrar_categorias", "", "Pnombre");
                limpiar();
            }
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            Txtidcategoria.Enabled = false;
            MostrarMarca.MostrarDatos(Drglistacategorias, "mostrar_categorias", "", "Pnombre");
        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarMarca.MostrarDatos(Drglistacategorias, "mostrar_categorias", Txtbuscar.Text, "Pnombre");
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Txtidcategoria.Enabled = false;
            button6.Enabled = false;
            Int64 varid = (Int64)Drglistacategorias.CurrentRow.Cells["idcategorias"].Value;
            string varnom = (string)Drglistacategorias.CurrentRow.Cells["nombre"].Value;
            Txtnombrecategoria.Text = varnom;
            Txtidcategoria.Text = varid.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegistrarCategoria.ModificarBd("editar_categoria", "Pidcategoria", "Pnombre", Txtidcategoria.Text, Txtnombrecategoria.Text);
            MostrarMarca.MostrarDatos(Drglistacategorias, "mostrar_categorias", "", "Pnombre");
            limpiar();
            button6.Enabled = true;
        }

        private void seleccionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
