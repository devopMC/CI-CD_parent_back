using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class SecuriteGroupeutilisateur
{
    public string Codegrouutil { get; set; } = null!;

    public string Libegrouutil { get; set; } = null!;

    public string? Obse { get; set; }

    public string? CodeGrouUtilPare { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<SecuriteDroitaccesgroupe> SecuriteDroitaccesgroupes { get; set; } = new List<SecuriteDroitaccesgroupe>();

    public virtual ICollection<SecuriteUtilisateur> SecuriteUtilisateurs { get; set; } = new List<SecuriteUtilisateur>();
}
