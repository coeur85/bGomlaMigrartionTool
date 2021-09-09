using System;

namespace BgFBG_MergeTool.Models.Stocks.Entities
{
    public class StkOrderEnitiyModel
    {
        public short company { get; set; }
        public short sector { get; set; }
        public short region { get; set; }
        public int branch { get; set; }
        public short section { get; set; }
        public short transtype { get; set; }
        public short doctype { get; set; }
        public int orderno { get; set; }
        public DateTime orderdate { get; set; }
        public int sites { get; set; }
        public short? sites_section { get; set; }
        public short? reordertype { get; set; }
        public int? reorderno { get; set; }
        public DateTime? reorderdate { get; set; }
        public short goodstype { get; set; }
        public short? status { get; set; }
        public int? invoiceno { get; set; }
        public DateTime? invoicedate { get; set; }
        public string examinationno { get; set; }
        public DateTime? examinationdate { get; set; }
        public string storeorder { get; set; }
        public DateTime? storedate { get; set; }
        public int? shipmentno { get; set; }
        public DateTime? shipmentdate { get; set; }
        public short? review { get; set; }
        public DateTime? reviewdate { get; set; }
        public short? posting { get; set; }
        public DateTime? postingdate { get; set; }
        public int? userid { get; set; }
        public short? transid { get; set; }
        public DateTime? transdate { get; set; }

        public short? collection { get; set; }

        public short? new_entry { get; set; }

        public short? dispatch_type { get; set; }

        public short? purchase_flag { get; set; }

        public int? Fin_Entryno { get; set; }

        public DateTime? Fin_Entrydate { get; set; }

        public short? Payment_type { get; set; }

        public DateTime? Due_date { get; set; }

        public int? Return_doc_no { get; set; }

        public DateTime? Return_doc_date { get; set; }

        public short? Invoice_type { get; set; }

        public int? Whole_seller { get; set; }

        public decimal? order_code { get; set; }

        public int? Branch_request { get; set; }

        public short? Discountype { get; set; }

        public decimal? Discountpercentage { get; set; }

        public decimal? Discountvalue { get; set; }

        public decimal? Totalvalue { get; set; }

        public decimal? Netvalue { get; set; }

        public int? Finalizedby { get; set; }

        public DateTime? Finalizeddate { get; set; }

        public int? Reviewedby { get; set; }

        public int? Postedby { get; set; }

        public short? Tax_add { get; set; }

        public decimal? Tax_value { get; set; }

        public short? Entered_from { get; set; }

        public DateTime? Entered_time { get; set; }

        public short? Order_item_count { get; set; }

        public string Notes { get; set; }

        public int? Reasonid { get; set; }

        public int? DispatchNature { get; set; }

        public short? Pos_id { get; set; }

        public int? DriverCode { get; set; }

        public string Carlicenseplatenumber { get; set; }

        public short? Penalty_code { get; set; }

        public decimal? Penalty_fees { get; set; }

        public string SuppliersInvoicesNO { get; set; }

        public string CarlockerNO { get; set; }

        public string Reserved1 { get; set; }

        public string Reserved2 { get; set; }

        public string Reserved3 { get; set; }

        public decimal? Reserved4 { get; set; }

        public decimal? Reserved5 { get; set; }

        public DateTime? Reserved6 { get; set; }

        public DateTime? Reserved7 { get; set; }

        public int? Reserved8 { get; set; }

        public int? Reserved9 { get; set; }

        public int? Reserved10 { get; set; }

        public DateTime? Reserved11 { get; set; }

        public DateTime? Reserved12 { get; set; }

        public int? Reserved13 { get; set; }

        public int? Reserved14 { get; set; }

        public int? Reserved15 { get; set; }
    }
}