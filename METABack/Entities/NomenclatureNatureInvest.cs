using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureNatureInvest
{
    public string CodeNatInv { get; set; } = null!;

    public string? LibeNatInv { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
