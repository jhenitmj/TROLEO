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
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog = TROLEO; Data Source = localhost; Integrated Security = SSPI"))
            {
                string strSQL = "select EMAIL, SENHA FROM [USER] WHERE EMAIL = @EMAIL and SENHA = @SENHA";

                DataTable dt = new DataTable();
                conn.Open();

                using (SqlCommand cmdo = new SqlCommand(strSQL))
                {
                    cmdo.CommandType = CommandType.Text;
                    cmdo.Connection = conn;
                    cmdo.CommandText = strSQL;

                    cmdo.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = obj.Email;
                    cmdo.Parameters.Add("@SENHA", SqlDbType.VarChar).Value = obj.Senha;

                    SqlDataReader dataReader;
                    dataReader = cmdo.ExecuteReader();
                    dt.Load(dataReader);

                    if (!(dt != null && dt.Rows.Count > 0))
                        return null;

                    var row = dt.Rows[0];
                    var usuario = new Usuario()
                    {
                        Email = row["EMAIL"].ToString(),
                        Senha = row["SENHA"].ToString()
                    };

                    conn.Close();
                    return usuario;
                }
            }
        }

        public void Inserir(Usuario obj)
        {

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
            {
                string strSQL = @"INSERT INTO USUARIO (EMAIL, SENHA) VALUES (@Email, @Senha);";

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

