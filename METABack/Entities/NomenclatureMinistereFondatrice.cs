using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureMinistereFondatrice
{
    public string CodeMiniFond { get; set; } = null!;

    public string LibeMiniFond { get; set; } = null!;

    public int OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
