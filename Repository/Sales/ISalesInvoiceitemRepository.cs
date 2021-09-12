using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using BgFBG_MergeTool.Models.Branches;
using BgFBG_MergeTool.Models.Sales.Dtos;
using BgFBG_MergeTool.Models.Sales.Entities;

namespace BgFBG_MergeTool.Repository.Sales
{
    public interface ISalesInvoiceitemRepository
    {
        Task<List<SalInvoiceItemsEnitiyModel>> SelectSalesInvoiceItemsAsync(SalInvoiceSelectorDto model,BranchModel branchServe,IDbTransaction transaction);
        Task<int> DeleteSalesInvoiceItemsAsync(SalInvoiceItemsEnitiyModel model,BranchModel branchServe,IDbTransaction transaction);
    }
}