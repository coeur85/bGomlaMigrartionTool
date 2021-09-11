using System;

namespace BgFBG_MergeTool.Models.Accounting.Enitiy
{
    public class AccTrnHedEnitiyModel
    {

        public short company { get; set; }

        public short docregion { get; set; }

        public int location { get; set; }

        public short journal_type { get; set; }

        public short doctype { get; set; }

        public int docno { get; set; }

        public DateTime docdate { get; set; }

        public decimal? orignaldoc_no { get; set; }

        public DateTime? orignaldoc_date { get; set; }

        public short currency { get; set; }

        public decimal currencyprice { get; set; }

        public string notes { get; set; }

        public int? userid { get; set; }

        public DateTime? transdate { get; set; }

        public decimal docpost { get; set; }

        public int? post_userid { get; set; }

        public DateTime? post_transdate { get; set; }

        public short? review_flag { get; set; }

        public DateTime? review_date { get; set; }

        public short? re_evaluate_flag { get; set; }

        public DateTime? re_evaluate_date { get; set; }

        public decimal? price { get; set; }

        public DateTime? last_modified_time { get; set; }

    }
}