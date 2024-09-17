using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendaRaizes.Infra.DAO
{
    class DbHelper
    {
        public SqlCommand ExecuteProcedure(string procedure)
        {
            var cmd = new SqlCommand();
            try
            {
                cmd.CommandText = procedure;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = new SqlConnection(Connection.GGConfeitaria());
                cmd.Connection.Open();
            }

            catch (SqlException exsql)
            {
                cmd.Connection.Close();
                throw exsql;
            }
            catch (Exception ex)
            {
                cmd.Connection.Close();
                throw (ex);
            }
            return cmd;
        }
        public SqlCommand ExecuteTransaction(string procedure)
        {
            var cmd = new SqlCommand();
            try
            {
                cmd.CommandText = procedure;
                cmd.CommandType = CommandType.StoredProcedure;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return cmd;
        }
        public SqlCommand ExecuteTransaction(string procedure, List<SqlParameter> parameter)
        {
            try
            {
                var cmd = ExecuteTransaction(procedure);
                cmd.Parameters.AddRange(parameter.ToArray());
                return cmd;
            }
            catch (SqlException exsql)
            {
                throw exsql;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public SqlCommand ExecuteProcedure(string procedure, List<SqlParameter> parameter)
        {
            try
            {
                var cmd = ExecuteProcedure(procedure);
                cmd.Parameters.AddRange(parameter.ToArray());
                return cmd;
            }
            catch (SqlException exsql)
            {
                throw exsql;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public void ExecuteTransaction(List<SqlCommand> command)
        {
            using (var conn = new SqlConnection(Connection.GGConfeitaria()))
            {
                SqlTransaction transaction = null;
                try
                {

                    conn.Open();
                    transaction = conn.BeginTransaction(IsolationLevel.Snapshot);
                    foreach (var comman in command)
                    {
                        comman.Connection = conn;
                        comman.Transaction = transaction;
                        comman.ExecuteNonQuery();
                        comman.Dispose();

                    }

                    transaction.Commit();
                }

                catch (SqlException ex)
                {
                    if (transaction != null)
                        transaction.Rollback();
                    throw ex;
                }
                catch (Exception ex)
                {
                    if (transaction != null)
                        transaction.Rollback();
                    throw ex;
                }
            }
        }

        public SqlCommand ExecuteTransactionWithoutConnection(string procedure, List<SqlParameter> parameter)
        {
            try
            {
                var cmd = ExecuteTransactionWithoutConnection(procedure);
                cmd.Parameters.AddRange(parameter.ToArray());
                return cmd;
            }
            catch (SqlException exsql)
            {
                throw exsql;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public SqlCommand ExecuteTransactionWithoutConnection(string procedure)
        {
            var cmd = new SqlCommand();
            try
            {
                cmd.CommandText = procedure;
                cmd.CommandType = CommandType.StoredProcedure;
            }

            catch (SqlException exsql)
            {
                throw exsql;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return cmd;
        }

    }
}
