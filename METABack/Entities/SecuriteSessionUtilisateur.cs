using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class SecuriteSessionUtilisateur
{
    public string CodeUtil { get; set; } = null!;

    public DateTime? DateCurrSess { get; set; }

    public DateTime? DateDebuLastSess { get; set; }

    public DateTime? DateFinLastSess { get; set; }

    public string? IpAdre { get; set; }

    public string? LastIpAdre { get; set; }

    public virtual SecuriteUtilisateur CodeUtilNavigation { get; set; } = null!;
}
