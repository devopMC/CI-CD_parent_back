using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class InspectionEquipement
{
    public int NumeVisiInsp { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public long NumeEqui { get; set; }

    public string? LibeTypeEqui { get; set; }

    public bool? ConfCara { get; set; }

    public bool? Disp { get; set; }

    public string? Obse { get; set; }

    public virtual InspectionVisiteInspection InspectionVisiteInspection { get; set; } = null!;
}
