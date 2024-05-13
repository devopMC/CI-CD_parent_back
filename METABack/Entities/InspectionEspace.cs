using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class InspectionEspace
{
    public int NumeVisiInsp { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public int NumeEspa { get; set; }

    public string? LibeTypeEspa { get; set; }

    public double? Surf { get; set; }

    public double? Haut { get; set; }

    public string? Obse { get; set; }

    public int? ConfCara { get; set; }

    public virtual InspectionVisiteInspection InspectionVisiteInspection { get; set; } = null!;
}
