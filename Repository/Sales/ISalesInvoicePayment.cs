using System.Collections.Generic;
using System.Threading.Tasks;
using BgFBG_MergeTool.Models.Sales.Dtos;
using BgFBG_MergeTool.Models.Sales.Entities;

namespace BgFBG_MergeTool.Repository.Sales
{
    public interface ISalesInvoicePayment
    {
        Task<List<SalInvoicePayment>> SelectSalesInvoicePayemntAsync(SalInvoiceSelectorDto model);
        Task<int> DeleteSalesInvoicePaymentAsync(SalInvoicePayment model);
    }
}