using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureEtatSignalisation
{
    public string CodeEtatSignalisation { get; set; } = null!;

    public string? LibeEtatSignalisation { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
