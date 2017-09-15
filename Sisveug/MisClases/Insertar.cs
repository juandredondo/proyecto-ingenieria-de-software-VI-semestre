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
using System.Data.SqlClient;



namespace Sisveug.MisClases
{
    class Insertar
    {
        Cadena Obj = new Cadena();// declaramos los objetos 

        public void InsertarBd(string Nombreprocedmiento, string PIdclientes, string PNombre, string PTelefono, string PDireccion, string PEmail, string TxtId, string TxtNombre, string Txttelefono, string Txtdireccion, string Txtemail)
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


                

                cmd.Parameters.AddWithValue("?" + PIdclientes, TxtId);
                cmd.Parameters["?" + PIdclientes].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?" + PNombre, TxtNombre);
                cmd.Parameters["?" + PNombre].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?" + PTelefono, Txttelefono);
                cmd.Parameters["?" + PTelefono].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?" + PDireccion, Txtdireccion);
                cmd.Parameters["?" + PDireccion].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?" + PEmail, Txtemail);
                cmd.Parameters["?" + PEmail].Direction = ParameterDirection.Input;

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
   


    
        public void InsertarBd2(string Nombreprocedmiento,string PNombre, string PDescripcion,string TxtNombre, string TxtDescripcion)
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

                cmd.Parameters.AddWithValue("?" + PNombre, TxtNombre);
                cmd.Parameters["?" + PNombre].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?" + PDescripcion, TxtDescripcion);
                cmd.Parameters["?" + PDescripcion].Direction = ParameterDirection.Input;

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
        public void ModificarBd(string Nombreprocedmiento, string PIddiagnostico, string PNombre, string PDescripcion, string TxtIddiagnostico, string TxtNombre, string Txtdescripcion)
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

                cmd.Parameters.AddWithValue("?" + PIddiagnostico, TxtIddiagnostico);
                cmd.Parameters["?" + PIddiagnostico].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?" + PNombre, TxtNombre);
                cmd.Parameters["?" + PNombre].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?" + PDescripcion, Txtdescripcion);
                cmd.Parameters["?" + PDescripcion].Direction = ParameterDirection.Input;

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
        public void ModificarPiezas(string Nombreprocedmiento, string PIdpiezas, string PReferencia, string PCantidad, string PVunitario, string PIdcategorias,string PIdmarcas, string TxtIdpiezas, string TxtReferencia, string TxtCantidad, string TxtVunitario, string TxtIdcategorias,string TxtIdmarcas)
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

                cmd.Parameters.AddWithValue("?" + PIdpiezas, TxtIdpiezas);
                cmd.Parameters["?" + PIdpiezas].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?" + PReferencia, TxtReferencia);
                cmd.Parameters["?" + PReferencia].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?" + PCantidad, TxtCantidad);
                cmd.Parameters["?" + PCantidad].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?" + PVunitario, TxtVunitario);
                cmd.Parameters["?" + PVunitario].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?" + PIdcategorias, TxtIdcategorias);
                cmd.Parameters["?" + PIdcategorias].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?" + PIdmarcas, TxtIdmarcas);
                cmd.Parameters["?" + PIdmarcas].Direction = ParameterDirection.Input;

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



