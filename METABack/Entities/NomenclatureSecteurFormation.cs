using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureSecteurFormation
{
    public string CodeSecFor { get; set; } = null!;

    public string? LibeSecFor { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
