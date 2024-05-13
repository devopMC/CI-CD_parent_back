using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewRepartitionClub
{
    public string Codeetab1 { get; set; } = null!;

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

    public int? Nbseance { get; set; }

    public string? LibeClub { get; set; }

    public string? LibeEtatEtab { get; set; }

    public string? NomClub { get; set; }

    public string LibeTypeEtatEtab { get; set; } = null!;
}
