using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// clases importadas 
using Sisveug.ClasesOperaciones;
using Sisveug.Formularios;
using Sisveug.MisClases;


using MySql.Data;// para operacines con mysql 
using MySql.Data.MySqlClient;

using Sisveug.FormOperaciones;
using MySql.Data.Common;


namespace Sisveug.FormOperaciones
{
   


    public partial class FormServicio : Form
    {
        // oespacio para declaracion de objetos

        Mostrar MostrarCliente = new Mostrar();
       Ir ObjIr = new Ir();
       InsertarServicio InsertarRegistros = new InsertarServicio();
       TxtNumSercicio mantenimiento = new TxtNumSercicio();
        // para validar las operaciones de buscar 
       public int respuesta=0;



        public FormServicio()
        {
            InitializeComponent();
        }


      
        private void BtnIrCliente_Click(object sender, EventArgs e)
        {
            ObjIr.MetdodoIr(TxtIdCliente, "select idcliente,nombre from cliente where idcliente = ", TxtIdCliente.Text, TxtIdCliente, TxtNombreCliente, "idcliente", "nombre");

        }

        private void BtnIrTipoEquipo_Click(object sender, EventArgs e)
        {
            ObjIr.MetdodoIr(TxtIdTipoEquipo, "select idequipo,nombreequipo from equipo where idequipo = ", TxtIdTipoEquipo.Text, TxtIdTipoEquipo, TxtNombreEquipo, "idequipo", "nombreequipo");

        }

        private void BtnIrDiagnostico_Click(object sender, EventArgs e)
        {
            ObjIr.MetdodoIr(TxtIdDiagnostico, "select iddiagnostico,nombre from diagnostico where iddiagnostico = ", TxtIdDiagnostico.Text, TxtIdDiagnostico, TxtNombreDiagnostico, "iddiagnostico", "nombre");

        }

        private void CBAprobado_SelectedIndexChanged(object sender, EventArgs e)
        {
        

        }

        private void BtnIrTecnico_Click(object sender, EventArgs e)
        {

            ObjIr.MetdodoIr(TxtIdTecnico, "select idtecnico,nombre from tecnicos where idtecnico = ", TxtIdTecnico.Text, TxtIdTecnico, TxtNombreTecnico, "idtecnico", "nombre");

        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            respuesta = 1;
            MostrarCliente.MostrarDatos(Drglistaclientes, "mostrar_cliente", "", "Pnombre");
            this.Txtbuscar.Focus();
            this.Txtbuscar.Text = "";


        }

