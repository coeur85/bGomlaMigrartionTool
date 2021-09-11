using System;

namespace BgFBG_MergeTool.Models.Accounting.Dtos
{
    public class AccountingTransactionSelectorDto
    {
        public int Location { get; set; }
        public int DocType { get; set; }
        public int OriginalDocNo { get; set; }
        public DateTime OriginalDocDate { get; set; }
    }
}