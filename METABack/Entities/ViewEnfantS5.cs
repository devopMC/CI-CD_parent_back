using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewEnfantS5
{
    public int AnneScol { get; set; }

    public string CodeTypeEtab { get; set; } = null!;

    public string? LibeGouv { get; set; }

    public string CodeGouv { get; set; } = null!;

    public string? LibeDele { get; set; }

    public int? OrdrG { get; set; }

    public int? OrdrD { get; set; }

    public int? OrdrS { get; set; }

    public string? CodeDele { get; set; }

    public string? Libesect { get; set; }

    public int? Nombre { get; set; }
}
