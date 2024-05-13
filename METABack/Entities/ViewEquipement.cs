using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewEquipement
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

    public int? Nomb { get; set; }

    public bool? ConfCara { get; set; }

    public bool? Disp { get; set; }

    public string? Obse { get; set; }

    public string? LibeEqui { get; set; }

    public string? LibeTypeEqui { get; set; }

    public string? LibeEtatEtab { get; set; }

    public string LibeTypeEtatEtab { get; set; } = null!;
}
