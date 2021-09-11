using System;
using System.Collections.Generic;

namespace BgFBG_MergeTool.Models.Stocks.Dtos
{
    public class CreateStockOrderDto
    {
        public int OrderNO { get; set; }
        public DateTime OrderDate { get; set; }
        public int Branch { get; set; }
        public int Sites { get; set; }
        public int DocType { get; set; }
        public int? InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public List<ItemQty> Items { get; set; }
    }
}