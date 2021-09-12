using System.Data;
using System.Threading.Tasks;
using BgFBG_MergeTool.Models.Branches;
using BgFBG_MergeTool.Models.Sales.Dtos;
using BgFBG_MergeTool.Models.Sales.Entities;

namespace BgFBG_MergeTool.Repository.Sales
{
    public interface ISalesInvoiceRepository
    {
        Task<SalInvoiceEnitiyModel> SelectSalesInvoiceAsync(SalInvoiceSelectorDto model,BranchModel branchServe,IDbTransaction transaction);
        Task<int> DeleteSalesInvoiceAsync(SalInvoiceEnitiyModel model,BranchModel branchServe,IDbTransaction transaction);
        
    }
}