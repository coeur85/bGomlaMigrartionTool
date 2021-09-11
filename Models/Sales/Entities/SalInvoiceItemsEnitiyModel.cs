using System;

namespace BgFBG_MergeTool.Models.Sales.Entities
{
    public class SalInvoiceItemsEnitiyModel
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

    public int transno { get; set; }

    public string barcode { get; set; }

    public string itemean { get; set; }

    public short? unit { get; set; }

    public short? peices { get; set; }

    public short? itemtype { get; set; }

    public DateTime? expirydate { get; set; }

    public decimal qty { get; set; }

    public decimal? consignment { get; set; }

    public decimal unitprice { get; set; }

    public decimal vatrate { get; set; }

    public decimal totalvalue { get; set; }

    public decimal? costprice { get; set; }

    public short? discounttype { get; set; }

    public decimal? discountvalue { get; set; }

    public int? transportation { get; set; }

    public decimal? transport_value { get; set; }

    public short? status { get; set; }

    public short? division { get; set; }

    public short? itemcount { get; set; }

    public int? sales_order_no { get; set; }

    public int? salesman_no { get; set; }

    public short? gift { get; set; }

    public short? category { get; set; }

    public string serial_no { get; set; }

    public int? salesman { get; set; }

    public string salesdoc { get; set; }

    public short? price_overridden { get; set; }

    public decimal? original_unitprice { get; set; }

    public int? discount_no { get; set; }

    public string discount_info { get; set; }

    public string item_log { get; set; }

    public string item_info { get; set; }

    public string reasons { get; set; }

    public decimal? costprice_discount_value { get; set; }

    public decimal? invoice_code { get; set; }

    public decimal? invoice_item_code { get; set; }

    public int? tax_id { get; set; }

    public decimal? tax_rate { get; set; }

    public decimal? tax_value { get; set; }

    public int? item_class { get; set; }

    public int? item_section { get; set; }

    public int? item_group { get; set; }

    public int? item_department { get; set; }

    public short? order_on_receipt { get; set; }

    public long? flags { get; set; }

    public short? item_price_type { get; set; }

    public DateTime? entry_time { get; set; }

    public int? item_supplier { get; set; }

    public string note { get; set; }

    public int? authorized_by { get; set; }

    public int? customer_no { get; set; }

    public int? coupon_no { get; set; }

    public string coupon_data { get; set; }

    public short? coupon_usage_count { get; set; }

    public decimal? returned_qty { get; set; }

    public string return_invoice_codes { get; set; }

    public short? registration_way { get; set; }

    public int? cashier_no { get; set; }

    public int? invoice_doctype { get; set; }

    public short? print_on_receipt { get; set; }

    public short? auto_added { get; set; }

    public short? is_package_component { get; set; }

    public string linked_invoice_item_codes { get; set; }

    public short? is_delivery { get; set; }

    public short? is_loyalty { get; set; }

    public short? is_staff { get; set; }

    public decimal? corresponding_value { get; set; }

    public short? is_gift { get; set; }

    public string item_data { get; set; }

    public short? is_service { get; set; }

    public short? is_serialized { get; set; }

    public short? discount_source { get; set; }

    public decimal? discount_share1 { get; set; }

    public decimal? discount_share2 { get; set; }

    public decimal? discount_share3 { get; set; }

    public decimal? discount_share4 { get; set; }

    public decimal? discount_share5 { get; set; }

    public int? discount_distribution_code { get; set; }

    public decimal? added_value { get; set; }

    public short? added_value_source { get; set; }

    public short? discount_disabled { get; set; }

    public short? is_installment { get; set; }

    public decimal? tax_base_price { get; set; }

    public decimal? taxed_totalvalue { get; set; }

    public short? has_distributed_discount { get; set; }

    public decimal? discounted_qty { get; set; }

    public int? dispatch_branch { get; set; }

    public string dispatch_orders_csv { get; set; }

    public decimal? item_balance { get; set; }

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