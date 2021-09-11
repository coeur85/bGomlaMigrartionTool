using System.Threading.Tasks;
using BgFBG_MergeTool.Models.Stocks;
using BgFBG_MergeTool.Models.Stocks.Dtos;
using BgFBG_MergeTool.Models.Stocks.Entities;

namespace BgFBG_MergeTool.Repository.Stock
{
    public interface IStockOrderRepository
    {
        Task<StkOrderEnitiyModel> SelectStockOrderAsync(StockOrderSelectorDto model, string connectionString)
     
        Task<int> GetNewStockOrderNumberAsync(NewStockOrderNumberModel model, string connectionString);
        Task<int> InsertStockOrderAsync(StkOrderEnitiyModel model, string connectionString);
        Task<int> DeleteStockOrderAsync(StkOrderEnitiyModel model, string connectionString);

    }
}