        private void BtnBuscarDiagnostico_Click(object sender, EventArgs e)
        {
            respuesta = 2;
            MostrarCliente.MostrarDatos(Drglistaclientes, "MostrarDiagnistico", "", "Pnombre");
            this.Txtbuscar.Text = "";
            this.Txtbuscar.Focus();

        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {

            switch (respuesta)
            {
                
                case 1:
                    MostrarCliente.MostrarDatos(Drglistaclientes, "mostrar_cliente", Txtbuscar.Text, "Pnombre");
                    break;
                case 2:
                    MostrarCliente.MostrarDatos(Drglistaclientes, "MostrarDiagnistico", Txtbuscar.Text, "Pnombre");


                    break;
                case 3:
                    MostrarCliente.MostrarDatos(Drglistaclientes, "MostarTecnicos", Txtbuscar.Text, "Pnombre");


                    break;
                case 4:
                    MostrarCliente.MostrarDatos(Drglistaclientes, "MostrarEquipos", Txtbuscar.Text, "Pnombre");

                    break;

            }
         

                

            
        }

        private void BtnBuscarTecnico_Click(object sender, EventArgs e)
        {
            respuesta = 3;
            MostrarCliente.MostrarDatos(Drglistaclientes, "MostarTecnicos", Txtbuscar.Text, "Pnombre");
            this.Txtbuscar.Text = "";
            this.Txtbuscar.Focus();
            
        }

        private void BtnBuscarTipoEquipo_Click(object sender, EventArgs e)
        {
            respuesta= 4;
            MostrarCliente.MostrarDatos(Drglistaclientes, "MostrarEquipos", Txtbuscar.Text, "Pnombre");
            this.Txtbuscar.Text = "";
            this.Txtbuscar.Focus();
           
        }

        private void Drglistaclientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (respuesta)
            {

                case 1:// cuando se busca un cliente 
                    string varid = (string)Drglistaclientes.CurrentRow.Cells["idcliente"].Value;
                    string varnombre = (string)Drglistaclientes.CurrentRow.Cells["nombre"].Value;

                    TxtIdCliente.Text = varid;
                    TxtNombreCliente.Text = varnombre;
                    break;
                case 2: // cuando se busca un diagnostico 
                    Int64 valor = (Int64)Drglistaclientes.CurrentRow.Cells["iddiagnostico"].Value;
                   
                    string varnombre2 = (string)Drglistaclientes.CurrentRow.Cells["nombre"].Value;

                    TxtIdDiagnostico.Text =(valor.ToString());
                    TxtNombreDiagnostico.Text = varnombre2;

                    break;
                case 3:
                    string varid55 = (string)Drglistaclientes.CurrentRow.Cells["idtecnico"].Value;
                    string varnombre55 = (string)Drglistaclientes.CurrentRow.Cells["nombre"].Value;

                    TxtIdTecnico.Text = varid55;
                    TxtNombreTecnico.Text = varnombre55;

                    break;
                case 4:

                    Int64 valor2 = (Int64)Drglistaclientes.CurrentRow.Cells["idequipo"].Value;

                    string varnombre22 = (string)Drglistaclientes.CurrentRow.Cells["nombreequipo"].Value;

                    TxtIdTipoEquipo.Text = (valor2.ToString());
                    TxtNombreEquipo.Text = varnombre22;



                      break;

            }




        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            if (TxtIdCliente.Text== "" || TxtIdDiagnostico.Text== "" || TxtIdTipoEquipo.Text== ""  || TxtIdTecnico.Text== "" || TxtSerie.Text=="" )
            {
                MessageBox.Show("Debe diligenciar todos los campos con * ", "ejemplo ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            else
            {


                try
                {
                    string fecha;
                    fecha = (DtfechaServicio.Value.Year + "/" + DtfechaServicio.Value.Month + "/" + DtfechaServicio.Value.Day);
                    double Vrdiagnostico = 0;

                    Vrdiagnostico = (Convert.ToDouble(TxtVrDiagnostico.Text));
                    InsertarRegistros.InsertarBDServicio("InsertarServicios", "Pdescripcion", "Pidequipo", "Pidtecnico", "Pidcliente", "Piddiagnostico", "Pfechaingreso", "Pvrdiagnostico", "Paprobado", "Pserie", RichTexboxProblema.Text, TxtIdTipoEquipo.Text, TxtIdTecnico.Text, TxtIdCliente.Text, TxtIdDiagnostico.Text, fecha, TxtVrDiagnostico.Text, CBAprobado.Text, TxtSerie.Text);



                    if (CBAprobado.Text == "Si")
                    {
                        mantenimiento.ShowDialog();
                        this.Hide();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ingrese el valor del diagnostico ", "ejemplo ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    TxtVrDiagnostico.Focus();
                }
            }

        }
        public void consultaSql(string ConsultaSQL, TextBox NombTxt)
        {

            Cadena Obj = new Cadena(); // objeto de la clase cadena    
            string CadenaApp;


            CadenaApp = Obj.Obtenercadena();// le asigamos la cadena de conexion a la variable CadenaApp       
            string connstring = CadenaApp;
            MySqlConnection cnn = new MySqlConnection(connstring);
            try
            {

                cnn.Open();
                string sql = ConsultaSQL;//WHERE id =TP101
                MySqlCommand cmd = new MySqlCommand(sql, cnn);
                // cmd.Parameters.AddWithValue("@TP101", ParametroId);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    NombTxt.Text = Convert.ToString(reader["contador"]);
                }
                else
                {
                    MessageBox.Show("No existe registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
      
        private void FormServicio_Load(object sender, EventArgs e)
        {
            CBAprobado.Text = "No";
         
          // mantenimiento.ShowDialog();

           consultaSql("select max(servicios.idservicios)+1 as contador from servicios", TxtNumservicio);
         
           
        }

        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {

            FormClientes abrircliente = new FormClientes();
            abrircliente.ShowDialog();
        }

        private void BtnNuevoDiagnostico_Click(object sender, EventArgs e)
        {
            FormDiagnostico abrir = new FormDiagnostico();
            abrir.ShowDialog();

        }

        private void BtnNuevoTecnico_Click(object sender, EventArgs e)
        {
            FormTecnicos tecnicos = new FormTecnicos();
            tecnicos.Show();

        }

        private void BtnNuevoTipoEquipo_Click(object sender, EventArgs e)
        {
            FormEquipos equipos = new FormEquipos();
            equipos.ShowDialog();
        }

        private void TxtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

      

        
    }
}
