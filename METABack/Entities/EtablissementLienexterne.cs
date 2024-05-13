using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class EtablissementLienexterne
{
    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string CodeLienExterne { get; set; } = null!;

    public bool? Checked { get; set; }

    public string? Observation { get; set; }
}
