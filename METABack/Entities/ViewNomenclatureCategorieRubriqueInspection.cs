using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewNomenclatureCategorieRubriqueInspection
{
    public string CodeCateRubrInsp { get; set; } = null!;

    public string? LibeCateRubrInsp { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public string? CodeTypeEtab { get; set; }
}
