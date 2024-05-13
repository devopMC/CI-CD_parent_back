using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureNiveauFormation
{
    public string CodeNivFor { get; set; } = null!;

    public string? LibeNivFor { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
