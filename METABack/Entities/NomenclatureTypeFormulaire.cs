using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureTypeFormulaire
{
    public string CodeFormulaire { get; set; } = null!;

    public string? LibeFormulaire { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
