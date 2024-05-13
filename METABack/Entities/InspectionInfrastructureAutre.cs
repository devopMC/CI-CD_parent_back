using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class InspectionInfrastructureAutre
{
    public int NumeVisiInsp { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public bool? Checked { get; set; }

    public string CodetypeInfra { get; set; } = null!;

    public string? LibeInfrastrcture { get; set; }

    public string Lbchecked { get; set; } = null!;
}
