using System;

namespace BgFBG_MergeTool.Models.Sales.Entities
{
    public class SalInvoiceEnitiyModel
    {
        
    public short company { get; set; }

    public short sector { get; set; }

    public short region { get; set; }

    public int branch { get; set; }

    public short transtype { get; set; }

    public short doctype { get; set; }

    public short pos_id { get; set; }

    public int invoiceno { get; set; }

    public DateTime invoicedate { get; set; }

    public short? section { get; set; }

    public int? invoice_id { get; set; }

    public int? salesrep { get; set; }

    public int? cashierno { get; set; }

    public short? pricetype { get; set; }

    public short? paytype { get; set; }

    public short? customertype { get; set; }

    public int? customerno { get; set; }

    public string a_customername { get; set; }

    public string l_customername { get; set; }

    public DateTime? arrival_date { get; set; }

    public string customerid { get; set; }

    public string issue_org { get; set; }

    public DateTime? issue_date { get; set; }

    public short? country { get; set; }

    public decimal? totalvalue { get; set; }

    public decimal? parts { get; set; }

    public decimal? payedvalue { get; set; }

    public decimal? remainder { get; set; }

    public short? discounttype { get; set; }

    public decimal? discounts { get; set; }

    public short? status { get; set; }

    public short? payment { get; set; }

    public short? delivery { get; set; }

    public DateTime? delivery_date { get; set; }

    public decimal? review { get; set; }

    public DateTime? reviewdate { get; set; }

    public short? posting { get; set; }

    public DateTime? postingdate { get; set; }

    public int? userid { get; set; }

    public short? transid { get; set; }

    public DateTime? transdate { get; set; }

    public DateTime? pay_date { get; set; }

    public short group_no { get; set; }

    public short guide { get; set; }

    public string a_guidename { get; set; }

    public string l_guidename { get; set; }

    public decimal? collection_fees { get; set; }

    public string transtime { get; set; }

    public int? salesman { get; set; }

    public string salesdoc { get; set; }

    public int? deliveryman { get; set; }

    public short? reprint_count { get; set; }

    public decimal? rounding_value { get; set; }

    public string app_version { get; set; }

    public int? discount_no { get; set; }

    public string discount_info { get; set; }

    public string trans_log { get; set; }

    public string trans_info { get; set; }

    public string reasons { get; set; }

    public string receipt { get; set; }

    public decimal? invoice_code { get; set; }

    public short? is_delivery { get; set; }

    public short? is_loyalty { get; set; }

    public short? is_staff { get; set; }

    public long? flags { get; set; }

    public short? customer_type { get; set; }

    public string customer_card { get; set; }

    public short? item_line_count { get; set; }

    public short? payment_line_count { get; set; }

    public DateTime? start_time { get; set; }

    public DateTime? end_time { get; set; }

    public DateTime? sent_time { get; set; }

    public string note { get; set; }

    public int? authorized_by { get; set; }

    public int? recalled_on_pos_id { get; set; }

    public DateTime? recall_time { get; set; }

    public decimal? recall_invoice_code { get; set; }

    public short? is_offline { get; set; }

    public string linked_invoice_codes { get; set; }

    public int? invoice_target { get; set; }

    public short? is_installment { get; set; }

    public decimal? corresponding_value { get; set; }

    public int? fin_entry_no { get; set; }

    public DateTime? fin_entry_date { get; set; }

    public int? dispatch_branch { get; set; }

    public string dispatch_orders_csv { get; set; }

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
    }
}