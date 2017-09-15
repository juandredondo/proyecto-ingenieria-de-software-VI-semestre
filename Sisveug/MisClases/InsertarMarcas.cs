using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// clases mas utilizadas
using System.Data;// para operaciones con datos 
using MySql.Data;// para operacines con mysql 
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Sisveug.MisClases;

namespace Sisveug.MisClases
{
    class InsertarMarcas
    {
        Cadena Obj = new Cadena();// declaramos los objetos 

        public void InsertarBd(string Nombreprocedmiento,  string PNombre, string TxtNombre)
        {
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

               // cmd.Parameters.AddWithValue("?" + PIdclientes, TxtId);
                //cmd.Parameters["?" + PIdclientes].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?" + PNombre, TxtNombre);
                cmd.Parameters["?" + PNombre].Direction = ParameterDirection.Input;

                odadapter.SelectCommand = cmd;
                cmd.ExecuteNonQuery();
                //MessageBox .Show("Usuario Guardado Con Exito!!",MessageBoxIcon.Information);

                MessageBox.Show("Los datos se han inserttado exitosamente ", " SISVEUG  SOFTWARE ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(" No se pueden guardar los datos \n ERROR: " + ex.Message, "SISVEUG  SOFTWARE ", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                //  MessageBox.Show("No se puedo guardar!! ","ejemplo ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
                conn.Dispose();
            }


        }


        public void ModificarBd(string Nombreprocedmiento, string PIdmarcas, string PNombre, string TxtIdmarca, string TxtNombre)
        {
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

                // cmd.Parameters.AddWithValue("?" + PIdclientes, TxtId);
                //cmd.Parameters["?" + PIdclientes].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("?" + PIdmarcas, TxtIdmarca);
                cmd.Parameters["?" + PIdmarcas].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("?" + PNombre, TxtNombre);
                cmd.Parameters["?" + PNombre].Direction = ParameterDirection.Input;

                odadapter.SelectCommand = cmd;
                cmd.ExecuteNonQuery();
                //MessageBox .Show("Usuario Guardado Con Exito!!",MessageBoxIcon.Information);

                MessageBox.Show("Los datos se han inserttado exitosamente ", " SISVEUG  SOFTWARE ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(" No se pueden guardar los datos \n ERROR: " + ex.Message, "SISVEUG  SOFTWARE ", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                //  MessageBox.Show("No se puedo guardar!! ","ejemplo ",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
