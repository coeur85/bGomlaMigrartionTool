using System.Threading.Tasks;
using BgFBG_MergeTool.Brokers.Sql;
using BgFBG_MergeTool.Models.Accounting.Dtos;
using BgFBG_MergeTool.Models.Branches;
using BgFBG_MergeTool.Models.Stocks;
using BgFBG_MergeTool.Models.Stocks.Dtos;
using BgFBG_MergeTool.Repository.Stock;
using BgFBG_MergeTool.Services.Accounting;
using bGomlaMigrartionTool.Models.Stocks.Dtos;
using bGomlaMigrartionTool.Repository.Stock;
using Services.Stock;

namespace BgFBG_MergeTool.Services.Stock
{
    public class StockServices : IStockServices
    {
        private readonly IStockOrderRepository _orderRepo;
        private readonly IStockOrderItemsRepository _orderItemsRepo;
        private readonly IAccountingServices _accountingService;
        private readonly ISqlTransaction _transactions;

        public StockServices(IStockOrderRepository order, 
        IStockOrderItemsRepository orderItems, 
        IAccountingServices  accountingServices,
        ISqlTransaction transaction )
        {
            _orderRepo = order;
            _orderItemsRepo = orderItems;
            _accountingService = accountingServices;
            _transactions = transaction;
        }

        public Task<int> CreateStockOrderAsync(StockOrderCreateDto model)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> DeleteStockOrderAsync(StockOrderSelectorDto model)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> GetNewStockOrderNumberAsync(NewStockOrderNumberModel model)
        {
            throw new System.NotImplementedException();
        }

        public Task<StockOrderModel> GetStockOrderAsync(StockOrderSelectorDto model)
        {
            throw new System.NotImplementedException();
        }
    }
}