using System.Collections.Generic;
using System.Threading.Tasks;
using BgFBG_MergeTool.Models.Accounting.Dtos;
using BgFBG_MergeTool.Models.Accounting.Enitiy;

namespace BgFBG_MergeTool.Repository.Accounting
{
    public interface IAccTrnDetails
    {
        Task<List<AccTrnDetEnitiyModel>> SelectAccTrnHeadAsync(AccountingTransactionSelectorDto model);
        Task<int> DeleteAccTrnDetailAsync(AccTrnDetEnitiyModel model);
        Task<int> InsertAccTrnDetailAsync(AccTrnDetEnitiyModel model);
    }
}