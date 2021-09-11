using System.Collections.Generic;
using BgFBG_MergeTool.Models.Sales.Entities;

namespace BgFBG_MergeTool.Models.Sales
{
    public class SalesInvoiceModel
    {
        public SalInvoiceEnitiyModel Header { get; set; }
        public List<SalInvoiceItemsEnitiyModel> Items { get; set; } = new();
        public List<SalInvoicePayment> Payments { get; set; } = new();
    }
}