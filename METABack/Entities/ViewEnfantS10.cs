using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewEnfantS10
{
    public int? Annescol { get; set; }

    public string? LibeTypeEtab { get; set; }

    public string? Methode { get; set; }

    public string? TypeEtablissement { get; set; }

    public string? TypeSign { get; set; }

    public string? LibeGouv { get; set; }

    public string CodeGouv { get; set; } = null!;

    public int? OrdrG { get; set; }

    public int? Nombre { get; set; }
}
