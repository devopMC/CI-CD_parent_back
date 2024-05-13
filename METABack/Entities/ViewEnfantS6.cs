using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewEnfantS6
{
    public string CodeTypeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string? LibeGouv { get; set; }

    public string CodeGouv { get; set; } = null!;

    public string? LibeDele { get; set; }

    public int? OrdrG { get; set; }

    public int? OrdrD { get; set; }

    public int? NombMasc { get; set; }

    public int? NombFemi { get; set; }

    public int? TotalEleve { get; set; }

    public int? NombreEtab { get; set; }

    public int? NombreP { get; set; }
}
