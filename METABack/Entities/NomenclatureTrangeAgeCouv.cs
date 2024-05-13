using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureTrangeAgeCouv
{
    public string CodeTranCouv { get; set; } = null!;

    public string? LibeTranCouv { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
