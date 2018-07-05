using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocaOleo
{
    public class UsuarioDAO
    {

        public Usuario Logar(Usuario obj)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            {
                string strSQL = @"SELECT EMAIL, SENHA FROM [USER] WHERE Email = @email or Senha = @senha;";

                DataTable dt = new DataTable();
                conn.Open();

                using (SqlCommand cmdo = new SqlCommand(strSQL))
                {
                    cmdo.CommandType = CommandType.Text;
                    cmdo.Connection = conn;
                    cmdo.CommandText = strSQL;
                    cmdo.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.Email;
                    cmdo.Parameters.Add("@senha", SqlDbType.VarChar).Value = obj.Senha;

                    SqlDataReader dataReader;
                    dataReader = cmdo.ExecuteReader();
                    dt.Load(dataReader);

                    if (!(dt != null && dt.Rows.Count > 0))
                        return null;

                    var row = dt.Rows[0];
                    var usuario = new Usuario()
                    {
                        Email = row["Email"].ToString(),
                        Senha = row["Senha"].ToString()
                    };

                    conn.Close();
                    return usuario;
                }
            }
        }

        public static void CadastrarUsuario(Usuario obj)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            {
                string strSQL = @"INSERT INTO [USER] (Email, Senha) VALUES (@Email, @Senha);";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = obj.Email;
                    cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = obj.Senha;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}

