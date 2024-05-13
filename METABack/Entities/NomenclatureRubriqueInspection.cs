using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureRubriqueInspection
{
    public string CodeRubrInsp { get; set; } = null!;

    public string LibeRubrInsp { get; set; } = null!;

    public string CodeCateRubrInsp { get; set; } = null!;

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual NomenclatureCategorieRubriqueInspection CodeCateRubrInspNavigation { get; set; } = null!;

    public virtual ICollection<InspectionConstatation> InspectionConstatations { get; set; } = new List<InspectionConstatation>();

    public virtual ICollection<NomenclatureConstatation> CodeCons { get; set; } = new List<NomenclatureConstatation>();
}
