using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewInspectionClub
{
    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string CodeTypeClub { get; set; } = null!;

    public string? LibeClub { get; set; }

    public string? PrixClub { get; set; }

    public int? NbInscrit { get; set; }

    public int? Nbseance { get; set; }

    public string? NomClub { get; set; }
}
