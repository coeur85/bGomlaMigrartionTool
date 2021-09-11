using System.Threading.Tasks;
using BgFBG_MergeTool.Models.Accounting;
using BgFBG_MergeTool.Models.Accounting.Dtos;

namespace BgFBG_MergeTool.Services.Accounting
{
    public interface IAccountingServices
    {
        Task<AccountingTransaction> GetAccountingTransactionAsync(AccountingTransactionSelectorDto model);
        Task<int> DeleteAccountingTransactionAsync(AccountingTransactionSelectorDto model);
        Task<int> CreateAccountingTransactionAsync(AccountingTransactionCreateDto model);
        
         void SetConnectionString(string connectionString);
        
    }
}