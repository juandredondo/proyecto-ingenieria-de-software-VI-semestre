using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;// para operaciones con datos 
using MySql.Data;// para operacines con mysql 
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Sisveug.MisClases;

namespace Sisveug.ClasesOperaciones
{
    class InsertarServicio
    {
        Cadena Obj = new Cadena();// declaramos los objetos 

        public void InsertarBDManteni(string Nombreprocedmiento,
            string Pfecha ,string Pfecha_terminacion,string Pvrmanodeobra,string Pidservicios,string Pretirado,string Pvrservicio,
            string Txtfecha ,string Txtfecha_terminacion,string Txtvrmanodeobra,string Txtidservicios,string Txtretirado,string Txtvrservicio)
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

                cmd.Parameters.AddWithValue("?" + Pfecha, Txtfecha);
                cmd.Parameters["?" + Pfecha].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?" + Pfecha_terminacion, Txtfecha_terminacion);
                cmd.Parameters["?" + Pfecha_terminacion].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?" + Pvrmanodeobra, Txtvrmanodeobra);
                cmd.Parameters["?" + Pvrmanodeobra].Direction = ParameterDirection.Input;


                cmd.Parameters.AddWithValue("?" + Pidservicios, Txtidservicios);
                cmd.Parameters["?" + Pidservicios].Direction = ParameterDirection.Input;




                cmd.Parameters.AddWithValue("?" + Pretirado, Txtretirado);
                cmd.Parameters["?" + Pretirado].Direction = ParameterDirection.Input;


                cmd.Parameters.AddWithValue("?" + Pvrservicio, Txtvrservicio);
                cmd.Parameters["?" + Pvrservicio].Direction = ParameterDirection.Input;


                

                odadapter.SelectCommand = cmd;
                cmd.ExecuteNonQuery();
                //MessageBox .Show("Usuario Guardado Con Exito!!",MessageBoxIcon.Information);

                MessageBox.Show("Los datos se han inserttado exitosamente ", " SSISTEMA VERTICAL", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(" No se pueden guardar los datos \n ERROR: " + ex.Message, "SISTEMA VERTICAL ", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                //  MessageBox.Show("No se puedo guardar!! ","ejemplo ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
                conn.Dispose();
            }


        }



        public void InsertarBDServicio (string Nombreprocedmiento, string Pdescripcion,
                   string Pidequipo, string Pidtecnico, string Pidcliente, string Piddiagnostico,
                   string Pfechaingreso, string Pvrdiagnostico, string Paprobado, string Pserie, string Txtdescripcion, string Txtidequipo, string
                   Txtidtecnico, string Txtidcliente, string Txtiddiagnostico, string Txtfechaingreso, string Txtvalordiagnostico, string Txtaprobado, string Txtserie)
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

                cmd.Parameters.AddWithValue("?" + Pdescripcion, Txtdescripcion);
                cmd.Parameters["?" + Pdescripcion].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?" + Pidequipo, Txtidequipo);
                cmd.Parameters["?" + Pidequipo].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?" + Pidtecnico, Txtidtecnico);
                cmd.Parameters["?" + Pidtecnico].Direction = ParameterDirection.Input;


                cmd.Parameters.AddWithValue("?" + Pidcliente, Txtidcliente);
                cmd.Parameters["?" + Pidcliente].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?" + Piddiagnostico, Txtiddiagnostico);
                cmd.Parameters["?" + Piddiagnostico].Direction = ParameterDirection.Input;


                cmd.Parameters.AddWithValue("?" + Pfechaingreso, Txtfechaingreso);
                cmd.Parameters["?" + Pfechaingreso].Direction = ParameterDirection.Input;


                /////////////////////////////////////////
                cmd.Parameters.AddWithValue("?" + Pvrdiagnostico, Txtvalordiagnostico);
                cmd.Parameters["?" + Pvrdiagnostico].Direction = ParameterDirection.Input;

                //cmd.Parameters.AddWithValue("?" + Pvrservicio, Txtvrservicio);
                //cmd.Parameters["?" + Pvrservicio].Direction = ParameterDirection.Input;


                cmd.Parameters.AddWithValue("?" + Paprobado, Txtaprobado);
                cmd.Parameters["?" + Paprobado].Direction = ParameterDirection.Input;


                cmd.Parameters.AddWithValue("?" + Pserie, Txtserie);
                cmd.Parameters["?" + Pserie].Direction = ParameterDirection.Input;


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






        public void InsertarBDPiezasXMto(string Nombreprocedmiento, string Pidmantenimiento, string Pidpiezas, string Txtidmantenimiento, string Txtidpiezas)
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

                cmd.Parameters.AddWithValue("?" + Pidmantenimiento, Txtidmantenimiento);
                cmd.Parameters["?" + Pidmantenimiento].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?" + Pidpiezas, Txtidpiezas);
                cmd.Parameters["?" + Pidpiezas].Direction = ParameterDirection.Input;        
                             
                odadapter.SelectCommand = cmd;
                cmd.ExecuteNonQuery();
                //MessageBox .Show("Usuario Guardado Con Exito!!",MessageBoxIcon.Information);

              //  MessageBox.Show(" DATOS GUARDADOS EN TABLA DE MUCHOS A MUCHOS  ", " SISVEUG  SOFTWARE ", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
            catch (Exception ex)
            {
                MessageBox.Show(" No se pueden guardar los datos \n ERROR: " + ex.Message, "SISVEUG  SOFTWARE ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                             
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
                conn.Dispose();
            }
        }












        public void ActualizarPiezas(string Nombreprocedmiento, string PCanRestar, string Pidpieza, string TxtCanRestar, string Txtidpieza)
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

                cmd.Parameters.AddWithValue("?" + PCanRestar, TxtCanRestar);
                cmd.Parameters["?" + PCanRestar].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("?" + Pidpieza, Txtidpieza);
                cmd.Parameters["?" + Pidpieza].Direction = ParameterDirection.Input;

                odadapter.SelectCommand = cmd;
                cmd.ExecuteNonQuery();
                //MessageBox .Show("Usuario Guardado Con Exito!!",MessageBoxIcon.Information);

            //    MessageBox.Show(" pieza actualizada  exitosamente ", " SISTEMA VERTICAL ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" No se pueden guardar los datos \n ERROR: " + ex.Message, "SISVEUG  SOFTWARE ", MessageBoxButtons.OK, MessageBoxIcon.Stop);

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
