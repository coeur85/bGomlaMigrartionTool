using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BgFBG_MergeTool.Brokers.Stocks
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> QueryAsync<T>(string connectionString, string sqlQury);
        Task<IEnumerable<T>> QueryAsync<T, U>(string connectionString, string sqlQury, U paramters);
        Task<T> QueryFirstOrDefaultAsync<T, U>(string connectionString, string sqlQury, U paramters);
        Task<T> QueryFirstOrDefaultAsync<T>(string connectionString, string sqlQury);
        public Task<T> QuerySingleAsync<T, U>(string connectionString, string sqlQury, U paramters);
        public Task<T> QuerySingleAsync<T>(string connectionString, string sqlQury);
        Task<int> ExecuteAsync<U>(IDbTransaction transaction , string sqlQury, U paramters);
    }
}