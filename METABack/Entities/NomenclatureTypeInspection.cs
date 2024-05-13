using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureTypeInspection
{
    public string CodeTypeInsp { get; set; } = null!;

    public string? LibeTypeInsp { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<InspectionVisiteInspection> InspectionVisiteInspections { get; set; } = new List<InspectionVisiteInspection>();

    public virtual ICollection<NomenclatureCategorieRubriqueInspection> CodeCateRubrInsps { get; set; } = new List<NomenclatureCategorieRubriqueInspection>();
}
