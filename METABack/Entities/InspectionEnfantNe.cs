using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class InspectionEnfantNe
{
    public int NumeVisiInsp { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public int Idenfant { get; set; }

    public string? Nomprenom { get; set; }

    public string? DateNais { get; set; }

    public string? Nompere { get; set; }

    public string? NumTel { get; set; }

    public string? Dateinscrit { get; set; }
}
