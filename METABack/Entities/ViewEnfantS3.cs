using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewEnfantS3
{
    public string CodeTypeEtab { get; set; } = null!;

    public int? AnneScol { get; set; }

    public string? LibeGouv { get; set; }

    public string? CodeGouv { get; set; }

    public string? LibeDele { get; set; }

    public int? OrdrG { get; set; }

    public int? OrdrD { get; set; }

    public int? OrdrS { get; set; }

    public string? CodeDele { get; set; }

    public string? LibeSect { get; set; }

    public string? LibeTypePrisChar { get; set; }

    public int? Nombre { get; set; }
}
