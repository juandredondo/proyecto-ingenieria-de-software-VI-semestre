using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;// para operaciones con datos 
using MySql.Data;// para operacines con mysql 
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Sisveug.MisClases;

namespace Sisveug.MisClases
{
    class Mostrar
    {

        Cadena Obj = new Cadena();// creamos un objeto de la clase Cadena 


        public void MostrarDatos(DataGridView dataGrid, string Nombreprocedmiento, string varnombre, string Nombreparametro)
        {
     
            Nombreparametro= "@"+ Nombreparametro;

            string CadenaApp;
            CadenaApp = Obj.Obtenercadena();// le asigamos la cadena de conexion a la variable CadenaApp                    
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
                cmd.Parameters.AddWithValue(Nombreparametro, "%" + varnombre + "%");
                cmd.Parameters[Nombreparametro].Direction = ParameterDirection.Input;
                odadapter.SelectCommand = cmd;
                odadapter.Fill(odtable);
                dataGrid.DataSource = odtable;
                // MessageBox.Show("Autor Guardado Con Exito!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedes mostrar los datos verifique la conexion e intente nuevamente !!" + ex.Message);
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
