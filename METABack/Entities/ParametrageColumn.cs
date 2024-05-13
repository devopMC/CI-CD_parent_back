using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class ParametrageColumn
{
    public int NumeNome { get; set; }

    public int NumeColu { get; set; }

    public string? ColuName { get; set; }

    public bool? ForeKeys { get; set; }

    public string? NomTable { get; set; }

    public string? LibeNome { get; set; }

    public string? CodeEnti { get; set; }

    public string? TypeRela { get; set; }

    public string? LibeColu { get; set; }

    public virtual ParametrageNomenclature NumeNomeNavigation { get; set; } = null!;
}
