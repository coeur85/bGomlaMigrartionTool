using System.Threading.Tasks;
using BgFBG_MergeTool.Models.Accounting.Dtos;
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
        private string _connectionString;

        public StockServices(IStockOrderRepository order, 
        IStockOrderItemsRepository orderItems, 
        IAccountingServices  accountingServices)
        {
            _orderRepo = order;
            _orderItemsRepo = orderItems;
            _accountingService = accountingServices;
        }

        public void SetConnectionString(string connectionString){
            _connectionString = connectionString;
            _accountingService.SetConnectionString(_connectionString);

        }
         
        public async Task<int> DeleteStockOrderAsync(StockOrderSelectorDto model)
        {
            int output = 0;
            var orderItems = await _orderItemsRepo.SelectStockOrderItemsAsync(model, _connectionString);
            foreach (var item in orderItems)
            {
                output += await _orderItemsRepo.DeleteStockOrderItemsAsync(item, _connectionString);
            }
          
            AccountingTransactionSelectorDto accountingSelector = new AccountingTransactionSelectorDto { 
                      Location = model.Branch , DocType = model.DocType, OriginalDocNo = model.OrderNO,
                    OriginalDocDate = model.OrderDate
            } ;
            output += await _accountingService.DeleteAccountingTransactionAsync(accountingSelector);

            var order = await _orderRepo.SelectStockOrderAsync(model, _connectionString);
            output += await _orderRepo.DeleteStockOrderAsync(order, _connectionString);

            return output;
        }

        public async Task<int> GetNewStockOrderNumberAsync(NewStockOrderNumberModel model)
        {
            int output = 0;
            output = await _orderRepo.GetNewStockOrderNumberAsync(model, _connectionString);
            return output;
        }

        public async Task<int> CreateStockOrderAsync(StockOrderCreateDto model)
        {
            // TODO esraa code fro  creating new order
            AccountingTransactionCreateDto accountingCreate = new AccountingTransactionCreateDto();
            await _accountingService.CreateAccountingTransactionAsync(accountingCreate);
            throw new System.NotImplementedException();
        }

        public async Task<StockOrderModel> GetStockOrderAsync(StockOrderSelectorDto model)
        {
            StockOrderModel output = new StockOrderModel();
            output.Header = await _orderRepo.SelectStockOrderAsync(model, _connectionString);
            output.Items = await _orderItemsRepo.SelectStockOrderItemsAsync(model, _connectionString);
            return output;
        }


    }
}