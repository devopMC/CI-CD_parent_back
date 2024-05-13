using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ParametrageRechercheMultiCritere
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Requ { get; set; } = null!;

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
