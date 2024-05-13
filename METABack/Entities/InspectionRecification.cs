using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class InspectionRecification
{
    public int NumeVisiInsp { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string CodeRect { get; set; } = null!;

    public bool Etat { get; set; }

    public virtual NomenclatureRectification CodeRectNavigation { get; set; } = null!;

    public virtual InspectionVisiteInspection InspectionVisiteInspection { get; set; } = null!;
}
