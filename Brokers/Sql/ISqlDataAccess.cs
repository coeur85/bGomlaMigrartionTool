using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BgFBG_MergeTool.Brokers.Stocks
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> QueryAsync<T>(IDbTransaction transaction, string sqlQury);
        Task<IEnumerable<T>> QueryAsync<T, U>(IDbTransaction transaction, string sqlQury, U paramters);
        Task<T> QueryFirstOrDefaultAsync<T, U>(IDbTransaction transaction, string sqlQury, U paramters);
        Task<T> QueryFirstOrDefaultAsync<T>(IDbTransaction transaction, string sqlQury);
        public Task<T> QuerySingleAsync<T, U>(IDbTransaction transaction, string sqlQury, U paramters);
        public Task<T> QuerySingleAsync<T>(IDbTransaction transaction, string sqlQury);
        Task<int> ExecuteAsync<U>(IDbTransaction transaction , string sqlQury, U paramters);
    }
}