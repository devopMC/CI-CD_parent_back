using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewInspectionOrganisationPedagogique
{
    public int NumeVisiInsp { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string LibeOrgaPeda { get; set; } = null!;

    public bool Disp { get; set; }

    public bool Ajour { get; set; }
}
