using System.Threading.Tasks;
using BgFBG_MergeTool.Models.Sales.Dtos;
using BgFBG_MergeTool.Models.Sales.Entities;

namespace BgFBG_MergeTool.Repository.Sales
{
    public interface ISalesInvoiceRepository
    {
        Task<SalInvoiceEnitiyModel> SelectSalesInvoiceAsync(SalInvoiceSelectorDto model);
        Task<int> DeleteSalesInvoiceAsync(SalInvoiceEnitiyModel model);
        
    }
}