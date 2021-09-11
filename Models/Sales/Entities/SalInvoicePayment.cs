using System;

namespace BgFBG_MergeTool.Models.Sales.Entities
{
    public class SalInvoicePayment
    {

        public int branch { get; set; }

        public short transtype { get; set; }

        public short doctype { get; set; }

        public int invoiceno { get; set; }

        public DateTime invoicedate { get; set; }

        public short pos_id { get; set; }

        public int cashierno { get; set; }

        public short tender_type { get; set; }

        public decimal? tender_amount { get; set; }

        public decimal? collection_fees { get; set; }

        public decimal? trans_total { get; set; }

        public short currency { get; set; }

        public decimal? exchange_rate { get; set; }

        public decimal? paid { get; set; }

        public decimal? change { get; set; }

        public short? credit_card_type { get; set; }

        public string credit_card_no { get; set; }

        public DateTime? working_date { get; set; }

        public DateTime? actual_date { get; set; }

        public string bank { get; set; }

        public string cheque_no { get; set; }

        public DateTime? due_date { get; set; }

        public decimal? commission { get; set; }

        public decimal? bank_commission { get; set; }

        public short? group_no { get; set; }

        public short? guide { get; set; }

        public int? customerno { get; set; }

        public short? planned_no { get; set; }

        public short? actual_no { get; set; }

        public string transtime { get; set; }

        public string payment_info { get; set; }

        public int? bank_id { get; set; }

        public string bank_name { get; set; }

        public int? other_payment_type { get; set; }

        public decimal? invoice_code { get; set; }

        public decimal? invoice_payment_code { get; set; }

        public long? flags { get; set; }

        public DateTime? entry_time { get; set; }

        public string note { get; set; }

        public int? authorized_by { get; set; }

        public string authorization_code { get; set; }

        public int? payment_card_id { get; set; }

        public string payment_card_serial { get; set; }

        public string doc_no { get; set; }

        public string doc_data { get; set; }

        public int? coupon_type { get; set; }

        public string terminal_id { get; set; }

        public short? registration_way { get; set; }

        public short? doc_registration_way { get; set; }

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