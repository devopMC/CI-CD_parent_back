using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class SecuriteEntite
{
    public string Codeenti { get; set; } = null!;

    public string Libeenti { get; set; } = null!;

    public string Codepack { get; set; } = null!;

    public int? Coderangmenu { get; set; }

    public string? Uri { get; set; }

    public virtual SecuritePackage CodepackNavigation { get; set; } = null!;

    public virtual ICollection<SecuriteDroitaccesgroupe> SecuriteDroitaccesgroupes { get; set; } = new List<SecuriteDroitaccesgroupe>();

    public virtual ICollection<SecuriteDroitaccesutilisateur> SecuriteDroitaccesutilisateurs { get; set; } = new List<SecuriteDroitaccesutilisateur>();
}
