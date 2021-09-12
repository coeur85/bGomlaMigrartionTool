using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using BgFBG_MergeTool.Models.Branches;
using BgFBG_MergeTool.Models.Stocks;
using BgFBG_MergeTool.Models.Stocks.Dtos;
using BgFBG_MergeTool.Models.Stocks.Entities;

namespace bGomlaMigrartionTool.Repository.Stock
{
    public interface IStockOrderItemsRepository
    {
        Task<List<StkOrderItemEnitiyModel>> SelectStockOrderItemsAsync(StockOrderSelectorDto model , BranchModel branchServe,IDbTransaction transaction);
        Task<int> InsertStockOrderItemsAsync(StkOrderItemEnitiyModel model, BranchModel branchServe,IDbTransaction transaction);
        Task<int> DeleteStockOrderItemsAsync(StkOrderItemEnitiyModel model, BranchModel branchServe,IDbTransaction transaction);
    }
}