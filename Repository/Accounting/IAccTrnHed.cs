using System.Data;
using System.Threading.Tasks;
using BgFBG_MergeTool.Models.Accounting.Dtos;
using BgFBG_MergeTool.Models.Accounting.Enitiy;
using BgFBG_MergeTool.Models.Branches;

namespace BgFBG_MergeTool.Repository.Accounting
{
    public interface IAccTrnHed
    {
        Task<AccTrnHedEnitiyModel> SelectAccTrnHeadAsync(AccountingTransactionSelectorDto model , BranchModel branchServe,IDbTransaction transaction);
        Task<int> DeleteAccTrnHeadAsync(AccTrnHedEnitiyModel model,BranchModel branchServe,IDbTransaction transaction);
        Task<int> InsertAccTrnHeadAsync(AccTrnHedEnitiyModel model,BranchModel branchServe,IDbTransaction transaction);
    }
}