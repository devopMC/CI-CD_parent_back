using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class InspectionConstatation
{
    public int NumeVisiInsp { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string CodeRubrInsp { get; set; } = null!;

    public string CodeCons { get; set; } = null!;

    public string? Obse { get; set; }

    public virtual NomenclatureRubriqueInspection CodeRubrInspNavigation { get; set; } = null!;

    public virtual InspectionVisiteInspection InspectionVisiteInspection { get; set; } = null!;
}
