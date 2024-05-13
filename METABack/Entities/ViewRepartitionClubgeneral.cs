using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewRepartitionClubgeneral
{
    public string? CodeEtab1 { get; set; }

    public string? CodeGouv { get; set; }

    public int AnneScol { get; set; }

    public string? LibeDele { get; set; }

    public string? LibeGouv { get; set; }

    public string? LibeDist { get; set; }

    public string LibeEtab { get; set; } = null!;

    public string? LibeTypeEtab { get; set; }

    public string? LibeZone { get; set; }

    public string? LibeComm { get; set; }

    public string? LibeSect { get; set; }

    public string CodeEtab { get; set; } = null!;

    public string? PrixClub { get; set; }

    public int? NbInscrit { get; set; }

    public string? LibeEtatEtab { get; set; }

    public string LibeTypeEtatEtab { get; set; } = null!;
}
