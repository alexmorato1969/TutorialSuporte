using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace APP_PEDIDOS.pedidosClasses
{

    class ufClass
    {

        // Criar os gets sets (propriedades)
        public int CD_uf { get; set; }
        public string DS_sigla_UF { get; set; }
        public string NM_UF { get; set; }
        public string DS_regiao_UF { get; set; }


        // Criar a conexão com o banco de dados
        static string minhaconexao = ConfigurationManager.ConnectionStrings["AMPMConnection"].ConnectionString;


        // Criar o método select

        /*
        public DataTable LerTudo()
        {
            SqlConnection conn = new SqlConnection(minhaconexao);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sql = "Select top 2 * from tbl_UF_Teste";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

            }
            catch(SqlException exsql)
            {
                string txterro = exsql.Message.ToString();
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }

        */

        #region CRUD

        public DataTable Select()
        {
            SqlConnection sqlconn = new SqlConnection(minhaconexao);
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select * from tbl_UF_Teste";
                SqlCommand cmd = new SqlCommand(sql, sqlconn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                sqlconn.Open();
                da.Fill(dt);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                sqlconn.Close();
            }
            return dt;
        }

        // Criar o método insert
        public bool Insert(ufClass c)
        {
            bool isSucesso = false;
            SqlConnection sqlconn = new SqlConnection(minhaconexao);
            try
            {
                string sql = "Insert into tbl_UF_Teste (DS_sigla_UF, NM_UF, DS_regiao_UF) values (@DS_sigla_UF, @NM_UF, @DS_regiao_UF)";

                SqlCommand cmd = new SqlCommand(sql, sqlconn);
                
                //cmd.Parameters.AddWithValue("@CD_uf", c.CD_uf);
                cmd.Parameters.AddWithValue("@DS_sigla_UF", c.DS_sigla_UF);
                cmd.Parameters.AddWithValue("@NM_UF", c.NM_UF);
                cmd.Parameters.AddWithValue("@DS_regiao_UF", c.DS_regiao_UF);

                sqlconn.Open();
                int linha = cmd.ExecuteNonQuery();

                if(linha>0)
                {
                    isSucesso = true;
                }
                else
                {
                    isSucesso = false;
                }



            }
            catch(Exception ex)
            {

            }
            finally
            {
                sqlconn.Close();
            }

            return isSucesso;

        }

        // Criar o método update
        public bool Update(ufClass c)
        {
            bool isSucesso = false;
            SqlConnection sqlconn = new SqlConnection(minhaconexao);

            try
            {
                string sql = "Update tbl_UF_Teste set DS_sigla_UF = @DS_sigla_UF, NM_UF = @NM_UF, DS_regiao_UF =@DS_regiao_UF Where CD_uf = @CD_uf";
                SqlCommand cmd = new SqlCommand(sql, sqlconn);

                cmd.Parameters.AddWithValue("@DS_sigla_UF", c.DS_sigla_UF);
                cmd.Parameters.AddWithValue("@NM_UF", c.NM_UF);
                cmd.Parameters.AddWithValue("@DS_regiao_UF", c.DS_regiao_UF);
                cmd.Parameters.AddWithValue("@CD_uf", c.CD_uf);

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

            }
            finally
            {
                sqlconn.Close();
            }

            return isSucesso;

        }

        // Criar o método delete
        public bool Delete(ufClass c)
        {
            bool isSucesso = false;
            SqlConnection sqlconn = new SqlConnection(minhaconexao);

            try
            {
                string sql = "Delete from tbl_UF_Teste Where CD_uf = @CD_uf";
                SqlCommand cmd = new SqlCommand(sql, sqlconn);

                cmd.Parameters.AddWithValue("@CD_uf", c.CD_uf);

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
                ex.Message.ToString();
            }
            finally
            {
                sqlconn.Close();
            }

            return isSucesso;

        }

        #endregion #region CRUD

        #region Comentários
        /*
         
        [CD_uf] [int] IDENTITY(1,1) NOT NULL,
	    [DS_sigla_UF] [char](2) NOT NULL,
	    [NM_UF] [varchar](50) NOT NULL,
	    [DS_regiao_UF] [varchar](50) NOT NULL, 
         
        */

        #endregion Comentários

    }
}
