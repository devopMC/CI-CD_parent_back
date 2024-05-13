using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureClub
{
    public string CodeClub { get; set; } = null!;

    public string? LibeClub { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
