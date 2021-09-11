using System.Collections.Generic;
using System.Threading.Tasks;
using BgFBG_MergeTool.Models.Sales.Entities;

namespace BgFBG_MergeTool.Brokers.Sales
{
    public interface IInvaliedSalesBroker
    {
         Task<List<SalInvoiceEnitiyModel>> GrapInvaledSalesInvoicesToCustomerAsync();
        Task<List<SalInvoiceEnitiyModel>> GrapInvaledRetunrSalesInvoicesFromCustomerAsync();
    }
}