using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureStatutSignalisation
{
    public string CodeStatutSignalisation { get; set; } = null!;

    public string? LibeStatutSignalisation { get; set; }

    public string CodeEtatSignalisation { get; set; } = null!;

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
