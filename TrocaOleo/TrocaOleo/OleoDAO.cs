using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocaOleo
{
    public class OleoDAO
    {
        public List<Oleo> CarregarNome()
        {
            var lst = new List<Oleo>();

            using (SqlConnection conn = new SqlConnection(@"Initial Catalog = TROLEO; Data Source = localhost; Integrated Security = SSPI"))
            {
                string strSQL = "SELECT NOME FROM OLEO;";

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
                        var oleo = new Oleo()
                        {
                            Cod = Convert.ToInt32(row["CODO"]),
                            Nome = row["NOME"].ToString()
                        };
                        lst.Add(oleo);
                    }
                }
            }
            return lst;
        }

        public List<Oleo> CarregarCategoria()
        {
            var lst = new List<Oleo>();

            using (SqlConnection conn = new SqlConnection(@"Initial Catalog = TrocaOleo; Data Source = localhost; Integrated Security = SSPI"))
            {
                string strSQL = "SELECT CATEGORIA FROM OLEO;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = strSQL;
                    cmd.Parameters.Add("@CODO", SqlDbType.Int).Value =  ;
                    var dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);

                    conn.Close();
                    foreach (DataRow row in dt.Rows)
                    {
                        var oleo = new Oleo()
                        {  
                            Cod = Convert.ToInt32(row["CODO"]),
                            Categoria = row["CATEGORIA"].ToString()
                        };
                        lst.Add(oleo);
                    }
                }
            }
            return lst;
        }

        public List<Oleo> CarregarTipo()
        {
            var lst = new List<Oleo>();

            using (SqlConnection conn = new SqlConnection(@"Initial Catalog = TROLEO; Data Source = localhost; Integrated Security = SSPI"))
            {
                string strSQL = "SELECT TIPO FROM OLEO;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = strSQL;

                    var dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);

                    conn.Close();
                    foreach (DataRow row in dt.Rows)
                    {
                        var oleo = new Oleo()
                        {
                            Cod = Convert.ToInt32(row["CODC"]),
                            Tipo = row["TIPO"].ToString()
                        };
                        lst.Add(oleo);
                    }
                }
            }
            return lst;
        }

        public List<Oleo> CarregarFabricante()
        {
            var lst = new List<Oleo>();

            using (SqlConnection conn = new SqlConnection(@"Initial Catalog = TROLEO; Data Source = localhost; Integrated Security = SSPI"))
            {
                string strSQL = "SELECT FABRICANTE FROM OLEO;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = strSQL;

                    var dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);

                    conn.Close();
                    foreach (DataRow row in dt.Rows)
                    {
                        var oleo = new Oleo()
                        {
                            Cod = Convert.ToInt32(row["CODO"]),
                            Fabricante = row["FABRICANTE"].ToString()
                        };
                        lst.Add(oleo);
                    }
                }
            }
            return lst;
        }

        ////public string CarregarValor()
        ////{
        ////    using (SqlConnection conn = new SqlConnection(@"Initial Catalog = TROLEO; Data Source = localhost; Integrated Security = SSPI"))
        ////    {
        ////        string strSQL = "SELECT valor FROM oleo where cod_oleo = @cod_oleo;";

        ////        using (SqlCommand cmd = new SqlCommand(strSQL))
        ////        {
        ////            conn.Open();
        ////            cmd.Connection = conn;
        ////            cmd.CommandText = strSQL;

        ////            var dataReader = cmd.ExecuteReader();
        ////            var dt = new DataTable();
        ////            dt.Load(dataReader);

        ////            conn.Close();
        ////            foreach (DataRow row in dt.Rows)
        ////            {
        ////                var oleo = new Oleo()
        ////                {
        ////                    Cod = Convert.ToInt32(row["cod_cliente"]),
        ////                    Fabricante = row["fabicante"].ToString()
        ////                };
        ////            }
        ////        }
        ////    }
        ////}
    }
}
