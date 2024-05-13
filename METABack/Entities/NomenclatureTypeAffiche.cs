using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureTypeAffiche
{
    public string CodeTypeAffiche { get; set; } = null!;

    public string? LibeTypeAffiche { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
