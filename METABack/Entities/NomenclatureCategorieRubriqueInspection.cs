using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureCategorieRubriqueInspection
{
    public string CodeCateRubrInsp { get; set; } = null!;

    public string LibeCateRubrInsp { get; set; } = null!;

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    /// <summary>
    /// Code type établissement
    /// </summary>
    public string? CodeTypeEtab { get; set; }

    public virtual NomenclatureTypeEtablissement? CodeTypeEtabNavigation { get; set; }

    public virtual ICollection<InspectionDeductionCategorieRubriqueInspection> InspectionDeductionCategorieRubriqueInspections { get; set; } = new List<InspectionDeductionCategorieRubriqueInspection>();

    public virtual ICollection<NomenclatureRubriqueInspection> NomenclatureRubriqueInspections { get; set; } = new List<NomenclatureRubriqueInspection>();

    public virtual ICollection<NomenclatureTypeInspection> CodeTypeInsps { get; set; } = new List<NomenclatureTypeInspection>();
}
