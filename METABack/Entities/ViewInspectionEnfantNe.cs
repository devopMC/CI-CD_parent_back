using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewInspectionEnfantNe
{
    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public int Idenfant { get; set; }

    public string? Nomprenom { get; set; }

    public string? DateNais { get; set; }

    public string? Nompere { get; set; }

    public string? NumTel { get; set; }

    public string? Dateinscrit { get; set; }
}
