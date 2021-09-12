using System.Data;
using System.Threading.Tasks;
using BgFBG_MergeTool.Models.Branches;
using BgFBG_MergeTool.Models.Stocks;
using BgFBG_MergeTool.Models.Stocks.Dtos;
using BgFBG_MergeTool.Models.Stocks.Entities;

namespace BgFBG_MergeTool.Repository.Stock
{
    public interface IStockOrderRepository
    {
        Task<StkOrderEnitiyModel> SelectStockOrderAsync(StockOrderSelectorDto model, BranchModel branchServe,IDbTransaction transaction);
        Task<int> GetNewStockOrderNumberAsync(NewStockOrderNumberModel model, BranchModel branchServe,IDbTransaction transaction);
        Task<int> InsertStockOrderAsync(StkOrderEnitiyModel model,BranchModel branchServe,IDbTransaction transaction);
        Task<int> DeleteStockOrderAsync(StkOrderEnitiyModel model, BranchModel branchServe,IDbTransaction transaction);

    }
}