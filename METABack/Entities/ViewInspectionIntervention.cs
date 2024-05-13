using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewInspectionIntervention
{
    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string CodeInterv { get; set; } = null!;

    public string? LibeInterv { get; set; }

    public string CodeTypeInterv { get; set; } = null!;

    public string? LibeTypeInterv { get; set; }

    public string? Observation { get; set; }
}
