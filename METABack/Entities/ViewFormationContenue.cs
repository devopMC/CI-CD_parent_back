using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewFormationContenue
{
    public int AnneScol { get; set; }

    public string CodeEtab { get; set; } = null!;

    public string LibeEtab { get; set; } = null!;

    public string? CodeGouv { get; set; }

    public string? LibeTypeEtab { get; set; }

    public string? LibeDele { get; set; }

    public string? LibeGouv { get; set; }

    public string? LibeComm { get; set; }

    public string? LibeZone { get; set; }

    public string? LibeSect { get; set; }

    public string? LibeEtatEtab { get; set; }

    public string? LibeDist { get; set; }

    public string LibeTypeEtatEtab { get; set; } = null!;

    public string? NomPren { get; set; }

    public string? SujetForm { get; set; }

    public string? LibeTypeForm { get; set; }

    public DateTime? DateForm { get; set; }

    public string? LieuForm { get; set; }

    public string? Orga { get; set; }

    public double? PeriForm { get; set; }
}
