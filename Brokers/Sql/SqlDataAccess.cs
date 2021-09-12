using BgFBG_MergeTool.Brokers.Stocks;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace PBgFBG_MergeTool.Brokers.Stocks
{
    public class SqlDataAccess : ISqlDataAccess, IDisposable
    {

        public async Task<T> QueryFirstOrDefaultAsync<T, U>(IDbTransaction transaction, string sqlQury, U paramters)
        {
            using IDbConnection connection = transaction.Connection;
            return await connection.QueryFirstOrDefaultAsync<T>(sqlQury, paramters);
        }
        public async Task<T> QueryFirstOrDefaultAsync<T>(IDbTransaction transaction, string sqlQury)
        {
            using IDbConnection connection =  transaction.Connection;
            return await connection.QueryFirstOrDefaultAsync<T>(sqlQury);
        }
        public async Task<IEnumerable<T>> QueryAsync<T, U>(IDbTransaction transaction, string sqlQury, U paramters)
        {
            using IDbConnection connection = transaction.Connection;
            return await connection.QueryAsync<T>(sqlQury, param: paramters);
        }
        public async Task<IEnumerable<T>> QueryAsync<T>(IDbTransaction transaction, string sqlQury)
        {
            using IDbConnection connection =  transaction.Connection;
            return await connection.QueryAsync<T>(sqlQury);
        }
        public async Task<T> QuerySingleAsync<T, U>(IDbTransaction transaction, string sqlQury, U paramters)
        {
            using IDbConnection connection =  transaction.Connection;
            return await connection.QuerySingleAsync<T>(sqlQury, paramters);
        }
        public async Task<T> QuerySingleAsync<T>(IDbTransaction transaction, string sqlQury)
        {
            using IDbConnection connection =  transaction.Connection;
            return await connection.QuerySingleAsync<T>(sqlQury);
        }
        public async Task<int> ExecuteAsync<U>(IDbTransaction transaction, string sqlQury, U paramters)
        {
            using IDbConnection connection = transaction.Connection;
            return await connection.ExecuteAsync(sqlQury, paramters);
        }
        public void Dispose()
        {
        }
    }
}
