using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class InspectionDeductionCategorieRubriqueInspection
{
    public int NumeVisiInsp { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string CodeCateRubrInsp { get; set; } = null!;

    public string? Dedu { get; set; }

    public virtual NomenclatureCategorieRubriqueInspection CodeCateRubrInspNavigation { get; set; } = null!;

    public virtual InspectionVisiteInspection InspectionVisiteInspection { get; set; } = null!;
}
