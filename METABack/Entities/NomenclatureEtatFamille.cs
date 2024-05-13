using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureEtatFamille
{
    public string CodeEtatFam { get; set; } = null!;

    public string? LibeEtatFam { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
