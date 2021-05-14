using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace APP_PEDIDOS.pedidosClasses
{
    class cidadeClass
    {
        public int cd_cidade { get; set; }
        public string NM_cidade { get; set; }
        public int cd_uf { get; set; }

        static string minhaconexao = ConfigurationManager.ConnectionStrings["AMPMConnection"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection sqlconn = new SqlConnection(minhaconexao);
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select * from vwCidade";

                SqlCommand cmd = new SqlCommand(sql, sqlconn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                sqlconn.Open();
                da.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sqlconn.Close();
            }
            return dt;
        }

        public DataTable SelectCbo()
        {
            SqlConnection sqlconn = new SqlConnection(minhaconexao);
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select distinct cd_uf,nm_uf from tbl_UF_Teste order by nm_uf";
                SqlCommand cmd = new SqlCommand(sql, sqlconn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                sqlconn.Open();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlconn.Close();
            }
            return dt;
        }

        public bool Insert(cidadeClass d)
        {
            bool isSucesso = false;
            SqlConnection sqlconn = new SqlConnection(minhaconexao);
            try
            {
                string sql = "Insert into tbl_Cidade (NM_Cidade, Cd_uf) values (@NM_Cidade, @Cd_uf)";

                SqlCommand cmd = new SqlCommand(sql, sqlconn);

                cmd.Parameters.AddWithValue("@NM_Cidade", d.NM_cidade);
                cmd.Parameters.AddWithValue("@cd_UF", d.cd_uf);

                sqlconn.Open();
                int linha = cmd.ExecuteNonQuery();

                if (linha > 0)
                {
                    isSucesso = true;
                }
                else
                {
                    isSucesso = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlconn.Close();
            }

            return isSucesso;
        }

        public bool Update(cidadeClass d)
        {
            bool isSucesso = false;
            SqlConnection sqlconn = new SqlConnection(minhaconexao);

            try
            {
                string sql = "Update tbl_Cidade set nm_cidade = @nm_cidade, cd_UF = @cd_UF Where CD_cidade = @CD_cidade";
                SqlCommand cmd = new SqlCommand(sql, sqlconn);

                cmd.Parameters.AddWithValue("@nm_cidade", d.NM_cidade);
                cmd.Parameters.AddWithValue("@NM_UF", d.cd_uf);

                sqlconn.Open();

                int linha = cmd.ExecuteNonQuery();

                if (linha > 0)
                {
                    isSucesso = true;
                }
                else
                {
                    isSucesso = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlconn.Close();
            }

            return isSucesso;

        }

        public bool Delete(cidadeClass d)
        {
            bool isSucesso = false;
            SqlConnection sqlconn = new SqlConnection(minhaconexao);

            try
            {
                string sql = "Delete from tbl_cidade Where CD_cidade = @CD_cidade";
                SqlCommand cmd = new SqlCommand(sql, sqlconn);

                cmd.Parameters.AddWithValue("@CD_uf", d.cd_cidade);

                sqlconn.Open();

                int linha = cmd.ExecuteNonQuery();


                if (linha > 0)
                {
                    isSucesso = true;
                }
                else
                {
                    isSucesso = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlconn.Close();
            }

            return isSucesso;

        }
    }
}
