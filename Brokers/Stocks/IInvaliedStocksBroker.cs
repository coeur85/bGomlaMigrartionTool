using System.Collections.Generic;
using System.Threading.Tasks;
using BgFBG_MergeTool.Models.Stocks.Entities;

namespace BgFBG_MergeTool.Brokers.Stocks
{
    public interface IInvaliedStocksBroker
    {
        Task<List<StkOrderEnitiyModel>> GrapInvaledRecevingFromSupplierAsync();
        Task<List<StkOrderEnitiyModel>> GrapInvaledReturnsToSupplierAsync();
    }
}