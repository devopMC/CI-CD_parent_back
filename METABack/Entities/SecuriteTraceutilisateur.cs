using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class SecuriteTraceutilisateur
{
    public decimal Numetrac { get; set; }

    public string? Libetrac { get; set; }

    public string? Linktrac { get; set; }

    public string Codeutil { get; set; } = null!;

    public DateTime Datetrac { get; set; }

    public string Codetypeoper { get; set; } = null!;

    public string Codeenti { get; set; } = null!;

    public string Pkenti { get; set; } = null!;

    public virtual SecuriteTypeoperationtrace CodetypeoperNavigation { get; set; } = null!;

    public virtual SecuriteUtilisateur CodeutilNavigation { get; set; } = null!;
}
