using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewInspectionOrganisationAdministrative
{
    public int NumeVisiInsp { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string LibeOrgaAdmi { get; set; } = null!;

    public bool Disp { get; set; }

    public bool Ajour { get; set; }
}
