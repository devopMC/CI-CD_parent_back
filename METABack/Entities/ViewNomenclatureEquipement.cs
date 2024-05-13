using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewNomenclatureEquipement
{
    public string CodeEqui { get; set; } = null!;

    public string? LibeEqui { get; set; }

    public string? CaraEqui { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public string CodeTypeEqui { get; set; } = null!;

    public string? LibeTypeEqui { get; set; }
}
