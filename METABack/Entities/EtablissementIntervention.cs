using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class EtablissementIntervention
{
    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string CodeInterv { get; set; } = null!;

    public bool? Checked { get; set; }

    public string? Observation { get; set; }

    public virtual NomenclatureInterventionnecessaire CodeIntervNavigation { get; set; } = null!;

    public virtual EtablissementFicheEtablissement EtablissementFicheEtablissement { get; set; } = null!;
}
