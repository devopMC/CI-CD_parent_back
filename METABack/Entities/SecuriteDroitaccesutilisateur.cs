using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class SecuriteDroitaccesutilisateur
{
    public string Codeenti { get; set; } = null!;

    public string Codeutil { get; set; } = null!;

    public bool DroiAcce { get; set; }

    public virtual SecuriteEntite CodeentiNavigation { get; set; } = null!;

    public virtual SecuriteUtilisateur CodeutilNavigation { get; set; } = null!;
}
