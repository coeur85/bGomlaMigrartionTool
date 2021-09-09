using System.Collections.Generic;
using BgFBG_MergeTool.Models.Stocks.Entities;

namespace BgFBG_MergeTool.Models.Stocks
{
    public class StockOrder
    {
        public StkOrderEnitiyModel Header { get; set; }  
        public List<StkOrderItemEnitiyModel> Items { get; set; }
    }
}