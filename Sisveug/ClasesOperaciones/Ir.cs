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
    class Ir
    {
        public void MetdodoIr(TextBox TxtValor, string ConsultaSQL, string ParametroId, TextBox TxtMosId, TextBox TxtMosNombre, string Piccliente, string PnombreCliente)
        {   Cadena Obj = new Cadena(); // objeto de la clase cadena    
            string CadenaApp;            
            CadenaApp = Obj.Obtenercadena();// le asigamos la cadena de conexion a la variable CadenaApp       
            string connstring = CadenaApp;
            MySqlConnection cnn = new MySqlConnection(connstring);
            {
                if (TxtValor.Text == "")
                {
                    MessageBox.Show(" Introduzca la Clave", "Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    TxtValor.Focus();
                }
                else
                {
                    try
                    {   cnn.Open();
                        string sql = ConsultaSQL+ "@TP101 ";//WHERE id =TP101
                        MySqlCommand cmd = new MySqlCommand(sql, cnn);
                        cmd.Parameters.AddWithValue("@TP101", ParametroId);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            TxtMosId.Text = Convert.ToString(reader[Piccliente]);
                            TxtMosNombre.Text = Convert.ToString(reader[PnombreCliente]);
                        }
                        else
                        {
                            MessageBox.Show("No existe registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    catch (Exception m)
                    {
                        MessageBox.Show(m.Message);
                    }
                }
            }
        }


        public int  verificar ( int bandera)

        {
            return bandera;
        }

    }
}
