using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureEtatPsycologique
{
    public string CodeEtatPsyc { get; set; } = null!;

    public string LibeEtatPsyc { get; set; } = null!;

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<EleveRepartitionEtatPsycologique> EleveRepartitionEtatPsycologiques { get; set; } = new List<EleveRepartitionEtatPsycologique>();
}
