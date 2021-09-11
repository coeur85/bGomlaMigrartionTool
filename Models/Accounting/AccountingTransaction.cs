using BgFBG_MergeTool.Models.Accounting.Enitiy;

namespace BgFBG_MergeTool.Models.Accounting
{
    public class AccountingTransaction
    {
        public AccTrnHedEnitiyModel Header { get; set; }
        public AccTrnDetEnitiyModel Details { get; set; }
    }
}