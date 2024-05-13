using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewRapportPassation
{
    public long? RowNumber { get; set; }

    public int CodePas { get; set; }

    public string? Codegouv { get; set; }

    public int? Annescol { get; set; }

    public DateTime? DatePas { get; set; }

    public string? EtabPas { get; set; }

    public string? Adirecteur { get; set; }

    public string? Arefrence { get; set; }

    public string? Directeur { get; set; }

    public string? Refrence { get; set; }

    public DateTime? Daterapport { get; set; }

    public string? Codeutilrapport { get; set; }

    public string? ActivitePas { get; set; }

    public string? Observation { get; set; }

    public DateTime? Datecreation { get; set; }

    public string? Codeutil { get; set; }

    public DateTime? Datemodification { get; set; }

    public string? CodeutilM { get; set; }

    public string? LibeGouv { get; set; }

    public string? Participant { get; set; }
}
