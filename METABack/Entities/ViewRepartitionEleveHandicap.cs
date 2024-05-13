using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewRepartitionEleveHandicap
{
    public string CodeEtab { get; set; } = null!;

    public int NumeElev { get; set; }

    public string? CodeGouv { get; set; }

    public int AnneScol { get; set; }

    public string? LibeDele { get; set; }

    public string? LibeGouv { get; set; }

    public string? LibeDist { get; set; }

    public string LibeEtab { get; set; } = null!;

    public string? LibeTypeEtab { get; set; }

    public string? LibeZone { get; set; }

    public string? LibeComm { get; set; }

    public string? LibeDegrHand { get; set; }

    public string? LibeInteHand { get; set; }

    public string? LibeTypeHand { get; set; }

    public DateTime? DateNais { get; set; }

    public bool? SuiviCentSpec { get; set; }

    public string? LibeGenr { get; set; }

    public string? LibeSect { get; set; }

    public string? LibeEtatEtab { get; set; }

    public int? AnneNais { get; set; }

    public string LibeTypeEtatEtab { get; set; } = null!;
}
