using System.Threading.Tasks;
using BgFBG_MergeTool.Models.Stocks;
using BgFBG_MergeTool.Models.Stocks.Dtos;
using bGomlaMigrartionTool.Models.Stocks.Dtos;

namespace bGomlaMigrartionTool.Repository.Stock
{
    public interface IStockRepository
    {
        Task<StockOrderModel> SelectStockOrderAsync(StockOrderSelectorDto model, string connectionString);
        Task<int> GetNewStockOrderNumberAsync(NewStockOrderNumberModel model, string connectionString);
        Task<int> InsertStockOrderAsync(StockOrderCreateDto model, string connectionString);
        Task<int> DeleteStockOrderAsync(StockOrderSelectorDto model, string connectionString);
    }
}