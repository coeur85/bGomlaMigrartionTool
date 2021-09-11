using System;

namespace BgFBG_MergeTool.Models.Accounting.Enitiy
{
    public class AccTrnDetEnitiyModel
    {
            public short company { get; set; }

    public short docregion { get; set; }

    public int location { get; set; }

    public short journal_type { get; set; }

    public short doctype { get; set; }

    public int docno { get; set; }

    public DateTime docdate { get; set; }

    public short line_no { get; set; }

    public string refno { get; set; }

    public string ledger { get; set; }

    public int subledger { get; set; }

    public short region { get; set; }

    public int branch { get; set; }

    public short section { get; set; }

    public short expenses { get; set; }

    public decimal debit { get; set; }

    public decimal credit { get; set; }

    public decimal? localdebit { get; set; }

    public decimal? localcredit { get; set; }

    public short? currency { get; set; }

    public string notes { get; set; }

    public short? documenttype { get; set; }

    public decimal? documentno { get; set; }

    public DateTime? documentdate { get; set; }

    public short? recieptflag { get; set; }

    public int? subcost { get; set; }

    public DateTime? last_modified_time { get; set; }

    }
}