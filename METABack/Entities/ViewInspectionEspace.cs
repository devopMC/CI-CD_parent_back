using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewInspectionEspace
{
    public int NumeEspa { get; set; }

    public string? LibeTypeEspa { get; set; }

    public double? Surf { get; set; }

    public double? Haut { get; set; }

    public string? Obse { get; set; }

    public int? ConfCara { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }
}
