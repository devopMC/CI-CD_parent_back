using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureNaturePere
{
    public string CodeNaturePere { get; set; } = null!;

    public string? LibeNaturePere { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
