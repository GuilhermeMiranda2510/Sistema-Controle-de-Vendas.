using SistemaVendaRaizes.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendaRaizes.Infra.DAO
{
    class FindParameters : DbHelper
    {
        SqlConnection con = new SqlConnection(Connection.GGConfeitaria());
        SqlDataReader reader;
        SqlCommand cmd;
        SqlTransaction tx = null;
        public Boolean open()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            try
            {
                con.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível estabelecer conexão com o Banco de Dados, por favor contate o administrador", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return false;
        }


        public List<string> FindBloco()
        {
            var bloco = new List<string>();

            con.Close();
            cmd = new SqlCommand("PRC_LS_BLOCO", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                if (open())
                {
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        bloco.Add(reader["DESCRICAO"].ToString());
                    }
                }

                reader.Close();
                cmd.Connection.Close();
            }
            catch (SqlException exsql)
            {
                throw (exsql);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return bloco;
        }

        public List<string> FindAP()
        {
            var ap = new List<string>();

            con.Close();
            cmd = new SqlCommand("PRC_LS_AP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                if (open())
                {
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ap.Add(reader["DESCRICAO"].ToString());
                    }
                }
                reader.Close();
                cmd.Connection.Close();
            }
            catch (SqlException exsql)
            {
                throw (exsql);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return ap;
        }


        public List<string> FindTipo()
        {
            var tipo = new List<string>();

            con.Close();
            cmd = new SqlCommand("PRC_LS_TIPO", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                if (open())
                {
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tipo.Add(reader["DESCRICAO"].ToString());
                    }
                }
                reader.Close();
                cmd.Connection.Close();
            }
            catch (SqlException exsql)
            {
                throw (exsql);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return tipo;
        }

        public List<string> FindSetor()
        {
            var setor = new List<string>();

            con.Close();
            cmd = new SqlCommand("PRC_LS_SETOR", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                if (open())
                {
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        setor.Add(reader["DESCRICAO"].ToString());
                    }
                }
                reader.Close();
                cmd.Connection.Close();
            }
            catch (SqlException exsql)
            {
                throw (exsql);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return setor;
        }

        public List<string> FindCliente()
        {
            var cliente = new List<string>();

            con.Close();
            cmd = new SqlCommand("PRC_LS_CLIENTE", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                if (open())
                {
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cliente.Add(reader["NOME"].ToString());
                    }
                }
                reader.Close();
                cmd.Connection.Close();
            }
            catch (SqlException exsql)
            {
                throw (exsql);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return cliente;
        }

        public List<string> FindProduto()
        {
            var produto = new List<string>();

            con.Close();
            cmd = new SqlCommand("PRC_LS_PRODUTO", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                if (open())
                {
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        produto.Add(reader["DESCRICAO"].ToString());
                    }
                }
                reader.Close();
                cmd.Connection.Close();
            }
            catch (SqlException exsql)
            {
                throw (exsql);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return produto;
        }

        public List<string> FindTipoProduto(string tipo)
        {
            var produto = new List<string>();

            con.Close();
            cmd = new SqlCommand("PRC_FIND_TIPO_PRODUTO", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TIPO", tipo);
            try
            {
                if (open())
                {
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                         produto.Add(reader["DESCRICAO"].ToString());
                    }
                }
                reader.Close();
                cmd.Connection.Close();
            }
            catch (SqlException exsql)
            {
                throw (exsql);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return produto;
        }

        public string FindProdutoValor(string produto)
        {
            var valor = "";

            con.Close();
            cmd = new SqlCommand("PRC_FIND_PRODUTO_VALOR", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PRODUTO", produto);
            try
            {
                if (open())
                {
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        valor =  reader["VALOR_UNI"].ToString();
                    }
                }
                reader.Close();
                cmd.Connection.Close();
            }
            catch (SqlException exsql)
            {
                throw (exsql);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return valor;
        }

        public List<string> FindPagamento()
        {
            var pagamento = new List<string>();

            con.Close();
            cmd = new SqlCommand("PRC_LS_PAGAMENTO", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                if (open())
                {
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        pagamento.Add(reader["DESCRICAO"].ToString());
                    }
                }
                reader.Close();
                cmd.Connection.Close();
            }
            catch (SqlException exsql)
            {
                throw (exsql);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return pagamento;
        }


        public bool RegistraPedido(List<PedidoItemModel> pedido)
        {

            var cmdPedido = new List<SqlCommand>();
            try
            {
                con.Close();
                for (int i = 0; i < pedido.Count; i++)
                {
                    cmd = new SqlCommand("PRC_REGISTRA_PEDIDO", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BLOCO", pedido[i].Bloco);
                    cmd.Parameters.AddWithValue("@AP", pedido[i].AP);
                    cmd.Parameters.AddWithValue("@CLIENTE", "");
                    cmd.Parameters.AddWithValue("@TIPO", pedido[i].Tipo);
                    cmd.Parameters.AddWithValue("@PRODUTO", pedido[i].Produto);
                    cmd.Parameters.AddWithValue("@VALORUNI", pedido[i].VUni);
                    cmd.Parameters.AddWithValue("@QTDE", pedido[i].Qtde);
                    cmd.Parameters.AddWithValue("@PAGAMENTO", pedido[i].Pag);
                    cmd.Parameters.AddWithValue("@VALORTOTAL", pedido[i].VTotal);
                    cmdPedido.Add(cmd);
                }
                if (open())
                {
                    //ABRE A TRANSACTION
                    tx = con.BeginTransaction(IsolationLevel.Snapshot);
                    for (int b = 0; b < cmdPedido.Count; b++)
                    {
                        cmdPedido[b].Transaction = tx;
                    }
                    for (int c = 0; c < cmdPedido.Count; c++)
                    {
                        cmdPedido[c].ExecuteNonQuery();
                    }
                    tx.Commit();
                    return true;
                }
            }
            catch (Exception ex)
            {
                //if (tx != null) { tx.Rollback(); }
                //SplashScreen.CloseSplashScreen();
                //aux.WriteLog(string.Empty, "TRANSACTION", "INSERE REGISTRO REPARO EXPEDICAO", ex.ToString());
                //throw new Exception("Não foi possível inserir defeitos, Rollback executado!");
            }
            finally
            {
                //con.Close();
                // this.Dispose();
            }
            return true;
        }

        public bool RegistraPedidoFiveMed(string cliente, string tipo, string produto, string valoruni, string qtde, string valortotal, string pag)
        {

            var cmdPedidoFive = new List<SqlCommand>();
            try
            {
                con.Close();

                    cmd = new SqlCommand("PRC_REGISTRA_PEDIDO", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BLOCO", "");
                    cmd.Parameters.AddWithValue("@AP", "");
                    cmd.Parameters.AddWithValue("@CLIENTE", cliente);
                    cmd.Parameters.AddWithValue("@TIPO", tipo);
                    cmd.Parameters.AddWithValue("@PRODUTO", produto);
                    cmd.Parameters.AddWithValue("@VALORUNI", "R$"+ valoruni);
                    cmd.Parameters.AddWithValue("@QTDE", qtde);
                    cmd.Parameters.AddWithValue("@VALORTOTAL", "R$"+ valortotal);
                    cmd.Parameters.AddWithValue("@PAGAMENTO", pag);
                cmdPedidoFive.Add(cmd);

                if (open())
                {
                    //ABRE A TRANSACTION
                    tx = con.BeginTransaction(IsolationLevel.Snapshot);
                    for (int b = 0; b < cmdPedidoFive.Count; b++)
                    {
                        cmdPedidoFive[b].Transaction = tx;
                    }
                    for (int c = 0; c < cmdPedidoFive.Count; c++)
                    {
                        cmdPedidoFive[c].ExecuteNonQuery();
                    }
                    tx.Commit();
                    return true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return true;
        }

        public bool RegistraProduto(string tipo, string produto, string valoruni)
        {

            cmd = new SqlCommand("PRC_REGISTRA_PRODUTO", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TIPO", tipo);
            cmd.Parameters.AddWithValue("@PRODUTO", produto);
            cmd.Parameters.AddWithValue("@VALORUNI", valoruni);

            try
            {
                if (open())
                {
                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch (ArgumentException e)
            {
                throw (e);
            }
            catch (SqlException e)
            {
                throw (e);
            }
            catch (Exception e)
            {
                throw (e);
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public bool RegistraCliente(string setor, string nome)
        {

            cmd = new SqlCommand("PRC_REGISTRA_CLIENTE", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SETOR", setor);
            cmd.Parameters.AddWithValue("@NOME", nome);

            try
            {
                if (open())
                {
                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }
            }
            catch (ArgumentException e)
            {
                throw (e);
            }
            catch (SqlException e)
            {
                throw (e);
            }
            catch (Exception e)
            {
                throw (e);
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public List<PedidoItemModel> GeraRelatorioTotal(DateTime data_ini, DateTime data_fim, string bloco, string ap, string tipo, string local)
        {
            var data_i = data_ini.ToString("yyyy-MM-dd 00:00:00");
            var data_f = data_fim.ToString("yyyy-MM-dd 23:59:59");

            var total = new List<PedidoItemModel>();
            con.Close();
            cmd = new SqlCommand("PRC_RELATORIOVENDAS", con);
            cmd.Parameters.AddWithValue("@data_ini", data_i);
            cmd.Parameters.AddWithValue("@data_fim", data_f);
            cmd.Parameters.AddWithValue("@bloco", bloco ?? string.Empty);
            cmd.Parameters.AddWithValue("@ap", ap ?? string.Empty);
            cmd.Parameters.AddWithValue("@tipo", tipo ?? string.Empty);
            cmd.Parameters.AddWithValue("@local", local ?? string.Empty);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                if (open())
                {
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        total.Add(new PedidoItemModel()
                        {
                            DataVenda = Convert.ToDateTime(reader["DATA_REGISTRO"].ToString()),
                            Bloco = Convert.ToInt32(reader["BLOCO"].ToString()),
                            AP = Convert.ToInt32(reader["AP"].ToString()),
                            Cliente = reader["CLIENTE"].ToString(),
                            Tipo = reader["TIPO"].ToString(),
                            Produto = reader["PRODUTO"].ToString(),
                            Qtde = Convert.ToInt32(reader["QTDE"].ToString()),
                            VUni = reader["VALORUNI"].ToString(),
                            Pag = reader["PAGAMENTO"].ToString(),
                            VTotal = reader["VALORTOTAL"].ToString(),
                            Local = reader["LUGARDEVENDA"].ToString(),
                        });
                    }
                }
            }
            catch (SqlException e)
            {
                throw (e);
            }
            catch (Exception e)
            {
                throw (e);
            }
            finally
            {
                reader.Close();
            }
            return total;
        }
    }
}

