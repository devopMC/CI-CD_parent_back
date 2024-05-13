using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class SecuriteDroitaccesgroupe
{
    public string Codegrouutil { get; set; } = null!;

    public string Codeenti { get; set; } = null!;

    public bool DroiSele { get; set; }

    public bool DroiUpda { get; set; }

    public bool DroiDele { get; set; }

    public virtual SecuriteEntite CodeentiNavigation { get; set; } = null!;

    public virtual SecuriteGroupeutilisateur CodegrouutilNavigation { get; set; } = null!;
}
