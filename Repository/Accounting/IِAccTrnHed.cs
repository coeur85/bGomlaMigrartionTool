using System.Threading.Tasks;
using BgFBG_MergeTool.Models.Accounting.Dtos;
using BgFBG_MergeTool.Models.Accounting.Enitiy;

namespace BgFBG_MergeTool.Repository.Accounting
{
    public interface IِAccTrnHed
    {
        Task<AccTrnHedEnitiyModel> SelectAccTrnHeadAsync(AccountingTransactionSelectorDto model);
        Task<int> DeleteAccTrnHeadAsync(AccTrnHedEnitiyModel model);
        Task<int> InsertAccTrnHeadAsync(AccTrnHedEnitiyModel model);
    }
}