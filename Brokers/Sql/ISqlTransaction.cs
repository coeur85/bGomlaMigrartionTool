using System.Data;

namespace BgFBG_MergeTool.Brokers.Sql
{
    public interface ISqlTransaction
    {
         void CommitTransaction();
        void CommitTransaction(IDbTransaction transaction);
        void RollbackTransaction();
        IDbTransaction StartTransaction();
    }
}