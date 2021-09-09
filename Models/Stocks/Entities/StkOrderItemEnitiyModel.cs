using System;

namespace BgFBG_MergeTool.Models.Stocks.Entities
{
    public class StkOrderItemEnitiyModel
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

        public short itemtype { get; set; }

        public string itemean { get; set; }

        public string barcode { get; set; }

        public short unit { get; set; }

        public DateTime expirydate { get; set; }

        public int transno { get; set; }

        public short? peices { get; set; }

        public decimal? item_qty { get; set; }

        public int? item_count { get; set; }

        public decimal? item_cost { get; set; }

        public decimal? actual_qty { get; set; }

        public int? actual_count { get; set; }

        public decimal? actual_cost { get; set; }

        public decimal? costprice { get; set; }

        public string remark { get; set; }

        public int? userid { get; set; }

        public short? transid { get; set; }

        public DateTime? transdate { get; set; }

        public short? collection { get; set; }

        public decimal free_qty { get; set; }

        public short posting { get; set; }

        public decimal? Order_code { get; set; }

        public int? Sites { get; set; }

        public short? Itemclass { get; set; }

        public short? Itemsection { get; set; }

        public short? Itemgroup { get; set; }

        public short? Department { get; set; }

        public short? Tax_vat_id { get; set; }

        public decimal? Tax_vat_value { get; set; }

        public short? Tax_add { get; set; }

        public decimal? Tax_add_value { get; set; }

        public decimal? Cost_price_ex_tax { get; set; }

        public short? Entered_from { get; set; }

        public short? Entered_type { get; set; }

        public DateTime? Entered_time { get; set; }

        public decimal? Onhand_qty { get; set; }

        public decimal? Retailprice { get; set; }

        public decimal? Wholeprice { get; set; }

        public short? Bonus_type { get; set; }

        public short? Discountype { get; set; }

        public decimal? Discountpercentage { get; set; }

        public decimal? Discountvalue { get; set; }

        public decimal? Net_cost_price { get; set; }

        public string Notes { get; set; }

        public int? Reasonid { get; set; }

        public short? Pos_id { get; set; }

        public decimal? Temperature_degree { get; set; }

        public string Reserved1 { get; set; }

        public string Reserved2 { get; set; }

        public string Reserved3 { get; set; }

        public decimal? Reserved4 { get; set; }

        public decimal? Reserved5 { get; set; }

        public DateTime? Reserved6 { get; set; }

        public System.DateTime? Reserved7 { get; set; }

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