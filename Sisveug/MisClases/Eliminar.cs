using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;// para operaciones con datos 
using MySql.Data;// para operacines con mysql 
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Sisveug.MisClases
{
    class Eliminar
    {
Cadena Obj = new Cadena(); // objeto de la clase cadena           
        public void EliminarDatos ( string Nombreprocedmiento, string Parametro,string valor)
        {
            string CadenaApp;
            CadenaApp = Obj.Obtenercadena();// le asigamos la cadena de conexion a la variable CadenaApp                    
            // llamamos a la clase obtener cadena
           // Int64 valor = (Int64)datautor.CurrentRow.Cells["idautor"].Value;
                String stm = Nombreprocedmiento;
                MySqlConnection conn = new MySqlConnection(CadenaApp);
                DataTable odtable = new DataTable();
                MySql.Data.MySqlClient.MySqlDataAdapter odadapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
                try
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    MySqlCommand cmd = new MySqlCommand(stm, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("?"+ Parametro, valor);
                    cmd.Parameters["?" + Parametro].Direction = ParameterDirection.Input;
                    odadapter.SelectCommand = cmd;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro Eliminado Con Exito!!","Sistema Vertical",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    // mostraraut(textBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puedo guardar!!" + ex.Message);
                }
                finally
                {
                    if (conn.State != ConnectionState.Closed)
                        conn.Close();
                    conn.Dispose();
                }
            }
    }
    }

