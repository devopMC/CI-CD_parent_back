using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureOrganisationPedagogique
{
    /// <summary>
    /// Commune
    /// </summary>
    public string CodeOrgaPeda { get; set; } = null!;

    public string LibeOrgaPeda { get; set; } = null!;

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    /// <summary>
    /// Code type établissement
    /// </summary>
    public string? CodeTypeEtab { get; set; }

    public virtual NomenclatureTypeEtablissement? CodeTypeEtabNavigation { get; set; }

    public virtual ICollection<EtablissementOrganisationPedagogique> EtablissementOrganisationPedagogiques { get; set; } = new List<EtablissementOrganisationPedagogique>();
}
