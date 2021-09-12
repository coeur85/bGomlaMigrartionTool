using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace BgFBG_MergeTool.Brokers.Sql
{
    public class SqlTransaction : ISqlTransaction
    {
        private readonly string _connectionString;
        private IDbTransaction _transaction;
        private bool isClosed = false;

        public SqlTransaction(IConfiguration  configuration )
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public IDbTransaction StartTransaction()
        {
            string connectionString = _connectionString;

            SqlConnection _connection = new SqlConnection(connectionString);
            _connection.Open();

            _transaction = _connection.BeginTransaction();

            isClosed = false;
            return _transaction;
        }
        public void CommitTransaction()
        {
            _transaction?.Commit();
            _transaction.Connection?.Close();

            isClosed = true;
        }
        public void CommitTransaction(IDbTransaction transaction)
        {
            transaction?.Commit();
            transaction.Connection?.Close();

            isClosed = true;
        }
        public void RollbackTransaction()
        {
            try
            {
                if (_transaction is not null)
                {

                    _transaction?.Rollback();
                    if (_transaction.Connection is not null)
                    {
                        _transaction?.Connection?.Close();
                    }
                    _transaction.Dispose();
                }
            }

            finally
            {
                isClosed = true;
            }



        }
        private void Dispose()
        {
            if (isClosed == false)
            {
                try
                {
                    CommitTransaction();
                }
                catch
                {
                    throw;
                }
            }

            _transaction = null;
            _transaction.Connection.Dispose();
        }
    }
}