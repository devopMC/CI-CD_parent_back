using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureCercle
{
    public string CodeCerc { get; set; } = null!;

    public string? LibeCerc { get; set; }

    public string? CodeGouv { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
