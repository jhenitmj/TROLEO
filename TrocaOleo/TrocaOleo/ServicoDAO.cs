using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocaOleo
{
    public class ServicoDAO
    {
        public void Inserir(ServicoTrocaOleo obj)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            {
                string strSQL = @"INSERT INTO TrocaOleo (DATAS, CLIENTE, OLEO, TIPO, CATEGORIA, FABRICANTE, VALOR, QTDE, EMAILC ) VALUES (@DATA, @ClIENTE, @OLEO, @CATEGORIA, @TIPO, @FABRICANTE, @VALOR, @qtde, @Emailc);";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@DATA", SqlDbType.VarChar).Value = obj.Data;
                    cmd.Parameters.Add("@CLIENTE", SqlDbType.VarChar).Value = obj.Cliente;
                    cmd.Parameters.Add("@OLEO", SqlDbType.VarChar).Value = obj.Oleo;
                    cmd.Parameters.Add("@TIPO", SqlDbType.VarChar).Value = obj.Tipo;
                    cmd.Parameters.Add("@CATEGORIA", SqlDbType.VarChar).Value = obj.Categoria;
                    cmd.Parameters.Add("@FABRICANTE", SqlDbType.VarChar).Value = obj.Fabricante;
                    cmd.Parameters.Add("@VALOR", SqlDbType.VarChar).Value = obj.ValorTotal;
                    cmd.Parameters.Add("@qtde", SqlDbType.VarChar).Value = obj.QtdeLitro;
                    cmd.Parameters.Add("@Emailc", SqlDbType.VarChar).Value = obj.Email;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
 

