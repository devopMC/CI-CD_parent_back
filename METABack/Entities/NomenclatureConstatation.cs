using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureConstatation
{
    public string CodeCons { get; set; } = null!;

    public string? LibeCons { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<NomenclatureRubriqueInspection> CodeRubrInsps { get; set; } = new List<NomenclatureRubriqueInspection>();
}
