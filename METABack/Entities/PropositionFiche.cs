using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class PropositionFiche
{
    public int CodePro { get; set; }

    public string? Codegouv { get; set; }

    public int? Annescol { get; set; }

    public DateTime? DatePro { get; set; }

    public string? CodeTypePro { get; set; }

    public string? CodeNatPro { get; set; }

    public string? Sujet { get; set; }

    public DateTime? Datecreation { get; set; }

    public string? Codeutil { get; set; }

    public DateTime? Datemodification { get; set; }

    public string? CodeutilM { get; set; }
}
