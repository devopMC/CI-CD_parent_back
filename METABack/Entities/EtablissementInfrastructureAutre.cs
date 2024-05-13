using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class EtablissementInfrastructureAutre
{
    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string CodetypeInfra { get; set; } = null!;

    public bool? Checked { get; set; }

    public virtual NomenclatureInfrastrcture CodetypeInfraNavigation { get; set; } = null!;

    public virtual EtablissementFicheEtablissement EtablissementFicheEtablissement { get; set; } = null!;
}
