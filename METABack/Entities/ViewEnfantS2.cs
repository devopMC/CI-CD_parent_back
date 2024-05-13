using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewEnfantS2
{
    public string CodeTypeEtab { get; set; } = null!;

    public string? CodeDele { get; set; }

    public string CodeSect { get; set; } = null!;

    public int AnneScol { get; set; }

    public string? LibeGouv { get; set; }

    public string CodeGouv { get; set; } = null!;

    public string? LibeDele { get; set; }

    public string? LibeGenr { get; set; }

    public string Genre { get; set; } = null!;

    public int? OrdrG { get; set; }

    public int? OrdrD { get; set; }

    public int? OrdrS { get; set; }

    public string? LibeSect { get; set; }

    public int? Nombre { get; set; }

    public double? Couverture { get; set; }
}
