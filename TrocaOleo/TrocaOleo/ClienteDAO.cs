using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocaOleo
{
    class ClienteDAO
    {
        public List<Cliente> CarregarCliente()
        {
            var lst = new List<Cliente>();

            using (SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=TROLEO;Integrated Security=True"))
            {
                string strSQL = "SELECT * FROM CLIENTE;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = strSQL;

                    var dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);

                    if (!(dt != null && dt.Rows.Count > 0))
                        return null;                                             

                    conn.Close();
                    foreach (DataRow row in dt.Rows)
                    {
                        var Cliente = new Cliente()
                        {
                            Cod = Convert.ToInt32(row["CODC"]),
                            Nome = row["NOME"].ToString()
                        };
                        lst.Add(Cliente);
                    }
                }
            }
            return lst;
        }

        public bool ValidarEmail(string email)
        {
            if (String.IsNullOrEmpty(email))
                return false;
            if (!email.Contains("@") || !email.Contains("."))
                return false;
            string[] strCamposEmail = email.Split(new String[] { "@" }, StringSplitOptions.RemoveEmptyEntries);
            if (strCamposEmail.Length != 2)
                return false;
            if (strCamposEmail[0].Length < 3)
                return false;
            if (!strCamposEmail[1].Contains("."))
                return false;
            strCamposEmail = strCamposEmail[1].Split(new String[] { "." }, StringSplitOptions.RemoveEmptyEntries);
            if (strCamposEmail.Length < 2)
                return false;
            if (strCamposEmail[0].Length < 1)
                return false;
            return true;
        }
    }
}
