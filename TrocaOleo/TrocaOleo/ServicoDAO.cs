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
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog = TROLEO; Data Source = localhost; Integrated Security = SSPI"))
            {
                string strSQL = @"INSERT INTO STORLEO (DATAS, CODC, CODO, QTDEL) VALUES  (@DATAS, @CODC, @CODO, @QTDEL);";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@DATAS", SqlDbType.DateTime).Value = obj.Data;
                    cmd.Parameters.Add("@CODC", SqlDbType.Int).Value = obj.Cliente.Cod;
                    cmd.Parameters.Add("@CODO", SqlDbType.Int).Value = obj.Oleo.Cod;
                    cmd.Parameters.Add("@QTDEL", SqlDbType.Int).Value = obj.QtdeLitro;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
 

