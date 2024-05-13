using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureNatureAnomalie
{
    public string? CodeNatureAnomalie { get; set; }

    public string? LibeNatureAnomalie { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
