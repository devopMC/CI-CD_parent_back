using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewNomenclatureRubriqueInspection
{
    public string CodeRubrInsp { get; set; } = null!;

    public string LibeRubrInsp { get; set; } = null!;

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public string CodeCateRubrInsp { get; set; } = null!;

    public string LibeCateRubrInsp { get; set; } = null!;
}
