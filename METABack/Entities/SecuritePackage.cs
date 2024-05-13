using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class SecuritePackage
{
    public string Codepack { get; set; } = null!;

    public string Libepack { get; set; } = null!;

    public int? Ordraffi { get; set; }

    public string? Uri { get; set; }

    public bool? IsVisi { get; set; }

    public virtual ICollection<SecuriteEntite> SecuriteEntites { get; set; } = new List<SecuriteEntite>();
}
