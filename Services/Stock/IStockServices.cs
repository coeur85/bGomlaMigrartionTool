using System.Threading.Tasks;
using BgFBG_MergeTool.Models.Stocks;
using BgFBG_MergeTool.Models.Stocks.Dtos;
using bGomlaMigrartionTool.Models.Stocks.Dtos;

namespace Services.Stock
{

    public interface IStockServices 
    {
         Task<StockOrderModel> GetStockOrderAsync(StockOrderSelectorDto model);
        Task<int> GetNewStockOrderNumberAsync(NewStockOrderNumberModel model);
        Task<int> CreateStockOrderAsync(StockOrderCreateDto model);
        Task<int> DeleteStockOrderAsync(StockOrderSelectorDto model);

        void SetConnectionString(string connectionString);
    }
}