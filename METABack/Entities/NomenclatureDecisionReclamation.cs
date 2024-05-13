using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureDecisionReclamation
{
    /// <summary>
    /// Commune
    /// </summary>
    public string CodeReclDeci { get; set; } = null!;

    public string? LibeReclDeci { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
