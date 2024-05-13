using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewEnfantS4
{
    public string CodeTypeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string? LibeGouv { get; set; }

    public string CodeGouv { get; set; } = null!;

    public string? LibeDele { get; set; }

    public string CodeSect { get; set; } = null!;

    public string? LibeSect { get; set; }

    public int? OrdrG { get; set; }

    public int? OrdrD { get; set; }

    public int? OrdrS { get; set; }

    public int? TotalEleve { get; set; }

    public int? TotalPersonnel { get; set; }

    public double? Encardement { get; set; }

    public double? EncardementD { get; set; }

    public double? EncardementG { get; set; }
}
