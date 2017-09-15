using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

    
    public partial class FormSoluciones : Form
    {

        InsertarMarcas RegistrarMarca = new InsertarMarcas();
        MostrarMarcas MostrarMarca = new MostrarMarcas();
        EliminarMarcas EliminarMarca = new EliminarMarcas();

        public FormSoluciones()
        {
            InitializeComponent();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            RegistrarMarca.InsertarBd("serviciosInsertar", "param_descripcion_solucion", txtReferencia.Text);
            MostrarMarca.MostrarDatos(DrgSoluciones, "mostrar_soluciones", "", "descripcion");
        }

        private void FormSoluciones_Load(object sender, EventArgs e)
        {
            MostrarMarca.MostrarDatos(DrgSoluciones, "mostrar_soluciones", "", "descripcion");

        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarMarca.MostrarDatos(DrgSoluciones, "mostrar_soluciones", Txtbuscar.Text, "descripcion");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            RegistrarMarca.ModificarBd("serviciosActualizar", "param_idsoluciones", "param_descripcion_solucion", Txtidpiezas.Text, txtReferencia.Text);
            MostrarMarca.MostrarDatos(DrgSoluciones, "mostrar_soluciones", "", "descripcion");
           
           
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            EliminarMarca.EliminarDatos("serviciosEliminar", "param_idsoluciones", Txtidpiezas.Text);
            MostrarMarca.MostrarDatos(DrgSoluciones, "mostrar_soluciones", Txtbuscar.Text, "descripcion");
        }
    }
}
