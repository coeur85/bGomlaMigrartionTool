using System.Collections.Generic;
using BgFBG_MergeTool.Models.Stocks.Entities;

namespace BgFBG_MergeTool.Models.Stocks
{
    public class StockOrderModel
    {
        public StkOrderEnitiyModel Header { get; set; }  
        public List<StkOrderItemEnitiyModel> Items { get; set; } = new();
    }
}