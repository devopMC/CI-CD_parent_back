using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureLienExterne
{
    public string CodeLienExterne { get; set; } = null!;

    public string? LibeLienExterne { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
