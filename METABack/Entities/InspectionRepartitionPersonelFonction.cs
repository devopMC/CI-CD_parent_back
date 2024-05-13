using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class InspectionRepartitionPersonelFonction
{
    public int NumeVisiInsp { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string LibeFonc { get; set; } = null!;

    public int? NombMasc { get; set; }

    public int? NombFemi { get; set; }

    public int? NombTota { get; set; }

    public virtual InspectionVisiteInspection InspectionVisiteInspection { get; set; } = null!;
}
