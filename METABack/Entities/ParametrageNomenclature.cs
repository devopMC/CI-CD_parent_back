using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ParametrageNomenclature
{
    public int NumeNome { get; set; }

    public string? NomTable { get; set; }

    public string? LibeNome { get; set; }

    public string? CodeEnti { get; set; }

    public bool? Acti { get; set; }

    public string? CodeGrou { get; set; }

    public int? OrdrAffi { get; set; }

    public string? SpDelete { get; set; }

    public virtual ICollection<ParametrageColumn> ParametrageColumns { get; set; } = new List<ParametrageColumn>();
}
