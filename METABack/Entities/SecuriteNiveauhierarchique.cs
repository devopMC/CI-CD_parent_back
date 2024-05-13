using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class SecuriteNiveauhierarchique
{
    public string Codenivehier { get; set; } = null!;

    public string Libenivehier { get; set; } = null!;

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<SecuriteUtilisateur> SecuriteUtilisateurs { get; set; } = new List<SecuriteUtilisateur>();
}
