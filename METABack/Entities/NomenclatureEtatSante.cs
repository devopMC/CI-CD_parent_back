using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureEtatSante
{
    public string CodeEtatSant { get; set; } = null!;

    public string LibeEtatSant { get; set; } = null!;

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<EleveRepartitionEtatSante> EleveRepartitionEtatSantes { get; set; } = new List<EleveRepartitionEtatSante>();
}
