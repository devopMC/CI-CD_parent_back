using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureActivite
{
    public string Codeactivite { get; set; } = null!;

    public string? Libeactivite { get; set; }

    public int? Afficheeleve { get; set; }

    public int? Afficheniveau { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
