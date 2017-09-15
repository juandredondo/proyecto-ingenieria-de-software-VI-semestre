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
using Sisveug.Formularios;


namespace Sisveug.Formularios
{
    
    public partial class FormPiezas : Form
    {
        Mostrar MostrarCategorias = new Mostrar();
        Insertar RegistraPiezas = new Insertar();
        Eliminar EliminarPiezas = new Eliminar();
        public int respuesta = 0;
        public FormPiezas()
        {
            InitializeComponent();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            //FormBuscarCategorias abrir = new FormBuscarCategorias();
            //abrir.Show();
            respuesta = 2;
            Drglistamarca.Visible = false;
            Drglistapiezas.Visible = false;
            Drglistacategorias.Visible = true;
            MostrarCategorias.MostrarDatos(Drglistacategorias, "mostrar_categorias", "", "Pnombre");

        }

        private void FormPiezas_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //FormBuscarMarcas abrir = new FormBuscarMarcas();
            //abrir.Show();
            respuesta = 3;
            Drglistacategorias.Visible = false;
            Drglistapiezas.Visible = false;
            Drglistamarca.Visible = true;
            MostrarCategorias.MostrarDatos(Drglistamarca, "mostrar_marcas", "", "Pnombre");
        }

        private void FormPiezas_Load(object sender, EventArgs e)
        {
            respuesta = 1;
            Drglistacategorias.Visible = false;
            Drglistamarca.Visible = false;
            MostrarCategorias.MostrarDatos(Drglistapiezas, "buscar_piezas", "", "Preferencia");
        }

        private void Drglistacategorias_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Int64 varid = (Int64)Drglistacategorias.CurrentRow.Cells["idcategorias"].Value;
            Txtcategoria.Text = varid.ToString();
        }

        private void Drglistamarca_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Int64 varid = (Int64)Drglistamarca.CurrentRow.Cells["idmarcas"].Value;
            Txtmarca.Text = varid.ToString();

        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            respuesta = 1;
            RegistraPiezas.InsertarBd("insertar_piezas", "Preferencia", "Pcantidad", "Pvunitario", "Pidcategorias", "Pidmarcas", Txtreferencia.Text, Txtcantidad.Text, Txtvunitario.Text, Txtcategoria.Text, Txtmarca.Text);
            MostrarCategorias.MostrarDatos(Drglistapiezas, "buscar_piezas", "", "Preferencia");
            Drglistacategorias.Visible = false;
            Drglistamarca.Visible = false;
            Drglistapiezas.Visible = true;
            limpiar();
        }
        public void limpiar() {
            Txtcantidad.Text = "";
            Txtreferencia.Text = "";
            Txtvunitario.Text = "";
            Txtcategoria.Text = "";
            Txtmarca.Text = "";
            Txtbuscar.Text = "";
            Txtidpiezas.Text = "";
        }
        private void SalirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            respuesta = 1;
            MostrarCategorias.MostrarDatos(Drglistapiezas, "buscar_piezas", "", "Preferencia");
            Drglistacategorias.Visible = false;
            Drglistamarca.Visible = false;
            Drglistapiezas.Visible = true;
            GuardarBtn.Enabled = true;
            limpiar();
            
        }

        private void Drglistamarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Id = Convert.ToString(Drglistapiezas.CurrentRow.Cells["idpiezas"].Value);
            string Nombre = Convert.ToString(Drglistapiezas.CurrentRow.Cells["referencia"].Value);


            //MessageBox.Show(valor.ToString());

            DialogResult dialog = MessageBox.Show("Esta seguro que desea eliminar el este registro " + Id + " " + Nombre + " No se podran deshacer los cambios", "Eliminar Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (dialog == DialogResult.OK)
            {
                respuesta = 1;
                EliminarPiezas.EliminarDatos("eliminar_piezas", "Pidpiezas", Id);
                MostrarCategorias.MostrarDatos(Drglistapiezas, "buscar_piezas", "", "Preferencia");
                Drglistacategorias.Visible = false;
                Drglistamarca.Visible = false;
                Drglistapiezas.Visible = true;
                limpiar();
                
            }
            
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int64 varid = (Int64)Drglistapiezas.CurrentRow.Cells["idpiezas"].Value;
            string varref = (string)Drglistapiezas.CurrentRow.Cells["referencia"].Value;
            int varcant = (int)Drglistapiezas.CurrentRow.Cells["cantidad"].Value;
            int varval = (int)Drglistapiezas.CurrentRow.Cells["vunitario"].Value;
            
            Txtidpiezas.Text = varid.ToString();
            Txtreferencia.Text = varref;
            Txtcantidad.Text = varcant.ToString();
            Txtvunitario.Text = varval.ToString();
            GuardarBtn.Enabled = false;

            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            respuesta = 1;
            RegistraPiezas.ModificarPiezas("editar_piezas", "Pidpiezas", "Preferencia", "Pcantidad", "Pvunitario", "Pidcategorias", "Pidmarcas", Txtidpiezas.Text, Txtreferencia.Text, Txtcantidad.Text, Txtvunitario.Text, Txtcategoria.Text, Txtmarca.Text);
            MostrarCategorias.MostrarDatos(Drglistapiezas, "buscar_piezas", "", "Preferencia");
            Drglistacategorias.Visible = false;
            Drglistamarca.Visible = false;
            Drglistapiezas.Visible = true;
            limpiar();
            GuardarBtn.Enabled = true;
        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            switch (respuesta) {
                case 0:
                    break;

                case 1:
                    MostrarCategorias.MostrarDatos(Drglistapiezas, "buscar_piezas", Txtbuscar.Text, "Preferencia");
                    break;
                case 2:
                    MostrarCategorias.MostrarDatos(Drglistacategorias, "mostrar_categorias", Txtbuscar.Text, "Pnombre");
                    break;
                case 3:
                    MostrarCategorias.MostrarDatos(Drglistamarca, "mostrar_marcas", Txtbuscar.Text, "Pnombre");
                    break;
            
            }
        }
    }
}
