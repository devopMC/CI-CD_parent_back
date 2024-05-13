using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureEtatParent
{
    public string CodeEtatPare { get; set; } = null!;

    public string LibeEtatPare { get; set; } = null!;

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<EleveRepartitionEtatParent> EleveRepartitionEtatParents { get; set; } = new List<EleveRepartitionEtatParent>();
}
