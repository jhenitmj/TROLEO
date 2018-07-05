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
        

        public List<Oleo> CarregarOleo()
        {
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog = TROLEO; Data Source = localhost; Integrated Security = SSPI"))
            {
                string srtSQL = "SELECT * FROM OLEO";
                DataTable dt = new DataTable();
                conn.Open();
                using (SqlCommand cmdo = new SqlCommand())
                {
                    cmdo.CommandType = CommandType.Text;
                    cmdo.Connection = conn;
                    cmdo.CommandText = srtSQL;
                    SqlDataReader dataReader;

                    dataReader = cmdo.ExecuteReader();
                    dt.Load(dataReader);
                    conn.Close();

                    if (!(dt != null && dt.Rows.Count > 0))
                        return null;

                    List<Oleo> listaOleo = new List<Oleo>();
                    foreach (DataRow linha in dt.Rows)
                    {
                        Oleo oleo = new Oleo();
                        oleo.Nome = Convert.ToString(linha["Nome"]);
                        oleo.Categoria = Convert.ToString(linha["Categoria"]);
                        oleo.Tipo = Convert.ToString(linha["TPOLEO"]);
                        oleo.Fabricante = Convert.ToString(linha["Fabricante"]);
                        listaOleo.Add(oleo);
                    }
                    return listaOleo;

                }
            }
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
