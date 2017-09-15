using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



using MySql.Data;// para operacines con mysql 
using MySql.Data.MySqlClient;
using Sisveug.MisClases;
using Sisveug.FormOperaciones;
using MySql.Data.Common;
using Sisveug.ClasesOperaciones;

namespace Sisveug.FormOperaciones
{
    public partial class TxtNumSercicio : Form
    {
        public TxtNumSercicio()
        {
            InitializeComponent();
           
        }
        // OBJETOS DE LAS CLASES CREADAS 
        Ir ObjIr = new Ir();
        InsertarServicio InsertarRegistros = new InsertarServicio();
        Mostrar MostrarCliente = new Mostrar();
        Boolean Encuentraprod =false;
        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            
            MostrarCliente.MostrarDatos(Drglistaclientes, "MostrarPiezas", Txtbuscar.Text, "Pnombre");

        }

        public void consultaSql(string ConsultaSQL,TextBox NombTxt)
        {

            Cadena Obj = new Cadena(); // objeto de la clase cadena    
            string CadenaApp;


            CadenaApp = Obj.Obtenercadena();// le asigamos la cadena de conexion a la variable CadenaApp       
            string connstring = CadenaApp;
            MySqlConnection cnn = new MySqlConnection(connstring);
            try
            {

                cnn.Open();
                string sql = ConsultaSQL ;//WHERE id =TP101
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


            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void IrVRServicio()
        {
                        
            Cadena Obj = new Cadena(); // objeto de la clase cadena    
            string CadenaApp;
            CadenaApp = Obj.Obtenercadena();// le asigamos la cadena de conexion a la variable CadenaApp       
            string connstring = CadenaApp;
            MySqlConnection cnn = new MySqlConnection(connstring);
           try
                    {
                        cnn.Open();
                        string sql = "select vrdiagnostico,aprobado from servicios where idservicios = " + "@TP101 ";//WHERE id =TP101
                        MySqlCommand cmd = new MySqlCommand(sql, cnn);
                        cmd.Parameters.AddWithValue("@TP101", "idservicios");
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            TxtVrServicio.Text = Convert.ToString(reader["vrdiagnostico"]);
                            TxtVrProductos.Text = Convert.ToString(reader["aprobado"]);
                        }
                        else
                        {
                            MessageBox.Show(" error de conexion con la base de datos \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    catch (Exception m)
                    {
                        MessageBox.Show(m.Message);
                    }
        
            
        }

        private void FormMantenimiento_Load(object sender, EventArgs e)
        {
            Txtbuscar.Focus();

           
            MostrarCliente.MostrarDatos(Drglistaclientes, "MostrarPiezas", Txtbuscar.Text, "Pnombre");
 
            MostrarCliente.MostrarDatos(Drglistaclientes, "MostrarPiezas","", "Pnombre");
            consultaSql("SELECT max(mantenimiento.idmantenimiento)+1 as contador from mantenimiento", TxtNumMantenimiento);
        
            consultaSql("select max(servicios.idservicios) as contador from servicios", TxtNumservicio);
            // aqui se le manda el texbox1 a modo de no cambiar la clase pero ese texbox  no sirve de nada por lo tando esta visible = false 
            // cargamos el valor del servicio al cual  se le va  a hacer el mantenimiento 
            consultaSql("select servicios.vrdiagnostico as contador from servicios where idservicios = " + TxtNumservicio.Text, TxtVrDiag);


            
       }
        Int64 valor;
                Int32 Exixtencia;
                    Int32 VrUnitario;
   
        private void Drglistaclientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

             valor = (Int64)Drglistaclientes.CurrentRow.Cells["idpiezas"].Value;
             Exixtencia = (Int32)Drglistaclientes.CurrentRow.Cells["cantidad"].Value;
             VrUnitario = (Int32)Drglistaclientes.CurrentRow.Cells["vunitario"].Value;
     
          
            string varnombre = (string)Drglistaclientes.CurrentRow.Cells["referencia"].Value;

            TxtIdproductos.Text =( valor.ToString());
            TxtNombreProducto.Text = varnombre;
            TxtExixtencia.Text = (Exixtencia.ToString());
            TxtVrUnit.Text=(VrUnitario.ToString());
            TxtCantidadPro.Focus();
            TxtCantidadPro.Text = "";
            TxtVrtotal.Text = "";
        }
        int cantidad = 0;
        private void TxtCantidadPro_TextChanged(object sender, EventArgs e)
        {
            try
            {
            
                cantidad = Convert.ToInt32(TxtCantidadPro.Text);
                if (TxtCantidadPro.Text == "")
                {
                    TxtVrtotal.Text = "";
                }
                else
                {
                    TxtVrtotal.Text = Convert.ToString(cantidad*VrUnitario);
                    
                }


                if (cantidad > Exixtencia)
                {
                    MessageBox.Show("La cantidad ingresada no esta disponible", "sistema vertical ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtCantidadPro.Text = "";
                    TxtVrtotal.Text = "";
                }
            }
            
            catch(Exception ex)
            {
            }

        }
      
         int item=0;

         public void limpiar()
         {
             TxtIdproductos.Text = "";
             TxtNombreProducto.Text = "";
             TxtCantidadPro.Text="";
             TxtVrtotal.Text="";
             TxtVrUnit.Text="";
             TxtExixtencia.Text = "";
         }
        private void IrProducto_Click(object sender, EventArgs e)
        {
            if (cantidad > Exixtencia || TxtCantidadPro.Text=="")
            {
                MessageBox.Show("La cantidad ingresada no esta disponible", "sistema vertical ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCantidadPro.Text = "";
                TxtVrtotal.Text = "";
            }
            else
            {
        
                 

              
                 
                    int Ir = 0;
                    int cont = 0;
                    int swi = 0;
                    int cuentaLin;
                  
                   
             
                    cont = this.DataGridView1.RowCount-1;





                    while (Ir <= cont && swi == 0)
                        {

                            if (Convert.ToInt32(DataGridView1.Rows[Ir].Cells[1].Value) == Convert.ToInt32(TxtIdproductos.Text))
                            {

                                Encuentraprod = true;
                                swi=1;

                            }
                            Ir = Ir + 1;


                        }
                    if (Encuentraprod == true)
                        {
                            MessageBox.Show("El articulo ya se encuentra en la lista ", "sistema vertical ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            Encuentraprod = false;
                        }

                        else
                        {
                           
                            cuentaLin = this.DataGridView1.Rows.Count;
                            item +=1;
                            try
                            {
                                this.DataGridView1.Rows.Add();
                                this.DataGridView1.Rows[cuentaLin].Cells[0].Value = item.ToString();
                                this.DataGridView1.Rows[cuentaLin].Cells[1].Value = valor;
                                this.DataGridView1.Rows[cuentaLin].Cells[2].Value = this.TxtNombreProducto.Text;
                                this.DataGridView1.Rows[cuentaLin].Cells[3].Value = TxtCantidadPro.Text;
                                this.DataGridView1.Rows[cuentaLin].Cells[4].Value = TxtVrUnit.Text;
                                this.DataGridView1.Rows[cuentaLin].Cells[5].Value = TxtVrtotal.Text;
                             
                                Encuentraprod = false;
                                limpiar();
                            }
                            catch (Exception ex)
                            {
                            }
                        }
                 





            }


        }

       

        private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
            
            DialogResult dialog = MessageBox.Show("Esta seguro que desea eliminar el este registro " , "Eliminar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (dialog == DialogResult.OK)
            {
                int cont;
                 this.DataGridView1.Rows.Remove(this.DataGridView1.CurrentRow);
                 // reordenar los items 
                cont = this.DataGridView1.Rows.Count + 1;
               
                if (cont==0)
                {
                    item=0;
                }
                else
                {
                    item-=1;
                    for(int j = 0; j<=item-1;j++)
                    {
                    this.DataGridView1.Rows[j].Cells[0].Value=j+1;
                    }
                }

                
            }

        }

        private void ModificarCantidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c;
            int idproducto;
            c = Convert.ToInt32(this.DataGridView1.CurrentRow);
            idproducto =Convert.ToInt32(DataGridView1.Rows[c-1].Cells[0].Value);
            MessageBox.Show(idproducto.ToString());
            this.TxtIdproductos.Text =idproducto.ToString() ;

        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            if (TxtVrDiagnostico.Text == "")
            {
                MessageBox.Show("Ingrese el valor del mantenimiento  ", "Sistema Vertical", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtVrDiagnostico.Focus();
            }
            else
            {

                // se guardan los datos correpondientes a la tabla mantenimiento
                string fecha1;
                string fecha2;
                fecha1 = (DTFechaMantenimiento.Value.Year + "/" + DTFechaMantenimiento.Value.Month + "/" + DTFechaMantenimiento.Value.Day);
                fecha2 = (DTFechaEntrega.Value.Year + "/" + DTFechaEntrega.Value.Month + "/" + DTFechaEntrega.Value.Day);
                InsertarRegistros.InsertarBDManteni("InsertarManteni", "Pfecha", "Pfecha_terminacion", "Pvrmanodeobra", "Pidservicios", "Pretirado", "Pvrservicio", fecha1, fecha2, TxtVrDiagnostico.Text, TxtNumservicio.Text, "No", TxtVrServicio.Text);

                //  recorremos el datagrid y vamos mandando los valores
                int i = 0;
                int max = 0;
                int ju = 0;
                int Cantidadrestar = 0;
                max = this.DataGridView1.RowCount;
                while (i < max)
                {   ju = Convert.ToInt32(this.DataGridView1.Rows[i].Cells[1].Value);
                    Cantidadrestar = Convert.ToInt32(this.DataGridView1.Rows[i].Cells[3].Value);
                    //MessageBox.Show(" GUARGADO EN BD ju = " + ju.ToString());
                    InsertarRegistros.InsertarBDPiezasXMto("InsertPiezasxMto", "Pidmantenimiento", "Pidpiezas", TxtNumMantenimiento.Text, ju.ToString());
                    InsertarRegistros.ActualizarPiezas("ActualizarPiezas", "PCanRestar", "Pidpieza", Cantidadrestar.ToString(), ju.ToString());

                    //TxtIdproductos.Text = (ju.ToString());
                    i += 1;
                }

            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                //  recorremos el datagrid y vamos mandando los valores
                int i = 0;
                int max = 0;
                int ju = 0;
               
                double sum=0;
                max = this.DataGridView1.RowCount;
                while (i < max)
                {
                    ju = Convert.ToInt32(this.DataGridView1.Rows[i].Cells[5].Value);
                    sum = sum + ju;
                    i += 1;
                }
                TxtVrProductos.Text = sum.ToString();
                GuardarBtn.Enabled = true;

            }
            catch (Exception ex)
            {
            }
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }
        double   suma1 = 0;
        private void TxtVrDiagnostico_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                double   num1 = 0, num2 = 0, num3 = 0, suma = 0;
                num1 = Convert.ToDouble(TxtVrDiag.Text);
                num2 = Convert.ToDouble(TxtVrProductos.Text);
                num3 = Convert.ToDouble(TxtVrDiagnostico.Text);
             
                suma1 = num1 + num2;
                suma = Convert.ToDouble(num1 + num2 + num3);
                TxtVrServicio.Text = suma.ToString();
                GuardarBtn.Enabled = true;
            }
            catch (Exception ex)
            {
               TxtVrServicio.Text =suma1.ToString();
            }
        }
    }
}
