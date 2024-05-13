using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewProposition
{
    public int CodePro { get; set; }

    public string? Codegouv { get; set; }

    public int? AnneScol { get; set; }

    public DateTime? DatePro { get; set; }

    public string? CodeTypePro { get; set; }

    public string? CodeNatPro { get; set; }

    public string? Sujet { get; set; }

    public DateTime? Datecreation { get; set; }

    public string? Codeutil { get; set; }

    public DateTime? Datemodification { get; set; }

    public string? CodeutilM { get; set; }

    public string? Libegouv { get; set; }

    public string? Nomprenutil { get; set; }

    public string? LibetypePro { get; set; }

    public string? LibeNatPro { get; set; }

    public string? Moisproposition { get; set; }
}
