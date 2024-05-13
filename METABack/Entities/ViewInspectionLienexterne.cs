using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewInspectionLienexterne
{
    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string CodeLienExterne { get; set; } = null!;

    public string? LibeLienExterne { get; set; }

    public string? Observation { get; set; }
}
