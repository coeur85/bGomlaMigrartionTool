using System;
using System.Collections.Generic;

namespace BgFBG_MergeTool.Models.Stocks.Dtos
{
    public class StockOrderSelectorDto
    {
        public int OrderNO { get; set; }
        public DateTime OrderDate { get; set; }
        public int Branch { get; set; }
        public int DocType { get; set; }
    }
}