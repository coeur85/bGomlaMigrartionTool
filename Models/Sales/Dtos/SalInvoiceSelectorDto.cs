using System;

namespace BgFBG_MergeTool.Models.Sales.Dtos
{
    public class SalInvoiceSelectorDto
    {
        public int  Branch { get; set; }
        public int InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public  int DocType { get; set; }   
        public int PosId { get; set; }
    }
}