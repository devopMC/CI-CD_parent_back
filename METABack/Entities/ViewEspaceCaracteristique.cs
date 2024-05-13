using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewEspaceCaracteristique
{
    public string CodeEtab { get; set; } = null!;

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

    public string? LibeTypeEspa { get; set; }

    public double? Surf { get; set; }

    public double? Haut { get; set; }

    public string? Obse { get; set; }

    public int NumeEspa { get; set; }

    public string CodeCaraEspa { get; set; } = null!;

    public string? LibeCaraEspa { get; set; }

    public string ConfCara { get; set; } = null!;

    public string? LibeEtatEtab { get; set; }

    public string LibeTypeEtatEtab { get; set; } = null!;
}
