using System.Collections.Generic;
using System.Threading.Tasks;
using BgFBG_MergeTool.Models.Stocks;
using BgFBG_MergeTool.Models.Stocks.Dtos;
using BgFBG_MergeTool.Models.Stocks.Entities;

namespace bGomlaMigrartionTool.Repository.Stock
{
    public interface IStockOrderItemsRepository
    {
        Task<List<StkOrderItemEnitiyModel>> SelectStockOrderItemsAsync(StockOrderSelectorDto model, string connectionString);
        Task<int> InsertStockOrderItemsAsync(StkOrderItemEnitiyModel model, string connectionString);
        Task<int> DeleteStockOrderItemsAsync(StkOrderItemEnitiyModel model, string connectionString);
    }
}