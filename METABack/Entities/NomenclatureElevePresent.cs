using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureElevePresent
{
    public string CodeElevePresent { get; set; } = null!;

    public string? LibeElevePresent { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
