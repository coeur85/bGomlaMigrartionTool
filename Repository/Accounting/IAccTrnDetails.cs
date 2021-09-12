using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using BgFBG_MergeTool.Models.Accounting.Dtos;
using BgFBG_MergeTool.Models.Accounting.Enitiy;
using BgFBG_MergeTool.Models.Branches;

namespace BgFBG_MergeTool.Repository.Accounting
{
    public interface IAccTrnDetails
    {
        Task<List<AccTrnDetEnitiyModel>> SelectAccTrnHeadAsync(AccountingTransactionSelectorDto model,BranchModel branchServe,IDbTransaction transaction);
        Task<int> DeleteAccTrnDetailAsync(AccTrnDetEnitiyModel model,BranchModel branchServe,IDbTransaction transaction);
        Task<int> InsertAccTrnDetailAsync(AccTrnDetEnitiyModel model,BranchModel branchServe,IDbTransaction transaction);
    }
}