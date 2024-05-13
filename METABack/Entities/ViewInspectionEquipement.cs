using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewInspectionEquipement
{
    public long? NumeEqui { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string? LibeTypeEqui { get; set; }

    public bool ConfCara { get; set; }

    public bool Disp { get; set; }

    public string? Obse { get; set; }
}
