using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class SecuriteTypeoperationtrace
{
    public string Codetypeopertrac { get; set; } = null!;

    public string Libetypeopertrac { get; set; } = null!;

    public string? Obse { get; set; }

    public virtual ICollection<SecuriteTraceutilisateur> SecuriteTraceutilisateurs { get; set; } = new List<SecuriteTraceutilisateur>();
}
