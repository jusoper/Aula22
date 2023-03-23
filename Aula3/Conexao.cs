
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    internal class Conexao
    {
        static private string servidor = "";
        static private string banco = "bd_aula3";
        static private string usuario = "root";
        static private string senha = "cursoads";

        static public string strConn = $"server={servidor};" +
            $"database={banco}; User Id={usuario};" +
            $"password={senha}";

        MySqlConnection cn;

        private bool Conectar()
        {
            bool result;
            try
            {
                cn = new MySqlConnection(strConn);
                cn.Open();
                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }

        private void Desconectar()
        {
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
        }
        public bool Executar(String sql)
        {
            bool resultado = false;
            if (Conectar())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cn);
                    cmd.ExecuteNonQuery();
                    resultado = true;
                }
                catch
                {
                    resultado = false;
                }
                finally
                {
                    Desconectar();
                }
            }
            return resultado;
        }

        public DataTable Retorna(string sql)
        {
            Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable data = cmd = new DataTable();
                da.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Desconectar();
            }
        }

    }
}




